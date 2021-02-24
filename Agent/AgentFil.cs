﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace AgentAssignment
{
    public class AgentFil
    {
        string id;
        string codeName;
        string speciality;
        string assignment;

        public AgentFil()
        {
        }

        public AgentFil(string aId, string aName, string aSpeciality, string aAssignment)
        {
            id = aId;
            codeName = aName;
            speciality = aSpeciality;
            assignment = aAssignment;
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string CodeName
        {
            get
            {
                return codeName;
            }
            set
            {
                codeName = value;
            }
        }

        public string Speciality
        {
            get
            {
                return speciality;
            }
            set
            {
                speciality = value;
            }
        }

        public string Assignment
        {
            get
            {
                return assignment;
            }
            set
            {
                assignment = value;
            }
        }
    }
}