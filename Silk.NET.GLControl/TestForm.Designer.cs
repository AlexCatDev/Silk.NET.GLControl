namespace Silk.NET.GLControl
{
    partial class TestForm
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
            this.glControl1 = new Silk.NET.WinForms.GLControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.API = Silk.NET.Windowing.ContextAPI.OpenGL;
            this.glControl1.APIVersion = new System.Version(3, 3, 0, 0);
            this.glControl1.Flags = Silk.NET.Windowing.ContextFlags.Default;
            this.glControl1.IsEventDriven = true;
            this.glControl1.Location = new System.Drawing.Point(12, 12);
            this.glControl1.Name = "glControl1";
            this.glControl1.Profile = Silk.NET.Windowing.ContextProfile.Core;
            this.glControl1.Size = new System.Drawing.Size(387, 426);
            this.glControl1.TabIndex = 0;
            this.glControl1.Text = "glControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.glControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WinForms.GLControl glControl1;
        private Button button1;
    }
}