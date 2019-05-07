using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM.Common
{
    public class Enums
    {
            public enum ActionType
            {
                Add = 0,
                Remove = 1
            }
            public enum ApplicationTypes
            {
                JavaScript = 0,
                NativeConfidential = 1
            };

            public enum StatusCode
            {
                Ok = 201,
                Accepted = 202,
                Unauthorized = 401,
                Forbidden = 403,
                Error = 500,
                GatewayTimeout = 503,
                TokenInValid = 190
            };

            public enum FormAction
            {
                /// <summary>
                /// Allow Action Read
                /// </summary>
                Read = 0,
                /// <summary>
                /// Allow Action Write
                /// </summary>
                Write = 1,
                /// <summary>
                /// Allow Action Delete
                /// </summary>
                Delete = 2
            }

            public enum StatusNewsFlash
            {
                Live = 0,
                Expired = 1,
                Draft = 2,
                Disable = 3
            }

            public enum StatusReviewerSubmit
            {
                Ok = 1,
                Warning = 2,
                Error = 3
            }
        }
}
