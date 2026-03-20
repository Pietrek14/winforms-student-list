using dpiotrowski_lab1.Models;
using dpiotrowski_lab1.Views;

namespace dpiotrowski_lab1
{
    partial class StudentForm : Form
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
            main = new TableLayoutPanel();
            studentListHeader = new Label();
            formHeader = new Label();
            formsContainer = new SplitContainer();
            basicForm = new GroupBox();
            basicFormLayout = new TableLayoutPanel();
            yearOfStudiesInputLabel = new Label();
            dateOfBirthInputLabel = new Label();
            lastNameInput = new TextBox();
            lastNameInputLabel = new Label();
            nameInputLabel = new Label();
            nameInput = new TextBox();
            dateOfBirthInput = new DateTimePicker();
            yearOfStudyInput = new ComboBox();
            addressForm = new GroupBox();
            addressFormLayout = new TableLayoutPanel();
            flatInputLabel = new Label();
            buildingInput = new TextBox();
            buildingInputLabel = new Label();
            streetInput = new TextBox();
            streetInputLabel = new Label();
            postalCodeInputLabel = new Label();
            cityInputLabel = new Label();
            cityInput = new TextBox();
            postalCodeInputLayout = new TableLayoutPanel();
            postalCodeInput2 = new TextBox();
            postalCodeDash = new Label();
            postalCodeInput1 = new TextBox();
            flatInputLayout = new TableLayoutPanel();
            flatInputCheckBox = new CheckBox();
            flatInput = new TextBox();
            studentFormButtonLayout = new TableLayoutPanel();
            dropStudentButton = new Button();
            editStudentButton = new Button();
            addStudentButton = new Button();
            studentListContainer = new TableLayoutPanel();
            studentList = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            loadStudentListButton = new Button();
            saveStudentListButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            saveStudentsToFileDialog = new SaveFileDialog();
            loadStudentsFromFileDialog = new OpenFileDialog();
            main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formsContainer).BeginInit();
            formsContainer.Panel1.SuspendLayout();
            formsContainer.Panel2.SuspendLayout();
            formsContainer.SuspendLayout();
            basicForm.SuspendLayout();
            basicFormLayout.SuspendLayout();
            addressForm.SuspendLayout();
            addressFormLayout.SuspendLayout();
            postalCodeInputLayout.SuspendLayout();
            flatInputLayout.SuspendLayout();
            studentFormButtonLayout.SuspendLayout();
            studentListContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // main
            // 
            main.ColumnCount = 2;
            main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            main.Controls.Add(studentListHeader, 1, 0);
            main.Controls.Add(formHeader, 0, 0);
            main.Controls.Add(formsContainer, 0, 1);
            main.Controls.Add(studentFormButtonLayout, 0, 2);
            main.Controls.Add(studentListContainer, 1, 1);
            main.Controls.Add(tableLayoutPanel1, 1, 2);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 0);
            main.Name = "main";
            main.RowCount = 3;
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            main.Size = new Size(887, 506);
            main.TabIndex = 0;
            // 
            // studentListHeader
            // 
            studentListHeader.Anchor = AnchorStyles.Left;
            studentListHeader.AutoSize = true;
            studentListHeader.Font = new Font("Segoe UI", 14F);
            studentListHeader.Location = new Point(453, 3);
            studentListHeader.Margin = new Padding(10, 0, 0, 0);
            studentListHeader.Name = "studentListHeader";
            studentListHeader.Size = new Size(143, 25);
            studentListHeader.TabIndex = 5;
            studentListHeader.Text = "Lista studentów";
            studentListHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formHeader
            // 
            formHeader.Anchor = AnchorStyles.Left;
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 14F);
            formHeader.Location = new Point(10, 3);
            formHeader.Margin = new Padding(10, 0, 0, 0);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(205, 25);
            formHeader.TabIndex = 0;
            formHeader.Text = "Dodaj studenta do listy";
            formHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formsContainer
            // 
            formsContainer.Dock = DockStyle.Fill;
            formsContainer.Location = new Point(3, 35);
            formsContainer.Name = "formsContainer";
            formsContainer.Orientation = Orientation.Horizontal;
            // 
            // formsContainer.Panel1
            // 
            formsContainer.Panel1.Controls.Add(basicForm);
            formsContainer.Panel1.Padding = new Padding(10);
            // 
            // formsContainer.Panel2
            // 
            formsContainer.Panel2.Controls.Add(addressForm);
            formsContainer.Panel2.Padding = new Padding(10);
            formsContainer.Size = new Size(437, 372);
            formsContainer.SplitterDistance = 174;
            formsContainer.TabIndex = 1;
            // 
            // basicForm
            // 
            basicForm.Controls.Add(basicFormLayout);
            basicForm.Dock = DockStyle.Fill;
            basicForm.Location = new Point(10, 10);
            basicForm.Name = "basicForm";
            basicForm.Size = new Size(417, 154);
            basicForm.TabIndex = 0;
            basicForm.TabStop = false;
            basicForm.Text = "Dane podstawowe";
            // 
            // basicFormLayout
            // 
            basicFormLayout.ColumnCount = 2;
            basicFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            basicFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            basicFormLayout.Controls.Add(yearOfStudiesInputLabel, 0, 3);
            basicFormLayout.Controls.Add(dateOfBirthInputLabel, 0, 2);
            basicFormLayout.Controls.Add(lastNameInput, 1, 1);
            basicFormLayout.Controls.Add(lastNameInputLabel, 0, 1);
            basicFormLayout.Controls.Add(nameInputLabel, 0, 0);
            basicFormLayout.Controls.Add(nameInput, 1, 0);
            basicFormLayout.Controls.Add(dateOfBirthInput, 1, 2);
            basicFormLayout.Controls.Add(yearOfStudyInput, 1, 3);
            basicFormLayout.Dock = DockStyle.Fill;
            basicFormLayout.Location = new Point(3, 19);
            basicFormLayout.Name = "basicFormLayout";
            basicFormLayout.RowCount = 4;
            basicFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            basicFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            basicFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            basicFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            basicFormLayout.Size = new Size(411, 132);
            basicFormLayout.TabIndex = 0;
            // 
            // yearOfStudiesInputLabel
            // 
            yearOfStudiesInputLabel.AutoSize = true;
            yearOfStudiesInputLabel.Dock = DockStyle.Fill;
            yearOfStudiesInputLabel.Location = new Point(3, 99);
            yearOfStudiesInputLabel.Name = "yearOfStudiesInputLabel";
            yearOfStudiesInputLabel.Size = new Size(199, 33);
            yearOfStudiesInputLabel.TabIndex = 6;
            yearOfStudiesInputLabel.Text = "Rok studiów";
            yearOfStudiesInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateOfBirthInputLabel
            // 
            dateOfBirthInputLabel.AutoSize = true;
            dateOfBirthInputLabel.Dock = DockStyle.Fill;
            dateOfBirthInputLabel.Location = new Point(3, 66);
            dateOfBirthInputLabel.Name = "dateOfBirthInputLabel";
            dateOfBirthInputLabel.Size = new Size(199, 33);
            dateOfBirthInputLabel.TabIndex = 4;
            dateOfBirthInputLabel.Text = "Data urodzenia";
            dateOfBirthInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lastNameInput
            // 
            lastNameInput.Dock = DockStyle.Fill;
            lastNameInput.Location = new Point(208, 36);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(200, 23);
            lastNameInput.TabIndex = 3;
            lastNameInput.KeyPress += _allowLettersAndWhitespace;
            // 
            // lastNameInputLabel
            // 
            lastNameInputLabel.AutoSize = true;
            lastNameInputLabel.Dock = DockStyle.Fill;
            lastNameInputLabel.Location = new Point(3, 33);
            lastNameInputLabel.Name = "lastNameInputLabel";
            lastNameInputLabel.Size = new Size(199, 33);
            lastNameInputLabel.TabIndex = 2;
            lastNameInputLabel.Text = "Nazwisko";
            lastNameInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameInputLabel
            // 
            nameInputLabel.AutoSize = true;
            nameInputLabel.Dock = DockStyle.Fill;
            nameInputLabel.Location = new Point(3, 0);
            nameInputLabel.Name = "nameInputLabel";
            nameInputLabel.Size = new Size(199, 33);
            nameInputLabel.TabIndex = 0;
            nameInputLabel.Text = "Imię";
            nameInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Fill;
            nameInput.Location = new Point(208, 3);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(200, 23);
            nameInput.TabIndex = 1;
            nameInput.KeyPress += _allowLettersAndWhitespace;
            // 
            // dateOfBirthInput
            // 
            dateOfBirthInput.CalendarFont = new Font("Segoe UI", 9F);
            dateOfBirthInput.Dock = DockStyle.Fill;
            dateOfBirthInput.Location = new Point(208, 69);
            dateOfBirthInput.Name = "dateOfBirthInput";
            dateOfBirthInput.Size = new Size(200, 23);
            dateOfBirthInput.TabIndex = 5;
            dateOfBirthInput.Value = new DateTime(2026, 3, 13, 0, 0, 0, 0);
            // 
            // yearOfStudyInput
            // 
            yearOfStudyInput.Dock = DockStyle.Fill;
            yearOfStudyInput.FormattingEnabled = true;
            yearOfStudyInput.Items.AddRange(new object[] { "I", "II", "III" });
            yearOfStudyInput.Location = new Point(208, 102);
            yearOfStudyInput.Name = "yearOfStudyInput";
            yearOfStudyInput.Size = new Size(200, 23);
            yearOfStudyInput.TabIndex = 7;
            // 
            // addressForm
            // 
            addressForm.Controls.Add(addressFormLayout);
            addressForm.Dock = DockStyle.Fill;
            addressForm.Location = new Point(10, 10);
            addressForm.Name = "addressForm";
            addressForm.Size = new Size(417, 174);
            addressForm.TabIndex = 0;
            addressForm.TabStop = false;
            addressForm.Text = "Dane adresowe";
            // 
            // addressFormLayout
            // 
            addressFormLayout.ColumnCount = 2;
            addressFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addressFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addressFormLayout.Controls.Add(flatInputLabel, 0, 4);
            addressFormLayout.Controls.Add(buildingInput, 1, 3);
            addressFormLayout.Controls.Add(buildingInputLabel, 0, 3);
            addressFormLayout.Controls.Add(streetInput, 1, 2);
            addressFormLayout.Controls.Add(streetInputLabel, 0, 2);
            addressFormLayout.Controls.Add(postalCodeInputLabel, 0, 1);
            addressFormLayout.Controls.Add(cityInputLabel, 0, 0);
            addressFormLayout.Controls.Add(cityInput, 1, 0);
            addressFormLayout.Controls.Add(postalCodeInputLayout, 1, 1);
            addressFormLayout.Controls.Add(flatInputLayout, 1, 4);
            addressFormLayout.Dock = DockStyle.Fill;
            addressFormLayout.Location = new Point(3, 19);
            addressFormLayout.Name = "addressFormLayout";
            addressFormLayout.RowCount = 5;
            addressFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addressFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addressFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addressFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addressFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addressFormLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            addressFormLayout.Size = new Size(411, 152);
            addressFormLayout.TabIndex = 0;
            // 
            // flatInputLabel
            // 
            flatInputLabel.AutoSize = true;
            flatInputLabel.Dock = DockStyle.Fill;
            flatInputLabel.Location = new Point(3, 120);
            flatInputLabel.Name = "flatInputLabel";
            flatInputLabel.Size = new Size(199, 32);
            flatInputLabel.TabIndex = 10;
            flatInputLabel.Text = "Numer mieszkania";
            flatInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buildingInput
            // 
            buildingInput.Dock = DockStyle.Fill;
            buildingInput.Location = new Point(208, 93);
            buildingInput.Name = "buildingInput";
            buildingInput.Size = new Size(200, 23);
            buildingInput.TabIndex = 9;
            buildingInput.KeyPress += _allowAlphanumeric;
            // 
            // buildingInputLabel
            // 
            buildingInputLabel.AutoSize = true;
            buildingInputLabel.Dock = DockStyle.Fill;
            buildingInputLabel.Location = new Point(3, 90);
            buildingInputLabel.Name = "buildingInputLabel";
            buildingInputLabel.Size = new Size(199, 30);
            buildingInputLabel.TabIndex = 8;
            buildingInputLabel.Text = "Numer budynku";
            buildingInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // streetInput
            // 
            streetInput.Dock = DockStyle.Fill;
            streetInput.Location = new Point(208, 63);
            streetInput.Name = "streetInput";
            streetInput.Size = new Size(200, 23);
            streetInput.TabIndex = 7;
            // 
            // streetInputLabel
            // 
            streetInputLabel.AutoSize = true;
            streetInputLabel.Dock = DockStyle.Fill;
            streetInputLabel.Location = new Point(3, 60);
            streetInputLabel.Name = "streetInputLabel";
            streetInputLabel.Size = new Size(199, 30);
            streetInputLabel.TabIndex = 6;
            streetInputLabel.Text = "Ulica";
            streetInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // postalCodeInputLabel
            // 
            postalCodeInputLabel.AutoSize = true;
            postalCodeInputLabel.Dock = DockStyle.Fill;
            postalCodeInputLabel.Location = new Point(3, 30);
            postalCodeInputLabel.Name = "postalCodeInputLabel";
            postalCodeInputLabel.Size = new Size(199, 30);
            postalCodeInputLabel.TabIndex = 2;
            postalCodeInputLabel.Text = "Kod pocztowy";
            postalCodeInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cityInputLabel
            // 
            cityInputLabel.AutoSize = true;
            cityInputLabel.Dock = DockStyle.Fill;
            cityInputLabel.Location = new Point(3, 0);
            cityInputLabel.Name = "cityInputLabel";
            cityInputLabel.Size = new Size(199, 30);
            cityInputLabel.TabIndex = 0;
            cityInputLabel.Text = "Miejscowość";
            cityInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cityInput
            // 
            cityInput.Dock = DockStyle.Fill;
            cityInput.Location = new Point(208, 3);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(200, 23);
            cityInput.TabIndex = 1;
            cityInput.KeyPress += _allowLettersAndWhitespace;
            // 
            // postalCodeInputLayout
            // 
            postalCodeInputLayout.ColumnCount = 3;
            postalCodeInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.0096016F));
            postalCodeInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2076836F));
            postalCodeInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.78272F));
            postalCodeInputLayout.Controls.Add(postalCodeInput2, 2, 0);
            postalCodeInputLayout.Controls.Add(postalCodeDash, 1, 0);
            postalCodeInputLayout.Controls.Add(postalCodeInput1, 0, 0);
            postalCodeInputLayout.Dock = DockStyle.Fill;
            postalCodeInputLayout.Location = new Point(205, 30);
            postalCodeInputLayout.Margin = new Padding(0);
            postalCodeInputLayout.Name = "postalCodeInputLayout";
            postalCodeInputLayout.RowCount = 1;
            postalCodeInputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            postalCodeInputLayout.Size = new Size(206, 30);
            postalCodeInputLayout.TabIndex = 5;
            // 
            // postalCodeInput2
            // 
            postalCodeInput2.Dock = DockStyle.Fill;
            postalCodeInput2.Location = new Point(91, 3);
            postalCodeInput2.MaxLength = 3;
            postalCodeInput2.Name = "postalCodeInput2";
            postalCodeInput2.Size = new Size(112, 23);
            postalCodeInput2.TabIndex = 4;
            postalCodeInput2.KeyPress += _allowDigits;
            // 
            // postalCodeDash
            // 
            postalCodeDash.AutoSize = true;
            postalCodeDash.Dock = DockStyle.Fill;
            postalCodeDash.Location = new Point(52, 0);
            postalCodeDash.Name = "postalCodeDash";
            postalCodeDash.Size = new Size(33, 30);
            postalCodeDash.TabIndex = 0;
            postalCodeDash.Text = "-";
            postalCodeDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // postalCodeInput1
            // 
            postalCodeInput1.Dock = DockStyle.Fill;
            postalCodeInput1.Location = new Point(3, 3);
            postalCodeInput1.MaxLength = 2;
            postalCodeInput1.Name = "postalCodeInput1";
            postalCodeInput1.Size = new Size(43, 23);
            postalCodeInput1.TabIndex = 3;
            postalCodeInput1.KeyPress += _allowDigits;
            // 
            // flatInputLayout
            // 
            flatInputLayout.ColumnCount = 2;
            flatInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            flatInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            flatInputLayout.Controls.Add(flatInputCheckBox, 1, 0);
            flatInputLayout.Controls.Add(flatInput, 0, 0);
            flatInputLayout.Location = new Point(208, 123);
            flatInputLayout.Name = "flatInputLayout";
            flatInputLayout.RowCount = 1;
            flatInputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            flatInputLayout.Size = new Size(200, 26);
            flatInputLayout.TabIndex = 11;
            // 
            // flatInputCheckBox
            // 
            flatInputCheckBox.AutoSize = true;
            flatInputCheckBox.Dock = DockStyle.Fill;
            flatInputCheckBox.Location = new Point(139, 3);
            flatInputCheckBox.Name = "flatInputCheckBox";
            flatInputCheckBox.Size = new Size(58, 20);
            flatInputCheckBox.TabIndex = 0;
            flatInputCheckBox.Text = "tak";
            flatInputCheckBox.UseVisualStyleBackColor = true;
            flatInputCheckBox.CheckedChanged += flatInputCheckBox_CheckedChanged;
            // 
            // flatInput
            // 
            flatInput.Dock = DockStyle.Fill;
            flatInput.Location = new Point(3, 3);
            flatInput.Name = "flatInput";
            flatInput.Size = new Size(130, 23);
            flatInput.TabIndex = 1;
            flatInput.KeyPress += _allowDigits;
            // 
            // studentFormButtonLayout
            // 
            studentFormButtonLayout.ColumnCount = 1;
            studentFormButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            studentFormButtonLayout.Controls.Add(dropStudentButton, 0, 2);
            studentFormButtonLayout.Controls.Add(editStudentButton, 0, 1);
            studentFormButtonLayout.Controls.Add(addStudentButton, 0, 0);
            studentFormButtonLayout.Dock = DockStyle.Fill;
            studentFormButtonLayout.Location = new Point(3, 413);
            studentFormButtonLayout.Name = "studentFormButtonLayout";
            studentFormButtonLayout.RowCount = 3;
            studentFormButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            studentFormButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            studentFormButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            studentFormButtonLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            studentFormButtonLayout.Size = new Size(437, 90);
            studentFormButtonLayout.TabIndex = 3;
            // 
            // dropStudentButton
            // 
            dropStudentButton.BackColor = Color.SaddleBrown;
            dropStudentButton.Dock = DockStyle.Fill;
            dropStudentButton.ForeColor = Color.White;
            dropStudentButton.Location = new Point(3, 63);
            dropStudentButton.Name = "dropStudentButton";
            dropStudentButton.Size = new Size(431, 24);
            dropStudentButton.TabIndex = 2;
            dropStudentButton.Text = "Usuń studenta";
            dropStudentButton.UseVisualStyleBackColor = false;
            // 
            // editStudentButton
            // 
            editStudentButton.BackColor = Color.Blue;
            editStudentButton.Dock = DockStyle.Fill;
            editStudentButton.ForeColor = Color.White;
            editStudentButton.Location = new Point(3, 33);
            editStudentButton.Name = "editStudentButton";
            editStudentButton.Size = new Size(431, 24);
            editStudentButton.TabIndex = 1;
            editStudentButton.Text = "Edytuj dane studenta";
            editStudentButton.UseVisualStyleBackColor = false;
            // 
            // addStudentButton
            // 
            addStudentButton.BackColor = Color.ForestGreen;
            addStudentButton.Dock = DockStyle.Fill;
            addStudentButton.ForeColor = Color.White;
            addStudentButton.Location = new Point(3, 3);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(431, 24);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "Dodaj studenta";
            addStudentButton.UseVisualStyleBackColor = false;
            // 
            // studentListContainer
            // 
            studentListContainer.ColumnCount = 1;
            studentListContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            studentListContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            studentListContainer.Controls.Add(studentList, 0, 0);
            studentListContainer.Dock = DockStyle.Fill;
            studentListContainer.Location = new Point(446, 35);
            studentListContainer.Name = "studentListContainer";
            studentListContainer.Padding = new Padding(3);
            studentListContainer.RowCount = 1;
            studentListContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            studentListContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            studentListContainer.Size = new Size(438, 372);
            studentListContainer.TabIndex = 4;
            // 
            // studentList
            // 
            studentList.Dock = DockStyle.Fill;
            studentList.FormattingEnabled = true;
            studentList.ItemHeight = 15;
            studentList.Location = new Point(6, 6);
            studentList.Name = "studentList";
            studentList.Size = new Size(426, 360);
            studentList.TabIndex = 2;
            studentList.SelectedValueChanged += _studentListSelectedItemChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(loadStudentListButton, 0, 1);
            tableLayoutPanel1.Controls.Add(saveStudentListButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(446, 413);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(438, 90);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // loadStudentListButton
            // 
            loadStudentListButton.BackColor = Color.MidnightBlue;
            loadStudentListButton.Dock = DockStyle.Fill;
            loadStudentListButton.ForeColor = Color.White;
            loadStudentListButton.Location = new Point(3, 33);
            loadStudentListButton.Name = "loadStudentListButton";
            loadStudentListButton.Size = new Size(432, 24);
            loadStudentListButton.TabIndex = 3;
            loadStudentListButton.Text = "Wczytaj listę studentów";
            loadStudentListButton.UseVisualStyleBackColor = false;
            // 
            // saveStudentListButton
            // 
            saveStudentListButton.BackColor = Color.DarkTurquoise;
            saveStudentListButton.Dock = DockStyle.Fill;
            saveStudentListButton.ForeColor = Color.White;
            saveStudentListButton.Location = new Point(3, 3);
            saveStudentListButton.Name = "saveStudentListButton";
            saveStudentListButton.Size = new Size(432, 24);
            saveStudentListButton.TabIndex = 2;
            saveStudentListButton.Text = "Zapisz listę studentów";
            saveStudentListButton.UseVisualStyleBackColor = false;
            saveStudentListButton.Click += saveStudentListButton_Click;
            // 
            // saveStudentsToFileDialog
            // 
            saveStudentsToFileDialog.Title = "Zapisz listę studentów";
            // 
            // loadStudentsFromFileDialog
            // 
            loadStudentsFromFileDialog.FileName = "openFileDialog1";
            loadStudentsFromFileDialog.Title = "Wczytaj listę studentów";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 506);
            Controls.Add(main);
            Name = "StudentForm";
            Text = "Lista studentów";
            main.ResumeLayout(false);
            main.PerformLayout();
            formsContainer.Panel1.ResumeLayout(false);
            formsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)formsContainer).EndInit();
            formsContainer.ResumeLayout(false);
            basicForm.ResumeLayout(false);
            basicFormLayout.ResumeLayout(false);
            basicFormLayout.PerformLayout();
            addressForm.ResumeLayout(false);
            addressFormLayout.ResumeLayout(false);
            addressFormLayout.PerformLayout();
            postalCodeInputLayout.ResumeLayout(false);
            postalCodeInputLayout.PerformLayout();
            flatInputLayout.ResumeLayout(false);
            flatInputLayout.PerformLayout();
            studentFormButtonLayout.ResumeLayout(false);
            studentListContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel main;
        private Label formHeader;
        private SplitContainer formsContainer;
        private GroupBox basicForm;
        private GroupBox addressForm;
        private TableLayoutPanel basicFormLayout;
        private Label nameInputLabel;
        private ListBox studentList;
        private TextBox nameInput;
        private Label lastNameInputLabel;
        private TextBox lastNameInput;
        private Label dateOfBirthInputLabel;
        private DateTimePicker dateOfBirthInput;
        private Label yearOfStudiesInputLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox yearOfStudyInput;
        private TableLayoutPanel addressFormLayout;
        private Label cityInputLabel;
        private Label postalCodeInputLabel;
        private TextBox cityInput;
        private TextBox postalCodeInput1;
        private TableLayoutPanel postalCodeInputLayout;
        private TextBox postalCodeInput2;
        private Label postalCodeDash;
        private Label flatInputLabel;
        private TextBox buildingInput;
        private Label buildingInputLabel;
        private TextBox streetInput;
        private Label streetInputLabel;
        private TableLayoutPanel studentFormButtonLayout;
        private TableLayoutPanel studentListContainer;
        private Label studentListHeader;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addStudentButton;
        private Button editStudentButton;
        private Button dropStudentButton;
        private Button loadStudentListButton;
        private Button saveStudentListButton;
        private TableLayoutPanel flatInputLayout;
        private CheckBox flatInputCheckBox;
        private TextBox flatInput;
        private SaveFileDialog saveStudentsToFileDialog;
        private OpenFileDialog loadStudentsFromFileDialog;
    }
}
