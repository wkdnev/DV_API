### IA-1 — Policy and Procedures (Control)

This requirement ensures the organisation has clear, approved rules for how people are identified and how they prove they are who they say they are. It must also include practical, step-by-step guidance. Without this, the wrong people could gain access to systems, accounts could be created or changed incorrectly, and sensitive information could be exposed or misused—particularly when job roles change or when regulations are updated.

The organisation must create and document an identification and authentication policy that covers the whole organisation, key business activities, and relevant systems. The policy must explain why it exists, what it applies to, who is responsible for what, how leadership supports it, how different teams work together, and how compliance will be checked. It must remain consistent with all relevant laws and internal standards.

An identification and access management (IAM) policy owner must be appointed within the Chief Information Security Officer (CISO) organisation to manage this policy. The policy must be shared with all users, privileged users, and identity administrators. The supporting procedures must also be shared with the operational teams that carry out these processes.

The policy and procedures must be reviewed at least once every year, and also after audit findings, security incidents, breach reports, major role or Human Resources (HR) changes, or changes to applicable regulations and guidance.

##### CISO-owned IA policy & role-based procedures with trigger-based review

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-approved **identification and authentication (IA) policy** and supporting **IA procedures**. Share them with the relevant, defined groups. Review and update them at least **every year** and also after specific triggering events.

###### WHY (control requirement)
IA-1 requires that the organisation has **IA policy and procedures** that cover the IA-related control requirements used across systems and organisations. The guidance highlights that:
- the risk management approach must feed into the policy/procedures,
- the security and privacy programmes must work together,
- the policy/procedures must be **written down** (not just a repeat of the control statements),
- the policy/procedures should cover **organisation-wide**, **mission/business process-wide**, and **system-specific** needs where appropriate,
- updates must happen after **assessment or audit findings, security incidents or breaches, or changes to relevant laws, regulations, directives, standards, or guidance**.

###### HOW (specific steps/approach)
1. **Set ownership and a review/approval process**: appoint the **IAM Policy Owner within the CISO organisation** as the accountable owner for the IA policy and procedures. Use the **IAM governance board (CISO + IAM governance board)** as the review and approval body.
2. **Write the IA policy as the main, authoritative document** (a single source of truth; use annexes only if needed). Include: purpose, scope (all users, privileged users, identity administrators, and relevant systems/identity stores), roles and responsibilities, management commitment, coordination between security and privacy programmes, and how compliance will be assured. Add an explicit section showing how the policy aligns with applicable laws, regulations, standards, and guidance.
3. **Create role-based procedures** as separate documents (or clearly separated sections). These should be practical “how-to” instructions for the defined audiences, aligned to the policy:
   - **IAM administrators** (identity lifecycle, multi-factor authentication (MFA) enrolment and management, privileged access workflows, exception handling)
   - **System owners** (what is expected when bringing a system into use, including IA integration)
   - **HR/identity lifecycle managers** (joiner, mover, and leaver triggers, and expectations for identity data quality)
   - **Security operations** (operational response to IA-related events and how evidence is handled)
4. **Share the documents with proof that they were provided**:
   - publish the IA policy to **all users, privileged users, and identity administrators** (for example, a controlled repository link plus acknowledgement for privileged/identity admin audiences),
   - publish the IA procedures to **IAM administrators, system owners, HR/identity lifecycle managers, and security operations**.
5. **Review and update based on triggers**:
   - set review to **every year** and after triggering events,
   - define triggering events separately for the policy and for the procedures:
     - **policy triggers**: audit findings, security incidents/breach reports, changes to applicable regulations or guidance
     - **procedure triggers**: audit findings, security incidents, major role/HR changes, and new or changed laws, directives, standards
   - record the outcome of each review (approved, updated, or replaced) using version control and keep approval evidence.
6. **Link to system plans where needed**: ensure system-level documentation points to the organisation’s IA policy/procedures (or the relevant annexes) rather than repeating requirements.

###### WHO (role responsible)
- **IAM Policy Owner (CISO organisation)**: accountable for the IA policy/procedures, approvals, and sharing.
- **IAM governance board (CISO + IAM governance)**: approves changes and ensures alignment with the risk management approach.
- **Security programme and Privacy programme leads**: co-author/validate the policy/procedure content for security and privacy assurance.
- **HR/identity lifecycle managers, system owners, IAM administrators, security operations**: provide procedure input and confirm it is workable in practice.

###### Acceptance criteria
- An approved IA policy exists, is version-controlled, and includes purpose, scope, roles, responsibilities, coordination, and compliance approach, including a mapping to applicable requirements.
- IA procedures exist for each defined audience and clearly explain how the policy is put into practice (not just a repeat of the control requirements).
- The IA policy is shared with **all users, privileged users, and identity administrators**, with auditable evidence of access and acknowledgement.
- The IA procedures are shared with **IAM administrators, system owners, HR/identity lifecycle managers, and security operations**, with auditable evidence.
- A document review/update schedule is set to **every year**, and updates are triggered and recorded after the defined events.
- System security/privacy plans reference the IA policy/procedures (or annexes) where system-level tailoring is required.

###### Actions Required for Compliance

- [ ] Appoint an “identity and access management (IAM) policy owner” within the Chief Information Security Officer (CISO) organisation, and set up the approval process through the IAM governance board.
- [ ] Create and get approval for the organisation’s information assurance (IA) policy using a structured template that covers: purpose, scope, responsibilities, coordination, and how it maps to required compliance standards.
- [ ] Develop role-based access control (RBAC) procedures for identity and access management (IAM) administrators, system owners, human resources (HR) and identity lifecycle managers, and security operations.
- [ ] Publish and share the information assurance (IA) policy with all users, privileged users, and identity administrators, and ensure their access and acknowledgement are recorded for audit purposes.
- [ ] Publish and share the information assurance (IA) procedures with the agreed audiences, and ensure access is auditable.
- [ ] Set document control to review and update the information assurance (IA) policy every year and after any triggering events. Apply the same approach to the procedures, using their defined triggers.
- [ ] Update the system security and privacy plans to point to the information assurance (IA) policy and procedures (or annexes) instead of repeating the same requirements.


---

### IA-2 — Identification and Authentication (Organizational Users) (Control)

This expectation is about making sure every person who works for the organisation has their own unique way to prove who they are, and that the system records their identity whenever they do anything—whether the work is done by a person or automatically on their behalf. Without this, actions could be wrongly linked to the wrong person, unauthorised access could go unnoticed, and it would be difficult to investigate mistakes or misuse because you would not know who actually did what.

To meet this expectation, the organisation must keep a clear, up-to-date link between each employee and the equivalent worker (including contractors and guest researchers), and ensure there is a single, individual account for each person. People must be able to sign in using an approved method, such as a password, a physical device, or a biometric check.

The organisation must also ensure the system logs the unique person identity for user actions, and that any automated processes acting on a person’s behalf use that person’s identity—not a generic or shared login—unless this is explicitly allowed elsewhere.

##### Federated SSO with phishing-resistant MFA and user identity propagation

- Category: Software
- Priority: Critical

###### WHAT
Set up sign-in for organisational users (employees, contractors, guest researchers) using a central identity system (Identity Provider (IdP)). Require multi-factor authentication (MFA) that is resistant to phishing for all access to the network and for remote access. Make sure the application records the authenticated unique identity of the user for every action, including actions carried out by automated processes acting on the user’s behalf.

###### WHY (control requirement)
IA-2 requires the organisation to **uniquely identify and verify organisational users**, and to link that unique identity to processes acting on the users’ behalf. It also requires that this unique identification and verification applies to access other than any explicitly exempted by AC-14, and that verification is enforced for **network access** (including remote access).

###### HOW (specific steps/approach)
1. **Authoritative identity mapping**: Set the IdP as the system of record and create user accounts from Human Resources (HR), contractor, and guest sources. Ensure each organisational user is mapped to a **single, unique identifier** (an unchanging unique user ID) that is used consistently throughout the application.
2. **Enforce strong authentication**: Require phishing-resistant MFA (for example, FIDO2/security keys or an equivalent method) for all sign-ins to the application for **network and remote access**. Use conditional access rules so MFA is required for interactive sign-ins, and require additional checks (“step-up”) for sensitive actions.
3. **Federated sign-in integration**: Connect the application using Security Assertion Markup Language (SAML) or OpenID Connect (OIDC) so the application receives the IdP’s stable unique user identifier (for example, `sub` / immutable user ID) and uses it as the accountable identity.
4. **Pass identity for “processes acting on behalf of users”**: For background jobs, workflow systems, Application Programming Interface (API) calls, and other asynchronous processing started by a user, pass the initiating user’s unique identity into the job context (for example, using signed information/session context). Ensure audit logs record the initiating user identity, not a generic account.
5. **Close accountability gaps**: Check for any shared or group authentication methods used for user-initiated activity. Remove them or restrict them to situations that are explicitly justified under the organisation’s AC-14 exceptions. In all other cases, require individual sign-in.
6. **Audit evidence**: Configure application audit logging so every action started by a user includes the authenticated unique user identifier (and can be linked to the IdP session). Send logs to the security information and event management (SIEM) system for tamper-resistant storage and verification.

###### WHO
- **Identity and Access Management (IAM) Engineer**: Configure the IdP, manage user provisioning, and set up MFA and conditional access.
- **Application Security/Platform Engineer**: Implement Security Assertion Markup Language (SAML) or OpenID Connect (OIDC) integration, ensure identity is carried through workflows/jobs, and set up audit logging.
- **Application Owner / Operations Lead**: Confirms any exceptions (if applicable) and verifies that audit logging is complete.

###### Acceptance criteria
- The application signs in organisational users through the central IdP and uses a **stable unique identifier** from the IdP for accountability.
- Phishing-resistant MFA is required for all network and remote access to the application.
- For asynchronous/background actions started by a user, audit logs show the **initiating user’s unique identifier** (not a generic/shared or service identity).
- Shared/group authentication methods are not used for actions attributed to users, except where explicitly documented under AC-14.
- Application audit logs (and SIEM checks) show that the unique user identifier is present for recent sign-ins and for representative user-initiated workflows.

###### Actions Required for Compliance

- [ ] Integrate the application with the organisation’s identity provider (IdP) using OpenID Connect (OIDC) or Security Assertion Markup Language (SAML), and link the IdP’s permanent (immutable) subject identifier to the application’s user identity field.
- [ ] Set up conditional access so that all users must use phishing-resistant multi-factor authentication (MFA) when accessing the application through both the network and remote connections.
- [ ] Set up identity propagation for asynchronous workflows and jobs, so the audit record includes the unique identifier of the user who started the process.
- [ ] Set up application audit logging so that every user action is recorded with the unique identifier of the signed-in user, and send the logs to the security information and event management (SIEM) system.
- [ ] Identify and fix any shared or group login credentials used for actions that are attributed to individual users, and record any AC-14 exceptions.
- [ ] Run an evidence test: start a workflow initiated by a user, which triggers background processing, and check that the security information and event management (SIEM) and application logs show the same unique identifier for the initiating user from start to finish.


---

#### IA-2.1 — Multi-factor Authentication to Privileged Accounts (Enhancement)

This requirement is about protecting the most powerful accounts in your systems. It ensures that people cannot gain access using only one simple check.

It matters because if a privileged account is protected only by a password (or another single form of proof), an attacker who steals that password could take over systems, change who has access, or cause serious disruption.

To meet this requirement, your organisation must:
- keep an up-to-date list of all privileged accounts, and
- require two or more different types of proof for every login to each of those accounts.

This applies whether the login is made on-site, from another device on your network, or from outside your environment.

Your organisation must choose the right combination of proofs based on the level of risk. You must then document and implement this using clear identification and authentication rules, step-by-step procedures, system plans and designs, the actual system settings that enforce the requirement, and audit records showing when the extra proof was requested and successfully used (or when access was blocked).

##### Enforce MFA with two factor types for all privileged logons

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement multi-factor authentication (MFA) for access to **privileged accounts**, ensuring that every privileged account login uses **two or more different authentication factor types** (for example: something you know plus something you have). This requirement must apply to **local, network, and remote** ways of accessing systems.

###### WHY (control requirement)
NIST IA-2(1) (Enhancement) requires: **“Implement multi-factor authentication for access to privileged accounts.”** The guidance also states that MFA must use **two or more different factors** (something you know/have/are), and that privileged accounts must use MFA options appropriate to the **level of risk** for **local, network, and remote** access.

###### HOW (specific steps/approach)
1. **Create and keep an up-to-date list of privileged accounts** by identifying privileged roles/groups (for example, directory administrator groups), privileged local administrator accounts (from the device inventory), and privileged “break-glass” accounts. Keep this list current using an automated discovery process and a change workflow.
2. **Choose and standardise at least two different factor types** for privileged sign-ins (for example: password/PIN plus a FIDO2 security key, or smart card plus PIN). Make sure the selected factors are enforced as **separate factor types** (not two password-like factors).
3. **Apply MFA for privileged users at the identity layer** using the organisation’s central identity provider (IdP) with conditional access rules that target the privileged account list (privileged groups/roles). Configure the rules so that **every privileged sign-in** (including admin portals and privileged workflows) requires MFA with the required combination of factor types.
4. **Control privileged sessions for admin access (privileged access management (PAM) / jump host where applicable)** so that privileged actions taken from admin consoles, jump hosts, and remote administration tools are governed by the same identity enforcement. Set up “step-up” authentication for privileged actions if a session could be created without MFA.
5. **Extend enforcement to remote and network access routes** by integrating VPN/remote access gateways and remote administration tools with the IdP/PAM, so privileged logons trigger MFA.
6. **Handle local access on devices** by either: (a) removing unmanaged local administrator accounts and replacing them with centrally managed accounts that are covered by the privileged account list and IdP enforcement, or (b) routing local privileged elevation through a managed method (for example, PAM-mediated local administrator elevation) so local privileged logons cannot avoid MFA.
7. **Produce audit evidence**: ensure logs record, at minimum, the privileged account identifier, sign-in attempt, which factor types were prompted/used, whether MFA succeeded or failed, and the access path (local/network/remote) where possible. Keep logs in line with enterprise logging and retention requirements and send them to security information and event management (SIEM).

###### WHO (role responsible)
- **Identity and Access Management (IAM) Lead**: responsible for IdP MFA and conditional access configuration for privileged groups.
- **Privileged Access Management (PAM) Engineer**: responsible for session brokering and step-up enforcement for privileged admin workflows.
- **Endpoint / Operational Technology (OT) / Infrastructure Security Engineer**: responsible for the local privileged access approach and device enforcement (either removing unmanaged local administrators or using managed elevation).
- **Security Operations Centre (SOC) / SIEM Engineer**: ensures audit logging, correlation, and retention.

###### Acceptance criteria
- For every privileged account in the authoritative inventory, **all** login attempts via **local, network, and remote** routes require MFA using **two or more different factor types**.
- MFA enforcement cannot be bypassed through alternative admin consoles, jump hosts, remote administration tools, or device local administrator elevation paths (within the defined integration scope).
- Audit records show MFA was **prompted and succeeded/failed** for privileged logons, including factor-type evidence where supported by the IdP/PAM.
- The privileged account inventory is demonstrably current (for example, updated within an agreed timeframe and checked during change events).

###### Actions Required for Compliance

- [ ] Build and keep an up-to-date, authoritative list of privileged accounts, including directory administrators, privileged local administrators, and break-glass accounts.
- [ ] Standardise which multi-factor authentication (MFA) methods are allowed for privileged access (for example, password/PIN plus FIDO2, or a smart card) and document this policy.
- [ ] Set up identity provider (IdP) conditional access so that multi-factor authentication (MFA) is required for every privileged group or role, using the required combination of authentication factors.
- [ ] Set up or configure privileged access management (PAM) and a jump host so that privileged administrator sessions are handled through the identity provider (IdP) and require additional “step-up” multi-factor authentication (MFA) when needed.
- [ ] Set up virtual private network (VPN) and remote access, and remote administration tools, so that when privileged users log in remotely through the identity provider (IdP) and privileged access management (PAM), multi-factor authentication (MFA) is required.
- [ ] Remove or control unapproved local accounts with high privileges, so that local high-privilege logins cannot be used to bypass multi-factor authentication (MFA), either through central management or by using privileged access management (PAM) to control any elevation of permissions.
- [ ] Turn on and keep audit logs that record attempts to sign in using privileged accounts, including whether multi-factor authentication (MFA) succeeded or failed, along with evidence of the factor used, and send these logs to security information and event management (SIEM).


---

#### IA-2.2 — Multi-factor Authentication to Non-privileged Accounts (Enhancement)

This requirement is about making sure that people always sign in to everyday, non-administrator accounts using two different ways to prove who they are—not just a password. Without this, a stolen or guessed password could let an attacker access systems and services directly, which could lead to data loss, fraud, or wider harm.

To meet this expectation, the organisation must set out in its access and sign-in rules that every non-administrator account needs two or more different types of proof of identity. The types of proof must be chosen based on the level of risk, depending on how people connect, whether they sign in locally, over a network, or from a remote location. The organisation must then apply these rules through clear sign-in procedures, system design, and configuration settings. It must also keep reliable records of sign-in activity and maintain an up-to-date list of accounts, so it can demonstrate that the second proof was required and enforced for all non-administrator users.

##### Enforce MFA for all non-privileged app logins via IdP

- Category: Software
- Priority: Critical

###### WHAT
Set up multi-factor authentication (two or more different checks) for access to **non-privileged accounts** for the enterprise application. Make sure multi-factor authentication is required for **every way users can sign in**, including web, mobile, and application programming interface (API) access, and any remote access routes that lead to the application.

###### WHY (control requirement)
IA-2(2) (Enhancement) requires: **“Implement multi-factor authentication for access to non-privileged accounts.”** The guidance says multi-factor authentication must use **two or more different factors** (for example, something you know, something you have, or something you are). It must be applied for **local, network, and remote** access using options appropriate to the risk.

###### HOW (specific steps/approach)
1. **Define non-privileged accounts** in the application’s access model as users who are not in privileged or administrator roles (for example, identity provider (IdP) groups/roles mapped from role-based access control (RBAC) and least-privilege definitions).
2. **Centralise sign-in through the enterprise identity provider (IdP)** (federated single sign-on) so the application follows the IdP’s sign-in results, rather than running its own password-only sign-in process.
3. Configure the IdP so that, when non-privileged users sign in to the application, it requires **multi-factor authentication using at least two different factor types**. Where possible, choose phishing-resistant combinations (for example, password plus FIDO2/passkey, or smart card/PIV plus a PIN).
4. **Remove any ways to skip multi-factor authentication**: turn off or restrict “remember this device” and any older sign-in methods that could let non-privileged users sign in using only one factor. Ensure the application blocks sessions/tokens that do not meet the IdP’s required multi-factor authentication assurance.
5. For **API and other non-interactive sign-in flows**, ensure any user-authenticated API access uses the same federated identity approach (for example, OAuth/OpenID Connect (OAuth/OIDC) with multi-factor authentication enforced during the interactive sign-in). Do not introduce separate single-factor credentials for non-privileged users.
6. **Apply the same enforcement in all environments** (production, testing, and disaster recovery) by using the same IdP policy set, with environment-specific application registrations. Do not weaken multi-factor authentication requirements in non-production environments.
7. **Keep proof for audits**: retain IdP sign-in logs showing the multi-factor authentication challenge and whether it succeeded or failed for non-privileged users. Also retain configuration exports and “policy-as-code” artefacts that show the multi-factor authentication requirement and the non-privileged scope.
8. **Maintain an up-to-date list of non-privileged accounts** by synchronising identity group membership (from identity governance and administration (IGA), human resources (HR), and role assignments) and periodically reconciling it with the application’s user list.

###### WHO
- **Identity and Access Management (IAM) Lead**: define the non-privileged scope and implement IdP multi-factor authentication and conditional access policies.
- **Application Owner / Security Engineer**: ensure the application uses federated single sign-on (federated SSO) / OAuth/OpenID Connect (OAuth/OIDC) and rejects tokens that do not show the required multi-factor authentication assurance.
- **Platform/DevOps Engineer**: implement consistent configuration across environments and ensure evidence is retained (logs and configuration exports).
- **Compliance/Assurance**: check the audit evidence and review reconciliation of the non-privileged account list.

###### Acceptance criteria
- Every non-privileged user who tries to access the application through supported entry points is prompted for **multi-factor authentication using two or more different factors**, and cannot complete sign-in using only one factor.
- No supported sign-in method (web, mobile, API) allows multi-factor authentication to be bypassed for non-privileged accounts (including “remember this device” and legacy sign-in flows).
- IdP logs and exported policy/configuration evidence show multi-factor authentication is enforced for the defined non-privileged scope.
- The non-privileged account list (IdP group membership/role mapping) is current and reconciled with the application’s user inventory on an agreed schedule.

###### Actions Required for Compliance

- [ ] Define “non-privileged accounts” as an identity provider (IdP) group or role scope that excludes any privileged or administrator roles.
- [ ] Set up the identity provider (IdP) so that, for that non-privileged access scope, users must use multi-factor authentication (MFA) with two or more different types of factors when signing in to the application.
- [ ] Require multi-factor authentication (MFA) at the application level by only accepting federated tokens or sessions that confirm MFA has been completed.
- [ ] Disable or restrict multi-factor authentication (MFA) bypass options (for example, older sign-in methods and weak “remember this device” behaviour) for non-privileged access.
- [ ] Check that multi-factor authentication (MFA) is enforced for every way users can sign in, including the website, mobile apps, and user-authenticated application programming interface (API) requests.
- [ ] Enable and keep identity provider (IdP) sign-in audit logs, and export the multi-factor authentication (MFA) and conditional access settings as evidence.
- [ ] Carry out regular checks to reconcile the list of non-privileged accounts between the identity governance and administration (IGA) / identity provider (IdP) groups and the application’s user inventory.


---

#### IA-2.5 — Individual Authentication with Group Authentication (Enhancement)

This requirement is about ensuring that, even if a business uses shared logins or shared access tools, each person is still verified as an individual before they can use anything linked to the shared account. Without this, someone could misuse a shared login, or access could be granted without knowing who actually signed in. That makes it harder to prevent wrongdoing and to identify who is responsible after something goes wrong.

To meet this expectation, the organisation must clearly state in its access rules that individual sign-in must happen before any shared account or shared resource is used. It must also explain in its system plans and design documents how the system enforces this rule. Staff procedures and system settings must be configured so access is blocked until the individual check is successful, and the system must keep records showing that the individual check took place before access was granted.

The organisation must also keep an up-to-date list of shared accounts, and document both the shared access method and the individual sign-in method the system uses.

##### Enforce individual authentication before shared account access

- Category: Software
- Priority: Critical

###### WHAT
Set up an “individual authentication gate” so that when a shared account or shared authentication device is used to access a shared resource, every user must first complete their own individual authentication step. Access to the shared account/resource is blocked until the individual authentication is successful.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Identity and Access Management (IA)-2(5) requires that, when shared accounts or shared authenticators are used, users are individually authenticated before being allowed access to the shared accounts or resources. This reduces the risk of unauthorised use of shared credentials and improves accountability.

###### HOW (specific steps/approach)
1. **Identify the ways users can reach shared access** in the application (for example: admin consoles, privileged actions, shared database or service credentials exposed through the application, shared jump or bastion workflows, or shared application programming interface (API) credentials used by operators).
2. **Add an individual-authentication gate at every entry point** that would otherwise allow direct use of the shared account/resource:
   - For **web, mobile, and API** flows: require the user to authenticate through the enterprise identity provider (IdP) (single sign-on (SSO)) before the application can start any action that uses the shared account.
   - For **operational or administrative actions** (if applicable): require an authenticated operator session through the IdP before the system can arrange or trigger any shared-credential session.
3. **Route shared access through the gate**:
   - Configure the application to use the shared account only as a **back-end credential** (never as an interactive login for operators).
   - Make sure the application only requests and uses the shared credential after the individual authentication gate confirms success.
4. **Enforce “block until success” in code/configuration**:
   - Reject the request if the individual authentication information is missing, expired, or not valid.
   - Confirm the individual authentication is recent (for example, the session is still valid) before allowing the shared-resource action.
5. **Create audit evidence**:
   - Record an auditable entry that includes: the individual user identity, time and date, authentication result, the shared resource/account identifier used, and the access decision.
   - Ensure logs are sent to the security information and event management (SIEM) system and kept according to enterprise logging requirements.
6. **Document how the control is enforced**:
   - Update the system security plan and relevant design documents to explain how the gate prevents access to shared resources without individual authentication.
   - Keep an up-to-date list of shared accounts/authenticators and the specific shared resources they enable.

###### WHO (roles responsible)
- **Application Owner / Engineering Lead**: implement the gate and the back-end shared-credential handling.
- **Identity and Access Management (IAM) Team**: ensure the enterprise identity provider (IdP) integration supports the required authentication assurance and session behaviour.
- **Security/Compliance Team**: check the audit evidence, review the documentation (system security plan and design), and confirm the shared-account list is complete.

###### Acceptance criteria
- For every workflow that uses a shared account/authenticator, attempts to access the shared resource **must fail** unless the user has an active, successfully authenticated individual session.
- Audit logs must show, for each shared-resource action: the individual user identity, the authentication outcome, and the shared account/resource identifier used.
- The system security plan/design documentation must clearly describe the “individual authentication before shared access” enforcement mechanism.
- A maintained inventory must exist for shared accounts/authenticators, mapping each to the shared resources it enables.

###### Actions Required for Compliance

- [ ] Identify and list every application workflow that uses shared accounts or shared authentication methods, and link each one to the shared resources it enables.
- [ ] Set up an individual login check in the application for every place where a shared resource can be accessed (web, application programming interface (API), and admin actions). If the login check is not successful, block the request.
- [ ] Change how shared accounts are used so that the shared login details are only used behind the scenes after each person has successfully logged in individually (there is no shared, interactive login).
- [ ] Set up session checks so that operations on shared resources are blocked if the user’s authentication details are missing or have expired.
- [ ] Record an audit log for every shared-resource action, including the individual user’s identity, whether authentication succeeded or failed, and the identifier of the shared account or resource used; send these logs to security information and event management (SIEM).
- [ ] Update the system security plan and design documents to explain how the security controls are enforced, and to keep the shared-account and authenticator inventory up to date.


---

#### IA-2.6 — Access to Accounts —separate Device (Enhancement)

This expectation is about making sure that when anyone logs in to your systems, they must prove who they are using more than one check. At least one of those checks must come from a separate physical device that is not the system they are trying to access.  

This matters because if attackers steal a password or trick a system into accepting it, they can pretend to be staff and gain access to both important (privileged) and everyday (non-privileged) accounts. This can happen whether they connect on-site, through your network, or from outside.  

To meet this expectation, the organisation must require multi-check login for local, network, and remote access to both privileged and non-privileged accounts. It must also ensure that the separate-device check uses validated cryptography, is hardware-backed (for example, a security key), and is designed to resist phishing attempts.  

The organisation should document what is covered in its login rules and procedures, configure systems to enforce it, keep records showing it is being used, and assign clear responsibility for implementing and running the approach.

##### Enforce phishing-resistant MFA using FIDO2 hardware keys

- Category: Software
- Priority: Critical

###### WHAT
Require multi-factor authentication (MFA) for **local, network, and remote** access to the application for both **privileged** and **non-privileged** accounts, where **at least one factor is provided by a separate device** (e.g., a hardware security key) that is **built into the device**, **resistant to phishing**, and uses **FIPS 140-2 validated encryption**.

###### WHY (control requirement)
NIST IA-2(6) enhancement requires MFA so that one factor is provided on a **separate device** from the system being accessed. This reduces the chance that an attacker can take over the login method on the target system and then pretend to be the user. The separate-device factor must provide stronger protection through **validated encryption** and **built-in, phishing-resistant** login methods.

###### HOW (specific steps/approach)
1. **Define where MFA applies** in the identity and access policy for the application, so MFA is required for:
   - **local, network, remote** access routes (as applicable to the application’s sign-in steps and administrative consoles), and
   - both **privileged accounts** and **non-privileged accounts**.
2. **Choose and register approved login methods** in the identity provider (IdP) so only **FIPS 140-2 validated**, **built-in**, **phishing-resistant** login methods are allowed (for example, **FIDO2/WebAuthn security keys**). Block weaker MFA options for these sign-in situations.
3. **Require the separate-device factor** by configuring the IdP so the phishing-resistant part of the MFA check uses a **hardware security key** (so the login is not accepted using credentials that are stored on, or could be compromised on, the target system).
4. **Set conditional access / sign-in rules** so MFA is consistently triggered for:
   - normal user sign-in to the application,
   - any administrative interfaces for the application,
   - remote access scenarios (for example, virtual private network (VPN) or remote browser access) that lead to application sign-in.
5. **Set up audit logging** so authentication records include the MFA method used (including whether a hardware key was used), and send these logs to the security information and event management (SIEM) system for evidence and alerts on repeated failures or attempts to bypass MFA rules.
6. **Put enrolment and exceptions into day-to-day operation** with documented procedures for:
   - enrolling new keys,
   - replacing lost keys,
   - handling temporary exceptions (if any) with compensating controls and time limits.

###### WHO
- **IAM/Identity Engineer**: implement IdP MFA and conditional access rules, and configure approved login methods.
- **Application Owner / Security Engineer**: confirm the application sign-in steps and ensure all relevant local/network/remote access routes go through the IdP.
- **Security Operations (SOC)**: check that logging, retention, and SIEM alerts for MFA events are working correctly.
- **IT Service Desk / Identity and Access Management (IAM) Operations**: carry out enrolment and replacement procedures under the agreed governance.

###### Acceptance criteria
- For both **privileged** and **non-privileged** accounts, signing in to the application from **local, network, and remote** access routes requires MFA.
- During MFA, at least one factor is satisfied by a **separate built-in phishing-resistant login method** (for example, a FIDO2 security key), not by methods that depend on credentials stored on the target system.
- The IdP is configured to allow only login methods that meet the organisation’s required strength: **FIPS 140-2 validated encryption** and **built-in phishing-resistant capability**.
- Authentication logs show MFA challenges and outcomes, including the MFA method used, and are available for audit.
- Documented enrolment/recovery/exception procedures exist and are followed for any deviations.

###### Actions Required for Compliance

- [ ] Categorise every application sign-in point as local access, network access, or remote access, and identify which user accounts are privileged accounts versus non-privileged accounts.
- [ ] Configure the identity provider (IdP) to require multi-factor authentication (MFA) for both privileged and non-privileged accounts for every defined sign-in situation (local, network, and remote).
- [ ] Limit multi-factor authentication (MFA) to approved sign-in methods only, using only FIPS 140-2 validated, hardware-based, phishing-resistant authenticators (FIDO2/WebAuthn security keys).
- [ ] Require that the phishing-resistant multi-factor authentication (MFA) method is provided by a separate hardware device (a hardware security key), rather than by authentication methods linked to the target system.
- [ ] Set up and send audit logs to the security information and event management (SIEM) system that record the multi-factor authentication (MFA) method used, the results of each challenge, and whether each attempt succeeded or failed, so the logs can be used as evidence and to help detect threats.
- [ ] Publish and put into day-to-day operation the processes for user enrolment, replacement of keys, and time-limited exceptions, with responsibility held by identity and access management (IAM) and the security operations centre (SOC).


---

#### IA-2.8 — Access to Accounts — Replay Resistant (Enhancement)

This requirement is about making sure that once a person has successfully proved who they are to sign in, they cannot reuse the same captured sign-in proof to get in again. Without this protection, an attacker could record a previous sign-in attempt and use it again later, potentially gaining access to both normal accounts and higher-privilege accounts. That could then lead to unauthorised changes, exposure of data, or disruption to systems.

To meet this expectation, the organisation must clearly define and document that replay-resistant sign-in is required for both privileged and non-privileged accounts. It must also choose and record the specific method used (for example, a new one-time challenge or a time-limited proof each time), and update its sign-in rules, procedures, and system plans accordingly.

The organisation must configure live systems so both account types use only these replay-resistant methods, disable any weaker legacy options, keep audit records showing that replay attempts were blocked, and be able to demonstrate through testing and evidence review that replayed sign-in messages fail for both account types.

##### Replay-resistant authentication for privileged and non-privileged accounts

- Category: Software
- Priority: Critical

###### WHAT
Set up replay-resistant sign-in for both privileged and non-privileged accounts. Ensure every interactive sign-in uses a “freshness” check (a nonce/challenge or a cryptographic/time-limited authenticator) so that any captured sign-in messages cannot be reused successfully.

###### WHY (control requirement)
IA-2(8) requires that authentication methods for the organisation-defined account types (privileged and non-privileged) protect against replay attacks. This means it should be impractical to gain access by reusing (replaying) messages from a previous sign-in. Replay-resistant methods must include freshness (for example, nonces/challenges or time/cryptographic authenticators).

###### HOW (specific approach)
1. **Use a single replay-resistant sign-in method enforced by the identity provider (IdP)** for interactive user authentication (for example, FIDO2/Web Authentication (WebAuthn) or certificate-based authentication). This ensures the IdP issues a fresh challenge for each sign-in, and the authenticator returns cryptographic proof tied to that specific sign-in.
2. **Apply the same requirement to both account groups** by using the replay-resistant requirement for sign-in for both privileged and non-privileged accounts (as defined by `ia-02.08_odp`).
3. **Turn off or block weaker or older sign-in options** that do not provide replay resistance (for example, password-only, one-time password (OTP) flows without freshness, or older single sign-on (SSO) modes that could be replayed using captured messages).
4. **Ensure this application always uses the IdP’s replay-resistant sign-in flow** for all access points (web, mobile, and API admin consoles, portals, and any front-end components). Do not build custom sign-in that could allow replay.
5. **Make the control auditable** by enabling detailed sign-in logs that record the account identifier, account type (privileged/non-privileged), authentication method, and result (including failure reasons). Send these logs to security information and event management (SIEM) for evidence and detection.
6. **Prove replay resistance through testing**: complete a legitimate sign-in, then try to reuse (replay) the captured sign-in messages/assertions against the same relying party. Confirm the replay fails and that the attempt is recorded in logs for both privileged and non-privileged accounts.

###### WHO
- **Application Owner / Identity and Access Management (IAM) Lead**: owns the sign-in design and identity provider (IdP) policy settings.
- **Security Engineering / Compliance**: defines what evidence is required and checks that replay-resistance testing is carried out.
- **Platform/Infrastructure Team**: ensures all application entry points (web/admin/API gateways) use the IdP replay-resistant sign-in flow.

###### Acceptance criteria
- Privileged and non-privileged interactive sign-in flows are configured to use a replay-resistant mechanism that includes freshness (nonce/challenge or cryptographic/time-limited proof).
- Any legacy or fallback sign-in options that do not provide replay resistance are disabled or blocked for both account groups.
- Sign-in audit logs show, at minimum, the account identifier/type, authentication method, and success/failure including failure reason codes.
- Replay testing (replaying captured sign-in messages) fails for both privileged and non-privileged accounts and generates the expected audit records.

###### Actions Required for Compliance

- [ ] Identify and label every type of interactive user account as either privileged or non-privileged for the application’s access routes.
- [ ] Set up the organisation’s identity provider (IdP) to require an authentication method that cannot be reused by an attacker (for example, FIDO2/Web Authentication (WebAuthn) or certificate-based authentication) for both account groups.
- [ ] Disable or block older “fallback” sign-in methods that do not provide freshness checks (such as a nonce/challenge or a cryptographic, time-limited proof) for both privileged and non-privileged accounts.
- [ ] Update the application entry points (web, admin, and application programming interface (API) gateways, and any single sign-on (SSO) integrations) to use the identity provider’s replay-resistant authentication process rather than a custom authentication method.
- [ ] Enable and centralise sign-in audit logging, including the account type, authentication method, and the reason for any failed sign-in; send this information to security information and event management (SIEM).
- [ ] Run replay-resistance tests by recording a successful login exchange and checking that any replay attempts fail and are recorded in the logs for both privileged and non-privileged accounts.


---

#### IA-2.10 — Single Sign-on (Enhancement)

This requirement is about allowing people (and certain automated accounts) to sign in once and then automatically access multiple on-site business applications and identity-aware access points, without having to keep entering passwords again. Without this, staff may reuse passwords in unsafe ways, access may be granted inconsistently across systems, and it becomes harder to understand and trace what happened if something goes wrong.

To meet this expectation, the organisation must set up a single sign-on service for the specified on-site applications and identity-aware proxies. This must cover privileged user accounts, service accounts, and federation-managed application accounts. The organisation must also clearly document: the rules for checking identities, the overall security plan, and step-by-step operating procedures for both single sign-on and identity checking.

In addition, the organisation must document how the solution is built and configured, keep records of relevant sign-in and access activity, and maintain an up-to-date list of the exact accounts and services included.

##### Implement auditable SSO for in-scope privileged and service accounts

- Category: Software
- Priority: Critical

###### WHAT must be done
Provide a **single sign-on (SSO)** capability for the organisation-defined scope: **privileged user accounts, service accounts, and federation-managed application accounts** for **on-premises enterprise applications and identity-aware proxies**.

