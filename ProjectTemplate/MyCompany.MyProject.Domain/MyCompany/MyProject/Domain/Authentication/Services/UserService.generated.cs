﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using MyCompany.MyProject.Domain.Authentication.Entities;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using cdmdotnet.Logging;
using Cqrs.Authentication;
using Cqrs.Commands;
using Cqrs.Repositories.Queries;
using Cqrs.Services;

namespace MyCompany.MyProject.Domain.Authentication.Services
{
	public  partial class UserService 
	{

		public virtual IServiceResponseWithResultData<IEnumerable<Entities.UserEntity>> GetAll(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, UserServiceGetAllParameters> serviceRequest)
		{
			AuthenticationTokenHelper.SetAuthenticationToken(serviceRequest.AuthenticationToken);
			CorrelationIdHelper.SetCorrelationId(serviceRequest.CorrelationId);
			IServiceResponseWithResultData<IEnumerable<Entities.UserEntity>> results = null;
			OnGetAll(serviceRequest, ref results);
			return CompleteResponse(results);
		}

		partial void OnGetAll(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, UserServiceGetAllParameters> serviceRequest, ref IServiceResponseWithResultData<IEnumerable<Entities.UserEntity>> results);


		public virtual IServiceResponseWithResultData<Entities.UserEntity> GetByRsn(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, UserServiceGetByRsnParameters> serviceRequest)
		{
			AuthenticationTokenHelper.SetAuthenticationToken(serviceRequest.AuthenticationToken);
			CorrelationIdHelper.SetCorrelationId(serviceRequest.CorrelationId);
			IServiceResponseWithResultData<Entities.UserEntity> results = null;
			OnGetByRsn(serviceRequest, ref results);
			return CompleteResponse(results);
		}

		partial void OnGetByRsn(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, UserServiceGetByRsnParameters> serviceRequest, ref IServiceResponseWithResultData<Entities.UserEntity> results);

	}
}