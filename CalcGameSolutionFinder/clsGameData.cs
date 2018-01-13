using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsGameData
    {
        /// <summary>
        /// Button String data that will be used to load the Button Data on the Game Form
        /// </summary>
        public string ButtonString { get; private set; }

        /// <summary>
        /// Current/Start number that will be used by Game as the initial number
        /// </summary>
        public int CurrentNumber { get; private set; }

        /// <summary>
        /// Target number that need be achieved to finished the game
        /// </summary>
        public int TargetNumber { get; private set; }

        /// <summary>
        /// Maximum moves allowed to reach the target number
        /// </summary>
        public int MaximumMoves { get; private set; }

        /// <summary>
        /// 1st Hint of the game
        /// </summary>
        public string[] HintData { get; private set; }

        /// <summary>
        /// Indicator to knew whether the Game Data can be loaded or not?
        /// </summary>
        public bool IsLoaded { get; private set; }

        /// <summary>
        /// Parse the GameData string that loaded from the GameData file.
        /// The GameData string should be separated by "#", with 4 fields inside of the GameData:
        /// (1) Button String - 5 button data (3 number, 2 operator) that separated with ","
        /// (2) Current Number/Starting number
        /// (3) Target Number
        /// (4) Maximum Moves allowed
        /// 
        /// Example of the GameData string:
        /// +1,+2,N3,,#100#10333#4
        /// </summary>
        /// <param name="GameData">GameData string loaded from GameData file</param>
        public clsGameData(string GameData)
        {
            // put the IsLoaded as false
            this.IsLoaded = false;

            // split the GameData with "#"
            string[] GameDataArr = GameData.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            // the GameData array length should be 5, otherwise it was a wrong game data
            if (GameDataArr.Length == 5)
            {
                // put the button string as the first data
                this.ButtonString = GameDataArr[0];

                // the 2nd data is current number, try to parse the data, if got error then no need to to continue
                try
                {
                    this.CurrentNumber = int.Parse(GameDataArr[1]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Game Data : " + GameData + " --> Cannot Be Loaded. " + ex.Message);
                    return;
                }

                // the 3rd data is target number, try to parse the data, if got error then no need to to continue
                try
                {
                    this.TargetNumber = int.Parse(GameDataArr[2]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Game Data : " + GameData + " --> Cannot Be Loaded. " + ex.Message);
                    return;
                }

                // the 4th data is maximum moves, try to parse the data, if got error then no need to to continue
                try
                {
                    this.MaximumMoves = int.Parse(GameDataArr[3]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Game Data : " + GameData + " --> Cannot Be Loaded. " + ex.Message);
                    return;
                }

                // the 5th data is hint data, split all the hint data and put into hint variable
                this.HintData = GameDataArr[4].Split(new string[] { "," }, StringSplitOptions.None);

                // if reaching this section it means that the game data is correct
                this.IsLoaded = true;
            }
            else
            {
                Console.WriteLine("Game Data : " + GameData + " --> Cannot Be Loaded. Array Length <> 4.");
            }
        }
    }
}
