﻿namespace SimpleThreads
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.threadTwo = new System.Windows.Forms.Button();
            this.threadOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // threadTwo
            // 
            this.threadTwo.Location = new System.Drawing.Point(12, 109);
            this.threadTwo.Name = "threadTwo";
            this.threadTwo.Size = new System.Drawing.Size(127, 23);
            this.threadTwo.TabIndex = 0;
            this.threadTwo.Text = "Thread 2";
            this.threadTwo.UseVisualStyleBackColor = true;
            this.threadTwo.Click += new System.EventHandler(this.threadTwo_Click);
            // 
            // threadOne
            // 
            this.threadOne.Location = new System.Drawing.Point(12, 80);
            this.threadOne.Name = "threadOne";
            this.threadOne.Size = new System.Drawing.Size(127, 23);
            this.threadOne.TabIndex = 1;
            this.threadOne.Text = "Thread 1";
            this.threadOne.UseVisualStyleBackColor = true;
            this.threadOne.Click += new System.EventHandler(this.threadOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensaje a mostrar";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 37);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(122, 20);
            this.txt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 143);
            this.ControlBox = false;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threadOne);
            this.Controls.Add(this.threadTwo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button threadTwo;
        private System.Windows.Forms.Button threadOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
    }
}

