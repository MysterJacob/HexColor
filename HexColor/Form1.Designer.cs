
namespace HexColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.color_chooser = new System.Windows.Forms.PictureBox();
            this.R_Color = new System.Windows.Forms.TrackBar();
            this.G_Color = new System.Windows.Forms.TrackBar();
            this.B_Color = new System.Windows.Forms.TrackBar();
            this.R_Color_Box = new System.Windows.Forms.TextBox();
            this.G_Color_Box = new System.Windows.Forms.TextBox();
            this.B_Color_Box = new System.Windows.Forms.TextBox();
            this.RGB_Value = new System.Windows.Forms.TextBox();
            this.Hex_Value = new System.Windows.Forms.TextBox();
            this.CMYK_Value = new System.Windows.Forms.TextBox();
            this.HSV_Color = new System.Windows.Forms.TrackBar();
            this.HSV_Value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.color_chooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // color_chooser
            // 
            this.color_chooser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color_chooser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_chooser.Cursor = System.Windows.Forms.Cursors.Cross;
            this.color_chooser.Location = new System.Drawing.Point(12, 12);
            this.color_chooser.Name = "color_chooser";
            this.color_chooser.Size = new System.Drawing.Size(350, 324);
            this.color_chooser.TabIndex = 0;
            this.color_chooser.TabStop = false;
            this.color_chooser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_chooser_MouseDown);
            this.color_chooser.MouseLeave += new System.EventHandler(this.color_chooser_MouseLeave);
            this.color_chooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.color_chooser_MouseUp);
            // 
            // R_Color
            // 
            this.R_Color.Location = new System.Drawing.Point(368, 12);
            this.R_Color.Maximum = 255;
            this.R_Color.Name = "R_Color";
            this.R_Color.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.R_Color.Size = new System.Drawing.Size(45, 324);
            this.R_Color.SmallChange = 0;
            this.R_Color.TabIndex = 1;
            this.R_Color.TickFrequency = 8;
            this.R_Color.Scroll += new System.EventHandler(this.R_color_Scroll);
            // 
            // G_Color
            // 
            this.G_Color.Location = new System.Drawing.Point(419, 12);
            this.G_Color.Maximum = 255;
            this.G_Color.Name = "G_Color";
            this.G_Color.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.G_Color.Size = new System.Drawing.Size(45, 324);
            this.G_Color.SmallChange = 0;
            this.G_Color.TabIndex = 2;
            this.G_Color.TickFrequency = 8;
            this.G_Color.Scroll += new System.EventHandler(this.G_color_Scroll);
            // 
            // B_Color
            // 
            this.B_Color.Location = new System.Drawing.Point(470, 12);
            this.B_Color.Maximum = 255;
            this.B_Color.Name = "B_Color";
            this.B_Color.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.B_Color.Size = new System.Drawing.Size(45, 324);
            this.B_Color.SmallChange = 0;
            this.B_Color.TabIndex = 3;
            this.B_Color.TickFrequency = 8;
            this.B_Color.Scroll += new System.EventHandler(this.B_Color_Scroll);
            // 
            // R_Color_Box
            // 
            this.R_Color_Box.Location = new System.Drawing.Point(364, 342);
            this.R_Color_Box.Name = "R_Color_Box";
            this.R_Color_Box.Size = new System.Drawing.Size(49, 20);
            this.R_Color_Box.TabIndex = 4;
            this.R_Color_Box.Text = "0";
            this.R_Color_Box.TextChanged += new System.EventHandler(this.R_Color_Box_TextChanged);
            // 
            // G_Color_Box
            // 
            this.G_Color_Box.Location = new System.Drawing.Point(415, 342);
            this.G_Color_Box.Name = "G_Color_Box";
            this.G_Color_Box.Size = new System.Drawing.Size(49, 20);
            this.G_Color_Box.TabIndex = 5;
            this.G_Color_Box.Text = "0";
            this.G_Color_Box.TextChanged += new System.EventHandler(this.G_Color_Box_TextChanged);
            // 
            // B_Color_Box
            // 
            this.B_Color_Box.Location = new System.Drawing.Point(466, 342);
            this.B_Color_Box.MaxLength = 3;
            this.B_Color_Box.Multiline = true;
            this.B_Color_Box.Name = "B_Color_Box";
            this.B_Color_Box.Size = new System.Drawing.Size(49, 20);
            this.B_Color_Box.TabIndex = 6;
            this.B_Color_Box.Text = "0";
            this.B_Color_Box.TextChanged += new System.EventHandler(this.B_Color_Box_TextChanged);
            // 
            // RGB_Value
            // 
            this.RGB_Value.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RGB_Value.Location = new System.Drawing.Point(521, 24);
            this.RGB_Value.Name = "RGB_Value";
            this.RGB_Value.ReadOnly = true;
            this.RGB_Value.Size = new System.Drawing.Size(157, 27);
            this.RGB_Value.TabIndex = 7;
            this.RGB_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hex_Value
            // 
            this.Hex_Value.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hex_Value.Location = new System.Drawing.Point(521, 50);
            this.Hex_Value.Name = "Hex_Value";
            this.Hex_Value.ReadOnly = true;
            this.Hex_Value.Size = new System.Drawing.Size(157, 27);
            this.Hex_Value.TabIndex = 8;
            this.Hex_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CMYK_Value
            // 
            this.CMYK_Value.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CMYK_Value.Location = new System.Drawing.Point(521, 76);
            this.CMYK_Value.Name = "CMYK_Value";
            this.CMYK_Value.ReadOnly = true;
            this.CMYK_Value.Size = new System.Drawing.Size(157, 27);
            this.CMYK_Value.TabIndex = 9;
            this.CMYK_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HSV_Color
            // 
            this.HSV_Color.Location = new System.Drawing.Point(12, 342);
            this.HSV_Color.Maximum = 360;
            this.HSV_Color.Name = "HSV_Color";
            this.HSV_Color.Size = new System.Drawing.Size(350, 45);
            this.HSV_Color.SmallChange = 0;
            this.HSV_Color.TabIndex = 11;
            this.HSV_Color.Scroll += new System.EventHandler(this.HSV_Color_Scroll);
            // 
            // HSV_Value
            // 
            this.HSV_Value.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HSV_Value.Location = new System.Drawing.Point(521, 100);
            this.HSV_Value.Name = "HSV_Value";
            this.HSV_Value.ReadOnly = true;
            this.HSV_Value.Size = new System.Drawing.Size(157, 27);
            this.HSV_Value.TabIndex = 12;
            this.HSV_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HSV_Value.TextChanged += new System.EventHandler(this.HSV_Value_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 377);
            this.Controls.Add(this.HSV_Value);
            this.Controls.Add(this.HSV_Color);
            this.Controls.Add(this.CMYK_Value);
            this.Controls.Add(this.Hex_Value);
            this.Controls.Add(this.RGB_Value);
            this.Controls.Add(this.B_Color_Box);
            this.Controls.Add(this.G_Color_Box);
            this.Controls.Add(this.R_Color_Box);
            this.Controls.Add(this.B_Color);
            this.Controls.Add(this.G_Color);
            this.Controls.Add(this.R_Color);
            this.Controls.Add(this.color_chooser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.color_chooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_Color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox color_chooser;
        private System.Windows.Forms.TrackBar R_Color;
        private System.Windows.Forms.TrackBar G_Color;
        private System.Windows.Forms.TrackBar B_Color;
        private System.Windows.Forms.TextBox R_Color_Box;
        private System.Windows.Forms.TextBox G_Color_Box;
        private System.Windows.Forms.TextBox B_Color_Box;
        private System.Windows.Forms.TextBox RGB_Value;
        private System.Windows.Forms.TextBox Hex_Value;
        private System.Windows.Forms.TextBox CMYK_Value;
        private System.Windows.Forms.TrackBar HSV_Color;
        private System.Windows.Forms.TextBox HSV_Value;
    }
}

