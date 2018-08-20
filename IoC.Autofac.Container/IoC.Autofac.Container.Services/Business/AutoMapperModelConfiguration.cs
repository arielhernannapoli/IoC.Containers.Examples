namespace IoC.Autofac.Container.Services.Business
{
    public static class AutomapperModelConfiguration
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new UsuarioProfile());
            });

        }
    }
}
