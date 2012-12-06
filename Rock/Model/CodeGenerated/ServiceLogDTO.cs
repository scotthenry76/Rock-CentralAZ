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
    /// Data Transfer Object for ServiceLog object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class ServiceLogDto : DtoSecured<ServiceLogDto>
    {
        /// <summary />
        [DataMember]
        public DateTime? Time { get; set; }

        /// <summary />
        [DataMember]
        public string Input { get; set; }

        /// <summary />
        [DataMember]
        public string Type { get; set; }

        /// <summary />
        [DataMember]
        public string Name { get; set; }

        /// <summary />
        [DataMember]
        public string Result { get; set; }

        /// <summary />
        [DataMember]
        public bool Success { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public ServiceLogDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="serviceLog"></param>
        public ServiceLogDto ( ServiceLog serviceLog )
        {
            CopyFromModel( serviceLog );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "Time", this.Time );
            dictionary.Add( "Input", this.Input );
            dictionary.Add( "Type", this.Type );
            dictionary.Add( "Name", this.Name );
            dictionary.Add( "Result", this.Result );
            dictionary.Add( "Success", this.Success );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.Time = this.Time;
            expando.Input = this.Input;
            expando.Type = this.Type;
            expando.Name = this.Name;
            expando.Result = this.Result;
            expando.Success = this.Success;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is ServiceLog )
            {
                var serviceLog = (ServiceLog)model;
                this.Time = serviceLog.Time;
                this.Input = serviceLog.Input;
                this.Type = serviceLog.Type;
                this.Name = serviceLog.Name;
                this.Result = serviceLog.Result;
                this.Success = serviceLog.Success;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is ServiceLog )
            {
                var serviceLog = (ServiceLog)model;
                serviceLog.Time = this.Time;
                serviceLog.Input = this.Input;
                serviceLog.Type = this.Type;
                serviceLog.Name = this.Name;
                serviceLog.Result = this.Result;
                serviceLog.Success = this.Success;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceLogDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static ServiceLog ToModel( this ServiceLogDto value )
        {
            ServiceLog result = new ServiceLog();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<ServiceLog> ToModel( this List<ServiceLogDto> value )
        {
            List<ServiceLog> result = new List<ServiceLog>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<ServiceLogDto> ToDto( this List<ServiceLog> value )
        {
            List<ServiceLogDto> result = new List<ServiceLogDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static ServiceLogDto ToDto( this ServiceLog value )
        {
            return new ServiceLogDto( value );
        }

    }
}