using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {  // member variables
        int endDate;
        UserInterface UI;
        Player player1;
        Day day;
        private bool endCondition = false;
        //constructor

        //methods

        void RunGame()
        {
            UI.DisplayFaq();
            SetEndDate();
            // ask game type 2 player or 1 player if add later
            SetPlayer1Name();
            do
            {
                RunRound();
            } while (endCondition == false);

            // starts the game before  round loop behins 
        }
        void RunRound()
        {
            UI.DisplayDay(); // runs the lemonade stand days
        }
        void CheckWinningConditon()
        {
            // when it hits game.days (Amount of days they chose)
        }
        void UpdatCurrentDay()
        {
            day.currentDay++;
        }
       void SetEndDate()
        {
            UI.DisplayEndDateOption();
            UI.GetUserInput();
            endDate = Convert.ToInt32(UI.userInput);
        }
        void SetPlayer1Name()
        {
            UI.DisplayNameOption();
            UI.GetUserInput();
            player1.name = UI.userInput;
        }
    }
}
