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

    public event ExerciseChangedEventHandler ExerciseChanged;
    public delegate void ExerciseChangedEventHandler(string Exercise);

    public ExerciseForm()
    {
      InitializeComponent();
    }

    private void settingsControl_ExerciseChanged(string Exercise)
    {
      if (ExerciseChanged != null)
      {
        ExerciseChanged(Exercise);
      }
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
