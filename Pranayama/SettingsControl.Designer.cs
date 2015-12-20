namespace lucidcode.LucidScribe.Plugin.Pranayama
{
  partial class SettingsControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("8:32:16", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Kapalbhati", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Heart Breath", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Bhastrika - Ujjayi", "Graph.Plugin2.bmp");
            this.lstImg = new System.Windows.Forms.ImageList(this.components);
            this.pnlPlugins = new lucidcode.Controls.Panel3D();
            this.lstExercises = new System.Windows.Forms.ListView();
            this.Panel3D4 = new lucidcode.Controls.Panel3D();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.pnlPlugins.SuspendLayout();
            this.Panel3D4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstImg
            // 
            this.lstImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImg.ImageStream")));
            this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImg.Images.SetKeyName(0, "Graph.Plugin2.bmp");
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlugins.BackColor = System.Drawing.Color.White;
            this.pnlPlugins.Controls.Add(this.lstExercises);
            this.pnlPlugins.Controls.Add(this.Panel3D4);
            this.pnlPlugins.Location = new System.Drawing.Point(0, 0);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(522, 109);
            this.pnlPlugins.TabIndex = 6;
            // 
            // lstExercises
            // 
            this.lstExercises.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExercises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstExercises.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstExercises.LargeImageList = this.lstImg;
            this.lstExercises.Location = new System.Drawing.Point(3, 25);
            this.lstExercises.MultiSelect = false;
            this.lstExercises.Name = "lstExercises";
            this.lstExercises.Size = new System.Drawing.Size(516, 81);
            this.lstExercises.TabIndex = 8;
            this.lstExercises.TileSize = new System.Drawing.Size(150, 32);
            this.lstExercises.UseCompatibleStateImageBehavior = false;
            this.lstExercises.View = System.Windows.Forms.View.Tile;
            this.lstExercises.SelectedIndexChanged += new System.EventHandler(this.lstExercises_SelectedIndexChanged);
            this.lstExercises.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstPlaylists_MouseMove);
            // 
            // Panel3D4
            // 
            this.Panel3D4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3D4.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel3D4.Controls.Add(this.Label5);
            this.Panel3D4.Controls.Add(this.Label6);
            this.Panel3D4.Location = new System.Drawing.Point(0, 0);
            this.Panel3D4.Name = "Panel3D4";
            this.Panel3D4.Size = new System.Drawing.Size(522, 24);
            this.Panel3D4.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Image = ((System.Drawing.Image)(resources.GetObject("Label5.Image")));
            this.Label5.Location = new System.Drawing.Point(3, 3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(19, 19);
            this.Label5.TabIndex = 4;
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(24, 3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(495, 19);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Exercise";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pnlPlugins);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(522, 109);
            this.pnlPlugins.ResumeLayout(false);
            this.Panel3D4.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.ImageList lstImg;
    internal Controls.Panel3D pnlPlugins;
    internal System.Windows.Forms.ListView lstExercises;
    internal Controls.Panel3D Panel3D4;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label6;


  }
}
