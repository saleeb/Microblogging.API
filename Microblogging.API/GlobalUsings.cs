global using Azure.Storage.Blobs;
global using MediatR;
global using Microblogging.ApplicationService.Auth.login.Query;
global using Microblogging.ApplicationService.Posts.Command;
global using Microblogging.ApplicationService.Services.Posts;
global using Microblogging.Domain.Contracts.Services;
global using Microblogging.Domain.Models.auth;
global using Microblogging.Domain.Models.DTOs;
global using Microblogging.Domain.Models.ViewModels;
global using Microblogging.Domain.Repository;
global using Microblogging.Domain.Servicies.Post;
global using Microblogging.Infrastructure.Repository;
global using Microblogging.Infrastructure.Services;
global using MicrobloggingApp.Infrastructure.Data;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;
global using System.Reflection;
global using System.Text;
global using AutoMapper;
global using Microblogging.Domain.Entities;


