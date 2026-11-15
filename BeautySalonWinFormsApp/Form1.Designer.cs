namespace BeautySalonWinFormsApp
{
    partial class FormBeautySalon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            MenuStrip1 = new MenuStrip();
            MenuItemFile = new ToolStripMenuItem();
            MenuItemExit = new ToolStripMenuItem();
            MenuItemHelp = new ToolStripMenuItem();
            MenuItemAbout = new ToolStripMenuItem();
            tabControlMain = new TabControl();
            tabPageServices = new TabPage();
            groupBoxSearchService = new GroupBox();
            ButtonReset = new Button();
            buttonSearchService = new Button();
            textBoxSearchServiceTitle = new TextBox();
            labelSearchServiceTitle = new Label();
            buttonDeleteService = new Button();
            buttonAddService = new Button();
            dataGridViewServices = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            ButtonEdit = new DataGridViewLinkColumn();
            ButtonDelete = new DataGridViewButtonColumn();
            tabPageMasters = new TabPage();
            groupBoxSearchMaster = new GroupBox();
            buttonResetMasterPhone = new Button();
            buttonResetMasterSpecialization = new Button();
            buttonResetMasterPatronymic = new Button();
            buttonResetMasterLastName = new Button();
            buttonResetMasterFirstName = new Button();
            buttonSearchMaster = new Button();
            textBoxSearchMasterPhone = new TextBox();
            labelSearchMasterPhone = new Label();
            textBoxSearchMasterSpecialization = new TextBox();
            labelSearchMasterSpecialization = new Label();
            textBoxSearchMasterPatronymic = new TextBox();
            labelSearchMasterPatronymic = new Label();
            textBoxSearchMasterLastName = new TextBox();
            labelSearchMasterLastName = new Label();
            textBoxSearchMasterFirstName = new TextBox();
            labelSearchMasterFirstName = new Label();
            buttonDeleteMaster = new Button();
            buttonAddMaster = new Button();
            dataGridViewMasters = new DataGridView();
            idMasterColumn = new DataGridViewTextBoxColumn();
            firstNameMasterColumn = new DataGridViewTextBoxColumn();
            lastNameMasterColumn = new DataGridViewTextBoxColumn();
            PatronymicMasterColumn = new DataGridViewTextBoxColumn();
            specializationMasterColumn = new DataGridViewTextBoxColumn();
            phoneMasterColumn = new DataGridViewTextBoxColumn();
            buttonEditMasterColumn = new DataGridViewLinkColumn();
            buttonDeleteMasterColumn = new DataGridViewButtonColumn();
            tabPageClients = new TabPage();
            groupBoxSearchClient = new GroupBox();
            buttonSearchClient = new Button();
            dateTimePickerSearchClientBirthDate = new DateTimePicker();
            labelSearchClientBirthDate = new Label();
            comboBoxSearchClientGender = new ComboBox();
            label1 = new Label();
            buttonResetClientPhoneNumber = new Button();
            textBoxSearchClientPhoneNumber = new TextBox();
            labelSearchClientPhoneNumber = new Label();
            buttonResetClientPatronymic = new Button();
            textBoxSearchClientPatronymic = new TextBox();
            labelSearchClientPatronymic = new Label();
            buttonResetClientSurname = new Button();
            textBoxSearchClientSurname = new TextBox();
            labelSearchClientSurname = new Label();
            buttonResetClientFirstName = new Button();
            textBoxSearchClientFirstName = new TextBox();
            labelSearchClientFirstName = new Label();
            buttonDeleteClient = new Button();
            buttonAddClient = new Button();
            dataGridViewClients = new DataGridView();
            idClientColumn = new DataGridViewTextBoxColumn();
            firstNameClientColumn = new DataGridViewTextBoxColumn();
            surnameClientColumn = new DataGridViewTextBoxColumn();
            patronymicClientColumn = new DataGridViewTextBoxColumn();
            phoneNumberClientColumn = new DataGridViewTextBoxColumn();
            genderClientColumn = new DataGridViewComboBoxColumn();
            birthDateClientColumn = new DataGridViewTextBoxColumn();
            buttonEditClientColumn = new DataGridViewLinkColumn();
            buttonDeleteClientColumn = new DataGridViewButtonColumn();
            tabPageAppointments = new TabPage();
            groupBoxSearchAppointment = new GroupBox();
            buttonSearchAppointment = new Button();
            numericUpDownSearchAppointmentPrice = new NumericUpDown();
            labelSearchAppointmentPrice = new Label();
            dateTimePickerSearchAppointmentDate = new DateTimePicker();
            labelSearchAppointmentDate = new Label();
            comboBoxSearchAppointmentStatus = new ComboBox();
            labelSearchAppointmentStatus = new Label();
            buttonResetAppointmentServiceId = new Button();
            numericUpDownSearchAppointmentServiceId = new NumericUpDown();
            labelSearchAppointmentServiceId = new Label();
            buttonResetAppointmentMasterId = new Button();
            numericUpDownSearchAppointmentMasterId = new NumericUpDown();
            labelSearchAppointmentMasterId = new Label();
            buttonResetAppointmentClientId = new Button();
            numericUpDownSearchAppointmentClientId = new NumericUpDown();
            labelSearchAppointmentClientId = new Label();
            buttonDeleteAppointment = new Button();
            buttonAddAppointment = new Button();
            dataGridViewAppointments = new DataGridView();
            idAppointmentColumn = new DataGridViewTextBoxColumn();
            clientIdAppointmentColumn = new DataGridViewTextBoxColumn();
            masterIdAppointmentColumn = new DataGridViewTextBoxColumn();
            serviceIdAppointmentColumn = new DataGridViewTextBoxColumn();
            startTimeAppointmentColumn = new DataGridViewTextBoxColumn();
            endTimeAppointmentColumn = new DataGridViewTextBoxColumn();
            bookedPriceAppointmentColumn = new DataGridViewTextBoxColumn();
            statusAppointmentColumn = new DataGridViewComboBoxColumn();
            dateAppointmentColumn = new DataGridViewTextBoxColumn();
            buttonEditAppointmentColumn = new DataGridViewLinkColumn();
            buttonDeleteAppointmentColumn = new DataGridViewButtonColumn();
            MenuStrip1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageServices.SuspendLayout();
            groupBoxSearchService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            tabPageMasters.SuspendLayout();
            groupBoxSearchMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasters).BeginInit();
            tabPageClients.SuspendLayout();
            groupBoxSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            tabPageAppointments.SuspendLayout();
            groupBoxSearchAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentServiceId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentMasterId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentClientId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemFile, MenuItemHelp });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(984, 24);
            MenuStrip1.TabIndex = 1;
            MenuStrip1.Text = "menuStrip2";
            MenuStrip1.ItemClicked += menuItemExit_ItemClicked;
            // 
            // MenuItemFile
            // 
            MenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { MenuItemExit });
            MenuItemFile.Name = "MenuItemFile";
            MenuItemFile.Size = new Size(48, 20);
            MenuItemFile.Text = "Файл";
            // 
            // MenuItemExit
            // 
            MenuItemExit.Name = "MenuItemExit";
            MenuItemExit.Size = new Size(109, 22);
            MenuItemExit.Text = "Выход";
            MenuItemExit.Click += MenuItemExit_Click;
            // 
            // MenuItemHelp
            // 
            MenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { MenuItemAbout });
            MenuItemHelp.Name = "MenuItemHelp";
            MenuItemHelp.Size = new Size(65, 20);
            MenuItemHelp.Text = "Справка";
            MenuItemHelp.Click += MenuItemHelp_Click;
            // 
            // MenuItemAbout
            // 
            MenuItemAbout.Name = "MenuItemAbout";
            MenuItemAbout.Size = new Size(149, 22);
            MenuItemAbout.Text = "О программе";
            MenuItemAbout.Click += MenuItemAbout_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageServices);
            tabControlMain.Controls.Add(tabPageMasters);
            tabControlMain.Controls.Add(tabPageClients);
            tabControlMain.Controls.Add(tabPageAppointments);
            tabControlMain.Location = new Point(0, 27);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(984, 533);
            tabControlMain.TabIndex = 2;
            // 
            // tabPageServices
            // 
            tabPageServices.Controls.Add(groupBoxSearchService);
            tabPageServices.Controls.Add(buttonDeleteService);
            tabPageServices.Controls.Add(buttonAddService);
            tabPageServices.Controls.Add(dataGridViewServices);
            tabPageServices.Location = new Point(4, 24);
            tabPageServices.Name = "tabPageServices";
            tabPageServices.Padding = new Padding(3);
            tabPageServices.Size = new Size(976, 505);
            tabPageServices.TabIndex = 0;
            tabPageServices.Text = "Услуги";
            tabPageServices.UseVisualStyleBackColor = true;
            tabPageServices.Click += tabPageServices_Click;
            // 
            // groupBoxSearchService
            // 
            groupBoxSearchService.Controls.Add(ButtonReset);
            groupBoxSearchService.Controls.Add(buttonSearchService);
            groupBoxSearchService.Controls.Add(textBoxSearchServiceTitle);
            groupBoxSearchService.Controls.Add(labelSearchServiceTitle);
            groupBoxSearchService.Location = new Point(702, 22);
            groupBoxSearchService.Name = "groupBoxSearchService";
            groupBoxSearchService.Size = new Size(252, 149);
            groupBoxSearchService.TabIndex = 3;
            groupBoxSearchService.TabStop = false;
            groupBoxSearchService.Text = "Поиск услуги";
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(6, 120);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(118, 23);
            ButtonReset.TabIndex = 3;
            ButtonReset.Text = "Сбросить";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // buttonSearchService
            // 
            buttonSearchService.Location = new Point(130, 119);
            buttonSearchService.Name = "buttonSearchService";
            buttonSearchService.Size = new Size(118, 24);
            buttonSearchService.TabIndex = 2;
            buttonSearchService.Text = "Найти";
            buttonSearchService.UseVisualStyleBackColor = true;
            buttonSearchService.Click += buttonSearchService_Click;
            // 
            // textBoxSearchServiceTitle
            // 
            textBoxSearchServiceTitle.Location = new Point(6, 37);
            textBoxSearchServiceTitle.Multiline = true;
            textBoxSearchServiceTitle.Name = "textBoxSearchServiceTitle";
            textBoxSearchServiceTitle.Size = new Size(240, 74);
            textBoxSearchServiceTitle.TabIndex = 1;
            textBoxSearchServiceTitle.TextChanged += textBoxSearchServiceTitle_TextChanged;
            // 
            // labelSearchServiceTitle
            // 
            labelSearchServiceTitle.AutoSize = true;
            labelSearchServiceTitle.Font = new Font("Microsoft Sans Serif", 9F);
            labelSearchServiceTitle.Location = new Point(6, 19);
            labelSearchServiceTitle.Name = "labelSearchServiceTitle";
            labelSearchServiceTitle.Size = new Size(67, 15);
            labelSearchServiceTitle.TabIndex = 0;
            labelSearchServiceTitle.Text = "Название:";
            labelSearchServiceTitle.Click += labelSearchServiceTitle_Click;
            // 
            // buttonDeleteService
            // 
            buttonDeleteService.Location = new Point(20, 460);
            buttonDeleteService.Name = "buttonDeleteService";
            buttonDeleteService.Size = new Size(141, 23);
            buttonDeleteService.TabIndex = 2;
            buttonDeleteService.Text = "Удалить услугу";
            buttonDeleteService.UseVisualStyleBackColor = true;
            // 
            // buttonAddService
            // 
            buttonAddService.Font = new Font("Segoe UI", 8F);
            buttonAddService.Location = new Point(167, 460);
            buttonAddService.Name = "buttonAddService";
            buttonAddService.Size = new Size(141, 23);
            buttonAddService.TabIndex = 1;
            buttonAddService.Text = "Добавить услугу";
            buttonAddService.UseVisualStyleBackColor = true;
            buttonAddService.Click += buttonAddService_Click;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Columns.AddRange(new DataGridViewColumn[] { id, Title, Description, Price, Duration, ButtonEdit, ButtonDelete });
            dataGridViewServices.Location = new Point(20, 22);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.Size = new Size(659, 432);
            dataGridViewServices.TabIndex = 0;
            dataGridViewServices.CellContentClick += dataGridViewServices_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Название услуги";
            Title.Name = "Title";
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Описание услуги";
            Description.Name = "Description";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Стоимость (руб)";
            Price.Name = "Price";
            // 
            // Duration
            // 
            Duration.DataPropertyName = "Duration";
            Duration.HeaderText = "Длительность (мин)";
            Duration.Name = "Duration";
            // 
            // ButtonEdit
            // 
            ButtonEdit.HeaderText = "Редактировать";
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Text = "Редактировать";
            ButtonEdit.UseColumnTextForLinkValue = true;
            // 
            // ButtonDelete
            // 
            ButtonDelete.HeaderText = "Удалить";
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Text = "Удалить";
            ButtonDelete.UseColumnTextForButtonValue = true;
            // 
            // tabPageMasters
            // 
            tabPageMasters.Controls.Add(groupBoxSearchMaster);
            tabPageMasters.Controls.Add(buttonDeleteMaster);
            tabPageMasters.Controls.Add(buttonAddMaster);
            tabPageMasters.Controls.Add(dataGridViewMasters);
            tabPageMasters.Location = new Point(4, 24);
            tabPageMasters.Name = "tabPageMasters";
            tabPageMasters.Padding = new Padding(3);
            tabPageMasters.Size = new Size(976, 505);
            tabPageMasters.TabIndex = 1;
            tabPageMasters.Text = "Мастера";
            tabPageMasters.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchMaster
            // 
            groupBoxSearchMaster.Controls.Add(buttonResetMasterPhone);
            groupBoxSearchMaster.Controls.Add(buttonResetMasterSpecialization);
            groupBoxSearchMaster.Controls.Add(buttonResetMasterPatronymic);
            groupBoxSearchMaster.Controls.Add(buttonResetMasterLastName);
            groupBoxSearchMaster.Controls.Add(buttonResetMasterFirstName);
            groupBoxSearchMaster.Controls.Add(buttonSearchMaster);
            groupBoxSearchMaster.Controls.Add(textBoxSearchMasterPhone);
            groupBoxSearchMaster.Controls.Add(labelSearchMasterPhone);
            groupBoxSearchMaster.Controls.Add(textBoxSearchMasterSpecialization);
            groupBoxSearchMaster.Controls.Add(labelSearchMasterSpecialization);
            groupBoxSearchMaster.Controls.Add(textBoxSearchMasterPatronymic);
            groupBoxSearchMaster.Controls.Add(labelSearchMasterPatronymic);
            groupBoxSearchMaster.Controls.Add(textBoxSearchMasterLastName);
            groupBoxSearchMaster.Controls.Add(labelSearchMasterLastName);
            groupBoxSearchMaster.Controls.Add(textBoxSearchMasterFirstName);
            groupBoxSearchMaster.Controls.Add(labelSearchMasterFirstName);
            groupBoxSearchMaster.Location = new Point(702, 22);
            groupBoxSearchMaster.Name = "groupBoxSearchMaster";
            groupBoxSearchMaster.Size = new Size(252, 300);
            groupBoxSearchMaster.TabIndex = 4;
            groupBoxSearchMaster.TabStop = false;
            groupBoxSearchMaster.Text = "Поиск мастера";
            // 
            // buttonResetMasterPhone
            // 
            buttonResetMasterPhone.Location = new Point(167, 212);
            buttonResetMasterPhone.Name = "buttonResetMasterPhone";
            buttonResetMasterPhone.Size = new Size(79, 23);
            buttonResetMasterPhone.TabIndex = 15;
            buttonResetMasterPhone.Text = "Сбросить";
            buttonResetMasterPhone.UseVisualStyleBackColor = true;
            buttonResetMasterPhone.Click += buttonResetMasterPhone_Click;
            // 
            // buttonResetMasterSpecialization
            // 
            buttonResetMasterSpecialization.Location = new Point(167, 168);
            buttonResetMasterSpecialization.Name = "buttonResetMasterSpecialization";
            buttonResetMasterSpecialization.Size = new Size(79, 23);
            buttonResetMasterSpecialization.TabIndex = 14;
            buttonResetMasterSpecialization.Text = "Сбросить";
            buttonResetMasterSpecialization.UseVisualStyleBackColor = true;
            buttonResetMasterSpecialization.Click += buttonResetMasterSpecialization_Click;
            // 
            // buttonResetMasterPatronymic
            // 
            buttonResetMasterPatronymic.Location = new Point(167, 124);
            buttonResetMasterPatronymic.Name = "buttonResetMasterPatronymic";
            buttonResetMasterPatronymic.Size = new Size(79, 23);
            buttonResetMasterPatronymic.TabIndex = 13;
            buttonResetMasterPatronymic.Text = "Сбросить";
            buttonResetMasterPatronymic.UseVisualStyleBackColor = true;
            buttonResetMasterPatronymic.Click += buttonResetMasterPatronymic_Click;
            // 
            // buttonResetMasterLastName
            // 
            buttonResetMasterLastName.Location = new Point(167, 80);
            buttonResetMasterLastName.Name = "buttonResetMasterLastName";
            buttonResetMasterLastName.Size = new Size(79, 23);
            buttonResetMasterLastName.TabIndex = 12;
            buttonResetMasterLastName.Text = "Сбросить";
            buttonResetMasterLastName.UseVisualStyleBackColor = true;
            buttonResetMasterLastName.Click += buttonResetMasterLastName_Click;
            // 
            // buttonResetMasterFirstName
            // 
            buttonResetMasterFirstName.Location = new Point(167, 37);
            buttonResetMasterFirstName.Name = "buttonResetMasterFirstName";
            buttonResetMasterFirstName.Size = new Size(79, 23);
            buttonResetMasterFirstName.TabIndex = 11;
            buttonResetMasterFirstName.Text = "Сбросить";
            buttonResetMasterFirstName.UseVisualStyleBackColor = true;
            buttonResetMasterFirstName.Click += buttonResetMasterFirstName_Click;
            // 
            // buttonSearchMaster
            // 
            buttonSearchMaster.Location = new Point(54, 271);
            buttonSearchMaster.Name = "buttonSearchMaster";
            buttonSearchMaster.Size = new Size(143, 23);
            buttonSearchMaster.TabIndex = 10;
            buttonSearchMaster.Text = "Найти";
            buttonSearchMaster.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchMasterPhone
            // 
            textBoxSearchMasterPhone.Location = new Point(6, 213);
            textBoxSearchMasterPhone.Name = "textBoxSearchMasterPhone";
            textBoxSearchMasterPhone.Size = new Size(155, 23);
            textBoxSearchMasterPhone.TabIndex = 9;
            // 
            // labelSearchMasterPhone
            // 
            labelSearchMasterPhone.AutoSize = true;
            labelSearchMasterPhone.Location = new Point(6, 195);
            labelSearchMasterPhone.Name = "labelSearchMasterPhone";
            labelSearchMasterPhone.Size = new Size(104, 15);
            labelSearchMasterPhone.TabIndex = 8;
            labelSearchMasterPhone.Text = "Номер телефона:";
            // 
            // textBoxSearchMasterSpecialization
            // 
            textBoxSearchMasterSpecialization.Location = new Point(6, 169);
            textBoxSearchMasterSpecialization.Name = "textBoxSearchMasterSpecialization";
            textBoxSearchMasterSpecialization.Size = new Size(155, 23);
            textBoxSearchMasterSpecialization.TabIndex = 7;
            // 
            // labelSearchMasterSpecialization
            // 
            labelSearchMasterSpecialization.AutoSize = true;
            labelSearchMasterSpecialization.Location = new Point(6, 151);
            labelSearchMasterSpecialization.Name = "labelSearchMasterSpecialization";
            labelSearchMasterSpecialization.Size = new Size(96, 15);
            labelSearchMasterSpecialization.TabIndex = 6;
            labelSearchMasterSpecialization.Text = "Специализация:";
            // 
            // textBoxSearchMasterPatronymic
            // 
            textBoxSearchMasterPatronymic.Location = new Point(6, 125);
            textBoxSearchMasterPatronymic.Name = "textBoxSearchMasterPatronymic";
            textBoxSearchMasterPatronymic.Size = new Size(155, 23);
            textBoxSearchMasterPatronymic.TabIndex = 5;
            // 
            // labelSearchMasterPatronymic
            // 
            labelSearchMasterPatronymic.AutoSize = true;
            labelSearchMasterPatronymic.Location = new Point(6, 107);
            labelSearchMasterPatronymic.Name = "labelSearchMasterPatronymic";
            labelSearchMasterPatronymic.Size = new Size(61, 15);
            labelSearchMasterPatronymic.TabIndex = 4;
            labelSearchMasterPatronymic.Text = "Отчество:";
            // 
            // textBoxSearchMasterLastName
            // 
            textBoxSearchMasterLastName.Location = new Point(6, 81);
            textBoxSearchMasterLastName.Name = "textBoxSearchMasterLastName";
            textBoxSearchMasterLastName.Size = new Size(155, 23);
            textBoxSearchMasterLastName.TabIndex = 3;
            // 
            // labelSearchMasterLastName
            // 
            labelSearchMasterLastName.AutoSize = true;
            labelSearchMasterLastName.Location = new Point(6, 63);
            labelSearchMasterLastName.Name = "labelSearchMasterLastName";
            labelSearchMasterLastName.Size = new Size(61, 15);
            labelSearchMasterLastName.TabIndex = 2;
            labelSearchMasterLastName.Text = "Фамилия:";
            // 
            // textBoxSearchMasterFirstName
            // 
            textBoxSearchMasterFirstName.Location = new Point(6, 37);
            textBoxSearchMasterFirstName.Name = "textBoxSearchMasterFirstName";
            textBoxSearchMasterFirstName.Size = new Size(155, 23);
            textBoxSearchMasterFirstName.TabIndex = 1;
            // 
            // labelSearchMasterFirstName
            // 
            labelSearchMasterFirstName.AutoSize = true;
            labelSearchMasterFirstName.Location = new Point(6, 19);
            labelSearchMasterFirstName.Name = "labelSearchMasterFirstName";
            labelSearchMasterFirstName.Size = new Size(34, 15);
            labelSearchMasterFirstName.TabIndex = 0;
            labelSearchMasterFirstName.Text = "Имя:";
            // 
            // buttonDeleteMaster
            // 
            buttonDeleteMaster.Location = new Point(20, 460);
            buttonDeleteMaster.Name = "buttonDeleteMaster";
            buttonDeleteMaster.Size = new Size(141, 23);
            buttonDeleteMaster.TabIndex = 3;
            buttonDeleteMaster.Text = "Удалить мастера";
            buttonDeleteMaster.UseVisualStyleBackColor = true;
            buttonDeleteMaster.Click += buttonDeleteMaster_Click;
            // 
            // buttonAddMaster
            // 
            buttonAddMaster.Font = new Font("Segoe UI", 8F);
            buttonAddMaster.Location = new Point(167, 460);
            buttonAddMaster.Name = "buttonAddMaster";
            buttonAddMaster.Size = new Size(141, 23);
            buttonAddMaster.TabIndex = 2;
            buttonAddMaster.Text = "Добавить мастера";
            buttonAddMaster.UseVisualStyleBackColor = true;
            buttonAddMaster.Click += buttonAddMaster_Click;
            // 
            // dataGridViewMasters
            // 
            dataGridViewMasters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMasters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMasters.Columns.AddRange(new DataGridViewColumn[] { idMasterColumn, firstNameMasterColumn, lastNameMasterColumn, PatronymicMasterColumn, specializationMasterColumn, phoneMasterColumn, buttonEditMasterColumn, buttonDeleteMasterColumn });
            dataGridViewMasters.Location = new Point(20, 22);
            dataGridViewMasters.Name = "dataGridViewMasters";
            dataGridViewMasters.Size = new Size(659, 432);
            dataGridViewMasters.TabIndex = 0;
            // 
            // idMasterColumn
            // 
            idMasterColumn.DataPropertyName = "id";
            idMasterColumn.HeaderText = "ID";
            idMasterColumn.Name = "idMasterColumn";
            // 
            // firstNameMasterColumn
            // 
            firstNameMasterColumn.DataPropertyName = "FirstName";
            firstNameMasterColumn.HeaderText = "Имя";
            firstNameMasterColumn.Name = "firstNameMasterColumn";
            // 
            // lastNameMasterColumn
            // 
            lastNameMasterColumn.DataPropertyName = "Surname";
            lastNameMasterColumn.HeaderText = "Фамилия";
            lastNameMasterColumn.Name = "lastNameMasterColumn";
            // 
            // PatronymicMasterColumn
            // 
            PatronymicMasterColumn.DataPropertyName = "Patronymic";
            PatronymicMasterColumn.HeaderText = "Отчество";
            PatronymicMasterColumn.Name = "PatronymicMasterColumn";
            // 
            // specializationMasterColumn
            // 
            specializationMasterColumn.DataPropertyName = "Specialization";
            specializationMasterColumn.HeaderText = "Специализация";
            specializationMasterColumn.Name = "specializationMasterColumn";
            // 
            // phoneMasterColumn
            // 
            phoneMasterColumn.DataPropertyName = "PhoneNumber";
            phoneMasterColumn.HeaderText = "Номер телефона";
            phoneMasterColumn.Name = "phoneMasterColumn";
            // 
            // buttonEditMasterColumn
            // 
            buttonEditMasterColumn.HeaderText = "Редактировать";
            buttonEditMasterColumn.Name = "buttonEditMasterColumn";
            buttonEditMasterColumn.Text = "Редактировать";
            buttonEditMasterColumn.UseColumnTextForLinkValue = true;
            // 
            // buttonDeleteMasterColumn
            // 
            buttonDeleteMasterColumn.HeaderText = "Удалить";
            buttonDeleteMasterColumn.Name = "buttonDeleteMasterColumn";
            buttonDeleteMasterColumn.Text = "Удалить";
            buttonDeleteMasterColumn.UseColumnTextForButtonValue = true;
            // 
            // tabPageClients
            // 
            tabPageClients.Controls.Add(groupBoxSearchClient);
            tabPageClients.Controls.Add(buttonDeleteClient);
            tabPageClients.Controls.Add(buttonAddClient);
            tabPageClients.Controls.Add(dataGridViewClients);
            tabPageClients.Location = new Point(4, 24);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Size = new Size(976, 505);
            tabPageClients.TabIndex = 2;
            tabPageClients.Text = "Клиенты";
            tabPageClients.UseVisualStyleBackColor = true;
            tabPageClients.Click += tabPageClients_Click;
            // 
            // groupBoxSearchClient
            // 
            groupBoxSearchClient.Controls.Add(buttonSearchClient);
            groupBoxSearchClient.Controls.Add(dateTimePickerSearchClientBirthDate);
            groupBoxSearchClient.Controls.Add(labelSearchClientBirthDate);
            groupBoxSearchClient.Controls.Add(comboBoxSearchClientGender);
            groupBoxSearchClient.Controls.Add(label1);
            groupBoxSearchClient.Controls.Add(buttonResetClientPhoneNumber);
            groupBoxSearchClient.Controls.Add(textBoxSearchClientPhoneNumber);
            groupBoxSearchClient.Controls.Add(labelSearchClientPhoneNumber);
            groupBoxSearchClient.Controls.Add(buttonResetClientPatronymic);
            groupBoxSearchClient.Controls.Add(textBoxSearchClientPatronymic);
            groupBoxSearchClient.Controls.Add(labelSearchClientPatronymic);
            groupBoxSearchClient.Controls.Add(buttonResetClientSurname);
            groupBoxSearchClient.Controls.Add(textBoxSearchClientSurname);
            groupBoxSearchClient.Controls.Add(labelSearchClientSurname);
            groupBoxSearchClient.Controls.Add(buttonResetClientFirstName);
            groupBoxSearchClient.Controls.Add(textBoxSearchClientFirstName);
            groupBoxSearchClient.Controls.Add(labelSearchClientFirstName);
            groupBoxSearchClient.Location = new Point(702, 22);
            groupBoxSearchClient.Name = "groupBoxSearchClient";
            groupBoxSearchClient.Size = new Size(252, 335);
            groupBoxSearchClient.TabIndex = 5;
            groupBoxSearchClient.TabStop = false;
            groupBoxSearchClient.Text = "Поиск клиента";
            // 
            // buttonSearchClient
            // 
            buttonSearchClient.Location = new Point(54, 306);
            buttonSearchClient.Name = "buttonSearchClient";
            buttonSearchClient.Size = new Size(143, 23);
            buttonSearchClient.TabIndex = 16;
            buttonSearchClient.Text = "Найти";
            buttonSearchClient.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSearchClientBirthDate
            // 
            dateTimePickerSearchClientBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerSearchClientBirthDate.Location = new Point(6, 257);
            dateTimePickerSearchClientBirthDate.Name = "dateTimePickerSearchClientBirthDate";
            dateTimePickerSearchClientBirthDate.Size = new Size(155, 23);
            dateTimePickerSearchClientBirthDate.TabIndex = 15;
            dateTimePickerSearchClientBirthDate.ValueChanged += dateTimePickerSearchClientBirthDate_ValueChanged;
            // 
            // labelSearchClientBirthDate
            // 
            labelSearchClientBirthDate.AutoSize = true;
            labelSearchClientBirthDate.Location = new Point(6, 239);
            labelSearchClientBirthDate.Name = "labelSearchClientBirthDate";
            labelSearchClientBirthDate.Size = new Size(93, 15);
            labelSearchClientBirthDate.TabIndex = 14;
            labelSearchClientBirthDate.Text = "Дата рождения:";
            // 
            // comboBoxSearchClientGender
            // 
            comboBoxSearchClientGender.FormattingEnabled = true;
            comboBoxSearchClientGender.Items.AddRange(new object[] { "Женский", "Мужской" });
            comboBoxSearchClientGender.Location = new Point(6, 213);
            comboBoxSearchClientGender.Name = "comboBoxSearchClientGender";
            comboBoxSearchClientGender.Size = new Size(155, 23);
            comboBoxSearchClientGender.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 195);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 12;
            label1.Text = "Пол:";
            // 
            // buttonResetClientPhoneNumber
            // 
            buttonResetClientPhoneNumber.Location = new Point(167, 168);
            buttonResetClientPhoneNumber.Name = "buttonResetClientPhoneNumber";
            buttonResetClientPhoneNumber.Size = new Size(79, 23);
            buttonResetClientPhoneNumber.TabIndex = 11;
            buttonResetClientPhoneNumber.Text = "Сбросить";
            buttonResetClientPhoneNumber.UseVisualStyleBackColor = true;
            buttonResetClientPhoneNumber.Click += buttonResetClientPhoneNumber_Click;
            // 
            // textBoxSearchClientPhoneNumber
            // 
            textBoxSearchClientPhoneNumber.Location = new Point(6, 169);
            textBoxSearchClientPhoneNumber.Name = "textBoxSearchClientPhoneNumber";
            textBoxSearchClientPhoneNumber.Size = new Size(155, 23);
            textBoxSearchClientPhoneNumber.TabIndex = 10;
            // 
            // labelSearchClientPhoneNumber
            // 
            labelSearchClientPhoneNumber.AutoSize = true;
            labelSearchClientPhoneNumber.Location = new Point(6, 151);
            labelSearchClientPhoneNumber.Name = "labelSearchClientPhoneNumber";
            labelSearchClientPhoneNumber.Size = new Size(104, 15);
            labelSearchClientPhoneNumber.TabIndex = 9;
            labelSearchClientPhoneNumber.Text = "Номер телефона:";
            // 
            // buttonResetClientPatronymic
            // 
            buttonResetClientPatronymic.Location = new Point(167, 125);
            buttonResetClientPatronymic.Name = "buttonResetClientPatronymic";
            buttonResetClientPatronymic.Size = new Size(79, 23);
            buttonResetClientPatronymic.TabIndex = 8;
            buttonResetClientPatronymic.Text = "Сбросить";
            buttonResetClientPatronymic.UseVisualStyleBackColor = true;
            buttonResetClientPatronymic.Click += buttonResetClientPatronymic_Click;
            // 
            // textBoxSearchClientPatronymic
            // 
            textBoxSearchClientPatronymic.Location = new Point(6, 125);
            textBoxSearchClientPatronymic.Name = "textBoxSearchClientPatronymic";
            textBoxSearchClientPatronymic.Size = new Size(155, 23);
            textBoxSearchClientPatronymic.TabIndex = 7;
            // 
            // labelSearchClientPatronymic
            // 
            labelSearchClientPatronymic.AutoSize = true;
            labelSearchClientPatronymic.Location = new Point(6, 107);
            labelSearchClientPatronymic.Name = "labelSearchClientPatronymic";
            labelSearchClientPatronymic.Size = new Size(61, 15);
            labelSearchClientPatronymic.TabIndex = 6;
            labelSearchClientPatronymic.Text = "Отчество:";
            // 
            // buttonResetClientSurname
            // 
            buttonResetClientSurname.Location = new Point(167, 81);
            buttonResetClientSurname.Name = "buttonResetClientSurname";
            buttonResetClientSurname.Size = new Size(79, 23);
            buttonResetClientSurname.TabIndex = 5;
            buttonResetClientSurname.Text = "Сбросить";
            buttonResetClientSurname.UseVisualStyleBackColor = true;
            buttonResetClientSurname.Click += buttonResetClientSurname_Click;
            // 
            // textBoxSearchClientSurname
            // 
            textBoxSearchClientSurname.Location = new Point(6, 81);
            textBoxSearchClientSurname.Name = "textBoxSearchClientSurname";
            textBoxSearchClientSurname.Size = new Size(155, 23);
            textBoxSearchClientSurname.TabIndex = 4;
            // 
            // labelSearchClientSurname
            // 
            labelSearchClientSurname.AutoSize = true;
            labelSearchClientSurname.Location = new Point(6, 63);
            labelSearchClientSurname.Name = "labelSearchClientSurname";
            labelSearchClientSurname.Size = new Size(61, 15);
            labelSearchClientSurname.TabIndex = 3;
            labelSearchClientSurname.Text = "Фамилия:";
            // 
            // buttonResetClientFirstName
            // 
            buttonResetClientFirstName.Location = new Point(167, 37);
            buttonResetClientFirstName.Name = "buttonResetClientFirstName";
            buttonResetClientFirstName.Size = new Size(79, 23);
            buttonResetClientFirstName.TabIndex = 2;
            buttonResetClientFirstName.Text = "Сбросить";
            buttonResetClientFirstName.UseVisualStyleBackColor = true;
            buttonResetClientFirstName.Click += buttonResetClientFirstName_Click;
            // 
            // textBoxSearchClientFirstName
            // 
            textBoxSearchClientFirstName.Location = new Point(6, 37);
            textBoxSearchClientFirstName.Name = "textBoxSearchClientFirstName";
            textBoxSearchClientFirstName.Size = new Size(155, 23);
            textBoxSearchClientFirstName.TabIndex = 1;
            // 
            // labelSearchClientFirstName
            // 
            labelSearchClientFirstName.AutoSize = true;
            labelSearchClientFirstName.Location = new Point(6, 19);
            labelSearchClientFirstName.Name = "labelSearchClientFirstName";
            labelSearchClientFirstName.Size = new Size(34, 15);
            labelSearchClientFirstName.TabIndex = 0;
            labelSearchClientFirstName.Text = "Имя:";
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.Location = new Point(20, 460);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(141, 23);
            buttonDeleteClient.TabIndex = 4;
            buttonDeleteClient.Text = "Удалить клиента";
            buttonDeleteClient.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Font = new Font("Segoe UI", 8F);
            buttonAddClient.Location = new Point(167, 460);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(141, 23);
            buttonAddClient.TabIndex = 3;
            buttonAddClient.Text = "Добавить клиента";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { idClientColumn, firstNameClientColumn, surnameClientColumn, patronymicClientColumn, phoneNumberClientColumn, genderClientColumn, birthDateClientColumn, buttonEditClientColumn, buttonDeleteClientColumn });
            dataGridViewClients.Location = new Point(20, 22);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(659, 432);
            dataGridViewClients.TabIndex = 0;
            // 
            // idClientColumn
            // 
            idClientColumn.DataPropertyName = "id";
            idClientColumn.HeaderText = "ID";
            idClientColumn.Name = "idClientColumn";
            // 
            // firstNameClientColumn
            // 
            firstNameClientColumn.DataPropertyName = "FirstName";
            firstNameClientColumn.HeaderText = "Имя";
            firstNameClientColumn.Name = "firstNameClientColumn";
            // 
            // surnameClientColumn
            // 
            surnameClientColumn.DataPropertyName = "Surname";
            surnameClientColumn.HeaderText = "Фамилия";
            surnameClientColumn.Name = "surnameClientColumn";
            // 
            // patronymicClientColumn
            // 
            patronymicClientColumn.DataPropertyName = "Patronymic";
            patronymicClientColumn.HeaderText = "Отчество";
            patronymicClientColumn.Name = "patronymicClientColumn";
            // 
            // phoneNumberClientColumn
            // 
            phoneNumberClientColumn.DataPropertyName = "PhoneNumber";
            phoneNumberClientColumn.HeaderText = "Номер телефона";
            phoneNumberClientColumn.Name = "phoneNumberClientColumn";
            // 
            // genderClientColumn
            // 
            genderClientColumn.DataPropertyName = "Gender";
            genderClientColumn.HeaderText = "Пол";
            genderClientColumn.Items.AddRange(new object[] { "Женский", "Мужской" });
            genderClientColumn.Name = "genderClientColumn";
            // 
            // birthDateClientColumn
            // 
            birthDateClientColumn.DataPropertyName = "BirthDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            birthDateClientColumn.DefaultCellStyle = dataGridViewCellStyle1;
            birthDateClientColumn.HeaderText = "Дата рождения";
            birthDateClientColumn.Name = "birthDateClientColumn";
            birthDateClientColumn.Resizable = DataGridViewTriState.True;
            birthDateClientColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonEditClientColumn
            // 
            buttonEditClientColumn.HeaderText = "Редактировать";
            buttonEditClientColumn.Name = "buttonEditClientColumn";
            buttonEditClientColumn.Resizable = DataGridViewTriState.True;
            buttonEditClientColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            buttonEditClientColumn.Text = "Редактировать";
            buttonEditClientColumn.UseColumnTextForLinkValue = true;
            // 
            // buttonDeleteClientColumn
            // 
            buttonDeleteClientColumn.HeaderText = "Удалить";
            buttonDeleteClientColumn.Name = "buttonDeleteClientColumn";
            buttonDeleteClientColumn.Resizable = DataGridViewTriState.True;
            buttonDeleteClientColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            buttonDeleteClientColumn.Text = "Удалить";
            buttonDeleteClientColumn.UseColumnTextForButtonValue = true;
            // 
            // tabPageAppointments
            // 
            tabPageAppointments.Controls.Add(groupBoxSearchAppointment);
            tabPageAppointments.Controls.Add(buttonDeleteAppointment);
            tabPageAppointments.Controls.Add(buttonAddAppointment);
            tabPageAppointments.Controls.Add(dataGridViewAppointments);
            tabPageAppointments.Location = new Point(4, 24);
            tabPageAppointments.Name = "tabPageAppointments";
            tabPageAppointments.Size = new Size(976, 505);
            tabPageAppointments.TabIndex = 3;
            tabPageAppointments.Text = "Журнал записей";
            tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchAppointment
            // 
            groupBoxSearchAppointment.Controls.Add(buttonSearchAppointment);
            groupBoxSearchAppointment.Controls.Add(numericUpDownSearchAppointmentPrice);
            groupBoxSearchAppointment.Controls.Add(labelSearchAppointmentPrice);
            groupBoxSearchAppointment.Controls.Add(dateTimePickerSearchAppointmentDate);
            groupBoxSearchAppointment.Controls.Add(labelSearchAppointmentDate);
            groupBoxSearchAppointment.Controls.Add(comboBoxSearchAppointmentStatus);
            groupBoxSearchAppointment.Controls.Add(labelSearchAppointmentStatus);
            groupBoxSearchAppointment.Controls.Add(buttonResetAppointmentServiceId);
            groupBoxSearchAppointment.Controls.Add(numericUpDownSearchAppointmentServiceId);
            groupBoxSearchAppointment.Controls.Add(labelSearchAppointmentServiceId);
            groupBoxSearchAppointment.Controls.Add(buttonResetAppointmentMasterId);
            groupBoxSearchAppointment.Controls.Add(numericUpDownSearchAppointmentMasterId);
            groupBoxSearchAppointment.Controls.Add(labelSearchAppointmentMasterId);
            groupBoxSearchAppointment.Controls.Add(buttonResetAppointmentClientId);
            groupBoxSearchAppointment.Controls.Add(numericUpDownSearchAppointmentClientId);
            groupBoxSearchAppointment.Controls.Add(labelSearchAppointmentClientId);
            groupBoxSearchAppointment.Location = new Point(702, 22);
            groupBoxSearchAppointment.Name = "groupBoxSearchAppointment";
            groupBoxSearchAppointment.Size = new Size(252, 336);
            groupBoxSearchAppointment.TabIndex = 6;
            groupBoxSearchAppointment.TabStop = false;
            groupBoxSearchAppointment.Text = "Поиск записи";
            // 
            // buttonSearchAppointment
            // 
            buttonSearchAppointment.Location = new Point(55, 307);
            buttonSearchAppointment.Name = "buttonSearchAppointment";
            buttonSearchAppointment.Size = new Size(143, 23);
            buttonSearchAppointment.TabIndex = 15;
            buttonSearchAppointment.Text = "Найти";
            buttonSearchAppointment.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSearchAppointmentPrice
            // 
            numericUpDownSearchAppointmentPrice.Location = new Point(6, 257);
            numericUpDownSearchAppointmentPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSearchAppointmentPrice.Name = "numericUpDownSearchAppointmentPrice";
            numericUpDownSearchAppointmentPrice.Size = new Size(143, 23);
            numericUpDownSearchAppointmentPrice.TabIndex = 14;
            // 
            // labelSearchAppointmentPrice
            // 
            labelSearchAppointmentPrice.AutoSize = true;
            labelSearchAppointmentPrice.Location = new Point(6, 239);
            labelSearchAppointmentPrice.Name = "labelSearchAppointmentPrice";
            labelSearchAppointmentPrice.Size = new Size(204, 15);
            labelSearchAppointmentPrice.TabIndex = 13;
            labelSearchAppointmentPrice.Text = "Стоимость на момент записи (руб):";
            // 
            // dateTimePickerSearchAppointmentDate
            // 
            dateTimePickerSearchAppointmentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerSearchAppointmentDate.Location = new Point(6, 213);
            dateTimePickerSearchAppointmentDate.Name = "dateTimePickerSearchAppointmentDate";
            dateTimePickerSearchAppointmentDate.Size = new Size(143, 23);
            dateTimePickerSearchAppointmentDate.TabIndex = 12;
            // 
            // labelSearchAppointmentDate
            // 
            labelSearchAppointmentDate.AutoSize = true;
            labelSearchAppointmentDate.Location = new Point(6, 195);
            labelSearchAppointmentDate.Name = "labelSearchAppointmentDate";
            labelSearchAppointmentDate.Size = new Size(129, 15);
            labelSearchAppointmentDate.TabIndex = 11;
            labelSearchAppointmentDate.Text = "Плановая дата визита:";
            // 
            // comboBoxSearchAppointmentStatus
            // 
            comboBoxSearchAppointmentStatus.FormattingEnabled = true;
            comboBoxSearchAppointmentStatus.Items.AddRange(new object[] { "Выполнено", "Запланировано", "Отменено" });
            comboBoxSearchAppointmentStatus.Location = new Point(6, 169);
            comboBoxSearchAppointmentStatus.Name = "comboBoxSearchAppointmentStatus";
            comboBoxSearchAppointmentStatus.Size = new Size(143, 23);
            comboBoxSearchAppointmentStatus.TabIndex = 10;
            // 
            // labelSearchAppointmentStatus
            // 
            labelSearchAppointmentStatus.AutoSize = true;
            labelSearchAppointmentStatus.Location = new Point(6, 151);
            labelSearchAppointmentStatus.Name = "labelSearchAppointmentStatus";
            labelSearchAppointmentStatus.Size = new Size(87, 15);
            labelSearchAppointmentStatus.TabIndex = 9;
            labelSearchAppointmentStatus.Text = "Статус записи:";
            // 
            // buttonResetAppointmentServiceId
            // 
            buttonResetAppointmentServiceId.Location = new Point(155, 125);
            buttonResetAppointmentServiceId.Name = "buttonResetAppointmentServiceId";
            buttonResetAppointmentServiceId.Size = new Size(91, 23);
            buttonResetAppointmentServiceId.TabIndex = 8;
            buttonResetAppointmentServiceId.Text = "Сбросить";
            buttonResetAppointmentServiceId.UseVisualStyleBackColor = true;
            buttonResetAppointmentServiceId.Click += buttonResetAppointmentServiceId_Click;
            // 
            // numericUpDownSearchAppointmentServiceId
            // 
            numericUpDownSearchAppointmentServiceId.Location = new Point(6, 125);
            numericUpDownSearchAppointmentServiceId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSearchAppointmentServiceId.Name = "numericUpDownSearchAppointmentServiceId";
            numericUpDownSearchAppointmentServiceId.Size = new Size(143, 23);
            numericUpDownSearchAppointmentServiceId.TabIndex = 7;
            numericUpDownSearchAppointmentServiceId.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // labelSearchAppointmentServiceId
            // 
            labelSearchAppointmentServiceId.AutoSize = true;
            labelSearchAppointmentServiceId.Location = new Point(6, 107);
            labelSearchAppointmentServiceId.Name = "labelSearchAppointmentServiceId";
            labelSearchAppointmentServiceId.Size = new Size(62, 15);
            labelSearchAppointmentServiceId.TabIndex = 6;
            labelSearchAppointmentServiceId.Text = "ID Услуги:";
            labelSearchAppointmentServiceId.Click += label2_Click;
            // 
            // buttonResetAppointmentMasterId
            // 
            buttonResetAppointmentMasterId.Location = new Point(155, 81);
            buttonResetAppointmentMasterId.Name = "buttonResetAppointmentMasterId";
            buttonResetAppointmentMasterId.Size = new Size(91, 23);
            buttonResetAppointmentMasterId.TabIndex = 5;
            buttonResetAppointmentMasterId.Text = "Сбросить";
            buttonResetAppointmentMasterId.UseVisualStyleBackColor = true;
            buttonResetAppointmentMasterId.Click += buttonResetAppointmentMasterId_Click;
            // 
            // numericUpDownSearchAppointmentMasterId
            // 
            numericUpDownSearchAppointmentMasterId.Location = new Point(6, 81);
            numericUpDownSearchAppointmentMasterId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSearchAppointmentMasterId.Name = "numericUpDownSearchAppointmentMasterId";
            numericUpDownSearchAppointmentMasterId.Size = new Size(143, 23);
            numericUpDownSearchAppointmentMasterId.TabIndex = 4;
            // 
            // labelSearchAppointmentMasterId
            // 
            labelSearchAppointmentMasterId.AutoSize = true;
            labelSearchAppointmentMasterId.Location = new Point(6, 63);
            labelSearchAppointmentMasterId.Name = "labelSearchAppointmentMasterId";
            labelSearchAppointmentMasterId.Size = new Size(71, 15);
            labelSearchAppointmentMasterId.TabIndex = 3;
            labelSearchAppointmentMasterId.Text = "ID Мастера:";
            // 
            // buttonResetAppointmentClientId
            // 
            buttonResetAppointmentClientId.Location = new Point(155, 37);
            buttonResetAppointmentClientId.Name = "buttonResetAppointmentClientId";
            buttonResetAppointmentClientId.Size = new Size(91, 23);
            buttonResetAppointmentClientId.TabIndex = 2;
            buttonResetAppointmentClientId.Text = "Сбросить";
            buttonResetAppointmentClientId.UseVisualStyleBackColor = true;
            buttonResetAppointmentClientId.Click += buttonResetAppointmentClientId_Click;
            // 
            // numericUpDownSearchAppointmentClientId
            // 
            numericUpDownSearchAppointmentClientId.Location = new Point(6, 37);
            numericUpDownSearchAppointmentClientId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSearchAppointmentClientId.Name = "numericUpDownSearchAppointmentClientId";
            numericUpDownSearchAppointmentClientId.Size = new Size(143, 23);
            numericUpDownSearchAppointmentClientId.TabIndex = 1;
            // 
            // labelSearchAppointmentClientId
            // 
            labelSearchAppointmentClientId.AutoSize = true;
            labelSearchAppointmentClientId.Location = new Point(6, 19);
            labelSearchAppointmentClientId.Name = "labelSearchAppointmentClientId";
            labelSearchAppointmentClientId.Size = new Size(69, 15);
            labelSearchAppointmentClientId.TabIndex = 0;
            labelSearchAppointmentClientId.Text = "ID Клиента:";
            // 
            // buttonDeleteAppointment
            // 
            buttonDeleteAppointment.Location = new Point(20, 460);
            buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            buttonDeleteAppointment.Size = new Size(141, 23);
            buttonDeleteAppointment.TabIndex = 5;
            buttonDeleteAppointment.Text = "Удалить запись";
            buttonDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonAddAppointment
            // 
            buttonAddAppointment.Font = new Font("Segoe UI", 8F);
            buttonAddAppointment.Location = new Point(167, 460);
            buttonAddAppointment.Name = "buttonAddAppointment";
            buttonAddAppointment.Size = new Size(141, 23);
            buttonAddAppointment.TabIndex = 4;
            buttonAddAppointment.Text = "Добавить запись";
            buttonAddAppointment.UseVisualStyleBackColor = true;
            buttonAddAppointment.Click += buttonAddAppointment_Click;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Columns.AddRange(new DataGridViewColumn[] { idAppointmentColumn, clientIdAppointmentColumn, masterIdAppointmentColumn, serviceIdAppointmentColumn, startTimeAppointmentColumn, endTimeAppointmentColumn, bookedPriceAppointmentColumn, statusAppointmentColumn, dateAppointmentColumn, buttonEditAppointmentColumn, buttonDeleteAppointmentColumn });
            dataGridViewAppointments.Location = new Point(20, 22);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.Size = new Size(659, 432);
            dataGridViewAppointments.TabIndex = 0;
            dataGridViewAppointments.CellContentClick += dataGridViewAppointments_CellContentClick;
            // 
            // idAppointmentColumn
            // 
            idAppointmentColumn.DataPropertyName = "id";
            idAppointmentColumn.HeaderText = "ID";
            idAppointmentColumn.Name = "idAppointmentColumn";
            // 
            // clientIdAppointmentColumn
            // 
            clientIdAppointmentColumn.DataPropertyName = "ClientId";
            clientIdAppointmentColumn.HeaderText = "Клиент (ID)";
            clientIdAppointmentColumn.Name = "clientIdAppointmentColumn";
            // 
            // masterIdAppointmentColumn
            // 
            masterIdAppointmentColumn.DataPropertyName = "MasterId";
            masterIdAppointmentColumn.HeaderText = "Мастер (ID)";
            masterIdAppointmentColumn.Name = "masterIdAppointmentColumn";
            // 
            // serviceIdAppointmentColumn
            // 
            serviceIdAppointmentColumn.DataPropertyName = "ServiceId";
            serviceIdAppointmentColumn.HeaderText = "Услуга (ID)";
            serviceIdAppointmentColumn.Name = "serviceIdAppointmentColumn";
            // 
            // startTimeAppointmentColumn
            // 
            startTimeAppointmentColumn.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            startTimeAppointmentColumn.DefaultCellStyle = dataGridViewCellStyle2;
            startTimeAppointmentColumn.HeaderText = "Начало";
            startTimeAppointmentColumn.Name = "startTimeAppointmentColumn";
            // 
            // endTimeAppointmentColumn
            // 
            endTimeAppointmentColumn.DataPropertyName = "EndTime";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            endTimeAppointmentColumn.DefaultCellStyle = dataGridViewCellStyle3;
            endTimeAppointmentColumn.HeaderText = "Окончание";
            endTimeAppointmentColumn.Name = "endTimeAppointmentColumn";
            // 
            // bookedPriceAppointmentColumn
            // 
            bookedPriceAppointmentColumn.DataPropertyName = "BookedPrice";
            bookedPriceAppointmentColumn.HeaderText = "Стоимость на момент записи (руб)";
            bookedPriceAppointmentColumn.Name = "bookedPriceAppointmentColumn";
            // 
            // statusAppointmentColumn
            // 
            statusAppointmentColumn.DataPropertyName = "Status";
            statusAppointmentColumn.HeaderText = "Статус";
            statusAppointmentColumn.Items.AddRange(new object[] { "Выполнено", "Запланировано", "Отменено" });
            statusAppointmentColumn.Name = "statusAppointmentColumn";
            statusAppointmentColumn.Resizable = DataGridViewTriState.True;
            statusAppointmentColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dateAppointmentColumn
            // 
            dateAppointmentColumn.DataPropertyName = "Date";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dateAppointmentColumn.DefaultCellStyle = dataGridViewCellStyle4;
            dateAppointmentColumn.HeaderText = "Плановая дата визита";
            dateAppointmentColumn.Name = "dateAppointmentColumn";
            // 
            // buttonEditAppointmentColumn
            // 
            buttonEditAppointmentColumn.HeaderText = "Редактировать";
            buttonEditAppointmentColumn.Name = "buttonEditAppointmentColumn";
            buttonEditAppointmentColumn.Resizable = DataGridViewTriState.True;
            buttonEditAppointmentColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            buttonEditAppointmentColumn.Text = "Редактировать";
            buttonEditAppointmentColumn.UseColumnTextForLinkValue = true;
            // 
            // buttonDeleteAppointmentColumn
            // 
            buttonDeleteAppointmentColumn.HeaderText = "Удалить";
            buttonDeleteAppointmentColumn.Name = "buttonDeleteAppointmentColumn";
            buttonDeleteAppointmentColumn.Resizable = DataGridViewTriState.True;
            buttonDeleteAppointmentColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            buttonDeleteAppointmentColumn.Text = "Удалить";
            buttonDeleteAppointmentColumn.UseColumnTextForButtonValue = true;
            // 
            // FormBeautySalon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tabControlMain);
            Controls.Add(MenuStrip1);
            Name = "FormBeautySalon";
            Text = "Салон красоты";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabPageServices.ResumeLayout(false);
            groupBoxSearchService.ResumeLayout(false);
            groupBoxSearchService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            tabPageMasters.ResumeLayout(false);
            groupBoxSearchMaster.ResumeLayout(false);
            groupBoxSearchMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasters).EndInit();
            tabPageClients.ResumeLayout(false);
            groupBoxSearchClient.ResumeLayout(false);
            groupBoxSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            tabPageAppointments.ResumeLayout(false);
            groupBoxSearchAppointment.ResumeLayout(false);
            groupBoxSearchAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentServiceId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentMasterId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchAppointmentClientId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageMasters;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private Button buttonAddService;
        private DataGridView dataGridViewServices;
        private GroupBox groupBoxSearchService;
        private Button buttonDeleteService;
        private TextBox textBoxSearchServiceTitle;
        private Label labelSearchServiceTitle;
        private Button buttonSearchService;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewLinkColumn ButtonEdit;
        private DataGridViewButtonColumn ButtonDelete;
        private Button ButtonReset;
        private DataGridView dataGridViewMasters;
        private DataGridView dataGridViewClients;
        private DataGridView dataGridViewAppointments;
        private TextBox textBoxSearchMasterFirstName;
        private Button buttonDeleteMaster;
        private Button buttonAddMaster;
        private Button buttonDeleteClient;
        private Button buttonAddClient;
        private Button buttonDeleteAppointment;
        private Button buttonAddAppointment;
        private GroupBox groupBoxSearchMaster;
        private Label labelSearchMasterPatronymic;
        private TextBox textBoxSearchMasterLastName;
        private Label labelSearchMasterLastName;
        private Label labelSearchMasterFirstName;
        private Button buttonSearchMaster;
        private TextBox textBoxSearchMasterPhone;
        private Label labelSearchMasterPhone;
        private TextBox textBoxSearchMasterSpecialization;
        private Label labelSearchMasterSpecialization;
        private TextBox textBoxSearchMasterPatronymic;
        private Button buttonResetMasterPhone;
        private Button buttonResetMasterSpecialization;
        private Button buttonResetMasterPatronymic;
        private Button buttonResetMasterLastName;
        private Button buttonResetMasterFirstName;
        private DataGridViewTextBoxColumn idMasterColumn;
        private DataGridViewTextBoxColumn firstNameMasterColumn;
        private DataGridViewTextBoxColumn lastNameMasterColumn;
        private DataGridViewTextBoxColumn PatronymicMasterColumn;
        private DataGridViewTextBoxColumn specializationMasterColumn;
        private DataGridViewTextBoxColumn phoneMasterColumn;
        private DataGridViewLinkColumn buttonEditMasterColumn;
        private DataGridViewButtonColumn buttonDeleteMasterColumn;
        private DataGridViewTextBoxColumn idClientColumn;
        private DataGridViewTextBoxColumn firstNameClientColumn;
        private DataGridViewTextBoxColumn surnameClientColumn;
        private DataGridViewTextBoxColumn patronymicClientColumn;
        private DataGridViewTextBoxColumn phoneNumberClientColumn;
        private DataGridViewComboBoxColumn genderClientColumn;
        private DataGridViewTextBoxColumn birthDateClientColumn;
        private DataGridViewLinkColumn buttonEditClientColumn;
        private DataGridViewButtonColumn buttonDeleteClientColumn;
        private GroupBox groupBoxSearchClient;
        private TextBox textBoxSearchClientFirstName;
        private Label labelSearchClientFirstName;
        private ComboBox comboBoxSearchClientGender;
        private Label label1;
        private Button buttonResetClientPhoneNumber;
        private TextBox textBoxSearchClientPhoneNumber;
        private Label labelSearchClientPhoneNumber;
        private Button buttonResetClientPatronymic;
        private TextBox textBoxSearchClientPatronymic;
        private Label labelSearchClientPatronymic;
        private Button buttonResetClientSurname;
        private TextBox textBoxSearchClientSurname;
        private Label labelSearchClientSurname;
        private Button buttonResetClientFirstName;
        private DateTimePicker dateTimePickerSearchClientBirthDate;
        private Label labelSearchClientBirthDate;
        private Button buttonSearchClient;
        private GroupBox groupBoxSearchAppointment;
        private Button buttonResetAppointmentMasterId;
        private NumericUpDown numericUpDownSearchAppointmentMasterId;
        private Label labelSearchAppointmentMasterId;
        private Button buttonResetAppointmentClientId;
        private NumericUpDown numericUpDownSearchAppointmentClientId;
        private Label labelSearchAppointmentClientId;
        private Label labelSearchAppointmentServiceId;
        private NumericUpDown numericUpDownSearchAppointmentServiceId;
        private DateTimePicker dateTimePickerSearchAppointmentDate;
        private Label labelSearchAppointmentDate;
        private ComboBox comboBoxSearchAppointmentStatus;
        private Label labelSearchAppointmentStatus;
        private Button buttonResetAppointmentServiceId;
        private Button buttonSearchAppointment;
        private NumericUpDown numericUpDownSearchAppointmentPrice;
        private Label labelSearchAppointmentPrice;
        private DataGridViewTextBoxColumn idAppointmentColumn;
        private DataGridViewTextBoxColumn clientIdAppointmentColumn;
        private DataGridViewTextBoxColumn masterIdAppointmentColumn;
        private DataGridViewTextBoxColumn serviceIdAppointmentColumn;
        private DataGridViewTextBoxColumn startTimeAppointmentColumn;
        private DataGridViewTextBoxColumn endTimeAppointmentColumn;
        private DataGridViewTextBoxColumn bookedPriceAppointmentColumn;
        private DataGridViewComboBoxColumn statusAppointmentColumn;
        private DataGridViewTextBoxColumn dateAppointmentColumn;
        private DataGridViewLinkColumn buttonEditAppointmentColumn;
        private DataGridViewButtonColumn buttonDeleteAppointmentColumn;
    }
}
