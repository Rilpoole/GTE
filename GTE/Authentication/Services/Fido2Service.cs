using Fido2NetLib.Objects;
using Fido2NetLib;
using Microsoft.Extensions.Options;
using Authentication.Data;

namespace Authentication.Services
{
    /*
    public class Fido2Service
    {
        private readonly Fido2 _fido2;
        private readonly IMetadataService _metadataService; // Optional for attestation

        public Fido2Service(Fido2 fido2)
        {
            _fido2 = fido2;
        }

        public CredentialCreateOptions StartRegistration(User user)
        {
            var options = _fido2.RequestNewCredential(user.ToFido2User(), new List<PublicKeyCredentialDescriptor>(),
                AuthenticatorSelection.Default, AttestationConveyancePreference.None);
            return options;
        }

        public async Task<Fido2.CredentialMakeResult> CompleteRegistration(AuthenticatorAttestationRawResponse attestationResponse)
        {
            var result = await _fido2.MakeNewCredentialAsync(attestationResponse, options,
                isCredentialIdUniqueToUserAsync);
            return result;
        }

        private async Task<bool> isCredentialIdUniqueToUserAsync(IsCredentialIdUniqueToUserParams args)
        {
            // Look up your database to verify if credentialId is unique
            return true;
        }
    }
    */
}
