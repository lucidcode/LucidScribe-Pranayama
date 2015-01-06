using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace lucidcode.LucidScribe.Plugin.Pranayama
{
  public partial class SettingsControl : UserControl
  {

    public event ExerciseChangedEventHandler ExerciseChanged;
    public delegate void ExerciseChangedEventHandler(string Exercise);

    public SettingsControl()
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

    private void lstExercises_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach (ListViewItem lstItem in lstExercises.Items)
      {
        lstItem.Font = new Font(lstItem.Font, FontStyle.Regular);
      }

      if (lstExercises.SelectedItems.Count > 0)
      {
        if (ExerciseChanged != null)
        {
          lstExercises.SelectedItems[0].Font = new Font(lstExercises.SelectedItems[0].Font, FontStyle.Bold);
          ExerciseChanged(lstExercises.SelectedItems[0].Text);
        }
      }
    }
  }
}
