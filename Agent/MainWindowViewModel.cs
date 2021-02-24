using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentAssignment;
using System.Runtime.CompilerServices;
using Prism.Commands;//Tilføjet
using Prism.Mvvm; //Tilføjet



                                                        /*BINDABLE BASE VERSION*/
/*------------------------------------------------------------------------------------------------------------------*/

///< summary >
///Tilføj en menu og en toolbar til Applikationen. Og implementer anvendelsen af commands i
///applikationen – brug DelegateCommand-klassen fra Prism til dette (installer Nuget pakken Prism.WPF).
///HJÆLP: Brug eksemplerne i CommandDemos som udgangspunkt for din implementering.
///Menuen opbygning:
///            File Agent
///            Exit Previous
///                 Next
///                 Add new
///                 Delete
///</ summary >



namespace Agent
{

    public class MainWindowViewModel : BindableBase
    {


        #region LIST


        ObservableCollection<AgentFil> agentsToList;

        public MainWindowViewModel()
        {
            agentsToList = new ObservableCollection<AgentFil>
                {
                    new AgentFil("002","Kai","Bad poems","Sit in dumpster for inspiration"),
                    new AgentFil("001","Takao","Teenage hormones","Go get Kai out from the dumpster")
                }; //Note: Skal være , og ikke ;
           
            CurrentAgent = agentsToList[0];
        }//Constructor


        public ObservableCollection<AgentFil> AgentFils
        {
            get
              {
                   return agentsToList;
              }
        }//List definition


        #endregion

        /*------------------------------------------------------------------------------------------------------------------*/


        #region CURRENTAGENT/INDEX

        AgentFil currentAgent = null; //Nulstillet
        
        public AgentFil CurrentAgent
        {
            get
            { 
                return currentAgent;
            }
            set
            {
                SetProperty(ref currentAgent, value);
            }
        }//Get set for currentAgent


        int currentIndex = -1; 


        public int CurretIndex
        {
            get
            {
                return currentIndex;
            }
            set
            {
                SetProperty(ref currentIndex, value);
            }

        }//Get set for correntIndex

        /*------------------------------------------------------------------------------------------------------------------*/

        #endregion

        /*------------------------------------------------------------------------------------------------------------------*/


        #region COMMANDS (previous, next, Add New, delete, close)



        #endregion

        /*------------------------------------------------------------------------------------------------------------------*/

    }
}

#region Previous code

/*INotifyPropertyChanged VERSION*/
/*------------------------------------------------------------------------------------------------------------------*/



/*

namespace Agent
{



    public class MainWindowViewModel : INotifyPropertyChanged
    {
        ObservableCollection<AgentFil> agentsToList;
        public MainWindowViewModel()
        {
            agentsToList = new ObservableCollection<AgentFil>();
            agentsToList.Add(new AgentFil() { ID = "2", CodeName = "Agent Cecillia", Speciality = "At græde", Assignment = "Make GUI work" });
            agentsToList.Add(new AgentFil() { ID = "3", CodeName = "Agent Yuhu", Speciality = "Kitchen duty", Assignment = "Opvasken" });
            CurrentAgent = agentsToList[0];
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        AgentFil currentAgent = null;


        public AgentFil CurrentAgent
        {
            get { return currentAgent; }
            set
            {
                if (currentAgent != value)
                {
                    currentAgent = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public ObservableCollection<AgentFil> AgentFils
        {
            get
            {
                return agentsToList;
            }
        }
        public void addNewAgent()
        {
            agentsToList.Add(new AgentFil());
        }
    }
}*/
#endregion