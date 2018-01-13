using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsGameData
    {
        public string ButtonString { get; private set; }
        public int CurrentNumber { get; private set; }
        public int TargetNumber { get; private set; }
        public int MaximumMoves { get; private set; }
        public bool IsLoaded { get; private set; }

        public clsGameData(string GameData)
        {
            // put the IsLoaded as false
            this.IsLoaded = false;

            // split the GameData with "#"
            string[] GameDataArr = GameData.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            // the GameData array length should be 4, otherwise it was a wrong game data
            if (GameDataArr.Length == 4)
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
