namespace _3_62
{
    partial class Main_F
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Group_B = new System.Windows.Forms.Button();
            this.Select_GB = new System.Windows.Forms.GroupBox();
            this.Select2_NUD = new System.Windows.Forms.NumericUpDown();
            this.Select1_NUD = new System.Windows.Forms.NumericUpDown();
            this.Select_B = new System.Windows.Forms.Button();
            this.Select_L = new System.Windows.Forms.Label();
            this.Sort_B = new System.Windows.Forms.Button();
            this.Where_GB = new System.Windows.Forms.GroupBox();
            this.Where_B = new System.Windows.Forms.Button();
            this.Where_TB = new System.Windows.Forms.TextBox();
            this.Where_L = new System.Windows.Forms.Label();
            this.Product_GB = new System.Windows.Forms.GroupBox();
            this.WeightProduct_NUD = new System.Windows.Forms.NumericUpDown();
            this.AddProduct_B = new System.Windows.Forms.Button();
            this.WeightProduct_L = new System.Windows.Forms.Label();
            this.ColorProduct_TB = new System.Windows.Forms.TextBox();
            this.ColorProduct_L = new System.Windows.Forms.Label();
            this.NameProduct_TB = new System.Windows.Forms.TextBox();
            this.NameProduct_L = new System.Windows.Forms.Label();
            this.DelProduct_B = new System.Windows.Forms.Button();
            this.Product_DGV = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_DGV = new System.Windows.Forms.DataGridView();
            this.Product_L = new System.Windows.Forms.Label();
            this.Result_L = new System.Windows.Forms.Label();
            this.ProductBS = new System.Windows.Forms.BindingSource(this.components);
            this.ResultBS = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Select_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Select2_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select1_NUD)).BeginInit();
            this.Where_GB.SuspendLayout();
            this.Product_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightProduct_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBS)).BeginInit();
            this.SuspendLayout();
            // 
            // Group_B
            // 
            this.Group_B.Location = new System.Drawing.Point(427, 519);
            this.Group_B.Name = "Group_B";
            this.Group_B.Size = new System.Drawing.Size(343, 41);
            this.Group_B.TabIndex = 20;
            this.Group_B.Text = "Группировка товаров по цвету с определнием суммарного веса товаров каждого цвета";
            this.Group_B.UseVisualStyleBackColor = true;
            this.Group_B.Click += new System.EventHandler(this.Group_B_Click);
            // 
            // Select_GB
            // 
            this.Select_GB.Controls.Add(this.Select2_NUD);
            this.Select_GB.Controls.Add(this.Select1_NUD);
            this.Select_GB.Controls.Add(this.Select_B);
            this.Select_GB.Controls.Add(this.Select_L);
            this.Select_GB.Location = new System.Drawing.Point(427, 391);
            this.Select_GB.Name = "Select_GB";
            this.Select_GB.Size = new System.Drawing.Size(343, 122);
            this.Select_GB.TabIndex = 19;
            this.Select_GB.TabStop = false;
            this.Select_GB.Text = "Отбор по заданому диапозону весу с созданием класса";
            // 
            // Select2_NUD
            // 
            this.Select2_NUD.DecimalPlaces = 1;
            this.Select2_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Select2_NUD.Location = new System.Drawing.Point(257, 34);
            this.Select2_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Select2_NUD.Name = "Select2_NUD";
            this.Select2_NUD.Size = new System.Drawing.Size(69, 20);
            this.Select2_NUD.TabIndex = 9;
            this.Select2_NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Select1_NUD
            // 
            this.Select1_NUD.DecimalPlaces = 1;
            this.Select1_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Select1_NUD.Location = new System.Drawing.Point(177, 34);
            this.Select1_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Select1_NUD.Name = "Select1_NUD";
            this.Select1_NUD.Size = new System.Drawing.Size(74, 20);
            this.Select1_NUD.TabIndex = 8;
            this.Select1_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Select_B
            // 
            this.Select_B.Location = new System.Drawing.Point(7, 60);
            this.Select_B.Name = "Select_B";
            this.Select_B.Size = new System.Drawing.Size(330, 55);
            this.Select_B.TabIndex = 2;
            this.Select_B.Text = "Отбор и создание класса с весом и объединением с названием и цветом";
            this.Select_B.UseVisualStyleBackColor = true;
            this.Select_B.Click += new System.EventHandler(this.Select_B_Click);
            // 
            // Select_L
            // 
            this.Select_L.AutoSize = true;
            this.Select_L.Location = new System.Drawing.Point(7, 36);
            this.Select_L.Name = "Select_L";
            this.Select_L.Size = new System.Drawing.Size(58, 13);
            this.Select_L.TabIndex = 0;
            this.Select_L.Text = "Диапозон";
            // 
            // Sort_B
            // 
            this.Sort_B.Location = new System.Drawing.Point(427, 343);
            this.Sort_B.Name = "Sort_B";
            this.Sort_B.Size = new System.Drawing.Size(343, 41);
            this.Sort_B.TabIndex = 18;
            this.Sort_B.Text = "Сортировка по убыванию веса и возрастанию наименования";
            this.Sort_B.UseVisualStyleBackColor = true;
            this.Sort_B.Click += new System.EventHandler(this.Sort_B_Click);
            // 
            // Where_GB
            // 
            this.Where_GB.Controls.Add(this.Where_B);
            this.Where_GB.Controls.Add(this.Where_TB);
            this.Where_GB.Controls.Add(this.Where_L);
            this.Where_GB.Location = new System.Drawing.Point(427, 231);
            this.Where_GB.Name = "Where_GB";
            this.Where_GB.Size = new System.Drawing.Size(343, 102);
            this.Where_GB.TabIndex = 17;
            this.Where_GB.TabStop = false;
            this.Where_GB.Text = "Отбор товара заданого цвета";
            // 
            // Where_B
            // 
            this.Where_B.Location = new System.Drawing.Point(155, 63);
            this.Where_B.Name = "Where_B";
            this.Where_B.Size = new System.Drawing.Size(182, 23);
            this.Where_B.TabIndex = 2;
            this.Where_B.Text = "Отбор";
            this.Where_B.UseVisualStyleBackColor = true;
            this.Where_B.Click += new System.EventHandler(this.Where_B_Click);
            // 
            // Where_TB
            // 
            this.Where_TB.Location = new System.Drawing.Point(155, 31);
            this.Where_TB.Name = "Where_TB";
            this.Where_TB.Size = new System.Drawing.Size(182, 20);
            this.Where_TB.TabIndex = 1;
            // 
            // Where_L
            // 
            this.Where_L.AutoSize = true;
            this.Where_L.Location = new System.Drawing.Point(7, 31);
            this.Where_L.Name = "Where_L";
            this.Where_L.Size = new System.Drawing.Size(32, 13);
            this.Where_L.TabIndex = 0;
            this.Where_L.Text = "Цвет";
            // 
            // Product_GB
            // 
            this.Product_GB.Controls.Add(this.WeightProduct_NUD);
            this.Product_GB.Controls.Add(this.AddProduct_B);
            this.Product_GB.Controls.Add(this.WeightProduct_L);
            this.Product_GB.Controls.Add(this.ColorProduct_TB);
            this.Product_GB.Controls.Add(this.ColorProduct_L);
            this.Product_GB.Controls.Add(this.NameProduct_TB);
            this.Product_GB.Controls.Add(this.NameProduct_L);
            this.Product_GB.Location = new System.Drawing.Point(12, 262);
            this.Product_GB.Name = "Product_GB";
            this.Product_GB.Size = new System.Drawing.Size(343, 159);
            this.Product_GB.TabIndex = 16;
            this.Product_GB.TabStop = false;
            this.Product_GB.Text = "Добавление товара";
            // 
            // WeightProduct_NUD
            // 
            this.WeightProduct_NUD.DecimalPlaces = 1;
            this.WeightProduct_NUD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WeightProduct_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.WeightProduct_NUD.Location = new System.Drawing.Point(180, 84);
            this.WeightProduct_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.WeightProduct_NUD.Name = "WeightProduct_NUD";
            this.WeightProduct_NUD.Size = new System.Drawing.Size(157, 20);
            this.WeightProduct_NUD.TabIndex = 7;
            this.WeightProduct_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // AddProduct_B
            // 
            this.AddProduct_B.Location = new System.Drawing.Point(180, 121);
            this.AddProduct_B.Name = "AddProduct_B";
            this.AddProduct_B.Size = new System.Drawing.Size(157, 23);
            this.AddProduct_B.TabIndex = 6;
            this.AddProduct_B.Text = "Добавить товара";
            this.AddProduct_B.UseVisualStyleBackColor = true;
            this.AddProduct_B.Click += new System.EventHandler(this.AddProduct_B_Click);
            // 
            // WeightProduct_L
            // 
            this.WeightProduct_L.AutoSize = true;
            this.WeightProduct_L.Location = new System.Drawing.Point(6, 84);
            this.WeightProduct_L.Name = "WeightProduct_L";
            this.WeightProduct_L.Size = new System.Drawing.Size(26, 13);
            this.WeightProduct_L.TabIndex = 4;
            this.WeightProduct_L.Text = "Вес";
            // 
            // ColorProduct_TB
            // 
            this.ColorProduct_TB.Location = new System.Drawing.Point(180, 55);
            this.ColorProduct_TB.Name = "ColorProduct_TB";
            this.ColorProduct_TB.Size = new System.Drawing.Size(157, 20);
            this.ColorProduct_TB.TabIndex = 3;
            // 
            // ColorProduct_L
            // 
            this.ColorProduct_L.AutoSize = true;
            this.ColorProduct_L.Location = new System.Drawing.Point(6, 58);
            this.ColorProduct_L.Name = "ColorProduct_L";
            this.ColorProduct_L.Size = new System.Drawing.Size(32, 13);
            this.ColorProduct_L.TabIndex = 2;
            this.ColorProduct_L.Text = "Цвет";
            // 
            // NameProduct_TB
            // 
            this.NameProduct_TB.Location = new System.Drawing.Point(180, 29);
            this.NameProduct_TB.Name = "NameProduct_TB";
            this.NameProduct_TB.Size = new System.Drawing.Size(157, 20);
            this.NameProduct_TB.TabIndex = 1;
            // 
            // NameProduct_L
            // 
            this.NameProduct_L.AutoSize = true;
            this.NameProduct_L.Location = new System.Drawing.Point(6, 32);
            this.NameProduct_L.Name = "NameProduct_L";
            this.NameProduct_L.Size = new System.Drawing.Size(95, 13);
            this.NameProduct_L.TabIndex = 0;
            this.NameProduct_L.Text = "Название товара";
            // 
            // DelProduct_B
            // 
            this.DelProduct_B.Location = new System.Drawing.Point(12, 232);
            this.DelProduct_B.Name = "DelProduct_B";
            this.DelProduct_B.Size = new System.Drawing.Size(343, 23);
            this.DelProduct_B.TabIndex = 15;
            this.DelProduct_B.Text = "Удалить выбраный товар";
            this.DelProduct_B.UseVisualStyleBackColor = true;
            this.DelProduct_B.Click += new System.EventHandler(this.DelProduct_B_Click);
            // 
            // Product_DGV
            // 
            this.Product_DGV.AllowUserToAddRows = false;
            this.Product_DGV.AllowUserToDeleteRows = false;
            this.Product_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ColorColumn,
            this.WeightColumn});
            this.Product_DGV.Location = new System.Drawing.Point(12, 32);
            this.Product_DGV.Name = "Product_DGV";
            this.Product_DGV.ReadOnly = true;
            this.Product_DGV.RowHeadersVisible = false;
            this.Product_DGV.Size = new System.Drawing.Size(343, 193);
            this.Product_DGV.TabIndex = 14;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название товара";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // ColorColumn
            // 
            this.ColorColumn.DataPropertyName = "Color";
            this.ColorColumn.HeaderText = "Цвет";
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.ReadOnly = true;
            // 
            // WeightColumn
            // 
            this.WeightColumn.DataPropertyName = "Weight";
            this.WeightColumn.HeaderText = "Вес";
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, -70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Результат";
            // 
            // Result_DGV
            // 
            this.Result_DGV.AllowUserToAddRows = false;
            this.Result_DGV.AllowUserToDeleteRows = false;
            this.Result_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_DGV.Location = new System.Drawing.Point(427, 32);
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.ReadOnly = true;
            this.Result_DGV.RowHeadersVisible = false;
            this.Result_DGV.Size = new System.Drawing.Size(343, 193);
            this.Result_DGV.TabIndex = 12;
            // 
            // Product_L
            // 
            this.Product_L.AutoSize = true;
            this.Product_L.Location = new System.Drawing.Point(12, 16);
            this.Product_L.Name = "Product_L";
            this.Product_L.Size = new System.Drawing.Size(38, 13);
            this.Product_L.TabIndex = 11;
            this.Product_L.Text = "Товар";
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(424, 16);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(59, 13);
            this.Result_L.TabIndex = 21;
            this.Result_L.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.Group_B);
            this.Controls.Add(this.Select_GB);
            this.Controls.Add(this.Sort_B);
            this.Controls.Add(this.Where_GB);
            this.Controls.Add(this.Product_GB);
            this.Controls.Add(this.DelProduct_B);
            this.Controls.Add(this.Product_DGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result_DGV);
            this.Controls.Add(this.Product_L);
            this.Name = "Main_F";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_F_Load);
            this.Select_GB.ResumeLayout(false);
            this.Select_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Select2_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select1_NUD)).EndInit();
            this.Where_GB.ResumeLayout(false);
            this.Where_GB.PerformLayout();
            this.Product_GB.ResumeLayout(false);
            this.Product_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightProduct_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Group_B;
        private System.Windows.Forms.GroupBox Select_GB;
        private System.Windows.Forms.NumericUpDown Select2_NUD;
        private System.Windows.Forms.NumericUpDown Select1_NUD;
        private System.Windows.Forms.Button Select_B;
        private System.Windows.Forms.Label Select_L;
        private System.Windows.Forms.Button Sort_B;
        private System.Windows.Forms.GroupBox Where_GB;
        private System.Windows.Forms.Button Where_B;
        private System.Windows.Forms.TextBox Where_TB;
        private System.Windows.Forms.Label Where_L;
        private System.Windows.Forms.GroupBox Product_GB;
        private System.Windows.Forms.NumericUpDown WeightProduct_NUD;
        private System.Windows.Forms.Button AddProduct_B;
        private System.Windows.Forms.Label WeightProduct_L;
        private System.Windows.Forms.TextBox ColorProduct_TB;
        private System.Windows.Forms.Label ColorProduct_L;
        private System.Windows.Forms.TextBox NameProduct_TB;
        private System.Windows.Forms.Label NameProduct_L;
        private System.Windows.Forms.Button DelProduct_B;
        private System.Windows.Forms.DataGridView Product_DGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Result_DGV;
        private System.Windows.Forms.Label Product_L;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.BindingSource ProductBS;
        private System.Windows.Forms.BindingSource ResultBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
        private System.Windows.Forms.Button button1;
    }
}

