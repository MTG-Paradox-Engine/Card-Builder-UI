namespace Card_Builder
{
    partial class CardCreator
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.Build_Button = new System.Windows.Forms.Button();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Power = new System.Windows.Forms.ComboBox();
            this.CB_Toughness = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_colors = new System.Windows.Forms.ListBox();
            this.B_ADD = new System.Windows.Forms.Button();
            this.B_REMOVE = new System.Windows.Forms.Button();
            this.LB_Selc_Colors = new System.Windows.Forms.ListBox();
            this.LB_Type = new System.Windows.Forms.ListBox();
            this.B_Remove_Type = new System.Windows.Forms.Button();
            this.B_Add_Type = new System.Windows.Forms.Button();
            this.TB_Type = new System.Windows.Forms.TextBox();
            this.TB_Subtype = new System.Windows.Forms.TextBox();
            this.B_Remove_Sub = new System.Windows.Forms.Button();
            this.B_Add_Sub = new System.Windows.Forms.Button();
            this.LB_Sub = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(88, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(92, 156);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 15);
            label5.TabIndex = 15;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(79, 281);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 15);
            label6.TabIndex = 20;
            label6.Text = "SubType";
            // 
            // Build_Button
            // 
            this.Build_Button.Location = new System.Drawing.Point(76, 487);
            this.Build_Button.Name = "Build_Button";
            this.Build_Button.Size = new System.Drawing.Size(75, 23);
            this.Build_Button.TabIndex = 0;
            this.Build_Button.Text = "Build";
            this.Build_Button.UseVisualStyleBackColor = true;
            this.Build_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(78, 12);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(100, 20);
            this.TB_NAME.TabIndex = 1;
            this.TB_NAME.Text = "<Name>";
            this.TB_NAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Power";
            // 
            // CB_Power
            // 
            this.CB_Power.DisplayMember = "1";
            this.CB_Power.FormattingEnabled = true;
            this.CB_Power.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "*"});
            this.CB_Power.Location = new System.Drawing.Point(88, 427);
            this.CB_Power.Name = "CB_Power";
            this.CB_Power.Size = new System.Drawing.Size(100, 21);
            this.CB_Power.TabIndex = 4;
            // 
            // CB_Toughness
            // 
            this.CB_Toughness.FormattingEnabled = true;
            this.CB_Toughness.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "*"});
            this.CB_Toughness.Location = new System.Drawing.Point(88, 457);
            this.CB_Toughness.Name = "CB_Toughness";
            this.CB_Toughness.Size = new System.Drawing.Size(100, 21);
            this.CB_Toughness.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toughness";
            // 
            // LB_colors
            // 
            this.LB_colors.FormattingEnabled = true;
            this.LB_colors.Items.AddRange(new object[] {
            "White",
            "Blue",
            "Black",
            "Red",
            "Green",
            "Colorless"});
            this.LB_colors.Location = new System.Drawing.Point(12, 64);
            this.LB_colors.Name = "LB_colors";
            this.LB_colors.Size = new System.Drawing.Size(60, 82);
            this.LB_colors.TabIndex = 7;
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(88, 77);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(63, 23);
            this.B_ADD.TabIndex = 9;
            this.B_ADD.Text = "Add";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // B_REMOVE
            // 
            this.B_REMOVE.Location = new System.Drawing.Point(88, 106);
            this.B_REMOVE.Name = "B_REMOVE";
            this.B_REMOVE.Size = new System.Drawing.Size(63, 23);
            this.B_REMOVE.TabIndex = 10;
            this.B_REMOVE.Text = "Remove";
            this.B_REMOVE.UseVisualStyleBackColor = true;
            this.B_REMOVE.Click += new System.EventHandler(this.B_REMOVE_Click);
            // 
            // LB_Selc_Colors
            // 
            this.LB_Selc_Colors.FormattingEnabled = true;
            this.LB_Selc_Colors.Location = new System.Drawing.Point(164, 64);
            this.LB_Selc_Colors.Name = "LB_Selc_Colors";
            this.LB_Selc_Colors.Size = new System.Drawing.Size(60, 82);
            this.LB_Selc_Colors.TabIndex = 11;
            // 
            // LB_Type
            // 
            this.LB_Type.FormattingEnabled = true;
            this.LB_Type.Location = new System.Drawing.Point(124, 183);
            this.LB_Type.Name = "LB_Type";
            this.LB_Type.Size = new System.Drawing.Size(100, 95);
            this.LB_Type.TabIndex = 12;
            // 
            // B_Remove_Type
            // 
            this.B_Remove_Type.Location = new System.Drawing.Point(25, 238);
            this.B_Remove_Type.Name = "B_Remove_Type";
            this.B_Remove_Type.Size = new System.Drawing.Size(63, 23);
            this.B_Remove_Type.TabIndex = 14;
            this.B_Remove_Type.Text = "Remove";
            this.B_Remove_Type.UseVisualStyleBackColor = true;
            this.B_Remove_Type.Click += new System.EventHandler(this.B_Remove_Type_Click);
            // 
            // B_Add_Type
            // 
            this.B_Add_Type.Location = new System.Drawing.Point(25, 209);
            this.B_Add_Type.Name = "B_Add_Type";
            this.B_Add_Type.Size = new System.Drawing.Size(63, 23);
            this.B_Add_Type.TabIndex = 13;
            this.B_Add_Type.Text = "Add";
            this.B_Add_Type.UseVisualStyleBackColor = true;
            this.B_Add_Type.Click += new System.EventHandler(this.B_Add_Type_Click);
            // 
            // TB_Type
            // 
            this.TB_Type.Location = new System.Drawing.Point(12, 183);
            this.TB_Type.Name = "TB_Type";
            this.TB_Type.Size = new System.Drawing.Size(89, 20);
            this.TB_Type.TabIndex = 16;
            this.TB_Type.Text = "<Type>";
            // 
            // TB_Subtype
            // 
            this.TB_Subtype.Location = new System.Drawing.Point(12, 308);
            this.TB_Subtype.Name = "TB_Subtype";
            this.TB_Subtype.Size = new System.Drawing.Size(89, 20);
            this.TB_Subtype.TabIndex = 21;
            this.TB_Subtype.Text = "<Subtype>";
            // 
            // B_Remove_Sub
            // 
            this.B_Remove_Sub.Location = new System.Drawing.Point(25, 363);
            this.B_Remove_Sub.Name = "B_Remove_Sub";
            this.B_Remove_Sub.Size = new System.Drawing.Size(63, 23);
            this.B_Remove_Sub.TabIndex = 19;
            this.B_Remove_Sub.Text = "Remove";
            this.B_Remove_Sub.UseVisualStyleBackColor = true;
            this.B_Remove_Sub.Click += new System.EventHandler(this.B_Remove_Sub_Click);
            // 
            // B_Add_Sub
            // 
            this.B_Add_Sub.Location = new System.Drawing.Point(25, 334);
            this.B_Add_Sub.Name = "B_Add_Sub";
            this.B_Add_Sub.Size = new System.Drawing.Size(63, 23);
            this.B_Add_Sub.TabIndex = 18;
            this.B_Add_Sub.Text = "Add";
            this.B_Add_Sub.UseVisualStyleBackColor = true;
            this.B_Add_Sub.Click += new System.EventHandler(this.B_Add_Sub_Click);
            // 
            // LB_Sub
            // 
            this.LB_Sub.FormattingEnabled = true;
            this.LB_Sub.Location = new System.Drawing.Point(124, 308);
            this.LB_Sub.Name = "LB_Sub";
            this.LB_Sub.Size = new System.Drawing.Size(100, 95);
            this.LB_Sub.TabIndex = 17;
            // 
            // CardCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 517);
            this.Controls.Add(this.TB_Subtype);
            this.Controls.Add(label6);
            this.Controls.Add(this.B_Remove_Sub);
            this.Controls.Add(this.B_Add_Sub);
            this.Controls.Add(this.LB_Sub);
            this.Controls.Add(this.TB_Type);
            this.Controls.Add(label5);
            this.Controls.Add(this.B_Remove_Type);
            this.Controls.Add(this.B_Add_Type);
            this.Controls.Add(this.LB_Type);
            this.Controls.Add(this.LB_Selc_Colors);
            this.Controls.Add(this.B_REMOVE);
            this.Controls.Add(this.B_ADD);
            this.Controls.Add(label4);
            this.Controls.Add(this.LB_colors);
            this.Controls.Add(this.CB_Toughness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Power);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.Build_Button);
            this.Name = "CardCreator";
            this.Text = "Card Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Build_Button;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Power;
        private System.Windows.Forms.ComboBox CB_Toughness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LB_colors;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Button B_REMOVE;
        private System.Windows.Forms.ListBox LB_Selc_Colors;
        private System.Windows.Forms.ListBox LB_Type;
        private System.Windows.Forms.Button B_Remove_Type;
        private System.Windows.Forms.Button B_Add_Type;
        private System.Windows.Forms.TextBox TB_Type;
        private System.Windows.Forms.TextBox TB_Subtype;
        private System.Windows.Forms.Button B_Remove_Sub;
        private System.Windows.Forms.Button B_Add_Sub;
        private System.Windows.Forms.ListBox LB_Sub;
    }
}

