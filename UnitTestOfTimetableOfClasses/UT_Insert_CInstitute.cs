﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;



namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CInstitute
	{
		[TestMethod]
		public void Task_616_1() //Добавление в пустую таблицу	
		{
			//arrange 	
			Controllers.CInstitute.Clear();
			MInstitute inst = new MInstitute("Институт Автоматизирован", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");
			bool expected = true;
			//act	
			bool actual = Controllers.CInstitute.Insert(inst);
			//assert	
			Assert.AreEqual(expected, actual);
		}

        [TestMethod]
        public void Task_616_2() //краткое название дублируется
		{
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт Неавтоматиз", "ИАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = Controllers.CInstitute.Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_616_3() // полное название дублируется
		{
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт Автоматизирован", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = Controllers.CInstitute.Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_616_4() // директор дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт Неавтоматизированных систем и технологий", "ФАСТ", "Лустгартен Ю.Л.", "Тюменский Государственный Университет");
            int C1 = Controllers.CInstitute.Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

		[TestMethod]
		public void Task_616_5() // наименование ВУЗа дублируется
		{
			bool ex = false;
			bool act;
			MInstitute T_Institute = new MInstitute("Институт Неавтоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
			int C1 = Controllers.CInstitute.Rows.Count;
			act = Controllers.CInstitute.Delete(T_Institute);
			int C2 = Controllers.CInstitute.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
	}

}



