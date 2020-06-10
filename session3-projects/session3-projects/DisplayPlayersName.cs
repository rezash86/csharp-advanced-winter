using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_projects
{
    class DisplayPlayersName
    {
        delegate int ScoreDelegate(PlayerStates state);
        void OnGameOver(PlayerStates[] playerStates)
        {
            //I would like to know who killed the most
            //I would like to know who captured the flags the most
            ScoreDelegate killDelegate = ScoreByKillCount;
            string playerMostKilled = GetPlayerNameTopScore(playerStates, killDelegate);
            ScoreDelegate flagCapturedDelegate = ScoreByFlagCaptured;
            string playerMostCaptured = GetPlayerNameTopScore(playerStates, flagCapturedDelegate);


            Console.WriteLine(playerMostKilled);
        }

        //private string GetPlayerNameMostKilled(PlayerStates[] playerStates)
        //{
        //    string name = "";
        //    int bestScore = 0;

        //    foreach(PlayerStates state in playerStates)
        //    {
        //        int score = state.kills;
        //        if(score > bestScore)
        //        {
        //            bestScore = score;
        //            name = state.name;
        //        }
        //    }

        //    return name;
        //}

        //private string GetPlayerNameMostCapturedFlag(PlayerStates[] playerStates)
        //{
        //    string name = "";
        //    int bestScore = 0;

        //    foreach (PlayerStates state in playerStates)
        //    {
        //        int score = state.flagCaptured;
        //        if (score > bestScore)
        //        {
        //            bestScore = score;
        //            name = state.name;
        //        }
        //    }

        //    return name;
        //}

        string GetPlayerNameTopScore(PlayerStates[] playerStates, ScoreDelegate scoreDelegate)
        {
            string name = "";
            int bestScore = 0;

            foreach (PlayerStates state in playerStates)
            {
                int score = scoreDelegate(state);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = state.name;
                }
            }

            return name;
        }

        int ScoreByKillCount(PlayerStates stats)
        {
            return stats.kills;
        }

        int ScoreByFlagCaptured(PlayerStates stats)
        {
            return stats.flagCaptured;
        }
    }
}