###### WHY (control requirement)
IA-2(10) requires the organisation to **“Provide a single sign-on capability for {{ param, ia-02.10_odp }}.”** The guidance explains that SSO improves operational efficiency, but it also increases risk because one sign-in event can allow access to multiple systems. Therefore, the SSO capability must be implemented in a way that is **secure, documented, and auditable**.

###### HOW (specific steps/approach)
Set up SSO using a central enterprise Identity Provider (IdP) and standards-based federation to the on-premises applications and identity-aware proxies in scope, ensuring both human and non-human identities (service/federation-managed) are covered.

1. **Create and maintain an SSO scope register** (the single source of truth) listing each in-scope **on-premises enterprise application** and **identity-aware proxy**. For each one, state which account types are used: **privileged user accounts**, **service accounts**, and/or **federation-managed application accounts**.
2. **Set up federation from the IdP to each in-scope on-premises application/proxy** using the supported protocol(s) (for example, **Security Assertion Markup Language 2.0 (SAML 2.0)** and/or **OpenID Connect (OIDC)**). Map IdP claims/groups to the application’s authorisation roles.
3. **Require strong authentication for privileged users** at the IdP (for example, conditional access and **multi-factor authentication (MFA)**, aligned to organisational standards). Configure session controls to reduce the risk of overly broad access after a single sign-in (for example, session length and when users must sign in again).
4. **Enable non-human SSO access** for service accounts and federation-managed application accounts using the IdP’s supported non-interactive approach (for example, workload identity / federation-managed application accounts). Ensure these identities are tightly restricted (least privilege) and mapped only to the minimum required authorisations for the application/proxy.
5. **Document SSO in the identification and authentication policy and the system security plan/design**. Include the SSO scope, authentication requirements, federation approach, session behaviour, and operational procedures for identity checks and day-to-day SSO operation.
6. **Make SSO auditable and produce evidence**: ensure the IdP and each in-scope application/proxy generate logs that allow you to link (a) the SSO sign-in event to (b) the subsequent access to in-scope resources, including for non-human identities. Send logs to the **security information and event management (SIEM)** system using consistent identifiers (for example, user/service principal, application/proxy, time, and session/token identifiers where available).

###### WHO (role responsible)
- **Identity and Access Management (IAM) Lead**: owns IdP configuration, federation mappings, and privileged authentication policies.
- **Application Owner / Proxy Owner**: confirms the application/proxy federation configuration and authorisation mappings are correct.
- **Security Architect / Compliance Lead**: ensures documentation, scope register governance, and audit evidence requirements are met.
- **Security Operations Centre (SOC)/SIEM Engineer**: ensures log forwarding, correlation fields, and alerts/detections are in place.

###### Acceptance criteria
- An **up-to-date SSO scope register** exists and includes all on-premises enterprise applications and identity-aware proxies in scope for IA-2(10), with the specified account types.
- All in-scope applications/proxies successfully accept IdP-issued assertions/tokens and grant access based on the mapped claims/roles.
- Privileged user authentication is enforced by the IdP (per organisational authentication/MFA standards), and session behaviour (session lifetime/re-sign-in rules) is configured to reduce the risk that one sign-in grants broad access.
- Service accounts and federation-managed application accounts can sign in using non-interactive SSO patterns and are authorised to access only the required resources.
- Audit logs from the IdP and in-scope resources are available in the SIEM and support linking SSO sign-in events to subsequent access for both human and non-human identities.
- Required documentation (policy/plan/design/procedures) is completed, reviewed, and the configuration is repeatable (version-controlled where applicable).

###### Actions Required for Compliance

- [ ] Create an SSO (single sign-on) scope register that lists all privileged user accounts, service accounts, and federation-managed application accounts for every in-scope on-premises enterprise application and every identity-aware proxy.
- [ ] Set up identity provider (IdP) federation—using security assertion markup language (SAML) and/or openid connect (OIDC), as supported—for each in-scope application and for each identity-aware proxy, with the correct claim and role mappings.
- [ ] Require strong authentication for privileged users at the identity provider (IdP), including multi-factor authentication (MFA) and conditional access in line with organisational standards, and set rules for how long sessions last and when users must re-authenticate.
- [ ] Set up non-interactive single sign-on (SSO) for service and federation-managed application accounts, using the identity provider’s (IdP’s) supported workload and federation setup patterns, with least-privilege authorisation mappings.
- [ ] Turn on and centralise audit logging for the identity provider (IdP) and each in-scope application or proxy, so that log records can be linked together—from the single sign-on (SSO) event to later access.
- [ ] Update the identification and authentication policy and the system security plan/design to cover single sign-on (SSO) scope, how it will be set up, how user sessions will behave, and the day-to-day operational procedures.


---

#### IA-2.12 — Acceptance of PIV Credentials (Enhancement)

This requirement is about only allowing entry when a person’s official identity badge is checked electronically and confirmed to be genuine. Without this, someone could use a fake, altered, or non-standard badge to access buildings or computer systems, putting staff, assets, and sensitive information at risk.

To meet this expectation, the organisation must accept Personal Identity Verification–compliant credentials (including any derived versions) only after the system electronically verifies each credential before access is granted. The badge must be issued by a federal issuer that meets the required standards.

The organisation must also keep a clear, documented process for deciding which issuers it trusts, and then only accept credentials from issuers it has authorised as reliable. In addition, the organisation must keep records showing which credentials were presented and the result of the electronic verification. The organisation must document this approach in its policies, system plans, procedures, and system settings, with clear responsibility assigned to the relevant teams.

##### Verify PIV credentials electronically via IdP with issuer allowlist

- Category: Software
- Priority: Critical

###### WHAT
Implement acceptance of Personal Identity Verification (PIV)-compliant credentials by requiring **electronic verification** of each credential before access is granted, and by accepting only credentials issued by **authorised, reliable federal issuers** (including derived PIV credentials).

###### WHY (control requirement)
NIST IA-2(12) (Enhancement) requires the organisation to **accept and electronically verify PIV-compliant credentials**. Acceptance must be limited to PIV credentials that are **compliant with Federal Information Processing Standards (FIPS) 201 and supporting guidance** (and derived PIV where applicable), with the reliability of issuers confirmed using **SP 800-79-2**. The purpose of this control is to stop access being granted using counterfeit, altered, or non-standard credentials.

###### HOW (specific steps/approach)
1. **Define the verification point and what happens on failure**: Configure the enterprise identity provider (IdP) authentication process so access is granted only when the login event includes a **successful electronic PIV verification** result. If verification cannot be completed or the result is missing, the IdP must **deny** access.
2. **Use an issuer allowlist**: Maintain a controlled and auditable allowlist of **authorised federal issuers** (and any derived credential types you accept). During authentication, identify the credential’s **issuer identity** (or a stable issuer attribute provided by the PIV middleware or gateway) and deny authentication if the issuer is not on the allowlist.
3. **Handle derived PIV credentials explicitly**: Ensure the IdP or middleware mapping for derived PIV produces a verification result and issuer identity that can be checked against the same issuer allowlist (do not rely on how the credential looks).
4. **Keep evidence of every verification attempt**: Configure logging so each login attempt records audit evidence including: date and time, user or principal mapping, presented credential identifier (or stable substitute), issuer identifier, the **electronic verification result** (success or failure), and the **access decision** (allow or deny).
5. **Document and manage the acceptance design**: Update system security documentation to explain how PIV acceptance works, what verification depends on, how derived PIV is handled, how issuers are authorised, and who is responsible operationally.
6. **Put changes under change control**: Manage issuer allowlist changes through formal change and configuration management, with regular reviews, so only approved issuers are added or removed.

###### WHO (role responsible)
- **IAM/Identity Architect**: designs the IdP authentication flow, verification indicators, and issuer attribute mapping.
- **Security Governance/Compliance Lead**: owns the issuer authorisation process and documentation.
- **IdP Administrator / IAM Engineer**: implements IdP configuration, conditional access rules, and logging.
- **Security Information and Event Management (SIEM) / Monitoring Engineer**: ensures logs are sent to the monitoring system, kept for the required period, and can be searched for audit purposes.

###### Acceptance criteria
- Access is **never granted** unless the IdP receives a **successful electronic PIV verification** result for the presented credential.
- Authentication is **denied** when verification fails, is missing, or cannot be completed.
- Only credentials from **authorised federal issuers** (as per the allowlist) are accepted; issuer mismatches result in denial.
- Derived PIV credentials are accepted only when they produce a verifiable electronic verification result and an issuer identity that matches the allowlist.
- For every authentication attempt, audit logs show the verification result and the allow or deny decision, including the credential identifier or substitute and the issuer identifier.
- System documentation (policy/security plan/procedures) and operational ownership are updated to reflect the implemented acceptance mechanism and issuer authorisation process.

###### Actions Required for Compliance

- [ ] Set up the identity provider (IdP) sign-in process so that it only issues an access token or session after a successful electronic Personal Identity Verification (PIV) check is confirmed.
- [ ] Set up a “deny access” rule in conditional access for situations where personal identity verification (PIV) is missing, fails, or cannot be completed.
- [ ] Set up and manage an approved list of federal issuers, and extract each wire issuer’s identity so it can be used in the authentication decision.
- [ ] Update the derived personal identity verification (PIV) credential mapping so the verification result and the issuer identity are available for allowlist checks.
- [ ] Enable audit logging for every sign-in attempt, including the credential identifier (or surrogate), the issuer identifier, the verification result, and the allow/deny decision; then send the records to security information and event management (SIEM).
- [ ] Document the planned approach for accepting personal identity verification (PIV) credentials, how derived PIV information is handled, how the issuer is approved, and the day-to-day operational responsibilities in the system security documentation.


---

#### IA-2.13 — Out-of-band Authentication (Enhancement)

This requirement is about preventing unauthorised access by requiring a fresh, one-time code from you when a login or action looks risky. If someone tries to sign in from a new device, if suspicious behaviour is detected, if there are signs of an increased threat, or if someone is attempting to access highly sensitive information or carry out powerful actions, the system must not rely on the usual login method alone.

Instead, it must ask you for a one-time passcode sent to an approved mobile number or generated in an approved authenticator app. It must then verify that code using a separate verification step before allowing the login or privileged action to continue. If the code is incorrect or cannot be verified, access must be blocked.

To meet this requirement, the organisation must clearly define and document when these checks apply, ensure the system is set up to support the approved code delivery and generation methods, keep evidence of the configuration, record events in audit logs, and assign clear responsibilities for operating the process, setting up users’ approved contact methods, overseeing compliance, and administering and building the system.

##### Risk-triggered step-up OTP via approved mobile/app

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement out-of-band authentication (step-up) so that, under the organisation-defined **conditions**, users must complete **independent out-of-band verification** using a **one-time passcode (OTP)** sent to an **approved mobile number** or generated via an **authenticator app**. The system must **block the login or the requested privileged action until OTP verification succeeds**.

###### WHY (control requirement)
IA-2(13) enhancement requires implementing the specified **out-of-band authentication mechanisms** under the organisation-defined **conditions**. Out-of-band authentication uses a **separate communication route** to independently verify the authentication and/or the requested action, reducing the risk of man-in-the-middle attacks.

###### HOW (specific steps/approach)
1. **Define and implement the trigger conditions** in the central identity/access policy layer (for example, enterprise identity provider (IdP) conditional access / risk-based step-up):
   - Require step-up OTP **when suspicious activity is detected**
   - Require step-up OTP for **new device logins**
   - Require step-up OTP **after elevated threat indicators**
   - Require step-up OTP for **requests involving Secret data or privileged actions**
2. **Use OTP as the out-of-band method**, using only organisation-approved delivery options:
   - OTP via an **approved mobile number**
   - OTP via an **authenticator app**
   Ensure OTP delivery is limited to **approved** factors only (no arbitrary phone numbers).
3. **Make the out-of-band check independent and blocking**:
   - Configure the IdP/application so the session is not created (or the privileged action is not carried out) until OTP verification succeeds.
   - Use short OTP validity periods and limited retry attempts; deny/stop the process on failure or timeout.
4. **Maintain an auditable, system-generated list of approved out-of-band options**:
   - Use IdP factor registration policies to keep the allowed OTP methods and approved mobile numbers.
   - Ensure the application uses the IdP’s factor/fallback configuration rather than local, ad-hoc OTP logic.
5. **Create audit evidence for each triggered event**:
   - Record when out-of-band authentication was **required**, the **reason it was triggered** (for example, new device / suspicious activity / privileged action), and whether OTP verification **succeeded or failed**.
   - Send logs to the enterprise security information and event management (SIEM) system with correlation identifiers (user, device, session, action).
6. **Link “privileged actions” to application authorisation events**:
   - Identify the specific admin/privileged endpoints or application programming interface (API) scopes (for example, secret read/export, identity and access management (IAM) changes, data export, role changes) and ensure step-up OTP is triggered for those actions.

###### WHO (role responsible)
- **Identity and Access Management (IAM) Lead**: implement IdP step-up OTP policies and the approved factor configuration.
- **Application Owner / Security Engineer**: map privileged actions to IdP triggers (scopes/endpoints) and confirm the correct blocking behaviour.
- **Security Operations Centre (SOC) / Security Operations**: confirm the sources of trigger signals (suspicious activity, elevated threat indicators) and review audit outputs.

###### Acceptance criteria
- For each defined condition (suspicious activity, new device login, elevated threat indicators, Secret data or privileged actions), the system requires OTP via an approved mobile number or authenticator app.
- OTP verification uses an out-of-band route that is independent of the in-band login/session creation.
- Login/session creation or privileged action execution is blocked until OTP verification succeeds; failures/timeouts result in denial.
- Audit logs show: the trigger condition, whether OTP was required, OTP success/failure, and the user/device/session/action identifiers.
- Approved out-of-band options (approved mobile numbers and authenticator app) are maintained through system configuration (IdP factor policies) and can be clearly audited.

###### Actions Required for Compliance

- [ ] Set identity provider (IdP) “step-up” authentication rules so that a one-time password (OTP) is required when there is suspicious activity, a login from a new device, elevated threat alerts, or when performing sensitive actions involving secrets or privileged access.
- [ ] Set up one-time password (OTP) delivery so it uses only the approved methods: OTP sent to an approved mobile number and/or an authenticator app.
- [ ] Block access so that sessions and privileged actions cannot continue until one-time password (OTP) verification is successful (deny if verification fails or times out).
- [ ] Create and keep an auditable, approved list of out-of-band authentication factors, using identity provider (IdP) factor registration policies (no one-off or ad-hoc phone entries).
- [ ] Set up and send audit records to the security information and event management (SIEM) system. These records must include the reason an one-time password (OTP) was required and whether the OTP check succeeded or failed, using matching reference identifiers for correlation.
- [ ] Link the map application’s privileged endpoints and application programming interface (API) scopes to the identity provider (IdP) “step-up” trigger, so that any access to secret data or privileged actions requires out-of-band verification.


---

### IA-3 — Device Identification and Authentication (Control)

This requirement is about making sure every device that tries to join your organisation’s network proves it is who it claims to be before it is allowed in. Without this, an unauthorised or fake device could connect, monitor activity, steal data, or disrupt services, because the network would not be able to reliably tell trusted devices from impostors.

To meet this expectation, the organisation must clearly define:
- which types of network devices are covered (for example, end-user devices, servers, and any relevant internet of things (IoT) devices), either by specific device or by device type; and
- which networks are covered (local and/or remote).

The organisation must also create and keep up to date:
- an approved policy,
- documented procedures, and
- system plans

showing how devices are uniquely identified and authenticated (verified). It must maintain a current list of the specific devices that must be authenticated, and configure the network so connections are blocked until authentication succeeds.

The organisation must choose how strong the check needs to be based on how important the systems are and the business needs. Where applying this to everything is not practical, the organisation may limit the scope to specific device types or to a defined number of devices.

##### Enforce device identity authentication before network access (802.1X)

- Category: Software
- Priority: Critical

###### WHAT
Set up unique identification and authentication for every in-scope device (by device and/or device type) before it is allowed to connect to any network.

###### WHY (control requirement)
This requirement (IA-3) says devices must be **uniquely identified and authenticated before they connect to a network** ({{ insert: param, ia-03_odp.01 }} before {{ insert: param, ia-03_odp.02 }} connection). It also expects the organisation to define device types/devices and use organisation-approved authentication methods (for example, IEEE 802.1X with EAP-TLS, using RADIUS), and to choose the right authentication strength based on the security category of the systems involved.

###### HOW (specific steps/approach)
1. **Define scope**: Create an authoritative list (inventory) of all in-scope device types/devices (for example, endpoints, servers, managed Internet of Things (IoT)) and the in-scope networks (local and/or remote) covered by this control.
2. **Issue unique device credentials**: Give each in-scope device its own unique cryptographic identity (X.509 certificate). Use an organisation-managed certificate authority (CA) and registration process, with approval checkpoints for any new device types.
3. **Require authentication before connection**: Configure the network access equipment (wired switches and Wi‑Fi controllers) so that **IEEE 802.1X** authentication is required using **EAP-TLS**, with **RADIUS** as the authentication service. Block network access by default until authentication succeeds.
4. **Link identity to what the device is allowed to do**: Configure RADIUS rules so that authenticated device identities (for example, certificate subject/subject alternative name (SAN), or a derived device identity) determine the authorisation outcome (for example, Virtual Local Area Network (VLAN), Virtual Routing and Forwarding (VRF), Access Control List (ACL), or role). This ensures authenticated devices only get the network access they are permitted.
5. **Set the right authentication strength**: Choose certificate and key settings, and the certificate validation approach (for example, certificate revocation checks where feasible) that match the security category of the covered networks/devices. Record the reasons for your choices.
6. **Keep audit evidence**: Store connection and authentication records from RADIUS and the network access controllers. Produce device connection reports showing successful and failed authentication events for in-scope devices.
7. **Handle exceptions explicitly**: If a legacy or shared “known information” method (for example, Media Access Control (MAC)-based) is unavoidable, use it only as an explicitly approved exception. Add compensating controls and fix it within a defined time period.

###### WHO
- **Network Engineering Lead**: Implements IEEE 802.1X/RADIUS enforcement and authorisation mapping.
- **Identity and Public Key Infrastructure (PKI) Owner**: Runs certificate issuance, renewal, revocation, and the registration workflow.
- **Information Security (Compliance) Lead**: Approves the scope, authentication strength, and exception handling; checks that audit evidence is available.
- **Asset Management Owner**: Maintains the authoritative in-scope device inventory and the mapping between devices and identities.

###### Acceptance criteria
- All in-scope devices are set to authenticate using IEEE 802.1X with EAP-TLS, and are **blocked from network access until authentication succeeds**.
- Each in-scope device has a **unique** identity credential and is linked to an authorised network access policy.
- RADIUS and network access logs show authentication results (success/failure) for in-scope devices on the in-scope networks.
- There is documented justification for the scope and authentication strength. Any exceptions are formally approved, time-limited, and supported by evidence.

###### Actions Required for Compliance

- [ ] Define and publish which device types and individual devices are in scope, and which networks are in scope, so that IA-3 controls can be enforced.
- [ ] Provide a unique X.509 certificate for each in-scope device using an approved certificate authority (CA) and registration process.
- [ ] Set up Remote Authentication Dial-In User Service (RADIUS) to check device certificates for Extensible Authentication Protocol – Transport Layer Security (EAP-TLS), and link each device identity to the approved rules for network access.
- [ ] Turn on IEEE 802.1X (Extensible Authentication Protocol – Transport Layer Security (EAP-TLS)) for wired network ports and Wi‑Fi network names (service set identifiers (SSIDs)), using a deny-by-default approach so unauthenticated devices are blocked.
- [ ] Disable any fallback “shared known information” authentication (for example, a media access control (MAC) address), or allow it only under strict exception control. Document the compensating controls that will be used instead.
- [ ] Set up log storage and reporting from the Remote Authentication Dial-In User Service (RADIUS) and network access controllers to provide evidence that users were authenticated before they are allowed to connect.
- [ ] Document and get approval for authentication strength settings (certificate profiles, validation, and certificate revocation checks) for each security category.


---

#### IA-3.1 — Cryptographic Bidirectional Authentication (Enhancement)

This requirement is about ensuring that, before any connection between systems that handles sensitive information is allowed, both sides prove their identities to each other using strong cryptographic checks. This matters because, if gateways and services that handle Confidential or Secret information can connect without verifying each other, an attacker could pretend to be a trusted service, intercept or change data, or gain unauthorised access through a fake connection.

To meet this expectation, the organisation must clearly state which federated identity gateways, application programming interface (API) gateways, and service-to-service peers that handle Confidential or Secret data are in scope. It must also confirm that the rule applies to network and remote connections (not local ones).

The organisation must document its approach in its security planning and design, keep written procedures, and maintain an up-to-date list of the specific devices or service types involved. It must assign named responsibilities to the appropriate staff, configure the systems so connections fail unless both sides complete cryptographic mutual authentication, and keep evidence (such as configuration records and connection logs) showing that authentication happens before any protected data is exchanged.

##### Enforce mutual TLS for network/remote Confidential-traffic

- Category: Software
- Priority: Critical

###### WHAT
Set up cryptography-based mutual authentication (both sides prove they are who they say they are) so that, for organisation-defined devices/services that handle **Confidential or Secret** data, **no network or remote connection** is made unless **both endpoints authenticate using cryptography**.

###### WHY (control requirement)
IA-3(1) requires that {{ ia-03.01_odp.01 }} are authenticated **before** establishing {{ ia-03.01_odp.02 }} connections using **cryptography-based mutual authentication**. This stops unauthorised parties from pretending to be trusted gateways/services and lowers the risk of interception or unauthorised changes.

###### HOW (specific approach)
###### 1) Define scope and expected peers
- Keep an up-to-date inventory that links each in-scope device/service type (for example, federated identity gateways, API gateways, and service-to-service peers handling Confidential/Secret data) to the **other peer identities** it is allowed to connect to.
- Clearly state that this applies to **network and remote** connections (not local connections).

###### 2) Require mutual cryptographic authentication at the connection point
- Use **mutual Transport Layer Security (mutual TLS (mTLS))** (or an equivalent cryptography-based mutual authentication method) at the **API gateway endpoint** and/or the **service-to-service communication layer**.
- Configure the receiving side to:
  - Require a **client certificate** (or an equivalent client cryptographic credential) for incoming connections.
  - Check the **server certificate** presented by the connecting peer.
  - Tie the connection to the expected identity by matching certificate details (for example, SAN/URI, SPIFFE ID, or an organisation-defined identity claim) to the allowlisted peer identity mapping.
- Configure the calling side to:
  - Send the correct client certificate/credential for the intended peer.
  - Stop the connection if the peer cannot be authenticated.

###### 3) Make “authentication before connection” a technical requirement
- Configure gateway/service rules so that the TLS handshake (or equivalent mutual authentication exchange) must complete successfully before the application accepts the session.
- Block or terminate connections that:
  - do not include a client certificate,
  - use an untrusted certificate chain,
  - present a certificate identity that does not match the allowlisted peer for that destination.

###### 4) Manage certificates over time and keep proof
- Use automated certificate issuing and renewal where possible (for example, workload identity integration or a managed certificate authority with short-lived certificates).
- Keep audit evidence by retaining:
  - gateway/service TLS handshake logs (success/failure, peer identity, certificate details),
  - snapshots of mTLS enforcement policy configuration,
  - connection/session logs showing that authenticated sessions are created only after mutual authentication.

###### WHO (roles responsible)
- **Security Architect / Identity and Access Management (IAM) & Public Key Infrastructure (PKI) Lead:** defines scope, identity mapping rules, and certificate approach.
- **Platform/Infrastructure Engineer:** implements mTLS enforcement at gateways/service mesh/workload layer.
- **Application Owner / DevOps Lead:** ensures application/service clients present the correct credentials and that failures are handled safely.
- **Security Operations / Compliance:** checks evidence, monitors handshake failures, and supports audit readiness.

###### Acceptance criteria
- For all in-scope {{ ia-03.01_odp.01 }} handling Confidential/Secret data, any **network/remote** connection attempt is rejected unless **mutual cryptographic authentication** succeeds.
- Logs show that sessions are only established after successful mutual authentication (for example, TLS handshake success with a validated peer identity).
- Identity-to-peer allowlisting ensures that a valid certificate from an unauthorised peer is not accepted.
- An evidence package is available for audit: mTLS policy configuration snapshots and representative handshake/connection logs covering both successful and failed cases.

###### Actions Required for Compliance

- [ ] Create and keep up to date an inventory of the in-scope federated identity gateways, API gateways, and service-to-service connections that handle Confidential or Secret information.
- [ ] For each in-scope connection path, define an approved (allowlisted) link between the identity on the certificate and the destination peer, using the certificate identity, subject alternative name (SAN), SPIFFE ID, and/or URI.
- [ ] Set up API gateways and/or service-to-service connections so that both sides must present digital client certificates, and so that server certificates are checked for network or remote connections (mutual Transport Layer Security (mTLS)).
- [ ] Set up “policy-as-code” rules to block any connection when the other party’s identity does not match the approved (allowlisted) identity mapping.
- [ ] Check that the connection fails at the point where Transport Layer Security (TLS) meets the application when mutual authentication is not successful—there must be no authenticated session unless the handshake completes successfully.
- [ ] Turn on and keep audit records of Transport Layer Security (TLS) connection handshake results and the other party’s identity, and store configuration evidence for mutual Transport Layer Security (mTLS) enforcement rules.
- [ ] Set up automated certificate issuing and renewal (including automatic replacement) and test the renewal process to ensure that mutual authentication is continuously enforced.


---

#### IA-3.3 — Dynamic Address Allocation (Enhancement)

This requirement is about making sure that when devices are given network addresses automatically, the information recorded for each device is consistent and can be checked later. Without this, the same device could be recorded differently each time it connects, making it harder to identify which device was using which address, investigate issues, or spot suspicious activity. It also increases the risk of mistakes when managing devices.

The organisation must configure its automatic address assignment service so that every device that connects dynamically gets the same standard set of recorded details, including the device name, a client identifier, the device’s network hardware address, and the device type or vendor class. It must also use an eight-hour lease duration for dynamic clients.

Every time an address is assigned to a device, the organisation must record and keep an auditable log showing the lease details and the eight-hour duration for that specific assignment.

##### Standardise DHCP lease metadata and enforce 8-hour dynamic leases

- Category: Software
- Priority: Critical

###### WHAT
Configure the organisation’s dynamic address allocation service (dynamic host configuration protocol (DHCP)) so that every automatically assigned internet address (internet protocol (IP) address) includes standard, device-identifying information (host name, client identifier, media access control (MAC) address link, and vendor type) and uses a fixed **8-hour** time limit for automatically assigned clients. Make sure every address assignment is saved in a way that can be checked later (audited), including the required details and the 8-hour time limit.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) information assurance (IA)-3(3) (enhancement) requires dynamic address allocation to be set up in a consistent way using agreed lease information and an agreed lease time limit. It also requires that lease information is kept so that each assignment can be traced and checked later.

###### HOW (specific steps/approach)
1. **List all DHCP scope(s) and servers** that provide addresses to automatically assigned clients, including any DHCP failover pairs and replication.
2. **Apply standard lease settings** on each relevant DHCP scope/server for automatically assigned clients so that the DHCP record consistently includes:
   - **Host name**
   - **Client identifier**
   - **MAC address link**
   - **Vendor type**
3. **Set the automatic lease time to exactly 8 hours** on each relevant scope, and confirm that failover/partner settings are aligned so the time limit is the same across the DHCP service.
4. **Turn on and keep records that can be audited**: configure DHCP server logging and lease database retention so that every address assignment event records the required fields and the 8-hour time limit (or an equivalent start/end time that results in an 8-hour duration).
5. **Centralise evidence collection** by sending DHCP lease assignment logs/events to the organisation’s central logging and security information and event management (SIEM) platform, ensuring the logs can be searched at least by **MAC address**, **host name**, and **client identifier**.
6. **Produce an audit-ready report** that, for any device (MAC address/host name/client identifier), shows the full lease assignment history including the required details and confirms the lease time is 8 hours.

###### WHO (role responsible)
- **Network Engineering / DHCP administrators**: set up DHCP scope/server configuration and logging.
- **Security Operations / SIEM administrators**: ensure logs are forwarded, kept for the required period, and can be searched and reported on.
- **Configuration Management / Change Management**: manage configuration baselines and approvals.

###### Acceptance criteria
- For all DHCP scopes serving automatically assigned clients, the DHCP configuration requires the lease metadata fields: **host name, client identifier, MAC address link, vendor type**.
- For all automatically assigned client leases, the lease time limit is **8 hours** (confirmed using log evidence showing start/end times or an explicit duration).
- For each address assignment, there is an **auditable record** kept for investigation that includes the required lease fields and the 8-hour time limit.
- Central logging includes DHCP lease assignment events that can be used to generate a device-level lease history report.

###### Actions Required for Compliance

- [ ] Identify and list all Dynamic Host Configuration Protocol (DHCP) scopes and all DHCP servers (including failover and replication partners) that assign IP addresses to devices that request them dynamically.
- [ ] Configure each relevant Dynamic Host Configuration Protocol (DHCP) scope to record, for dynamic leases, the device hostname, client identifier, Media Access Control (MAC) address binding, and vendor class.
- [ ] Set the dynamic client lease duration to exactly 8 hours on every relevant Dynamic Host Configuration Protocol (DHCP) scope, and check that the failover partner settings match.
- [ ] Set up Dynamic Host Configuration Protocol (DHCP) lease database and event logging so that every time an IP address is assigned, the system records the required lease details and the lease length of 8 hours (or the start and expiry times that together add up to 8 hours).
- [ ] Send Dynamic Host Configuration Protocol (DHCP) lease assignment logs and events to the central security information and event management (SIEM) and log management platform, including the device media access control (MAC) address, hostname, and client identifier.
- [ ] Create an audit-ready report or query that returns, for each device, the full history of lease assignments, including the required supporting information (metadata), and that verifies the lease duration is 8 hours.


---

#### IA-3.4 — Device Attestation (Enhancement)

This requirement is about ensuring a device is only trusted when it is in the exact condition that is expected, and that any updates do not break that trust. Without this, a device could be changed or updated in an unauthorised way and still be allowed to connect. That could let attackers get in by using a device that appears normal, and then access systems.

To meet this expectation, the organisation must:
- identify and verify devices using a cryptographic check of the device’s known configuration and current state; and
- manage every patch and software update through its approved configuration management process, supported by its central device records, using secure updates.

After any change that could affect the device’s state, the organisation must re-check the device’s attestation value so the device can still be correctly identified and verified. It must also keep clear records of the approved changes and the re-checks after each change, so auditors can see what happened and when.

##### Attestation-based device auth with CMDB-backed secure updates

- Category: Software
- Priority: Critical

###### WHAT
Implement device identification and authentication using **cryptographic device attestation** based on the device’s **known configuration/operating state**, and make sure that **patches/updates are carried out through the organisation’s approved configuration management process** so attestation continues to work for other devices. After each approved change, **re-check (revalidate) the attestation value**.

###### WHY (control requirement)
NIST IA-3(4) enhancement requires: **“Handle device identification and authentication based on attestation by {{ insert: param, ia-03.04_odp }}.”** The guidance further states that if attestation is used for identification/authentication, then **patches and updates must be handled through a configuration management process** that applies updates securely and **does not break identification/authentication**. It also expects that device attestation can be determined using a **cryptographic hash** of the device’s known state.

###### HOW (specific approach)
1. **Define the attestation basis (known-good state)**: choose the cryptographic method used for attestation (for example, TPM/secure boot measurements, a signed configuration manifest hash, or a device configuration bundle hash) and document the exact “known configuration/state” that will be used as the attestation input.
2. **Create CMDB-backed attestation baselines**: for each device type/environment (production, test, disaster recovery), store the expected attestation value(s) in the CMDB (or a configuration database tightly linked to it). Link these values to the device identity and to the approved change record.
3. **Verify attestation at the access decision point**: connect the attestation check to the organisation’s access control system (for example, ZTNA/conditional access) so that **device access is allowed only when the attestation check matches the CMDB baseline**.
4. **Apply secure updates through the approved CM process**: route all patching/updates through the DoD-approved configuration management (CM) process (CMDB-backed patching and secure updates). Make sure update files are integrity-checked (for example, signed packages) and are deployed only through the approved release pipeline.
5. **Revalidate attestation after each approved change**: after each approved patch/update, automatically trigger re-attestation for the affected device(s) and record the result against the change record. If revalidation fails, block access and require fixes and/or re-baselining through the change process.
6. **Keep audit-ready traceability**: ensure logs/evidence link together: (a) the CMDB baseline used for verification, (b) the change/patch job, (c) the post-change revalidation result, and (d) the access decision outcome.

###### WHO
- **Security Architect / Identity and Access Management (IAM) Architect**: defines the attestation basis, verification logic, and how enforcement is integrated.
- **Configuration Management Lead (IT/Infrastructure)**: owns CMDB-backed patching and the secure update workflow.
- **Platform/Operational Technology (OT)/Network Engineering (as applicable)**: implements enforcement points (for example, ZTNA/edge gateway) and ensures operational continuity.
- **Governance, Risk and Compliance (GRC)/Compliance**: checks that audit evidence is sufficient and approves attestation baseline governance.

###### Acceptance criteria
- Device access decisions are **based on successful cryptographic attestation** matching the **CMDB-backed known-good baseline**.
- All patches/updates that affect attestation inputs are performed **only through the approved CM process** and are integrity-verified.
- After each approved change, the system performs **attestation hash revalidation** and records pass/fail evidence linked to the change record.
- If revalidation fails, the device is **not treated as authenticated** for the attestation-dependent access path until remediation is completed.
- Audit evidence shows end-to-end traceability between the baseline, the change, the revalidation result, and the access outcome.

###### Actions Required for Compliance

- [ ] Define the cryptographic attestation basis and the exact inputs that represent the “known configuration/state”, which will be hashed and measured.
- [ ] Set up approval checklists (attestations) for each device type and environment, using the configuration database (CMDB) as the source of truth, and link them to approved change records.
- [ ] Implement an attestation verification service that checks live device attestation values against the configuration baseline stored in the configuration management database (CMDB).
- [ ] Add checks that verify device identity into the organisation’s access decision step (for example, zero trust network access (ZTNA) or conditional access), so access is granted only when the verification matches.
- [ ] Set up the approved configuration management (CM) process so that only patch and update files that have been checked for integrity are deployed, and so that configuration management database (CMDB) records are updated as part of the change process.
- [ ] Automate the re-checking of the attestation hash after changes, and record whether the link passed or failed against the matching change record.
- [ ] Set enforcement for revalidation failures so that access that depends on attestation is blocked, and require remediation or re-baselining through the change control process.


---

### IA-4 — Identifier Management (Control)

This requirement is about making sure every person, team, service, or device has the correct name or label in our systems, and that those labels are not accidentally given to the wrong thing. Without this, an unauthorised person could gain access, or a label from a previous user could be reused, allowing someone to inherit permissions or data they should not have.

To meet this expectation, the organisation must only assign an identifier—such as a username, group or role name, service name, device token, or device network address—after approval from the information system owner and the designated administrator. The identifier chosen must clearly refer to the intended person, team, role, service, or device, and it must be assigned to that intended entity.

Finally, once an identifier has been used, it must not be reused for any other entity for 12 months. The organisation must have clear procedures and keep records showing how identifiers are managed.

##### Authorised identifier lifecycle with 12-month non-reuse hold

- Category: Software
- Priority: Critical

###### WHAT
Set up an identifier “life cycle” process (and supporting automation) to control when system identifiers are created, assigned, and retired. This applies to identifiers such as usernames, group or role names, service identifiers, and device token/address identifiers. After an identifier has been used, it must not be reassigned to a different entity for **12 months**.

###### WHY (control requirement)
IA-4 requires the organisation to **manage system identifiers** by making sure identifiers are:
- authorised before they are issued,
- linked to the correct intended entity, and
- protected from reuse, including a defined **12-month** period where reuse is not allowed.

###### HOW (specific approach)
1. **Define identifier governance scope and approvers**: For each application or system, require approval from the **information system owner** and the **designated identity and access management (IAM) administrator** before any identifier is created or linked to an entity (a person, group, role, service, or device).  
2. **Implement an IAM approval checkpoint**: Configure the IAM/orchestration layer so that identifier creation or linking is blocked unless both approvals are in place. Treat identifiers as managed items with required details, including the intended entity mapping, system or environment, owner, and current life cycle status.  
3. **Ensure identifier-to-entity mapping is clear and unique**: Use validation rules so identifiers follow approved formats and cannot be created with unclear or conflicting ownership details. Make sure provisioning tools (application programming interfaces and consoles) only allow linking when the target entity record is uniquely identified.  
4. **Enforce 12-month non-reuse**: When an identifier is retired, mark it as **reserved/held** (a tombstone) and set a release date **12 months** after retirement. Provisioning and administration actions must reject any attempt to reuse the identifier while the hold is active, except through a controlled exception process that records the reason and the compensating controls.  
5. **Create audit evidence**: Produce tamper-resistant logs showing the person who requested the change, the approvers (system owner and IAM administrator), the identifier value, the intended entity, timestamps, and the hold status. Send this information to the security information and event management (SIEM) system and log archive for audit purposes.

