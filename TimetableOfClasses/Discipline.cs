﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
    public partial class Discipline : Form
    {
		public Discipline()
		{
			InitializeComponent();
			DG_Disc.DataSource = Controllers.CDiscipline.Select();
		}


        private void DG_Disc_SelectionChanged(object sender, EventArgs e)
        {
            if ((DG_Disc.SelectedRows.Count > 0)&&(DG_Disc.SelectedCells[0].RowIndex != DG_Disc.Rows.Count - 1))
            {
                Delete.Enabled = true;
            }
            else
            {
                Delete.Enabled = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try { DG_Disc.Rows.RemoveAt(DG_Disc.SelectedCells[0].RowIndex); }
            catch{}

        }

		private void btCreateDiscipline_Click(object sender, EventArgs e)
		{
			AddDiscipline addDiscipline = new AddDiscipline();
			addDiscipline.ShowDialog();
		}
	}
}

