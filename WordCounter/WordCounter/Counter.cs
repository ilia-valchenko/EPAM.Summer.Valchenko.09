﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    /// <summary>
    /// This class allows to know how many times each word appears in the text.
    /// </summary>
    public class Counter
    {
        #region Public fields and properties
        /// <summary>
        /// Property which returns words and their counters represented by Dictionary.
        /// </summary>
        public Dictionary<string, int> WordCounter => dictionaryCounter; 
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Counter() { }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="path">A path to a text file.</param>
        public Counter(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("File doesn't exist.");

            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(path);
            }
            catch (Exception exc)
            {
                log.Fatal($"Something wrong with textfile. StackTrace: {exc.StackTrace}. Error message: {exc.Message}.");
            }

            string[] words = streamReader.ReadToEnd().Split();

            dictionaryCounter = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (dictionaryCounter.ContainsKey(word))
                {
                    int counter;
                    dictionaryCounter.TryGetValue(word, out counter);
                    dictionaryCounter[word] = ++counter;
                }
                else
                    dictionaryCounter.Add(word, 1);
            }
        } 
        #endregion

        #region Private fields
        /// <summary>
        /// Dictionary which represents words and their counters.
        /// </summary>
        private readonly Dictionary<string, int> dictionaryCounter;
        /// <summary>
        /// Logger for warning and error messages. 
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        #endregion
    }
}
