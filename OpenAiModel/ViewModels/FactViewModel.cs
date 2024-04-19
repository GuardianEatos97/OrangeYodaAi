using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.AI.OpenAI;
using OpenAiModel.ViewModels;
using OpenAiModel.Views;
using OpenAiModel.Enums;
using OpenAiModel.Configuration;
using OpenAiModel.Services;
using OpenAiModel.Models;
using CommunityToolkit.Mvvm.Input;
using OpenAiModel.Services.Interfaces;

namespace OpenAiModel.ViewModels
{
    public partial class FactViewModel : BaseViewModel
    {
        private IAiAssistant _assistant;
        public FactViewModel(IAiAssistant AiAssistant)
        {
            _assistant = AiAssistant;
        }

        private ChatMessage _factshow;
        public ChatMessage Factshow
        { get { return _factshow; }
            set
            {
                _factshow = value;
                OnPropertyChanged();
            } 

        }

        [RelayCommand]
        public async void ShowFact() 
        {
            Factshow = await _assistant.GetCompletion();
        }
    } 
}

