﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieManager>().As<IMovieService>();
            builder.RegisterType<EfMovieDal>().As<IMovieDal>();

            builder.RegisterType<DirectorManager>().As<IDirectorService>();
            builder.RegisterType<EfDirectorDal>().As<IDirectorDal>();

            builder.RegisterType<CastManager>().As<ICastService>();
            builder.RegisterType<EfCastDal>().As<ICastDal>();

            builder.RegisterType<CastImageManager>().As<ICastImageService>();
            builder.RegisterType<EfCastImageDal>().As<ICastImageDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>();

            builder.RegisterType<DirectorImageManager>().As<IDirectorImageService>();
            builder.RegisterType<EfDirectorImageDal>().As<IDirectorImageDal>();

            builder.RegisterType<MovieCastManager>().As<IMovieCastService>();
            builder.RegisterType<EfMovieCastDal>().As<IMovieCastDal>();

            builder.RegisterType<MovieCategoryManager>().As<IMovieCategoryService>();
            builder.RegisterType<EfMovieCategoryDal>().As<IMovieCategoryDal>();

            builder.RegisterType<MovieDirectorManager>().As<IMovieDirectorService>();
            builder.RegisterType<EfMovieDirectorDal>().As<IMovieDirectorDal>();

            builder.RegisterType<MovieImageManager>().As<IMovieImageService>();
            builder.RegisterType<EfMovieImageDal>().As<IMovieImageDal>();


        }
    }
}
