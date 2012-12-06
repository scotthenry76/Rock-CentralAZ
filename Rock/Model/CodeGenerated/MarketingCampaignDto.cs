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
    /// Data Transfer Object for MarketingCampaign object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class MarketingCampaignDto : DtoSecured<MarketingCampaignDto>
    {
        /// <summary />
        [DataMember]
        public string Title { get; set; }

        /// <summary />
        [DataMember]
        public int? ContactPersonId { get; set; }

        /// <summary />
        [DataMember]
        public string ContactEmail { get; set; }

        /// <summary />
        [DataMember]
        public string ContactPhoneNumber { get; set; }

        /// <summary />
        [DataMember]
        public string ContactFullName { get; set; }

        /// <summary />
        [DataMember]
        public int? EventGroupId { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public MarketingCampaignDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="marketingCampaign"></param>
        public MarketingCampaignDto ( MarketingCampaign marketingCampaign )
        {
            CopyFromModel( marketingCampaign );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "Title", this.Title );
            dictionary.Add( "ContactPersonId", this.ContactPersonId );
            dictionary.Add( "ContactEmail", this.ContactEmail );
            dictionary.Add( "ContactPhoneNumber", this.ContactPhoneNumber );
            dictionary.Add( "ContactFullName", this.ContactFullName );
            dictionary.Add( "EventGroupId", this.EventGroupId );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.Title = this.Title;
            expando.ContactPersonId = this.ContactPersonId;
            expando.ContactEmail = this.ContactEmail;
            expando.ContactPhoneNumber = this.ContactPhoneNumber;
            expando.ContactFullName = this.ContactFullName;
            expando.EventGroupId = this.EventGroupId;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is MarketingCampaign )
            {
                var marketingCampaign = (MarketingCampaign)model;
                this.Title = marketingCampaign.Title;
                this.ContactPersonId = marketingCampaign.ContactPersonId;
                this.ContactEmail = marketingCampaign.ContactEmail;
                this.ContactPhoneNumber = marketingCampaign.ContactPhoneNumber;
                this.ContactFullName = marketingCampaign.ContactFullName;
                this.EventGroupId = marketingCampaign.EventGroupId;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is MarketingCampaign )
            {
                var marketingCampaign = (MarketingCampaign)model;
                marketingCampaign.Title = this.Title;
                marketingCampaign.ContactPersonId = this.ContactPersonId;
                marketingCampaign.ContactEmail = this.ContactEmail;
                marketingCampaign.ContactPhoneNumber = this.ContactPhoneNumber;
                marketingCampaign.ContactFullName = this.ContactFullName;
                marketingCampaign.EventGroupId = this.EventGroupId;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class MarketingCampaignDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static MarketingCampaign ToModel( this MarketingCampaignDto value )
        {
            MarketingCampaign result = new MarketingCampaign();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<MarketingCampaign> ToModel( this List<MarketingCampaignDto> value )
        {
            List<MarketingCampaign> result = new List<MarketingCampaign>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<MarketingCampaignDto> ToDto( this List<MarketingCampaign> value )
        {
            List<MarketingCampaignDto> result = new List<MarketingCampaignDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static MarketingCampaignDto ToDto( this MarketingCampaign value )
        {
            return new MarketingCampaignDto( value );
        }

    }
}