###### WHO
- **IAM administrator (designated)**: sets up and runs the identifier life cycle workflow and manages exceptions.
- **Information system owner**: approves identifier creation or linking for their system.
- **IAM/identity governance and administration (IGA) engineering**: builds the workflow automation, validation, and non-reuse enforcement.
- **Security and compliance**: checks that the evidence is complete and performs periodic sampling.

###### Acceptance criteria
- No identifier (user, group, role, service, device token, or device address) can be created or linked without recorded approvals from both the **information system owner** and the **designated IAM administrator**.
- Each identifier is issued with metadata that links it clearly to one intended entity only.
- After retirement, the identifier cannot be reassigned to a different entity for **12 months** (confirmed by attempting reuse during the hold period and verifying it is rejected).
- Audit records exist for every life cycle event (request, approvals, provisioning result, retirement, and hold/release dates) and can be retrieved for audit review.

###### Actions Required for Compliance

- [ ] Define which identifier types and formats are approved for the application or system, including service and device token/address identifiers, and specify the required ownership information (metadata).
- [ ] Set up the identity and access management (IAM) and identity governance and administration (IGA) workflow to prevent new identifiers from being created and linked unless approvals are recorded from the information system owner and the designated IAM administrator.
- [ ] Set up provisioning checks to ensure every identifier clearly and uniquely points to one intended entity record.
- [ ] Add a 12-month “reserved” or “held” (tombstone) period when an identifier is retired, and reject any attempt to reuse that identifier during the hold period.
- [ ] Set up an auditable exception process for any attempt to reuse something during the hold period, including recorded reasons and compensating controls.
- [ ] Send unchangeable lifecycle audit records (requests, approvals, identifiers, entity-to-record mapping, timestamps, and whether each item is on hold or released) to security information and event management (SIEM) so they can be used as evidence.


---

#### IA-4.1 — Prohibit Account Identifiers as Public Identifiers (Enhancement)

This requirement is about ensuring that a person’s internal login name is never the same as the public information people use to contact or identify them, such as the part of their email address before the “@” or their instant messaging name. If internal names match public details, attackers can more easily guess valid login names and then target accounts more effectively.

To meet this expectation, the organisation must set clear written rules for staff and system administrators that explicitly forbid assigning the same internal and public identifiers to any individual account. The organisation must also explain how to check this rule during both new account creation and any account changes.

The system should prevent or fix any attempt to create or update an account where the internal identifier matches the public identifier. It should also keep records showing that these checks were carried out.

The organisation must document how the system enforces this rule and keep the relevant policy, procedure, configuration, design, and audit evidence.

##### IdP provisioning rule to block internal IDs matching public identifiers

- Category: Software
- Priority: High

###### WHAT
Set up an automated check in the organisation’s main identity system (identity provider (IdP)/directory) so that, for every user account, the **system account identifier** (the internal username/account ID) is **never the same** as any **public identifier** the user uses for communication or identification. At minimum, this means the **part of the email address before the “@”** (the email local-part). If the organisation uses internal instant messaging (IM) handles for communication/identification, those must also be included.

###### WHY (control requirement)
The requirement IA-4(1) enhancement says: **“Prohibit the use of system account identifiers that are the same as public identifiers for individual accounts.”** This guidance explains that it makes it harder for an attacker to guess a user’s identifier (for example, guessing the email local-part).

###### HOW (specific steps/approach)
1. **Define what you will compare in the IdP/directory and during account creation/change:**
   - Internal identifier: the directory/IdP field used as the login account identifier (for example, `userPrincipalName`, `username`, or internal `accountId`).
   - Public identifiers:
     - Email local-part (the part before `@`) from the IdP-managed email field.
     - IM handle(s) only if the organisation uses/maintains them in the same authoritative IdP/directory and uses them for communication/identification.
2. **Add a validation rule at provisioning time** (before creating or updating an account) that checks, using a case-insensitive comparison, whether:
   - `internalIdentifier` matches `emailLocalPart`
   - `internalIdentifier` matches `imHandle` (for each configured IM handle field, if present)
3. **Enforcement behaviour:**
   - If a prohibited match is found, **reject** the account creation/update request with an error that references the IA-4(1) rule; or **auto-correct** by generating a compliant internal identifier and require approval if your change governance requires it.
4. **Prevent “drift”:**
   - Run a scheduled reconciliation job that re-checks all accounts against the current public identifier fields and raises tickets/alerts for any records that are not compliant but were created outside the normal process.
5. **Create audit evidence:**
   - Make sure each provisioning event records the result of the check (match/no match) and the specific public identifier fields that were checked (for example, `emailLocalPart`, `imHandle`).
6. **Document the enforcement** in system security documentation (system security plan/design/configuration notes), including:
   - Where the rule is enforced (IdP provisioning hooks/workflow)
   - The exact fields compared and the matching logic (for example, case-insensitive equality)
   - How exceptions are handled (reject/auto-correct/approval)

###### WHO
- **Identity and Access Management (IAM) Engineer**: implement the IdP/directory rule, reconciliation job, and audit logging.
- **Application Owner / System Owner**: confirm which public identifier fields are the authoritative ones for the application’s user communications.
- **Security/Compliance Analyst**: confirm the audit evidence and review how exceptions are handled.

###### Acceptance criteria
- For every user account, the IdP provisioning process **rejects or corrects** any create/update where the internal account identifier equals the email local-part (and IM handle(s) where those are used and maintained in the IdP).
- Audit logs show that, for each provisioning attempt, the prohibited-match check was carried out and whether it passed or failed.
- The reconciliation process finds any existing or drifted non-compliant accounts and routes them for remediation.
- System security documentation accurately describes where the enforcement happens, which fields are compared, and how prohibited matches are handled.

###### Actions Required for Compliance

- [ ] Identify the internal account identifier field that is officially used for login in the identity provider (IdP) or directory.
- [ ] Identify the official public contact details used for communication within the same identity provider (IdP) or directory—specifically the email address local part and any instant messaging (IM) handle details.
- [ ] Set up “before create” and “before update” checks that compare the internal identifier with the email address local part (case-insensitive), and also compare it with the relevant instant messaging (IM) handle(s) where applicable.
- [ ] Set enforcement rules to block prohibited matches or automatically fix them, and log the result of the decision.
- [ ] Turn on and keep audit logs for provisioning attempts, including which public identifier fields were checked and whether they matched.
- [ ] Set up a scheduled reconciliation job to check for any account changes or accounts that do not meet requirements, where those accounts were created outside the normal workflow, and raise an alert if any are found.
- [ ] Update the system security plan, design, and configuration documentation to explain how enforcement works, which fields are checked against each other, and how exceptions are handled.


---

#### IA-4.4 — Identify User Status (Enhancement)

This requirement is about making sure every person who needs access is clearly and uniquely identified as one of three types: contractor, foreign national, or non-organisational user. This matters because if people are not correctly identified, the organisation may give the wrong level of access, apply the wrong rules, and misunderstand who is behind messages or requests—raising the risk of unauthorised activity and mistakes.

To meet this expectation, the organisation must:

- define and document only these three status categories
- assign a single unique identifier to each person
- record the correct status against that identifier so it is always one of the allowed values, and never left blank or given more than one status at the same time

The organisation must also:

- have clear written procedures for creating, updating, and correcting identifiers and account records
- keep a documented list of the characteristics used to decide a person’s status
- keep evidence showing how the status was decided
- assign named responsibilities to the appropriate staff to manage and oversee this process, including system administrators who implement it

##### Enforce single user-status attribute for contractor/foreign/non-org

- Category: Software
- Priority: Critical

###### WHAT
Set up one single, authoritative “user status” field for each individual identifier. The field must be set to **exactly one** of the allowed values: **contractor**, **foreign national**, or **non-organisational user**.

###### WHY (control requirement)
IA-4(4) requires that individual identifiers are managed by **uniquely identifying each individual as {{ insert: param, ia-04.04_odp }}**. The guidance explains that these status details (for example, contractor, foreign national, non-organisational user) provide extra context for communication and access decisions.

###### HOW (specific steps/approach)
1. **Define the approved status list** in the organisation’s identity and access management (IAM) configuration and documentation, using only these permitted values: `contractor`, `foreign national`, `non-organisational user` (no other values, no blank entries).
2. **Use the organisation’s main identity directory and identity provider (IdP) as the single source of truth** by adding one dedicated, single-value attribute (for example, `userStatus`) to the user record.
3. **Ensure each identifier has only one status** by:
   - making sure the identifier used by the application points to an unchangeable directory record (and is not reused), and
   - requiring the attribute to be single-value and mandatory for all applicable human users.
4. **Block invalid status during onboarding** using the identity provisioning and workflow process (for example, policy-as-code or an equivalent mechanism), so account creation or activation is rejected unless `userStatus` is one of the three allowed values.
5. **Keep proof of how the status was assigned** by recording a reference to the originating workflow, ticket, or attestation (for example, onboarding request ID, contract start record, immigration/attestation reference) in an audit log or provisioning records.
6. **Make the status available to the application for audit and decision context** by including the attribute in the application’s authenticated identity information (or by using a secure directory lookup) and recording it alongside security-relevant events (for example, authentication events, administrative actions, and access decisions where applicable).
7. **Update the identification and authentication rules and the system security plan** to confirm that status is managed through the authoritative directory attribute and must be present before account activation. Also name the responsibilities for IAM administrators and security oversight.

###### WHO (role responsible)
- **IAM/Identity Engineer**: implement the directory structure, provisioning rules, and how the status is passed to applications.
- **Security Governance/Compliance Lead**: approve the approved status list, proof/evidence requirements, and updates to policy and the system security plan.
- **Application Owner**: ensure the application uses and records the status attribute consistently.

###### Acceptance criteria
- Every individual identifier used by the application maps to exactly one directory identity and has `userStatus` set to **one and only one** of the three allowed values.
- Provisioning/workflow prevents account creation or activation when `userStatus` is missing or not one of the allowed values.
- Proof references showing how status was assigned are recorded and can be retrieved for audit.
- The application records security-relevant events using the resolved `userStatus` value (or a consistent, deterministic reference to it), and the system security plan/policy documents the control approach and responsibilities.

###### Actions Required for Compliance

- [ ] Define and publish the only allowed user-status values: contractor, foreign national, and non-organisational user.
- [ ] Add a required, single-value directory field (for example, `userStatus`) to the official identity records for the relevant human users.
- [ ] Set up provisioning and workflow checks to block account creation or activation when the user status is missing or not one of the approved values.
- [ ] Ensure the application identifier mapping uses an unchangeable directory record, so each identifier uniquely links to one person.
- [ ] When you set `userStatus`, record an evidence reference (for example, onboarding ID, ticket number, or attestation ID) at the same time, and keep it for audit purposes.
- [ ] Update the application to use the `userStatus` claim/attribute and include it in logs that are used for security monitoring.
- [ ] Update the identification and authentication policy and the system security plan to record the status-management approach and the named responsibilities.


---

#### IA-4.5 — Dynamic Management (Enhancement)

This requirement is about creating and linking a person’s system identity only after you have properly checked who they are, and then removing it promptly when they no longer need access. Without this, a system could accidentally or incorrectly give access to the wrong person, or leave access in place after someone’s role ends. That increases the risk of unauthorised use, fraud, or data exposure.

To meet this expectation, the organisation must document a clear policy for “dynamic identifiers” that states:
- identifiers are issued and linked only when access is needed, and only after the organisation’s official identity provider has successfully verified the person’s credentials; and  
- identifiers are revoked when the account or access ends, no later than 24 hours after termination.

The organisation must also:
- document and follow procedures for handling identifier and account termination;  
- include this approach in its system security plan and design;  
- configure the system so it works this way;  
- keep evidence from system settings and audit records showing when verification and revocation happened; and  
- assign named individuals responsible for managing identifiers, checking compliance, and building and maintaining the required system behaviour.

##### JIT dynamic identifiers issued only after IdP validation

- Category: Software
- Priority: Critical

###### WHAT
Set up dynamic management of individual identifiers so that identifiers are **issued and linked at runtime only after the authoritative identity provider successfully verifies the user’s credentials**, and are **cancelled within 24 hours of termination**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Identity Assurance (IA)-4(5) (enhancement) requires: **“Manage individual identifiers dynamically in accordance with {{ insert: param, ia-04.05_odp }}.”** The organisation-defined parameter **ia-04.05_odp (dynamic identifier policy)** states: **“issue and bind identifiers at runtime only after credential validation by the authoritative identity provider; revoke on termination within 24 hours.”**

###### HOW (specific steps/approach)
1. **Define and publish the dynamic identifier policy** (including what counts as “termination” and the 24-hour cancellation service level agreement) and make sure it is built into the application’s security design.
2. **Apply identity-first linking during runtime** in the application: when an unknown user/entity tries to access, the application must request a **verified token/assertion** from the authoritative identity provider (for example, OpenID Connect (OIDC) / Security Assertion Markup Language (SAML)). The application must **create/link the internal identifier only after** the token/assertion is successfully checked (including signature, intended audience, issuer, expiry, and required information).
3. **Use consistent mapping from identity claims to identifiers** so that linking is repeatable and can be checked later (for example, map the identity provider’s subject/unique identifier plus the tenant/application scope to the internal identifier).
4. **Cancel identifiers when termination happens**: subscribe to lifecycle events from the authoritative identity provider (for example, user disabled, role removed, entitlement revoked) and/or regularly compare with the identity provider’s current state. When termination occurs, cancel internal identifiers and remove/disable access entitlements so that cancellation is completed **within 24 hours**.
5. **Make the identifier lifecycle auditable**: record events that show (a) credential verification happened (token validation success), (b) when the identifier was issued/linked, and (c) when it was cancelled and why (termination event source). Keep logs according to enterprise logging requirements and make them searchable for audit.
6. **Assign named operational ownership**: appoint an application owner and an identity and access management (IAM) / identity operations owner responsible for following the policy, handling lifecycle events, and producing evidence.

###### WHO (role responsible)
- **Application Owner / Engineering Lead**: implements runtime linking and cancellation logic, claims mapping, and audit logging.
- **IAM/Identity Operations Lead**: ensures the authoritative identity provider is set up to send lifecycle events and that termination signals are dependable.
- **Information Security / Compliance Lead**: checks that the policy, the 24-hour service level agreement, and evidence requirements are met.

###### Acceptance criteria
- For any first-time (previously unknown) user/entity, the application **does not create/link an internal identifier** unless the identity provider’s token/assertion validation succeeds.
- For terminated users/entities, internal identifier cancellation (and access removal) is completed **no later than 24 hours** after the termination signal is received/confirmed.
- Audit records exist showing: **token/assertion validation success**, **identifier issuance/linking time**, and **cancellation time** including the termination reason/source.
- Evidence can be produced showing compliance with the organisation-defined policy **ia-04.05_odp** for both identifier issuance and cancellation.

###### Actions Required for Compliance

- [ ] Document the dynamic identifier policy, which allows identifiers to be issued and linked only after the authoritative identity provider (IdP) has validated the credentials, and which requires revocation within 24 hours after termination.
- [ ] Set the authoritative identity provider (IdP) as the only system that verifies the relevant identities, and turn on lifecycle and termination events so that disabling users and removing entitlements are recorded.
- [ ] Implement just-in-time (JIT) runtime identifier issuance so the application creates and links its internal identifiers only after it has successfully validated the OpenID Connect (OIDC) or Security Assertion Markup Language (SAML) token or assertion.
- [ ] Define and implement fixed rules that map claims to identifiers in a consistent way, so the results can be reliably linked and checked during audits.
- [ ] Set up account-access revocation to happen when termination is detected, using identity provider (IdP) event notifications and/or regular checks to confirm access is removed, ensuring revocation is completed within 24 hours.
- [ ] Record audit logs for identifier lifecycle events, including successful validation, the time the identifier was issued and linked, the time it was revoked, and the reason for revocation. Then check that logs are kept for the required period and that they can be searched to provide audit evidence.
- [ ] Assign named owners for managing each identifier’s full life cycle and for generating evidence, and run an end-to-end test that proves the system issues identifiers correctly and that revocation happens within 24 hours.


---

#### IA-4.6 — Cross-organization Management (Enhancement)

This requirement is about making sure your organisation works closely with key external partners. The goal is that, when you operate across organisations, people, teams, roles, and devices can be correctly identified. Without this coordination, the wrong person or device could be identified, access could be granted incorrectly, or information could be shared under the wrong identity. This could lead to data exposure, service disruption, or failures against compliance requirements.

To meet this expectation, your organisation must work with the Department of Defense Joint Enterprise Service Desk (DoD JESD), the Defense Information Systems Agency (DISA), and the Department of Defense Identity Management (DoD IDM) federation partners. Together, you must manage the identifiers used for cross-organisation activities that involve handling information.

You must also reflect this coordination in your identification and authentication policy, document clear procedures for managing identifiers and accounts, record it in your system security plan, and keep other relevant evidence showing that coordination is in place.

Finally, you must clearly name who is responsible for managing identifiers and who oversees information security. You must also ensure that the practical arrangements and system set-up support coordinated identifier management.

##### Coordinate external identifier management via federation and documented mappings

- Category: Software
- Priority: Critical

###### WHAT must be done
Work with the specified external organisations (the Department of Defense Joint Enterprise Service Desk (DoD JESD), the Defense Information Systems Agency (DISA), and Department of Defense Identity Management (DoD IDM) federation partners) to manage identifiers across organisations when information is processed, stored, or sent between organisational boundaries.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Information Assurance (IA)-4(6) enhancement requires the organisation to **coordinate with the external organisations listed in param ia-04.06_odp** for cross-organisation identifier management. This helps ensure people, groups, roles, and devices are identified correctly during cross-organisation activities.

###### HOW (specific steps/approach)
1. **Define identifier scope and mapping rules** for cross-organisation activities, at minimum covering: individuals, groups, roles, and devices. Also state which identifier attributes/claims are the trusted source (authoritative) from each external partner.
2. **Put coordination into day-to-day operation** by configuring the application’s identity integration to use the organisation’s central identity service/federation setup with the DoD IDM federation partners. Include partner-specific claim/attribute mapping into local access permissions (for example, roles/entitlements) and device identity handling where relevant.
3. **Document the coordination** in the organisation’s identification and authentication policy (or equivalent). This must explicitly name JESD, DISA, and DoD IDM federation partners, including:
   - the purpose (cross-organisation identifier management),
   - the scope (users/groups/roles/devices),
   - the coordination method (federation/identifier mapping and lifecycle triggers), and
   - responsibilities for keeping mappings up to date and coordinating with partners.
4. **Create and maintain procedures** for managing the identifier/account life cycle. These procedures must explain how changes are handled in coordination with external partners (for example, joiner/mover/leaver and how deprovisioning updates are shared). Also describe how the application uses these updates and how any mismatches are resolved.
5. **Keep evidence of coordination** in the system security plan for each relevant system/application. Include references to:
   - federation configuration baselines,
   - partner metadata/configuration snapshots,
   - change tickets/approvals for mapping updates, and
   - any formal coordination records (for example, agreements or named operational contacts) showing ongoing coordination.
6. **Assign accountable roles**: appoint an identifier management owner (for example, Identity and Access Management (IAM)/Identity Engineering) and an information security oversight role (for example, Chief Information Security Officer (CISO)/Information Security Manager or a delegated security governance role) to ensure coordination is maintained and reviewed.

###### WHO (role responsible)
- **Identity and Access Management (IAM) Engineering Lead**: owns federation configuration, identifier mapping rules, and the implementation of life cycle procedures.
- **Information Security Manager / CISO delegate**: approves the policy/procedures and ensures coordination evidence is recorded in the system security plan.
- **Application Owner**: ensures the application uses the central identity service correctly across environments (production/test/disaster recovery) and that changes follow release/change management.

###### Acceptance criteria
- The application (through its central identity/federation integration) is set up to coordinate identifier management with **JESD, DISA, and DoD IDM federation partners**, and it correctly maps external identifiers/claims to local roles/entitlements for cross-organisation activities.
- The identification and authentication policy clearly documents coordination with the specified external organisations and the identifier scope (users/groups/roles/devices).
- Procedures exist and are followed for identifier/account life cycle management. They must explain how partner-coordinated changes are processed and how exceptions are handled.
- The system security plan for the application references the coordination approach and includes audit-ready evidence (federation/mapping baselines and change records).
- Named roles exist for identifier management ownership and information security oversight, and they review mapping changes at least through the organisation’s standard change governance.

###### Actions Required for Compliance

- [ ] Define the cross-organisation identifier coverage (individuals, groups, roles, and devices) and the official information (attributes or claims) that each external partner is allowed to use.
- [ ] Set up the application to use the organisation’s central federation identity provider (IdP) with Department of Defense (DoD) identity provider (IdP) federation partners, and create partner-specific mappings that translate partner claims into the correct user roles and entitlements.
- [ ] Set up joiner, mover, and leaver processes and deactivation (deprovisioning) workflows so that when an identifier changes with external partners, the change is coordinated and automatically reflected in the organisation’s local access permission records.
- [ ] Update the identification and authentication policy to clearly name the JESD, Defence Information Systems Agency (DISA), and Department of Defense (DoD) Identity Management (IDM) federation partners, including their responsibilities and the scope covered.
- [ ] Create and maintain procedures for managing the full lifecycle of partner identifiers and accounts, including how partner-coordinated changes and exceptions are handled.
- [ ] Update the system security plan to refer to the federation and mapping baseline requirements, and keep audit-ready proof of any changes linked to the coordination arrangements.


---

#### IA-4.8 — Pairwise Pseudonymous Identifiers (Enhancement)

This requirement is about giving each person a different, hard-to-guess identifier for every separate service they use, so the identifier does not reveal who they are. Without this, the same person could be quietly recognised and followed across different services, enabling unwanted tracking and profiling that goes beyond what the organisation needs to operate.

To meet this expectation, the organisation must ensure its identity service creates a unique, non-transparent identifier for every individual for every service that relies on it. The identifier must contain no personal information and must not be realistically predictable. By default, these identifiers must not be used to link a person’s activity across services, unless there is a clearly justified operational need to match records, or all parties involved have given consent to link them.

The organisation must also document how identifiers are created, define and maintain procedures for handling identifiers and accounts, include this approach in its system plans and design documents, configure the system accordingly, keep records of configuration, assign named responsibilities, and retain audit evidence showing that identifiers are generated in line with these requirements.

##### Configure IdP for pairwise pseudonymous identifiers per relying party

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation’s identity provider (identity provider (IdP)) to issue **pairwise pseudonymous identifiers** for each person **for each relying party**, using **opaque, unguessable** subject identifiers. Ensure that, by default, these identifiers are **not linkable across relying parties**.

###### WHY (control requirement)
Control IA-4(8) enhancement requires the IdP to **issue pairwise pseudonymous identifiers** so that different identifiers are issued for each relying party. This helps discourage tracking and profiling of subscribers beyond what is operationally needed. Linking the same person across relying parties should only be possible when a relying party can show a **clear, demonstrable reason for operational need**, or where **all parties agree** to linking.

###### HOW (specific steps/approach)
1. **Choose the right federation method** for each relying party (Security Assertion Markup Language (SAML) NameID and/or OpenID Connect (OpenID Connect (OIDC)) subject handling) and enable the IdP’s **pairwise subject** feature for that relying party/client.
2. **Make sure the identifier is opaque and unguessable** by configuring the IdP so the subject/pairwise identifier is **not based on attributes** such as email, user principal name (UPN), employee/contractor ID, or other stable personal information. Confirm this by checking the issued tokens/claims and verifying the subject value cannot be predicted from known attributes.
3. **Prevent default linking across relying parties** by ensuring the IdP does not use a single, shared subject mapping for the same user across different relying parties/clients.
4. **Allow linking only through controlled exceptions**: create an auditable “approved correlation” process (for example, an approved relying-party pair list with reasons and agreement status). Only for approved cases, enable the required linking behaviour (for example, a specific mapping mode or exception setting). Ensure any exception is time-limited and can be reviewed.
5. **Document how identifiers are created and used** in system security plan/design documentation, including: how pairwise mode is enabled, how exceptions are requested/approved/revoked, and how joiner/mover/leaver changes affect whether identifiers stay the same.
6. **Keep configuration and audit evidence**: store IdP configuration exports (or infrastructure as code (IaC) state), keep change records, and retain periodic evidence that pairwise identifiers are being issued as configured.

###### WHO
- **Identity and Access Management (IAM) Engineer**: configure the IdP for pairwise identifiers and controlled correlation exceptions.
- **Information Security Officer / IAM Governance Lead**: approve correlation exceptions and ensure documentation and evidence requirements are met.
- **System Owner (application/service owner)**: ensure relying-party onboarding includes the correct pairwise configuration and exception status.

###### Acceptance criteria
- For at least two relying parties (A and B) involving the same individual, the IdP issues **different** opaque subject identifiers by default.
- The subject identifier includes **no identifying attributes** (for example, not email/UPN/employee ID) and is **not realistically guessable** from known user information.
- Linking across relying parties is **disabled by default** and only enabled for relying-party pairs listed in the **approved correlation** record, with documented justification/consent.
- Evidence is available showing: IdP configuration for pairwise mode, exception configuration, and audit-ready records (configuration exports/IaC, change tickets, and token inspection results).

###### Actions Required for Compliance

- [ ] Enable pairwise subject identifiers in the identity provider (IdP) for each Security Assertion Markup Language (SAML) service provider (SP) and OpenID Connect (OIDC) client, using the IdP’s pairwise mode.
- [ ] Remove or disable any global subject mapping so that, by default, the same user is given different identifiers across relying parties.
- [ ] Check the token and claim outputs to confirm that the subject is not readable or guessable, and that it is not created from an email address, user principal name (UPN), or employee identifier.
- [ ] Create and keep an auditable, approved correlation matrix showing: relying party pair, the reason for the correlation, consent status, the person responsible for approval, and the approval expiry date.
- [ ] Set up an exception process so that correlation behaviour is only turned on for approved relying-party pairs, and only for a limited time.
- [ ] Update the system security plan and system design documents to explain how pairwise identifiers are created and how exceptions are handled.
- [ ] Archive identity provider (IdP) configuration evidence (exports and infrastructure as code (IaC) state) and keep token inspection results to support audit readiness.


---

#### IA-4.9 — Attribute Maintenance and Protection (Enhancement)

This requirement is about keeping the identifying details for every person, device, and service that your systems recognise in one secure place, and making sure only the right people can view or change them. If these details are spread out or not well protected, attackers or careless insiders could alter records, pretend to be users or equipment, or use old information to get past checks—resulting in unauthorised access and disruption to operations.

To meet this expectation, the organisation must store these details in a single central directory service with controlled access, such as an authorised Active Directory (AD) or Lightweight Directory Access Protocol (LDAP) system. The information must be encrypted when stored on disk, and access must be limited based on job role rather than granted through one-off permissions.

The organisation must keep these records up to date over time for all relevant types of entities. It must also document how the directory is used and protected, including the procedures for creating, updating, and removing identifier and account-related details, as well as the system design and security settings.

In addition, the organisation must keep audit records showing who accessed the stored details and what changes were made, along with any supporting documentation needed to demonstrate that protection is maintained on an ongoing basis.

##### Central authoritative directory for identity/device/service attributes

- Category: Software
- Priority: Critical

###### WHAT
Keep the key details (attributes) for every uniquely identified person, device, and service in one secure, central directory (the single authoritative record). Keep those details up to date throughout their lifecycle, protect the directory data with encryption when stored, and limit access using role-based access control.

###### WHY (control requirement)
The IA-4(9) enhancement requires that the attributes for each uniquely identified person, device, or service are maintained in {{ insert: param, ia-04.09_odp }} (that is, a central secure store). The guidance also requires that these attributes are kept up to date on an ongoing basis in a central secure store for the entities covered by IA-2, IA-3, IA-8, and IA-9.

###### HOW (specific steps/approach)
1. **Select and configure the authoritative directory**: Use the organisation-approved “protected central storage” (for example, Department of Defense (DoD)-approved Active Directory (AD)/Lightweight Directory Access Protocol (LDAP)) as the single source of truth for attribute data for people, devices, and service identities.
2. **Define entity coverage and structure**: Create or extend the directory structure (schema) and object types so that people, devices, and service identities are uniquely identified and their relevant attributes are stored in the directory—rather than being split across different application-specific stores.
3. **Enforce protection and access**: Turn on encryption when data is stored (including backups). Use role-based access control (RBAC) with directory-built-in groups/roles so only authorised administrators and approved integration services can read and write the attribute records.
4. **Implement ongoing maintenance (lifecycle)**: Set up automated or semi-automated processes to create, update, and remove directory attributes based on trusted sources (for example, Human Resources (HR) joiner/mover/leaver events, Information Technology Service Management (ITSM)/Configuration Management Database (CMDB) for devices, and service onboarding/offboarding pipelines for service identities). Add checks to correct any mismatches (drift).
5. **Audit attribute access and changes**: Enable directory auditing for both reads and writes of attribute records. Send audit events to the security information and event management (SIEM) system and keep the records as evidence.
6. **Document procedures and responsibilities**: Document how attribute records are created, updated, removed, and protected. Include the responsible roles (directory administrators, identity integration owners, application owners) and the evidence sources used to show ongoing protection.

###### WHO (role responsible)
- **Identity and Access Management (IAM) / Directory Service Owner**: owns directory configuration, the RBAC model, encryption-at-rest settings, and auditing.
- **Identity Integration Engineer**: implements lifecycle updates and reconciliation from HR/ITSM/CMDB/onboarding pipelines.
- **Application Owner / System Owner**: ensures the application uses the central directory for attribute lookups and does not keep separate, competing attribute stores.
- **Security Operations / SIEM Administrator**: ensures audit events are collected and retained.

###### Acceptance criteria
- For every uniquely identified person, device, and service identity used by the application, the authoritative attribute record exists in the central protected directory.
- Directory storage and backups are encrypted when stored.
- Only RBAC-authorised roles/integration services can read and write attribute records; direct ad-hoc access is restricted.
- Attribute lifecycle events (create/update/remove) are handled on an ongoing basis, including drift reconciliation.
- Directory audit logs show access and changes to attribute records, and are sent to SIEM with retention sufficient for audit evidence.
- Documented procedures exist for managing and protecting attribute lifecycles, and are followed in day-to-day operations.

###### Actions Required for Compliance

- [ ] Set up the organisation-approved protected central storage (Active Directory (AD) / Lightweight Directory Access Protocol (LDAP)) as the main, trusted source of identity information for people, devices, and service accounts.
- [ ] Create directory schema and object classes so each type of entity is represented uniquely, and store the required information in a central place.
- [ ] Turn on encryption for data stored in the directory and for backups, and confirm that encryption is working in both live production systems and disaster recovery systems.
- [ ] Set up role-based access control (RBAC) for directory attribute objects using the minimum necessary permissions (least privilege), and limit direct interactive access for people who can read or write those attributes.
- [ ] Automate the full lifecycle of user attributes—create, update, and remove—using the human resources (HR) system, the IT service management (ITSM) system, and the configuration management database (CMDB), and during service onboarding and offboarding. Also run scheduled checks to reconcile records and prevent data drift.
- [ ] Enable and send directory audit logs for reading and changing attributes to the security information and event management (SIEM) system, and keep the records for evidence retention.
- [ ] Publish and keep documented procedures for managing the full life cycle of attributes, including who is responsible and where audit evidence comes from.


---

### IA-5 — Authenticator Management (Control)

This requirement ensures that every method people use to prove who they are to access systems is issued safely, kept secure, and withdrawn promptly when it should no longer work. Without it, attackers could use well-known default login details, stolen or damaged credentials could still allow access, and people who have left or changed roles could keep access they no longer need. It also helps prevent sensitive credential information from being exposed or changed.

The organisation must verify the recipient’s identity before issuing any password, access badge, code device, certificate, or biometric enrolment. It must set the initial credential securely and ensure it is strong enough for its purpose. The organisation must use documented steps to issue, replace, revoke, and manage credentials that are lost, compromised, or damaged. It must also change any factory default credentials before first use.

Credentials must be refreshed on a set schedule: passwords every 90 days, certificates every 365 days, one-time code tokens every 180 days, biometric re-enrolment when the template changes or every 2 years, and ID badges every 1 year. The organisation must also refresh credentials immediately after suspected compromise, loss, theft, damage, an administrative reset, staff or device changes, or certificate or key revocation.

The organisation must protect credential data from unauthorised viewing or tampering, require people and devices to follow specific safeguarding rules, and update access for group or role accounts whenever membership changes.

##### Automate authenticator lifecycle with identity-verified issuance

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-controlled process for managing how the application’s users and service accounts receive, update, and stop using authentication methods. This includes identity-checked issuance, securely setting the initial authentication details (including removing any built-in factory defaults), using settings that match the required strength, refreshing/rotating on a planned schedule, and immediately revoking or refreshing when specific events occur.

###### WHY (control requirement)
IA-5 requires the organisation to **manage system authenticators** by:
- setting organisation-approved rules for what authenticator characteristics are allowed,
- defining **time periods by authenticator type** and the **events** that require a change or refresh, and
- carrying out lifecycle actions such as issuing and revoking authenticators for temporary access, and handling authenticators that are lost, compromised, or damaged.

This solution follows the organisation-approved parameters:
- **time period by authenticator type** (Passwords 90 days; Certificates/Public Key Infrastructure (PKI) 365 days; One-time password (OTP) tokens 180 days; Biometrics re-enrol on template change or every 2 years; ID badges 1 year)
- **events** (suspected compromise, loss, theft, damage, or administrative reset; user leaves or changes role/group; device is decommissioned/reassigned or identity changes; after key material or certificate revocation)

###### HOW (specific steps/approach)
###### 1) Centralise issuance and lifecycle in the enterprise identity service
- Use the enterprise identity provider (IdP) and identity and access management (IAM) system as the main source of truth for user authentication methods (passwords/multi-factor authentication (MFA) factors/certificates where applicable) and for provisioning and deprovisioning.
- Require **identity checks** (as defined in your assurance process) before any authenticator is issued to a person (including contractors/partners where applicable).

###### 2) Remove factory default credentials and enforce secure initial setup
- For any application components that come with factory default passwords/credentials, use a deployment check that **changes the defaults before first use** and stores the new secrets only in an approved secrets manager.
- For any temporary access authenticators, generate them through an automated process (not chosen by people), deliver them through approved channels, and force an immediate change/rotation at first use.

###### 3) Apply authenticator-type settings and restrictions
- Configure authenticator rules in the IdP and/or the application authentication layer to enforce organisation-approved characteristics (for example: password rules and lockout, certificate validity, OTP token validation window and rejection limits where supported).
- Ensure the authentication method strength matches the intended use and risk (for example: use phishing-resistant multi-factor authentication (MFA) for interactive access).

###### 4) Refresh/rotate on a planned schedule by authenticator type
- Set up automated rotation jobs/workflows based on the organisation-approved time periods:
  - Passwords: rotate/refresh every **90 days**
  - Certificates/Public Key Infrastructure (PKI): rotate/refresh every **365 days**
  - One-time password (OTP) tokens: rotate/refresh every **180 days**
  - Biometrics: re-enrol on template change or every **2 years** (where biometrics is supported)
  - ID badges: re-issue every **1 year** (where badge-based authentication is used)

###### 5) Immediately revoke or refresh when defined events occur
- Link IAM and device/human resources (HR) events so that the following events trigger immediate authenticator revocation/refresh:
  - suspected compromise, loss, theft, damage, or administrative reset
  - user leaving or changing role/group membership
  - device decommissioning/reassignment or identity change
  - key material or certificate revocation
- Handle service accounts in the same way using privileged access management (PAM) and secrets workflows (revocation when accounts are removed and rotation when keys/certificates are revoked).

###### 6) Protect authenticator details and administrative actions
- Store authenticator details (especially passwords/secrets and any certificate private material) only in approved encrypted storage (secrets manager/PAM vault), with access limited to authorised administrators.
- Record and retain authenticator lifecycle events (issuance, reset, rotation, revocation, and failed verification where available) so they can be audited.

###### WHO
- **Identity and Access Management (IAM) Engineer**: implement IdP rules, identity-check integration, and lifecycle workflows.
- **Application Security/Platform Engineer**: implement the deployment check to remove factory defaults and integrate secrets management.
- **Privileged Access/PAM Administrator**: manage issuance, rotation, and revocation of service account authenticators.
- **Security Operations (SOC) / Incident Response Lead**: ensure event-driven revocation is triggered and confirmed during suspected compromise.

