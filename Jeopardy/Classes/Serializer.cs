using JeopardyGame.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Classes
{
    /// <summary>
    /// This class serializes the game information so it can be stored as a blob in the db. It also deserializes information from the db so it can be read/viewed by users.
    /// </summary>
    static class Serializer
    {
        public static List<Game> showGames = new List<Game>();
        public static List<string> dateList = new List<string>();

        public static void SerializeNow(Game game)
        {
            //Create new MemoryStream
            MemoryStream myStream = new MemoryStream();

            //Setup the binary formatting obj
            BinaryFormatter myFormat = new BinaryFormatter();

            //Call the serailize method and pass in the stream and object to transform
            myFormat.Serialize(myStream, game);

            //Convert the serialized object to Base64 for encoding and easy storage
            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            //Call the Insert method of the DataAdapter class and insert the serialized value
            DataAdapter.Insert(serializedValue);

            //Close the stream
            myStream.Close();

        }


        /// <summary>
        /// Deserialize the object from the database so it is readable
        /// </summary>
        /// <param name="encodedData"></param>
        public static List<Game> DeSerializeNow(string encodedData)
        {
            //Create a generic object to hold the object
            object type;

            //Create a stream and binary formatter
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(encodedData));
            BinaryFormatter myFormat = new BinaryFormatter();

            //Deserialize what's in memory into the generic object
            type = myFormat.Deserialize(myStream);

            //Test what type of object it is
            if (type.GetType().Name == "Game")
            {
                Game games = (Game)type;

                //Add the game to the showGames list
                showGames.Add(games);

                //Return the list
                return showGames;

            }

            //Close the stream
            myStream.Close();

            //Return the list of games
            return showGames;
        }
    }
}
