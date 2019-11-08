namespace ImageProcessing
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
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnFlipV = new System.Windows.Forms.Button();
            this.btnFlipH = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnPixelate = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSwitchCorner = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnEdgeDetection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(352, 12);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(86, 23);
            this.btnTransform.TabIndex = 5;
            this.btnTransform.Text = "Green Filter";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(257, 258);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(320, 240);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(444, 12);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(88, 23);
            this.btnLighten.TabIndex = 6;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(444, 41);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(88, 23);
            this.btnDarken.TabIndex = 7;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(444, 70);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(88, 23);
            this.btnNegative.TabIndex = 8;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(444, 99);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(88, 23);
            this.btnSunset.TabIndex = 9;
            this.btnSunset.Text = "Sunset Effect";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnFlipV
            // 
            this.btnFlipV.Location = new System.Drawing.Point(444, 129);
            this.btnFlipV.Name = "btnFlipV";
            this.btnFlipV.Size = new System.Drawing.Size(88, 23);
            this.btnFlipV.TabIndex = 10;
            this.btnFlipV.Text = "Flip Vertically";
            this.btnFlipV.UseVisualStyleBackColor = true;
            this.btnFlipV.Click += new System.EventHandler(this.btnFlipV_Click);
            // 
            // btnFlipH
            // 
            this.btnFlipH.Location = new System.Drawing.Point(444, 159);
            this.btnFlipH.Name = "btnFlipH";
            this.btnFlipH.Size = new System.Drawing.Size(88, 23);
            this.btnFlipH.TabIndex = 11;
            this.btnFlipH.Text = "Flip Horizontally";
            this.btnFlipH.UseVisualStyleBackColor = true;
            this.btnFlipH.Click += new System.EventHandler(this.btnFlipH_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(444, 189);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(88, 23);
            this.btnRotate180.TabIndex = 12;
            this.btnRotate180.Text = "Rotate 180";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.Location = new System.Drawing.Point(352, 42);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(86, 23);
            this.btnGrayScale.TabIndex = 13;
            this.btnGrayScale.Text = "GrayScale";
            this.btnGrayScale.UseVisualStyleBackColor = true;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(444, 219);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(88, 23);
            this.btnPolarize.TabIndex = 14;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnPixelate
            // 
            this.btnPixelate.Location = new System.Drawing.Point(444, 248);
            this.btnPixelate.Name = "btnPixelate";
            this.btnPixelate.Size = new System.Drawing.Size(88, 23);
            this.btnPixelate.TabIndex = 15;
            this.btnPixelate.Text = "Pixelate";
            this.btnPixelate.UseVisualStyleBackColor = true;
            this.btnPixelate.Click += new System.EventHandler(this.btnPixelate_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(444, 278);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(88, 23);
            this.btnBlur.TabIndex = 16;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnSwitchCorner
            // 
            this.btnSwitchCorner.Location = new System.Drawing.Point(352, 70);
            this.btnSwitchCorner.Name = "btnSwitchCorner";
            this.btnSwitchCorner.Size = new System.Drawing.Size(86, 23);
            this.btnSwitchCorner.TabIndex = 17;
            this.btnSwitchCorner.Text = "Switch Corners";
            this.btnSwitchCorner.UseVisualStyleBackColor = true;
            this.btnSwitchCorner.Click += new System.EventHandler(this.btnSwitchCorner_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(352, 99);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(86, 23);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(154, 299);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 19;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(76, 331);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 20;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(233, 330);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 21;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(154, 359);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 22;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnEdgeDetection
            // 
            this.btnEdgeDetection.Location = new System.Drawing.Point(352, 129);
            this.btnEdgeDetection.Name = "btnEdgeDetection";
            this.btnEdgeDetection.Size = new System.Drawing.Size(86, 23);
            this.btnEdgeDetection.TabIndex = 23;
            this.btnEdgeDetection.Text = "Find Edges";
            this.btnEdgeDetection.UseVisualStyleBackColor = true;
            this.btnEdgeDetection.Click += new System.EventHandler(this.btnEdgeDetection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 476);
            this.Controls.Add(this.btnEdgeDetection);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSwitchCorner);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnPixelate);
            this.Controls.Add(this.btnPolarize);
            this.Controls.Add(this.btnGrayScale);
            this.Controls.Add(this.btnRotate180);
            this.Controls.Add(this.btnFlipH);
            this.Controls.Add(this.btnFlipV);
            this.Controls.Add(this.btnSunset);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnDarken);
            this.Controls.Add(this.btnLighten);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnFlipV;
        private System.Windows.Forms.Button btnFlipH;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnGrayScale;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnPixelate;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSwitchCorner;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnEdgeDetection;
    }
}

