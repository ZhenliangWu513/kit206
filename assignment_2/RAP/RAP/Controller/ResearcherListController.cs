﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // Required for making the 'viewable' variables for manipulation
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RAP.Controller
{
    class ResearcherListController
    {

        /// ???
        public List<string> filters;

        // Constant researcher list
        private List<Model.Researcher> researchers;
        public List<Model.Researcher> Researchers { get; set; }

        // Observable researcher list
        // Modify to filter list, etc.
        private ObservableCollection<Model.Researcher> researcherList;
        public ObservableCollection<Model.Researcher> ResearcherList { get; set; }

        public ResearcherListController()
        {
            // Load all researchers from database when controller is created?
            // Not sure if this is the best idea.
            Researchers = Database.ResearcherAdapter.fetchResearcherList();
            loadResearcherList();

            //How to handle the publications for a researcher?
        }


        /// <summary>
        /// GetViewableList
        /// Returns the list of researchers for display
        /// </summary>
        public ObservableCollection<Model.Researcher> GetViewableList()
        {
            return ResearcherList;
        }

        // Title of currently occupied position
        public string currentjobTitle(Model.Researcher r)
        {
            if (r.GetType() == typeof(Model.Student))
                return "Student";
            else
                return r.Positions[0].jobTitle();
        }


        // Load cumulative publications for reasearcher.
        public List<Model.Publication> loadCumulativePublications()
        {
            return null;
        }

        /// Blake's Comment: Probably not necessary, as we use the adapter to fetch the research list
        /// Not removing for your opinion
        // Load basic details for all researchers.
        public ObservableCollection<Model.Researcher> loadResearcherList()
        {
            // Instantiate ResearcherList
            if (ResearcherList == null)
            {
                ResearcherList =
                    new ObservableCollection<Model.Researcher>(Researchers);
            }
            // Reset ResearcherList to match Researcher
            else
            {
                ResearcherList.Clear();
                foreach (Model.Researcher r in Researchers)
                {
                    ResearcherList.Add(r);
                }
            }

            return ResearcherList;
        }

        /// Blake's Comment: You've done this in the Researcher model
        // Format list of researchers to be of the form "firstName, lastName
        // (title)".
        public List<string> formatList()
        {
            return null;
        }

        // Update filters (employment status, first name partial match,
        // last name partial match) based on user input.
        public void updateFilters()
        {
        }

        /// Blake's Comment: Wouldn't we need two filters for the level and type?
        // Update researcher list to contain only those researchers with
        // details satisfying the current filters.
        public List<string> filterList()
        {
            return null;
        }

        /// Blake's Comment: Same as loadResearcher
        /// <returns></returns>
        // Load list of students a staff members is or has ever supervised.
        public List<string> loadSupervisions()
        {
            return null;
        }

        /// Blake's Comment: Now, you call something similar in PublicationAdapter (totalPublications)
        /// So, do we want this in publications, or here?
        // Calculate cumulatie publications per year for a given researcher.
        public Dictionary<DateTime, int> calculateCumulativePublications()
        {
            return null;
        }

        /// Blake's Comment: Same as loadResearcher
        // Load details of researcher.
        public Model.Researcher loadResearcher(string id)
        {
            Model.Researcher researcher = Database.ResearcherAdapter.fetchResearcherDetails(id);
            return researcher;
        }

        /// Blake's Comment: Same as loadResearcher
        // Load name of researcher.
        public string loadResearcherName()
        {
            return null;
        }
    }
}
