
namespace maskBits
{
    partial class BitwiseOperator
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
            this.firstBinary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.operatorSelection = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.endValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstBinary
            // 
            this.firstBinary.AutoSize = true;
            this.firstBinary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstBinary.Location = new System.Drawing.Point(35, 114);
            this.firstBinary.Name = "firstBinary";
            this.firstBinary.Size = new System.Drawing.Size(81, 21);
            this.firstBinary.TabIndex = 0;
            this.firstBinary.Text = "1st Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd Value:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(122, 114);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 20);
            this.value1.TabIndex = 2;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(122, 153);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(100, 20);
            this.value2.TabIndex = 3;
            // 
            // operatorSelection
            // 
            this.operatorSelection.FormattingEnabled = true;
            this.operatorSelection.Items.AddRange(new object[] {
            "&",
            "|"});
            this.operatorSelection.Location = new System.Drawing.Point(228, 133);
            this.operatorSelection.Name = "operatorSelection";
            this.operatorSelection.Size = new System.Drawing.Size(37, 21);
            this.operatorSelection.TabIndex = 4;
            this.operatorSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endValue
            // 
            this.endValue.Location = new System.Drawing.Point(122, 202);
            this.endValue.Name = "endValue";
            this.endValue.Size = new System.Drawing.Size(100, 20);
            this.endValue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bitwise Operation Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output:";
            // 
            // dataType
            // 
            this.dataType.FormattingEnabled = true;
            this.dataType.Items.AddRange(new object[] {
            "Decimal",
            "Hexadecimal",
            "Binary"});
            this.dataType.Location = new System.Drawing.Point(122, 75);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(75, 21);
            this.dataType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Type:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Crimson;
            this.warningLabel.Location = new System.Drawing.Point(259, 202);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 21);
            this.warningLabel.TabIndex = 11;
            // 
            // BitwiseOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 319);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operatorSelection);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstBinary);
            this.Name = "BitwiseOperator";
            this.Text = "Bitwise Operation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.ComboBox operatorSelection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox endValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dataType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label warningLabel;
    }
}

