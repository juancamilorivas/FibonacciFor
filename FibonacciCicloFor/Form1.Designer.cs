namespace FibonacciCicloFor
{
    partial class Form1
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
            this.numberInput = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(44, 69);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(116, 23);
            this.numberInput.TabIndex = 0;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(60, 109);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(84, 23);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Calcular";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 209);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.numberInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numberInput;
        private Button agregar;
    }
}