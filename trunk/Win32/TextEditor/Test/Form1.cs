using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Test
{
	/// <summary>
	/// Descripci�n breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Pelsoft.Controls.TextCodeEditor.TextCodeEditor textCodeEditor1;
		/// <summary>
		/// Variable del dise�ador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Necesario para admitir el Dise�ador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar c�digo de constructor despu�s de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region C�digo generado por el Dise�ador de Windows Forms
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			this.textCodeEditor1 = new Pelsoft.Controls.TextCodeEditor.TextCodeEditor();
			this.SuspendLayout();
			// 
			// textCodeEditor1
			// 
			this.textCodeEditor1.BackColor = System.Drawing.Color.Silver;
			this.textCodeEditor1.Lenguaje = Pelsoft.Controls.TextCodeEditor.TextCodeEditor.TipoLenguaje.C64CHARP;
			this.textCodeEditor1.Location = new System.Drawing.Point(0, 0);
			this.textCodeEditor1.Name = "textCodeEditor1";
			this.textCodeEditor1.Size = new System.Drawing.Size(544, 336);
			this.textCodeEditor1.TabIndex = 0;
			this.textCodeEditor1.TitleText = "";
			this.textCodeEditor1.TitleVisible = true;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 358);
			this.Controls.Add(this.textCodeEditor1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicaci�n.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
