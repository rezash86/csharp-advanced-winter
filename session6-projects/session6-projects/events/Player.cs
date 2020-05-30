using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session6_projects
{
    class Player
    {
        public delegate void DeathDelegate();
        public event DeathDelegate deathEvent;
        void Die()
        {
            //I would like to notify or do an action about this event!
            //Achievement achievement = new Achievement();
            //achievement.OnPlayerDeath();

            //UserInterface userInterface = new UserInterface();
            //userInterface.OnPlayerDeath();

            //DatabaseAction dbAction = new dbAction();
            //dbAction.OnPlayerDeath()

            deathEvent?.Invoke();
            //or
            if(deathEvent != null)
            {
                deathEvent();
            }
        }
    }
}
