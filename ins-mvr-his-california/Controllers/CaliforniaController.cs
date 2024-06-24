using ins_mvr_his_california.Models;
using Microsoft.HostIntegration.TI;
using System;
using System.Text;
using System.Web.Http;

namespace ins_mvr_his_california.Controllers
{
    public class CaliforniaController : ApiController
    {
        /* Send this string to test - be sure to update the DATE/TIME fields                                                                                             
         *                                                                         YYYYMMDDHHMMSS
curl -X POST -H "Content-Type: application/json" -d "{\"Query\": \"DMV2EX01A00MSGS 20240623180416MVRDEV01                                                                      BURKKATEST                      LXNXTESTT                                                  .DB2X0001KABV7I0031007CAM52X4000       \"}" https://localhost:44391/api/California
         */
        // POST: api/California
        public IHttpActionResult Post([FromBody] QueryPayload payload)
        {
            try
            { 
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Your logic here, using payload.Query
                byte[] INQUIRY = ConvertToEbcdic(payload.Query);
                INQUIRY[237] = 0x03; //terminate query  
                byte[] RESPONSE;

                ClientContext clientContext = new ClientContext();
                California.DMV dmv = new California.DMV();
                dmv.DMV2(INQUIRY, out RESPONSE, ref clientContext);

                string response = ConvertEbcdicToAscii(RESPONSE);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // Existing methods...
        static byte[] ConvertToEbcdic(string input)
        {
            // Create an encoding for the EBCDIC code page 37
            Encoding ebcdic = Encoding.GetEncoding(37);

            // Convert the string to EBCDIC bytes
            return ebcdic.GetBytes(input);
        }

        static string ConvertEbcdicToAscii(byte[] ebcdicBytes)
        {
            // Create an encoding for the EBCDIC code page 37
            Encoding ebcdic = Encoding.GetEncoding(37);

            // Convert the EBCDIC bytes to an ASCII string
            return ebcdic.GetString(ebcdicBytes);
        }

        // GET: api/California/Status
        [HttpGet]
        [Route("api/California/Status")]
        public IHttpActionResult GetStatus()
        {
            return Ok("UP");
        }

    }
}
