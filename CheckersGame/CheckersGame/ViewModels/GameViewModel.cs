using CheckersGame.Commands;
using CheckersGame.Models;
using CheckersGame.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;

namespace CheckersGame.ViewModels
{
    internal class GameViewModel : BaseViewModel, ISerializable
    {
        public GameViewModel()
        {
            Game = new Game();

            SquareClickCommand = new RelayCommand(SquareClick);
            LoadGameCommand = new RelayCommand(LoadGame);
            SaveGameCommand = new RelayCommand(SaveGame);
            ShowAboutCommand = new RelayCommand(ShowAboout);
            ShowStatisticsCommand = new RelayCommand(ShowStatistics);
            ChangeTurnCommand = new RelayCommand(ChangeTurn);
            StartNewGameCommand = new RelayCommand(StartNewGame);
        }

        private Game _game;

        public Game Game { get; set; }

        public ICommand SquareClickCommand { get; set; }
        public ICommand LoadGameCommand { get; set; }
        public ICommand SaveGameCommand { get; set; }
        public ICommand ShowStatisticsCommand { get; set; }
        public ICommand ShowAboutCommand { get; set; }
        public ICommand ChangeTurnCommand { get; set; }
        public ICommand StartNewGameCommand { get; set; }


        private void SquareClick(object parameter)
        {
            var piece = parameter as Piece;
            if (piece != null)
                Game.OnPieceClicked(piece);

        }

        public void ChangeTurn(object parameter)
        {
            Game.ChangeTurn();
        }

        private void LoadGame(object parameter)
        {
            int ceva = 1;
        }
        private void SaveGame(object parameter)
        {
            string filePath = "game.json";

            try
            {
                //string jsonData = JsonSerializer.Serialize(Game, new JsonSerializerOptions { WriteIndented = true });

                //File.WriteAllText(filePath, jsonData);

                Console.WriteLine("Game saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving game: {ex.Message}");
            }
        }

        private void ShowAboout(object parameter)
        {
            AboutView aboutPage = new AboutView();
            aboutPage.Show();
        }
        private void ShowStatistics(object parameter)
        {
            StatisticsView statisticsView = new StatisticsView();
            statisticsView.Show();
        }
        private void StartNewGame(object parameter)
        {
            Game.Restart();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
