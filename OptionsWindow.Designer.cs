namespace Polaris
{
    partial class OptionsWindow
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOKSave = new System.Windows.Forms.Button();
            this.btnHourColor = new System.Windows.Forms.Button();
            this.btnMinuteColor = new System.Windows.Forms.Button();
            this.btnSecondColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpacing = new System.Windows.Forms.TextBox();
            this.txtBrushWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.chk24Hour = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOKSave
            // 
            this.btnOKSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOKSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKSave.Location = new System.Drawing.Point(15, 165);
            this.btnOKSave.Name = "btnOKSave";
            this.btnOKSave.Size = new System.Drawing.Size(87, 27);
            this.btnOKSave.TabIndex = 2;
            this.btnOKSave.Text = "OK";
            this.btnOKSave.UseVisualStyleBackColor = true;
            this.btnOKSave.Click += new System.EventHandler(this.btnOKSave_Click);
            // 
            // btnHourColor
            // 
            this.btnHourColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHourColor.Location = new System.Drawing.Point(98, 7);
            this.btnHourColor.Name = "btnHourColor";
            this.btnHourColor.Size = new System.Drawing.Size(90, 29);
            this.btnHourColor.TabIndex = 3;
            this.btnHourColor.UseVisualStyleBackColor = true;
            this.btnHourColor.Click += new System.EventHandler(this.btnHourColor_Click);
            // 
            // btnMinuteColor
            // 
            this.btnMinuteColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinuteColor.Location = new System.Drawing.Point(98, 43);
            this.btnMinuteColor.Name = "btnMinuteColor";
            this.btnMinuteColor.Size = new System.Drawing.Size(90, 29);
            this.btnMinuteColor.TabIndex = 4;
            this.btnMinuteColor.UseVisualStyleBackColor = true;
            this.btnMinuteColor.Click += new System.EventHandler(this.btnMinuteColor_Click);
            // 
            // btnSecondColor
            // 
            this.btnSecondColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondColor.Location = new System.Drawing.Point(98, 79);
            this.btnSecondColor.Name = "btnSecondColor";
            this.btnSecondColor.Size = new System.Drawing.Size(90, 29);
            this.btnSecondColor.TabIndex = 5;
            this.btnSecondColor.UseVisualStyleBackColor = true;
            this.btnSecondColor.Click += new System.EventHandler(this.btnSecondColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hour Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minute Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Second Color:";
            // 
            // txtSpacing
            // 
            this.txtSpacing.Location = new System.Drawing.Point(295, 11);
            this.txtSpacing.Name = "txtSpacing";
            this.txtSpacing.Size = new System.Drawing.Size(48, 23);
            this.txtSpacing.TabIndex = 11;
            // 
            // txtBrushWeight
            // 
            this.txtBrushWeight.Location = new System.Drawing.Point(295, 48);
            this.txtBrushWeight.Name = "txtBrushWeight";
            this.txtBrushWeight.Size = new System.Drawing.Size(48, 23);
            this.txtBrushWeight.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Spacing (px):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Brush Weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Back Color:";
            // 
            // btnBackColor
            // 
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(98, 115);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(90, 29);
            this.btnBackColor.TabIndex = 15;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // chk24Hour
            // 
            this.chk24Hour.AutoSize = true;
            this.chk24Hour.Location = new System.Drawing.Point(211, 88);
            this.chk24Hour.Name = "chk24Hour";
            this.chk24Hour.Size = new System.Drawing.Size(132, 19);
            this.chk24Hour.TabIndex = 17;
            this.chk24Hour.Text = "24 hour time format";
            this.chk24Hour.UseVisualStyleBackColor = true;
            // 
            // OptionsWindow
            // 
            this.AcceptButton = this.btnOKSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(359, 205);
            this.Controls.Add(this.chk24Hour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrushWeight);
            this.Controls.Add(this.txtSpacing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecondColor);
            this.Controls.Add(this.btnMinuteColor);
            this.Controls.Add(this.btnHourColor);
            this.Controls.Add(this.btnOKSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Options";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOKSave;
        private System.Windows.Forms.Button btnHourColor;
        private System.Windows.Forms.Button btnMinuteColor;
        private System.Windows.Forms.Button btnSecondColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpacing;
        private System.Windows.Forms.TextBox txtBrushWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.CheckBox chk24Hour;
    }
}