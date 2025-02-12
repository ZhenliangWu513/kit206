﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Model
{

    class Publication
    {

        private string doi;
        public string Doi
        {
            get { return doi; }
            set { doi = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private DateTime publicationDate;
        public DateTime PublicationDate
        {
            get { return publicationDate; }
            set { publicationDate = value; }
        }

        private PublicationType type;
        public PublicationType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string citeAs;
        public string CiteAs
        {
            get { return citeAs; }
            set { citeAs = value; }
        }

        private DateTime availabilityDate;
        public DateTime AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        public Publication()
        {
        }

        // Number of days since publication became available.
        // May be negative if publication is not yet available.
        public int age()
        {
            return (DateTime.Now - AvailabilityDate).Days;
        }
    }
}
