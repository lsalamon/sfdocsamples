﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using Fwk.Bases;
using Health.BE;


namespace Health.Isvc.RetrivePatientAppoiments
{
    [Serializable]
    public class RetrivePatientAppoimentsReq : Fwk.Bases.Request<Params>
    {
        public RetrivePatientAppoimentsReq()
        {
            base.ServiceName = "RetrivePatientAppoimentsService";
        }
    }
    [XmlInclude(typeof(Params)), Serializable]
    public class Params : Fwk.Bases.Entity
    {
        public int PatientId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Status { get; set; }
    }


    [Serializable]
    public class RetrivePatientAppoimentsRes : Fwk.Bases.Response<Patient_Appointments_ViewList>
    {
        
    }

  
}
