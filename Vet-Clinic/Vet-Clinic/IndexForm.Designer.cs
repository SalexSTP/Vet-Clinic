using System.ComponentModel;

namespace Vet_Clinic
{
    partial class AnimalsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AnimalsForm));
            labelTitle = new Label();
            imageListViewPets = new ListView();
            imageListPets = new ImageList(components);
            AddPetButton = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(390, 48);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(224, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Vet Clinic";
            // 
            // imageListViewPets
            // 
            imageListViewPets.LargeImageList = imageListPets;
            imageListViewPets.Location = new Point(45, 136);
            imageListViewPets.Name = "imageListViewPets";
            imageListViewPets.Size = new Size(891, 281);
            imageListViewPets.SmallImageList = imageListPets;
            imageListViewPets.TabIndex = 1;
            imageListViewPets.UseCompatibleStateImageBehavior = false;
            // 
            // imageListPets
            // 
            imageListPets.ColorDepth = ColorDepth.Depth16Bit;
            imageListPets.ImageStream = (ImageListStreamer)resources.GetObject("imageListPets.ImageStream");
            imageListPets.TransparentColor = Color.Transparent;
            imageListPets.Images.SetKeyName(0, "icons8-cat-48.png");
            imageListPets.Images.SetKeyName(1, "icons8-dog-100.png");
            // 
            // AddPetButton
            // 
            AddPetButton.BackColor = Color.FromArgb(20, 54, 66);
            AddPetButton.ForeColor = Color.White;
            AddPetButton.Location = new Point(788, 423);
            AddPetButton.Name = "AddPetButton";
            AddPetButton.Size = new Size(148, 40);
            AddPetButton.TabIndex = 2;
            AddPetButton.Text = "Add New Pet";
            AddPetButton.UseVisualStyleBackColor = false;
            // 
            // AnimalsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(984, 541);
            Controls.Add(AddPetButton);
            Controls.Add(imageListViewPets);
            Controls.Add(labelTitle);
            Name = "AnimalsForm";
            Text = "Vet Clinic";

            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private ListView imageListViewPets;
        private ImageList imageListPets;
        private Button AddPetButton;
    }
}