###### Acceptance criteria (evidenceable)
1. For each authenticator type used by the application (passwords, certificates/Public Key Infrastructure (PKI), one-time password (OTP), biometrics where applicable, ID badges where applicable), the system enforces the organisation-approved **refresh/rotation time periods**.
2. For each organisation-approved **event** (compromise/loss/theft/damage/admin reset; joiner/mover/leaver; device decommission/reassignment/identity change; key/certificate revocation), the system performs **immediate** authenticator revocation and/or refresh, with audit records showing the trigger and result.
3. No factory default credentials remain in any production environment; deployment evidence shows defaults were changed before first use and secrets are stored in the approved secrets manager.
4. Authenticator details are not stored as plain text in application configuration repositories; secrets/certificate private material are stored encrypted, with restricted access and recorded activity.
5. Audit records exist for authenticator issuance, reset, rotation, and revocation actions, and can be linked to the initiating event (user/device/admin action).

###### Actions Required for Compliance

- [ ] Set up an identity provider and identity and access management (IdP/IAM) process for joiners, movers, and leavers that issues and removes access credentials based on verified identity and confirmed changes to roles or groups.
- [ ] Add a deployment check that detects and replaces any factory default login details before the application is first used, and store the new secrets only in an approved secrets manager.
- [ ] Set rules for each type of sign-in method (password, certificate/public key infrastructure (PKI), one-time passcode (OTP), and badge or biometric where used) to enforce the organisation’s required limits and strength.
- [ ] Set up automated rotation and refresh jobs in line with **ia-05_odp.01**, covering **90/365/180-day** timing, including the **biometrics re-enrolment schedule** and the **badge re-issue schedule**.
- [ ] Set up event alerts for **ia-05_odp.02** so that, when any of the following happen—**suspected compromise, loss, theft, damage, or an administrator reset; device decommissioning, reassignment, or identity change; or revocation of a key or certificate**—the system immediately **revokes and refreshes** the affected access credentials.
- [ ] Limit and record access to authenticator information (passwords and secrets, and private certificate material) by using privileged access management (PAM) and secrets management, with audit records.


---

#### IA-5.1 — Password-based Authentication (Enhancement)

This requirement is about stopping people from signing in using passwords that are easy to guess or already known, and making sure passwords are handled safely. Without it, attackers could try common passwords, reuse passwords taken from past data leaks, or capture passwords while they are being sent, and then gain unauthorised access to accounts.

To meet this expectation, the organisation must keep a regularly updated list of commonly used, expected, or known-compromised passwords. This list must be updated at least weekly, and immediately if there is any suspicion that organisational passwords may have been compromised. When anyone sets or changes a password, the system must block any password from this list. Passwords must be sent only over secure encrypted connections, and stored using an approved protected method that includes a random extra value, so the original password cannot be recovered.

During account recovery, users must choose a new password straight away.

Users may use long passphrases (including spaces and all printable characters). The system must provide automated guidance on password strength, and the organisation’s rules must be enforced: at least 14 characters, at least 3 of 4 character types, no parts of the username or service name, and no 3 or more repeated characters or sequential characters.

##### IdP-enforced strong passwords with breach blocklist and secure recovery

- Category: Software
- Priority: Critical

###### WHAT
Set up password-based authentication rules in the organisation’s central Identity Provider (IdP) so that when users create, change, or recover their passwords, the IdP enforces the organisation’s password rules. The IdP must also stop users from choosing passwords that are commonly used, expected, or known to be compromised (using a maintained list). Finally, the IdP must ensure passwords are sent and stored using approved cryptographic protections.

###### WHY (control requirement)
IA-5(1) enhancement requires that, for password-based authentication, the organisation:
- keeps and regularly updates a list of commonly used, expected, or compromised passwords (with a defined update frequency, and immediate updates when compromise is suspected),
- blocks passwords from that list when users create or change passwords,
- sends passwords using cryptographically protected transmission,
- stores passwords using cryptographically protected, salted one-way hashes (approved salted key derivation),
- supports account recovery by requiring users to choose a new password immediately,
- enforces the organisation’s defined password composition and complexity rules.

###### HOW (specific steps/approach)
1. **Centralise password processes in the IdP**: Configure all user sign-in and password reset/change processes for the application to use the IdP (federation/OpenID Connect (OIDC)/Security Assertion Markup Language (SAML)). This prevents any local or older password entry methods from bypassing IdP rules.
2. **Enforce the organisation-defined password composition/complexity rules in the IdP password policy**:
   - minimum **14 characters**
   - at least **3 of 4**: uppercase letters, lowercase letters, digits, symbols
   - **block passwords containing the username or service name**
   - **block 3 or more repeated or sequential characters**
   - **allow long passphrases** (including spaces and all printable characters), as supported by the IdP
3. **Maintain a “known bad” password blocklist in the IdP** (using built-in capability or an external feed):
   - refresh the list **weekly**
   - update the list **immediately** when compromise is suspected, using an incident-driven process (for example: security operations centre (SOC) alerts, credential exposure reports, or vendor breach notifications)
4. **Reject blocked passwords when users create or change them**: Configure the IdP to deny password set/reset/change requests when the chosen password matches an entry in the maintained list. Return an appropriate error message to the user and record the event in logs.
5. **Protect password transmission using cryptography**: Require HTTPS/Transport Layer Security (TLS) for all IdP endpoints and application sign-in pages. Disable HTTP. Enable HTTP Strict Transport Security (HSTS) where applicable. Ensure strong TLS settings for browser and application-based authentication redirects.
6. **Protect password storage using cryptography**: Check and provide evidence that the IdP stores passwords using an approved salted one-way cryptographic hash / salted key derivation function (KDF) (including salting and that the password cannot be recovered). Where supported, ensure a keyed/peppered option is enabled and documented.
7. **Strengthen account recovery**: Configure the password reset/recovery process so that after the user completes recovery verification, they must **set a new password immediately**. The user must not be able to reuse the old password, and the new password must follow the same blocklist and composition rules.

###### WHO
- **Identity and Access Management (IAM) Engineer**: implement IdP password policy, blocklist integration, and recovery flow configuration.
- **Security Operations (SOC) / Incident Response Lead**: define and trigger the “compromise suspected” event that causes immediate blocklist refresh.
- **Application Owner / Platform Engineer**: ensure the application uses the IdP for all password processes and does not provide any bypass routes.
- **Security Assurance / Compliance**: review evidence (configuration exports, logs, and vendor documentation) to support audit readiness.

###### Acceptance criteria
- Password creation/change requests are rejected when the chosen password matches the maintained compromised/expected/common password list.
- The maintained list is refreshed **at least weekly** and updated **immediately** when a defined “compromise suspected” trigger occurs.
- The IdP enforces the organisation-defined password rules: **minimum 14 characters**, **3-of-4** character types, **no username/service-name substrings**, and **no 3 or more repeated/sequential characters**; long passphrases are allowed.
- All password entry and reset/recovery interactions occur only over **cryptographically protected channels** (HTTPS/TLS only).
- Evidence confirms password storage uses an approved **salted one-way hash / salted KDF** and is non-recoverable.
- Account recovery requires the user to choose a **new password immediately**, and the new password is subject to the same blocklist and composition rules.

###### Actions Required for Compliance

- [ ] Set up the organisation’s identity provider (IdP) so it is the only place users enter their password when signing in, and when they reset or change their password for the application.
- [ ] Configure the identity provider (IdP) password rules to require: at least 14 characters, at least 3 out of 4 character types, block passwords that contain the username or service name, and reject passwords with 3 or more repeated or sequential characters.
- [ ] Enable long passphrase support in the identity provider (IdP) and confirm that spaces and printable characters are accepted.
- [ ] Add a regularly updated list of known compromised or commonly used passwords to the identity provider (IdP), and refresh it every week.
- [ ] Set up an incident-based trigger to update the blocklist immediately when an organisational security breach is suspected.
- [ ] Check and record that the identity provider (IdP) stores passwords using an approved salted one-way hashing method (or salted key derivation function (KDF)), which cannot be reversed, and that passwords are sent only over secure encrypted connections using Hypertext Transfer Protocol Secure (HTTPS) / Transport Layer Security (TLS).
- [ ] Set up account recovery so that, when users recover their accounts, they are required to set a new password immediately, and make sure the same blocklist and password rules are applied.


---

#### IA-5.2 — Public Key-based Authentication (Enhancement)

This expectation is about ensuring that when people or systems sign in using a public key, only the rightful owner can use the matching secret private key, and the sign-in is correctly linked to the right person or group account. Without this, an attacker could pretend to be someone else, or a sign-in could be connected to the wrong account, which could allow unauthorised access to sensitive work systems.

Where certificates are used, the organisation must also confirm that each certificate was issued by an approved source and is still valid. This includes checking whether it has been cancelled. The organisation must make these checks by tracing the certificate’s approval chain (trust path) back to an approved starting point.

To keep services working during network problems, the system must store a local copy of certificate cancellation information and use it to make the same validity decisions even when it cannot reach the usual online checks.

##### PKI auth with trust-path validation and cached revocation checks

- Category: Software
- Priority: Critical

###### WHAT
Set up public key infrastructure (PKI) based authentication so that only certificates and keys issued by approved PKI authorities can be used to sign in. During authentication, the system must confirm that the certificate chain is valid back to an approved trust anchor, check whether the certificate has been revoked, and store revocation information locally so sign-in can still work if the network cannot reach the revocation checking services.

###### WHY (control requirement)
IA-5(2) enhancement requires that public key authentication uses valid public key cryptography. This includes checking the certificate chain back to an approved trust anchor and verifying certificate status using certificate revocation list (CRL) and/or online certificate status protocol (OCSP). It also requires a local cache of revocation information so the system can still find and validate certificate paths when revocation information cannot be retrieved over the network.

###### HOW (specific steps/approach)
1. **Enforce certificate trust anchors**: Configure the authentication and validation component to build and verify a certification path back to the organisation-approved Common Policy Root trust anchor (or another approved trust anchor). Include certificate policy checks as part of the path validation.
2. **Enable revocation checking**: For every sign-in attempt, check certificate status using the approved methods (CRL and/or OCSP) configured for the service relying on the certificate.
3. **Implement local revocation cache**: Deploy a local cache of revocation information (CRLs and/or OCSP responses) for use when the network cannot reach the CRL/OCSP endpoints. Cache entries must include expiry and next update handling, so outdated revocation data is never used after it is no longer valid.
4. **Deterministic identity-to-account mapping**: Link the authenticated identity to the correct user or group account using certificate details (for example, subject/UPN, subject alternative name (SAN), or organisation-specific mapping rules). Ensure the mapping is consistent (deterministic) and reject certificates that do not match the expected identity details.
5. **Auditability**: Record sign-in results with enough information to support audits and incident investigation (for example, certificate serial number or thumbprint, which trust anchor was used, the revocation check method, and whether cached or live revocation data was used).

###### WHO
- **Application/Platform Security Engineer**: designs and implements certificate validation and revocation caching behaviour in the authentication and authorisation layer.
- **PKI/Identity Team**: provides approved trust anchors, certificate policy requirements, and identity mapping rules.
- **Operations/Site Reliability Engineering (SRE)**: runs the revocation cache service/configuration and monitors cache freshness and sign-in success/failure rates.

###### Acceptance criteria
- Sign-in using PKI succeeds only when the presented certificate chains to the approved trust anchor and passes certificate policy processing.
- For every sign-in attempt, certificate status is checked using the configured CRL/OCSP methods.
- If revocation checking services cannot be reached, sign-in continues using locally cached revocation data **only within the cached validity window**. If the cached data has expired, sign-in fails safely (no acceptance based on outdated revocation status).
- Mapping certificate attributes to directory user/group accounts is deterministic; any mismatch results in sign-in being denied.
- Logs provide audit evidence of trust-path validation and revocation checking, including whether cached or live revocation data was used.

###### Actions Required for Compliance

- [ ] Set up the authentication service to create and check certificate trust paths back to the approved “Common Policy Root” trust anchor, with certificate policy checking turned on.
- [ ] Enable certificate revocation list (CRL) and/or online certificate status protocol (OCSP) checks during certificate validation for all public key infrastructure (PKI)-based logins.
- [ ] Set up a local “revocation” cache that keeps certificate revocation lists (CRLs) and online certificate status protocol (OCSP) responses, and automatically removes or refreshes them based on their expiry or next update time, following a defined refresh schedule.
- [ ] Update the identity-mapping process so that certificate details (attributes/principals) are matched in a consistent way to the correct directory user or group, and reject certificates that do not match.
- [ ] Record audit logs for: how the trust anchor was chosen, the results of trust-path checks, the method used to check whether a certificate was revoked, and whether the revocation information came from cached data or live data.
- [ ] Test failover by blocking outgoing connections to certificate revocation list (CRL) and online certificate status protocol (OCSP) sites, and confirm that authentication works only while the saved (cached) revocation information is still valid.


---

#### IA-5.5 — Change Authenticators Prior to Delivery (Enhancement)

This requirement is about making sure that when new parts of your systems are built, configured, delivered, or installed, they do not come with the same pre-set login details that others could easily guess. If this is not done, attackers (or careless insiders) could use the default usernames and passwords to gain access quickly, before you have time to secure the device or service. This could result in unauthorised access, disruption, or data loss.

To meet this expectation, your organisation must clearly assign internal responsibilities to developers and installers to either create unique login details for each component or replace any default ones before the component is delivered and before it goes live. You must also document how this will be handled, and ensure your purchasing documents and contracts for system parts and installation services explicitly require suppliers to do the same. You must keep evidence showing that the login details were changed in time.

##### Unique authenticators deliverable with signed handover evidence

- Category: Software
- Priority: Critical

###### WHAT
Require that every system component instance provided by developers/installers is set up with **unique authentication details** (or any **default authentication details are changed**) **before it is delivered and before it becomes operational**, and that this is proven using a **signed handover evidence pack**.

###### WHY (control requirement)
IA-5(5) enhancement requires: “Require developers and installers of system components to provide unique authenticators or change default authenticators prior to delivery and installation.” This approach ensures the timing (before delivery / before it is in service) and proof (auditable evidence) are met for each component instance.

###### HOW (specific steps/approach)
1. **Create an Authenticator Handover Evidence Pack for each component type** (for example: virtual machine image, container image, configuration bundle, managed service deployment, network appliance configuration, endpoint management agent package). The pack must include: component identifier, instance/environment, which authentication method(s) were affected (for example: administrator account, service account, device local accounts, default API keys if applicable), what was done (unique set up vs defaults changed), and the date/time.
2. **Add a “handover gate” to the release/deployment pipeline**: a deployment/change cannot be marked “delivered” or “ready for service” until the evidence pack is attached to the change/ticket and passes checks (complete and all required fields present).
3. **Create unique authentication details for each instance** using the organisation’s approved secrets method (for example: secrets manager/vault or secure injection through continuous integration and continuous delivery (CI/CD)). Do not allow the same default credentials to be shared across environments. Where defaults exist (including commercial off-the-shelf (COTS) products), require the installer runbook to perform a “change defaults” step as part of pre-operational set-up.
4. **Collect proof automatically where possible** (for example: configuration management change logs, application programming interface (API)/audit records, infrastructure-as-code apply logs, device configuration snapshots) and **complete a signed checklist step** where automation cannot prove the change (installer/developer confirmation with date/time and component reference).
5. **Store authentication details separately from evidence**: authentication details in the secrets manager; the evidence pack in an auditable repository linked to the change record/central configuration management database (CMDB) item. Keep evidence for the period required by the organisation’s audit rules.
6. **Apply the same gate to operational technology (OT)/edge installation runbooks** (where applicable) by requiring a pre-operational “unique authentication details/default-change” checklist item and a signed evidence pack at handover, adapted to vendor constraints.

###### WHO (role responsible)
- **Developers/installers**: perform the unique authentication details/default-change action and complete the signed evidence pack.
- **Release manager / DevOps engineer**: implements the pipeline handover gate and validation checks.
- **Security/Identity and Access Management (IAM) lead**: defines acceptable authentication types and uniqueness rules; reviews the evidence pack template.
- **Configuration management / CMDB owner**: ensures component/instance identifiers and evidence linkage are consistent.

###### Acceptance criteria
- For each delivered component instance, there is a **completed Authenticator Handover Evidence Pack** linked to the change record/CMDB item.
- The evidence shows the authentication action happened **before delivery** and **before the component is marked “ready for service”**.
- No default/shared authentication details are still in use after installation (confirmed by the evidence pack action type and, where possible, supporting configuration/audit records).
- The pipeline/release process prevents marking “ready for service” without the evidence pack (i.e., the handover gate is enforced).
- Evidence packs are kept and can be retrieved for audit in line with the organisation’s retention policy.

###### Actions Required for Compliance

- [ ] Create an “Authenticator Handover Evidence Pack” template for each component type.
- [ ] Set the rules for what counts as a unique identifier, and what the default change behaviour should be, for each type of authenticator (admin, service, device local, and API keys where applicable).
- [ ] Set up a release and deployment handover checkpoint that prevents anything being marked “ready for service” unless the evidence pack is provided.
- [ ] Integrate the generation and delivery of secrets with the organisation-approved secrets manager or vault.
- [ ] Update the installer and developer runbooks so they apply the default authenticator changes as a pre-operation step for commercial off-the-shelf (COTS) components.
- [ ] Store signed evidence packs in an auditable repository, linked to the relevant change record or configuration management database (CMDB) item, and keep them for the period required by the applicable policy.


---

#### IA-5.6 — Protection of Authenticators (Enhancement)

This requirement is about protecting the tools people use to prove who they are—such as passwords and other sign-in codes—at the right level of strength. If these login details or “access keys” are not protected properly, attackers could pretend to be staff, get past entry checks, and access more sensitive information than they should. This risk is higher when one system can be used to access different levels of sensitive data.

To meet this expectation, the organisation must first identify how sensitive the information is that each sign-in method can access. It must then protect each sign-in method appropriately. If the system allows different sensitivity levels to be mixed without clear separation, the organisation must apply the strongest protection required for the highest sensitivity level involved.

This approach must be written into the organisation’s login rules and day-to-day procedures, assigned to specific named roles responsible for it, implemented by system administrators, and supported by documented evidence. This evidence should include security reviews showing how well the protections work, and risk findings that track any gaps until they are closed.

##### Authenticator protection tiering driven by security categorisation

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-wide rule that links **information security categories** to the **required strength of the sign-in method** for every type of sign-in that can grant access to the application (for example: passwords, multi-factor authentication (MFA) methods, tokens, certificates, single sign-on (SSO) credentials, and recovery options). If the system can access multiple information security categories and you cannot reliably separate them, apply the **“highest security category wins”** rule.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Information Assurance (IA)-5(6) requires that sign-in methods are **protected according to the information security category** they allow access to. It also requires that where multiple security categories exist and you cannot reliably separate them (physically or logically), sign-in methods used to access the system must be protected according to the **highest** security category present.

###### HOW (specific steps/approach)
1. **Create a controlled mapping** between your organisation’s information security categories (from your information categorisation process) and the required sign-in method strength (for example: which MFA methods are allowed, cryptographic requirements for certificates and tokens, password strength rules, and recovery option requirements). Keep this mapping as controlled configuration data.
2. **Identify the highest applicable category for each application** (and for each environment: production, testing, disaster recovery) based on the categorisation results for the application’s information assets and functions.
3. **Enforce the required sign-in strength in the central identity system** (identity provider (IdP)/single sign-on (SSO)) using conditional access and authentication rules, so that any sign-in that grants access to the application must use a sign-in method that meets the required strength. **Prevent downgrade** to weaker methods for that application when multiple categories apply.
4. **Apply the same strength rules to privileged and recovery access**: ensure administrators, privileged users, service accounts, and any sign-in recovery mechanisms (for example: helpdesk resets, recovery codes, and re-enrolment processes) are protected to the strength required by the highest category.
5. **Generate evidence and check it regularly**: automatically export the identity policy configuration and the actual enforcement outcome (which sign-in methods are permitted or required per application and environment), and keep it for audit. Run periodic checks to confirm the effective enforcement matches the categorisation-based mapping.

###### WHO (role responsible)
- **Information Security / Identity and Access Management (IAM) Governance Lead**: owns the information security category to sign-in strength mapping and approves it.
- **Identity and Access Management (IAM) Engineers**: implement and maintain IdP/SSO conditional access and authentication rules.
- **Application Owner / System Owner**: provides or approves the application’s information categorisation inputs and confirms the highest-category decision.
- **Security Assurance / Compliance**: reviews the evidence and performs periodic checks.

###### Acceptance criteria
- For the application, the organisation can demonstrate (using retained evidence) that the **required sign-in method strength** is based on the **information categorisation**, and that the **highest-category rule** is applied where separation is not reliable.
- The central identity system enforces that only sign-in methods meeting the required strength are allowed to access the application; weaker methods are blocked (no downgrade).
- Privileged access and sign-in recovery routes follow the same strength rules.
- Audit evidence is available showing the current effective enforcement configuration and the results of periodic verification.

###### Actions Required for Compliance

- [ ] Create and approve a controlled mapping between enterprise security categories and the required strength levels for authenticator protection.
- [ ] For each environment, identify the highest security category that applies to the application, using the security categorisation results.
- [ ] Set up central identity provider (IdP) and single sign-on (SSO) conditional access and sign-in rules so that, for each application, users must use the strongest allowed sign-in method for their access level.
- [ ] When the application supports multiple authentication categories, disable or block the weaker authentication methods and prevent any fallback to weaker options.
- [ ] Apply the same access-level controls to privileged access and to authenticator recovery and re-enrolment processes.
- [ ] Automate the collection of evidence showing the effective configuration of the identity policy, and keep it for audit purposes.
- [ ] Carry out regular checks that the required authentication level matches the mapping based on the category, and fix any mismatches found.


---

#### IA-5.7 — No Embedded Unencrypted Static Authenticators (Enhancement)

This requirement is about making sure secret login information is not quietly built into software or left in fixed files where someone could potentially find it. If unencrypted secret information is built into an application, access scripts, or pre-set function keys, it can be copied, exposed, or reused. This could allow unauthorised people to pretend to be users or access systems without having to guess passwords.

To meet this expectation, the organisation must clearly define what it considers an “authentication secret” and what counts as “static” storage. It must also explain what it means by “encrypted” versus “unencrypted” for stored values. The organisation should then record this rule in its system security plan and authenticator management procedures, ensure that access scripts and function keys never contain unencrypted secrets, and ensure authentication is implemented without relying on such embedded values.

The organisation must review application code to find any unencrypted embedded secrets, keep evidence of those reviews, assign named people to oversee the work, and be able to show the relevant policy, plans, procedures, design and configuration records, scripts, and review results when asked.

##### Prevent unencrypted static authenticators in code and scripts

- Category: Software
- Priority: Critical

###### WHAT
Use a “secretless by design” approach and apply both technical and process controls so that authentication credentials (for example: passwords, application programming interface (API) keys, shared secrets, static tokens, and function-key values) are never built into applications or stored in other fixed places (including access scripts and function keys) in an unencrypted form. This also applies even when the stored value is used exactly as it is stored.

###### WHY (control requirement)
Information Assurance (IA)-5(7) enhancement requires: **“Ensure that unencrypted static authenticators are not embedded in applications or other forms of static storage.”** The guidance explains that **static storage includes access scripts and function keys**. It also states that if credentials are used **in the same way they are stored**, then those stored representations are treated as **unencrypted authenticators**.

###### HOW (specific steps/approach)
###### 1) Define scope and “static/unencrypted” in engineering terms
- Update the organisation’s authenticator management procedure to explicitly treat any authentication credential material as an **authenticator**.
- Define **static** as any authenticator value that is **stored or built into** deliverables (source code, compiled software, container images, virtual machine images, configuration files, access scripts, and function-key definitions) rather than being obtained at runtime.
- Define **unencrypted** as any authenticator value that appears in deliverables in a form that can be used directly (that is, the application or script uses the stored value as-is).

###### 2) Enforce via continuous integration and continuous delivery (CI/CD) and build-time scanning (software guardrails)
- Add a stage in the CI/CD pipeline that performs **secret scanning** on source code, build outputs, and packaged deliverables (for example: container images, deployment files, scripts, and any function-key configuration files).
- Configure the scanner to flag both:
  - obvious credential patterns (API keys, tokens, password-like strings), and
  - high-randomness strings and known credential formats.
- Stop merges or builds when results match the authenticator policy (or require documented approval for an exception).

###### 3) Replace embedded authenticators with runtime retrieval
- Update applications and scripts so that credentials are obtained at runtime from approved methods (for example: enterprise identity, workload identity, a secrets manager, or a key management service), rather than being built into the software.
- If any cryptographic material is required, ensure it is protected using an approved key management method and **never** stored in fixed deliverables in a directly usable form.

###### 4) Add targeted review evidence for “static storage” locations
- Carry out and keep evidence of code and configuration review specifically for:
  - access scripts (shell/PowerShell scripts, automation jobs, and administrative scripts),
  - function keys / pre-set key values (where used by the application or operational tools),
  - configuration templates and environment files included with releases.

###### 5) Manage exceptions and fix legacy cases
- Maintain an exception process that requires:
  - documented business or technical justification,
  - compensating controls (for example: strict access controls and short-lived runtime retrieval), and
  - a remediation date.
- Prioritise fixing any legacy function-key or script-based authentication methods.

###### WHO (role responsible)
- **Application Security Lead / Security Engineering**: owns the authenticator management procedure definitions and the CI/CD enforcement rules.
- **DevOps / Platform Engineering**: implements pipeline secret scanning and runtime credential retrieval patterns.
- **Application Owners / Engineering Managers**: ensure refactoring and remediation are completed and exceptions are properly justified.
- **Developers**: fix scan findings and ensure no embedded authenticators are introduced.

###### Acceptance criteria (verifiable)
- The CI/CD pipeline fails (or requires an approved exception) when unencrypted authenticator values are detected in:
  - source code, scripts, and function-key configuration files, and
  - built deliverables (for example: container images and deployment packages).
- Applications and operational scripts obtain credentials at runtime from approved identity and secrets services; no authenticator values are present in release deliverables in a directly usable form.
- Evidence exists for at least one full release cycle showing:
  - secret scan results,
  - remediation and waiver records (if any), and
  - targeted review outcomes for scripts and function-key related deliverables.
- Any identified embedded static authenticators are either removed or covered by an approved exception with an agreed remediation plan.

###### Actions Required for Compliance

- [ ] Update the authenticator management procedure to define:

- **“authenticator”**
- **“static”**
- **“unencrypted”** (including the **“used as-is”** rule)
- [ ] Set up automated checks in the continuous integration and continuous delivery (CI/CD) process to scan for secrets in source code, scripts, function-key configuration files, and packaged outputs (for example, container images).
- [ ] Set up release “pipeline gates” to stop deployments when unencrypted static authenticators are found, with an exception process and remediation deadlines.
- [ ] Update applications and access scripts so they get authenticator details at the time they are needed from approved identity and secrets services, instead of hard-coding those values.
- [ ] Create targeted pre-release review checklists for access scripts and any function-key features, and keep the supporting evidence for audit purposes.
- [ ] Create and carry out a plan to fix any legacy embedded or static authenticator issues, prioritising them based on how much risk they create (exposure) and how serious they are (criticality).


---

#### IA-5.8 — Multiple System Accounts (Enhancement)

This requirement is about making sure people do not use the same login secret (such as a password) across multiple systems. The real-world risk is straightforward: if someone’s access to one system is stolen or guessed, and the same password or login method also works on other systems, attackers can quickly move to those other systems using the same credentials.

To meet this expectation, the organisation must use a shared login approach. Users should sign in through a central identity service when accessing systems, rather than each system relying on its own separate password. For each person, each system must use unique authentication credentials. The organisation must also stop users from reusing the same password or other authenticator on different systems.

The organisation should document these rules in its login and password management policies and procedures, include the approach in each system’s security plan, keep an up-to-date list of people who have accounts on multiple systems, and record the safeguards in place. Named responsibilities should be clearly assigned for managing and overseeing these arrangements.

##### Federated SSO for multi-system users with no password reuse

- Category: Software
- Priority: Critical

###### WHAT
Set up a federated single sign-on (SSO) approach for users who have accounts on more than one system. Require that each system uses a unique authenticator, so users cannot reuse the same password or authenticator across systems. Where possible, turn off or tightly limit password-based sign-in on each system for the covered applications, so sign-in is handled through the central identity provider (IdP).

###### WHY (control requirement)
This requirement (NIST IA-5(8) enhancement) asks us to follow the organisation’s defined approach (ia-05.08_odp) to reduce the risk of compromise spreading when people have accounts on multiple systems and use the same authenticators (especially passwords). The guidance specifically highlights federated SSO and other options to reduce cross-system compromise risk.

###### HOW (specific steps/approach)
1. **Define the federated SSO approach for the in-scope application(s)**: choose the IdP as the main (authoritative) sign-in source, and configure the application as a relying party using Security Assertion Markup Language (SAML) or OpenID Connect (OIDC).
2. **Ensure sign-in is handed off to the IdP**: configure the application so it accepts only IdP-issued assertions or tokens for interactive user access. Disable local password sign-in for normal users (or restrict it to tightly controlled “break-glass” accounts with documented exceptions).
3. **Require unique authenticators per system through IdP sign-in**: make sure users sign in to the IdP using phishing-resistant multi-factor authentication (MFA) (for example, FIDO2/passkeys or an equivalent method). Ensure the application does not store reusable system passwords for standard users.
4. **Prevent password reuse across systems**: put technical controls in place so users cannot set or use the same password on multiple systems. Do this by removing the ability to use system-local passwords for the covered systems and centralising sign-in at the IdP.
5. **Ensure the setup is auditable and resilient**: manage federation and MFA requirements using infrastructure-as-code (code that defines infrastructure) / configuration-as-code pipelines. Ensure sign-in logs record whether access used federated SSO.
6. **Keep evidence for people with access to multiple systems**: maintain an up-to-date list of individuals who have access to multiple systems, and record the safeguards used (federated SSO, MFA enforcement, and any break-glass exceptions).

###### WHO (role responsible)
- **Identity and Access Management (IAM) Lead**: responsible for IdP configuration, MFA enforcement, and federation standards.
- **Application Owner / Security Engineer**: implements the relying-party configuration and disables or restricts local password sign-in.
- **Security Governance / Compliance Lead**: ensures the multi-system access list and exception handling are documented and reviewed.

###### Acceptance criteria
- The in-scope application(s) authenticate interactive users using federated SSO (SAML/OIDC) to the central IdP, and local password sign-in is disabled for standard users.
- For users with accounts on multiple systems, sign-in is mediated by the IdP, and users cannot reuse system-local passwords across systems because system-local password sign-in is not available (or is limited to documented break-glass accounts).
- The IdP enforces phishing-resistant multi-factor authentication (MFA) for the relevant user population (or an equivalent strong MFA method in line with the organisation’s standard).
- Evidence is available showing: (a) federation configuration, (b) MFA enforcement policy, (c) sign-in logs indicating federated SSO usage, and (d) a current list/mapping of multi-system users with documented safeguards and any exceptions.

###### Actions Required for Compliance

- [ ] Choose and document the main identity provider (IdP) and the federation method (Security Assertion Markup Language (SAML) or OpenID Connect (OIDC)) for the in-scope application(s).
- [ ] Configure the application to accept only identity provider (IdP) assertions and tokens, and turn off local password sign-in for standard users.
- [ ] Require phishing-resistant multi-factor authentication (MFA) at the identity provider (IdP) for user groups that have accounts on multiple systems.
- [ ] Put in place technical safeguards to stop people reusing the same local password on different systems, by removing the ability to log in using system-local passwords.
- [ ] Manage federation and multi-factor authentication (MFA) settings using configuration-as-code, and make sure every change can be reviewed and audited.
- [ ] Create and keep an up-to-date record of which accounts map to which systems, and document the protections in place—such as single sign-on (SSO) through a trusted provider, enforcing multi-factor authentication (MFA), and any authorised “break-glass” exceptions.
- [ ] Use testing and monitoring to confirm that users can sign in to the application only through federated single sign-on (SSO), and ensure that audit logs are generated.


---

#### IA-5.9 — Federated Credential Management (Enhancement)

This requirement is about ensuring that, when your organisation needs to check people and devices from other organisations, it only relies on a small, approved set of external identity and trust services: **DoD Defense Manpower Data Center (DMDC) Enterprise Identity** and **DoD Public Key Infrastructure (PKI) (Common Access Card)** trust services.  

This matters because if you allowed unapproved partners to verify credentials, the wrong person or device could be accepted. That could lead to unauthorised access, exposure of sensitive data, or disruption to shared activities.  

To meet this expectation, your organisation must set clear rules for cross-organisation sign-in and verification that name only these approved services. These rules must be reflected in: your identification and authentication policy, your procedures for managing credentials and accounts, your system security plan, and your security agreements and related records.  

You must also appoint named individuals responsible for credential management, information security oversight, and operating the cross-organisation (federated) authentication capability. Finally, you must ensure the system is configured so only the approved services can be used, and you must keep evidence showing they are actually used for cross-organisation activities that involve processing, storing, or transmitting information.

##### Allow-list federated partners to DMDC ID and DoD PKI/CAC only

- Category: Software
- Priority: Critical

###### WHAT
Set up and enforce federated credential management so that cross-organisation sign-in uses **only** the approved external organisations listed in **IA-5(9) parameter ia-05.09_odp**: **DoD Defense Manpower Data Center (DMDC) Enterprise Identity** and **DoD PKI (Common Access Card) trust services**.

###### WHY (control requirement)
IA-5(9) enhancement requires: **“Use the following external organizations to federate credentials: {{ insert: param, ia-05.09_odp }}.”** The goal is to ensure only **checked and trusted** external identity and trust services are used for cross-organisation activities that involve the **processing, storage, or transmission** of information.

###### HOW (specific steps/approach)
Create a central federation enforcement point (for example, an enterprise federation gateway, an identity provider broker, or a reverse-proxy authentication gateway) that:
1. **Hard-codes an approved partner list** containing exactly the two approved services (DMDC Enterprise Identity and DoD PKI/CAC trust services).
2. **Locks trust settings** to the approved issuer/metadata/certificate trust anchors for each service (for example: SAML/OpenID Connect issuer and audience limits; certificate trust store for CAC; required signature checks; certificate revocation checks where applicable).
3. **Blocks any non-approved federation partner** by turning off dynamic discovery/automatic metadata import, and by rejecting any authentication statements/tokens whose issuer, signing certificate chain, or trust anchor does not match the approved list.
4. Uses **policy-as-code / configuration-as-code** so any changes must be reviewed and approved, and are kept in version history.
5. Enables **audit logging** that records which external federation partner was used for every successful and failed federated sign-in attempt, and keeps logs as evidence.
6. Updates the relevant governance documents to reflect the approved partner list and enforcement method (at minimum: identification and authentication policy, authenticator/account management procedures, system security plan, and federation-related security agreements).

###### Practical implementation notes for typical enterprise systems
- If using SAML/OpenID Connect: enforce **issuer**, **audience**, **signature validation**, and **metadata/certificate pinning** to the approved DMDC and DoD PKI/CAC trust anchors.
- If using CAC-based client authentication: configure the application/gateway to trust only the approved DoD PKI/CAC trust store, and map certificates to identities using the approved mapping rules.
- Ensure relying applications validate statements/tokens correctly and do not accept unsigned or incorrectly signed statements.

###### WHO (role responsible)
- **Identity and Access Management (IAM) / Federation Architect**: designs the federation enforcement point and the approved partner list rules.
- **Identity and Access Management (IAM) Engineer**: implements federation configuration, trust anchors, and token/statement validation.
- **Information Security Officer / Security Governance Lead**: ensures policies, procedures, the system security plan, and security agreements reflect the approved partner list.
- **Change Manager / Security Approver**: ensures any federation configuration changes are reviewed and approved.

###### Acceptance criteria (verifiable)
- The federation enforcement point is configured to accept **only** DMDC Enterprise Identity and DoD PKI/CAC trust services from **ia-05.09_odp**.
- Attempts using any other external federation partner (different issuer/metadata/signing certificate chain) are **rejected** (no successful sign-in) and are logged.
- Federation configuration is managed using version-controlled configuration/policy-as-code, with restricted administrative access.
- Audit logs show that federated sign-in events include the **external partner identity** (DMDC vs DoD PKI/CAC) and logs are retained for audit.
- The organisation’s identification and authentication policy, authenticator/account management procedures, system security plan, and relevant security agreements document the approved external organisations and the enforcement approach.

###### Actions Required for Compliance

- [ ] Create an allow-list of federation partners that includes exactly the following trust services from **ia-05.09_odp**: **DMDC Enterprise Identity** and **Department of Defense public key infrastructure (DoD PKI) (Common Access Card (CAC))**.
- [ ] Set up the federation enforcement point to check and lock the trusted issuer, audience, and signing certificates for only the two approved services.
- [ ] Turn off automatic discovery of federation partners and automatic import of federation details, and limit changes to federation settings to approved administrators only.
- [ ] Implement rejection logic to block any federated authentication assertion or token if its issuer or certificate chain does not match the approved allow-list.
- [ ] Enable and keep audit logs that record which external federation partner was used for each federated login attempt.
- [ ] Update the identification and authentication policy, the procedures for managing authenticators and accounts, the system security plan, and the federation security agreements to record the approved partner list and how it will be enforced.


