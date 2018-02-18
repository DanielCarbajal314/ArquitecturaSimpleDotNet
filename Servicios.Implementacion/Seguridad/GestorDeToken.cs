using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Seguridad.User.Respuesta;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion.Seguridad
{
    public class GestorDeToken : IGestorDeToken
    {
        private readonly string SECRET_KEY = ConfigurationManager.AppSettings["LLaveSecreta"]??"ThisIsMySecreTT";
        private readonly static IJsonSerializer serializer = new JsonNetSerializer();
        private readonly static IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
        private readonly static IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
        private readonly static IDateTimeProvider provider = new UtcDateTimeProvider();

        private IJwtEncoder encoder;
        private IJwtDecoder decoder;

        public GestorDeToken()
        {
            IJwtValidator validator = new JwtValidator(serializer, provider);
            this.decoder = new JwtDecoder(serializer, validator, urlEncoder);
            this.encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
        }

        public string GenerarToken(Usuario usuario)
        {
            return encoder.Encode(usuario, SECRET_KEY);
        }

        public Usuario RecuperarInformacionDeUsuario(string token)
        {           
            return decoder.DecodeToObject<Usuario>(token, SECRET_KEY, verify: true);
        }
    }
}
