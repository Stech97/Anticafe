﻿using System;
using System.Windows;
using Anticafe.Model;
using System.Windows.Input;
using System.Windows.Controls;

namespace Anticafe
{
    public partial class StartWindow : Window
    {
		private readonly ILog _log;

		public StartWindow()
        {
            InitializeComponent();
			CLogin.Items.Add("Admin");
			CLogin.Items.Add("qwaszx");
			_log = LogManager.CreateLogger("Desktop", "trace");
			_log.Trace("Старт приложения");

			//не забудь убрать после отладки
			/*if (GetFromDB.GetStateDB())
				CLogin.ItemsSource = GetFromDB.GetCurrentAdministrator();
			else
			{
				_log.Errors("Нет подключения к Базе Данных.");
				_log.Errors("Приложение закрыто с кодом -1");
				Environment.Exit(-1);
			}*/
        }

		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			var mes = "На смене:" + CLogin.Text;
            _log.Trace(mes);
            _log.Trace("Смена началась");

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}

	}
}