---

#### IA-5.10 — Dynamic Credential Binding (Enhancement)

This requirement is about ensuring that when someone signs in using a smartcard, the system only trusts that smartcard if it can reliably link it to the correct person. The system must only create that person’s access after these checks are completed successfully. Without this, a stolen or forged smartcard could be used to access the wrong accounts, or the system could accidentally create new accounts using untrusted or incorrect information. This could result in unauthorised access and inaccurate, difficult-to-manage identity records.

To meet this expectation, the organisation must set up an automated process that:
- verifies the smartcard’s certificate using certificates issued by an approved authority
- checks that the certificate includes the required details
- maps the certificate to the correct identity

If any validation fails, if required certificate details do not match, or if the system cannot determine a valid identity match, the system must block the login and must not create or activate any identity. The system must also keep clear records of what happened during each sign-in attempt.

##### IdP-enforced PKI smartcard binding with JIT provisioning

- Category: Software
- Priority: Critical

###### WHAT
Set up dynamic linking of smartcard login credentials by only linking the presented public key infrastructure (PKI) certificate to a user identity after the system enforces the organisation’s required linking rules (ia-05.10_odp). The system must:
- check that the certificate is valid (including that it chains to an approved certificate authority (CA) and, where applicable, that it has not expired or been revoked),
- confirm the certificate contains the required certificate details (attributes),
- reliably and consistently work out which identity the certificate belongs to,
- and only then dynamically create, activate, or provision that identity for the authenticated session (just-in-time (JIT)).

###### WHY (control requirement)
IA-5(10) requires that identities and login credentials are linked dynamically using the organisation’s required **binding rules** (parameter **ia-05.10_odp**). The guidance states that linking must not rely on weak or unspoken assumptions. Instead, organisations must validate identities and credentials using pre-agreed trust relationships and mechanisms. Dynamic provisioning must only happen after successful validation.

###### HOW (specific steps/approach)
1. **Define and implement the binding rules in the identity provider (IdP)**: encode how the certificate maps to a user identity and the required order of actions (validate → check certificate details → map to identity → provision). Use the organisation’s rule: “PKI-based smartcard binding with certificate-to-identity mapping via Department of Defense (DoD)-approved CA; dynamically provision identity only after successful certificate validation and certificate detail checks.”
2. **Only trust approved certificate authority (CA)(s)**: configure the IdP’s certificate trust list (allow-list) so it accepts only certificates that chain to the **DoD-approved CA(s)** named by the organisation. Reject any certificate that fails chain validation.
3. **Validate the presented certificate before any mapping or provisioning**: ensure the IdP checks certificate validity (time validity) and revocation status where your public key infrastructure (PKI) setup supports it (for example, certificate revocation list (CRL) or online certificate status protocol (OCSP)). If validation fails, deny access and stop—do not continue.
4. **Check required certificate attributes**: after validation succeeds, check the certificate has the required details (for example, extended key usage (EKU)/key usage appropriate for smartcard authentication, subject/alternative name format, required object identifiers (OIDs)/claims, and any organisation-specific conditions). If these checks fail, deny access and do not provision.
5. **Map the certificate to an identity in a consistent, predictable way**: determine the identity using the defined mapping rules (for example, map certificate user principal name (UPN)/alternative name or subject distinguished name (DN) components to a directory key). If the mapping is unclear or does not match the expected identity key format, deny access and do not provision.
6. **Only trigger just-in-time (JIT) provisioning after success**: configure the IdP so user creation and activation happens only after all steps above succeed. Include a clear “no provisioning on failure” safeguard (no fallback to weaker identifiers; no partial account creation).
7. **Create audit evidence for every attempt**: generate audit records showing the certificate validation result, whether certificate attribute checks passed or failed, the mapping result (success/unclear), and whether provisioning occurred. Send logs to the enterprise security information and event management (SIEM) system for correlation and alerts.

###### WHO (role responsible)
- **Identity and Access Management (IAM) Engineer**: configure the IdP, set up trust and validation, implement mapping rules, and implement the just-in-time (JIT) provisioning workflow.
- **Public Key Infrastructure (PKI) / Certificate Authority Administrator**: confirm the approved CA list, revocation locations, and required certificate attribute details.
- **Security Operations / SIEM Engineer**: ensure audit events are correctly sent, stored, and monitored.

###### Acceptance criteria
- Smartcard authentication attempts using certificates that do not chain to the approved DoD CA are denied and do not result in any identity provisioning.
- Smartcard authentication attempts where certificates fail validity or revocation checks are denied and do not result in any identity provisioning.
- Smartcard authentication attempts where required certificate attributes do not match the binding rules are denied and do not result in any identity provisioning.
- For successful attempts, the certificate is mapped to the correct identity in a consistent way, and just-in-time (JIT) provisioning/activation happens only after validation and attribute checks.
- Audit logs exist for each attempt showing: validation result, certificate attribute check result, mapping outcome, and whether provisioning occurred.

###### Actions Required for Compliance

- [ ] Set up the identity provider (IdP) to apply the organisation’s defined binding rules (ia-05.10_odp) as a fixed, repeatable rule that links each certificate to the correct identity.
- [ ] Configure the identity provider (IdP) to trust only the Department of Defense (DoD)-approved certificate authority or authorities (CAs) when checking the smart card certificate chain (using an explicit CA allow-list).
- [ ] Before mapping or provisioning, enable certificate validation, including checks that the certificate is still valid and has not been revoked, in line with the public key infrastructure (PKI) model.
- [ ] Set up checks for required certificate details (for example, extended key usage (EKU), key usage (KeyUsage), and required subject, alternative name (altName), and object identifier (OID) rules). If any check fails, block the certificate.
- [ ] Set up just-in-time (JIT) provisioning so that user account creation and activation happen only after successful checks for identity validation, required attributes, and a consistent, predictable mapping.
- [ ] Add a clear safeguard to stop identity provisioning when the mapping is unclear or when any validation or attribute check fails.
- [ ] For every sign-in attempt, enable and send audit records to the security information and event management (SIEM) system. These records should include the validation result, the attribute check result, the mapping outcome, and whether provisioning took place.


---

#### IA-5.12 — Biometric Authentication Performance (Enhancement)

This requirement is about making sure that when people log in using a fingerprint, face scan, or similar biological check, the system is accurate enough to allow genuine users in, while almost never letting impostors through. If it does not meet this standard, an attacker could trick the system into granting access using a fake or low-quality biometric, or legitimate staff could be incorrectly turned away—causing disruption and increasing the risk of unauthorised entry.

To meet this requirement, the organisation must use biometric authentication methods that achieve at least a 99.5% genuine match rate when checking users, while keeping the false match rate to no more than 0.1%. The organisation must also ensure liveness detection is enabled, meaning the system checks that the biometric is taken from a live person rather than a copy.

The organisation should record these biometric quality targets, configure the system to meet them, and keep audit records showing that biometric performance meets the stated requirements.

##### Enforce biometric verification quality targets with liveness

- Category: Software
- Priority: Critical

###### WHAT
Implement biometric-based authentication (verification) using biometric solutions that meet the organisation’s required quality standards, specifically: **for verification, achieve at least a 99.5% genuine match rate when the false match rate (FMR) is no more than 0.1%**, and **ensure liveness detection is enabled**.

###### WHY (control requirement)
The NIST IA-5(12) enhancement requires that, for biometric-based authentication, the organisation uses mechanisms that meet the biometric quality requirements defined in **ia-05.12_odp**. The guidance explains that biometric performance is assessed using **match rate** (for example, genuine match rate) and **false match rate (FMR)**, and that **liveness detection** is needed to reduce the risk of spoofing.

###### HOW (specific steps/approach)
1. **Choose verification-grade biometric components** (software development kit (SDK)/engine and/or capture hardware) that support liveness detection and have documented performance characteristics that match the required operating point.
2. **Define and document the biometric quality requirements** in the system security design/configuration documentation exactly as: **≥99.5% genuine match rate at FMR ≤0.1%** and **liveness detection enabled**.
3. **Set the biometric verification decision thresholds** (operating point) in the authentication service so the system runs at or below the required FMR while still meeting the genuine match rate target. Make sure this configuration is used in production and cannot be bypassed through fallback options.
4. **Turn on liveness detection explicitly** in the capture and/or verification process (depending on the biometric technology) and test that liveness checks run for every verification attempt.
5. **Keep audit evidence** showing the enforced configuration and performance position, including: the **operating point/threshold version**, the **liveness enabled indicator**, and the relevant biometric authentication event information needed for audit.
6. **Protect configuration integrity** by using version-controlled configuration baselines and change control, so threshold and liveness settings cannot be changed without approval.

###### WHO (role responsible)
- **Application/Identity Engineering Lead**: sets up biometric verification configuration, enforces thresholds, and enables liveness.
- **Security Architect / IAM Security Owner**: approves the documented biometric quality requirements and checks that the configuration meets the targets.
- **Platform/DevOps Engineer**: deploys the version-controlled biometric configuration baseline and ensures it is enforced in production.
- **Security Assurance / Compliance**: checks the evidence (audit logs/configuration records) to confirm audit readiness.

###### Acceptance criteria
- The production authentication service is configured so that **verification achieves ≥99.5% genuine match rate at FMR ≤0.1%** (based on the selected biometric mechanism and the enforced operating point configuration).
- **Liveness detection is enabled** and cannot be bypassed for verification attempts.
- Audit evidence exists showing the **threshold/operating point version** and **liveness enabled status** for the deployed configuration.
- Any changes to biometric thresholds or liveness require approved change control and can be traced to the deployed version.

###### Actions Required for Compliance

- [ ] Choose a verification-grade biometric software development kit (SDK) or engine and/or capture hardware that supports liveness detection and has documented performance characteristics.
- [ ] Document the biometric quality requirements in the system security and configuration documentation as follows: **at least 99.5% genuine match rate when the false match rate is 0.1% or less, and liveness detection must be enabled**.
- [ ] Set the biometric verification decision thresholds in the authentication service so that the false match rate is **0.1% or less**, while aiming for a **genuine match rate of 99.5% or higher**.
- [ ] Enable liveness detection in the capture and/or verification process, and confirm it is applied to every verification attempt with no option to bypass or fall back to a less secure method.
- [ ] Set up audit logs to record the version of the threshold or operating point settings and whether liveness detection is enabled for biometric verification events.
- [ ] Store biometric threshold and “liveness” settings as a version-controlled baseline, and apply them through controlled releases that require change approval.


---

#### IA-5.13 — Expiration of Cached Authenticators (Enhancement)

This requirement ensures that any stored login information used to sign in when the network is unavailable stops working after 7 days. Without this, someone could use old, outdated sign-in details long after they should have been updated, which increases the risk of unauthorised access if a person’s access should have changed or been removed.

To meet this requirement, the organisation must:
- set a clear 7-day expiry rule for stored login and authentication information;
- automatically block sign-in using that stored information once it is more than 7 days old; and
- enforce the rule through the system’s own settings, rather than relying on staff to remember.

The organisation should also document how stored sign-ins are created, updated, and cancelled, record the settings that are in place, assign named responsibilities to the appropriate roles, and keep audit records showing when stored sign-ins were allowed or blocked due to expiry.

##### Enforce 7-day expiry for offline cached authenticators with audit

- Category: Software
- Priority: Critical

###### WHAT
Implement a technical enforcement measure that **blocks the use of cached authenticators after the organisation-defined time period** (default **7 days**, per `ia-05.13_odp`). Ensure the system **denies offline/cached sign-in once the cached data is older than 7 days** and **logs audit evidence** for both **allowed** and **denied** attempts.

###### WHY (control requirement)
NIST IA-5(13) (Enhancement) requires: **“Prohibit the use of cached authenticators after {{ insert: param, ia-05.13_odp }}.”** The guidance explains that cached sign-in is used when the network is unavailable, but it may become unreliable if it is too old. Therefore, cached authenticators must become invalid after the defined period.

###### HOW (specific steps/approach)
1. **Identify the cached authenticator mechanism(s)** used for offline sign-in across the enterprise identity journey (for example: endpoint offline sign-in cache, brokered offline tokens, or local credential material issued or managed by the identity software stack).
2. **Set the cached authenticator lifetime to exactly 7 days** (or the configured `ia-05.13_odp` value) using centrally managed configuration (for example: endpoint management policy, identity provider policy automation, or configuration management tooling). Make sure there are **no** “unlimited”, “grace”, or vendor default overrides.
3. **Enforce expiry at the time of sign-in**: configure the sign-in component to check the **cache creation/refresh time** and **deny** cached sign-in when `now - cache_timestamp > ia-05.13_odp`.
4. **Remove or disable any fallback** that would allow sign-in to continue after expiry (for example: reusing stale cached credentials, silent refresh without network access, or any other offline credential route not governed by the same expiry rule).
5. **Create audit records** for offline/cached sign-in outcomes, including: user identifier, device/host identifier, time of attempt, cache age (or the expiry decision), and a clear reason code (for example: `CACHED_AUTH_EXPIRED`). Send these events to the security information and event management (SIEM) system for auditability.
6. **Test the enforcement** on representative managed endpoints: create/refresh cached authenticators, simulate a network outage, attempt sign-in at **under 7 days** and **over 7 days**, and confirm sign-in is blocked after expiry.

###### WHO (role responsible)
- **Identity and Access Management (IAM) Lead**: owns the mapping between policy and configuration for `ia-05.13_odp`, and ensures the correct enforcement points are selected.
- **Endpoint/Platform Engineering (or IT Operations)**: implements and verifies centrally managed configuration on endpoints.
- **Security Monitoring (SOC/SIEM Engineer)**: ensures audit events are collected, normalised, and retained correctly.

###### Acceptance criteria
- The system’s effective cached authenticator lifetime is **exactly** the configured `ia-05.13_odp` value (default **7 days**) across all in-scope managed endpoints.
- Offline/cached sign-in attempts **work only when cache age is within the limit**, and are **denied when cache age exceeds the limit**.
- Audit logs/SIEM events exist for offline/cached sign-in attempts showing **allowed/denied outcomes** and an **expiry/invalidity reason code**.
- Evidence is available showing configuration settings and test results for at least one representative endpoint per major platform type (for example, Windows/macOS/Linux if applicable).

###### Actions Required for Compliance

- [ ] Identify the specific offline or cached authentication method(s) used by the in-scope devices, and confirm where the system records the time each cache entry was created.
- [ ] Set the cached authenticator expiry to exactly `ia-05.13_odp` (default: 7 days) using the centrally managed identity or endpoint policy, and check that no other settings override it.
- [ ] Set up authentication-time enforcement so that any cached authentication is rejected if the cache is older than `ia-05.13_odp`.
- [ ] Disable, or reroute around, any offline authentication fallback routes that would allow cached authentication to be used after the expiry time window.
- [ ] Set up audit logging for authentication attempts that are handled offline or from cached data. Include clear expiry decision and reason codes, and send the logs to the security information and event management (SIEM) system.
- [ ] Run controlled tests during a network outage to confirm the process works before the access expires, and is blocked after it expires. Keep records and evidence of the results.


---

#### IA-5.14 — Managing Content of PKI Trust Stores (Enhancement)

This requirement is about keeping the organisation’s trusted digital certificate lists consistent and up to date wherever they are used to decide who or what is allowed to connect. If these trusted lists are managed differently across networks, computers, web browsers, and applications, people could be blocked incorrectly, or—more seriously—the organisation might trust the wrong certificates, which could allow unauthorised access or impersonation.

To meet this expectation, the organisation must use one single, organisation-wide approach for managing the contents of all such trusted lists. This approach must be applied specifically to any sign-in or access decisions that rely on trusted certificates.

Named responsibilities must be assigned, with input from information security. System and network administrators must be involved for the platforms they run, and application developers must be involved where relevant. The approach must be supported by practical processes or tools, documented in system plans and designs, reflected in configuration records, and aligned with the organisation’s overall security and architecture plans.

##### Governed trust-store policy with automated, drift-checked rollout

- Category: Software
- Priority: Critical

###### WHAT
Put in place an organisation-wide approach to define and control the content of every public key infrastructure (PKI) “trust store” used for PKI-based authentication across networks, operating systems, browsers, and applications. Create one single, authoritative trust-store policy (what the organisation trusts and what it does not trust) and apply it consistently to every relevant platform. Keep it up to date and continuously check for unauthorised or accidental changes (drift).

###### WHY (control requirement)
IA-5(14) (Enhancement) requires that, for PKI-based authentication, the organisation uses an organisation-wide approach to manage the content of PKI trust stores installed across all platforms (networks, operating systems, browsers, applications). This helps ensure PKI-based authentication credentials stay accurate and current across the organisation.

###### HOW (specific steps/approach)
1. **Create an authoritative trust-store content model**: define the approved trust sources (roots/intermediates) and any explicit “do not trust” rules, including authentication-related constraints (for example, which certificate uses are allowed, where relevant to how your PKI is used). Keep this model in a version-controlled repository.
2. **Set up governance and named responsibilities**: assign named roles for managing trust-store content (including information security oversight) and require peer review and approval for any changes. Make sure system and network administrators, and application owners or developers, are involved for the platforms and applications they manage or use.
3. **Automate deployment to each platform type**:
   - **Operating systems**: use enterprise endpoint management (for example, Microsoft Intune, Group Policy, or Jamf) to install and update operating system trust stores using the authoritative policy.
   - **Browsers**: use managed browser policy settings to control trust-store behaviour where supported.
   - **Applications**: configure applications to use the governed trust sources (for example, by distributing a shared trust bundle, using a trust bundle at build time, or mounting a trust bundle at runtime) rather than building in local, one-off trust stores.
   - **Networks** (where applicable): configure transport security trust checks (for example, for Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS)) in components such as reverse proxies, application programming interface (API) gateways, and load balancers to use the governed trust bundle.
4. **Keep it current using lifecycle automation**: collect certificate authority (CA) information such as expiry dates and planned rotations, plus revocation and validity signals. Create change tickets with impact analysis and agreed rollout and rollback windows. Ensure trust-store updates follow the same review and approval process.
5. **Detect and fix drift**: continuously compare what is deployed on each platform (per platform and environment) against the authoritative policy. Alert on differences and correct them using the same controlled deployment method.
6. **Create audit-ready evidence and documentation**: update system security plans, designs, and configuration records to show which trust-store policy applies to each system and how it is deployed (including change records and drift reports).

###### WHO
- **Information Security (policy owner/oversight)**: owns the authoritative trust-store content model and the approval process.
- **Public Key Infrastructure (PKI) and Identity team (implementer)**: maintains the “policy as code” model, lifecycle automation, and trust bundle creation.
- **System/Network Administrators**: carry out platform-specific deployment (operating system and network components).
- **Application Owners/Developers**: ensure applications use the governed trust bundle or policy rather than local, ad-hoc trust stores.
- **Change Management/Release Management**: ensures controlled rollout and rollback, and captures evidence.

###### Acceptance criteria
- There is a **single, version-controlled authoritative trust-store policy** defining what is trusted and what is not trusted for PKI-based authentication.
- Named roles and an approval workflow exist, with evidence that trust-store changes have been reviewed.
- Trust-store content is **deployed consistently** across all relevant platform categories (operating systems, browsers, applications, and any applicable network components).
- Trust-store updates are **kept up to date** using automated lifecycle inputs and scheduled, approved rollouts.
- **Drift detection** is in place and produces useful alerts and evidence; any deviations are corrected within agreed operational timeframes.
- System security plans, designs, and configuration records include **documented coverage** and deployment details for each system and environment.

###### Actions Required for Compliance

- [ ] Define an official trust-store content model (approved trust anchors and any explicit distrust rules) in a version-controlled repository.
- [ ] Assign named roles and set up an approval workflow for changes to the trust store, with oversight from information security.
- [ ] Set up automated deployment of the governed trust bundle to the operating system trust stores that are managed, and configure browser settings where supported.
- [ ] Update applications and transport layer security (TLS) / mutual transport layer security (mTLS) network components so they use the approved trust bundle and policy (remove any built-in, ad-hoc trust stores).
- [ ] Automate the process of bringing in certificate and certificate authority (CA) updates—covering expiry and rotation, and revocation and validity information—to create approved tickets for updating the trusted certificate store.
- [ ] Set up drift detection to compare what is currently deployed in the trust store against the approved policy, and automatically fix the configuration if they do not match.
- [ ] Update system security plans, designs, and configuration records to document which trust-store settings are covered, and to keep evidence of changes and any drift from the approved configuration.


---

#### IA-5.15 — GSA-approved Products and Services (Enhancement)

This requirement is about making sure your organisation uses only pre-approved products and services for the systems that: prove who people are, manage their login details, and control access to services. If this is not done, organisations may unintentionally use tools that have not been checked for safety and correct behaviour. This increases the risk of unauthorised access, weak or inconsistent checks of identity, and poor control over how user accounts and login credentials are connected and kept up to date.

To meet this expectation, the organisation must have a clear written policy and supporting procedures that explain how identity and login are handled. This includes how user identifiers are created, changed, and managed. The organisation must also show that these processes use only products and services that are listed on the General Services Administration approved list, or that are otherwise documented as approved through the relevant conformance programme.

In addition, for each system, the organisation must document:
- which approved products are used
- how user identifiers are dynamically linked to the login credentials
- what configuration settings were applied
- records of identity and access activity are kept.

##### IAM approved-catalogue with evidence-backed enforcement for FICAM

- Category: Manual
- Priority: Critical

###### WHAT
Set up an organisation-wide “approved IAM catalogue” that includes only **General Services Administration (GSA) conformance programme-approved** identity, credential, and access management (ICAM) products and services. Then require that every ICAM integration the application uses connects only to catalogue-approved components.

###### WHY (control requirement)
IA-5(15) (Enhancement) requires: **“Use only General Services Administration-approved products and services for identity, credential, and access management.”** The guidance explains that approved products and services are those **approved through the GSA conformance programme (where applicable)** and **listed on the GSA Approved Products List**.

###### HOW (specific steps/approach)
1. **Create and maintain the approved IAM catalogue** for the ICAM capabilities the application uses (for example: identity provider (IdP), multi-factor authentication (MFA), federation, directory/identity store, certificate services, privileged access management (PAM) connectors, account lifecycle tools, and any certificate/public key infrastructure (PKI)-based access methods).
2. For each catalogue item, keep **evidence of GSA approval status**, including the vendor and product/service name, version (where applicable), and a link/reference to the **GSA Approved Products List** entry (or the documented conformance programme approval reference).
3. **Update the identification and authentication policy** to clearly state that **only GSA-approved ICAM products and services from the catalogue** may be used for authentication, credential handling, account management, and identifier management processes.
4. **Enforce through architecture and continuous integration/continuous delivery (CI/CD) checks**: during design reviews and release pipelines, confirm that configuration and integration points (IdP adapters, federation endpoints, MFA policy engines, PAM connectors, certificate issuance/validation components, and any logic that links identities to credentials) use only catalogue-approved components.
5. **Record per-system evidence** in the system security plan/design: list which approved catalogue components are used, the relevant configuration settings/baselines, and how the application depends on those components for authentication and credential/identifier handling.
6. **Keep audit-ready records** that link ICAM activity to the approved components (for example: logs showing authentication events come from the approved IdP/MFA/PAM/certificate services, plus configuration snapshots showing the approved settings in place).

###### WHO (role responsible)
- **IAM Governance Lead / Chief Information Security Officer (CISO) delegate**: owns the approved IAM catalogue and policy updates.
- **Enterprise Architect / Security Architect**: ensures the application architecture/design references only catalogue-approved components.
- **Application Owner / DevSecOps Lead**: implements CI/CD and configuration validation checks, and ensures system documentation is updated.
- **Configuration Management Lead**: maintains configuration baselines and keeps evidence for audit.

###### Acceptance criteria
- Every ICAM component the application uses (IdP/MFA/federation/PAM/certificate services/identity stores and connectors) matches a catalogue entry with **documented GSA approval evidence**.
- The application’s design and system security plan explicitly list the approved catalogue components and the configuration settings/baselines applied.
- CI/CD or release governance blocks deployment if ICAM integrations reference any non-catalogue components.
- Audit evidence exists showing that authentication, credential, and privileged access activity is produced by the approved ICAM components, and configuration snapshots confirm only approved settings were deployed.

###### Actions Required for Compliance

- [ ] Create an approved identity and access management (IAM) catalogue that links each identity and access management capability used by the application to a Government Security Agency (GSA) Approved Products List entry (including the version where applicable).
- [ ] Update the identification and authentication policy so that only catalogue-approved, General Services Administration (GSA)-approved identity and access management (ICAM) products and services can be used.
- [ ] Set up architecture and design review checkpoints that reject any identity and access management (IAM) integrations that are not listed in the approved IAM catalogue.
- [ ] Add checks to the continuous integration and continuous delivery (CI/CD) setup to confirm that the identity provider (IdP), multi-factor authentication (MFA), federation, privileged access management (PAM), and certificate integration settings reference only approved catalogue components.
- [ ] Update the application system security plan and design documents to name the approved identity and access management (ICAM) components and the configuration settings and security baselines that have been applied.
- [ ] Set up evidence retention for audits by keeping: catalogue records, configuration snapshots, and logs that show the identity and access management (ICAM) activity comes from approved components.


---

#### IA-5.16 — In-person or Trusted External Party Authenticator Issuance (Enhancement)

This requirement ensures that identity cards and their personal access codes are given out only in a controlled, face-to-face process, and only after the correct checks and approvals are completed. Without this, the wrong person could receive a smart card or its code, or the process could be rushed or skipped, which could allow unauthorised access to systems and sensitive information.

To meet this requirement, the organisation must issue the specified, verified smart cards and deliver the associated personal identification number (PIN) in person. It must never be done through unattended or remote methods. Issuance can happen only after the registration team has formally approved the person’s identity. In addition, no smart card can be issued unless the Identity and Access Management director has explicitly authorised it.

The organisation must also keep clear records showing that:
- the required approvals were obtained before issuance,
- the approvals relate to the same person, and
- the records match the same issuance event, and
- the smart card and PIN were handed over together face-to-face.

##### Workflow-gated in-person PIV+PIN issuance with dual approvals

- Category: Software
- Priority: Critical

###### WHAT
Set up an issuance process that allows issuance only for the specified authenticators: **FIPS 140-2 validated personal identity verification (PIV) smart cards** and the associated **personal identification number (PIN) delivery**. This must be done **in person only**, and **only after registration authority approval has been recorded before any issuance action**, with **explicit authorisation by the identity and access management (IAM) director**.

###### WHY (control requirement)
Control IA-5(16) requires that issuance of the defined authenticator types is carried out **in person**, **before** registration authority approval, and with authorisation by the defined roles/personnel (the IAM director). Issuing without these ordering and authorisation controls weakens the reliability of identity checks and increases the risk of unauthorised access.

###### HOW (specific steps/approach)
1. **Create a controlled issuance transaction** in the identity lifecycle/identity and access management (IAM) workflow system. Use workflow stages that match the required order, for example: `Submitted → Registration Authority Approved → IAM Director Authorised → Ready for In-person Issuance → Issued/Closed`.
2. **Enforce the required order in the workflow**: prevent any move into `Ready for In-person Issuance` (and prevent any issuance action) unless a **registration authority approval record** exists and is time-stamped **before** the issuance event for the same person/request.
3. **Enforce IAM director authorisation**: require an explicit authorisation step by the **IAM director** (or an approved delegate role if your governance allows delegation). This authorisation must be linked to the **same request/ticket and the same person**. Block issuance if authorisation is missing, expired, or does not match the same person/request.
4. **Restrict issuance staff tools**: configure issuance consoles/queues so issuers can only work on items that are in `Ready for In-person Issuance`. Any attempt to bypass the process must be technically prevented (for example, through application programming interface (API) and user interface checks) and must be logged.
5. **Record evidence that can be audited at handover** (for the same issuance transaction), including:
   - confirmation of in-person handover (desk attendance/recipient verification evidence),
   - recipient identity check evidence at the point of issuance,
   - scanned and recorded card serial number/batch/model,
   - PIN delivery confirmation recorded as part of the same issuance event reference.
6. **Limit the authenticator types**: keep an approved catalogue of the specific **FIPS 140-2 validated** PIV smart card models/batches, and require issuers to select/scan from this catalogue during issuance.

###### WHO
- **IAM Director**: provides explicit authorisation for each issuance transaction.
- **Registration Authority**: performs identity checks and records formal approval.
- **IAM/Identity Operations (issuance team)**: carries out in-person handover using the workflow-controlled tools.
- **IAM/Platform Engineer**: implements workflow rules, technical enforcement, and audit logging.

###### Acceptance criteria
- No issuance transaction can reach `Ready for In-person Issuance` (or perform issuance) unless **registration authority approval exists and is earlier than the issuance event** for the same person/request.
- No issuance can occur unless **IAM director authorisation** exists and is explicitly linked to the same person/request.
- Issuance staff can only access and act on items that have been approved by the workflow; any bypass attempts are blocked and logged.
- For each issued card, audit records show: in-person handover confirmation, recipient verification evidence, card serial number/batch/model, and PIN delivery confirmation linked to the same issuance reference.
- Only approved **FIPS 140-2 validated PIV card types** from the configured catalogue can be issued.

###### Actions Required for Compliance

- [ ] Define the stages (states) and the allowed moves (transitions) for the issuance process: **Registration Approved → IAM Director Authorised → Ready for In-person Issuance**.
- [ ] Set up technical blocking rules so that issuance actions are refused unless there is an approval from the registration authority, and that approval has a timestamp recorded before the issuance event for the same subject or request.
- [ ] Require explicit authorisation from the identity and access management (IAM) director as a mandatory, subject/request-specific step. Do not issue anything if the authorisation is missing, has expired, or does not match the request.
- [ ] Limit issuance staff access to the user interface (UI) and application programming interface (API) so issuers can only process items that are in the queue approved for the workflow.
- [ ] Set up audit logging and tamper-proof records for approval actions, attempts to issue documents, and evidence of in-person handover, all linked to one unique issuance reference.
- [ ] Create and enforce an approved list of FIPS 140-2 validated personal identity verification (PIV) card models and batches, and require staff to select from this list when issuing cards.


---

#### IA-5.17 — Presentation Attack Detection for Biometric Authenticators (Enhancement)

This requirement is about protecting biometric sign-ins (for example, fingerprint or facial recognition) from fake attempts, such as a photo, video, copied fingerprint, or a high-resolution image designed to trick the device. Without this protection, someone could get past identity checks by using an imitation instead of a real person, which could lead to unauthorised access to systems and potential harm to customers, staff, and the business.

To meet this expectation, the organisation must include presentation attack detection in biometric sign-in and ensure it cannot be switched off or bypassed for real use. Where the biometric method supports it, the system must check that a live person is present, record the results of those checks in audit records, and keep those records available for review.

The organisation must also document how the protection works, how it is configured, and who is responsible for enabling, maintaining, and monitoring it, so the approach stays consistent and accountable over time.

##### Enforce PAD-required biometric authentication with auditable outcomes

- Category: Software
- Priority: Critical

###### WHAT
Add presentation attack detection (PAD) / liveness detection as a required, non-bypassable part of biometric-based sign-in, and make sure PAD results are saved for audit and review.

###### WHY (control requirement)
IA-5(17) Enhancement requires the organisation to “employ presentation attack detection mechanisms for biometric-based authentication”. Guidance notes that biometric features are not secrets and can be copied or reproduced (for example, photos or video, lifted fingerprints, or high-resolution iris patterns). PAD (including liveness detection) helps prevent spoofing by making it hard to create fake materials intended to trick the biometric sensor.

###### HOW (specific steps/approach)
1. **Choose biometric sign-in devices that support PAD** (face, fingerprint, iris) and confirm they support liveness/PAD beyond basic “quality checks”.
2. **Make PAD mandatory in the sign-in process**: only allow biometric verification when the PAD result shows the presentation is genuine (for example, pass/success). Remove or disable any live “demo/test/compatibility” options and block any fallback that would accept biometric verification without PAD.
3. **Manage and lock PAD settings centrally** using the organisation’s enterprise management tools for the biometric devices/software development kit (for example, device management/configuration management tools). Use version-controlled, peer-reviewed configuration templates so PAD cannot be changed quietly on individual devices.
4. **Record PAD results with every sign-in attempt**: ensure each authentication attempt produces a PAD outcome (pass/fail/detected) and sends it to the application that relies on it, and then into the security information and event management (SIEM) and logging system.
5. **Make audit and review practical**: keep PAD result logs according to the organisation’s audit retention requirements; set up alerts for repeated PAD failures or patterns that may indicate an attack.
6. **Document PAD behaviour and ownership** in system design and security planning documents: which biometric types are protected, what PAD does (liveness/attack detection), what decision is expected when an attack is suspected (deny/fail), and who is responsible for enabling, maintaining, and monitoring PAD.

###### WHO (role responsible)
- **Identity and Access Management (IAM) lead**: sets the PAD-required sign-in policy and acceptance criteria.
- **Security engineering / platform security**: ensures PAD settings are locked down and included in audit logging.
- **Device/endpoint management team (or operational technology (OT)/information technology (IT) operations team, where applicable)**: deploys and maintains the PAD configuration templates.
- **Security Operations Centre (SOC)/SIEM operations**: monitors PAD result events and investigates alerts.

###### Acceptance criteria
- In production, biometric sign-in attempts are **approved only when the PAD result is pass/success**; any PAD fail/detected result must cause sign-in to fail.
- There is **no operationally available bypass** (no fallback that allows sign-in using biometric verification without PAD) for real user sign-in.
- PAD results (pass/fail/detected) are **captured for every attempt** and are available in audit logs/SIEM with enough identifiers (user/device/session/time).
- PAD settings are **managed centrally, version-controlled, and enforced** so unauthorised changes can be detected and require a controlled change process.
- System design/security documentation exists that explains how PAD works, how it is configured, and names responsibilities for enabling, maintaining, and monitoring PAD.

###### Actions Required for Compliance

- [ ] Confirm that each biometric authenticator software development kit (SDK) supports presentation attack detection (PAD) or liveness detection (not just checks on sensor quality) and record which PAD outcomes are supported.
- [ ] Set the authentication rules so that biometric verification is only accepted when it meets the required “presentation attack detection” (PAD) checks, and block access if the PAD result is “fail” or if an attack is detected.
- [ ] Disable or remove any production fallback, demo, or test modes that could bypass privileged access during real sign-in.
- [ ] Centralise personal access device (PAD) settings using the enterprise management platform, using templates that are version-controlled and reviewed by peers, with controlled change processes.
- [ ] Set up event logging so that every login attempt records the result of the presentation attack detection (pass, fail, or detected), along with the relevant user, device, and session details, and sends this information to the security information and event management (SIEM) system.
- [ ] Set up and run security monitoring alerts to detect repeated personal access device (PAD) failures and possible spoofing patterns, and document who is responsible for investigating (triaging) each alert.
- [ ] Update the system design and security planning documents to explain the behaviour of the platform access daemon (PAD), how it is configured, and the named responsibilities for enabling it and monitoring it.


---

#### IA-5.18 — Password Managers (Enhancement)

This requirement is about using a trusted password vault to create and securely store every user’s passwords, so people do not have to reuse the same password or keep it in unsafe places. Without this, users may choose weak or repeated passwords. If a password collection is stolen or exposed, attackers could use it to try to break into many accounts at the same time.

To meet this expectation, the organisation must use an approved enterprise password manager to generate and manage unique passwords for every user account in scope. It must also protect the stored passwords by encrypting them while they are stored, restricting access and use to authorised personnel only, and keeping the password collection offline using tokenised storage so it is not continuously available online.

The organisation should also be able to demonstrate that only the right people can retrieve passwords, that access is properly restricted and regularly reviewed, and that the offline token approach is in place and can be traced.

##### Approved password manager with encrypted vault and offline token access

- Category: Software
- Priority: Critical

###### WHAT
Set up an approved enterprise password manager to create and manage unique passwords for every in-scope user account. Keep the password store secure by encrypting it and saving it offline using tokenised storage. Limit password access and use to authorised personnel only.

###### WHY (control requirement)
IA-5(18) enhancement guidance says that when static passwords are used, organisations should use a password manager to automatically create and store strong, different passwords, while reducing the risk that an attacker could target the password collection. It also requires protecting the password collection by **encrypting the passwords** (see IA-5(1)(d)) and **storing the collection offline using a token**. Organisation-defined requirements also call for an **approved enterprise password manager**, plus defined controls for encryption while stored, restricting access to authorised personnel, and offline tokenised storage.

