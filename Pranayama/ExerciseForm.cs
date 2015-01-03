using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.IO;

namespace lucidcode.LucidScribe.Plugin.Pranayama
{
  public partial class ExerciseForm : Form
  {
    public String SelectedExercise = "";

    public ExerciseForm()
    {
      InitializeComponent();
    }

    private void lstPlaylists_MouseMove(object sender, MouseEventArgs e)
    {
      if (lstExercises.GetItemAt(e.X, e.Y) != null)
      {
        lstExercises.Cursor = Cursors.Hand;
      }
      else
      {
        lstExercises.Cursor = Cursors.Default;
      }
    }

    private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstExercises.SelectedItems.Count > 0)
      {
        SelectedExercise = lstExercises.SelectedItems[0].Text;
        DialogResult = DialogResult.OK;
        Close();
      }
    }
  }
}
