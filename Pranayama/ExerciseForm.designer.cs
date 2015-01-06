namespace lucidcode.LucidScribe.Plugin.Pranayama
{
  partial class ExerciseForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseForm));
      this.lstImg = new System.Windows.Forms.ImageList(this.components);
      this.settingsControl = new lucidcode.LucidScribe.Plugin.Pranayama.SettingsControl();
      this.SuspendLayout();
      // 
      // lstImg
      // 
      this.lstImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImg.ImageStream")));
      this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
      this.lstImg.Images.SetKeyName(0, "Graph.Plugin2.bmp");
      // 
      // settingsControl
      // 
      this.settingsControl.BackColor = System.Drawing.Color.LightSteelBlue;
      this.settingsControl.Location = new System.Drawing.Point(12, 12);
      this.settingsControl.Name = "settingsControl";
      this.settingsControl.Size = new System.Drawing.Size(239, 143);
      this.settingsControl.TabIndex = 6;
      this.settingsControl.ExerciseChanged += new lucidcode.LucidScribe.Plugin.Pranayama.SettingsControl.ExerciseChangedEventHandler(this.settingsControl_ExerciseChanged);
      // 
      // ExerciseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.ClientSize = new System.Drawing.Size(263, 167);
      this.Controls.Add(this.settingsControl);
      this.Font = new System.Drawing.Font("Verdana", 8.25F);
      this.ForeColor = System.Drawing.Color.MidnightBlue;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ExerciseForm";
      this.Text = "Lucid Scribe - Pranayama";
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.ImageList lstImg;
    internal SettingsControl settingsControl;
  }
}