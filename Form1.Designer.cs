﻿namespace Zadanie2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BitmapCanvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PolygonToolsBox = new System.Windows.Forms.GroupBox();
            this.RemoveVertexRadioButton = new System.Windows.Forms.RadioButton();
            this.AddPolygonRadioButton = new System.Windows.Forms.RadioButton();
            this.AddVertexRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectFigureRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectVertexRadioButton = new System.Windows.Forms.RadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.AnimationBox = new System.Windows.Forms.GroupBox();
            this.ClearRandomsButton = new System.Windows.Forms.Button();
            this.AnimateCheckBox = new System.Windows.Forms.CheckBox();
            this.PolygonSpeedSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.FillOptionsBox = new System.Windows.Forms.GroupBox();
            this.LoadMapButton = new System.Windows.Forms.Button();
            this.BumpMapName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadTextureButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BumpRadioButton = new System.Windows.Forms.RadioButton();
            this.TextureFileName = new System.Windows.Forms.Label();
            this.TextureRadioButton = new System.Windows.Forms.RadioButton();
            this.VertexColorRadioButton = new System.Windows.Forms.RadioButton();
            this.LightBox = new System.Windows.Forms.GroupBox();
            this.HeightValue = new System.Windows.Forms.Label();
            this.HeightSlider = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.KsValue = new System.Windows.Forms.Label();
            this.KdValue = new System.Windows.Forms.Label();
            this.KsSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.KdSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.LampCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.PolygonToolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.AnimationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.FillOptionsBox.SuspendLayout();
            this.LightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KsSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BitmapCanvas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(744, 541);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // BitmapCanvas
            // 
            this.BitmapCanvas.BackColor = System.Drawing.Color.White;
            this.BitmapCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BitmapCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BitmapCanvas.Location = new System.Drawing.Point(0, 0);
            this.BitmapCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.BitmapCanvas.Name = "BitmapCanvas";
            this.BitmapCanvas.Size = new System.Drawing.Size(534, 541);
            this.BitmapCanvas.TabIndex = 0;
            this.BitmapCanvas.TabStop = false;
            this.BitmapCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseDown);
            this.BitmapCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 541);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PolygonToolsBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(191, 739);
            this.splitContainer2.SplitterDistance = 155;
            this.splitContainer2.TabIndex = 23;
            // 
            // PolygonToolsBox
            // 
            this.PolygonToolsBox.Controls.Add(this.RemoveVertexRadioButton);
            this.PolygonToolsBox.Controls.Add(this.AddPolygonRadioButton);
            this.PolygonToolsBox.Controls.Add(this.AddVertexRadioButton);
            this.PolygonToolsBox.Controls.Add(this.SelectFigureRadioButton);
            this.PolygonToolsBox.Controls.Add(this.SelectVertexRadioButton);
            this.PolygonToolsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PolygonToolsBox.Location = new System.Drawing.Point(0, 0);
            this.PolygonToolsBox.Name = "PolygonToolsBox";
            this.PolygonToolsBox.Size = new System.Drawing.Size(191, 155);
            this.PolygonToolsBox.TabIndex = 0;
            this.PolygonToolsBox.TabStop = false;
            this.PolygonToolsBox.Text = "Własne wielokąty";
            // 
            // RemoveVertexRadioButton
            // 
            this.RemoveVertexRadioButton.AutoSize = true;
            this.RemoveVertexRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveVertexRadioButton.Location = new System.Drawing.Point(3, 124);
            this.RemoveVertexRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.RemoveVertexRadioButton.Name = "RemoveVertexRadioButton";
            this.RemoveVertexRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.RemoveVertexRadioButton.Size = new System.Drawing.Size(185, 27);
            this.RemoveVertexRadioButton.TabIndex = 31;
            this.RemoveVertexRadioButton.Text = "Usuń wierzchołek";
            this.RemoveVertexRadioButton.UseVisualStyleBackColor = true;
            this.RemoveVertexRadioButton.CheckedChanged += new System.EventHandler(this.RemoveVertexRadioChanged);
            // 
            // AddPolygonRadioButton
            // 
            this.AddPolygonRadioButton.AutoSize = true;
            this.AddPolygonRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPolygonRadioButton.Location = new System.Drawing.Point(3, 97);
            this.AddPolygonRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.AddPolygonRadioButton.Name = "AddPolygonRadioButton";
            this.AddPolygonRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.AddPolygonRadioButton.Size = new System.Drawing.Size(185, 27);
            this.AddPolygonRadioButton.TabIndex = 30;
            this.AddPolygonRadioButton.Text = "Dodaj nowy wielokąt";
            this.AddPolygonRadioButton.UseVisualStyleBackColor = true;
            this.AddPolygonRadioButton.CheckedChanged += new System.EventHandler(this.AddPolygonRadioChanged);
            // 
            // AddVertexRadioButton
            // 
            this.AddVertexRadioButton.AutoSize = true;
            this.AddVertexRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddVertexRadioButton.Location = new System.Drawing.Point(3, 70);
            this.AddVertexRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.AddVertexRadioButton.Name = "AddVertexRadioButton";
            this.AddVertexRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.AddVertexRadioButton.Size = new System.Drawing.Size(185, 27);
            this.AddVertexRadioButton.TabIndex = 29;
            this.AddVertexRadioButton.Text = "Dodaj wierzchołek na kraw.";
            this.AddVertexRadioButton.UseVisualStyleBackColor = true;
            this.AddVertexRadioButton.CheckedChanged += new System.EventHandler(this.AddVertexRadioChanged);
            // 
            // SelectFigureRadioButton
            // 
            this.SelectFigureRadioButton.AutoSize = true;
            this.SelectFigureRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectFigureRadioButton.Location = new System.Drawing.Point(3, 43);
            this.SelectFigureRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.SelectFigureRadioButton.Name = "SelectFigureRadioButton";
            this.SelectFigureRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.SelectFigureRadioButton.Size = new System.Drawing.Size(185, 27);
            this.SelectFigureRadioButton.TabIndex = 28;
            this.SelectFigureRadioButton.Text = "Zaznacz figurę";
            this.SelectFigureRadioButton.UseVisualStyleBackColor = true;
            this.SelectFigureRadioButton.CheckedChanged += new System.EventHandler(this.SelectFigureRadioChanged);
            // 
            // SelectVertexRadioButton
            // 
            this.SelectVertexRadioButton.AutoSize = true;
            this.SelectVertexRadioButton.Checked = true;
            this.SelectVertexRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectVertexRadioButton.Location = new System.Drawing.Point(3, 16);
            this.SelectVertexRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.SelectVertexRadioButton.Name = "SelectVertexRadioButton";
            this.SelectVertexRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.SelectVertexRadioButton.Size = new System.Drawing.Size(185, 27);
            this.SelectVertexRadioButton.TabIndex = 27;
            this.SelectVertexRadioButton.TabStop = true;
            this.SelectVertexRadioButton.Text = "Zaznacz wierzchołek/krawędź";
            this.SelectVertexRadioButton.UseVisualStyleBackColor = true;
            this.SelectVertexRadioButton.CheckedChanged += new System.EventHandler(this.SelectVertexRadioChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.AnimationBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(191, 580);
            this.splitContainer3.SplitterDistance = 115;
            this.splitContainer3.TabIndex = 0;
            // 
            // AnimationBox
            // 
            this.AnimationBox.Controls.Add(this.ClearRandomsButton);
            this.AnimationBox.Controls.Add(this.AnimateCheckBox);
            this.AnimationBox.Controls.Add(this.PolygonSpeedSlider);
            this.AnimationBox.Controls.Add(this.label1);
            this.AnimationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimationBox.Location = new System.Drawing.Point(0, 0);
            this.AnimationBox.Name = "AnimationBox";
            this.AnimationBox.Size = new System.Drawing.Size(191, 115);
            this.AnimationBox.TabIndex = 0;
            this.AnimationBox.TabStop = false;
            this.AnimationBox.Text = "Animacja";
            // 
            // ClearRandomsButton
            // 
            this.ClearRandomsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearRandomsButton.Location = new System.Drawing.Point(3, 86);
            this.ClearRandomsButton.Name = "ClearRandomsButton";
            this.ClearRandomsButton.Size = new System.Drawing.Size(185, 25);
            this.ClearRandomsButton.TabIndex = 9;
            this.ClearRandomsButton.Text = "Wyczyść losowe wielokąty";
            this.ClearRandomsButton.UseVisualStyleBackColor = true;
            this.ClearRandomsButton.Click += new System.EventHandler(this.ClearRandoms_Click);
            // 
            // AnimateCheckBox
            // 
            this.AnimateCheckBox.AutoSize = true;
            this.AnimateCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnimateCheckBox.Location = new System.Drawing.Point(3, 59);
            this.AnimateCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.AnimateCheckBox.Name = "AnimateCheckBox";
            this.AnimateCheckBox.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.AnimateCheckBox.Size = new System.Drawing.Size(185, 27);
            this.AnimateCheckBox.TabIndex = 8;
            this.AnimateCheckBox.Text = "Animuj";
            this.AnimateCheckBox.UseVisualStyleBackColor = true;
            this.AnimateCheckBox.CheckedChanged += new System.EventHandler(this.AnimateCheckBoxChanged);
            // 
            // PolygonSpeedSlider
            // 
            this.PolygonSpeedSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.PolygonSpeedSlider.LargeChange = 10;
            this.PolygonSpeedSlider.Location = new System.Drawing.Point(3, 29);
            this.PolygonSpeedSlider.Margin = new System.Windows.Forms.Padding(0);
            this.PolygonSpeedSlider.Maximum = 100;
            this.PolygonSpeedSlider.MaximumSize = new System.Drawing.Size(200, 30);
            this.PolygonSpeedSlider.Minimum = 10;
            this.PolygonSpeedSlider.Name = "PolygonSpeedSlider";
            this.PolygonSpeedSlider.Size = new System.Drawing.Size(185, 30);
            this.PolygonSpeedSlider.SmallChange = 10;
            this.PolygonSpeedSlider.TabIndex = 7;
            this.PolygonSpeedSlider.TickFrequency = 10;
            this.PolygonSpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PolygonSpeedSlider.Value = 100;
            this.PolygonSpeedSlider.ValueChanged += new System.EventHandler(this.SpeedSliderChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prędkość wielokątów";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.FillOptionsBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.LightBox);
            this.splitContainer4.Size = new System.Drawing.Size(191, 461);
            this.splitContainer4.SplitterDistance = 200;
            this.splitContainer4.TabIndex = 0;
            // 
            // FillOptionsBox
            // 
            this.FillOptionsBox.Controls.Add(this.LoadMapButton);
            this.FillOptionsBox.Controls.Add(this.BumpMapName);
            this.FillOptionsBox.Controls.Add(this.label2);
            this.FillOptionsBox.Controls.Add(this.LoadTextureButton);
            this.FillOptionsBox.Controls.Add(this.label3);
            this.FillOptionsBox.Controls.Add(this.BumpRadioButton);
            this.FillOptionsBox.Controls.Add(this.TextureFileName);
            this.FillOptionsBox.Controls.Add(this.TextureRadioButton);
            this.FillOptionsBox.Controls.Add(this.VertexColorRadioButton);
            this.FillOptionsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillOptionsBox.Location = new System.Drawing.Point(0, 0);
            this.FillOptionsBox.Name = "FillOptionsBox";
            this.FillOptionsBox.Size = new System.Drawing.Size(191, 200);
            this.FillOptionsBox.TabIndex = 0;
            this.FillOptionsBox.TabStop = false;
            this.FillOptionsBox.Text = "Wypełnienie";
            // 
            // LoadMapButton
            // 
            this.LoadMapButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadMapButton.Location = new System.Drawing.Point(3, 168);
            this.LoadMapButton.Name = "LoadMapButton";
            this.LoadMapButton.Size = new System.Drawing.Size(185, 25);
            this.LoadMapButton.TabIndex = 11;
            this.LoadMapButton.Text = "Wczytaj mapę";
            this.LoadMapButton.UseVisualStyleBackColor = true;
            this.LoadMapButton.Click += new System.EventHandler(this.LoadBump_Click);
            // 
            // BumpMapName
            // 
            this.BumpMapName.Location = new System.Drawing.Point(70, 145);
            this.BumpMapName.Name = "BumpMapName";
            this.BumpMapName.Size = new System.Drawing.Size(116, 23);
            this.BumpMapName.TabIndex = 10;
            this.BumpMapName.Text = "(brak mapy)";
            this.BumpMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bump map:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadTextureButton
            // 
            this.LoadTextureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadTextureButton.Location = new System.Drawing.Point(3, 120);
            this.LoadTextureButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.LoadTextureButton.Name = "LoadTextureButton";
            this.LoadTextureButton.Size = new System.Drawing.Size(185, 25);
            this.LoadTextureButton.TabIndex = 8;
            this.LoadTextureButton.Text = "Wczytaj teksturę";
            this.LoadTextureButton.UseVisualStyleBackColor = true;
            this.LoadTextureButton.Click += new System.EventHandler(this.LoadTextureButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tekstura:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BumpRadioButton
            // 
            this.BumpRadioButton.AutoSize = true;
            this.BumpRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BumpRadioButton.Location = new System.Drawing.Point(3, 70);
            this.BumpRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.BumpRadioButton.Name = "BumpRadioButton";
            this.BumpRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.BumpRadioButton.Size = new System.Drawing.Size(185, 27);
            this.BumpRadioButton.TabIndex = 4;
            this.BumpRadioButton.Text = "Tekstura + bump map";
            this.BumpRadioButton.UseVisualStyleBackColor = true;
            this.BumpRadioButton.CheckedChanged += new System.EventHandler(this.BumpRadioChanged);
            // 
            // TextureFileName
            // 
            this.TextureFileName.Location = new System.Drawing.Point(67, 97);
            this.TextureFileName.Margin = new System.Windows.Forms.Padding(0);
            this.TextureFileName.Name = "TextureFileName";
            this.TextureFileName.Size = new System.Drawing.Size(119, 23);
            this.TextureFileName.TabIndex = 2;
            this.TextureFileName.Text = "(brak tekstury)";
            this.TextureFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextureRadioButton
            // 
            this.TextureRadioButton.AutoSize = true;
            this.TextureRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextureRadioButton.Location = new System.Drawing.Point(3, 43);
            this.TextureRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.TextureRadioButton.Name = "TextureRadioButton";
            this.TextureRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.TextureRadioButton.Size = new System.Drawing.Size(185, 27);
            this.TextureRadioButton.TabIndex = 1;
            this.TextureRadioButton.Text = "Tekstura";
            this.TextureRadioButton.UseVisualStyleBackColor = true;
            this.TextureRadioButton.CheckedChanged += new System.EventHandler(this.TextureRadioChanged);
            // 
            // VertexColorRadioButton
            // 
            this.VertexColorRadioButton.AutoSize = true;
            this.VertexColorRadioButton.Checked = true;
            this.VertexColorRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VertexColorRadioButton.Location = new System.Drawing.Point(3, 16);
            this.VertexColorRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.VertexColorRadioButton.Name = "VertexColorRadioButton";
            this.VertexColorRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.VertexColorRadioButton.Size = new System.Drawing.Size(185, 27);
            this.VertexColorRadioButton.TabIndex = 0;
            this.VertexColorRadioButton.TabStop = true;
            this.VertexColorRadioButton.Text = "Z wierzchołków (interpolacja)";
            this.VertexColorRadioButton.UseVisualStyleBackColor = true;
            this.VertexColorRadioButton.CheckedChanged += new System.EventHandler(this.VertexColorRadioChanged);
            // 
            // LightBox
            // 
            this.LightBox.Controls.Add(this.HeightValue);
            this.LightBox.Controls.Add(this.HeightSlider);
            this.LightBox.Controls.Add(this.label12);
            this.LightBox.Controls.Add(this.ColorPictureBox);
            this.LightBox.Controls.Add(this.SetColorButton);
            this.LightBox.Controls.Add(this.KsValue);
            this.LightBox.Controls.Add(this.KdValue);
            this.LightBox.Controls.Add(this.KsSlider);
            this.LightBox.Controls.Add(this.label5);
            this.LightBox.Controls.Add(this.KdSlider);
            this.LightBox.Controls.Add(this.label4);
            this.LightBox.Controls.Add(this.LampCheckBox);
            this.LightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightBox.Location = new System.Drawing.Point(0, 0);
            this.LightBox.Name = "LightBox";
            this.LightBox.Size = new System.Drawing.Size(191, 257);
            this.LightBox.TabIndex = 0;
            this.LightBox.TabStop = false;
            this.LightBox.Text = "Oświetlenie";
            // 
            // HeightValue
            // 
            this.HeightValue.AutoSize = true;
            this.HeightValue.Location = new System.Drawing.Point(164, 159);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(22, 13);
            this.HeightValue.TabIndex = 11;
            this.HeightValue.Text = "0.5";
            // 
            // HeightSlider
            // 
            this.HeightSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeightSlider.Location = new System.Drawing.Point(3, 172);
            this.HeightSlider.Minimum = 1;
            this.HeightSlider.Name = "HeightSlider";
            this.HeightSlider.Size = new System.Drawing.Size(185, 45);
            this.HeightSlider.TabIndex = 50;
            this.HeightSlider.TickFrequency = 10;
            this.HeightSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.HeightSlider.Value = 5;
            this.HeightSlider.ValueChanged += new System.EventHandler(this.HeightSliderChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Wysokość";
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPictureBox.Location = new System.Drawing.Point(10, 225);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(25, 25);
            this.ColorPictureBox.TabIndex = 8;
            this.ColorPictureBox.TabStop = false;
            // 
            // SetColorButton
            // 
            this.SetColorButton.Location = new System.Drawing.Point(41, 225);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(146, 25);
            this.SetColorButton.TabIndex = 7;
            this.SetColorButton.Text = "Ustaw kolor światła";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // KsValue
            // 
            this.KsValue.AutoSize = true;
            this.KsValue.Location = new System.Drawing.Point(164, 101);
            this.KsValue.Name = "KsValue";
            this.KsValue.Size = new System.Drawing.Size(22, 13);
            this.KsValue.TabIndex = 6;
            this.KsValue.Text = "0.5";
            // 
            // KdValue
            // 
            this.KdValue.AutoSize = true;
            this.KdValue.Location = new System.Drawing.Point(164, 43);
            this.KdValue.Name = "KdValue";
            this.KdValue.Size = new System.Drawing.Size(22, 13);
            this.KdValue.TabIndex = 5;
            this.KdValue.Text = "0.5";
            // 
            // KsSlider
            // 
            this.KsSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.KsSlider.Location = new System.Drawing.Point(3, 114);
            this.KsSlider.Maximum = 100;
            this.KsSlider.Name = "KsSlider";
            this.KsSlider.Size = new System.Drawing.Size(185, 45);
            this.KsSlider.TabIndex = 4;
            this.KsSlider.TickFrequency = 10;
            this.KsSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.KsSlider.Value = 50;
            this.KsSlider.ValueChanged += new System.EventHandler(this.KsSlider_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Współczynnik Ks";
            // 
            // KdSlider
            // 
            this.KdSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.KdSlider.Location = new System.Drawing.Point(3, 56);
            this.KdSlider.Maximum = 100;
            this.KdSlider.Name = "KdSlider";
            this.KdSlider.Size = new System.Drawing.Size(185, 45);
            this.KdSlider.TabIndex = 2;
            this.KdSlider.TickFrequency = 10;
            this.KdSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.KdSlider.Value = 50;
            this.KdSlider.ValueChanged += new System.EventHandler(this.KdSlider_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wpółczynnik Kd";
            // 
            // LampCheckBox
            // 
            this.LampCheckBox.AutoSize = true;
            this.LampCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LampCheckBox.Location = new System.Drawing.Point(3, 16);
            this.LampCheckBox.Name = "LampCheckBox";
            this.LampCheckBox.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.LampCheckBox.Size = new System.Drawing.Size(185, 27);
            this.LampCheckBox.TabIndex = 0;
            this.LampCheckBox.Text = "Włącz własną lampę";
            this.LampCheckBox.UseVisualStyleBackColor = true;
            this.LampCheckBox.CheckedChanged += new System.EventHandler(this.LampCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Zadanie 1";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_ResizeEnd);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BitmapCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.PolygonToolsBox.ResumeLayout(false);
            this.PolygonToolsBox.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.AnimationBox.ResumeLayout(false);
            this.AnimationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonSpeedSlider)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.FillOptionsBox.ResumeLayout(false);
            this.FillOptionsBox.PerformLayout();
            this.LightBox.ResumeLayout(false);
            this.LightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KsSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox BitmapCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox PolygonToolsBox;
        private System.Windows.Forms.RadioButton RemoveVertexRadioButton;
        private System.Windows.Forms.RadioButton AddPolygonRadioButton;
        private System.Windows.Forms.RadioButton AddVertexRadioButton;
        private System.Windows.Forms.RadioButton SelectFigureRadioButton;
        private System.Windows.Forms.RadioButton SelectVertexRadioButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox AnimationBox;
        private System.Windows.Forms.Button ClearRandomsButton;
        private System.Windows.Forms.CheckBox AnimateCheckBox;
        private System.Windows.Forms.TrackBar PolygonSpeedSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox FillOptionsBox;
        private System.Windows.Forms.Button LoadMapButton;
        private System.Windows.Forms.Label BumpMapName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadTextureButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton BumpRadioButton;
        private System.Windows.Forms.Label TextureFileName;
        private System.Windows.Forms.RadioButton TextureRadioButton;
        private System.Windows.Forms.RadioButton VertexColorRadioButton;
        private System.Windows.Forms.GroupBox LightBox;
        private System.Windows.Forms.PictureBox ColorPictureBox;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.Label KsValue;
        private System.Windows.Forms.Label KdValue;
        private System.Windows.Forms.TrackBar KsSlider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar KdSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox LampCheckBox;
        private System.Windows.Forms.Label HeightValue;
        private System.Windows.Forms.TrackBar HeightSlider;
        private System.Windows.Forms.Label label12;
    }
}

