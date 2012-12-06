//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Data Transfer Object for PageRoute object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class PageRouteDto : DtoSecured<PageRouteDto>
    {
        /// <summary />
        [DataMember]
        public bool IsSystem { get; set; }

        /// <summary />
        [DataMember]
        public int PageId { get; set; }

        /// <summary />
        [DataMember]
        public string Route { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public PageRouteDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="pageRoute"></param>
        public PageRouteDto ( PageRoute pageRoute )
        {
            CopyFromModel( pageRoute );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "PageId", this.PageId );
            dictionary.Add( "Route", this.Route );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.IsSystem = this.IsSystem;
            expando.PageId = this.PageId;
            expando.Route = this.Route;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is PageRoute )
            {
                var pageRoute = (PageRoute)model;
                this.IsSystem = pageRoute.IsSystem;
                this.PageId = pageRoute.PageId;
                this.Route = pageRoute.Route;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is PageRoute )
            {
                var pageRoute = (PageRoute)model;
                pageRoute.IsSystem = this.IsSystem;
                pageRoute.PageId = this.PageId;
                pageRoute.Route = this.Route;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class PageRouteDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PageRoute ToModel( this PageRouteDto value )
        {
            PageRoute result = new PageRoute();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PageRoute> ToModel( this List<PageRouteDto> value )
        {
            List<PageRoute> result = new List<PageRoute>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PageRouteDto> ToDto( this List<PageRoute> value )
        {
            List<PageRouteDto> result = new List<PageRouteDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PageRouteDto ToDto( this PageRoute value )
        {
            return new PageRouteDto( value );
        }

    }
}