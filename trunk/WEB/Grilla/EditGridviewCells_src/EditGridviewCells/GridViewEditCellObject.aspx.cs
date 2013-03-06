using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class GridViewEditCellObject : System.Web.UI.Page
{
    /// <summary>
    /// There is a ButtonField column and the Id column
    /// therefore first edit cell index is 2
    /// </summary>
    private const int _firstEditCellIndex = 2;

    #region Page Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {           
            this.GridView1.DataBind();
        }

        if (this.GridView1.SelectedIndex > -1)
        {
            // Call UpdateRow on every postback
            this.GridView1.UpdateRow(this.GridView1.SelectedIndex, false);
        } 
    }

    #endregion

    #region GridView1

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // Get the LinkButton control in the first cell
            LinkButton _singleClickButton = (LinkButton)e.Row.Cells[0].Controls[0];
            // Get the javascript which is assigned to this LinkButton
            string _jsSingle = ClientScript.GetPostBackClientHyperlink(_singleClickButton, "");

            // If the page contains validator controls then call 
            // Page_ClientValidate before allowing a cell to be edited
            if (Page.Validators.Count > 0)
                _jsSingle = _jsSingle.Insert(11, "if(Page_ClientValidate())");

            // Add events to each editable cell
            for (int columnIndex = _firstEditCellIndex; columnIndex < e.Row.Cells.Count; columnIndex++)
            {
                // Add the column index as the event argument parameter
                string js = _jsSingle.Insert(_jsSingle.Length - 2, columnIndex.ToString());
                // Add this javascript to the onclick Attribute of the cell
                e.Row.Cells[columnIndex].Attributes["onclick"] = js;
                // Add a cursor style to the cells
                e.Row.Cells[columnIndex].Attributes["style"] += "cursor:pointer;cursor:hand;"; 
            }     
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridView _gridView = (GridView)sender;

        switch (e.CommandName)
        {
            case ("SingleClick"):
                // Get the row index
                int _rowIndex = int.Parse(e.CommandArgument.ToString());                
                // Parse the event argument (added in RowDataBound) to get the selected column index
                int _columnIndex = int.Parse(Request.Form["__EVENTARGUMENT"]);
                // Set the Gridview selected index
                _gridView.SelectedIndex = _rowIndex;
                // Bind the Gridview
                _gridView.DataBind();

                // Write out a history if the event
                this.Message.Text += "Single clicked GridView row at index " + _rowIndex.ToString() 
                    + " on column index " + _columnIndex + "<br />";

                // Get the display control for the selected cell and make it invisible
                Control _displayControl = _gridView.Rows[_rowIndex].Cells[_columnIndex].Controls[1]; 
                _displayControl.Visible = false;
                // Get the edit control for the selected cell and make it visible
                Control _editControl = _gridView.Rows[_rowIndex].Cells[_columnIndex].Controls[3];
                _editControl.Visible = true;
                // Clear the attributes from the selected cell to remove the click event
                _gridView.Rows[_rowIndex].Cells[_columnIndex].Attributes.Clear();

                // Set focus on the selected edit control
                ScriptManager.RegisterStartupScript(this, GetType(), "SetFocus",
                    "document.getElementById('" + _editControl.ClientID + "').focus();", true);
                // If the edit control is a dropdownlist set the
                // SelectedValue to the value of the display control
                if (_editControl is DropDownList && _displayControl is Label)
                {
                    ((DropDownList)_editControl).SelectedValue = ((Label)_displayControl).Text;
                }                 
                // If the edit control is a textbox then select the text
                if (_editControl is TextBox)
                {
                   ((TextBox)_editControl).Attributes.Add("onfocus", "this.select()");
                }

                break;
        }
    }

    /// <summary>
    /// A DataSource control normally takes the values  
    /// from the EditItemTemplate to populate the NewValues 
    /// collection when updating a GridView row.
    /// As the EditItemTemplate is not being used in this scenario 
    /// the NewValues collection must be populated programatically.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridView _gridView = (GridView)sender;
        string key = "";
        string value = "";

        // The keys for the NewValues collection
        string[] _columnKeys = new string[] { "Description", "AssignedTo", "Status" };

        if (e.RowIndex > -1)
        {
            // Loop though the columns
            for (int i = _firstEditCellIndex; i < _gridView.Columns.Count; i++)
            {
                // Get the controls in the cell
                Control _displayControl = _gridView.Rows[e.RowIndex].Cells[i].Controls[1];
                Control _editControl = _gridView.Rows[e.RowIndex].Cells[i].Controls[3];

                // Get the column key
                key = _columnKeys[i - _firstEditCellIndex];

                // If a cell in edit mode get the value of the edit control
                if (_editControl.Visible)
                { 
                    if (_editControl is TextBox)
                    {
                        value = ((TextBox)_editControl).Text;
                    }
                    else if (_editControl is DropDownList)
                    {
                        value = ((DropDownList)_editControl).SelectedValue;
                    }

                    // Add the key/value pair to the NewValues collection
                    e.NewValues.Add(key, value);
                }
                // else get the value of the display control
                else
                {
                    value = ((Label)_displayControl).Text.ToString();

                    // Add the key/value pair to the NewValues collection
                    e.NewValues.Add(key, value);
                }
            }
            // Clear the selected index to prevent 
            // another update on the next postback
            _gridView.SelectedIndex = -1;
        }
    }

    #endregion

    #region Render Override

    // Register the dynamically created client scripts
    protected override void Render(HtmlTextWriter writer)
    {
        // The client events for GridView1 were created in GridView1_RowDataBound
        foreach (GridViewRow r in GridView1.Rows)
        {
            if (r.RowType == DataControlRowType.DataRow)
            {
                for (int columnIndex = _firstEditCellIndex; columnIndex < r.Cells.Count; columnIndex++)
                {
                    Page.ClientScript.RegisterForEventValidation(r.UniqueID + "$ctl00", columnIndex.ToString());
                }
            }
        }
      
        base.Render(writer);
    }

    #endregion   
}
