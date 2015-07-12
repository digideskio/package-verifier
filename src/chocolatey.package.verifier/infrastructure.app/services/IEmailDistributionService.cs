// Copyright � 2015 - Present RealDimensions Software, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
// You may obtain a copy of the License at
// 
// 	http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace chocolatey.package.verifier.infrastructure.app.services
{
    /// <summary>
    ///   Sends out specific system messages
    /// </summary>
    public interface IEmailDistributionService
    {
        /// <summary>
        ///   Sends the reset password message.
        /// </summary>
        /// <param name="to">The recipient.</param>
        /// <param name="resetCode">The reset code.</param>
        void send_reset_password_message(string to, string resetCode);
    }
}
