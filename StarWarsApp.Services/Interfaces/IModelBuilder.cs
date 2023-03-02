namespace StarWarsApp.Services.Interfaces
{
    internal interface IModelBuilder<TInput, TOutput>
    {
        public TOutput Build(TInput input);
    }
}
