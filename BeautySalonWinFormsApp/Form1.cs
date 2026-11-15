using BeautySalonWinFormsApp.Data;
using System.Reflection;

namespace BeautySalonWinFormsApp
{
    public partial class FormBeautySalon : Form
    {
        public FormBeautySalon()
        {
            InitializeComponent();

            ServiceCrud();
            MasterCrud();
            ClientCrud();
            AppointmentCrud();
            var Service = new List<Service>()
            {
                new Service
                {
                    id = 1,
                    Title = "Аппаратный маникюр и гель-лак",
                    Description = "Комплексный гигиенический маникюр, выравнивание ногтевой пластины базой, покрытие в один тон",
                    Price = 2200,
                    Duration = 90
                },
                new Service
                {
                    id = 2,
                    Title = "Сложное окрашивание (Airtouch)",
                    Description = "Многоцветное окрашивание волос с растяжкой цвета",
                    Price = 7500,
                    Duration = 240
                },
                new Service
                {
                    id = 3,
                    Title = "Архитектура и окрашивание бровей",
                    Description = "Подбор идеальной формы пинцетом/воском, окрашивание профессиональной хной или краской",
                    Price = 1500,
                    Duration = 40
                },
                new Service
                {
                    id = 4,
                    Title = "Увлажняющий уход для лица",
                    Description = "Глубокое очищение кожи, нанесение сыворотки с гиалуроновой кислотой, альгинатная маска и массаж",
                    Price = 3000,
                    Duration = 60
                }
            };

            dataGridViewServices.DataSource = Service;

            var masters = new List<Master>()
            {
                new Master
                {
                    id = 1,
                    FirstName = "Алина",
                    Surname = "Пак",
                    Patronymic = "Дмитриевна",
                    Specialization = "Мастер маникюра и педикюра",
                    PhoneNumber = "+79991112233"
                },
                new Master
                {
                    id = 2,
                    FirstName = "Валерия",
                    Surname = "Ахматова",
                    Patronymic = "Сергеевна",
                    Specialization = "Стилист-колорист по волосам",
                    PhoneNumber = "+79992223344"
                },
                new Master
                {
                    id = 3,
                    FirstName = "Элина",
                    Surname = "Браун",
                    Patronymic = "Артуровна",
                    Specialization = "Мастер-бровист, визажист",
                    PhoneNumber = "+79993334455"
                },
                new Master
                {
                    id = 4,
                    FirstName = "Кристина",
                    Surname = "Ли",
                    Patronymic = "Владимировна",
                    Specialization = "Косметолог",
                    PhoneNumber = "+79994445566"
                }
            };

            dataGridViewMasters.DataSource = masters;

            var clients = new List<Client>()
            {
                new Client
                {
                    id = 1,
                    FirstName = "Мария",
                    Surname = "Иванова",
                    Patronymic = "Ивановна",
                    PhoneNumber = "+79001234567",
                    Gender = "Женский",
                    BirthDate = "15.06.2005"
                },
                new Client
                {
                    id = 2,
                    FirstName = "Ксения",
                    Surname = "Смирнова",
                    Patronymic = "Сергеевна",
                    PhoneNumber = "+79007654321",
                    Gender = "Женский",
                    BirthDate = "20.11.2004"
                },
                new Client
                {
                    id = 3,
                    FirstName = "Александр",
                    Surname = "Петров",
                    Patronymic = "Витальевич",
                    PhoneNumber = "+79009998877",
                    Gender = "Мужской",
                    BirthDate = "10.03.1998"
                },
                new Client
                {
                    id = 4,
                    FirstName = "Дарья",
                    Surname = "Кузнецова",
                    Patronymic = "Алексеевна",
                    PhoneNumber = "+79005554433",
                    Gender = "Женский",
                    BirthDate = "01.02.2006"
                }
            };

            dataGridViewClients.DataSource = clients;

            var appointments = new List<Appointment>()
            {
                new Appointment
                {
                    id = 1,
                    ClientId = 1,
                    MasterId = 1,
                    ServiceId = 1,
                    StartTime = "12:00",
                    EndTime = "13:30",
                    BookedPrice = 2200,
                    Status = "Выполнено",
                    Date = "24.10.2026"
                },
                new Appointment
                {
                    id = 2,
                    ClientId = 2,
                    MasterId = 2,
                    ServiceId = 2,
                    StartTime = "14:00",
                    EndTime = "18:00",
                    BookedPrice = 7500,
                    Status = "Запланировано",
                    Date = "24.10.2026"
                },
                new Appointment
                {
                    id = 3,
                    ClientId = 3,
                    MasterId = 4,
                    ServiceId = 4,
                    StartTime = "10:00",
                    EndTime = "11:00",
                    BookedPrice = 3000,
                    Status = "Запланировано",
                    Date = "25.10.2026"
                },
                new Appointment
                {
                    id = 4,
                    ClientId = 4,
                    MasterId = 3,
                    ServiceId = 3,
                    StartTime = "11:00",
                    EndTime = "11:40",
                    BookedPrice = 1500,
                    Status = "Отменено",
                    Date = "23.10.2026"
                }
            };

            dataGridViewAppointments.AutoGenerateColumns = false;
            dataGridViewAppointments.DataSource = appointments;



        }