###### HOW (specific steps/approach)
1. **Select and approve** an enterprise password manager platform, and formally record it as the organisation-approved solution for creating and managing unique passwords.
2. **Define and enforce scope**: list all in-scope accounts that use static passwords (for example, employee and contractor accounts, privileged operator accounts, and any application or service accounts where static credentials are used). Ensure onboarding and credential changes create and rotate credentials through the password manager rather than manual entry.
3. **Set up encryption while stored** for the password vault/storage, and ensure encryption keys are protected using the organisation’s approved key management approach (for example, key management service (KMS) or hardware security module (HSM) support where available).
4. **Restrict vault access to authorised personnel only**: set up role-based access with the minimum necessary permissions (for example, separate “view/retrieve” access from administrative functions), connect to the organisation’s identity system, and require strong authentication for vault access.
5. **Use offline tokenised storage/access**: configure the vault unlock and retrieval process so the password collection is not kept continuously online. For example, vault access may require an offline token device, or an approved offline export/import process stores the encrypted password collection on token media and only makes it available during controlled retrieval windows.
6. **Enable auditability**: ensure the system records every vault unlock, password retrieval, export, and failed access attempt, and send these logs to the organisation’s security information and event management (SIEM) system for monitoring and evidence.

###### WHO (role responsible)
- **Security Architect / IAM Lead**: define the scope, access model, and approval for the password manager.
- **Platform/Identity Engineering**: configure encryption, identity integration, and vault access roles.
- **Privileged Access Management (PAM) / Security Operations**: implement the offline tokenised access process and confirm audit logging and monitoring are in place.
- **Application Owners / System Owners**: ensure in-scope accounts are onboarded and credentials are managed only through the password manager.

###### Acceptance criteria
- The organisation can show that the approved enterprise password manager is used to create and manage unique passwords for **all in-scope user accounts**.
- The password vault/storage is configured for **encryption while stored**.
- Vault access is limited to **authorised personnel only** using minimum-permission roles integrated with the organisation’s identity system.
- The password collection is stored and protected using an **offline tokenised** mechanism (not kept continuously online), and the process is enforced operationally.
- Audit logs exist for vault unlock, retrieval, and export actions, and are available for review in the SIEM (or an equivalent logging system).

###### Actions Required for Compliance

- [ ] Approve and document the organisation-approved password manager for generating and managing unique passwords.
- [ ] Create an up-to-date list of in-scope accounts and make sure new accounts are set up through onboarding, so that all in-scope accounts that use static passwords are managed using the password manager.
- [ ] Turn on and confirm encryption when data is stored for the password vault/storage, and make sure the encryption keys are protected using the organisation-approved key management approach.
- [ ] Set up vault access with the minimum permissions needed, and link vault access to your organisation’s identity system so only authorised staff can retrieve passwords.
- [ ] Set up and test offline access to a tokenised vault (using a token device or a controlled offline export/import process) so that password collection is not kept continuously online.
- [ ] Turn on audit logging for vault unlocking, data retrieval, data export, and failed access attempts, and send those logs to the security information and event management (SIEM) system as evidence.


---

### IA-6 — Authentication Feedback (Control)

This requirement is about making sure that, when people log in, nothing they type and no on-screen login messages can accidentally reveal secret information to someone watching. Without this, an unauthorised person could learn a password or other login secret by looking over someone’s shoulder, or by capturing what briefly appears on the screen, and then use it to gain access.

To meet this expectation, the organisation must clearly document how login feedback is hidden, set out the exact approach to use (for example, showing typed passwords as obscured symbols and keeping any temporary on-screen feedback very brief), and choose the method based on the device used and the level of screen risk, while balancing the chance of user input mistakes.

The organisation must ensure this behaviour happens at every step of authentication, configure systems so it works as described, keep evidence and audit records showing it is enabled, and assign named people to implement and maintain it.

##### Obscure authentication feedback via central IdP and UI masking

- Category: Software
- Priority: High

###### WHAT
Implement authentication screen behaviour so that, during every authentication step (password entry, multi-factor authentication (MFA) or “step-up” prompts, and re-authentication), the system hides any on-screen authentication information that could be used by unauthorised people watching the screen (for example, show typed secrets as asterisks/bullets/dots and never show the real text). Any on-screen feedback that can be read should be shown only briefly and must not reveal sensitive details.

###### WHY (control requirement)
IA-6 requires that authentication feedback is obscured so it does not provide information that could help unauthorised individuals compromise authentication. The guidance specifically highlights the risk of “shoulder surfing” (someone watching over your shoulder) and states that obscuring feedback includes showing asterisks when users type passwords and/or showing feedback only for a very limited time before hiding it.

###### HOW (specific approach)
1. **Use the enterprise identity provider (IdP) / single sign-on (SSO) as the single route for authentication**, so password/secret entry is handled by one approved and governed authentication screen, rather than custom screens in individual applications.
2. **Mask all secret input fields** on the IdP-hosted login pages and in any embedded or software development kit (SDK)-based authentication components:
   - Set password/secret fields to display masked characters (for example, bullets/dots) and never display the real text.
   - Ensure error messages are generic (for example, do not reveal whether a username exists, password length, or any part of a password).
3. **Cover every authentication step**:
   - Apply the same masking rules to multi-factor authentication (MFA), step-up, and re-authentication screens (including any intermediate prompts).
   - Disable or tightly control any “show password” or “reveal” options; if such functionality exists, it must be formally risk-assessed and governed (otherwise do not enable it).
4. **Choose the best obscuring approach based on device risk**, using organisation-defined device categories:
   - For large monitors/desktops: prioritise resistance to shoulder surfing (no real-text echo; avoid detailed “near miss” feedback).
   - For small screens/mobile: keep masking enabled, while ensuring the interface does not cause excessive input errors (for example, no real-text echo; keep feedback non-sensitive).
5. **Limit how long authentication feedback is visible**:
   - Ensure any temporary status text that could be interpreted as authentication information is non-sensitive and shown only briefly.
6. **Make the behaviour auditable and hard to break**:
   - Store IdP/application authentication configuration as code where supported.
   - Add automated checks in continuous integration and continuous delivery (CI/CD) to confirm masking settings and generic error templates are in place.
   - Enable and keep relevant IdP/application audit logs for authentication events, so there is evidence that the configured authentication process is being used.

###### WHO
- **Identity and Access Management (IAM) / Identity Engineering Lead**: owns identity provider (IdP) / single sign-on (SSO) configuration standards and enforcement.
- **Application Owner / Engineering Manager**: ensures application authentication integrations use the approved IdP flows and do not override masking behaviour.
- **Security Assurance / Compliance Engineer**: sets acceptance criteria, reviews evidence, and checks that regression controls work.

###### Acceptance criteria
- During password entry and all subsequent authentication steps (multi-factor authentication (MFA) / step-up / re-authentication), secret input is shown only as masked characters (no real-text echo).
- Authentication error/feedback messages do not reveal information that could help unauthorised people compromise authentication (for example, no password fragments, no password-length hints, no character hints).
- Any readable authentication feedback that could be misused is non-sensitive and is not left visible beyond a very short time.
- Evidence exists that the approved IdP/SSO configuration is deployed in production (configuration export and/or configuration-as-code artefacts) and that automated regression checks are run.
- Test results (manual or automated user interface tests) confirm masking behaviour across supported client types (web and mobile at minimum) and across multi-factor authentication (MFA) / step-up flows.

###### Actions Required for Compliance

- [ ] Standardise an approved sign-in screen pattern that hides secret input (for example, using asterisks, bullets, or dots) and uses generic error messages.
- [ ] Set up the organisation’s identity provider (IdP) and single sign-on (SSO) hosted login, including multi-factor authentication (MFA) and any “step-up” checks, so that all secret information is hidden and any options that would display or echo secrets in plain text are turned off.
- [ ] Update the application sign-in integrations to use the approved identity provider (IdP) methods (hosted sign-in pages or approved software development kit (SDK) components), without changing or overriding the existing masking behaviour.
- [ ] Set up checks for continuous integration and continuous delivery (CI/CD) configurations to confirm that masking settings and generic feedback templates stay enabled after any changes.
- [ ] Enable and keep identity provider (IdP) and application audit logs for authentication events, so you have evidence that the configured authentication process is active in live (production) systems.
- [ ] Run user interface tests on all supported client types (web and mobile) to confirm that, at every step of the sign-in process, no plain text authentication details are shown.


---

### IA-7 — Cryptographic Module Authentication (Control)

This requirement is about making sure only the right people can access the organisation’s cryptographic tools and use them only for the tasks they are authorised to do. Without this, someone could pretend to be an authorised operator or take on a role they are not permitted to use. This could result in unauthorised access to sensitive protection functions and misuse of cryptographic services.

To meet this expectation, the organisation must set clear, documented rules for how it checks identity and permissions when accessing cryptographic modules. These checks must follow all relevant laws, government directions, organisational policies, regulations, and recognised security standards.

The organisation must explain how these checks work in its system security plan and written procedures. It must also document the authentication approach and the role and permission checks in its system design and configuration records. Finally, it must keep audit records showing what identity and permission decisions were made and whether access was granted or denied.

##### IAM-gated authentication and role verification for crypto module access

- Category: Software
- Priority: Critical

###### WHAT
Set up authentication for people who operate the cryptographic module (or its access broker, application programming interface (API), or command-line interface (CLI)) and confirm that the authenticated operator is authorised to take on the requested role and carry out the requested cryptographic services.

###### WHY (control requirement)
IA-7 requires authentication mechanisms for a cryptographic module that meet the requirements of applicable laws, executive orders, directives, policies, regulations, standards, and guidance. The guidance also expects authentication to (1) confirm the identity of the operator accessing the module and (2) confirm the operator is authorised to take on the requested role and perform the services allowed for that role.

###### HOW (specific approach)
1. **Define authentication and role/permission checks** in an IA-7-aligned policy and system documentation: state the identity source, the authentication method(s) (for example, multi-factor authentication (MFA) that is resistant to phishing), and the authorisation decision rules (role-to-service mapping) used to control access to the cryptographic module.
2. **Require authentication through the organisation’s central identity service**: require operators to authenticate to an **access broker** (or directly to the cryptographic module interface if it supports this) using the organisation’s approved identity provider (IdP) and multi-factor authentication (MFA) requirements.
3. **Check authorisation for each requested cryptographic service**: use role-based (or attribute-based) checks so the broker/module only allows cryptographic actions when the authenticated identity is mapped to the requested role(s), and the requested service is permitted for that role.
4. **Apply extra protection for sensitive roles**: apply policy conditions (for example, device compliance, session risk, location, and limits on privileged access) and require stronger “step-up” authentication for high-risk or high-privilege cryptographic services.
5. **Create audit records for authentication and authorisation outcomes**: record the operator identity, role requested, cryptographic service used, authentication method used, and the authorisation decision (granted/denied), including timestamps; send these records to security information and event management (SIEM) for retention and review.
6. **Document and run the process operationally**: keep procedures for requesting roles, handling access denials, and managing exceptions; ensure the system security plan and configuration records reference the implemented authentication and authorisation controls.

###### WHO (roles responsible)
- **Security Architect / Identity and Access Management (IAM) Lead**: define IA-7 policy requirements, role/service mapping, and conditional access rules.
- **Application/Platform Owner**: implement the access broker/module integration and enforce service-level authorisation.
- **Privileged Access Management (PAM) / Identity Team**: configure identity provider (IdP) multi-factor authentication (MFA), conditional access, and identity-to-role mappings.
- **Security Operations Centre (SOC) / Security Operations**: verify logging, monitor events, and support collection of audit evidence.

###### Acceptance criteria
- Access to the cryptographic module interface (or access broker) requires the approved enterprise identity and the approved multi-factor authentication (MFA) method(s).
- For every cryptographic service request, the system checks that the authenticated operator is authorised for the requested role and service; unauthorised requests are denied.
- Audit logs exist and show, for each attempt: operator identity, role requested, cryptographic service used, authentication outcome, and authorisation decision (granted/denied).
- The system security plan and configuration/design documentation clearly describe the authentication mechanism and the role/permission verification rules used for cryptographic module access.
- Conditional access and step-up authentication are applied for sensitive roles/services as defined in the IA-7 policy.

###### Actions Required for Compliance

- [ ] Create an IA-7 authentication and role/permission policy for access to cryptographic modules, including a compliance cross-reference to the applicable requirements.
- [ ] Set up an access broker (or integrate with the module interface) that requires identity provider (IdP) sign-in and enforces phishing-resistant multi-factor authentication (MFA) for operators.
- [ ] Set up role-based permissions for each cryptographic service and apply those permissions to every request for a cryptographic service.
- [ ] Use conditional access and step-up authentication for privileged and sensitive cryptographic roles and services.
- [ ] Enable audit logs for sign-in and access decisions (who the user is, the role requested, which service was called, and whether access was granted or denied) and send them to security information and event management (SIEM) with data retention.
- [ ] Update the system security plan and the configuration and design records to document the authentication method and the rules used to decide authorisation.
- [ ] Publish clear operating procedures for requesting roles, handling access denials, and managing exceptions, and check during testing that these procedures are followed.


---

### IA-8 — Identification and Authentication (Non-organizational Users) (Control)

This requirement is about making sure that any outside user, or any automated service acting on behalf of an outside user, is correctly identified and verified before being allowed into your systems. Without this, the wrong person or an unauthorised process could gain access, pretend to be a partner or supplier, or carry out actions that are difficult to trace and investigate—putting sensitive information and business operations at risk.

To meet this, the organisation must clearly define which users and processes count as “non-organisational”, document any specific approved exceptions to the normal identification and verification rules, and set out the approach in written policies, privacy and security planning, and step-by-step procedures. The system must be configured so that each outside user and each acting process has its own distinct identity, is blocked if identification or verification is missing or fails, and records what happened so the organisation can review it and demonstrate compliance later.

##### IdP-gated unique authentication for external users and workload identities

- Category: Software
- Priority: Critical

###### WHAT must be done
Put in place a single, enforceable method that **uniquely identifies and verifies (authenticates) non-organisational users and the processes acting on their behalf** before they can access the application, with **access blocked if authentication fails** (except for exceptions that are explicitly documented).

###### WHY (control requirement)
NIST IA-8 requires that non-organisational users/processes (meaning those not covered by IA-2) are **uniquely identified and successfully authenticated** for any access other than the specific cases already identified and documented in AC-14. The guidance also expects organisations to consider security, privacy, scalability, and practicality, and to ensure the approach can be audited.

###### HOW (specific steps/approach)
1. **Define the non-organisational identity scope and exceptions**: Keep a register or taxonomy of non-organisational users (for example, partners, suppliers, contractors) and non-human, automated process identities (workloads acting on their behalf). Link any exceptions to the organisation’s documented access exceptions (aligned to AC-14) so they are clear, explicit, and reviewable.
2. **Verify unique human users using the enterprise identity provider (IdP)**: Connect the application to the organisation’s central identity provider (IdP) using single sign-on (SSO). Require **phishing-resistant multi-factor authentication (MFA)** (for example, FIDO2/passkeys or certificate-based MFA where feasible) for non-organisational human users. Make sure the application only accepts sessions/tokens that the IdP has issued after successful authentication.
3. **Verify unique automated processes/workloads**: For automated processes acting on behalf of non-organisational users, use **workload identities** (service principals/application registrations) with **certificate-based or key-based client authentication**, and short-lived tokens where supported. Do not allow shared accounts or long-term shared passwords/secrets for these workloads.
4. **Allow access only after successful authentication**: Configure the application and upstream components (application programming interface (API) gateway / reverse proxy / application middleware) so that **no unauthenticated requests, or requests with failed authentication, can reach protected parts of the application**. Use conditional access rules (for example, based on device, network, location, or risk) to reduce risk further while keeping the “block by default” approach.
5. **Record authentication outcomes for auditing**: Ensure audit logs record, at minimum, the **unique identity** (human identity or workload identity), **authentication method and result**, **time**, **resource accessed**, and **source** (where available). Send these logs to the security information and event management (SIEM) system for retention and correlation.

###### WHO (role responsible)
- **Application Owner / Security Architect**: owns the IA-8 design, alignment of the exception register, and the evidence needed for audits.
- **Identity and Access Management (IAM) Lead**: configures IdP authentication and conditional access for non-organisational identities.
- **Platform/DevOps Engineer**: implements enforcement at the application/API gateway level and sets up logging integration.
- **Security information and event management (SIEM)/Monitoring Lead**: ensures authentication events are routed correctly, retained for the required period, and alerts are created for authentication failures.

###### Acceptance criteria (verifiable)
- Non-organisational human users can access the application **only** through IdP-authenticated single sign-on (SSO) sessions; direct or anonymous access to protected endpoints is blocked.
- Non-organisational automated processes use **unique workload identities** (no shared accounts) and authenticate using certificate/key-based methods; requests without valid workload authentication are blocked.
- Authentication failures (including missing or invalid tokens) result in **access being blocked** and are recorded in audit logs with the unique identity and the failure outcome.
- An **exception register** exists, and every exception is explicitly documented and traceable to the organisation’s documented access exceptions (aligned to AC-14).
- Audit logs include the unique identity, authentication result, and accessed resource, and are available in the SIEM for review.

###### Actions Required for Compliance

- [ ] Create and keep a record (register) of identities that are not part of the organisation (both people and automated systems/workloads), and document any exceptions that are aligned with AC-14.
- [ ] Set up the application and application programming interface (API) gateway so that every protected page or service requires an identity provider (IdP) issued token, and block any request that has no token or an invalid token.
- [ ] Require phishing-resistant multi-factor authentication (MFA) for all non-organisation human users in the identity provider (IdP), and require additional (step-up) MFA when accessing sensitive resources.
- [ ] Set up workload identity authentication for non-interactive processes by using unique application or service identities, authenticating with certificates, and using short-lived access tokens where supported.
- [ ] Disable or block shared accounts and service login details for access routes outside the organisation, and replace any old shared passwords or secrets by rotating them.
- [ ] Turn on and check audit logging for each unique user identity, the authentication method and result, and the resource that was accessed. Send the logs to the security information and event management (SIEM) system and keep them for the required retention period.


---

#### IA-8.1 — Acceptance of PIV Credentials from Other Agencies (Enhancement)

This requirement is about allowing entry only when people present official identity cards issued by other government organisations, and when your system checks those cards electronically and records the result. Without this, someone could enter buildings or access systems using a card that is not genuine, has been withdrawn, or is not allowed for your organisation. This could lead to unauthorised access and potential harm to people, information, and services.

To meet this expectation, your organisation must clearly state in its access rules that it will accept these external identity cards for both building entry and system access, but only when they meet the required standard. You must document how the electronic checking works, how access decisions are made, and what staff should do if a card cannot be verified.

Your systems must be set up to carry out the electronic check every time, and you must keep records showing the verification result, the card details used, and the permissions that allowed or blocked access.

##### Verify external-agency PIV (FIPS 201) before logical/physical access

- Category: Software
- Priority: Critical

###### WHAT must be done
Accept and electronically check Personal Identity Verification (PIV)-compliant credentials issued by other federal agencies (i.e., credentials that follow **Federal Information Processing Standards (FIPS) Publication 201** and related guidance) before granting **both electronic (logical) and on-site (physical)** access. Keep evidence that can be audited showing the result of the electronic check and the access authorisation decision.

###### WHY (control requirement)
This requirement, **National Institute of Standards and Technology (NIST) Information Assurance (IA)-8(1)** enhancement, means the organisation must **accept and electronically check** PIV credentials from external agencies. The guidance also explains that PIV credentials are issued by federal agencies that follow **FIPS Publication 201** and related guidelines. It further states that the trustworthiness of PIV card issuers is handled through authorisation using **Special Publication (SP) 800-79-2**.

###### HOW (specific steps/approach)
1. **Define acceptance in policy (logical + physical):** Update the organisation’s identification and authentication policy (and any physical access policy that covers badge/card use) to clearly state that external-agency PIV credentials are accepted **only** when they are PIV-compliant (**FIPS 201**) and are electronically checked before access is granted.
2. **Set up trust for external issuers:** For the authentication part that performs the check, configure the system so it trusts only approved external-agency PIV issuers (authorised under **SP 800-79-2**). Make sure certificate revocation checks (for example, **Certificate Revocation Lists (CRLs)** and **Online Certificate Status Protocol (OCSP)** where applicable) are enabled and treated as part of the decision to verify.
3. **Electronically verify every attempt:** Configure the electronic access process so that authentication uses a PIV-capable method (for example, smartcard software middleware, a PIV authentication gateway, or a federation “relying party” flow) that performs cryptographic verification of the credential and its certificates—not just “card was presented”. For physical access, configure the **Physical Access Control System (PACS)**, reader, and controller so the same electronic verification step is performed (or so it relies on an official upstream verification decision) before entry is unlocked/authorised.
4. **Use the verified identity to decide access (verified-then-authorised):** Ensure the access decision system (using **role-based access control (RBAC)** and/or **attribute-based access control (ABAC)**) uses **only** identity details that have been successfully verified (for example, mapped subject/issuer/unique identifier). Access decisions must depend on successful verification.
5. **Log and keep proof of verification and the access decision:** Turn on audit logging so that, for every access attempt, at minimum you record: the time of the attempt, the credential details used for verification (for example, issuer/serial/subject or an equivalent set), whether verification succeeded or failed, the access decision (granted/denied), and the basis for authorisation (for example, the outcome of role/group mapping). Send these logs to the **security information and event management (SIEM)** system and keep them according to the organisation’s log retention requirements.
6. **Define what happens when verification fails:** Create an operational procedure for what staff/system operators must do when verification fails (for example, deny access by default, record the event, and follow an escalation path for badge/card issues). Ensure the procedure covers both electronic and physical access processes.

###### WHO (role responsible)
- **Identity and Access Management (IAM) / Identity Architect:** updates policy, defines trust settings for external issuers, and defines how identity attributes are mapped.
- **Security Engineering / Platform Team:** implements the verification integration for electronic access and integrates with **PACS** for physical access.
- **Physical Security Lead:** ensures **PACS**, reader, and controller settings support electronic verification and the failure-handling process.
- **Security Operations Centre (SOC) / SIEM Administrator:** sets up audit logging, alerts, and log retention.
- **System Owner / Authorising Official:** approves trust decisions for issuers and approves how authorisation mapping is applied.

###### Acceptance criteria
- External-agency PIV credentials are accepted for both electronic and physical access **only** after successful electronic verification.
- Verification is cryptographic and includes issuer trust constraints and revocation checking as configured; presenting a card without verification does not grant access.
- For every access attempt, audit records exist showing the verification result and the resulting access decision, with credential identifier details sufficient to link records for audit purposes.
- Issuer trustworthiness/adequacy is authorised under **SP 800-79-2** (with documented trust configuration and approvals).
- Documented failure handling exists and is tested (deny-by-default behaviour with recorded evidence).

###### Actions Required for Compliance

- [ ] Update the identification and authentication policy to explicitly allow external-agency Personal Identity Verification (PIV) credentials for both logical access and physical access only after electronic verification has been completed.
- [ ] Document and get approval for decisions about which external agency can issue personal identity verification (PIV) credentials, in line with SP 800-79-2, and set up the relying party trust settings (trust anchors) accordingly.
- [ ] Set up the logical access sign-in process to verify the cryptographic Personal Identity Verification (PIV) credential on every attempt, including checking whether it has been revoked.
- [ ] Integrate public access control system (PACS) readers and controllers so that physical entry is allowed only after electronic verification (or after a verification decision made by an authorised upstream system).
- [ ] Set up authorisation mapping that uses only verified identity information and only allows access after the identity has been verified.
- [ ] Enable audit logging for every attempt. Record the credential identifier details used, the verification result, and whether access was granted or denied. Send these records to security information and event management (SIEM) and keep them for as long as required by policy.
- [ ] Create and train an operational process for handling verification failures, using a “deny by default” approach, escalating when needed, and capturing supporting evidence.


---

#### IA-8.2 — Acceptance of External Authenticators (Enhancement)

This requirement is about making sure that, when people sign in to your public services using an external sign-in provider, you only allow providers that meet the required standard for checking identity. If you do not, attackers could persuade your organisation to trust an unreliable or unsafe sign-in method, which could lead to unauthorised access, fraud, or the exposure of sensitive information.

To meet this expectation, your organisation must set up its public-facing systems to accept only external sign-in options that have been shown to meet the required standard. You must also keep a documented, maintained list of every external sign-in provider you have approved for use. This list must be detailed enough to identify each provider and where it is used. It must be kept up to date whenever providers are added, changed, or removed, and you must record clear evidence showing why each approved provider is acceptable.

##### Policy-as-code gate for approved external authenticators

- Category: Software
- Priority: Critical

###### WHAT
Put in place a controlled approval process so that public-facing sign-in only works with external sign-in providers that have been explicitly approved as meeting the required assurance standards (as set out in *NIST SP 800-63B*). Use the organisation’s **Accepted External Authenticators** list as the single source of truth, and enforce it automatically through “policy-as-code” in the deployment pipeline.

###### WHY (control requirement)
The *IA-8(2) (Acceptance of External Authenticators)* enhancement requires that, for systems available to the public, the organisation accepts **only** external sign-in providers that comply with *SP 800-63B*. It also requires that approved providers meet or exceed the minimum Federal Government-wide requirements for technical capability, security, privacy, and organisational maturity. This means the approval list must be kept up to date with supporting evidence, and it must prevent accidental or one-off approvals.

###### HOW (specific steps/approach)
1. **Create a central registry** (for example, a ticketing-backed configuration database) called **Accepted External Authenticators**. At a minimum, each entry must include: the external authenticator/provider identifier, authenticator type (for example, OpenID Connect (OIDC) / Security Assertion Markup Language (SAML) / social federation), the target assurance level, the public service or application scope(s) where it can be used, and a reference to evidence showing it meets *SP 800-63B* expectations.
2. **Define an evidence checklist (schema)** for each registry entry (for example, an assurance-level mapping or attestation reference, a compliance statement, or an equivalent documented basis). Make this mandatory for any new or changed entry.
3. **Implement policy-as-code** in continuous integration and continuous delivery (CI/CD) so that any change to public sign-in settings (for example, identity provider (IdP) federation settings, relying-party trust, enabled “Sign in with …” options, callback or issuer settings) is generated and checked using the registry.
4. **Add a deployment gate**: builds and releases must fail if the identity provider (IdP) or application configuration would enable an external authenticator that is not listed in the registry for the relevant application scope, or if the registry entry is missing required evidence fields.
5. **Enforce governance**: restrict updates to the registry to authorised security or identity and access management (IAM) approvers. Require an approval record (approver identity, date, and evidence reference) before a registry entry can be used for deployment.
6. **Record audit evidence automatically**: save pipeline outputs showing (a) the registry version used, (b) the exact configuration generated, and (c) the approval record IDs linked to each accepted external authenticator.

###### WHO
- **Identity and Access Management (IAM) / Security Engineering Lead**: owns the registry structure, evidence checklist, and approval process.
- **Security / IAM Approvers (authorised role)**: approve new or changed external authenticators and confirm evidence is complete.
- **Platform / DevOps Engineering**: implements the policy-as-code checks and deployment gates.
- **Application Owner**: ensures application scope mappings are correct and requests changes through the approved process.

###### Acceptance criteria
- For every public-facing application scope, the enabled external authenticators in the identity provider (IdP) or application configuration **match exactly** the entries in the **Accepted External Authenticators** registry for that scope.
- No release can be deployed if it would enable an external authenticator that is not in the registry, or if the registry entry lacks required evidence fields.
- Each accepted external authenticator has an auditable approval record and evidence reference, and the deployment pipeline keeps traceability to the registry version and approval record IDs.
- Registry changes require authorised approval and cannot be bypassed by direct configuration changes in release pipelines.

###### Actions Required for Compliance

- [ ] Create an **“Accepted External Authenticators”** register that lists each external authentication provider’s identifier, the required assurance level, which applications each provider can be used for, and references to supporting evidence.
- [ ] Define a required evidence format that matches the assurance expectations in NIST Special Publication 800-63B for every registry entry.
- [ ] Set up “policy as code” in continuous integration and continuous delivery (CI/CD) to automatically create and check identity provider (IdP) and application authentication settings from the registry.
- [ ] Set up deployment gates so that a release fails if, for the intended scope, the required external authenticators are not listed in the registry or there is no supporting evidence that they are present.
- [ ] Limit permission to update the registry to authorised identity and access management (IAM) and security approvers, and require that approval details are recorded as metadata.
- [ ] Enable audit logging to record the registry version, the approval record identifiers, and the exact configuration items that were deployed.


---

#### IA-8.4 — Use of Defined Profiles (Enhancement)

This requirement is about making sure your organisation uses a consistent, agreed set of proven rules for checking people’s identities and managing their accounts, so different services can work together reliably. Without this, the wrong people could gain access, accounts might not be created or disabled correctly, and partners or new systems may not connect smoothly—raising the risk of fraud, data exposure, and operational disruption.

To meet this expectation, the organisation must adopt and use defined identity-management profiles based on the National Institute of Standards and Technology (NIST) Special Publication 800-63A, 800-63B, and 800-63C, OpenID Connect (OIDC) and OAuth 2.0, Security Assertion Markup Language (SAML) 2.0, System for Cross-domain Identity Management (SCIM) 2.0, and the NIST 800-53 Revision 5 identity assurance mappings. It must then configure and run its identity and authentication, account handling, and related system features so they match those profiles.

The organisation must also be able to demonstrate this through clear internal documents covering its identity and authentication policy, system security plan, system design, the specific system settings used, and audit records showing relevant events and results. These documents must also name the responsibilities of the teams that operate, develop, secure, administer, and manage accounts.

##### Profile-conformant IAM configuration for app and APIs

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up and run the application’s identity management connection (how users are identified, how they prove who they are, and how accounts are created and managed) so it follows the organisation’s identity management profiles {{ insert: param, ia-08.04_odp }}. Make sure the organisation can prove this using: policy documents, the system security plan/scope, system design documents, configuration settings, and audit evidence.

###### WHY (control requirement)
IA-8(4) requires the application to follow the defined identity management profiles for identity management {{ insert: param, ia-08.04_odp }}. The guidance also expects that open identity management standards are checked and scoped to confirm they are suitable and work with each other, considering relevant laws, directives, policies, regulations, standards, and guidance.

###### HOW (specific steps/approach)
1. **Create a profile-to-implementation mapping** for this application covering: identity assurance mappings from NIST Special Publication 800-63A/B/C, OpenID Connect (OIDC) and OAuth 2.0, Security Assertion Markup Language (SAML) 2.0, and System for Cross-domain Identity Management (SCIM) 2.0 behaviours. For each profile requirement, define the exact identity provider (IdP) and application settings needed (for example: multi-factor authentication (MFA) strength and “step-up” rules, session and re-check rules, required token/session details, redirect URI and signing requirements, SAML/OIDC protocol settings, and SCIM joiner/mover/leaver handling).
2. **Apply configuration that matches the profiles** in the enterprise identity provider (IdP) and the application integration:
   - Use OpenID Connect (OIDC) and OAuth 2.0 for application programming interfaces (APIs) and web where applicable (for example: authorisation code flow with Proof Key for Code Exchange (PKCE), strict redirect URI allowlisting, signed tokens, and required claims).
   - Use Security Assertion Markup Language (SAML) 2.0 for legacy enterprise applications where applicable.
   - Use System for Cross-domain Identity Management (SCIM) 2.0 for user lifecycle provisioning and role/group assignment, ensuring account creation, changes, and removal match the defined profiles.
3. **Record the conformance scope and approach** in the application’s System Security Plan (SSP) and System Design documents. Clearly state which profiles are included, which protocols are used (OIDC/SAML/SCIM), and how the application enforces or depends on the IdP to achieve profile-aligned behaviour.
4. **Keep configuration baselines that can be audited** (configuration management) for the IdP integration and SCIM endpoints/roles. This includes separating environments (production/test/development/disaster recovery) and keeping evidence of change control.
5. **Produce and keep audit evidence** from the IdP and application logs showing the relevant identification, authentication, and account-handling events and outcomes (for example: successful/failed logins with assurance-relevant context, multi-factor authentication (MFA) challenges, token/session issuance parameters, SCIM provisioning outcomes, and deprovisioning actions).
6. **Assign responsibilities** for meeting the profile requirements across operations, security, administrators, developers, and account provisioning processes. Ensure operational runbooks point to the profile mapping and the required evidence sources.

###### WHO (role responsible)
- **Identity and Access Management (IAM) / Identity Architect**: owns the profile-to-implementation mapping and conformance design.
- **Application Owner / Engineering Lead**: ensures the application integration settings and documentation reflect the mapping.
- **IdP/Platform Administrator**: implements and maintains the IdP and SCIM configuration baselines.
- **Security/Compliance Lead**: checks that the SSP/design/policy references the required profiles and that the audit evidence is complete.
- **Operations / Security Operations Centre (SOC)**: ensures logs are collected, kept, and monitored to meet the evidence requirements.

###### Acceptance criteria
- A documented mapping exists from each required profile element in {{ insert: param, ia-08.04_odp }} to the specific IdP/application/SCIM configuration settings.
- The application’s SSP and System Design documents clearly state the in-scope profiles and the enforcement/interoperability approach using OpenID Connect (OIDC) and OAuth 2.0, Security Assertion Markup Language (SAML) 2.0, and System for Cross-domain Identity Management (SCIM) 2.0 as applicable.
- Configuration baselines for the IdP integration and SCIM provisioning are implemented and managed through change/configuration management across environments.
- Audit logs provide evidence of profile-relevant identification/authentication and account lifecycle outcomes for the application, including provisioning and deprovisioning events.
- Named roles and runbooks show who is responsible for maintaining conformance over time.

###### Actions Required for Compliance

- [ ] Create a matrix that maps each user profile to the application’s configuration settings. Include how the application supports the National Institute of Standards and Technology (NIST) 800-63A, 800-63B, and 800-63C assurance levels, and how it behaves for OpenID Connect (OIDC), OAuth 2.0, Security Assertion Markup Language (SAML) 2.0, and System for Cross-domain Identity Management (SCIM) 2.0.
- [ ] Set up the organisation’s identity provider (IdP) and application connection settings to enforce the required user profile rules, including multi-factor authentication (MFA) and assurance level, when users must re-verify during a session, what information is included in tokens and session details, which connection methods are allowed, and controls on approved redirect addresses (redirect URI controls).
- [ ] Implement System for Cross-domain Identity Management version 2.0 (SCIM 2.0) provisioning so that new starters, internal moves, leavers, and account removals follow the agreed profiles and the defined rules for assigning roles and groups.
- [ ] Update the application security statement (SSP) and system design documents to clearly list the in-scope profiles, the protocols used, and how compliance is demonstrated.
- [ ] Set standard configuration settings and use a change-controlled deployment process for identity provider (IdP) integration and System for Cross-domain Identity Management (SCIM) endpoints across production (prod), testing (test), and disaster recovery (DR) environments.
- [ ] Turn on and keep audit logs for authentication events and account changes that are relevant to profiles, and check that the recorded evidence is complete by running test authentications and test System for Cross-domain Identity Management (SCIM) account lifecycle updates.


---

#### IA-8.5 — Acceptance of PIV-I Credentials (Enhancement)

This requirement is about allowing entry only to people who present identity cards or digital credentials that the organisation has officially trusted for the correct purpose. If this is not done, a system could wrongly accept a credential from the wrong issuer or under the wrong trust rules, which could allow unauthorised access to buildings, applications, or services.

To meet this requirement, the organisation must accept and check federated or public-key credentials only when the credential’s certificate rules match a specific, pre-approved Federal Bridge trust policy. That policy must be mapped and approved for the relevant United States Government relying parties.

The organisation must:
- document the rules for accepting and checking credentials;
- build these rules into the system settings and design;
- ensure the approach works for both physical access (for example, door entry) and logical access (for example, logging into systems);
- keep evidence that each accepted credential was actually verified;
- record the acceptance and verification events; and
- ensure the staff responsible for operations and security can explain and follow the process.

##### Enforce FBCA PIV-I certificate-policy allow-list at IdP

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation’s federation/identity provider (identity provider (IdP)) and authentication gateway to **only accept and verify federated or public key infrastructure (PKI) credentials when the presented X.509 certificate’s certificate policy matches an organisation-approved Federal Bridge Certificate Authority (FBCA) PIV-I certificate policy mapping and approval** (parameter: `ia-08.05_odp`).

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Information Assurance (IA)-8(5) requirement is that the organisation **accepts and verifies federated or PKI credentials that meet `{{ insert: param, ia-08.05_odp }}`**. The guidance states that PIV-I acceptance and verification depends on **PIV-I certificate policy mapping to the Federal Bridge (FBCA) PIV-I Certificate Policy**, and that relying parties can only trust policies that are **mapped and approved**.

###### HOW (specific steps/approach)
1. **Create and maintain an approved allow-list** of certificate policy identifiers (for example, certificatePolicy object identifiers (OIDs) or identifiers) that correspond to the **FBCA PIV-I certificate policy mapping and approval for Department of Defense (DoD) relying parties** (the value of `ia-08.05_odp`). Keep this under change control as the main reference for enforcement.
2. **Configure the IdP/federation gateway** to carry out full X.509 checks (certificate chain trust, validity period, and revocation handling where applicable) and to **read the certificate policy identifiers** from the presented credential.
3. **Use policy-gated acceptance**: the IdP must **block authentication** unless the extracted certificate policy identifiers match the approved allow-list for `ia-08.05_odp` (either an exact match or clearly defined equivalence rules, documented and approved).
4. **Record verification outcomes**: generate structured authentication and verification events showing (a) the certificate chain validation result, (b) whether the certificate policy matched or did not match, and (c) the final authentication decision. Send these events to security information and event management (SIEM) with correlation identifiers.
5. **Connect downstream logical access** so applications use the IdP’s authentication decision (so applications do not accept raw certificates on their own). For physical access, apply this approach only if the physical access control points or gateways use the same identity assertion from the IdP; otherwise, document the gap and implement a separate enforcement mechanism at the physical access integration point.
6. **Document the enforcement logic** in identification and authentication policy and in the system security plan and procedures. Include the accepted certificate policy identifiers, the verification steps, pass/fail criteria, and how exceptions are handled (who can approve changes to the allow-list).

