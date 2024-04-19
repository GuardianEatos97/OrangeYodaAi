using OpenAiModel.Views;
using OpenAiModel.ViewModels;

namespace OpenAiModel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            //Routing.RegisterRoute("question", typeof(YodaQuestionPage));
            //Routing.RegisterRoute("answer", typeof(YodaAnswerPage));
            Routing.RegisterRoute("Facts", typeof(FactsPage));
        }
    }
}
