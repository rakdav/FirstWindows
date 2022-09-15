namespace FirstWindows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbMilliKilometr = new System.Windows.Forms.CheckBox();
            this.txtMilliKilometers = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbMilliKilometr
            // 
            this.chbMilliKilometr.AutoSize = true;
            this.chbMilliKilometr.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbMilliKilometr.Location = new System.Drawing.Point(34, 12);
            this.chbMilliKilometr.Name = "chbMilliKilometr";
            this.chbMilliKilometr.Size = new System.Drawing.Size(242, 34);
            this.chbMilliKilometr.TabIndex = 0;
            this.chbMilliKilometr.Text = "Милли->Километры";
            this.chbMilliKilometr.UseVisualStyleBackColor = true;
            this.chbMilliKilometr.CheckedChanged += new System.EventHandler(this.chbMilliKilometr_CheckedChanged);
            // 
            // txtMilliKilometers
            // 
            this.txtMilliKilometers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMilliKilometers.Location = new System.Drawing.Point(34, 53);
            this.txtMilliKilometers.Name = "txtMilliKilometers";
            this.txtMilliKilometers.Size = new System.Drawing.Size(142, 36);
            this.txtMilliKilometers.TabIndex = 1;
            this.txtMilliKilometers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilliKilometers_KeyPress);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(192, 53);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 37);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Перевести";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(34, 97);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(293, 62);
            this.lbResult.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 174);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtMilliKilometers);
            this.Controls.Add(this.chbMilliKilometr);
            this.Name = "MainForm";
            this.Text = "Милли-километры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chbMilliKilometr;
        private TextBox txtMilliKilometers;
        private Button btnChange;
        private Label lbResult;
    }
}