###### WHO
- **Identity and Access Management (IAM) engineer / federation administrator**: implement IdP/gateway configuration and policy-gated enforcement.
- **Information Security / compliance owner**: approve the FBCA PIV-I certificate policy mapping, the allow-list, and the exception process.
- **Security operations (security operations centre (SOC) / SIEM engineer)**: check that logging, event structure, and alerting are correct.

###### Acceptance criteria
- Authentication attempts using PIV-I credentials with **certificate policy identifiers that do not match the approved `ia-08.05_odp` allow-list are blocked**.
- Authentication attempts with **matching certificate policy identifiers are allowed only if X.509 validation succeeds**.
- The IdP generates **audit-ready events** showing certificate policy match or mismatch and the final decision for each attempt.
- Downstream logical access (single sign-on (SSO)) depends on the IdP’s decision, with **no bypass path** that accepts raw PKI credentials without policy gating.
- Documentation exists describing the approved policy mapping, enforcement logic, and exception/change process.

###### Actions Required for Compliance

- [ ] Define and approve the Federal Bridge Certification Authority (FBCA) Personal Identity Verification (PIV) Identity (PIV-I) certificate policy identifier allow-list for `ia-08.05_odp` through the change control process.
- [ ] Configure the identity provider (IdP) or federation gateway to check that presented X.509 certificate chains are valid and to extract certificate policy identifiers from the credentials provided.
- [ ] Set up policy-controlled acceptance so authentication is refused unless the certificate policy matches the approved allow-list.
- [ ] Set up and test structured logging that records whether certificate policy matches or does not match, and the authentication decision, then send this information to security information and event management (SIEM).
- [ ] Update single sign-on (SSO) and application integration so that access is granted only when the identity provider (IdP) policy allows the authentication result.
- [ ] Document how the system security plan and authentication policy enforce requirements, the pass/fail criteria, and the process for exceptions or changes.


---

#### IA-8.6 — Disassociability (Enhancement)

This requirement is about stopping people being tracked across different organisations just because they use the same login details. Without it, a person’s identity information could be reused or quietly linked from one partner or service to another. This could enable unwanted profiling, loss of privacy, or misuse of personal data.

To meet this expectation, the organisation must configure its federated login service so that, for the same person, each external service (relying party) receives a different, hard-to-guess identifier. It must also ensure that identifiers and identity details cannot be linked back together across different organisations.

The organisation must share only the minimum identity information each relying party genuinely needs, and it must document what is shared and the reasons for those decisions.

The organisation must use privacy-protecting identifier mapping to prevent cross-party correlation, reflect this in system design and configuration, and keep evidence in audit and operational records showing that these settings continue to be correctly enforced over time.

##### Pairwise identifiers and blinded attribute release per relying party

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement disassociability for federated identity by ensuring that user details and the way identifiers are confirmed cannot be linked across different people, credential service providers, and relying parties. Specifically, for each relying party, **issue a unique, pairwise pseudonymous identifier**, **share only the minimum user attributes needed**, and use **cryptographic blinding for identifier mapping** so that cross-party linking is prevented.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Identity Assurance (IA)-8(6) enhancement requires: “Implement the following measures to disassociate user attributes or identifier assertion relationships among individuals, credential service providers, and relying parties: {{ insert: param, ia-08.06_odp }}.” The guidance explains that federated identity can increase privacy risk through tracking and profiling. It also explains that using identifier mapping tables or cryptographic techniques can reduce privacy risk by preventing credential service providers and relying parties from learning each other’s identity information, or by making identity attributes less visible to the parties that receive them.

###### HOW (specific steps/approach)
1. **Enable pairwise pseudonymous subject identifiers per relying party** in the federation/identity provider (IdP) layer (for example, SAML/OpenID Connect (OIDC) subject/`sub` equivalents) so the same user gets a different, non-obvious identifier for each relying party.
2. **Set per-relying-party attribute release rules** (deny-by-default) so each relying party receives only the minimum information it needs for authorisation and its business purpose. Avoid releasing stable identifiers or attributes that would allow linking across parties.
3. **Use cryptographic blinding for identifier mapping**: implement privacy-preserving identifier mapping so that any internal link between the organisation’s main (canonical) identity and the per-relying-party identifier cannot be used by other parties to link identities. Practically, this means using the IdP’s supported privacy features for pairwise identifiers and ensuring that any mapping mechanism is not exposed through token contents, metadata, or logs that relying parties can access.
4. **Apply the rules when tokens are issued**: configure the IdP/federation gateway so relying parties cannot request extra attributes beyond the approved per-relying-party set (for example, restrict scopes and claims, hard-code the allowed claim sets per relying party, and reject unauthorised claim requests).
5. **Record and prove the disassociability design**: keep design and configuration documentation showing (a) the pairwise identifier setup, (b) the per-relying-party claim sets, and (c) how cryptographic blinding/privacy-preserving mapping is achieved. Keep operational evidence (token issuance logs/audit events) showing that each relying party receives only the intended claims and pairwise identifier.

###### WHO (role responsible)
- **Identity and Access Management (IAM) Architect / Federation Engineer**: implement pairwise identifiers, per-relying-party claim policies, and token issuance enforcement.
- **Privacy Officer / Data Protection Lead** (or delegated governance): approve attribute minimisation decisions and the documented reasons.
- **Security Assurance / Compliance**: check the evidence, review change records, and confirm that auditing is possible.

###### Acceptance criteria
- For a test user, relying party A and relying party B receive **different pairwise subject identifiers** for the same user.
- Token responses (OpenID Connect (OIDC) / SAML assertions) to each relying party include **only the approved minimum claims** for that relying party; stable identifiers that enable cross-party linking are not released.
- The federation/IdP configuration shows that **identifier mapping is privacy-preserving/blinded**, so relying parties cannot link identities across relying parties using token contents or exposed mapping information.
- Evidence exists: configuration/design documentation and audit logs showing the relying party, the pairwise identifier, and the released claims match the approved per-relying-party policies.

###### Actions Required for Compliance

- [ ] Set up pairwise pseudonymous subject identifiers for each relying party in the identity provider (IdP) and federation configuration.
- [ ] Set up “deny by default” rules for each relying party to control which claims and attributes are released, using only the approved minimum set of claims.
- [ ] Set up token issuing so the allowed scopes and claims are limited, so relying parties cannot request unauthorised attributes.
- [ ] Ensure that cryptographic and privacy-protecting identifier mappings are not exposed through token contents, metadata, or logs that the relying party can access.
- [ ] Set up automated “configuration as code” and formal change control for pairwise and claim policies for each relying party.
- [ ] Collect and keep audit records of token issuance, including the relying party, the pairwise identifier, and the claims that were released.


---

### IA-9 — Service Identification and Authentication (Control)

This requirement is about ensuring that every service and application that provides web services, database query services, and connections between services proves its identity before it is allowed to communicate with devices, people, or other services. If this is not done, an attacker could pretend to be a trusted service, intercept or change information, or quietly connect unauthorised components that then gain access to systems and data.

To meet this expectation, the organisation must clearly define which services are included, create and maintain a written policy and step-by-step procedures for how each service is uniquely identified and checked, and record this approach in both the system security plan and the system design.

The system must use approved methods to confirm identity and origin, check those confirmations before allowing any communication, and ensure that any separate decision-making is used only to allow or block access. The organisation must configure the system to support this, keep audit records of the checks, and assign and oversee responsibilities so operational staff follow the procedures, developers implement them, and security staff review that the controls are working as intended.

##### mTLS service identities with pre-communication authentication gates

- Category: Software
- Priority: Critical

###### WHAT
Set up **unique, cryptographically verifiable identities** for **system services and applications** (web services, database query services, and inter-service APIs). Require **mutual authentication before any communication** is allowed to start.

###### WHY (control requirement)
NIST IA-9 requires that services and applications are **uniquely identified and authenticated before establishing communications** with devices, users, or other services/applications. The guidance also supports distributed designs where **identity/authentication checks are handled by a separate component**.

###### HOW (specific steps/approach)
1. **Define the IA-9 service scope**: create an authoritative service catalogue for the in-scope service types (web/API/database-query and inter-service API callers) for each environment (production, test, development, disaster recovery). Include service owners and communication routes.
2. **Issue unique service identities**: use a workload identity approach (for example, SPIFFE/SPIRE-style) or an equivalent enterprise service identity method, so each service instance has a **unique identity** and short-lived credentials/certificates.
3. **Enforce mutual Transport Layer Security (mTLS) at the communication boundary**: configure entry/exit gateways and service-to-service (east-west) connections to require **mutual TLS (mTLS)** with strict certificate checks (both server and client). Block by default when identity/authentication cannot be verified.
4. **Centralise the decision (separate decision-making)**: apply policy enforcement at the gateway/service mesh/API gateway so it checks identity/authentication and makes an **allow/deny** decision before forwarding traffic to the target service.
5. **Record audit evidence**: for every connection/request, log the calling service identity, certificate details (for example, subject/subject alternative name (SAN)/serial number and validity period), the enforcement decision (allow/deny), and denial reason codes. Send logs to security information and event management (SIEM) for retention and review.
6. **Operationalise lifecycle controls**: automate identity registration and certificate rotation through continuous integration/continuous delivery (CI/CD) and configuration management. Test revocation/rotation procedures (including disaster recovery scenarios).

###### WHO (roles responsible)
- **Application/Platform Engineering Lead**: implements service identity issuance and mutual TLS (mTLS) enforcement patterns.
- **Security Architect**: defines IA-9 scope, identity/authentication validation requirements, and audit expectations.
- **Network/Platform Operations**: runs gateway/mesh configuration, certificate rotation automation, and incident response for identity failures.
- **Security Monitoring/Security Operations Centre (SOC)**: ensures SIEM receives logs, supports alerting, and performs periodic review of denied/unknown identities.

###### Acceptance criteria
- Every in-scope service-to-service and client-to-service communication route is configured to require **mutual TLS (mTLS)** and blocks unauthenticated traffic (fails closed).
- Each in-scope service uses a **unique service identity** (not shared static credentials) and certificates are short-lived and rotated.
- A policy enforcement component (gateway/mesh/API gateway) validates identity/authentication and produces allow/deny decisions **before** traffic reaches the target service.
- Audit logs exist and, for representative traffic, show the calling service identity, certificate validity indicators, and enforcement outcomes.
- Certificate rotation and revocation procedures are demonstrated in at least one environment (for example, test), with evidence captured in change records/logs.

###### Actions Required for Compliance

- [ ] Create and keep up to date an IA-9 service catalogue for each environment, covering web services, database query services, and application programming interfaces (APIs) between services.
- [ ] Choose and put in place a workload identity method that creates unique service identities and uses short-lived credentials.
- [ ] Set up incoming and outgoing network gateways and internal (east-west) service connections to require mutual Transport Layer Security (mTLS) with strict certificate checks, and block all traffic by default (deny-by-default).
- [ ] Set up policy enforcement at the gateway, service mesh, or application programming interface (API) layer to check a user’s identity and authentication, and to decide whether to allow or block the request before it is forwarded.
- [ ] Set up and centralise audit logs for identity checks in security information and event management (SIEM), including the identity lookup results, certificate details, whether access was allowed or denied, and the reasons for any denial.
- [ ] Use continuous integration and continuous delivery (CI/CD) to automatically renew certificates and register service identities, then test certificate cancellation and renewal in a non-production environment and keep supporting evidence.


---

### IA-10 — Adaptive Authentication (Control)

This expectation is about making sure that if someone tries to access sensitive information in a suspicious way, they must prove again that they are authorised, using stronger checks. Without this, an attacker who has stolen a password could pretend to be a legitimate user and access confidential files—especially if the access is from an unusual location, from an internet address with a poor reputation, if unusually large amounts of records are downloaded, or if someone tries to view information outside what their role normally allows.

To meet this expectation, the organisation must set up the system so that, in these specific trigger situations, access to Secret/Confidential data requires an extra step: a second form of verification using either a FIDO2 security key or an approved authenticator app, plus a check that the device being used meets the required security conditions. The organisation must document how this works, configure the system to enforce it, and keep records showing when the extra checks were triggered and whether they succeeded or failed.

##### Step-up MFA + device posture for Secret/Confidential access triggers

- Category: Software
- Priority: Critical

###### WHAT
Set up **adaptive authentication** so that when users try to access **Secret/Confidential** information under defined **circumstances/situations**, the system asks for **extra authentication**: **step-up multi-factor authentication using FIDO2 security keys or an approved authenticator app, plus checks of the device’s security status**.

###### WHY (control requirement)
IA-10 requires the organisation to “Require individuals accessing the system to employ {{ ia-10_odp.01 }} under specific {{ ia-10_odp.02 }}.” The guidance also explains that adaptive authentication should be triggered by suspicious behaviour (for example, access outside the user’s usual pattern, unusual location or IP reputation, and bulk downloads) and should **add to** multi-factor authentication (not replace it).

###### HOW (specific steps/approach)
1. **Define and put the triggers into practice (ia-10_odp.02)**
   - Access that is **outside the usual pattern** for Secret/Confidential data (for example, accessing resources that are outside the user’s typical role or resource set, or an unusual access graph/risk score).
   - Access from **anomalous location or IP reputation** (for example, identity provider risk signals, IP reputation feeds, or “impossible travel”).
   - **Downloading large volumes of records** (for example, the application/application programming interface (API) produces a bulk-download event showing record count/size; set and enforce a threshold).
2. **Set up step-up supplemental authentication (ia-10_odp.01)**
   - If any trigger is met, require **step-up multi-factor authentication (MFA)** using **FIDO2 security keys or an approved authenticator app**.
   - Require **device security status checks** (for example, managed device/compliance signals such as encryption enabled, operating system and patch level, and endpoint detection and response (EDR) present—mapped to the organisation’s device compliance standard).
   - Make sure step-up is **in addition to** the existing baseline MFA (do not remove or replace baseline MFA).
3. **Apply it at the point of access**
   - Connect the application/API with the enterprise identity provider (IdP) and authorisation broker so the step-up check happens **before** the Secret/Confidential action completes (for example, before returning the requested dataset, exporting, or allowing the download).
4. **Audit and keep evidence**
   - Record and retain audit information showing: the trigger reason(s), user identity, resource/data classification (Secret/Confidential), the step-up method used (FIDO2 versus approved authenticator app), the device security status check result, and whether it succeeded or failed.
   - Send logs to security information and event management (SIEM) for correlation and periodic compliance review.
5. **Set thresholds and fine-tune**
   - Start with initial thresholds for “large volumes” and anomaly scoring; review false positives/false negatives and adjust through controlled change management.

###### WHO (role responsible)
- **Identity and Access Management (IAM) lead**: implement conditional access/step-up MFA and device security status checks.
- **Application security/engineering lead**: update the application/API so it produces reliable signals for unusual access and bulk-download events.
- **Security operations (SOC) / SIEM engineer**: ensure audit log fields, retention, and SIEM forwarding are correct.
- **System owner / compliance owner**: approve trigger definitions and thresholds.

###### Acceptance criteria
- For Secret/Confidential access, when any defined trigger in **ia-10_odp.02** occurs, the system requires **step-up MFA using FIDO2 or an approved authenticator app plus device security status checks** before granting the requested access/action.
- Step-up MFA is **in addition to** baseline MFA (baseline MFA still applies to all users; step-up happens only when triggers are met).
- Audit logs show, for each triggered event: trigger reason(s), step-up method, device security status result, and outcome (success/failure), and are retained and searchable for compliance evidence.

###### Actions Required for Compliance

- [ ] Set the rules for when to trigger alerts for out-of-pattern access to Secret/Confidential information, unusual location or internet protocol (IP) reputation, and bulk-download activity thresholds, mapped to ia-10_odp.02.
- [ ] Integrate the application/application programming interface (API) with the organisation’s identity provider (IdP) and authorisation service to require additional verification (“step-up”) before any Secret or Confidential data can be exported, downloaded, or returned in a response.
- [ ] Configure step-up multi-factor authentication (MFA) so that, for the additional authentication requirement in **ia-10_odp.01**, only **FIDO2 security keys** and/or **approved authenticator apps** are allowed.
- [ ] Enable device posture attestation and link compliance signals to the organisation’s required device security settings
- [ ] Set up audit logging for every triggered event, recording the trigger reason, the step-up method used, the resulting device or user posture, and whether it succeeded or failed; then send the logs to security information and event management (SIEM).
- [ ] Test the full process using real users and devices to confirm that “step-up” authentication happens only when the defined triggers occur, and that it does not replace the normal baseline multi-factor authentication (MFA).


---

### IA-11 — Re-authentication (Control)

This requirement is about making sure people prove they are still who they say they are at the moments when mistakes or misuse would cause the most harm. It matters because if someone’s access changes, they start doing high-importance actions, or they have been away from their account for too long, an attacker or an unauthorised person could take advantage of an already-open session to make changes, approve sensitive work, or access higher-risk areas without being checked again.

To meet this expectation, the organisation must set clear rules and step-by-step procedures for re-checking identity whenever a user is about to carry out privileged actions, whenever their role or the system’s security level changes, and after 30 minutes of inactivity. It must build these checks into system settings, keep an up-to-date list of when re-checks are required, document how the system enforces them, and keep records showing both what triggered the re-check and the prompt the user received, so the organisation can show it worked as intended.

##### Step-up re-auth for privileged actions, role/category changes, and 30-min idle

- Category: Software
- Priority: Critical

###### WHAT
Set up organisation-defined re-authentication triggers so that users must sign in again when **privileged actions run**, when **their roles or security levels change**, and after **30 minutes of inactivity**.

###### WHY (control requirement)
NIST IA-11 requires: “Require users to re-authenticate when {{ insert: param, ia-11_odp }}.” The organisation-defined parameter **ia-11_odp** covers the required situations: **privileged actions run**, **roles or security levels change**, and **after 30 minutes of inactivity**. This prevents outdated or higher-than-appropriate permissions from being used within an existing signed-in session.

###### HOW (specific approach)
###### 1) Define the re-auth triggers and where they are enforced
- Create an IA-11 re-auth policy with four triggers:
  1. **Privileged action runs**: any request to an endpoint or workflow marked as privileged must require “step-up” re-authentication.
  2. **Role/entitlement change**: when the authorisation situation changes (for example, role-based access control (RBAC) or attribute-based access control (ABAC) entitlements are updated), the next privileged action must require re-authentication.
  3. **Security level change**: when the session’s effective security level changes (for example, access to restricted data or workflows), the next privileged action must require re-authentication.
  4. **Inactivity**: if **30 minutes** pass without user activity, the next privileged action must require re-authentication.

###### 2) Implement step-up authentication at the identity provider (preferred)
- Use the organisation’s identity provider (IdP), integrated with the application, to enforce **step-up re-authentication** based on how “fresh” the session is and/or an application-provided indicator.
- Set up conditional access / step-up so that when the application indicates a privileged action (or when the session context shows an elevated role or security level), the IdP requires a **fresh sign-in**.
- Ensure the application does not complete the privileged action until the IdP confirms a successful step-up re-authentication.

###### 3) Ensure role/security changes affect the re-auth decision
- Make sure role/entitlement and security-level changes are reflected in the session information the IdP/application uses (for example, token details, session settings, or an authorisation context record).
- When roles or security levels change, mark the existing session so that the next privileged action requires step-up re-authentication (so the user cannot continue elevated actions without re-authentication).

###### 4) Enforce the 30-minute inactivity rule
- Add an inactivity timer based on authenticated user activity (such as the last successful request or interaction).
- If the timer exceeds **30 minutes**, require step-up re-authentication for the next privileged action (not necessarily for every non-privileged request, unless your risk assessment requires it).

###### 5) Produce audit evidence
- Record and keep audit information for:
  - the **trigger** (privileged action attempted, role/security change event, inactivity limit reached),
  - the **re-authentication challenge** issued,
  - the **re-authentication result** (success/failure),
  - the **completion of the privileged action** (only after success).
- Send logs to the security information and event management (SIEM) system for correlation (trigger → step-up required → step-up success/failure).

###### WHO
- **Identity and Access Management (IAM) Engineer**: configure IdP step-up/conditional access and session “freshness” handling.
- **Application Security/Backend Engineer**: mark privileged functions, block completion until step-up succeeds, implement inactivity tracking, and pass through context changes.
- **Security Operations (SOC) / SIEM Engineer**: ensure audit log collection, retention, and correlation rules are in place.

###### Acceptance criteria
- When a user attempts a **privileged action**, the system requires re-authentication and does not carry out the privileged operation until re-authentication succeeds.
- When a user’s **role or security level changes**, the next privileged operation requires re-authentication (even if the user remains signed in).
- After **30 minutes of inactivity**, the next privileged operation requires re-authentication.
- Audit logs show, for each event, the trigger and the re-authentication challenge/result, and the privileged action completion happens only after successful re-authentication.

###### Actions Required for Compliance

- [ ] Define and document the IA-11 re-authentication policy triggers exactly as: privileged function execution, a change in role or security category, and 30 minutes of inactivity.
- [ ] Mark privileged functions and workflows in the application so the backend can request an additional approval (step-up) before they run.
- [ ] Configure the organisation’s identity provider (IdP) to require extra verification (step-up re-authentication) when users perform privileged actions, and to ensure the session has the correct elevated context (role/category) and is still recent (session freshness).
- [ ] Set up inactivity tracking using a 30-minute limit, and require an extra approval step for the next privileged action once that limit has been exceeded.
- [ ] Ensure that any changes to roles, permissions, or security categories update the current session information, and flag the session so that any later privileged actions require step-up verification.
- [ ] Set up audit logging and security information and event management (SIEM) to track and link the sequence: trigger → re-authentication challenge → re-authentication outcome → completion of the privileged action.


---

### IA-12 — Identity Proofing (Control)

This requirement is about making sure you genuinely know who someone is before giving them an account to access important systems. Without proper identity checks, the organisation risks fraudulent or incorrect account registrations—for example, the wrong person being granted access, or an attacker creating an account using false information.  

To meet this expectation, the organisation must confirm a person’s identity for every account that needs access, using the required level of identity assurance for that type of account, as set out in relevant standards and guidance. It must also link the person’s identity to one unique individual, so there is no confusion or duplication.  

Finally, it must collect the person’s identity information, check that it is accurate, and verify it—while ensuring any legal or privacy obligations are considered through appropriate internal privacy and legal advice.

##### IAL-based identity proofing with unique identity resolution in IdP

- Category: Software
- Priority: Critical

###### WHAT
Set up an identity-check process in the enterprise Identity Provider (IdP) so that, for every user account that needs access to systems, the organisation:
- collects identity evidence,
- checks that evidence is valid,
- confirms the evidence is genuine, and
- links the user to **one single unique person** (so there are no duplicate or “alias” identities).

This process must follow the required **Identity Assurance Level (IAL)** for each type of account.

###### WHY (control requirement)
IA-12 requires the organisation to reduce the risk of threats to user registration and account creation by carrying out identity checks—meaning **collecting, validating, and verifying identity information**—and by ensuring the identity is **linked to one single unique person**. The required Identity Assurance Level (IAL) must match relevant guidance (for example, SP 800-63-3 and SP 800-63A).

###### HOW (specific steps/approach)
1. **Define account categories and IAL mapping**: Create an identity-check policy that links each account type (for example, employee, contractor, partner, privileged operator) to the required IAL.
2. **Configure evidence collection**: In the IdP onboarding/registration workflow, require the collection of identity evidence details that match the mapped IAL (for example, document-based or electronic details, as applicable).
3. **Validate evidence**: Add automated checks in the workflow (for example, trusted issuer lists, evidence format checks, source/provenance checks, and consistency checks against authoritative records).
4. **Verify evidence**: Add a verification step that matches the IAL (for example, additional “step-up” checks and/or approved electronic verification). For higher IALs, use verification methods that are resistant to phishing, where the IAL mapping requires it.
5. **Resolve to a single unique individual**: Use a consistent method to match identities using fixed, authoritative identifiers (for example, employee ID plus a verified personal identifier). Add duplicate detection and an adjudication queue for unclear matches to prevent linking an account to the wrong person.
6. **Ensure auditability and retention**: Record the outcome of the identity checks (what evidence was provided, validation and verification results, the identity match decision, and any actions by approvers/adjudicators where relevant) in tamper-evident audit logs for later audit review.
7. **Privacy/legal alignment**: Make sure evidence retention and minimisation, and the legal basis for processing, are reviewed with privacy/legal advisers and reflected in the system security plan and privacy documentation.

###### WHO
- **Identity and Access Management (IAM) Lead**: owns the IAL mapping, IdP workflow design, and identity matching rules.
- **Privacy Officer / Legal Counsel**: reviews evidence collection and retention, and the legal basis.
- **IdP/Platform Engineer**: implements IdP configuration, integrations, and audit logging.
- **Authoritative Source Owner (for example, HRIS/HR)**: ensures data quality and governance of authoritative identifiers.

###### Acceptance criteria
- For each account type, the IdP onboarding workflow enforces the mapped **Identity Assurance Level (IAL)** and cannot complete without the required evidence collection, validation, and verification steps.
- Every newly created access account is linked to exactly **one unique individual**; any duplicate or unclear matches are sent to adjudication and do not automatically create an account.
- Identity-check outcomes and identity match decisions are recorded in audit logs with enough detail to show compliance during an audit.
- Privacy/legal requirements for handling evidence (minimisation and retention) are documented and implemented.

###### Actions Required for Compliance

- [ ] Create an identity verification policy that maps each account type to the required identity assurance level (IAL).
- [ ] Set up the identity provider (IdP) onboarding process to collect the required identity evidence details for each assurance level (IAL).
- [ ] Set up automated checks to confirm the information is correct, including verifying the format, whether the issuer can be trusted, where the information came from, and that it matches trusted official sources.
- [ ] Carry out identity verification steps that are appropriate for the required assurance level (including additional “step-up” verification and phishing-resistant verification where the assurance-level mapping requires it).
- [ ] Set up a consistent way to match each record to one specific person using fixed, official identifiers, and turn on duplicate detection so any duplicates are reviewed and resolved.
- [ ] Enable tamper-evident audit logs of proofing results and identity verification decisions to support audit readiness
- [ ] Carry out the full privacy and legal review for how evidence is reduced and how long it is kept, then put in place the approved retention controls.


---

#### IA-12.1 — Supervisor Authorization (Enhancement)

This requirement ensures that when someone requests access to the organisation’s systems and applications, their manager (or a nominated sponsor) must explicitly approve the request before any account is created. This is important because, without that approval, accounts could be set up too easily, given to the wrong people, or granted with more access than is actually needed—raising the risk of misuse, mistakes, or unauthorised access that could disrupt operations or expose sensitive information.

To meet this expectation, the organisation must use an account registration process where supervisor or sponsor approval is part of the workflow before any account request can be completed. The organisation must also clearly define who is considered an approving manager. Before approval is granted, it must complete identity checks. It must keep clear records showing who approved the request, when they approved it, and that they confirmed the account is necessary for the person’s role and that the requested access level matches their responsibilities.

##### Block account registration until supervisor/sponsor approval

- Category: Software
- Priority: Critical

###### WHAT
Implement a logical access registration process that **cannot finish** (i.e., no account is created or activated) until an appropriate **supervisor or sponsor** has **explicitly approved** the request.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Information Assurance (IA)-12(1) enhancement requires that the **registration process** for obtaining a logical access account includes **supervisor or sponsor authorisation**. This guidance explains that it adds oversight so that the management chain is aware, the account is needed for the organisation’s key missions/functions, and the requested permissions are suitable.

###### HOW (specific steps/approach)
1. **Define who is eligible to approve and how they are identified**: Set up rules to identify the correct supervisor/sponsor for each requester using trusted Human Resources (HR) or identity information (for example, reporting manager, nominated sponsor). Include support for acting or temporary sponsors and set time limits for when approvals are valid.
2. **Make approval a required “stop point” in the identity process**: In the enterprise identity provider / identity governance workflow, require a mandatory approval step before any account creation or activation can happen. Configure the workflow so that account provisioning either:
   - does not start until approval is completed, or
   - creates the account in a **pending** state that cannot be used until approval is recorded.
3. **Check identity verification is completed before approval**: Ensure the workflow confirms that identity verification is complete (and matches trusted records) before sending the request to the supervisor/sponsor for approval.
4. **Capture clear approval evidence**: Require the approver to confirm (using structured fields and, where needed, a reason) that:
   - the account is needed for the organisation’s missions/functions, and
   - the requested access level is appropriate for the requester’s responsibilities.
5. **Record and keep audit evidence**: Store an auditable record for each request, including the requester’s identity, the approver’s identity, the decision result, the date/time, and the recorded confirmations about necessity and appropriateness. Keep logs according to organisational audit requirements and ensure they can be searched for compliance.
6. **Apply the same rule for administrative access**: Send administrator or privileged operator account requests through the same supervisor/sponsor approval workflow (so they cannot be bypassed by application-side administrative actions).

###### WHO (role responsible)
- **Identity and Access Management (IAM) engineer**: build the approval “stop point”, set up approver identification, and connect it to account provisioning.
- **HR/People Systems owner (or HR Information System (HRIS) integration team)**: ensure the trusted information used to identify managers/sponsors is accurate.
- **Application owner / security lead**: confirm that the approval fields reflect organisational mission need and access appropriateness.
- **Approvers (supervisors/sponsors)**: provide the required confirmations and approvals.

###### Acceptance criteria
- A logical access registration request **cannot create an active/provisioned account** until supervisor/sponsor approval is recorded.
- The workflow requires **identity verification completion** before the approval step.
- Approval records include **approver identity, date/time, and confirmations** for necessity and access appropriateness.
- Requests for privileged/admin access use the **same blocking approval workflow**.
- Audit evidence is retained and can be produced for a sample of recent requests (for example, the last 30–90 days) showing the approval “stop point” and the recorded confirmations.

###### Actions Required for Compliance

- [ ] Define the rules for linking each supervisor and sponsor to the correct approver, using the official human resources (HR) and identity details, including how to handle acting or temporary sponsors.
- [ ] Set up the identity governance and identity provider (IdP) registration process so that account set-up and activation are blocked until a supervisor or sponsor has approved the request.
- [ ] Make completion of identity checks a required step before sending the request to the supervisor or sponsor for approval.
- [ ] Add structured confirmation fields for approvers to confirm (a) that access is necessary for the organisation’s missions or functions, and (b) that the access level is appropriate.
- [ ] Link workflow results to account provisioning so new accounts stay pending/inactive until approval evidence is recorded.
- [ ] Turn on and keep audit logs for every request, recording who made the request, who approved it, the decision made, the date and time, and confirmation that the approval was completed.


---

#### IA-12.2 — Identity Evidence (Enhancement)

This requirement is about making sure the organisation correctly verifies a person’s identity before they are officially registered. If identity evidence is not checked properly, the wrong person could pretend to be someone else, get an account, and then misuse access. This could lead to financial loss, exposure of sensitive data, or disruption to important services.

To meet this expectation, the organisation must ensure the registration authority collects and reviews proof of identity before registration. It must use only approved types of evidence, such as official documents, and—where appropriate—a combination of documents and biometric checks.

The registration authority must decide what level and type of evidence to use based on the risks and the level of access and privileges the person will have. This includes risks linked to the person’s role and the systems they will use.

The organisation must document the identity-checking process, require staff to follow it, set out the evidence requirements in its internal policy, and keep records showing what evidence was provided and reviewed for each person.

##### Risk-based identity proofing workflow with evidence capture

- Category: Software
- Priority: Critical

###### WHAT
Set up an identity registration process that collects, checks, and records proof of an individual’s identity **before** the individual is registered (and **before** any account is created or access rights are increased). The process must choose which proof is acceptable (proof documents only, or proof documents plus biometric checks) based on the individual’s risk level, their role, and the systems and privileges they will use.

###### WHY (control requirement)
This requirement, from the National Institute of Standards and Technology (NIST) Identity Assurance (IA)-12(2) enhancement, states: **“Require evidence of individual identification be presented to the registration authority.”** Guidance explains that identity proof (documents, or a combination of documents and biometrics) reduces the risk of fraudulent identity claims, and that the acceptable types of proof should match the risks to the systems, roles, and privileges involved.

###### HOW (specific steps/approach)
1. **Define evidence levels and link them to access**: Create evidence levels (for example, Tier 0/1/2/3) and map them to access and privilege levels, and to how critical the system is (from the system security plan or an equivalent source). For each level, set which proof types are acceptable: **documents only** or **documents + biometrics**.
2. **Block “proof” from being skipped in the identity registration process**: Configure the registration and provisioning process so that account creation and/or privilege increases are stopped until identity proofing is completed and approved by the registration authority.
3. **Require registration authority review and identity matching**: Provide registration authority tools (user interface/workflow) to capture and review the evidence, including checks that the evidence matches the person being registered (using manual checks and any automated checks for completeness and correct format).
4. **Keep proofing results for audit purposes**: Store evidence details and verification outcomes for each person (for example: evidence type(s), document type, verification result, reviewer identity, dates/times, and decision). Keep evidence according to the organisation’s retention rules and link the results to the person’s identity record.
5. **Use separation of duties**: Make sure the person requesting access is not the same person who approves or reviews the identity evidence. Approvals must be limited to authorised registration authority roles.
6. **Re-check identity when privileges change**: If the person’s role or access level increases (or if the target system’s criticality changes), require additional (“step-up”) identity proofing that matches the higher evidence level before granting the increased access.

###### WHO (responsible roles)
- **Identity and Access Management (IAM) Lead**: responsible for designing the workflow, defining evidence levels, and enforcing the process in the registration and provisioning pipeline.
- **Registration Authority (RA) / Identity Proofing Team**: captures and reviews the evidence, and records the proofing outcomes.
- **Security/Compliance**: checks that the evidence levels match the risk assessments and ensures evidence is retained in a way that supports audits.
- **System Owner / Application Owner**: provides system criticality and role-to-privilege mapping inputs (from the system security plan or an equivalent source).

###### Acceptance criteria
- No user or account is registered (or given privileged access) unless evidence has been presented to and reviewed by the registration authority.
- The evidence types used for each registration match the defined evidence level for the person’s role and system risk.
- Proofing outcomes (including reviewer identity and dates/times) are recorded and can be retrieved for audit.
- Separation of duties is enforced (the requester cannot approve the evidence review).
- When privileges change, step-up proofing is triggered if the required evidence level increases.

###### Actions Required for Compliance

- [ ] Set up evidence levels based on a person’s role and access rights, and on how critical the system is. Specify when proof is document-only and when it must include both documents and biometric verification.
- [ ] Set up the registration and account-creation process so that new accounts and any privilege increases are blocked until identity checks (proofing) are completed and approved.
- [ ] Set up a process to collect and review proof for registration authority decisions, and record the reviewer’s decision.
- [ ] Store and link the proofing evidence details and results (type of evidence, verification outcome, who reviewed it, and the dates and times) to the person’s identity record.
- [ ] Ensure separation of duties so that people who submit an identity evidence request cannot approve or review their own identity evidence.
- [ ] Set up “step-up” checks to run when a user’s role or system access level increases.


---

#### IA-12.3 — Identity Evidence Validation and Verification (Enhancement)

This requirement is about making sure the person applying for an account is genuinely who they say they are, before the organisation creates or links that account. Without this check, someone could use a fake or borrowed identity to gain access, pretend to be a real customer or employee, and potentially misuse systems or permissions they should not have.

To meet this expectation, the organisation must use approved identity checks either in person or by video. During these checks, staff must review an official government-issued identity document, confirm that the person on the call or in front of them matches the document (including any required credential or biometric match), and verify the information against reliable official records.

The organisation must document these approved methods in its identity rules and step-by-step procedures, ensure its systems and plans support the approach, and assign named staff to carry out the checks. It must also keep clear records showing which method was used, the results of the checks, and the final decision. The organisation must not create or link an account if the evidence does not pass validation or verification.

##### Approved identity proofing workflow before account creation/linking

- Category: Software
- Priority: Critical

###### WHAT
Set up an identity evidence checking process that uses the organisation-approved methods (in-person or video identity checks using a government-issued ID, credential/biometric matching where applicable, and checks against official records). Only allow account creation or account linking when the identity evidence has been both validated and verified successfully.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Identity and Access Control (IA) requirement IA-12(3) enhancement says: “Require that the presented identity evidence be validated and verified through {{ insert: param, ia-12.03_odp }}.” The guidance explains that:
- **Validation** confirms the evidence is genuine/authentic and that the information is correct, up to date, and belongs to the person.
- **Verification** confirms and links the claimed identity to the real person presenting the evidence.
The methods used must match the risks for the systems, roles, and access privileges given to the user.

