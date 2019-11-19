namespace Zadanie1
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveVertexRadioButton = new System.Windows.Forms.RadioButton();
            this.AddPolygonRadioButton = new System.Windows.Forms.RadioButton();
            this.AddVertexRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectFigureRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectVertexRadioButton = new System.Windows.Forms.RadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearRandomsButton = new System.Windows.Forms.Button();
            this.AnimateCheckBox = new System.Windows.Forms.CheckBox();
            this.PolygonSpeedSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LoadMapButton = new System.Windows.Forms.Button();
            this.BumpMapName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadTextureButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BumpRadioButton = new System.Windows.Forms.RadioButton();
            this.TextureFileName = new System.Windows.Forms.Label();
            this.TextureRadioButton = new System.Windows.Forms.RadioButton();
            this.VertexColorRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.KsValue = new System.Windows.Forms.Label();
            this.KdValue = new System.Windows.Forms.Label();
            this.KsSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.KdSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.LampCheckBox = new System.Windows.Forms.CheckBox();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KsSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(704, 681);
            this.splitContainer1.SplitterDistance = 512;
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
            this.BitmapCanvas.Size = new System.Drawing.Size(512, 681);
            this.BitmapCanvas.TabIndex = 0;
            this.BitmapCanvas.TabStop = false;
            this.BitmapCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseDown);
            this.BitmapCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasMove);
            this.BitmapCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseUp);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(190, 681);
            this.splitContainer2.SplitterDistance = 155;
            this.splitContainer2.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveVertexRadioButton);
            this.groupBox1.Controls.Add(this.AddPolygonRadioButton);
            this.groupBox1.Controls.Add(this.AddVertexRadioButton);
            this.groupBox1.Controls.Add(this.SelectFigureRadioButton);
            this.groupBox1.Controls.Add(this.SelectVertexRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Własne wielokąty";
            // 
            // RemoveVertexRadioButton
            // 
            this.RemoveVertexRadioButton.AutoSize = true;
            this.RemoveVertexRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveVertexRadioButton.Location = new System.Drawing.Point(3, 124);
            this.RemoveVertexRadioButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.RemoveVertexRadioButton.Name = "RemoveVertexRadioButton";
            this.RemoveVertexRadioButton.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.RemoveVertexRadioButton.Size = new System.Drawing.Size(184, 27);
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
            this.AddPolygonRadioButton.Size = new System.Drawing.Size(184, 27);
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
            this.AddVertexRadioButton.Size = new System.Drawing.Size(184, 27);
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
            this.SelectFigureRadioButton.Size = new System.Drawing.Size(184, 27);
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
            this.SelectVertexRadioButton.Size = new System.Drawing.Size(184, 27);
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
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(190, 522);
            this.splitContainer3.SplitterDistance = 115;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearRandomsButton);
            this.groupBox2.Controls.Add(this.AnimateCheckBox);
            this.groupBox2.Controls.Add(this.PolygonSpeedSlider);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animacja";
            // 
            // ClearRandomsButton
            // 
            this.ClearRandomsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearRandomsButton.Location = new System.Drawing.Point(3, 86);
            this.ClearRandomsButton.Name = "ClearRandomsButton";
            this.ClearRandomsButton.Size = new System.Drawing.Size(184, 23);
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
            this.AnimateCheckBox.Size = new System.Drawing.Size(184, 27);
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
            this.PolygonSpeedSlider.Size = new System.Drawing.Size(184, 30);
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
            this.splitContainer4.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer4.Size = new System.Drawing.Size(190, 403);
            this.splitContainer4.SplitterDistance = 200;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LoadMapButton);
            this.groupBox3.Controls.Add(this.BumpMapName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.LoadTextureButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BumpRadioButton);
            this.groupBox3.Controls.Add(this.TextureFileName);
            this.groupBox3.Controls.Add(this.TextureRadioButton);
            this.groupBox3.Controls.Add(this.VertexColorRadioButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 200);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wypełnienie";
            // 
            // LoadMapButton
            // 
            this.LoadMapButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadMapButton.Location = new System.Drawing.Point(3, 166);
            this.LoadMapButton.Name = "LoadMapButton";
            this.LoadMapButton.Size = new System.Drawing.Size(184, 23);
            this.LoadMapButton.TabIndex = 11;
            this.LoadMapButton.Text = "Wczytaj mapę";
            this.LoadMapButton.UseVisualStyleBackColor = true;
            this.LoadMapButton.Click += new System.EventHandler(this.LoadBump_Click);
            // 
            // BumpMapName
            // 
            this.BumpMapName.Location = new System.Drawing.Point(70, 143);
            this.BumpMapName.Name = "BumpMapName";
            this.BumpMapName.Size = new System.Drawing.Size(119, 23);
            this.BumpMapName.TabIndex = 10;
            this.BumpMapName.Text = "(brak mapy)";
            this.BumpMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bump map:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadTextureButton
            // 
            this.LoadTextureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadTextureButton.Location = new System.Drawing.Point(3, 120);
            this.LoadTextureButton.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.LoadTextureButton.Name = "LoadTextureButton";
            this.LoadTextureButton.Size = new System.Drawing.Size(184, 23);
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
            this.BumpRadioButton.Size = new System.Drawing.Size(184, 27);
            this.BumpRadioButton.TabIndex = 4;
            this.BumpRadioButton.Text = "Tekstura + bump map";
            this.BumpRadioButton.UseVisualStyleBackColor = true;
            this.BumpRadioButton.CheckedChanged += new System.EventHandler(this.BumpRadioChanged);
            // 
            // TextureFileName
            // 
            this.TextureFileName.Location = new System.Drawing.Point(67, 97);
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
            this.TextureRadioButton.Size = new System.Drawing.Size(184, 27);
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
            this.VertexColorRadioButton.Size = new System.Drawing.Size(184, 27);
            this.VertexColorRadioButton.TabIndex = 0;
            this.VertexColorRadioButton.TabStop = true;
            this.VertexColorRadioButton.Text = "Z wierzchołków (interpolacja)";
            this.VertexColorRadioButton.UseVisualStyleBackColor = true;
            this.VertexColorRadioButton.CheckedChanged += new System.EventHandler(this.VertexColorRadioChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ColorPictureBox);
            this.groupBox4.Controls.Add(this.SetColorButton);
            this.groupBox4.Controls.Add(this.KsValue);
            this.groupBox4.Controls.Add(this.KdValue);
            this.groupBox4.Controls.Add(this.KsSlider);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.KdSlider);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.LampCheckBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 199);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Oświetlenie";
            // 
            // KsValue
            // 
            this.KsValue.AutoSize = true;
            this.KsValue.Location = new System.Drawing.Point(156, 101);
            this.KsValue.Name = "KsValue";
            this.KsValue.Size = new System.Drawing.Size(22, 13);
            this.KsValue.TabIndex = 6;
            this.KsValue.Text = "0.5";
            // 
            // KdValue
            // 
            this.KdValue.AutoSize = true;
            this.KdValue.Location = new System.Drawing.Point(156, 43);
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
            this.KsSlider.Size = new System.Drawing.Size(184, 45);
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
            this.KdSlider.Size = new System.Drawing.Size(184, 45);
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
            this.LampCheckBox.Size = new System.Drawing.Size(184, 27);
            this.LampCheckBox.TabIndex = 0;
            this.LampCheckBox.Text = "Włącz lampę";
            this.LampCheckBox.UseVisualStyleBackColor = true;
            this.LampCheckBox.CheckedChanged += new System.EventHandler(this.LampCheckBox_CheckedChanged);
            // 
            // SetColorButton
            // 
            this.SetColorButton.Location = new System.Drawing.Point(68, 160);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(112, 23);
            this.SetColorButton.TabIndex = 7;
            this.SetColorButton.Text = "Ustaw kolor światła";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.Location = new System.Drawing.Point(14, 160);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(40, 23);
            this.ColorPictureBox.TabIndex = 8;
            this.ColorPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(720, 720);
            this.Name = "Form1";
            this.Text = "Zadanie 1";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BitmapCanvas)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonSpeedSlider)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KsSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox BitmapCanvas;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RemoveVertexRadioButton;
        private System.Windows.Forms.RadioButton AddPolygonRadioButton;
        private System.Windows.Forms.RadioButton AddVertexRadioButton;
        private System.Windows.Forms.RadioButton SelectFigureRadioButton;
        private System.Windows.Forms.RadioButton SelectVertexRadioButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox AnimateCheckBox;
        private System.Windows.Forms.TrackBar PolygonSpeedSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearRandomsButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label TextureFileName;
        private System.Windows.Forms.RadioButton TextureRadioButton;
        private System.Windows.Forms.RadioButton VertexColorRadioButton;
        private System.Windows.Forms.Button LoadMapButton;
        private System.Windows.Forms.Label BumpMapName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadTextureButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton BumpRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar KsSlider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar KdSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox LampCheckBox;
        private System.Windows.Forms.Label KsValue;
        private System.Windows.Forms.Label KdValue;
        private System.Windows.Forms.PictureBox ColorPictureBox;
        private System.Windows.Forms.Button SetColorButton;
    }
}

