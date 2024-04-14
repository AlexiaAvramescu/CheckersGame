using CheckersGame.Commands;
using CheckersGame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;

namespace CheckersGame.ViewModels
{
    internal class GameViewModel : BaseViewModel
    {
        public GameViewModel()
        {
            Game = new Game();
            CurrentPlayer = EColor.Black;
            SelectedPiece = new Piece(-1, -1);
            IsGameOver = false;
            FirstMoveMade = false;
            FirstMoveCapture = false;

            SquareClickCommand = new RelayCommand(SquareClick);
            LoadGameCommand = new RelayCommand(LoadGame);
            SaveGameCommand = new RelayCommand(SaveGame);
            ShowAboutCommand = new RelayCommand(ShowAboout);
            ShowStatisticsCommand = new RelayCommand(ShowStatistics);
            ChangeTurnCommand = new RelayCommand(ChangeTurn);
            StartNewGameCommand = new RelayCommand(StartNewGame);
        }

        private Game _game;
        private bool _isGameOver;
        private EColor _currentPlayer;
        private bool _firstMoveMade;
        private Piece _selectedPiece;
        public bool IsGameOver
        {
            get { return _isGameOver; }
            set
            {
                _isGameOver = value;
                OnPropertyChanged(nameof(IsGameOver));
            }
        }
        public bool FirstMoveMade { get; set; }
        private bool FirstMoveCapture { get; set; }

        public Game Game { get; set; }
        public Piece SelectedPiece
        {
            get { return _selectedPiece; }
            set
            {
                _selectedPiece = value;
                OnPropertyChanged(nameof(SelectedPiece));
                OnPropertyChanged(nameof(Game.Board.Pieces));
            }
        }
        public EColor CurrentPlayer
        {
            get { return _currentPlayer; }
            set
            {
                _currentPlayer = value;
                OnPropertyChanged(nameof(CurrentPlayer));
            }
        }
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
            bool firstMoveCapture = FirstMoveCapture;
            if (piece != null)
            {
                if (!piece.IsNull && SelectedPiece.IsNull && piece.Color == CurrentPlayer)
                {
                    SelectedPiece = piece;
                }
                else if (!SelectedPiece.IsNull)
                {
                    if (piece.IsNull)
                    {
                        if (Game.MakeMove(SelectedPiece, piece, FirstMoveMade, ref firstMoveCapture))
                        {
                            if (!Game.MultipleJumps)
                                CurrentPlayer = (CurrentPlayer == EColor.White) ? EColor.Black : EColor.White;
                            else
                                FirstMoveMade = true;
                        }
                        if (Game.Board.WhitePiecesCount == 0 || Game.Board.BlackPiecesCount == 0)
                        {
                            IsGameOver = true;
                            // record statistics
                        }
                        FirstMoveCapture = firstMoveCapture;

                    }
                    SelectedPiece = new Piece(-1, -1);
                }
            }
        }

        public void ChangeTurn(object parameter)
        {
            if (FirstMoveMade)
            {
                CurrentPlayer = (CurrentPlayer == EColor.White) ? EColor.Black : EColor.White;
                FirstMoveMade = false;
                FirstMoveCapture = false;
            }
        }

        private void LoadGame(object parameter)
        {
            int ceva = 1;
        }
        private void SaveGame(object parameter)
        {
            //string filePath = "game.json";

            //try
            //{
            //    // Serialize the Game object to JSON including GameViewModel properties
            //    string jsonData = JsonSerializer.Serialize(Game);

            //    // Write the serialized JSON data to a file
            //    File.WriteAllText(filePath, jsonData);

            //    // Display a message or perform any other actions upon successful save
            //    Console.WriteLine("Game saved successfully.");
            //}
            //catch (Exception ex)
            //{
            //    // Handle any exceptions that occur during the save process
            //    Console.WriteLine($"Error saving game: {ex.Message}");
            //}
        }

        private void ShowAboout(object parameter) { }
        private void ShowStatistics(object parameter) { }
        private void StartNewGame(object parameter) { }
    }
}