###### HOW (specific steps/approach)
1. **Define the approved proofing methods** in the organisation’s identity rules/procedures to match `ia-12.03_odp` (in-person or video checks; government-issued ID; credential/biometric matching; official-record verification).
2. **Set up a guided onboarding workflow** (identity provider/registration service + proofing provider + case management) that completes proofing **before** any account is created or any account is linked.
3. **Use clear decision gates**: the workflow must return an explicit result (for example, **Approved / Rejected / Escalate**). The identity provider/application must stop account creation/linking unless the result is **Approved**.
4. **Keep audit-ready records of validation and verification**: store the method used, the validation checks completed (genuine/authentic; correct and current data; relates to the individual), the verification checks completed (link between the claimed identity and the person presenting the evidence), the official-record check results, timestamps, and the final decision.
5. **Use risk-based assurance**: configure the workflow so higher-risk roles or higher privileges require stronger proofing (for example, video proofing and/or extra matching and official-record checks) in line with the risk to the system and role.
6. **Assign operational ownership and runbooks**: name the operators/roles responsible for handling **Escalate** cases, exceptions, and re-checking, and ensure procedures explain what to do when evidence fails validation/verification.

###### WHO
- **Identity and Access Management (IAM) Lead**: owns the identity rules/procedures and workflow design.
- **Security/Compliance Officer**: checks that the workflow methods match `ia-12.03_odp` and that risk-based assurance is applied.
- **Identity Provider (IdP)/Platform Engineer**: builds the workflow integration and enforces “no account without proofing”.
- **Proofing Operations Team**: carries out or oversees in-person/video proofing and manages exception/escalation handling.

###### Acceptance criteria
- For every new account creation and account linking event, the system must require proofing to be completed and must receive an **Approved** outcome before the account/link is established.
- Proofing records must show the **method used**, the **validation** evidence (genuine/authentic; correct and current data; relates to the individual), and the **verification** evidence (link between the claimed identity and the person presenting the evidence), including official-record verification results.
- Evidence retention must be sufficient for audit (the case record includes timestamps, decision, and the operator/automation identity where applicable).
- Risk-based branching must be clearly demonstrated (for example, privileged roles cannot be provisioned using weaker proofing than allowed by the identity rules).
- Any attempt to create/link accounts without successful proofing must be blocked and logged.

###### Actions Required for Compliance

- [ ] Document the approved identity evidence validation and verification methods that match **IA-12.03 ODP**, including: **in-person or video checks**, **government-issued identification**, **matching the credential and biometric information**, and **verification using authoritative records**.
- [ ] Set up an onboarding process that checks identity (proofing) before creating any account or linking any account, and that clearly returns one of these results: **Approved**, **Rejected**, or **Escalate**.
- [ ] Configure the identity provider (IdP) and registration service to prevent new accounts from being created or linked unless the workflow outcome is **Approved**.
- [ ] Combine the proofing provider’s results and keep complete, auditable case records showing: the method used, the validation results, the verification and matching/linking results, checks against authoritative records, the relevant dates and times, and the final decision.
- [ ] Set up risk-based assurance mapping so that roles with higher privileges must provide stronger verification, in line with the agreed identity rules.
- [ ] Create operational runbooks and assign named responsibilities for handling escalations, re-checking proofs, and processing exceptions, including audit logging of what operators do.


---

#### IA-12.4 — In-person Validation and Verification (Enhancement)

This requirement is about making sure people prove who they are in person, face-to-face, before an authorised registration team issues or accepts an identity credential. It matters because if identity checks are done only remotely or by the wrong people, criminals could use fake documents or pretend to be someone else to obtain credentials they should not have. Those credentials could then be used to access services, accounts, or benefits improperly.

To meet this expectation, the organisation must arrange for identity evidence to be checked and confirmed during a face-to-face meeting with a designated registration authority. The organisation must not use unauthorised staff or third parties to carry out this step.

The organisation should keep clear records showing that the individual attended in person with the designated authority, that the authority checked the physical identity evidence, and that the person who carried out the check is clearly identified as an authorised registration authority.

##### In-person identity proofing by authorised registration authority

- Category: Manual
- Priority: Critical

###### WHAT
Make sure that checks to validate and verify identity documents are carried out **in person** by a **designated registration authority** before any identity credential is issued or accepted.

###### WHY (control requirement)
IA-12(4) enhancement requires that identity document validation and verification happen **face-to-face** with a **designated registration authority**. This lowers the risk of fraudulent credentials by requiring physical presence, presentation of physical identity documents, and direct interaction with authorised proofing staff.

###### HOW (specific approach)
1. **Define and maintain the designated registration authority list**: keep an official list of the named roles or individuals allowed to do in-person checks. Include proof of their authorisation (for example, approval from Human Resources or a line manager) and re-check their authorisation periodically.
2. **Set up an in-person proofing desk or process**: require applicants to attend a controlled location (or an equivalent face-to-face meeting arranged by the authority). The designated registration authority must physically inspect the identity documents and complete the validation and verification steps (for example, checking document authenticity and expiry dates, and matching them to the applicant’s provided identity details).
3. **Use a standard checklist and record the result**: the registration authority must record, at minimum, the document type(s), the result of the checks (verified/accepted/rejected), the date and time, and the identity of the authorised registration authority who carried out the check.
4. **Keep proofing records that can be audited and cannot be altered without detection**: store proofing evidence and outcomes in an unchangeable, audit-logged way (for example, a workflow system with locked records and an immutable audit trail, or controlled retention of scanned proofing forms in write-once, read-many style storage). Ensure the records clearly show who the authorised registration authority was and which applicant session they relate to.
5. **Block credential issuance/acceptance unless proofing is complete**: configure the credential issuance and acceptance process so it cannot proceed unless there is a valid, referenceable proofing record created through the in-person process (for example, a proofing reference number that is checked against the tamper-evident record).
6. **Manage exceptions clearly**: if any alternative to strict in-person proofing is ever allowed, require prior approval through a documented exception process and keep the approval reference attached to the proofing record.

###### WHO
- **Registration Authority Manager / Identity Governance Lead**: maintains the authorised list and approves exceptions.
- **Designated Registration Authorities (proofing staff)**: carry out the in-person validation and verification and complete the checklist.
- **IAM/Identity Engineering Lead**: implements the issuance and acceptance “gate” and connects it to the proofing record storage.
- **Compliance/Audit Owner**: checks that audit evidence is sufficient and retained appropriately.

###### Acceptance criteria
- For every identity credential issuance or acceptance event, there is an auditable proofing record showing:
  - the applicant was checked **in person**,
  - the checks were carried out by a **designated registration authority** (named or role-based attribution),
  - the identity evidence was **validated and verified**, with the recorded result,
  - the record is stored in a **tamper-evident/immutable** way, including timestamps.
- Credential issuance or acceptance cannot happen without a valid proofing reference that links to an in-person proofing record.
- If exceptions exist, they must include documented prior approval and be traceable to the proofing record.

###### Actions Required for Compliance

- [ ] Create and get approval for a named list of registration authority staff, including specific roles and individuals, and provide proof that this list is checked and confirmed at regular intervals.
- [ ] Set up an in-person proofing process that requires the person to attend in person and meet face to face with the designated registration authority.
- [ ] Create a proofing checklist that sets out:

- the required validation and verification steps, and  
- the required recorded information, including: document type, outcome, date and time, and the identity of the authorised staff member.
- [ ] Use tamper-evident storage or write-once (immutable) workflow logs for proofing records, and prevent further changes by locking completed sessions.
- [ ] Set up the process for issuing and accepting credentials so that it only continues after a valid proofing reference is provided and that reference is linked to an in-person proofing record.
- [ ] Set up an exception process that requires prior approval, and make sure all approved exceptions are kept on file and linked to the relevant proofing record.


---

#### IA-12.5 — Address Confirmation (Enhancement)

This requirement is about making sure the person who signs up is genuinely connected to the address they claim. The organisation must do this by sending a temporary registration code or a proofing notice to a contact point where it can reach them outside the sign-up process. If it does not, someone could pretend to be a real customer and complete registration using another person’s details, which could lead to fraud, unauthorised access, or incorrect records.

To meet this expectation, the organisation must clearly set out how it will confirm the “address of record” using an out-of-band method. It must send the code or notice to the delivery destination taken from its existing records, not to anything the user enters during the confirmation step. It must be able to send it to either a physical address (for example, a home address) or a digital address (for example, an email address or mobile number). It must also send it using a different channel from the one used to register.

The organisation must document this approach in its procedures and plans, assign it to the right staff, ensure it is supported by its systems, and keep records showing the code was sent to the correct address and was successfully used to complete confirmation.

##### Out-of-band address confirmation code via IdP using address-of-record

- Category: Software
- Priority: Critical

###### WHAT
Set up an identity-check and registration step that requires a **temporary registration code** (or a proofing notice). This code must be sent to the user’s **address of record** (either physical or digital) using an **out-of-band channel**, and then checked by the person completing registration.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Identity Assurance Level (IA) 12.5 enhancement requires that the **ia-12.05_odp** be **sent using an out-of-band channel** to confirm the user’s **address of record** (physical or digital). The sending destination must come from **authoritative existing records** (not values the user enters themselves during confirmation).

###### HOW (specific steps/approach)
1. **Define the out-of-band method for ia-12.05_odp**: configure the registration process to create a short-lived **registration code** and send it via an out-of-band channel (for example, email and/or text message (SMS)) to the user’s address of record.
2. **Use authoritative address-of-record only**: when the proofing session is created, get the delivery destination from the authoritative identity data source (for example, enterprise identity provider (IdP) profile details taken from the system of record). Save a **masked snapshot** of the destination used for delivery in the proofing session record.
3. **Keep out-of-band separate**: make sure the code is never shown in the registration website/application session, and cannot be retrieved through the same channel or application programming interface (API) used to submit registration details.
4. **Prevent address substitution**: during the confirmation step, disable any user interface (UI) or API options that let the user change the email or phone destination. Alternatively, accept the input but do not use it for delivery or verification—use only the stored address-of-record snapshot.
5. **Link verification to the proofing session**: require the user to enter the code within a set time limit. If the code is entered correctly, mark the address of record as confirmed for that proofing session and record whether verification succeeded or failed.
6. **Create audit evidence**: record (and keep) events for: (a) code generation, (b) delivery attempt and the masked destination used, (c) the delivery provider’s response, and (d) whether code verification succeeded or failed. Use correlation identifiers to link the proofing session to the user.

###### WHO (role responsible)
- **Identity and Access Management (IAM) / Identity Engineer**: build the identity provider (IdP) registration and verification journey, including code generation and linking results to proofing sessions.
- **Application Owner**: ensure the registration user interface (UI) and application programming interface (API) do not allow address substitution during confirmation.
- **Security / Compliance**: confirm the audit evidence requirements, retention approach, and review procedures.

###### Acceptance criteria
- A registration participant cannot complete address confirmation without entering the **ia-12.05_odp** that was sent via an **out-of-band** channel.
- The delivery destination used for the code comes from **authoritative address-of-record** and cannot be changed during the confirmation step.
- Successful confirmation creates an auditable change of state (address confirmed) linked to the proofing session.
- Audit logs show, for each proofing session: delivery attempt details (masked destination), delivery provider outcome, and whether verification succeeded or failed.

###### Actions Required for Compliance

- [ ] Set up the registration and identity-check process so it creates a short-lived registration code (`ia-12.05_odp`) and sends it to the user using a separate channel (email or text message).
- [ ] Set up proofing-session logic to get the delivery address from the official address-on-record details, and store a masked copy of it so it can be verified and linked to the proofing session.
- [ ] During the confirmation step, remove or ignore any destination details provided by the user, so that address substitution is not possible.
- [ ] Make sure the code is not shown in the registration website or application session, and that it is not sent back in the registration application programming interface (API) response.
- [ ] Link code verification to the identity-checking session, and only mark the address-of-record as confirmed after a successful code entry within the allowed time window.
- [ ] Turn on audit logs and keep them for code generation, delivery attempts (with the destination hidden), the delivery provider’s response, and the verification result, using matching reference identifiers to link related events.


---

#### IA-12.6 — Accept Externally-proofed Identities (Enhancement)

This requirement is about only allowing people to use your system when their identity has been checked by an outside organisation to a sufficiently strong standard. If you accept identities that were verified too weakly, the wrong person could gain access, pretend to be a legitimate user, or cause harm to data and services. To meet this expectation, the organisation must accept externally verified (federated) identities for this system only when the outside identity check meets the required Level 3 standard, and it must state this clearly in its identity and login rules, the step-by-step procedures for checking external identity proof, and the system’s security plan and supporting records. The organisation should also make sure staff know what to do if the outside proof is missing, unclear, or below the required standard—for example, refusing access or requiring the identity to be re-checked to reach Level 3 before it is accepted.

##### Enforce Level 3-only externally-proofed identities via federation claims

- Category: Software
- Priority: Critical

###### WHAT
Set up the application’s identity federation and access checks so that externally verified identities are accepted **only** when the external verification assurance matches the organisation-defined identity assurance level for this enhancement (default: **NIST SP 800-63B Level 3**).

###### WHY (control requirement)
IA-12(6) requires the organisation to **accept externally verified identities at {{ param, ia-12.06_odp }}**. The guidance stresses that proof should be accepted only at a **matching level of assurance**, in line with the organisation’s security policy and the assurance level required for the system.

###### HOW (specific steps/approach)
1. **Set the Level 3 acceptance rule** in the identification and authentication policy: externally verified identities are accepted for this application only when the federation message includes an assurance indicator that corresponds to **Level 3** (and are rejected otherwise).
2. **Apply enforcement at the relying-party boundary** (for example, an API gateway, reverse proxy, application authentication middleware, or the identity provider integration layer):
   - Require the incoming **SAML (Security Assertion Markup Language)** or **OIDC (OpenID Connect)** token to include an assurance indicator (for example, `acr`, `loa`, `assurance_level`, or federation metadata) that maps to **Level 3**.
   - Block authentication when the assurance indicator is **missing, incorrectly formed, or maps to a level below Level 3**.
3. **Create an auditable onboarding/trust mapping** for each external identity provider (IdP) or agency:
   - Record which claim or metadata field represents assurance and how it maps to **Level 3**.
   - Keep the evidence used to justify the mapping (for example, trust framework documentation, contractual assurance statements, certification references).
4. **Log and keep proof of the decision** for each login attempt where externally verified identities are used:
   - Record the external IdP/issuer, the assurance indicator value received, the mapping result (Level 3 vs not), and the access decision (allow/deny).
5. **Document the enforcement approach** in the system security plan, so auditors can confirm how the application enforces the “Level 3 only” acceptance rule in practice.

###### WHO
- **Application Owner / IAM Lead**: sets the Level 3 acceptance rule and ensures it is reflected in policy and the system security plan.
- **Identity and Access Management Engineer**: implements relying-party enforcement (gateway/middleware) and validates token claims.
- **Security Assurance / Compliance**: reviews onboarding evidence and mapping records for external IdPs.

###### Acceptance criteria
- The application **denies** externally verified authentication attempts when the assurance indicator is **missing** or **not mapped to Level 3**.
- The application **allows** externally verified authentication attempts only when the assurance indicator is present and **mapped to Level 3**.
- For each externally verified login attempt, logs show the external issuer, assurance indicator value, mapping outcome, and allow/deny decision.
- The system security plan and identification/authentication policy explicitly state the **Level 3-only** externally verified identity acceptance rule and the enforcement mechanism.

###### Actions Required for Compliance

- [ ] Update the identification and authentication policy to say that externally verified identities are accepted only at {{ ia-12.06_odp }} (default level 3) for this application.
- [ ] Configure the relying party (the application gateway or reverse proxy, or the authentication middleware) to require an assurance indicator claim (for example, `acr`, `loa`, or `assurance_level`) and map it to Level 3.
- [ ] Use a “deny by default” approach for authentication when the assurance indicator is missing, not valid, or indicates a level below Level 3.
- [ ] Create and keep an auditable “trust mapping” record for each external identity provider (IdP) or agency. This record must show the assurance claim and related information (metadata), and the evidence that supports the Level 3 mapping.
- [ ] Enable and keep authentication decision logs that record the issuer, the assurance indicator value, the mapping result, and whether the outcome was allow or deny.
- [ ] Document the enforcement approach and the evidence sources in the system security plan so it can be checked during audits.


---

### IA-13 — Identity Providers and Authorization Servers (Control)

This requirement is about ensuring the organisation uses trusted services to verify who (or what) is trying to access its systems, and to determine what they are allowed to do. Without this, the wrong person, device, or automated service could be treated as legitimate, which could lead to unauthorised access to sensitive information or systems, or to legitimate access being granted incorrectly.

To meet this expectation, the organisation must use approved identity services and approved authorisation services to manage the identities of people, devices, and non-person entities, along with the relevant details and access rights needed to make both login decisions and access decisions. This must be done in line with the Department of Defense (DoD) Federal Identity, Credential, and Access Management policy and the organisation’s own authentication and authorisation policy.

The organisation must use the approved methods for these interactions, including Security Assertion Markup Language 2.0 (SAML 2.0), Open Authorisation 2.0 (OAuth 2.0), OpenID Connect, device certificates, and signed access tokens. It must also document how this is done in system design and security planning, keep the related configuration information, maintain the required policy and procedure records, and assign clear responsibilities to the right staff for running and managing these services.

##### Approved IdP/AS federation with signed tokens and claim mapping

- Category: Software
- Priority: Critical

###### WHAT
Implement (or integrate with) approved **identity providers (IdPs)** and **authorisation servers (ASs)** to manage **user, device, and non-person entity (NPE)** identities, attributes, and access rights used for **authentication and authorisation decisions**. Use the organisation-approved mechanisms: **SAML 2.0, OAuth 2.0, OpenID Connect, X.509 device certificates, and signed JSON Web Token (JWT) access tokens**.

###### WHY (control requirement)
NIST **IA-13** requires the organisation to use identity providers and authorisation servers to manage identities, attributes, and access rights that support authentication and authorisation decisions **in line with the organisation’s IA-13 policy** (ia-13_odp.01) using the **approved mechanisms** (ia-13_odp.02). This helps ensure authentication and authorisation decisions are based on trusted identity information and signed access tokens.

###### HOW (specific approach)
1. **Select and integrate with approved IdP/AS endpoints** that support **OpenID Connect and OAuth 2.0** for interactive use and for application programming interface (API) access, and that can issue **signed JSON Web Token (JWT) access tokens** for authorisation decisions.
2. **Use SAML 2.0 federation only when needed** for legacy or partner applications, ensuring the application validates signed SAML statements from the approved IdP.
3. **Set up device identity using X.509 certificates** for managed devices (and any NPEs that need certificate-based authentication), including mapping certificates to identities and handling certificate revocation in line with the organisation’s authentication and authorisation policy.
4. **Standardise identity attributes and entitlements**: define a single, agreed set of claims (for example, user/device/NPE identifiers, roles, entitlements, tenant/organisation, assurance level) and map them consistently from IdP/AS outputs into the application’s authorisation inputs.
5. **Check tokens and authorisation inputs in the application**: confirm the JWT signature, issuer, audience, token validity period, and that required claims are present; enforce authorisation based on the mapped entitlements and roles.
6. **Document the design and configuration**: record which IdP/AS is the source of truth, which protocols are used for each integration, how attributes and entitlements are mapped, and how device/NPE identities are handled—ensuring the documentation matches the organisation’s IA-13 policy and is kept as auditable evidence.

###### WHO
- **Identity and Access Management (IAM) engineer**: implement IdP/AS integrations, configure token checks, and map claims and entitlements.
- **Application security lead / application owner**: ensure the application’s authorisation logic uses the mapped claims and entitlements correctly.
- **Security architect**: approve the design documentation and ensure it aligns with ia-13_odp.01.

###### Acceptance criteria
- The application authenticates users using **OpenID Connect** and authorises requests using **signed JSON Web Token (JWT) access tokens** issued by the approved authorisation server.
- For legacy or partner integrations, the application validates **SAML 2.0** statements from the approved identity provider.
- Managed devices authenticate using **X.509 certificates**, and the application (or gateway) correctly maps certificate identity to authorisation claims.
- JWT checks include signature verification and confirm **issuer, audience, expiry**, and required claims and entitlements.
- A maintained, audit-ready record exists describing: the authoritative IdP/AS, protocol usage, claim/entitlement mapping, and device/NPE identity handling, aligned to **ia-13_odp.01** and **ia-13_odp.02**.

###### Actions Required for Compliance

- [ ] Connect the application to the approved identity provider (IdP) using OpenID Connect for user sign-in (authentication) flows
- [ ] Configure the application to accept and check signed JSON Web Token (JWT) access tokens, including the token’s issuer, intended audience, digital signature, expiry time, and any required claims.
- [ ] Set up Security Assertion Markup Language version 2.0 (SAML 2.0) sign-in sharing for the required legacy and partner connections, and require that any signed sign-in statements are validated.
- [ ] Set up X.509 device certificate authentication and map each certificate to the correct user or device identity for managed devices.
- [ ] Define and implement a standard way to map identity provider (IdP) and authorisation server (AS) outputs to application access decisions based on claims and entitlements.
- [ ] Create and keep up-to-date system design and configuration documents that explain how the identity provider (IdP) and attribute service (AS) are used, which protocols are used, and how user attributes and entitlements are mapped.


---

#### IA-13.1 — Protection of Cryptographic Keys (Enhancement)

This requirement is about keeping the secret keys that protect digital access tokens safe. These keys are what make tokens trustworthy and usable only by the right people. If the keys are created carelessly, stored poorly, or accessed by the wrong person, attackers could create fake tokens, pretend to be users, or view and alter access messages. This could lead to unauthorised access to important systems and data.

To meet this expectation, the organisation must:
- decide how strongly the keys need to be protected based on the level of harm if they are compromised
- ensure the keys are created for signing and protecting tokens
- manage the keys properly from when they are created, through any changes, and until they are retired
- store the private signing keys so only authorised staff can use them

The organisation must use approved methods and secure components to generate and handle keys, document how this is done in system design, configuration, and security planning, assign clear responsibilities, and keep records showing that key setup, changes, and destruction are carried out as required.

##### HSM-backed lifecycle management for token signing/encryption keys

- Category: Software
- Priority: Critical

###### WHAT
Set up secure processes for generating, storing, and managing the cryptographic keys used to sign and protect identity assertions and access tokens. This ensures private keys are kept safe from being revealed or misused.

###### WHY (control requirement)
IA-13(1) requires that cryptographic keys used to protect access tokens are generated, managed, and protected from disclosure and misuse. The level of protection must match the potential impact of the system and the information resources that could be accessed. This requirement expects that token-signing/private keys are protected throughout their entire lifecycle.

###### HOW (specific steps/approach)
1. **Set key protection levels based on impact** for token signing and token protection keys (for example, production privileged access tokens versus non-privileged tokens). For each level, define the required safeguards (for example, whether a hardware security module is required, the access approach, expectations for key rotation and retirement, and how long audit records are kept).
2. **Generate and use private keys inside a hardware security module (HSM) (or cloud HSM)** for the identity provider/authorisation service that issues and signs tokens. Make sure key generation, signing, and key protection (wrapping/encryption) all happen inside the HSM, so private key material never leaves approved key custody.
3. **Separate responsibilities and control key use**: limit HSM administration and key lifecycle actions (generate, activate, rotate, deactivate, retire) to authorised roles. Require approvals for high-impact key changes. Ensure application services can only request signing/encryption actions that they are permitted to perform.
4. **Run the full key lifecycle with events that can be audited**: put in place processes and automation for setting up keys, maintaining them, rotating/changing them, revoking/retiring them, and destroying them (including overlap/transition handling for verification). Collect evidence from the HSM/identity provider, such as key identifiers, activation and rotation times, operator approvals, and revocation events.
5. **Strengthen access to key management systems**: use phishing-resistant multi-factor authentication (MFA) for privileged operators, restrict administrative network access (for example, allow-listing, virtual private network (VPN), or bastion hosts), and record all administrative actions in the central security information and event management (SIEM) system.
6. **Document the design and configuration** in system design, configuration, and security planning documents, including: which keys are used for signing versus token protection, where keys are generated and stored, how rotation and retirement are carried out, and how access to private keys is restricted.

###### WHO
- **Identity and Access Management (IAM) Lead**: defines impact tiers and the required key protection levels.
- **Security Architect / Compliance Architect**: ensures alignment with IA-13(1) and approves the documentation and evidence approach.
- **Platform/Cloud Security Engineer**: implements HSM integration, access controls, and lifecycle automation.
- **HSM/Identity Provider Administrators**: carry out authorised key lifecycle actions according to the agreed procedures.

###### Acceptance criteria
- Private keys used for token signing and token protection are generated and used inside an HSM (or cloud HSM) and cannot be exported during normal operations.
- Key lifecycle actions (set up, rotate/change, retire/revoke, destroy) are carried out under defined procedures, with role-based authorisation and approval controls for high-impact keys.
- Central audit evidence is available for key events (activation/rotation/revocation/destruction) and administrative actions are logged to the SIEM.
- System design/configuration/security planning documentation clearly describes how token keys are generated, stored, used, protected, and managed through their lifecycle.
- Access to HSM/identity provider key management functions is limited to authorised roles, using phishing-resistant multi-factor authentication (MFA) and network controls.

###### Actions Required for Compliance

- [ ] Define the impact levels for token keys and link each level to the required safeguards, including whether a hardware security module (HSM) must be used, the access rules that must be followed, and expectations for key rotation and retirement.
- [ ] Connect the identity provider and authorisation service to a hardware security module (HSM) (or a cloud-based HSM) so that the keys used to sign and encrypt tokens are created and used inside the module.
- [ ] Set up role-based access control (RBAC) so only authorised roles can perform hardware security module (HSM) and identity provider (IdP) key lifecycle tasks, and ensure separation of duties for privileged actions.
- [ ] Set up automated key rotation and transition handling, and automated key revocation and retirement procedures, using overlap periods so the change can be verified.
- [ ] Turn on and centralise audit logs for important events and administrative actions, send them to the security information and event management (SIEM) system, and keep the evidence needed for audits.
- [ ] Secure access to the hardware security module (HSM) and identity provider (IdP) management systems by using multi-factor authentication (MFA) that cannot be tricked by phishing, and by limiting connections to approved network routes (such as a bastion host, virtual private network (VPN), or an allow-list).
- [ ] Update the system design, configuration, and security planning documents to explain how encryption keys are generated, stored, used, protected, and how evidence is kept for their lifecycle.


---

#### IA-13.2 — Verification of Identity Assertions and Access Tokens (Enhancement)

This requirement is about making sure that, before anyone is allowed into a system or to use an application, the organisation checks that the information used to prove who they are comes from a trusted source and has not been altered. Without these checks, an attacker could fake or change the information that confirms your identity or what you are allowed to do, potentially gaining unauthorised access or carrying out harmful actions at the right time.

To meet this expectation, the organisation must verify both the identity proof and the access permission “ticket” for trust and integrity every time access is requested. This includes checking the digital protections on them and confirming that the details included with the request (such as who or what is being accessed and when) are present and match what is being requested. Access must be refused if any of these checks fail. The organisation should also be able to demonstrate, using documented trusted sources and system records, that these checks are completed before access is granted.

##### PEP token & assertion verification with metadata claim checks

- Category: Software
- Priority: Critical

###### WHAT
Set up a **Policy Enforcement Point (PEP)** for all protected access routes (web, application programming interface (API), and service-to-service) to **check the source and integrity** of identity statements and access tokens **before allowing access**. The PEP must confirm **digital signatures** (or equivalent cryptographic integrity checks) and must also check the included information (known as **metadata/claims**), such as the **issuer**, **audience/resource**, **time validity**, and any **request-specific identifiers** where applicable.

###### WHY (control requirement)
NIST IA-13(2) requires that the **source and integrity of identity statements and access tokens are verified before access is granted**. The guidance specifies verifying **digital signatures that protect identity statements and access tokens** and checking **included metadata**, such as information unique to the user/system/resource being accessed and transaction details such as time.

###### HOW (specific steps/approach)
1. **Standardise trusted issuers and validation keys** for each environment and each protected resource type (for example: IdP issuer allow-list; JSON Web Token (JWT) JWKS endpoints/certificates; Security Assertion Markup Language (SAML) signing certificates). Configure the PEP to reject tokens/statements whose issuer/source is not on the allow-list.
2. **Do cryptographic checks at the PEP for every request**:
   - For JWT access tokens: verify the signature using the configured JWKS/certificates; enforce `iss`, `aud` (audience), `exp`/`nbf`/`iat` with an explicit clock-skew tolerance; require mandatory claims to be present.
   - For SAML assertions: verify the XML signature using the configured signing certificate(s); enforce assertion conditions (for example, the validity window) and required attributes.
3. **Check that the metadata/claims match the access request**:
   - Confirm the token/assertion claims match the target resource being accessed (for example: API identifier/resource/audience, tenant/environment, and any request-binding identifiers supported by your token format).
   - Enforce time-based rules (token lifetime, not-before, and any transaction time claims) before authorising.
4. **Deny by default if anything fails**: if signature/integrity checks fail, the issuer is not trusted, required metadata is missing, or metadata does not match the requested resource/transaction, the PEP must return an **access denied** response and must not continue to authorisation.
5. **Make checks auditable**: record structured audit events for each request outcome, including: whether the issuer matched, whether the signature was validated, whether metadata/claims were validated, and a failure reason code (without exposing sensitive token contents). Send these to **security information and event management (SIEM)** for monitoring and alerts on repeated failures.
6. **Prove it with automated tests**: add continuous integration/continuous delivery (CI/CD) tests that submit valid and invalid tokens/statements (wrong issuer, altered signature, expired token, wrong audience/resource, missing required claims) and confirm access is denied for all invalid cases.

###### WHO
- **Application/API owner**: ensures all protected endpoints route through the PEP.
- **Identity and Access Management (IAM) engineer**: sets up trusted issuers/keys and token validation settings.
- **Security engineer**: defines validation rules, failure reason codes, and the audit event format; ensures SIEM integration.
- **Developers**: implement/manage PEP middleware/gateway configuration and automated tests.

###### Acceptance criteria
- For every protected access route, the system performs cryptographic verification of identity statements and access tokens **before** any authorisation decision.
- Requests with an untrusted issuer/source, invalid/altered signatures, expired/not-yet-valid tokens, or inconsistent/missing required metadata are **denied**.
- Audit logs are produced for both allowed and denied outcomes, with verifiable reason codes for verification/metadata failures.
- Automated tests show denial for at least: wrong issuer, altered signature, expired token, wrong audience/resource, and missing required claims.

###### Actions Required for Compliance

- [ ] Choose and document which token or assertion types are used (for example, JavaScript Object Notation Web Tokens (JWT) or Security Assertion Markup Language (SAML)), and record the trusted issuer allow-list and the signing keys or certificates for each environment.
- [ ] Set up a PEP (policy enforcement point) — such as an API gateway, middleware, or service mesh component — so that every protected endpoint checks the required tokens or assertions before allowing access (authorisation).
- [ ] Validate digital cryptographic signatures, and require the presence and correct timing of specific claims—issuer (`iss`), audience (`aud`), and time limits (`exp`/`nbf`/`iat`)—using a defined allowance for clock differences (clock-skew tolerance).
- [ ] Add checks to ensure the token’s information (claims) matches the intended resource or transaction context, such as the correct audience and resource identifiers.
- [ ] Enforce a “deny by default” approach: reject access if any issuer, signature, or metadata check fails, and do not continue to authorisation.
- [ ] Set up structured audit logs that record whether access was allowed or denied, including verification details and a coded reason when metadata checks fail, and send these logs to the security information and event management (SIEM) system.
- [ ] Set up continuous integration and continuous delivery (CI/CD) checks to test both valid and invalid tokens and assertions, including cases such as the wrong issuer, a changed (tampered) signature, an expired token, the wrong audience or resource, and missing required claims. Confirm that access is denied for all invalid cases.


---

#### IA-13.3 — Token Management (Enhancement)

This requirement is about making sure that the permissions a system gives to people and services are created, used, changed, and cancelled in a controlled way. If these permission records are not managed properly, a stolen or misused permission could keep working for longer than it should, or it could be used to access the wrong system. This could lead to unauthorised access to sensitive data and services.

To meet this expectation, the organisation must have clear, documented procedures for the entire life of these permission records. This includes how they are created, issued, updated, and withdrawn. The organisation must also ensure that permissions are only valid for a limited time and only for the specific application or service they were intended for.

The organisation must revoke or invalidate permissions promptly when they are suspected to be compromised, lost, or no longer needed. It must also put the right systems in place and assign responsibility so these actions are carried out consistently.

##### Enforce token audience, short lifetimes, and revocation via IdP

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up the full life cycle for authentication assertions and access tokens so they are **created (issued)**, **renewed (refreshed)**, and **cancelled (revoked/invalidated)** in a controlled way. This must include **short, limited time periods** for how long tokens remain valid, and **limited permitted use** so tokens work **only for the intended application/security area**.

###### WHY (control requirement)
IA-13(3) enhancement requires that, in line with `{{ insert: param, ia-13_odp.01 }}`, authentication assertions and access tokens are managed throughout their life cycle, including:
- **Time limits** (tokens expire within agreed time periods)
- **Use limits (audience restriction)** (tokens are valid only for the intended application/security area)
- **Cancellation (revocation/invalidations)** when they are suspected to be compromised/lost or are no longer needed

###### HOW (specific steps/approach)
1. **Set token lifetime and renewal rules** in the enterprise identity provider (and/or token service) so access tokens and assertions have short, policy-defined `exp` values, and renewal is tightly controlled (for example, refresh token rotation with reuse detection where supported).
2. **Apply use limits at both creation and use**:
   - Configure the identity provider to issue tokens with the correct `aud` value for each relying party/application.
   - Configure each resource server/application to **strictly check** `aud` and `iss` (and the token signature) and to reject tokens where the `aud` value does not match.
3. **Put cancellation/revocation in place for compromise and decommission events**:
   - Use identity-provider-supported methods to invalidate sessions/tokens (for example, refresh token rotation with reuse detection; back-channel logout/session revocation where available).
   - Ensure the application/resource server follows the token-checking rules and, where supported, acts on revocation signals so revoked tokens cannot continue to be used.
4. **Operationalise the triggers for cancellation**:
   - Link the identity provider’s revocation actions to the organisation’s incident and identity processes (for example, account disablement, suspected compromise, contractor offboarding, and ending privileged access).
5. **Ensure life cycle events are auditable and ready as evidence**:
   - Turn on and keep identity-provider audit logs for token creation, renewal, and cancellation/revocation/invalidation events.
   - Link events to the requester identity, the application/resource involved, and the relevant change/incident/ticket references.

###### WHO (role responsible)
- **Identity & Access Management (IAM) lead**: identity provider configuration (token lifetimes, audience/use limits, refresh rotation, revocation methods).
- **Application security engineer / backend engineer**: strict token checks in resource servers (audience/issuer checks, signature verification, rejection logic).
- **SOC/IR lead**: ensure compromise triggers lead to timely cancellation/revocation/invalidation and appropriate monitoring.
- **Compliance/assurance**: check evidence (logs, configuration baselines) and confirm audit readiness.

###### Acceptance criteria
- Access tokens/assertions issued to the application have **configured maximum lifetimes** and reliably expire (confirmed by `exp`).
- Resource servers **reject** tokens with incorrect `aud` (and incorrect `iss`) and log the rejection.
- When an account is disabled or compromise is declared, the organisation can show **prompt cancellation/revocation/invalidation** (using identity-provider logs and/or revocation methods) and that any further access using the revoked token is blocked.
- Identity-provider audit logs show token creation, renewal, and cancellation/revocation/invalidation events with enough detail to support audit (who/what/when/which application/resource).
- Configuration is managed through controlled change management (for example, infrastructure-as-code) with peer review and traceability.

###### Actions Required for Compliance

- [ ] Configure the organisation’s identity provider (IdP) to enforce short, policy-defined lifetimes for access tokens and assertions, and to limit how refreshes can be performed.
- [ ] Issue tokens separately for each application so the `aud` (audience) claim matches only the intended application and security domain.
- [ ] Apply strict checks for the `aud` (audience) and `iss` (issuer) values in the token—reject any mismatch—along with verifying the token’s digital signature and expiry date.
- [ ] Where supported, enable refresh token rotation with reuse detection, and set up session and token revocation so that tokens are cancelled when a compromise is detected.
- [ ] Link user account lifecycle processes and incident-handling steps so that, when an account is disabled, suspected to be compromised, or being offboarded, the identity provider (IdP) can revoke or invalidate access.
- [ ] Enable retention of identity provider (IdP) audit logs for token issuance, token refresh, and token revocation or invalidation, and verify that the audit correlation fields are correct.

