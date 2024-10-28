namespace FactoryMethodPattern.Example
{
    internal class Controller
    {
        protected void RenderView()
        {
            var engine = CreatViewEngine();
            engine.Render();
        }


        ////can make abstract also 
        //public abstract IViewEngine ViewEngine();

        /// <summary>
        /// Factory method
        /// </summary>
        /// <returns></returns>
        protected virtual IViewEngine CreatViewEngine()
        {
            //default view engine
            return new MatchViewEngine();
        }
    }
}
