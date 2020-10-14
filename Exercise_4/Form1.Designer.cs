namespace Exercise_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_test1 = new System.Windows.Forms.Button();
            this.button2_test2 = new System.Windows.Forms.Button();
            this.button3_test3 = new System.Windows.Forms.Button();
            this.button_BinaryBuild = new System.Windows.Forms.Button();
            this.label1_buildTime = new System.Windows.Forms.Label();
            this.label2_inOrderTime = new System.Windows.Forms.Label();
            this.label3_preOrderTime = new System.Windows.Forms.Label();
            this.label4_postOrderTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TextView = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.button_InOrder = new System.Windows.Forms.Button();
            this.button_PreOrder = new System.Windows.Forms.Button();
            this.button_PostOrder = new System.Windows.Forms.Button();
            this.textBox_InOrder = new System.Windows.Forms.TextBox();
            this.textBox_PostOrder = new System.Windows.Forms.TextBox();
            this.textBox_PreOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_test1
            // 
            this.button1_test1.Location = new System.Drawing.Point(22, 27);
            this.button1_test1.Name = "button1_test1";
            this.button1_test1.Size = new System.Drawing.Size(96, 34);
            this.button1_test1.TabIndex = 0;
            this.button1_test1.Text = "Test 1";
            this.button1_test1.UseVisualStyleBackColor = true;
            this.button1_test1.Click += new System.EventHandler(this.button1_test1_Click);
            // 
            // button2_test2
            // 
            this.button2_test2.Location = new System.Drawing.Point(22, 88);
            this.button2_test2.Name = "button2_test2";
            this.button2_test2.Size = new System.Drawing.Size(96, 34);
            this.button2_test2.TabIndex = 1;
            this.button2_test2.Text = "Test 2";
            this.button2_test2.UseVisualStyleBackColor = true;
            this.button2_test2.Click += new System.EventHandler(this.button2_test2_Click);
            // 
            // button3_test3
            // 
            this.button3_test3.Location = new System.Drawing.Point(22, 150);
            this.button3_test3.Name = "button3_test3";
            this.button3_test3.Size = new System.Drawing.Size(96, 34);
            this.button3_test3.TabIndex = 2;
            this.button3_test3.Text = "Test 3";
            this.button3_test3.UseVisualStyleBackColor = true;
            this.button3_test3.Click += new System.EventHandler(this.button3_test3_Click);
            // 
            // button_BinaryBuild
            // 
            this.button_BinaryBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_BinaryBuild.Location = new System.Drawing.Point(12, 214);
            this.button_BinaryBuild.Name = "button_BinaryBuild";
            this.button_BinaryBuild.Size = new System.Drawing.Size(116, 45);
            this.button_BinaryBuild.TabIndex = 5;
            this.button_BinaryBuild.Tag = "";
            this.button_BinaryBuild.Text = "BinaryBuild";
            this.button_BinaryBuild.UseVisualStyleBackColor = true;
            this.button_BinaryBuild.Click += new System.EventHandler(this.button_BinaryBuild_Click);
            // 
            // label1_buildTime
            // 
            this.label1_buildTime.BackColor = System.Drawing.Color.White;
            this.label1_buildTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1_buildTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_buildTime.ForeColor = System.Drawing.Color.Red;
            this.label1_buildTime.Location = new System.Drawing.Point(9, 274);
            this.label1_buildTime.Name = "label1_buildTime";
            this.label1_buildTime.Size = new System.Drawing.Size(132, 19);
            this.label1_buildTime.TabIndex = 6;
            this.label1_buildTime.Text = "0";
            this.label1_buildTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2_inOrderTime
            // 
            this.label2_inOrderTime.BackColor = System.Drawing.Color.White;
            this.label2_inOrderTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2_inOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_inOrderTime.Location = new System.Drawing.Point(9, 342);
            this.label2_inOrderTime.Name = "label2_inOrderTime";
            this.label2_inOrderTime.Size = new System.Drawing.Size(132, 19);
            this.label2_inOrderTime.TabIndex = 7;
            this.label2_inOrderTime.Text = "0";
            this.label2_inOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3_preOrderTime
            // 
            this.label3_preOrderTime.BackColor = System.Drawing.Color.White;
            this.label3_preOrderTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3_preOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_preOrderTime.Location = new System.Drawing.Point(9, 398);
            this.label3_preOrderTime.Name = "label3_preOrderTime";
            this.label3_preOrderTime.Size = new System.Drawing.Size(132, 19);
            this.label3_preOrderTime.TabIndex = 8;
            this.label3_preOrderTime.Text = "0";
            this.label3_preOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4_postOrderTime
            // 
            this.label4_postOrderTime.BackColor = System.Drawing.Color.White;
            this.label4_postOrderTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4_postOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_postOrderTime.Location = new System.Drawing.Point(9, 454);
            this.label4_postOrderTime.Name = "label4_postOrderTime";
            this.label4_postOrderTime.Size = new System.Drawing.Size(132, 19);
            this.label4_postOrderTime.TabIndex = 9;
            this.label4_postOrderTime.Text = "0";
            this.label4_postOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "In Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pre Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Post Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TextView
            // 
            this.textBox_TextView.BackColor = System.Drawing.Color.White;
            this.textBox_TextView.Location = new System.Drawing.Point(147, 12);
            this.textBox_TextView.Multiline = true;
            this.textBox_TextView.Name = "textBox_TextView";
            this.textBox_TextView.ReadOnly = true;
            this.textBox_TextView.Size = new System.Drawing.Size(189, 515);
            this.textBox_TextView.TabIndex = 13;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(343, 13);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(356, 514);
            this.treeView.TabIndex = 14;
            // 
            // button_InOrder
            // 
            this.button_InOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_InOrder.Location = new System.Drawing.Point(705, 489);
            this.button_InOrder.Name = "button_InOrder";
            this.button_InOrder.Size = new System.Drawing.Size(118, 38);
            this.button_InOrder.TabIndex = 15;
            this.button_InOrder.Text = "In Order";
            this.button_InOrder.UseVisualStyleBackColor = true;
            this.button_InOrder.Click += new System.EventHandler(this.button_InOrder_Click);
            // 
            // button_PreOrder
            // 
            this.button_PreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PreOrder.Location = new System.Drawing.Point(829, 489);
            this.button_PreOrder.Name = "button_PreOrder";
            this.button_PreOrder.Size = new System.Drawing.Size(118, 38);
            this.button_PreOrder.TabIndex = 16;
            this.button_PreOrder.Text = "Pre Order";
            this.button_PreOrder.UseVisualStyleBackColor = true;
            this.button_PreOrder.Click += new System.EventHandler(this.button_PreOrder_Click);
            // 
            // button_PostOrder
            // 
            this.button_PostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PostOrder.Location = new System.Drawing.Point(952, 489);
            this.button_PostOrder.Name = "button_PostOrder";
            this.button_PostOrder.Size = new System.Drawing.Size(118, 38);
            this.button_PostOrder.TabIndex = 17;
            this.button_PostOrder.Text = "Post Order";
            this.button_PostOrder.UseVisualStyleBackColor = true;
            this.button_PostOrder.Click += new System.EventHandler(this.button_PostOrder_Click);
            // 
            // textBox_InOrder
            // 
            this.textBox_InOrder.BackColor = System.Drawing.Color.White;
            this.textBox_InOrder.Location = new System.Drawing.Point(705, 12);
            this.textBox_InOrder.Multiline = true;
            this.textBox_InOrder.Name = "textBox_InOrder";
            this.textBox_InOrder.ReadOnly = true;
            this.textBox_InOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_InOrder.Size = new System.Drawing.Size(118, 471);
            this.textBox_InOrder.TabIndex = 18;
            // 
            // textBox_PostOrder
            // 
            this.textBox_PostOrder.BackColor = System.Drawing.Color.White;
            this.textBox_PostOrder.Location = new System.Drawing.Point(952, 13);
            this.textBox_PostOrder.Multiline = true;
            this.textBox_PostOrder.Name = "textBox_PostOrder";
            this.textBox_PostOrder.ReadOnly = true;
            this.textBox_PostOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_PostOrder.Size = new System.Drawing.Size(118, 471);
            this.textBox_PostOrder.TabIndex = 19;
            // 
            // textBox_PreOrder
            // 
            this.textBox_PreOrder.BackColor = System.Drawing.Color.White;
            this.textBox_PreOrder.Location = new System.Drawing.Point(829, 13);
            this.textBox_PreOrder.Multiline = true;
            this.textBox_PreOrder.Name = "textBox_PreOrder";
            this.textBox_PreOrder.ReadOnly = true;
            this.textBox_PreOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_PreOrder.Size = new System.Drawing.Size(118, 471);
            this.textBox_PreOrder.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 534);
            this.Controls.Add(this.textBox_PreOrder);
            this.Controls.Add(this.textBox_PostOrder);
            this.Controls.Add(this.textBox_InOrder);
            this.Controls.Add(this.button_PostOrder);
            this.Controls.Add(this.button_PreOrder);
            this.Controls.Add(this.button_InOrder);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.textBox_TextView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4_postOrderTime);
            this.Controls.Add(this.label3_preOrderTime);
            this.Controls.Add(this.label2_inOrderTime);
            this.Controls.Add(this.label1_buildTime);
            this.Controls.Add(this.button_BinaryBuild);
            this.Controls.Add(this.button3_test3);
            this.Controls.Add(this.button2_test2);
            this.Controls.Add(this.button1_test1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Павел Диянов Първанов ф.н.17621736 СИТ Курс: 3 Група: 2Б";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_test1;
        private System.Windows.Forms.Button button2_test2;
        private System.Windows.Forms.Button button3_test3;
        private System.Windows.Forms.Button button_BinaryBuild;
        private System.Windows.Forms.Label label1_buildTime;
        private System.Windows.Forms.Label label2_inOrderTime;
        private System.Windows.Forms.Label label3_preOrderTime;
        private System.Windows.Forms.Label label4_postOrderTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_InOrder;
        private System.Windows.Forms.Button button_PreOrder;
        private System.Windows.Forms.Button button_PostOrder;
        public System.Windows.Forms.TextBox textBox_TextView;
        public System.Windows.Forms.TreeView treeView;
        public System.Windows.Forms.TextBox textBox_InOrder;
        public System.Windows.Forms.TextBox textBox_PostOrder;
        public System.Windows.Forms.TextBox textBox_PreOrder;
    }
}

