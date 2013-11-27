using System;
using System.Threading.Tasks;
namespace Igooana {
  interface IApi {
    Task<bool> Authenticate(Uri uri);
    Uri AuthenticateUri { get; }
  }
}
