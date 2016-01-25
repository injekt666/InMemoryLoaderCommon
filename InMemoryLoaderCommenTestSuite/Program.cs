﻿using System;

using log4net;

namespace InMemoryLoaderCommenTestSuite
{
	class MainClass
	{
		/// <summary>
		/// The log.
		/// </summary>
		private static readonly ILog log = LogManager.GetLogger (typeof(MainClass));
		/// <summary>
		/// The app base.
		/// </summary>
		private static AppBase appBase = AppBase.Instance;

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		private static void Main (string[] args)
		{
			try {
				log.Info ("Start InMemoryLoaderCommenTestSuite");

				var baseTestOk = RunBaseTest ();
				log.InfoFormat ("RunBaseTest = {0}", baseTestOk);

				// CheckUtils Test Cases
				var stringByteTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringByteTest ();
				log.InfoFormat ("IsStringByteTest = {0}", stringByteTest);
				var stringDateTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringDateTest ();
				log.InfoFormat ("IsStringDateTest = {0}", stringDateTest);
				var stringDecimalTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringDecimalTest ();
				log.InfoFormat ("IsStringDecimalTest = {0}", stringDecimalTest);
				var stringDoubleTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringDoubleTest ();
				log.InfoFormat ("IsStringDoubleTest = {0}", stringDoubleTest);
				var stringFloatTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringFloatTest ();
				log.InfoFormat ("IsStringFloatTest = {0}", stringFloatTest);
				var stringIntTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringIntTest ();
				log.InfoFormat ("IsStringIntTest = {0}", stringIntTest);
				var stringLongTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsStringLongTest ();
				log.InfoFormat ("IsStringLongTest = {0}", stringLongTest);
				var urlValidTest = InMemoryLoaderCommenTestSuite.CheckUtilsTest.Test.IsUrlValidTest ();
				log.InfoFormat ("IsUrlValidTest = {0}", urlValidTest);

				// ConvertUtils Test Cases
				var convertBooleanTest = InMemoryLoaderCommenTestSuite.ConvertUtilsTest.Test.ConvertBooleanTest ();
				log.InfoFormat ("ConvertBooleanTest = {0}", convertBooleanTest);

				// CryptUtilsTest
				var cryptHashTest = InMemoryLoaderCommenTestSuite.CryptUtilsTest.Test.CryptHashTest ();
				log.InfoFormat ("CryptHashTest = {0}", cryptHashTest);
				var cryptRijndaelTest = InMemoryLoaderCommenTestSuite.CryptUtilsTest.Test.CryptRijndaelTest ();
				log.InfoFormat ("CryptRijndaelTest = {0}", cryptRijndaelTest);



				Console.Read ();
			} catch (Exception ex) {
				log.FatalFormat ("{0}", ex);
			}
		}

		/// <summary>
		/// Runs the base test.
		/// </summary>
		/// <returns><c>true</c>, if base test was run, <c>false</c> otherwise.</returns>
		private static bool RunBaseTest ()
		{
			try {
				bool baseTestOk = false;

				// appBase is typeof AppBase
				if (appBase != null) {
					baseTestOk = true;
				}
				log.InfoFormat ("Is Instanze AppBase = {0}", baseTestOk);

				// ComponentLoader is initialized
				if (appBase.ComponentLoader != null) {
					baseTestOk = true;
				}
				log.InfoFormat ("Is Instanze ComponentLoader = {0}", baseTestOk);

				// CommonComponentLoader is initialized
				if (appBase.CommonComponentLoader != null) {
					baseTestOk = true;
				}
				log.InfoFormat ("Is Instanze CommonComponentLoader = {0}", baseTestOk);

				var components = appBase.CommonComponentLoader.Components.Count;
				log.InfoFormat ("CommonComponentLoader contains {0} components", components);

				if (components > 0) {
					baseTestOk = true;
				}

				if (log.IsDebugEnabled) {
					foreach (var item in appBase.CommonComponentLoader.Components) {
						log.Debug (item.Class.ToString ());
					}
				}

				return baseTestOk;
			} catch (Exception ex) {
				throw ex;
			}
		}

	}
}