        public void ServiceCrud()
        {
            using (var context = new BeautySalonContext())
            {
                var service = new Service
                {
                    Title = "Маникюр",
                    Description = "Аппаратный маникюр и гель-лак",
                    Price = 2200,
                    Duration = 90
                };
                context.Services.Add(service);
                context.SaveChanges();
            }

            using (var context = new BeautySalonContext())
            {
                var services = context.Services.ToList();
                foreach (var s in services)
                {
                    Console.WriteLine(s.Title);
                }
            }

            using (var context = new BeautySalonContext())
            {
                var service = context.Services.FirstOrDefault();
                if (service != null)
                {
                    service.Price = 2500;
                    context.SaveChanges();
                }
            }

            using (var context = new BeautySalonContext())
            {
                var service = context.Services.FirstOrDefault();
                if (service != null)
                {
                    context.Services.Remove(service);
                    context.SaveChanges();
                }


            }
        }

        public void MasterCrud()
        {

        }

        public void ClientCrud()
        {

        }

        public void AppointmentCrud()
        {

        }

        private void menuItemExit_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            var form = new ButtonResetDuration();
            form.ShowDialog();
        }

        private void labelSearchServiceTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchServiceTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchService_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuItemHelp_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            var form = new FormAbout();
            form.ShowDialog();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxSearchServiceTitle.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteMaster_Click(object sender, EventArgs e)
        {

        }

        private void tabPageServices_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerSearchClientBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddMaster_Click(object sender, EventArgs e)
        {
            var form = new FormMasterAdd();
            form.ShowDialog();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var form = new FormClientAdd();
            form.ShowDialog();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            var form = new FormappointmentAdd();
            form.ShowDialog();
        }

        private void buttonResetMasterFirstName_Click(object sender, EventArgs e)
        {
            textBoxSearchMasterFirstName.Clear();
        }

        private void buttonResetMasterLastName_Click(object sender, EventArgs e)
        {
            textBoxSearchMasterLastName.Clear();
        }

        private void buttonResetMasterPatronymic_Click(object sender, EventArgs e)
        {
            textBoxSearchMasterPatronymic.Clear();
        }

        private void buttonResetMasterSpecialization_Click(object sender, EventArgs e)
        {
            textBoxSearchMasterSpecialization.Clear();
        }

        private void buttonResetMasterPhone_Click(object sender, EventArgs e)
        {
            textBoxSearchMasterPhone.Clear();
        }

        private void buttonResetClientFirstName_Click(object sender, EventArgs e)
        {
            textBoxSearchClientFirstName.Clear();
        }

        private void buttonResetClientSurname_Click(object sender, EventArgs e)
        {
            textBoxSearchClientSurname.Clear();
        }

        private void buttonResetClientPatronymic_Click(object sender, EventArgs e)
        {
            textBoxSearchClientPatronymic.Clear();
        }

        private void buttonResetClientPhoneNumber_Click(object sender, EventArgs e)
        {
            textBoxSearchClientPhoneNumber.Clear();
        }

        private void buttonResetAppointmentClientId_Click(object sender, EventArgs e)
        {
            numericUpDownSearchAppointmentClientId.Value = 0;
        }

        private void buttonResetAppointmentMasterId_Click(object sender, EventArgs e)
        {
            numericUpDownSearchAppointmentMasterId.Value = 0;
        }

        private void buttonResetAppointmentServiceId_Click(object sender, EventArgs e)
        {
            numericUpDownSearchAppointmentServiceId.Value = 0;
        }

        private void tabPageClients_Click(object sender, EventArgs e)
        {

        }
    }
}