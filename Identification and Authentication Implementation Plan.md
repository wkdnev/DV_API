### IA-1 — Policy and Procedures (Control)

This requirement ensures the organisation has clear, approved rules for how people are identified and how they prove they are who they say they are. It must also include practical, step-by-step guidance. Without this, the wrong people could gain access to systems, accounts could be created or changed incorrectly, and sensitive information could be exposed or misused—especially when job roles change or when laws and regulatory requirements are updated.

The organisation must create and document an identification and authentication policy for the whole organisation, for key business activities, and for relevant systems. The policy must explain why it exists, what it covers, who is responsible for what, how senior leadership supports it, how different teams work together, and how compliance will be checked. It must remain consistent with all relevant laws and internal standards.

A named IAM policy owner must be appointed within the Chief Information Security Officer (CISO) organisation to manage the policy. The policy must be shared with all users, privileged users, and identity administrators. The supporting procedures must be shared with the operational teams that carry out these processes.

The policy and procedures must be reviewed at least every year and also after audit findings, security incidents, breach reports, major role or human resources (HR) changes, or changes to applicable regulations and guidance.

##### CISO-owned IA policy & role-based procedures with trigger-based review

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish IA policy governance workflow (RACI, approval route, version control approach, trigger event definitions for policy vs procedures) | Compliance Manager | Enterprise | 16h | — |
| Draft organisation-approved IA policy (purpose, scope, roles & responsibilities, coordination with security/privacy, compliance/assurance approach, explicit mapping to applicable laws/regulations/standards/guidance) | Cyber Security Lead | Enterprise | 40h | — |
| Create role-based IA procedures (IAM administrators; system owners; HR/identity lifecycle managers; security operations) written as “how-to” with audience-specific triggers, evidence expectations, and exception handling | Security Engineer | Enterprise | 56h | — |
| Internal review, co-author validation, and approval pack preparation (security programme + privacy programme validation; IAM governance board submission and sign-off) | Compliance Manager | Enterprise | 24h | — |
| Dissemination and auditable acknowledgement process (publish IA policy to users/privileged users/identity administrators; publish procedures to defined audiences; implement acknowledgement workflow and retention of evidence) | Operations Lead | Enterprise | 24h | £3,000 |
| Implement trigger-based review & update mechanism (annual cadence + event-driven triggers; document review log; approval/updated/replaced outcomes; communications plan for changes) | Project Manager | Enterprise | 24h | — |
| Ensure system security/privacy plans reference IA policy/procedures (create guidance for system owners; verify linkage for representative systems; provide tailoring rules to avoid duplication) | System Design Authority | Enterprise | 16h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Appoint an “identity and access management (IAM) policy owner” within the Chief Information Security Officer (CISO) organisation, and set up the approval process through the IAM governance board.
- [ ] Create and get approval for the organisation’s information assurance (IA) policy using a structured template covering: purpose, scope, responsibilities, coordination, and how it maps to compliance requirements.
- [ ] Develop role-based identity and access management (IAM) procedures for identity and access management administrators, system owners, human resources (HR) and identity lifecycle managers, and security operations teams.
- [ ] Share and publish the information assurance (IA) policy with all users, privileged users, and identity administrators, and ensure their access and acknowledgement are recorded for audit purposes.
- [ ] Publish and share the information assurance (IA) procedures with the agreed audiences, and ensure access is auditable.
- [ ] Set document control to review and update the information assurance (IA) policy every year and whenever a triggering event occurs. Apply the same approach to the procedures, using their defined trigger events.
- [ ] Update your system security and privacy plans to point to the information assurance (IA) policy and procedures (or annexes) instead of repeating the same requirements.


---

### IA-2 — Identification and Authentication (Organizational Users) (Control)

This expectation is about making sure every person who works for the organisation has their own unique way to prove who they are, and that the system records their identity whenever they do anything—whether the work is carried out automatically on their behalf or not. Without this, actions could be credited to the wrong person, unauthorised access could go unnoticed, and it would be hard to investigate mistakes or misuse because you would not know who actually did what.

To meet this expectation, the organisation must keep a clear, up-to-date link between each employee and equivalent worker (including contractors and guest researchers) and a single, individual account that can be used to sign in, using an approved method such as a password, a physical device, or a biometric check. The organisation must also ensure the system logs the unique person identity for user actions, and that any automated processes acting on a user’s behalf still use the correct person’s identity—not a generic or shared login—unless this is explicitly allowed elsewhere.

##### Federated SSO with phishing-resistant MFA and user identity propagation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| IdP authoritative identity mapping: define immutable unique identifier strategy (e.g., IdP subject/unique user ID), configure HR/contractor/guest provisioning flows, and validate one-to-one user mapping | Identity & Access Management Engineer | Enterprise | 40h | — |
| Federated SSO integration: implement/adjust SAML/OIDC configuration for the application (issuer, audience, signing keys, claim mapping), and ensure the application stores/uses the IdP stable unique identifier as the accountable principal | Software Lead | Enterprise | 48h | — |
| Phishing-resistant MFA enforcement: configure conditional access policies for interactive network/remote access, require FIDO2/security keys (or equivalent), and define step-up rules for sensitive actions | Cyber Security Lead | Enterprise | 32h | £6,000 |
| Identity propagation for “processes acting on behalf of users”: implement job/workflow/API context propagation using signed claims/session context; ensure background tasks carry initiating user unique identifier into execution and audit events | Platform Engineer | Enterprise | 56h | — |
| Prevent accountability gaps: inventory shared/group authenticators and service identities used for user-attributed activity; remove or restrict them, and document any AC-14-exempt cases with compensating controls | Compliance Manager | Enterprise | 24h | — |
| Audit logging & SIEM evidence: implement audit log fields (authenticated unique user ID, IdP session correlation, initiating user for async actions), forward to SIEM, and create test queries/dashboards for audit-ready evidence | Operations Lead | Enterprise | 40h | £3,000 |
| End-to-end testing & acceptance evidence: execute test plan covering sign-in, MFA enforcement, claim mapping, async identity propagation, and audit log completeness; produce compliance evidence pack for IA-2 | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Integrate the application with the organisation’s identity provider (IdP) using OpenID Connect (OIDC) and/or Security Assertion Markup Language (SAML), and map the IdP’s permanent (immutable) subject identifier to the application’s user identity field.
- [ ] Set up conditional access so that anyone accessing the application through the network or remotely must use phishing-resistant multi-factor authentication (MFA).
- [ ] Set up identity propagation for asynchronous workflows and jobs so the audit record includes the unique identifier of the user who started the process.
- [ ] Set up application audit logging so that every user action is recorded with the unique identifier of the signed-in user, and send the logs to the security information and event management (SIEM) system.
- [ ] Identify and fix any shared or group login credentials used for actions linked to specific users, and record any AC-14 exceptions.
- [ ] Run an evidence test: start a user-led process that causes background work, then check that the security information and event management (SIEM) and application logs show the same initiating user’s unique identifier from start to finish.


---

#### IA-2.1 — Multi-factor Authentication to Privileged Accounts (Enhancement)

This requirement is about protecting the most powerful accounts in your systems. It ensures that people cannot gain access using only one simple check.

It matters because if a privileged account is protected only by a password or another single form of proof, an attacker who steals that password could take over systems, change who has access, or cause serious disruption.

To meet this expectation, your organisation must:
- Keep an up-to-date list of all privileged accounts.
- Require two or more different forms of proof for every login to each privileged account, whether the login is made on-site, from another device on your network, or from outside your environment.

Your organisation must choose the right combination of proofs based on the level of risk. You must then document and put this in place through clear identification and login rules, step-by-step procedures, system plans and designs, the actual system settings that enforce the requirement, and audit records showing when the extra proof was requested and successfully used (or when access was blocked).

##### Enforce MFA with two factor types for all privileged logons

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Build authoritative privileged account inventory (privileged groups/roles, privileged local admin accounts from endpoint inventory, and break-glass accounts) with automated discovery and change workflow | IAM Lead | Enterprise | 40h | £— |
| Standardise privileged MFA factor types (select ≥2 distinct factor types, define factor-type pairing rules, and publish configuration standards for IdP/PAM) | System Design Authority | Enterprise | 24h | £— |
| Implement IdP conditional access policies targeting privileged inventory to require MFA with the required distinct factor-type combination for all privileged sign-ins (including admin portals and privileged workflows) | Cyber Security Lead | Enterprise | 56h | £— |
| Configure PAM / jump host session brokering and step-up authentication so privileged actions from admin consoles and remote admin workflows cannot establish sessions without the required MFA | PAM Engineer | Enterprise | 48h | £— |
| Integrate remote access paths (VPN/remote access gateways and remote admin tooling) with IdP/PAM so privileged logons trigger MFA consistently across remote/network access | Infrastructure Lead | Enterprise | 32h | £— |
| Implement local access enforcement on endpoints: remove unmanaged local admin accounts where feasible and/or route local privileged elevation through managed PAM-mediated elevation covered by the privileged inventory | Endpoint/OT/Infrastructure Security Engineer | Department | 40h | £— |
| Implement audit evidence capture and SIEM forwarding: log privileged account identifier, sign-in attempt, MFA success/failure, factor types prompted/used (where supported), and access path (local/network/remote); validate retention and correlation | Security Operations Lead | Enterprise | 32h | £— |

| Total Estimated Effort | 272h | Total Estimated Cost | £0 |

###### Actions Required for Compliance

- [ ] Build and keep an authoritative list of privileged accounts, covering directory administrators, privileged local administrators, and “break-glass” accounts.
- [ ] Standardise which types of multi-factor authentication (MFA) are required for privileged access (for example, a password or personal identification number (PIN) plus FIDO2, or a smart card) and document this policy.
- [ ] Set up identity provider (IdP) conditional access so that multi-factor authentication (MFA) is required for all privileged groups and roles, using the specified combination of authentication factor types.
- [ ] Set up and configure privileged access management (PAM) and a jump host so that highly privileged administrator sessions are handled through the identity provider (IdP), and so that additional verification (step-up multi-factor authentication (MFA)) is required when needed.
- [ ] Set up virtual private network (VPN) and remote access, and remote administration tools, to work with the identity provider (IdP) and privileged access management (PAM) so that any remote login with elevated privileges triggers multi-factor authentication (MFA).
- [ ] Remove or control unmanaged local privileged accounts so local privileged logins cannot bypass multi-factor authentication (MFA), either through central management or by using privileged access management (PAM) to control any elevation of permissions.
- [ ] Enable and keep audit logs that record attempts to sign in using privileged access, and record whether multi-factor authentication (MFA) succeeded or failed, including evidence of the factor used. Send these logs to security information and event management (SIEM).


---

#### IA-2.2 — Multi-factor Authentication to Non-privileged Accounts (Enhancement)

This requirement is about making sure that people sign in to everyday, non-administrator accounts using two different ways to prove who they are, every time—not just a password. Without this, a stolen or guessed password could let an attacker get straight into systems and services, potentially leading to data loss, fraud, or wider harm.

To meet this expectation, the organisation must set out in its access and sign-in rules that every non-administrator account needs two or more different types of proof of identity. The types chosen must match the level of risk for how people connect—for example, whether they sign in locally, over a network, or from a remote location.

The organisation must then put these rules into practice through clear sign-in procedures, system design and configuration settings, and by keeping reliable records of sign-in activity and an up-to-date list of accounts. This is so it can demonstrate that the second proof of identity was required and enforced for all non-administrator users.

##### Enforce MFA for all non-privileged app logins via IdP

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm application authentication architecture and enumerate all supported sign-in paths (web/mobile/API/remote entry points) and identify any existing MFA bypass/legacy flows | System Design Authority | Department | 16h | — |
| Define “non-privileged” scope by mapping IdP groups/roles to application RBAC/least-privilege model, including service accounts and any exceptions | Compliance Manager | Enterprise | 12h | — |
| Configure IdP conditional access / sign-in policy to require MFA with two or more different factor types for the non-privileged groups (phishing-resistant where feasible) | Cyber Security Lead | Enterprise | 24h | — |
| Enforce MFA assurance at the application layer for federated sessions/tokens (e.g., validate MFA/assurance claims, reject tokens lacking required MFA context) across all environments | Security Engineer | Department | 20h | — |
| Eliminate MFA bypass paths: disable/limit “remember device”, legacy authentication methods, and any alternate single-factor credential paths for non-privileged users | IAM Lead | Enterprise | 16h | — |
| Implement/verify API and non-interactive flows use the same federated identity approach (OIDC/OAuth) and do not introduce alternate single-factor credentials for non-privileged users | Platform Engineer | Department | 16h | — |
| Create audit-ready evidence pack: retain IdP sign-in logs (MFA challenge/success/failure) and export policy/configuration artefacts (policy-as-code where available) for production/test/DR | Data Protection Officer | Enterprise | 14h | — |
| Establish ongoing reconciliation process for the non-privileged account list (group membership sync from IGA/HR/role assignments) and define cadence, ownership, and exception handling | Service Delivery Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 130h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define “non-privileged accounts” as an identity provider (IdP) group or role scope that excludes privileged and administrator roles.
- [ ] Set up the identity provider (IdP) so that, for that non-privileged access scope, users must use multi-factor authentication (MFA) with two or more different types of authentication factors when accessing the application.
- [ ] Require multi-factor authentication (MFA) at the application by only allowing sign-in sessions or tokens from trusted identity providers that confirm MFA has been completed.
- [ ] Disable or limit options that allow multi-factor authentication (MFA) to be bypassed (for example, older sign-in methods and weak “remember this device” behaviour) for non-privileged access.
- [ ] Check that multi-factor authentication (MFA) is enforced for every way users can sign in, including the website, mobile apps, and user-authenticated application programming interface (API) requests.
- [ ] Enable and keep identity provider (IdP) sign-in audit logs, and export the multi-factor authentication (MFA) and conditional access configuration as evidence.
- [ ] Carry out regular checks to reconcile the list of non-privileged accounts between the identity governance and administration (IGA) / identity provider (IdP) groups and the application’s user list.


---

#### IA-2.5 — Individual Authentication with Group Authentication (Enhancement)

This requirement is about ensuring that, even if a business uses shared logins or shared access tools, every person is still checked as an individual before they can use anything linked to a shared account. Without this, someone could misuse a shared login, or access could be granted without knowing who actually signed in. That makes it harder to prevent misuse and to identify responsibility after something goes wrong.

To meet this expectation, the organisation must clearly state in its access rules that an individual sign-in must happen before any shared account or shared resource is used. It must also explain in its system plans and design documents how the system enforces this rule.

Staff procedures and system settings must be set up so access is blocked until the individual check is successful. The system must also keep records showing that the individual check took place before access was granted.

The organisation must maintain an up-to-date list of shared accounts, and document both:
- the shared access method the system uses, and
- the individual sign-in method the system uses.

##### Enforce individual authentication before shared account access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Perform shared-account/authenticator access-path discovery and produce an inventory mapping shared accounts/authenticators to every shared resource/workflow | Compliance Manager | Enterprise | 24h | — |
| Define the “individual-authentication gate” enforcement design (block-until-success semantics, session freshness/expiry rules, backend-only use of shared credentials) and update threat model | System Design Authority | Department | 32h | — |
| Implement gate in application entry points (web/mobile/API and any admin/OT broker flows), including deny-by-default when individual auth context is missing/invalid/expired | Software Lead | Department | 80h | — |
| Implement shared-credential brokering so shared accounts are used only as backend credentials after successful individual authentication (no interactive/shared login paths) | Platform Engineer | Department | 40h | — |
| Add audit evidence generation and SIEM forwarding (structured logs with user identity, auth result, shared resource/account identifier, decision outcome) and configure retention alignment | Security Engineer | Enterprise | 32h | — |
| Update system security plan and design documentation to evidence the enforcement mechanism; include operational runbook notes for troubleshooting and incident handling | Compliance Manager | Enterprise | 16h | — |
| Execute end-to-end testing and acceptance validation (positive/negative cases, session expiry, replay attempts, multi-environment coverage) and produce test evidence pack | Quality Assurance Lead | Department | 40h | £2,000 |
| Deploy with change management controls (release packaging, configuration management, rollout/rollback plan, and verification in staging then production) | Project Manager | Business Unit | 24h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £2,000

###### Actions Required for Compliance

- [ ] List all application workflows that use shared accounts or shared authentication methods, and map each one to the shared resources it enables.
- [ ] Add an individual sign-in check to the application for every place where shared resources can be accessed (web, application programming interface (API), and administration actions). Block the request if the sign-in check is not met.
- [ ] Change how shared accounts are used so the shared login details are only used in the background after each person has successfully logged in individually (there is no shared, interactive login).
- [ ] Set up session checks so that operations on shared resources are blocked if the user’s authentication information is missing or has expired.
- [ ] Record an audit log for every shared-resource action, including the individual user’s identity, whether authentication succeeded or failed, and the identifier of the shared account or resource used; send the logs to security information and event management (SIEM).
- [ ] Update the system security plan and design documents to explain how the security controls are enforced, and keep the shared-account and authenticator inventory up to date.


---

#### IA-2.6 — Access to Accounts —separate Device (Enhancement)

This expectation is about making sure that when anyone logs in to your systems, they must prove who they are using more than one check. At least one of these checks must come from a separate physical device that is not the system they are trying to access.  

This matters because if attackers steal a password or trick a system into accepting it, they can pretend to be staff and gain access to both important (privileged) and everyday (non-privileged) accounts. This can happen whether they connect on-site, through your network, or from outside.  

To meet this expectation, the organisation must require multi-check login for local, network, and remote access to both privileged and non-privileged accounts. It must also ensure that the separate-device check uses validated cryptography, is hardware-backed (for example, a security key), and is designed to resist phishing attempts.  

The organisation should document what is covered in its login rules and procedures, configure systems to enforce it, keep records showing it is being used, and clearly assign responsibility for implementing and running the approach.

##### Enforce phishing-resistant MFA using FIDO2 hardware keys

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm application sign-in coverage for local, network, and remote access paths (including privileged/admin consoles) and document the required MFA enforcement points | System Design Authority | Enterprise | 16h | — |
| Define and publish MFA policy requirements for privileged and non-privileged accounts, including “separate-device” phishing-resistant factor requirement and allowed authenticator strength-of-mechanism criteria (FIPS 140-2 validated, hardware-backed, FIDO2/WebAuthn) | Compliance Manager | Enterprise | 12h | — |
| Configure IdP MFA/conditional access to require FIDO2/WebAuthn hardware keys for the defined sign-in contexts; block weaker MFA methods for those contexts | IAM/Identity Engineer | Enterprise | 24h | — |
| Implement enrolment and authenticator registration controls in the IdP (approved authenticators only, hardware-backed attestation where supported, and enforcement that MFA cannot be satisfied by target-system-stored credentials) | Security Engineer | Enterprise | 20h | — |
| Validate end-to-end authentication flows across interactive sign-in, admin interfaces, and remote access scenarios (e.g., VPN/remote browser) to confirm MFA is consistently triggered and phishing-resistant factor is used | Quality Assurance Lead | Enterprise | 16h | — |
| Integrate audit logging for MFA challenges/outcomes (including MFA method used and hardware-key usage indicators) and forward to SIEM with evidence-ready fields and alert hooks for repeated failures/bypass attempts | Operations Lead | Enterprise | 20h | — |
| Operationalise key enrolment, replacement, and time-limited exception handling (including compensating controls and governance workflow) with runbooks and training for IAM Operations/Service Desk | Service Delivery Manager | Business Unit | 18h | — |
| Execute change management, security review, and production rollout (including phased deployment to environments and rollback plan) | Project Manager | Enterprise | 14h | — |

**Total Estimated Effort:** 140h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Group every application login point into local access, network access, or remote access categories, and identify which user accounts are privileged versus non-privileged.
- [ ] Configure the identity provider (IdP) to require multi-factor authentication (MFA) for both privileged and non-privileged accounts for every defined sign-in situation, including local, network, and remote access.
- [ ] Only allow multi-factor authentication (MFA) methods from approved authenticators. Require hardware-based, phishing-resistant authenticators that have been validated to Federal Information Processing Standards (FIPS) 140-2, such as FIDO2/WebAuthn security keys.
- [ ] Ensure that the phishing-resistant multi-factor authentication (MFA) requirement is met using a separate physical device (a hardware security key), rather than using authentication methods linked to the target system.
- [ ] Set up and send audit logs to the security information and event management (SIEM) system. These logs must record the multi-factor authentication (MFA) method used, the results of each challenge, and whether each attempt succeeded or failed, so they can be used as evidence and to help detect threats.
- [ ] Publish and put into day-to-day operation the processes for enrolment, key replacement, and time-limited exceptions, with ownership assigned to identity and access management (IAM) and the security operations centre (SOC).


---

#### IA-2.8 — Access to Accounts — Replay Resistant (Enhancement)

This requirement is about ensuring that once a person has successfully proved who they are to sign in, they cannot reuse the same captured sign-in proof to get in again. Without this protection, an attacker could record a previous sign-in attempt and use it later, potentially gaining access to both normal accounts and more powerful privileged accounts. This could then lead to unauthorised changes, data exposure, or disruption to systems.

To meet this expectation, the organisation must clearly define and document that sign-in must be resistant to replay attacks for both privileged and non-privileged accounts. It must also select and record the specific method used (for example, a new one-time challenge or a proof that expires quickly each time), and update its sign-in rules, procedures, and system plans accordingly.

The organisation must configure live systems so both account types use only these replay-resistant methods, disable any weaker legacy options, keep audit records showing that replay attempts were blocked, and be able to demonstrate through testing and evidence review that replayed sign-in messages fail for both account types.

##### Replay-resistant authentication for privileged and non-privileged accounts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and standardise the IdP-enforced replay-resistant interactive authentication method (e.g., FIDO2/WebAuthn or certificate-based), including supported authenticators and account-type mapping (privileged vs non-privileged) | System Design Authority | Enterprise | 16h | — |
| Configure IdP authentication policies to require freshness for all interactive sign-in ceremonies for both privileged and non-privileged accounts; define ceremony parameters (challenge lifetime, replay protections, session binding) | Cyber Security Lead | Enterprise | 24h | — |
| Identify all relying parties and sign-in entry points (web/admin consoles, portals, API gateways, mobile clients) and enforce that they use the IdP replay-resistant flow (no custom authentication paths) | Infrastructure Lead | Department | 32h | — |
| Disable/block legacy or fallback authentication paths that are not replay-resistant (e.g., password-only, OTP without freshness, legacy SSO modes that permit replay) and document exceptions (if any) with compensating controls | Compliance Manager | Enterprise | 20h | — |
| Implement audit logging and evidence capture: ensure sign-in logs include account identifier, account type (privileged/non-privileged), authentication method, outcome, and failure reason codes; forward to SIEM | Security Engineer | Enterprise | 24h | £6,000 |
| Develop and execute replay-resistance test plan: capture a legitimate authentication exchange, attempt replay against the same relying party for both account groups, verify failure and confirm corresponding audit records | Quality Assurance Lead | Department | 24h | — |
| Produce compliance evidence pack for IA-2(8): configuration screenshots/exports, policy settings, SIEM query examples, test results, and sign-off against acceptance criteria | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 156h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Identify and label all interactive user account types used by the application’s access routes as either privileged or non-privileged.
- [ ] Set up the organisation’s identity provider (IdP) so that both account groups must use an authentication method that cannot be reused (for example, FIDO2/Web Authentication (WebAuthn) or certificate-based authentication).
- [ ] Disable or block older or fallback sign-in methods that do not provide freshness (a nonce or challenge, or a cryptographic or time-limited proof) for both privileged and non-privileged accounts.
- [ ] Update the application entry points (web, administration, and application programming interface (API) gateways, and any single sign-on (SSO) integrations) to use the identity provider’s replay-resistant authentication process rather than a custom authentication method.
- [ ] Set up and centralise sign-in audit logging, including the account type, how the user authenticated, and the reason codes for any failed sign-ins; send this information to security information and event management (SIEM).
- [ ] Run replay-resistance tests by recording a successful login exchange and checking that any replay attempts fail and are recorded in the logs for both privileged and non-privileged accounts.


---

#### IA-2.10 — Single Sign-on (Enhancement)

This requirement is about allowing people (and certain automated accounts) to sign in once and then automatically use multiple on-site business applications and identity-aware access points without repeatedly entering passwords. Without this, staff may reuse passwords in unsafe ways, access may be granted inconsistently across systems, and it becomes harder to understand and trace what happened if something goes wrong.

To meet this expectation, the organisation must put in place a single sign-on service that covers privileged user accounts, service accounts, and federation-managed application accounts for the specified on-site applications and identity-aware proxies. The organisation must also clearly document:

- the rules for checking identities  
- the overall security plan  
- step-by-step operating procedures for both single sign-on and identity checking  

In addition, it must document how the solution is built and configured, keep records of relevant sign-in and access activity, and maintain an up-to-date list of the exact accounts and services included.

##### Implement auditable SSO for in-scope privileged and service accounts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish and govern an **SSO scope register** (source of truth) covering in-scope on-prem enterprise applications and identity-aware proxies, including account types (privileged user, service, federation-managed application) and ownership | Compliance Manager | Enterprise | 24h | — |
| Perform **application/proxy federation design**: validate supported protocols (SAML 2.0/OIDC), define claim/role mappings, and produce per-application federation configuration specifications (including least-privilege authorisation model) | System Design Authority | Enterprise | 32h | — |
| Implement **IdP federation configuration** for all in-scope applications/proxies (SAML/OIDC endpoints, signing/encryption, attribute/claim mappings, role mapping rules) with version-controlled configuration artefacts | IAM Lead | Enterprise | 56h | — |
| Configure **privileged user strong authentication and session controls** at the IdP (conditional access/MFA, session lifetime, re-authentication rules, risk-based policies) aligned to organisational standards | Security Engineer | Enterprise | 40h | — |
| Implement **non-human SSO access patterns** for service accounts and federation-managed application accounts (workload identity / non-interactive federation), including scoping to minimum required authorisations and validation test cases | Platform Engineer | Enterprise | 40h | — |
| Enable **auditability and SIEM correlation**: ensure IdP and each in-scope application/proxy emit required logs; implement log forwarding, normalised identifiers (user/service principal, app/proxy, session/token IDs where available), and correlation rules/detections for SSO→resource access | SOC/SIEM Engineer | Enterprise | 48h | £6,000 |
| Produce **audit-ready documentation pack** (identification & authentication policy updates, system security plan/design, operational procedures, evidence checklist, and configuration runbooks) and complete review/approval | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 304h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create an SSO scope register that lists all in-scope on-premises enterprise applications and identity-aware proxies, including privileged user accounts, service accounts, and federation-managed application accounts.
- [ ] Set up identity provider (IdP) federation—using security assertion markup language (SAML) and/or openid connect (OIDC) where supported—for each in-scope application and for each identity-aware proxy, with the correct claim and role mappings.
- [ ] Require extra security for privileged users at the identity provider (IdP), including multi-factor authentication (MFA) and conditional access in line with organisational standards, and set how long sessions last and when users must sign in again.
- [ ] Set up non-interactive single sign-on (SSO) for service and federation-managed application accounts, using the identity provider’s (IdP’s) supported workload and federation methods, with least-privilege access permissions.
- [ ] Turn on and centralise audit logging for the identity provider (IdP) and each in-scope application or proxy, so that log records can be linked together—from the single sign-on (SSO) event to any later access.
- [ ] Update the identification and authentication policy and the system security plan/design to cover single sign-on (SSO) scope, the configuration approach, how user sessions behave, and the operational procedures.


---

#### IA-2.12 — Acceptance of PIV Credentials (Enhancement)

This requirement is about only allowing access when a person’s official identity badge is checked electronically and confirmed to be genuine. Without this, someone could use a fake, altered, or non-standard badge to enter buildings or access computer systems, putting staff, assets, and sensitive information at risk.

To meet this expectation, the organisation must only accept credentials that meet Personal Identity Verification (Personal Identity Verification–compliant credentials), including any derived versions, after the system electronically verifies each credential presented before granting access. The badge must be issued by a federal issuer that meets the required standards. The organisation must also have a clear, documented process for deciding which issuers it trusts, and then only accept credentials from issuers it has authorised as reliable.

The organisation must keep records showing which credentials were presented and the result of the electronic verification. It must also document this approach in its policies, system plans, procedures, and system settings, with clear responsibility assigned to the relevant teams.

##### Verify PIV credentials electronically via IdP with issuer allowlist

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IdP authentication/authorisation flow requirements for PIV electronic verification (success indicator required; deny on missing/failure) and map to application access decision points | System Design Authority | Enterprise | 16h | — |
| Implement issuer allowlist model and attribute extraction/normalisation (issuer identifier source from PIV middleware/gateway; derived credential issuer handling) | Security Engineer | Enterprise | 24h | — |
| Configure IdP conditional access rules to enforce: (1) successful electronic verification present, (2) issuer identifier matches allowlist, (3) derived PIV credentials produce verifiable verification outcome + issuer identity | Infrastructure Lead | Enterprise | 32h | — |
| Integrate/validate PIV middleware or gateway to ensure electronic verification result and issuer identity are available to IdP for every authentication attempt (including derived PIV) | Platform Engineer | Enterprise | 24h | £8,000 |
| Implement audit logging and evidence schema for every attempt (timestamp, principal mapping, credential identifier/surrogate, issuer identifier, verification result, allow/deny decision) and ensure SIEM forwarding/searchability | DevOps Lead | Enterprise | 20h | — |
| Execute end-to-end testing and negative test cases (verification failure, missing indicator, issuer mismatch, derived PIV scenarios) with evidence packs for audit | Quality Assurance Lead | Enterprise | 24h | — |
| Produce governance documentation and operational runbook (acceptance design, issuer authorisation process, change control workflow, periodic review responsibilities) | Compliance Manager | Enterprise | 16h | — |
| Establish change/configuration management for issuer allowlist (approval workflow, versioning, rollback plan, periodic review cadence) | Project Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Set up the identity provider (IdP) sign-in process so that it only issues an access token or session after a successful electronic personal identity verification (PIV) check has been confirmed.
- [ ] Set up a strict “deny” conditional access rule for situations where personal identity verification (PIV) is missing, fails, or cannot be completed.
- [ ] Set up and manage an approved list of federal issuers, and extract the wire issuer identity so it can be used as part of the authentication decision.
- [ ] Update the derived personal identity verification (PIV) credential mapping so the verification result and the issuer identity are available for allowlist checks.
- [ ] Enable audit logging for every sign-in attempt, including the credential identifier (or surrogate), the issuer identifier, the verification result, and the allow/deny decision; send the records to security information and event management (SIEM).
- [ ] Document the planned approach for accepting personal identity verification (PIV) credentials, how derived PIV information is handled, how the issuer is approved, and the day-to-day operational responsibilities in the system security documentation.


---

#### IA-2.13 — Out-of-band Authentication (Enhancement)

This requirement is about preventing unauthorised access by asking for a fresh, one-time code when a login or action looks risky. If someone tries to sign in from a new device, if suspicious behaviour is detected, if there are signs of increased threat, or if someone is attempting to access highly sensitive information or carry out powerful actions, the system must not rely on the usual login method alone.

Instead, it must ask you for a one-time passcode sent to an approved mobile number or generated in an approved authenticator app. It must then verify that passcode using a separate verification step before allowing the login or privileged action to continue. If the passcode is incorrect or cannot be verified, access must be blocked.

To meet this expectation, the organisation must clearly define and document when these checks apply, ensure the system is set up to support the approved passcode methods, keep evidence of the configuration, record events in audit logs, and assign clear responsibilities for running the process, setting up users’ approved contact methods, monitoring compliance, and administering and building the system.

##### Risk-triggered step-up OTP via approved mobile/app

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define risk/trigger conditions for step-up OTP (suspicious activity, new device, elevated threat indicators, secret data & privileged actions) and document mapping to IdP/app enforcement points | Compliance Manager | Enterprise | 16h | — |
| Configure IdP conditional access / risk-based step-up to require OTP via approved mobile number or authenticator app under the defined conditions | Cyber Security Lead | Enterprise | 24h | — |
| Implement application-level blocking so login/session establishment and privileged actions are denied until OTP verification succeeds (including failure/timeout handling) | Software Lead | Department | 32h | — |
| Configure and enforce approved factor registration and out-of-band delivery restrictions (no arbitrary phone numbers; rely on IdP factor/fallback configuration) | Infrastructure Lead | Enterprise | 16h | — |
| Map privileged actions to authorisation events (admin endpoints/API scopes such as secret read/export, IAM changes, data export, role changes) and ensure step-up is invoked consistently | System Design Authority | Department | 24h | — |
| Implement audit evidence generation and SIEM forwarding (trigger reason, OTP required, success/failure, correlation identifiers: user/device/session/action) and validate log completeness | Security Engineer | Enterprise | 24h | — |
| End-to-end testing and operational readiness (test plans, negative cases, retry/validity limits, regression testing, runbooks, and audit evidence review) | Quality Assurance Lead | Team | 24h | — |

Total Estimated Effort: **160h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Set identity provider (IdP) “step-up” authentication rules so that a one-time password (OTP) is required when there is suspicious activity, when a new device is used to sign in, when elevated threat alerts are triggered, or when secret or privileged actions are performed.
- [ ] Set up one-time password (OTP) delivery so it uses only the approved methods: one-time password (OTP) via an approved mobile number and/or an authenticator app.
- [ ] Block access so that sessions and privileged actions cannot continue until one-time password (OTP) verification is successful (deny if verification fails or times out).
- [ ] Create and keep an auditable, approved list of out-of-band verification factors using the identity provider’s factor registration rules (no one-off or ad-hoc phone entries).
- [ ] Set up and send audit records to the security information and event management (SIEM) system that include the reason an one-time password (OTP) was required, and whether the one-time password (OTP) succeeded or failed, using matching reference identifiers to link related events.
- [ ] Link the map application’s privileged endpoints and application programming interface (API) access scopes to the identity provider (IdP) step-up trigger, so that any access to secret data or privileged actions requires out-of-band verification.


---

### IA-3 — Device Identification and Authentication (Control)

This requirement is about making sure every device that tries to connect to your organisation’s network proves it is who it claims to be before it is allowed in. Without this, an unauthorised or fake device could connect, watch activity, steal data, or disrupt services, because the network would not have a reliable way to tell trusted devices from impostors.

To meet this expectation, the organisation must clearly define:
- which types of network devices are covered (for example, computers and servers, and any relevant internet of things (IoT) devices, identified by specific device and/or by device type), and
- which networks are covered (local and/or remote).

The organisation must also create and keep up to date:
- an approved policy,
- documented procedures, and
- system plans

showing how devices are uniquely identified and verified. It must maintain a current list of the specific devices that must be verified, and configure the network so connections are blocked until the device verification succeeds.

The organisation must decide how strong the verification needs to be based on how important the systems are and the business needs. Where verifying every device is not practical, the organisation may limit the scope to specific device types or numbers.

##### Enforce device identity authentication before network access (802.1X)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define control scope and device/network inventory for 802.1X (in-scope device types, networks, environments, and exception candidates) | Compliance Manager | Enterprise | 24h | — |
| Design target architecture for 802.1X EAP-TLS (RADIUS integration, certificate trust model, identity-to-authorisation mapping approach, VLAN/VRF/ACL outcomes) | System Design Authority | Enterprise | 32h | — |
| Establish/extend PKI workflow for unique device credentials (registration, approval gates for new device types, certificate lifecycle/renewal, revocation strategy) | Data Protection Officer | Enterprise | 40h | £8,000 |
| Configure RADIUS and network access policy rules (certificate validation, authorisation mapping from certificate subject/SAN to network access outcomes, default-deny posture) | Security Engineer | Enterprise | 48h | £3,000 |
| Implement 802.1X enforcement on wired and Wi‑Fi infrastructure (switch/controller configuration baselines, EAP-TLS settings, role/VLAN assignment enforcement, staged rollout) | Infrastructure Lead | Business Unit | 56h | — |
| Validate authentication strength and evidence requirements (revocation checking where feasible, test plans, success/failure verification, audit evidence retention configuration) | Cyber Security Lead | Enterprise | 24h | — |
| Define and approve exception process for any unavoidable legacy/shared methods (time-bounded approvals, compensating controls, remediation plan, monitoring triggers) | Compliance Manager | Enterprise | 16h | — |
| Pilot and operationalise (run pilot with representative device types, tune policies, create runbooks, change management artefacts, and handover to operations) | Service Delivery Manager | Department | 32h | £2,500 |

Total Estimated Effort: **272h**  
Total Estimated Cost: **£13,500**

###### Actions Required for Compliance

- [ ] Define and publish which device types/devices and which networks are covered (in scope) for IA-3 enforcement.
- [ ] Provide a unique X.509 certificate for each in-scope device through an approved certificate authority (CA) and registration process.
- [ ] Set up Remote Authentication Dial-In User Service (RADIUS) to check device certificates used for Extensible Authentication Protocol—Transport Layer Security (EAP-TLS), and link the device identities to the approved rules for network access.
- [ ] Turn on IEEE 802.1X (Extensible Authentication Protocol – Transport Layer Security (EAP-TLS)) for wired network ports and Wi‑Fi network names (service set identifiers (SSIDs)), using a “deny by default” approach so unauthenticated devices are blocked.
- [ ] Disable any fallback “shared secret” authentication method (for example, media access control (MAC)), or allow it only under strict exception control. Document the compensating controls that will be used instead.
- [ ] Set up log retention and reporting from the Remote Authentication Dial-In User Service (RADIUS) and network access controllers to provide evidence that users were authenticated before they connect.
- [ ] Document and get approval for authentication strength settings (certificate profiles, checks, and certificate revocation handling) for each security category.


---

#### IA-3.1 — Cryptographic Bidirectional Authentication (Enhancement)

This requirement is about ensuring that, before any connection between systems is allowed, both sides prove their identities to each other using strong cryptographic security checks. This matters because, if gateways and services that handle Confidential or Secret information can connect without verifying each other, an attacker could pretend to be a trusted service, intercept or alter data, or gain unauthorised access through a fake connection.

To meet this expectation, the organisation must clearly state which federated identity gateways, application programming interface (API) gateways, and service-to-service peers that handle Confidential or Secret data are in scope. It must also confirm that the rule applies to network and remote connections (not local ones).

The organisation must document how it will meet this requirement in its security planning and design. It must keep written procedures and an up-to-date list of the specific devices or service types involved. It must assign named responsibilities to the right people, configure the systems so connections fail unless both sides complete cryptographic mutual authentication, and keep evidence—such as configuration records and connection logs—showing authentication happens before any protected data is exchanged.

##### Enforce mutual TLS for network/remote Confidential-traffic

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define in-scope scope boundaries and peer allowlisting model for Confidential/Secret network/remote connections (destination → allowed peer identity mapping rules, including certificate attribute binding) | Security Architect | Enterprise | 24h | — |
| Select and standardise mTLS termination/enforcement points (gateway vs service mesh vs workload layer) and produce target architecture + configuration blueprint for “authentication before connection” | System Design Authority | Enterprise | 20h | — |
| Implement mTLS enforcement at the connection boundary for all in-scope services (require client cert, validate server cert, abort on handshake failure, enforce identity match to allowlist) | Platform Engineer | Department | 56h | — |
| Integrate certificate issuance/rotation and trust management (CA integration, trust store distribution, short-lived cert option where feasible, automated renewal) | Security Engineer | Enterprise | 40h | £12,000 |
| Update application/service clients to present correct client credentials and handle mutual-auth failures safely (no fallback to unauthenticated sessions; clear error handling) | Software Lead | Business Unit | 28h | — |
| Implement audit evidence capture and operational monitoring (handshake success/failure logging with peer identity, configuration snapshotting, SIEM/SOC alerting for failed mutual auth) | Compliance Manager | Enterprise | 24h | £6,000 |
| Execute test and assurance (integration tests for authorised/unauthorised peers, negative tests for missing/invalid certs, evidence pack generation for audit) | Quality Assurance Lead | Department | 32h | — |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of all in-scope federated identity gateways, application programming interface (API) gateways, and service-to-service connections that handle Confidential/Secret information.
- [ ] For each in-scope connection path, define an approved (allowlisted) link between the identity on the certificate and the target peer, using the certificate identity, subject alternative name (SAN), SPIFFE ID, and/or URI.
- [ ] Set up API gateways and/or service-to-service connections so that both sides must present certificates. Require client certificates and verify server certificates for network and remote traffic (mutual Transport Layer Security (mTLS)).
- [ ] Set up “policy-as-code” rules to block connections when the other party’s identity does not match the approved (allowlisted) identity mapping.
- [ ] Check that the connection setup fails at the point where Transport Layer Security (TLS) meets the application when mutual authentication is not successful—meaning there is no authenticated session unless the handshake completes successfully.
- [ ] Turn on and keep audit logs showing Transport Layer Security (TLS) connection handshake results and the identity of the other party, and store configuration evidence for mutual Transport Layer Security (mTLS) enforcement policies.
- [ ] Set up automated certificate issuing and rotation, and test certificate renewals, so that mutual authentication is continuously enforced.


---

#### IA-3.3 — Dynamic Address Allocation (Enhancement)

This requirement ensures that when devices receive network addresses automatically, the information recorded for each device is the same every time and can be checked later. Without this, the same device could be recorded differently each time it connects, which makes it harder to identify which device used which address, investigate issues, or detect suspicious activity. It also increases the risk of mistakes when managing devices.

The organisation must configure its automatic address assignment service so that every device that connects dynamically gets the same standard set of recorded details, including the device name, a client identifier, the device’s network hardware address, and the device type or vendor class. The organisation must also use an eight-hour lease duration for dynamic clients.

Whenever an address is assigned to a device, the organisation must record and keep an auditable log that shows the lease details and confirms the eight-hour duration for that specific assignment.

##### Standardise DHCP lease metadata and enforce 8-hour dynamic leases

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Inventory DHCP estate: identify all DHCP scopes, DHCP servers, and any failover/replication pairs; confirm which scopes serve dynamic clients | Infrastructure Lead | Enterprise | 16h | — |
| Define standard DHCP lease metadata requirements and mapping: hostname, client identifier, MAC binding, vendor class (including how each is sourced and normalised) | Security Engineer | Enterprise | 8h | — |
| Configure DHCP scope/server options to enforce required metadata fields for dynamic clients (hostname, client identifier, MAC binding, vendor class) | Network Engineering Lead | Enterprise | 24h | — |
| Set dynamic lease duration to exactly 8 hours across all relevant scopes and verify failover/partner settings align (including any partner/replication timing considerations) | Infrastructure Lead | Enterprise | 16h | — |
| Enable auditable lease assignment recording and retention: ensure lease database/log settings capture required fields and the 8-hour duration (or equivalent start/expiry that yields 8 hours) | Operations Lead | Enterprise | 24h | — |
| Implement central evidence collection: export/forward DHCP lease assignment events to SIEM/log platform; ensure events are searchable by MAC, hostname, and client identifier | DevOps Lead | Enterprise | 24h | £3,000 |
| Build audit-ready reporting: produce a device-level lease history report that returns assignment history and validates 8-hour duration for each MAC/hostname/client identifier | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **148 Hours**  
Total Estimated Cost: **£3,000**

###### Actions Required for Compliance

- [ ] Identify and list all Dynamic Host Configuration Protocol (DHCP) scopes and all DHCP servers (including any failover or replication partners) that assign Internet Protocol (IP) addresses to devices that request addresses dynamically.
- [ ] Configure each relevant Dynamic Host Configuration Protocol (DHCP) scope to capture and record the following details for dynamic leases: host name, client identifier, Media Access Control (MAC) address binding, and vendor class.
- [ ] Set the dynamic client lease duration to exactly 8 hours on every relevant Dynamic Host Configuration Protocol (DHCP) scope, and check that the failover partner settings match.
- [ ] Set up Dynamic Host Configuration Protocol (DHCP) lease database and event logging so that every time an IP address is assigned, the system records the required lease details and the lease length of 8 hours (or a start and expiry time that results in 8 hours).
- [ ] Send Dynamic Host Configuration Protocol (DHCP) lease assignment logs and events to the central security information and event management (SIEM) and log management platform, including the device’s media access control (MAC) address, hostname, and client identifier.
- [ ] Create an audit-ready report or query that returns, for each device, the full history of lease assignments, includes the required supporting information (metadata), and verifies that each lease lasts for 8 hours.


---

#### IA-3.4 — Device Attestation (Enhancement)

This requirement is about ensuring a device is only trusted when it is in the exact condition the organisation expects, and that any updates do not break that trust. Without this, a device could be changed or updated in an unauthorised way and still be allowed to connect. That could let attackers get in by using a device that appears normal, and then gain access to systems.

To meet this expectation, the organisation must:
- Identify and verify devices using a cryptographic check that confirms the device matches its known, approved configuration or state.
- Manage every patch and software update through its approved configuration management process, supported by its central device records, using secure updates.

After any change that could affect the device’s condition, the organisation must:
- Re-check the device’s attestation value so the device can still be correctly identified and verified.
- Keep clear records of the approved changes and the re-checks after each change, so auditors can trace what happened.

##### Attestation-based device auth with CMDB-backed secure updates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define attestation basis and “known-good state” specification (cryptographic inputs, measurement sources, hash/manifest format, device class/environment mapping, failure semantics) | System Design Authority | Enterprise | 24h | — |
| Design CMDB-backed attestation baseline model (schema, identity linkage, baseline versioning, association to approved change records, retention/evidence requirements) | Architect | Enterprise | 32h | — |
| Implement CMDB integration for baseline retrieval and verification decisioning (API/contracts, caching strategy, baseline selection rules, error handling) | Platform Engineer | Enterprise | 40h | — |
| Implement attestation verification at access decision point (integration with ZTNA/conditional access/authorisation service; allow/deny logic; policy controls; test harness) | Cyber Security Lead | Enterprise | 48h | — |
| Implement secure update enforcement via approved CM pipeline (signed artefact verification, deployment gating, update provenance, ensuring attestation inputs remain consistent) | Operations Lead | Department | 40h | £25,000 |
| Implement post-change attestation hash revalidation workflow (trigger on approved change, re-attestation execution, pass/fail recording, automated access blocking on failure) | DevOps Lead | Department | 40h | — |
| Establish audit-ready traceability and evidence pack (log correlation model, evidence retention, dashboards/reports, sample evidence generation for audits) | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £25,000

###### Actions Required for Compliance

- [ ] Define the cryptographic attestation basis and the exact “known configuration/state” inputs that will be hashed (converted into a fixed-length digital fingerprint) and measured.
- [ ] Set up attestation checks based on the configuration management database (CMDB) for each type of device and each environment, and link them to approved change records.
- [ ] Implement an attestation verification service that checks the device’s live attestation values against the configuration baseline stored in the configuration management database (CMDB).
- [ ] Add checks that verify device identity into the organisation’s access decision step (for example, zero trust network access (ZTNA) or conditional access) so access is granted only when the device verification matches.
- [ ] Set up the approved configuration management (CM) process so that only patch or update files that have been verified for integrity are deployed, and so that configuration management database (CMDB) records are updated as part of the change process.
- [ ] Automate the re-checking of attestation hash values after changes, and record whether the link passed or failed against the matching change record.
- [ ] Set enforcement for revalidation failures by blocking access that depends on attestation, and requiring remediation or re-baselining through the change control process.


---

### IA-4 — Identifier Management (Control)

This requirement is about making sure every person, team, service, or device has the correct name or label in our systems, and that those labels are not accidentally given to the wrong thing. If we do not do this, an unauthorised person could gain access, or a previous user’s label could be reused, allowing someone to inherit permissions or data they should not have.

To meet this expectation, the organisation must only assign an identifier (such as a username, group or role name, service name, device token, or device network address) after getting approval from the information system owner and the designated administrator. The identifier chosen must clearly refer to the intended person, team, role, service, or device, and it must be assigned to that intended entity.

Once an identifier has been used, it must not be reused for any other entity for 12 months. The organisation must also have clear procedures and keep records showing how identifiers are managed.

##### Authorised identifier lifecycle with 12-month non-reuse hold

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define identifier lifecycle governance model (identifier types, metadata schema, lifecycle states, approval roles, exception policy for reuse) and publish control-aligned procedure | Compliance Manager | Enterprise | 24h | — |
| Design IAM workflow gate for identifier creation/binding (two-approver requirement: information system owner + designated IAM administrator) including workflow states, audit fields, and rejection behaviour | System Design Authority | Enterprise | 32h | — |
| Implement unambiguous identifier-to-entity mapping validation (format rules, uniqueness constraints, target-entity record resolution, and provisioning API/consoles enforcement) | Security Engineer | Enterprise | 40h | — |
| Implement 12-month non-reuse enforcement (retire → tombstone/reserved with release date; block reuse attempts; controlled exception path with justification + compensating controls) | IAM administrator | Enterprise | 48h | — |
| Develop and integrate audit evidence pipeline (immutable event logging for request/approvals/outcome/retirement/hold status; export to SIEM/log archive; retention alignment) | DevOps Lead | Enterprise | 32h | £8,000 |
| Build test plan and execute validation (unit/integration tests, negative tests for missing approvals and reuse during hold; evidence verification and sampling readiness) | Quality Assurance Lead | Enterprise | 32h | — |
| Rollout and operational readiness (runbooks, monitoring/alerting for blocked actions, training for approvers, change management package, and go-live support) | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Define which identifier types and formats are approved for the application or system, including service and device token or address identifiers, and specify the required ownership information (metadata).
- [ ] Set up the identity and access management (IAM) and identity governance and administration (IGA) workflow so that new identifiers cannot be created, and identifiers cannot be linked to access, unless approvals are recorded from the information system owner and the designated IAM administrator.
- [ ] Implement provisioning checks to ensure each identifier matches one and only one intended entity record.
- [ ] Add a 12-month “reserved/held” (tombstone) period when an identifier is retired, and reject any attempt to reuse that identifier during the hold period.
- [ ] Set up an auditable exception process for any attempt to reuse something during the hold period, including a recorded reason and compensating controls.
- [ ] Send unchangeable lifecycle audit records (requests, approvals, identifiers, how items are linked, dates and times, and whether they are on hold or released) to security information and event management (SIEM) as evidence.


---

#### IA-4.1 — Prohibit Account Identifiers as Public Identifiers (Enhancement)

This requirement is about making sure a person’s internal login name is never the same as the public details people use to contact or identify them, such as the part of their email address before the “@” or their instant messaging handle. If internal names match public details, attackers can more easily guess valid usernames and then target accounts more effectively.

To meet this expectation, the organisation must set clear written rules for staff and system administrators that explicitly forbid assigning matching internal and public identifiers for individual accounts. The organisation must also explain how to check this when creating new accounts and when making changes to existing accounts.

The system should block or correct any attempt to create or update an account where the internal identifier matches the public identifier. It should also keep records showing these checks were carried out.

The organisation must document how the system enforces this rule and retain the relevant policy, procedure, configuration, design, and audit evidence.

##### IdP provisioning rule to block internal IDs matching public identifiers

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm IdP/directory field mapping for `internalIdentifier` and public identifiers (email local-part and any IM handle attributes), including case-normalisation rules | System Design Authority | Enterprise | 8h | — |
| Design provisioning-time validation logic (pre-create/pre-update) for case-insensitive equality checks: `internalIdentifier` vs `emailLocalPart`, and vs each configured `imHandle` attribute; define reject vs auto-correct/approval workflow | Cyber Security Lead | Enterprise | 16h | — |
| Implement IdP provisioning hook/workflow enforcement (including error handling, governance integration for exceptions, and unit/integration tests with representative identity data) | Software Lead | Enterprise | 40h | — |
| Implement scheduled reconciliation job to detect drift (accounts created/updated outside the normal workflow), generate remediation tickets/alerts, and produce a remediation backlog | DevOps Lead | Enterprise | 24h | — |
| Configure audit evidence: ensure provisioning events record evaluation outcome (pass/fail) and the specific fields checked (`emailLocalPart`, `imHandle`), with retention aligned to enterprise logging standards | Compliance Manager | Enterprise | 16h | — |
| Update system security documentation (system security plan/design/config notes) describing enforcement point, exact fields compared, match logic, and exception handling (reject/auto-correct/approval) | Security Engineer | Enterprise | 12h | — |
| Run pilot rollout and operational readiness (monitoring dashboards/alerts, rollback plan, and sign-off against acceptance criteria) | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 132h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Identify the internal account identifier field that is used for login in the identity provider (IdP) or directory.
- [ ] Identify the official public contact details used for communication within the same identity provider (IdP) or directory—specifically the email address local part and any instant messaging (IM) handle details.
- [ ] Set up “before create” and “before update” checks so the system compares the internal identifier with the email address local part (case-insensitive), and also compares it with the relevant instant messaging (IM) handle(s) where applicable.
- [ ] Set enforcement rules to block or automatically fix prohibited matches, and log the result of the decision.
- [ ] Turn on and keep audit records for provisioning attempts, including which public identifier fields were checked and whether they matched.
- [ ] Set up a scheduled reconciliation job to check for any account changes or non-compliant accounts that were created outside the approved workflow, and raise alerts if any are found.
- [ ] Update the system security plan, design, and configuration documents to explain how enforcement works, which fields are checked against each other, and how exceptions are handled.


---

#### IA-4.4 — Identify User Status (Enhancement)

This requirement is about ensuring that every person who needs access is clearly and uniquely identified as one of three types: contractor, foreign national, or non-organisational user. This matters because if people are not correctly identified, the organisation may give the wrong level of access, apply the wrong rules, and misunderstand who is behind messages or requests—raising the risk of unauthorised activity and mistakes.

To meet this expectation, the organisation must:
- define and document only these three status categories
- use a single unique identifier for each person
- record the correct status against that identifier, so it is always one of the allowed values and is never left blank or assigned to more than one status at the same time

The organisation must also have clear written procedures for creating, updating, and correcting identifiers and account records. It must keep a documented list of the characteristics used to decide a person’s status, keep evidence showing how the status was decided, and assign named responsibilities to the appropriate staff to manage and oversee this process, including the system administrators who implement it.

##### Enforce single user-status attribute for contractor/foreign/non-org

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define canonical `userStatus` taxonomy (exactly `contractor`, `foreign national`, `non-organisational user`), including mapping rules and documentation for IAM administrators and application owners | Compliance Manager | Enterprise | 16h | — |
| Extend enterprise directory/IdP user schema to add dedicated single-valued required attribute `userStatus`, including immutability/anti-reuse constraints on the identifier-to-object mapping | System Design Authority | Enterprise | 24h | — |
| Configure identity provisioning/workflow policy-as-code to enforce allowed values and reject account creation/activation when `userStatus` is missing or invalid (including test cases for negative scenarios) | Security Engineer | Enterprise | 32h | — |
| Implement evidence capture: store originating workflow/ticket/attestation reference alongside `userStatus` assignment in provisioning metadata and ensure it is retrievable for audit | Data Protection Officer | Enterprise | 16h | — |
| Propagate `userStatus` to the application via authenticated claims (or secure directory lookup) and update application logging to record security-relevant events with resolved `userStatus` (or deterministic reference) | Software Lead | Department | 24h | — |
| Update application identification/authentication policy and the system security plan to document the control mechanism, responsibilities, and activation preconditions (including audit evidence locations) | Compliance Manager | Enterprise | 16h | — |
| End-to-end testing and audit readiness: run integration tests across environments (dev/test/prod), validate uniqueness/single-status per identifier, and produce an audit pack (screenshots/config exports, test results, evidence samples) | Quality Assurance Lead | Department | 24h | — |

**Total Estimated Effort:** 152h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and publish the only allowed user-status values: contractor, foreign national, non-organisational user.
- [ ] Add a required, single-value directory attribute (for example, `userStatus`) to the authoritative identity store for the human identities that apply.
- [ ] Set up the account provisioning and workflow checks so that account creation or activation is rejected if the user status is missing or not one of the approved values.
- [ ] Ensure the application identifier mapping uses an unchangeable directory record, so each identifier uniquely links to one person.
- [ ] When you set `userStatus`, record an evidence reference (for example, onboarding ID, ticket ID, or attestation ID) at the same time, and keep it for audit purposes.
- [ ] Update the application to read the `userStatus` claim/attribute and include it in logs that are used for security monitoring.
- [ ] Update the identification and authentication policy and the system security plan to document the status-management mechanism and the named responsibilities.


---

#### IA-4.5 — Dynamic Management (Enhancement)

This requirement is about only creating and linking a person’s system identity after you have properly checked who they are, and then removing it promptly when they no longer need access. Without this, a system could accidentally or incorrectly give access to the wrong person, or leave access in place after someone’s role ends—raising the risk of unauthorised use, fraud, or data exposure.

To meet this expectation, the organisation must document a clear policy for “dynamic identifiers” that states:
- identifiers are issued and linked only at the time access is granted, and only after the organisation’s official identity checker has successfully verified the person’s credentials; and
- identifiers are revoked when the account or access ends, no later than 24 hours after termination.

The organisation must also:
- document and follow procedures for handling identifier and account termination;
- include this approach in its system security plan and design;
- configure the system so it operates in this way;
- keep evidence from system settings and audit records showing when verification and revocation happened; and
- assign named individuals responsible for managing identifiers, overseeing compliance, and building and maintaining the required system behaviour.

##### JIT dynamic identifiers issued only after IdP validation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the dynamic identifier policy (ia-04.05_odp) implementation requirements, including definition of “termination”, 24-hour revocation SLA, and evidence requirements | Compliance Manager | Enterprise | 16h | — |
| Update application security design and runtime flow to enforce identity-first binding (no internal identifier creation/binding until IdP token/assertion validation succeeds) | System Design Authority | Enterprise | 24h | — |
| Implement deterministic claims-to-identifier mapping (IdP subject/unique identifier + tenant/application scope) with audit-safe, reproducible identifier generation | Software Lead | Business Unit | 32h | — |
| Implement termination-triggered revocation mechanism (IdP lifecycle event subscription and/or reconciliation job) and ensure identifier/access removal completes within 24 hours | Platform Engineer | Business Unit | 40h | — |
| Add auditability and evidence logging for identifier lifecycle (validation success, issuance/binding timestamp, revocation timestamp, termination reason/source) and integrate with central logging/SIEM | Security Engineer | Enterprise | 24h | — |
| Create automated tests and operational runbooks (unit/integration tests for “no bind before validation”, revocation SLA tests, and incident/rollback procedures) | Quality Assurance Lead | Department | 24h | — |
| Configure and validate IdP lifecycle event delivery (webhooks/event bus), including signing/verification, retry/backoff, and operational monitoring/alerting for missed termination events | Infrastructure Lead | Enterprise | 24h | £6,000 |
| Total Estimated Effort |  |  | **204h** |  |
| Total Estimated Cost |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Document the policy for dynamic identifiers, including that they are issued and linked only after the authoritative identity provider (IdP) has validated credentials, and that they are revoked within 24 hours of termination.
- [ ] Set the authoritative identity provider (IdP) as the single system that verifies the relevant identities, and enable lifecycle and termination events so that disabling accounts and removing entitlements are recorded.
- [ ] Implement just-in-time (JIT) runtime identifier issuance so the application creates and links internal identifiers only after it has successfully validated the OpenID Connect (OIDC) or Security Assertion Markup Language (SAML) token or assertion.
- [ ] Define and implement fixed rules that map claims to identifiers in a consistent way, so results can be reliably linked and audited.
- [ ] Set up account-access revocation to happen when termination is confirmed, using identity provider (IdP) notifications and/or regular checks, and ensure access is revoked within 24 hours.
- [ ] Add audit logs for key identifier lifecycle events, including validation success, the time the identifier was issued or bound, and the time and reason for revocation. Then check that the logs are kept for the required period and can be searched to provide audit evidence.
- [ ] Assign named owners for managing the full lifecycle of identifiers and for generating evidence, and run an end-to-end test that proves both issuance and revocation within 24 hours.


---

#### IA-4.6 — Cross-organization Management (Enhancement)

This requirement is about making sure your organisation works with key external partners so that, when you operate across organisations, the right people, teams, roles, and devices can be identified correctly. Without this coordination, the wrong person or device could be identified, access could be granted incorrectly, or information could be shared under the wrong identity. This could lead to data exposure, service disruption, or failures against compliance requirements.

To meet this expectation, your organisation must work with the Department of Defense Joint Enterprise Service Desk (DoD JESD), the Defense Information Systems Agency (DISA), and the Department of Defense Identity Management (DoD IDM) federation partners to manage the identifiers used for cross-organisation activities that involve handling information.

You must also:
- reflect this coordination in your identification and authentication policy
- document clear procedures for managing identifiers and accounts
- record it in your system security plan
- keep other relevant evidence showing that coordination is in place

Finally, you must name:
- who is responsible for managing identifiers
- who is responsible for overseeing information security

You must ensure the practical arrangements and system set-up support this coordinated identifier management.

##### Coordinate external identifier management via federation and documented mappings

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish cross-organisation identifier scope and mapping rules (individuals, groups, roles, devices) including authoritative claim/attribute sources per JESD, DISA, and DoD IDM partners | System Design Authority | Enterprise | 24h | — |
| Configure federation/identity integration in the application to consume central identity service and apply partner-specific claim/attribute mapping into local roles/entitlements (incl. device identity handling where applicable) across dev/test/prod | IAM Engineering Lead | Enterprise | 56h | — |
| Implement and validate lifecycle handling procedures (joiner/mover/leaver, deprovisioning propagation, update consumption, discrepancy/exception resolution) with partner-coordinated triggers | Security Engineer | Enterprise | 32h | — |
| Produce and approve identification & authentication policy (or equivalent) documenting coordination with JESD, DISA, and DoD IDM federation partners, including scope, mechanism, lifecycle triggers, and responsibilities | Compliance Manager | Enterprise | 20h | — |
| Create audit-ready evidence pack and update system security plan per relevant system/app (federation configuration baselines, partner metadata/config snapshots, mapping change records, coordination artefacts/contacts) | Compliance Manager | Enterprise | 24h | — |
| Define governance workflow for mapping changes (RACI, change ticket templates, review/approval gates, periodic review cadence) and run at least one end-to-end mapping change through standard change management | Project Manager | Enterprise | 24h | — |
| Execute integration testing and security validation for cross-organisation identifier mapping (functional tests, negative tests for claim tampering/missing claims, and logging/traceability checks) | Quality Assurance Lead | Enterprise | 28h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define the organisation-wide identifier coverage (individuals, groups, roles, and devices) and the official attributes or claims provided for each external partner.
- [ ] Set up the application to use the organisation’s central federation identity provider (IdP), and connect it with Department of Defense (DoD) identity federation partners. Then configure partner-specific mappings that translate partner-provided claims into the correct roles and entitlements in the application.
- [ ] Set up joiner, mover, and leaver processes and deprovisioning workflows so that when an identifier changes with external partners, the update is coordinated and passed through to the local access permissions.
- [ ] Update the identification and authentication policy to clearly name the JESD, Defence Information Systems Agency (DISA), and Department of Defense (DoD) identity management (IDM) federation partners, including their responsibilities and the scope covered.
- [ ] Create and maintain procedures for the full lifecycle of partner identifiers and accounts, explaining how partner-coordinated changes and exceptions are handled.
- [ ] Update the system security plan to refer to the federation and mapping baseline settings, and keep evidence of any changes so that audits can be completed, linked to the agreed coordination arrangements.


---

#### IA-4.8 — Pairwise Pseudonymous Identifiers (Enhancement)

This requirement is about giving each person a different, hard-to-guess identifier for each separate service they use. This helps ensure the identifier does not reveal who the person is. Without this, the same person could be quietly recognised and followed from one service to another, enabling unwanted tracking and profiling that goes beyond what the organisation needs to operate.

To meet this expectation, the organisation must ensure its identity service creates a unique, non-transparent identifier for every individual for every service that relies on it. The identifier must not include any personal information and must not be realistically predictable.

By default, these identifiers must not be usable to link a person’s activity across different services. The only exceptions are where there is a clearly justified operational need to match records, or where all involved parties have given consent to link records.

The organisation must also:
- document how identifiers are generated and managed
- set out and maintain procedures for handling identifiers and accounts
- include this approach in system plans and design documents
- configure the system accordingly
- keep records of the configuration
- assign named responsibilities
- retain audit evidence showing that identifiers are generated as required

##### Configure IdP for pairwise pseudonymous identifiers per relying party

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm IdP federation mechanisms per relying party (SAML NameID / OIDC subject) and produce a per-client configuration plan for pairwise identifiers | System Design Authority | Enterprise | 16h | — |
| Configure IdP pairwise subject identifiers for at least two relying parties (A and B) and ensure default non-correlation across clients | IAM Engineer | Enterprise | 24h | — |
| Validate identifier opacity/unguessability: inspect issued tokens/claims and confirm subject values are not derived from email/UPN/employee/contractor IDs or other stable attributes | Security Engineer | Enterprise | 12h | — |
| Implement controlled correlation exceptions: define an auditable approved correlation record (pair matrix with justification/consent, time-bounds, and review dates) and configure the IdP exception mechanism accordingly | Compliance Manager | Enterprise | 20h | — |
| Create and publish operational runbook for joiner/mover/leaver and lifecycle impacts on pairwise identifiers, including how exceptions are requested, approved, revoked, and revalidated | Compliance Manager | Enterprise | 12h | — |
| Produce audit-ready evidence pack: IdP configuration exports/IaC state, change tickets, token inspection results, and periodic verification schedule | Project Manager | Enterprise | 16h | £1,500 |
| Execute change management and rollout to all identified relying parties with regression checks (token/claim validation and correlation behaviour verification) | Operations Lead | Enterprise | 20h | — |

**Total Estimated Effort:** 120h  
**Total Estimated Cost:** £1,500

###### Actions Required for Compliance

- [ ] Enable pairwise subject identifiers in the identity provider (IdP) for each Security Assertion Markup Language (SAML) service provider (SP) and OpenID Connect (OIDC) client, using the IdP’s pairwise mode.
- [ ] Remove or disable any global subject mapping so that, by default, the same user is given different identifiers across relying parties.
- [ ] Check the token and claim outputs to confirm the subject is not guessable, does not reveal or come from an email address, user principal name (UPN), or employee identifier.
- [ ] Create and keep an auditable, approved correlation matrix that records: relying party pair, the reason for the correlation, consent status, the person responsible for approval, and the approval expiry date.
- [ ] Set up an exception process so that correlation behaviour is only enabled for approved relying-party pairs, and only for a limited time.
- [ ] Update the system security plan and system design documents to explain how pairwise identifiers are created and how exceptions are handled.
- [ ] Archive identity provider (IdP) configuration evidence (exports and infrastructure as code (IaC) state) and keep token inspection results to support audit readiness.


---

#### IA-4.9 — Attribute Maintenance and Protection (Enhancement)

This requirement is about keeping the identifying details for every person, device, and service that your systems recognise in one secure place, and making sure only the right people can view or change them. If these details are spread out or not well protected, attackers or careless insiders could alter records, pretend to be users or equipment, or use old information to get past checks—resulting in unauthorised access and disruption to operations.

To meet this expectation, the organisation must store these details in a single central directory service that is controlled and access-restricted, such as an authorised Active Directory (AD) or Lightweight Directory Access Protocol (LDAP) system. The information must be encrypted when stored on disk, and access must be limited based on job role rather than granted in an ad-hoc way.

The organisation must keep these records up to date over time for all relevant types of entities. It must also document how the directory is used and protected, including the procedures for creating, updating, and removing identifier and account-related details, as well as the system design and security settings.

In addition, the organisation must keep audit records that show who accessed the stored details and what changes were made, along with any supporting documentation needed to demonstrate that protection is maintained on an ongoing basis.

##### Central authoritative directory for identity/device/service attributes

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and confirm the “protected central storage” authoritative directory (e.g., AD/LDAP) and document scope for individuals, devices, and service principals | System Design Authority | Enterprise | 16h | — |
| Design and implement directory schema/object classes for uniquely identified individuals, devices, and service identities (including required attribute mapping and uniqueness constraints) | Architect | Enterprise | 40h | — |
| Configure encryption at rest for directory data and backups; validate key management approach and restore testing evidence | Infrastructure Lead | Enterprise | 24h | £8,000 |
| Implement RBAC/least-privilege access model for attribute objects (directory-native groups/roles), including separation of duties for admins vs integration services | Cyber Security Lead | Enterprise | 32h | — |
| Build identity lifecycle integration workflows (joiner/mover/leaver, device lifecycle, service onboarding/offboarding) to create/update/remove attribute records from HR/ITSM/CMDB/onboarding pipelines | Software Lead | Enterprise | 56h | £15,000 |
| Implement reconciliation/drift detection jobs and automated remediation (including idempotency, conflict handling, and reporting) | DevOps Lead | Enterprise | 32h | — |
| Enable directory auditing for reads/writes to attribute objects; forward audit events to SIEM and configure retention to meet audit evidence requirements | Security Engineer | Enterprise | 24h | £6,000 |
| Produce operational procedures and evidence pack (runbooks, access review approach, change control notes, and audit-ready documentation) | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £29,000

###### Actions Required for Compliance

- [ ] Set up the organisation-approved protected central storage (Active Directory/Lightweight Directory Access Protocol (AD/LDAP)) as the main, trusted source of identity information for people, devices, and service accounts.
- [ ] Create a directory structure with separate schema and object classes for each type of entity, so each entity is represented uniquely and the required information is stored in one central place.
- [ ] Turn on encryption for data stored in the directory and for backups, and confirm that it is working in both live production systems and disaster recovery systems.
- [ ] Set up role-based access control (RBAC) for directory attribute objects using the minimum necessary permissions (least privilege), and prevent attribute readers and writers from having direct interactive access.
- [ ] Automate the full lifecycle of user attributes—creating, updating, and removing them—using the human resources (HR) system, the information technology service management (ITSM) system, and the configuration management database (CMDB). Also automate service onboarding and offboarding, and run scheduled checks to keep everything in sync and prevent drift.
- [ ] Enable and send directory audit logs for when attributes are read and written to the security information and event management (SIEM) system, and keep the records for evidence retention.
- [ ] Publish and keep documented procedures for managing the full life cycle of attributes, including who is responsible and where audit evidence comes from.


---

### IA-5 — Authenticator Management (Control)

This requirement is about making sure every method someone uses to prove who they are to access systems is issued safely, kept secure, and withdrawn promptly when it should no longer work. Without it, attackers could use well-known default login details, stolen or damaged credentials could still grant access, and people who have left or changed roles could keep access they no longer should have. It also helps prevent sensitive credential information from being exposed or altered.

The organisation must verify the recipient’s identity before issuing any password, access badge, code device, certificate, or biometric enrolment. It must set the initial credential securely and ensure it is strong enough for its purpose. The organisation must follow documented steps to issue, replace, revoke, and manage lost, compromised, or damaged credentials, and it must change any factory default credentials before first use.

Credentials must be refreshed on a set schedule: passwords every 90 days, certificates every 365 days, one-time code tokens every 180 days, biometric enrolments when the template changes or every 2 years, and ID badges every 1 year. The organisation must also refresh credentials immediately after suspected compromise, loss, theft, damage, administrative reset, staff or device changes, or certificate or key revocation.

The organisation must protect credential data from unauthorised viewing or tampering, require people and devices to follow specific safeguarding rules, and update access for group or role accounts whenever membership changes.

##### Automate authenticator lifecycle with identity-verified issuance

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authenticator lifecycle control mapping (types, time periods, and event triggers) and produce an auditable control specification for the application and service accounts | Compliance Manager | Enterprise | 16h | — |
| Implement IdP/IAM-driven identity-verified issuance workflow (joiner/contractor/partner as applicable), including proofing integration and approval gates before authenticator issuance | IAM Engineer | Enterprise | 40h | — |
| Configure authenticator-type settings and restrictions in IdP/application auth layer (password/MFA factor policies, certificate/PKI validity handling, OTP validation windows, biometric template change/re-enrol rules, badge re-issue rules where supported) | System Design Authority | Enterprise | 48h | — |
| Build automated scheduled refresh/rotation jobs and workflows aligned to the defined time periods (90/180/365 days; 2-year biometric template re-enrol; 1-year badge re-issue), with idempotency and rollback-safe behaviour | DevOps Lead | Department | 56h | — |
| Implement event-driven immediate revocation/refresh integrations (compromise/loss/theft/damage/admin reset; joiner/mover/leaver; device decommission/reassign/identity change; key/certificate revocation) and ensure audit logs capture trigger + outcome | Security Engineer | Enterprise | 64h | — |
| Create deployment gate to eliminate factory defaults (change defaults before first use), and integrate secrets manager/PAM vault for secure storage of initial authenticator content and forced first-use rotation for temporary access | Platform Engineer | Business Unit | 40h | £12,000 |
| Implement privileged access (PAM) workflows for service accounts: issuance, rotation, revocation on deprovision and key/cert revocation, with least-privilege admin access and audit evidence | Privileged Access/PAM Administrator | Department | 32h | — |
| Add end-to-end auditability and evidence packaging (SIEM/SOAR event correlation, retention, dashboards, and test evidence for issuance/reset/rotation/revocation; include negative tests for failed verification) | Operations Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 328h  
**Total Estimated Cost:** £12,000

###### Actions Required for Compliance

- [ ] Set up an identity provider (IdP) and identity and access management (IAM) process for joiners, movers, and leavers that issues and removes authentication credentials based on verified identity and confirmed changes to roles or groups.
- [ ] Add a deployment check that detects and replaces any factory default login details before the application is first used, and store the new secrets only in an approved secrets manager.
- [ ] Set rules for each type of sign-in method (password, certificate/public key infrastructure (PKI), one-time password (OTP), and badge or biometric where used) to enforce the organisation’s required restrictions and strength.
- [ ] Set up automated rotation and refresh jobs in line with **ia-05_odp.01**, covering **90/365/180 days**, including a **biometrics re-enrolment schedule** and a **badge re-issue schedule**.
- [ ] Set up event alerts for **ia-05_odp.02** to immediately revoke or update access when there is: **a compromise, loss, theft, or damage; an administrative reset; device decommissioning, reassignment, or identity change; or revocation of a key or certificate**.
- [ ] Limit and record administrative access to authenticator content (passwords and secrets, and private certificate material) by using privileged access management (PAM) and secrets management, with audit records.


---

#### IA-5.1 — Password-based Authentication (Enhancement)

This requirement is about stopping people from signing in using easy-to-guess or previously known passwords, and ensuring that passwords are handled safely. Without it, attackers could try common passwords, reuse passwords taken from past data leaks, or capture passwords while they are being sent, and then gain unauthorised access to accounts.

To meet this expectation, the organisation must maintain an up-to-date list of commonly used, expected, or known-compromised passwords. This list must be refreshed at least weekly, and updated immediately if there is any suspicion that organisational passwords may have been compromised.

When anyone sets or changes a password, the system must:
- block any password that appears on the list,  
- send passwords only over secure encrypted connections, and  
- store passwords using an approved protected method that uses a random extra value, so the original password cannot be worked out or recovered.

During account recovery, users must choose a new password straight away.

Users are allowed long passphrases (including spaces and all printable characters). Automated guidance must help users choose strong passphrases, and the organisation’s rules must be enforced, including:
- at least 14 characters,
- at least 3 of 4 character types,
- no password parts that include the username or service name, and
- no 3 or more repeated characters or sequential characters.

##### IdP-enforced strong passwords with breach blocklist and secure recovery

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm IdP password/authentication flow coverage (federation/OIDC/SAML) and remove/disable any legacy/local password entry or bypass paths; produce a signed evidence map of all password set/reset/change/recovery entry points | IAM Engineer | Enterprise | 16h | — |
| Implement IdP password composition policy: min 14 chars; at least 3 of 4 character classes; block username/service-name substrings; block 3+ repeated or sequential characters; allow long passphrases (including spaces/printables) per IdP capabilities; export configuration evidence | Security Engineer | Enterprise | 24h | — |
| Implement “known bad” password blocklist in IdP: configure built-in capability or external feed integration; define data format, matching mode, and operational parameters; export configuration evidence | IAM Engineer | Enterprise | 32h | £8,000 |
| Establish blocklist refresh and incident-driven update pipeline: weekly refresh job plus immediate refresh trigger tied to “compromise suspected” event; include runbooks and operational ownership; test with a simulated incident | Operations Lead | Enterprise | 24h | £3,000 |
| Configure IdP to reject blocked passwords at creation/change time with user-facing error handling and security logging (including correlation IDs); validate behaviour across all relevant flows (password change, reset, recovery) | Security Engineer | Enterprise | 16h | — |
| Enforce cryptographically protected password transmission: require HTTPS/TLS-only for IdP endpoints and authentication redirects; disable HTTP; enable/verify HSTS where applicable; validate strong TLS settings and redirect integrity | Infrastructure Lead | Enterprise | 16h | — |
| Validate and evidence cryptographically protected password storage: confirm approved salted one-way hash / salted KDF is used; ensure salting and non-recoverability; enable pepper/keyed variant if supported and document; produce audit-ready evidence pack | Security Engineer | Enterprise | 20h | — |
| Harden account recovery: configure recovery flow to require immediate new password selection after verification; ensure same composition rules and blocklist enforcement apply; perform end-to-end testing and produce evidence | IAM Engineer | Enterprise | 16h | — |

**Total Estimated Effort:** 164h  
**Total Estimated Cost:** £11,000

###### Actions Required for Compliance

- [ ] Set up the organisation’s identity provider (IdP) so it is the only place users enter their password to sign in, and to reset or change their password for the application.
- [ ] Configure the identity provider (IdP) password rules to require: at least 14 characters, at least 3 different character types out of 4, block passwords that contain the username or service name, and reject passwords with 3 or more repeated or sequential characters.
- [ ] Enable support for long passphrases in the identity provider (IdP), and confirm that spaces and printable characters are accepted.
- [ ] Add a regularly updated list of commonly used compromised passwords to the identity provider (IdP), and refresh it every week.
- [ ] Set up an incident-based trigger to update the blocklist immediately when an organisational security breach is suspected.
- [ ] Check and record that the identity provider (IdP) stores passwords using approved salted one-way hashing or a salted key derivation function (KDF), which cannot be reversed, and that passwords are sent only over secure web connections using HTTPS with Transport Layer Security (TLS).
- [ ] Set up account recovery so that, when users recover their accounts, they are required to set a new password immediately, and make sure the same blocklist and password rules are applied.


---

#### IA-5.2 — Public Key-based Authentication (Enhancement)

This expectation ensures that when people or systems log in using a public key, only the rightful owner can use the matching secret private key, and the login is correctly connected to the right person or group account. Without this, an attacker could pretend to be someone else, or a login could be linked to the wrong account—both of which could lead to unauthorised access to sensitive work systems.

Where certificates are used, the organisation must also confirm that each certificate was issued by an approved source and is still valid. This includes checking whether the certificate has been cancelled. The organisation must make these checks by tracing the certificate’s approval chain (“trust path”) back to an approved starting point.

To keep services available during network problems, the system must store a local copy of certificate cancellation information and use it to make the same validity decisions even when it cannot access the usual online checks.

##### PKI auth with trust-path validation and cached revocation checks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define PKI validation requirements: approved trust anchor(s), certificate policy processing rules, acceptable key usages/extended key usages, and path-building constraints | Compliance Manager | Enterprise | 16h | — |
| Design and implement trust-path validation in the authentication/authorisation layer (including deterministic selection of the approved trust anchor and rejection of non-conforming chains) | System Design Authority | Enterprise | 40h | — |
| Implement CRL/OCSP revocation checking during authentication with configurable enforcement modes (fail-closed), supported methods, and certificate status handling logic | Security Engineer | Enterprise | 48h | — |
| Build local revocation cache service/component: storage model for CRLs/OCSP responses, cache indexing by issuer/serial/nonce (as applicable), nextUpdate/expiry enforcement, and safe fallback behaviour when responders are unreachable | Platform Engineer | Enterprise | 56h | £6,000 |
| Implement deterministic identity-to-account mapping from certificate attributes (e.g., SAN/UPN/subject) with explicit mismatch denial and configurable mapping rules per relying service | Software Lead | Enterprise | 32h | — |
| Add audit-ready logging and evidence capture: trust anchor used, validation outcome, revocation method (live vs cached), cache freshness indicators, certificate identifiers (serial/thumbprint), and correlation IDs | Quality Assurance Lead | Enterprise | 24h | — |
| Create test plan and execute validation: unit/integration tests with mocked CRL/OCSP, network-failure scenarios, cache expiry scenarios, and negative tests for wrong trust anchors/policies/mappings | Quality Assurance Lead | Enterprise | 40h | £2,500 |
| Production rollout and operational readiness: deployment configuration, monitoring/alerting for cache freshness and auth failure rates, runbooks, and change management sign-off | Operations Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] Set up the authentication service to create and check certificate trust chains back to the approved “Common Policy Root” trust anchor, with certificate policy checking turned on.
- [ ] Enable certificate revocation list (CRL) and/or online certificate status protocol (OCSP) checks during certificate validation for all public key infrastructure (PKI)-based logins and authentications.
- [ ] Set up a local “revocation” cache to store certificate revocation lists (CRLs) and online certificate status protocol (OCSP) responses, making sure each item is only used until its expiry date (or next update time), and follow a defined refresh schedule.
- [ ] Update the identity matching rules so certificate details (attributes/principals) are matched in a consistent, predictable way to the correct directory user or group, and reject any certificates that do not match.
- [ ] Record audit logs for: the selection of the trust anchor, the results of trust-path validation, the method used for revocation checks, and whether cached or live revocation data was used.
- [ ] Test failover by blocking outbound connections to certificate revocation list (CRL) and online certificate status protocol (OCSP) checking sites, and confirm that authentication only succeeds while the previously cached revocation information is still valid.


---

#### IA-5.5 — Change Authenticators Prior to Delivery (Enhancement)

This requirement is about making sure that when new parts of your systems are built, set up, delivered, or installed, they do not come with the same “ready-made” login details that others could easily guess. If this is not done, attackers (or careless insiders) could use default usernames and passwords to gain access quickly, before you have time to secure the device or service. This could result in unauthorised access, disruption, or data loss.

To meet this expectation, your organisation must clearly assign responsibilities to developers and installers to either create unique login details for each component or replace any default ones before the component is delivered and before it goes into service. You must also document how this will be handled, and ensure your purchasing documents and contracts for system parts and installation services explicitly require suppliers to do the same, with evidence kept to show the changes were made in time.

##### Unique authenticators deliverable with signed handover evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define Authenticator Handover Evidence Pack template(s) per component type (fields, required actions, timestamping, component/instance identifiers, evidence linkage to change record/CMDB) | Compliance Manager | Enterprise | 24h | — |
| Define uniqueness/default-change rules and acceptable authenticator types (incl. COTS/defaults handling, environment segregation, required secrets mechanism integration points) | Data Protection Officer | Enterprise | 16h | — |
| Implement unique authenticator provisioning workflow using approved secrets mechanism (API/service account creation, rotation/renewal hooks, prohibition of shared defaults) | Security Engineer | Enterprise | 40h | — |
| Implement “handover gate” in release/deployment pipeline (block “delivered/ready for service” until evidence pack attached; automated completeness validation + required-field checks) | DevOps Lead | Enterprise | 56h | — |
| Implement evidence capture automation and signed checklist fallback (collect config/IaC apply logs, audit trails, device snapshots where feasible; create attestation step for cases automation cannot prove) | Platform Engineer | Enterprise | 48h | — |
| Configure evidence storage, retention, and access controls (auditable repository, link to change record/CMDB, retention alignment, least-privilege access for auditors/ops) | Operations Lead | Enterprise | 24h | — |
| Extend handover gate and evidence pack process to OT/edge installation runbooks (adapted checklist + signed evidence pack requirement; vendor constraint handling) | System Design Authority | Enterprise | 24h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create an “Authenticator Handover Evidence Pack” template for each component type.
- [ ] Set the rules for what counts as a unique authenticator, and what the default change behaviour is, for each authenticator type (administrator, service, locally stored device, and API keys where applicable).
- [ ] Set up a release and deployment handover checkpoint that prevents a system being marked “ready for service” unless the evidence pack has been provided.
- [ ] Integrate the generation and delivery of secrets with the organisation-approved secrets manager or vault.
- [ ] Update the installer and developer runbooks so they apply the default authenticator changes as a pre-operation step for commercial off-the-shelf (COTS) components.
- [ ] Store the signed evidence packs in an auditable repository that is linked to the relevant change record and configuration management database (CMDB) item, and keep them for the period required by the applicable policy.


---

#### IA-5.6 — Protection of Authenticators (Enhancement)

This requirement is about protecting the tools people use to prove who they are—such as passwords and other sign-in codes—at the right level of strength. If these login details or access “keys” are not properly protected, attackers could pretend to be staff, get past entry checks, and access more sensitive information than they should. This risk is higher when one system can be used to access different levels of sensitive data.

To meet this expectation, the organisation must first identify how sensitive the information is that each sign-in method can access, and then protect each sign-in method accordingly. If the system allows different sensitivity levels to be mixed without clear separation, the organisation must apply the strongest protection required for the highest sensitivity level involved.

This approach must be built into the organisation’s login rules and everyday procedures, assigned to named responsible roles, implemented by system administrators, and supported by documented evidence. This includes security reviews showing how well the protections work, and risk findings that track any gaps until they are closed.

##### Authenticator protection tiering driven by security categorisation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define authenticator protection tiers/strength requirements and map them to enterprise security categories (including passwords, MFA methods, certificate/token crypto requirements, and recovery factors) | Information Security / IAM Governance Lead | Enterprise | 24h | — |
| Produce controlled configuration schema and governance process for the security-category → authenticator-tier mapping (versioning, approvals, change control, rollback approach) | Compliance Manager | Enterprise | 16h | — |
| Determine highest applicable security category per application and per environment (prod/test/DR) using categorisation outputs; document the decision logic and assumptions | Project Manager | Enterprise | 20h | — |
| Implement IdP/SSO conditional access enforcement for application sign-in flows using the required tier (including “highest security category wins” and downgrade blocking) | IAM Engineers | Enterprise | 56h | — |
| Extend enforcement to privileged/admin access and all recovery paths (helpdesk reset, recovery codes, re-enrolment flows, service account/admin break-glass where applicable) | Security Engineer | Enterprise | 40h | — |
| Evidence generation: automatically export identity policy configuration state and effective enforcement status per application/environment; define audit retention and reporting format | Data Protection Officer | Enterprise | 24h | — |
| Periodic verification and continuous assurance: run scheduled checks that effective enforcement matches the categorisation-driven mapping; produce audit-ready verification reports and remediation workflow | Security Assurance / Compliance | Enterprise | 24h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and approve a controlled mapping between enterprise security categories and the required strength levels for authenticator protection.
- [ ] For each environment, determine the highest security category that applies to the application, based on the security categorisation results.
- [ ] Set up central identity provider (IdP) and single sign-on (SSO) conditional access and sign-in rules so that, for each application, users must use the strongest authentication method allowed for their access level.
- [ ] If the application supports multiple authentication categories, turn off or block the weaker authentication methods and prevent any option that could reduce the authentication strength.
- [ ] Apply the same tier-based access controls to privileged access and to authenticator recovery and re-enrolment processes.
- [ ] Automate the collection of evidence showing that the effective identity policy settings are in place, and keep this evidence for audit purposes.
- [ ] Carry out regular checks that the required authentication level matches the category-based mapping, and fix any mismatches found.


---

#### IA-5.7 — No Embedded Unencrypted Static Authenticators (Enhancement)

This requirement is about making sure secret login information is not quietly built into software or left in fixed files where it could be found. If unencrypted secrets are included in an application, access scripts, or pre-set function keys, they can be copied, exposed, or reused. This could allow unauthorised people to pretend to be users or gain access to systems without having to guess passwords.

To meet this expectation, the organisation must clearly define:
- what it considers an authentication secret, and
- what counts as “static” storage.

It must also explain what it means by “encrypted” versus “unencrypted” for stored values. The organisation then needs to document this rule in its system security plan and authenticator management procedures, ensure that access scripts and function keys never contain unencrypted secrets, and ensure authentication is implemented without relying on such embedded values.

The organisation must review application code for any unencrypted embedded secrets, keep evidence of those reviews, assign named people to oversee the work, and be able to provide the relevant policy, plans, procedures, design and configuration records, scripts, and review results when asked.

##### Prevent unencrypted static authenticators in code and scripts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “authenticator”, “static”, and “unencrypted” scope in the authenticator management procedure; include explicit coverage for access scripts and function-key/pre-set key values | Compliance Manager | Enterprise | 16h | — |
| Establish CI/CD guardrail requirements: pipeline stage design, merge/build blocking rules, exception workflow triggers, and required evidence outputs (scan reports, artefact manifests) | Project Manager | Enterprise | 24h | — |
| Implement secret scanning in CI/CD for source, build outputs, and packaged artefacts (scripts, deployment manifests, container images/archives); configure policy for both known patterns and high-entropy/credential formats | DevOps Lead | Enterprise | 40h | £18,000 |
| Integrate scanning results into release governance: fail/require approval logic, ticketing/exception linkage, and retention of scan evidence for at least one full release cycle | Operations Lead | Enterprise | 16h | — |
| Refactor applications and automation scripts to remove embedded authenticators; implement runtime retrieval patterns using approved secrets/identity services and update function-key usage to avoid directly usable stored values | Software Lead | Business Unit | 72h | — |
| Perform targeted review and evidence capture for “static storage” locations (access scripts, function-key/pre-set key definitions, configuration templates, environment files packaged with releases) and document remediation actions | Security Engineer | Department | 24h | — |
| Operationalise exception handling and legacy remediation: define compensating controls, remediation dates, and prioritisation; remediate top legacy cases (function-key/script-based) to meet acceptance criteria | Cyber Security Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Update the authenticator management procedure to define: “authenticator”, “static”, and “unencrypted” (including the “used as-is” rule).
- [ ] Set up automated checks in the continuous integration and continuous delivery (CI/CD) process to scan secrets in your source code, scripts, function-key configuration files, and packaged outputs (for example, container images).
- [ ] Set up release “pipeline gates” to stop deployments when unencrypted static authenticators are found, with an approval exception process and planned fix dates.
- [ ] Refactor applications and access scripts so they retrieve authentication details at runtime from approved identity and secrets services, rather than hard-coding those values.
- [ ] Create focused pre-release review checklists for access scripts and any function-key mechanisms, and keep the evidence for audit purposes.
- [ ] Create and carry out a plan to fix any legacy embedded or static authenticator issues, prioritising them based on how exposed they are and how critical they are.


---

#### IA-5.8 — Multiple System Accounts (Enhancement)

This requirement is about making sure people do not use the same login secret across multiple systems. The real-world risk it addresses is straightforward: if someone’s access to one system is stolen or guessed, and the same password (or other login method) also works on other systems, attackers can quickly use those same login details to access additional systems.

To meet this expectation, the organisation must use a shared login approach. Users should sign in through a central identity service when accessing systems, rather than each system relying on its own separate password. For each person, each system must use unique login credentials. The organisation must also stop users from reusing the same password or other authentication method on different systems.

The organisation should document these rules in its login and password management policies and procedures, include the approach in each system’s security plan, keep an up-to-date list of people who have accounts on multiple systems, and record the safeguards in place. Named responsibilities should be clearly assigned for managing and overseeing these arrangements.

##### Federated SSO for multi-system users with no password reuse

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm in-scope applications and define federated SSO pattern (SAML/OIDC), including relying-party requirements and token/claim mapping | System Design Authority | Enterprise | 16h | — |
| Configure IdP as authoritative authentication source for each relying party (SAML/OIDC app registrations, redirect/ACS settings, signing/encryption, session settings) | IAM Lead | Enterprise | 24h | — |
| Implement authentication hand-off: disable local password login for standard users and restrict any remaining local authentication to documented break-glass accounts only | Security Engineer | Department | 20h | — |
| Enforce phishing-resistant MFA at IdP for the relevant user population (e.g., FIDO2/passkeys), including conditional access rules and fallback handling | IAM Lead | Enterprise | 24h | £25,000 |
| Ensure “unique authenticators per system” via IdP mediation: remove/avoid system-local password storage for covered apps and validate that sign-in is exclusively via IdP assertions/tokens | Platform Engineer | Department | 16h | — |
| Build auditability and evidence: configure sign-in logs/claims to record federated SSO usage, and implement configuration-as-code pipelines for federation/MFA settings | DevOps Lead | Enterprise | 24h | £8,000 |
| Maintain and govern multi-system account holder evidence: create/refresh mapping of multi-system users, define exception workflow for break-glass, and produce audit-ready reports | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 140h  
**Total Estimated Cost:** £33,000

###### Actions Required for Compliance

- [ ] Choose and document the main identity provider (IdP) and the federation method (Security Assertion Markup Language (SAML) or OpenID Connect (OIDC)) for the in-scope application(s).
- [ ] Configure the application to accept only identity provider (IdP) assertions or tokens, and turn off local password sign-in for standard users.
- [ ] Require phishing-resistant multi-factor authentication (MFA) at the identity provider (IdP) for user groups that have accounts on more than one system
- [ ] Put in place technical safeguards to stop people reusing the same password on different systems by removing the ability to sign in using system-local passwords.
- [ ] Manage federation and multi-factor authentication (MFA) settings using configuration-as-code, so that all changes can be reviewed and audited.
- [ ] Create and keep an up-to-date record of how accounts map across all systems, including the protections in place—such as single sign-on (SSO) through a trusted provider, enforcing multi-factor authentication (MFA), and any approved “break-glass” exceptions.
- [ ] Use testing and monitoring to confirm that users can sign in to the application only through federated single sign-on (SSO), and ensure that audit logs are generated.


---

#### IA-5.9 — Federated Credential Management (Enhancement)

This requirement is about ensuring that when your organisation needs to check people and devices from other organisations, it only relies on a small, approved set of external identity and trust services: the U.S. Department of Defense (DoD) Defense Manpower Data Center (DMDC) Enterprise Identity and the DoD Public Key Infrastructure (PKI) trust services used with the Common Access Card (CAC).  

This matters because if you allowed unapproved partners to verify credentials, the wrong person or device could be accepted. That could lead to unauthorised access, exposure of sensitive data, or disruption to shared activities.  

To meet this expectation, your organisation must set clear rules for cross-organisation sign-in and verification that list only these approved services. Those rules must be reflected in your identification and authentication policy, your procedures for managing credentials and accounts, your system security plan, and your security agreements and related records.  

You must also appoint named individuals responsible for managing credentials, overseeing information security, and operating the cross-organisation (federated) sign-in capability. Finally, you must ensure the system is configured so that only the approved services can be used, and you must keep evidence showing they are actually used for cross-organisation activities that involve processing, storing, or transmitting information.

##### Allow-list federated partners to DMDC ID and DoD PKI/CAC only

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design federation enforcement approach (gateway/broker/reverse-proxy) including allow-list logic for exactly DMDC Enterprise Identity and DoD PKI/CAC trust services; define required validation checks (issuer, audience, signature chain, trust anchors, revocation where applicable) | IAM/Federation Architect | Enterprise | 24h | — |
| Implement configuration-as-code / policy-as-code for federation settings (hard-coded partner allow-list, disable dynamic discovery/auto-metadata import, pin issuer/metadata/cert trust anchors per partner) | IAM Engineer | Enterprise | 40h | — |
| Configure relying applications / auth flows to enforce strict token/assertion validation (SAML/OIDC issuer+audience+signature validation; CAC trust store only; reject unsigned/incorrectly signed assertions) across prod/test environments | Platform Engineer | Enterprise | 32h | — |
| Establish audit logging and evidence capture (log external partner identity used, success/failure reason codes, correlation IDs; integrate with SIEM; define retention aligned to audit needs) | Operations Lead | Enterprise | 20h | £3,000 |
| Implement administrative controls for change management (restricted access to federation policy repo, approval workflow, versioning, and rollback procedures) | Compliance Manager | Enterprise | 16h | — |
| Update governance artefacts to reflect IA-5(9) approved external organisations and enforcement mechanism (identification & authentication policy, authenticator/account management procedures, system security plan, and federation security agreements) | Data Protection Officer | Enterprise | 18h | — |
| Execute test and acceptance validation (negative tests for non-approved partners; positive tests for DMDC and DoD PKI/CAC; run security regression checks; produce acceptance evidence pack) | Quality Assurance Lead | Enterprise | 24h | — |

Total Estimated Effort: **194h**  
Total Estimated Cost: **£3,000**

###### Actions Required for Compliance

- [ ] Create an allow-list of federation partners that includes exactly the following trust services from **ia-05.09_odp**: **DMDC Enterprise Identity** and **Department of Defense public key infrastructure (DoD PKI) (Common Access Card (CAC))**.
- [ ] Set up the federation enforcement point to check and lock the expected issuer, audience, and signing trust information for only the two approved services.
- [ ] Turn off automatic discovery of federation partners and automatic import of their metadata, and limit federation configuration changes to approved administrators.
- [ ] Implement rejection logic that blocks any federated authentication assertion or token if its issuer or certificate chain does not match the approved allow-list.
- [ ] Enable and keep audit logs that record which external federation partner was used for each federated authentication attempt.
- [ ] Update the identification and authentication policy, the procedures for managing authenticators and accounts, the system security plan, and the federation security agreements to record the approved partner list and how it will be enforced.


---

#### IA-5.10 — Dynamic Credential Binding (Enhancement)

This requirement is about ensuring that when someone signs in using a smartcard, the system only accepts that smartcard if it can reliably link it to the correct person. The system must only create that person’s access after these checks are passed. Without this, a stolen or forged smartcard could be used to access the wrong accounts, or the system could accidentally create new accounts based on untrusted or incorrect information. This could lead to unauthorised access and inaccurate, messy identity records.

To meet this expectation, the organisation must put in place an automated process that:
- checks the smartcard’s certificate using certificates issued by an approved authority
- confirms the certificate includes the required details
- links (maps) the certificate to the correct identity

If any validation fails, if required certificate details do not match, or if the system cannot determine a valid identity match, the system must refuse the login and must not create or activate any identity. It must also keep clear records of what happened during each attempt.

##### IdP-enforced PKI smartcard binding with JIT provisioning

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm approved DoD CA allow-list, revocation sources (CRL/OCSP) and certificate attribute requirements (EKU/KeyUsage, subject/altName/OIDs) and document binding rule specification (ia-05.10_odp) | PKI/Certificate Authority Administrator | Enterprise | 16h | — |
| Configure IdP trust/validation to accept only certificates chaining to approved CA(s) (trust store/allow-list) and disable any non-approved trust paths | Security Engineer | Enterprise | 24h | — |
| Implement certificate validation workflow in IdP (validity window checks + revocation checking where supported) with hard deny on failure prior to any mapping/provisioning | IAM Engineer | Enterprise | 32h | — |
| Implement required certificate attribute checks and binding rule enforcement (EKU/KeyUsage, required OIDs/claims, subject/altName format, organisation-specific constraints) with explicit failure outcomes | IAM Engineer | Enterprise | 24h | — |
| Implement deterministic certificate-to-identity mapping logic (identity key derivation, indeterminate mapping handling) and ensure no fallback to weaker identifiers | Architect | Enterprise | 24h | — |
| Configure JIT provisioning/activation to trigger only after successful validation + attribute checks + deterministic mapping, including explicit “no provisioning on failure” guardrails | IAM Engineer | Enterprise | 24h | — |
| Implement audit evidence generation and SIEM forwarding (per-attempt events: validation result, attribute check result, mapping outcome, provisioning occurred/denied) and verify retention/alerting hooks | Security Operations / SIEM Engineer | Enterprise | 20h | — |
| End-to-end testing and acceptance evidence (positive/negative test matrix for CA trust, revocation failure, attribute mismatch, indeterminate mapping; confirm zero provisioning on deny) and produce release-ready compliance sign-off pack | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Set up the identity provider (IdP) to follow the organisation’s defined binding rules (ia-05.10_odp) by using a fixed, repeatable rule that maps each certificate to the correct user identity.
- [ ] Set up the identity provider (IdP) to trust only the smart card certificate authority (CA) or CAs approved by the Department of Defense (DoD) when checking the certificate chain (an explicit list of allowed CAs).
- [ ] Before mapping or provisioning, enable certificate validation, including checks that the certificate is still valid and has not been revoked, in line with the public key infrastructure (PKI) model.
- [ ] Set up checks for required certificate details (for example, extended key usage (EKU), key usage (KeyUsage), and required subject, alternative name (altName), and object identifier (OID) rules). If any check fails, block the certificate.
- [ ] Set up just-in-time (JIT) provisioning so that user account creation and activation happen only after successful checks for identity validation, required attributes, and a consistent (deterministic) mapping.
- [ ] Add a clear safeguard to stop identity provisioning if the mapping is unclear or if any validation or attribute check fails.
- [ ] For every sign-in attempt, enable and send audit records to the security information and event management (SIEM) system. Include the sign-in validation result, the attribute check result, the mapping outcome, and whether provisioning took place.


---

#### IA-5.12 — Biometric Authentication Performance (Enhancement)

This requirement is about making sure that when people sign in using a fingerprint, face scan, or similar biological check, the system is accurate enough to accept genuine users while almost never accepting impostors. If it is not, an attacker could trick the system into granting access using a fake or low-quality biometric, or genuine staff could be incorrectly turned away—causing disruption and increasing the risk of unauthorised entry.

To meet this requirement, the organisation must use biometric authentication methods that achieve at least a 99.5% genuine match rate when checking users, while keeping the false match rate to no more than 0.1%. The organisation must also ensure liveness detection is enabled, meaning the system checks that the biometric is from a live person rather than a copy.

The organisation should record these biometric quality targets, configure the system to meet them, and keep audit records showing that biometric performance meets the stated requirements.

##### Enforce biometric verification quality targets with liveness

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select verification-grade biometric SDK/engine and/or capture hardware with documented liveness support and biometric quality characteristics suitable for the required operating point | System Design Authority | Enterprise | 24h | £25,000 |
| Produce biometric quality requirements statement and embed into system security design/configuration documentation (exact targets: **≥99.5% genuine match rate at FMR ≤0.1%** and **liveness detection enabled**) | Compliance Manager | Enterprise | 16h | — |
| Configure authentication service decisioning thresholds/operating point to meet FMR ≤0.1% while achieving ≥99.5% genuine match rate; implement hard enforcement to prevent bypass via fallback modes | Software Lead | Department | 32h | — |
| Enable liveness detection end-to-end in the capture/verification pipeline and implement enforcement so liveness is required for every verification attempt | Security Engineer | Department | 24h | — |
| Execute validation testing to demonstrate liveness is invoked for every attempt and that the deployed operating point meets/does not exceed FMR ≤0.1% with genuine match rate ≥99.5% (including test evidence pack) | Quality Assurance Lead | Business Unit | 40h | £6,000 |
| Implement audit evidence capture: persist operating point/threshold version, liveness enabled indicator, and required biometric event metadata; integrate with logging/SIEM retention requirements | Platform Engineer | Enterprise | 24h | — |
| Establish configuration integrity controls: version-controlled biometric configuration baseline, change control workflow, and deployment enforcement (including rollback strategy) | DevOps Lead | Enterprise | 24h | £3,000 |
| Security assurance review: review evidence and configuration artefacts for audit readiness; sign-off against NIST IA-5(12) enhancement expectations | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £34,000

###### Actions Required for Compliance

- [ ] Choose a verification-grade biometric software development kit (SDK) or engine and/or capture hardware that supports liveness detection and has documented performance results.
- [ ] Document the biometric quality requirements in the system security and configuration documentation as follows: **at least 99.5% genuine match rate when the false match rate is 0.1% or less, and liveness detection must be enabled**.
- [ ] Set the biometric verification decision thresholds in the authentication service so that the false match rate is **0.1% or less**, while aiming for a **genuine match rate of at least 99.5%**.
- [ ] Enable liveness detection in the capture and/or verification process, and confirm it is applied to every verification attempt with no option to bypass or fall back.
- [ ] Set up audit logs to record the threshold or operating point version and whether liveness detection is enabled for biometric verification events.
- [ ] Store biometric threshold and liveness settings as a version-controlled baseline, and apply them through controlled releases that require change approval.


---

#### IA-5.13 — Expiration of Cached Authenticators (Enhancement)

This requirement ensures that any stored login information used to sign in when the network is unavailable stops working after 7 days. Without this, someone could use old, outdated sign-in details long after they should have been updated, increasing the risk of unauthorised access if a person’s access should have changed or been removed.

To meet this requirement, the organisation must:
- set a clear 7-day expiry rule for stored login or authentication information
- automatically block sign-in using that stored information once it is more than 7 days old
- enforce the rule through the system’s own settings, rather than relying on staff to remember

The organisation should also:
- document how stored sign-ins are created, updated, and cancelled
- record which settings are in place
- assign named responsibilities to the appropriate roles
- keep audit records showing when stored sign-ins were allowed or denied because they had expired

##### Enforce 7-day expiry for offline cached authenticators with audit

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Identify and document all offline/cached authenticator mechanisms in scope (endpoints, brokers, local caches) and map each to the enforcement point(s) | IAM Lead | Enterprise | 24h | — |
| Define the effective cached authenticator lifetime parameterisation for `ia-05.13_odp` (default 7 days) and confirm there are no vendor defaults, grace periods, or unlimited overrides | Compliance Manager | Enterprise | 16h | — |
| Implement centrally managed configuration to set cached authenticator expiry to exactly `ia-05.13_odp` across all in-scope managed endpoints/platforms | Platform Engineer | Enterprise | 32h | — |
| Add/adjust authentication-time enforcement logic to deny cached authentication when `now - cache_timestamp > ia-05.13_odp`, including explicit reason codes (e.g., `CACHED_AUTH_EXPIRED`) | Software Lead | Enterprise | 40h | — |
| Remove/disable any alternative offline fallback paths that could permit continued use past expiry (e.g., stale reuse, silent offline refresh, parallel offline credential paths) | Security Engineer | Enterprise | 24h | — |
| Implement audit event generation and SIEM forwarding for both allowed and denied offline/cached attempts (user/device identifiers, timestamps, cache age/decision, reason codes) | Security Engineer | Enterprise | 24h | £3,000 |
| Execute validation and evidence pack: test at <7 days and >7 days across representative endpoint platform types; capture configuration evidence and test results for audit | Operations Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 212h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Identify the exact offline or cached authentication method(s) used by the in-scope endpoints, and confirm where the system records the cache timestamps.
- [ ] Set the cached authenticator time limit to exactly `ia-05.13_odp` (default: 7 days) using centrally managed identity and endpoint policy, and check that no other settings override it.
- [ ] Set up authentication-time enforcement so that any cached authentication is rejected when the cache is older than `ia-05.13_odp`.
- [ ] Disable or bypass any offline authentication fallback options that would allow cached authentication to be used after the expiry time window.
- [ ] Set up audit logging for authentication attempts made offline or from cached data. Include clear decision and reason codes for when each attempt expires, and send the logs to the security information and event management (SIEM) system.
- [ ] Run controlled tests during a network outage to confirm the service works before the access period ends, and is blocked after it ends; keep the supporting evidence.


---

#### IA-5.14 — Managing Content of PKI Trust Stores (Enhancement)

This requirement is about keeping the organisation’s trusted digital certificate lists consistent and up to date wherever they are used to decide who or what is allowed to connect. If these trusted lists are managed differently across networks, computers, web browsers, and applications, people could be blocked incorrectly, or the organisation could end up trusting the wrong certificates—allowing unauthorised access or impersonation.

To meet this expectation, the organisation must set one organisation-wide approach for managing the contents of all such trusted lists, and apply it specifically to any sign-in or access decisions that rely on trusted certificates. Named responsibilities must be assigned, with input from information security, and involvement from system and network administrators for the platforms they manage, and from application developers where relevant. The approach must be supported by practical processes or tools, documented in system plans and designs, recorded in configuration records, and aligned with the organisation’s overall security and architecture plans.

##### Governed trust-store policy with automated, drift-checked rollout

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the authoritative trust-store content model (approved roots/intermediates, distrust/deny rules, EKU/purpose constraints, environment scoping) and publish as version-controlled “trust-store policy-as-code” | Information Security Lead | Enterprise | 24h | — |
| Establish governance workflow and named responsibilities (peer review/approval, change tickets, rollback criteria, RACI, evidence requirements) and integrate into existing change management process | Compliance Manager | Enterprise | 16h | — |
| Implement trust-bundle generation pipeline (from CA metadata + policy-as-code to platform-specific bundles/artifacts) including signing/versioning and reproducible builds | Platform Engineer | Enterprise | 40h | — |
| Configure automated deployment to OS trust stores via enterprise endpoint management (e.g., Intune/Group Policy/Jamf) with staged rollout rings (test→prod), rollback, and configuration baselines | Operations Lead | Enterprise | 32h | — |
| Configure managed browser trust-store behaviour (where supported) and/or controlled distribution of governed trust bundles for supported browser fleets | System Design Authority | Enterprise | 24h | — |
| Update application consumption pattern to remove ad-hoc embedded trust stores (shared trust bundle distribution, container build-time/runtime mounting, and runtime validation wiring) and provide developer guidance | Software Lead | Enterprise | 32h | — |
| Implement drift detection and continuous currency checks (authoritative vs deployed comparison per platform/environment; alerting to ticketing; remediation runbooks) | Cyber Security Lead | Enterprise | 40h | £18,000 |
| Produce audit-ready evidence pack (coverage matrix, deployment records, approval/change logs, drift reports, and security plan/design/configuration updates) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Define an official trust-store content standard (approved trust anchors and any explicit rules to block them) in a version-controlled repository.
- [ ] Assign named roles and put an approval process in place for changes to the trust store, with oversight from information security.
- [ ] Set up automated deployment of the approved trust bundle to the operating system trust stores for managed devices, and configure browser settings where the browser supports this.
- [ ] Update applications and Transport Layer Security (TLS) / mutual Transport Layer Security (mTLS) network components so they use the approved trust bundle and policy (remove any built-in, one-off trust stores).
- [ ] Automate the process for bringing in certificates and certificate authorities (including their expiry and rotation, and any revocation or validity updates) to create approved tickets for trust-store updates
- [ ] Set up drift detection to compare the trust-store content currently in use against the approved policy, and automatically fix it if there is any mismatch.
- [ ] Update system security plans, designs, and configuration records to document which trust-store settings are covered, and to keep evidence of changes and any drift from the approved configuration.


---

#### IA-5.15 — GSA-approved Products and Services (Enhancement)

This requirement ensures your organisation uses only pre-approved products and services for the systems that: prove who people are, manage their login details, and control access to services. If this is not done, organisations may unintentionally use tools that have not been checked for safety and correct behaviour. That increases the risk of unauthorised access, weak or inconsistent checks of identity, and poor control over how user accounts are linked to login credentials and kept up to date.

To meet this expectation, the organisation must have a clear written policy and supporting procedures for how identity and authentication are handled. This includes how user identifiers are created, changed, and managed. The organisation must also show that these processes use only products and services that are listed on the General Services Administration approved list (or are otherwise recorded as approved through the relevant conformance programme).

In addition, for each system, the organisation must document:
- which approved products are used
- how user identifiers are dynamically linked to the credentials used to log in
- what configuration settings were applied
- records of identity and access activity are kept

##### IAM approved-catalogue with evidence-backed enforcement for FICAM

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define scope of “approved IAM catalogue” for FICAM (ICAM capabilities covered, environments, and integration types) and confirm mapping to IA-5(15) enhancement expectations | Compliance Manager | Enterprise | 8h | — |
| Create catalogue data model and evidence template (fields for vendor/product/service, version, GSA Approved Products List reference/link, approval status, applicability, and configuration baseline pointers) | Data Protection Officer | Enterprise | 16h | — |
| Build initial approved IAM catalogue entries for all ICAM components used by the application (IdP, MFA, federation, directory/identity store, certificate services/PKI components, PAM connectors, account lifecycle tooling, and any certificate/PKI-based access mechanisms) | Cyber Security Lead | Enterprise | 40h | — |
| Establish catalogue governance and maintenance process (ownership, change control, periodic review cadence, handling of new versions/retirements, and audit trail requirements) | Project Manager | Enterprise | 16h | — |
| Update identification/authentication and credential/access management policy to explicitly require “catalogue-approved GSA-approved ICAM products/services only”, including enforcement responsibilities and exceptions process | Compliance Manager | Enterprise | 24h | — |
| Implement architecture/design review checklist and release gate criteria to validate that every ICAM integration references only catalogue-approved components (including required evidence artefacts) | System Design Authority | Enterprise | 24h | — |
| Create per-system evidence pack for the application (system security plan/design updates listing approved catalogue components, applied configuration baselines, and how authentication/credential/PAM/certificate flows rely on them) | Security Engineer | Department | 32h | — |
| Define audit-ready evidence retention approach and run a first evidence dry-run (tie authentication/credential/PAM/certificate activity to approved components and capture configuration snapshots for production/test) | Operations Lead | Enterprise | 24h | — |
| **Total Estimated Effort** |  |  | **204h** |  |
| **Total Estimated Cost** |  |  |  | **£0** |

###### Actions Required for Compliance

- [ ] Create an approved identity and access management (IAM) catalogue that links each identity and access management capability used by the application to the relevant entry on the Government Software Agency (GSA) Approved Products List (including the version where applicable).
- [ ] Update the identification and authentication policy to require the use of only catalogue-approved, General Services Administration (GSA)-approved Identity, Credential, and Access Management (ICAM) products and services.
- [ ] Set up architecture and design review checkpoints that reject any identity and access management (ICAM) integrations that are not listed in the approved identity and access management (IAM) catalogue.
- [ ] Add checks to the continuous integration and continuous delivery (CI/CD) process to confirm that the identity provider (IdP), multi-factor authentication (MFA), federation, privileged access management (PAM), and certificate integration settings reference only approved catalogue components.
- [ ] Update the application security plan and design documents to name the approved identity and access management (ICAM) components and the configuration settings and baseline standards that have been applied.
- [ ] Set up evidence retention for audits by keeping (1) a record catalogue, (2) configuration snapshots, and (3) logs that show the identity and access management (ICAM) activity comes from approved components.


---

#### IA-5.16 — In-person or Trusted External Party Authenticator Issuance (Enhancement)

This requirement is about ensuring identity cards and their personal access codes are given out only in a controlled, face-to-face process, and only after the correct checks and approvals are completed. Without this, the wrong person could receive a smart card or its code, or the process could be rushed or skipped, which could lead to unauthorised access to systems and sensitive information.

To meet this expectation, the organisation must issue the specified, validated smart cards and deliver the associated personal identification number (PIN) in person—never through unattended or remote methods—and only after the registration team has formally approved the person’s identity. In addition, no smart card can be issued unless the Identity and Access Management director has explicitly authorised it. The organisation must also keep clear records showing that approvals were obtained first, that they relate to the same person and the same issuance event, and that the card and PIN were handed over together face-to-face.

##### Workflow-gated in-person PIV+PIN issuance with dual approvals

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define workflow state model and transition rules for issuance ordering (Submitted → RA Approved → IAM Director Authorised → Ready for In-person Issuance → Issued/Closed), including explicit “no issuance unless prerequisites met” logic | System Design Authority | Enterprise | 24h | — |
| Implement workflow enforcement in the IAM/identity lifecycle application (API/UI guards, server-side transition validation, subject/request binding, prevention of bypass, and denial responses) | Platform Engineer | Enterprise | 56h | — |
| Implement IAM Director authorisation capture and validation (explicit authorisation record, expiry handling, delegate rules if applicable, and strict linkage to the same subject/request/ticket) | Software Lead | Enterprise | 40h | — |
| Implement RA approval record validation and timestamp ordering enforcement (ensure RA approval exists and is earlier than issuance event; handle edge cases such as resubmissions/updates) | Security Engineer | Enterprise | 32h | — |
| Configure issuance staff tooling and queues so issuers can only act on items in `Ready for In-person Issuance` (role-based access, filtered worklists, and audit trail for any blocked attempts) | Operations Lead | Department | 24h | — |
| Add auditable evidence capture at handover and issuance (in-person confirmation, recipient verification evidence, card serial/batch/model scan capture, PIN delivery confirmation, all linked to the same issuance reference) | Compliance Manager | Enterprise | 48h | — |
| Build and enforce approved authenticator catalogue for FIPS 140-2 validated PIV card types (catalogue management, issuer selection/scan validation, and rejection of non-approved models/batches) | Cyber Security Lead | Enterprise | 32h | £6,000 |
| Testing, security review, and deployment (unit/integration tests for ordering/authorisation, negative/bypass tests, audit log verification, UAT with issuance team, and production release) | Quality Assurance Lead | Enterprise | 64h | £3,500 |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £9,500

###### Actions Required for Compliance

- [ ] Define the stages (states) and the allowed changes (transitions) for the issuance process: **Registration Approved → IAM Director Authorised → Ready for In-person Issuance**.
- [ ] Set up technical blocking rules so that issuance actions are refused unless there is an approved registration authority decision that has been recorded with a timestamp before the issuance happens for the same subject or request.
- [ ] Require explicit authorisation in the identity and access management (IAM) process as a mandatory, subject/request-specific step. Do not issue anything if the authorisation is missing, has expired, or does not match the request.
- [ ] Limit the issuance team’s user interface (UI) and application programming interface (API) access so issuers can only handle items that are in the queue approved for the workflow.
- [ ] Set up audit records and tamper-proof event capture for approval decisions, attempts to issue items, and evidence of in-person handover, all linked to one unique issuance reference.
- [ ] Create and enforce an approved list (catalogue) of FIPS 140-2 validated personal identity verification (PIV) card models and batches, and require staff to select the card from this approved list when issuing it.


---

#### IA-5.17 — Presentation Attack Detection for Biometric Authenticators (Enhancement)

This requirement is about protecting biometric sign-ins (such as fingerprint or facial recognition) from being fooled by fake or copied biometric features—for example, a photo, video, a lifted fingerprint, or a high-resolution image designed to trick the sensor. Without this protection, someone could get past identity checks by using an artefact instead of a real person, which could lead to unauthorised access to systems and potential harm to customers, staff, and the business.

To meet this expectation, the organisation must ensure that presentation attack detection is built into biometric sign-in and cannot be switched off or bypassed for real use. Where the biometric method supports it, the system must check that the person is live, record the result of those checks in audit records, and keep those records available for review.

The organisation must also document how the protection works, how it is configured, and who is responsible for enabling, maintaining, and monitoring it, so the approach stays consistent and accountable over time.

##### Enforce PAD-required biometric authentication with auditable outcomes

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select PAD-capable biometric authenticators (face/fingerprint/iris) and confirm liveness/PAD support beyond quality checks; produce a modality-by-modality capability matrix and acceptance criteria | System Design Authority | Enterprise | 24h | — |
| Define and publish the “PAD-required, non-bypassable” authentication policy for production flows, including explicit deny/fail decisioning on PAD fail/detected and prohibition of fallback/demo modes | Compliance Manager | Enterprise | 16h | — |
| Implement authentication flow enforcement: ensure biometric verification is accepted **only** when PAD outcome is pass/success; remove/disable bypass paths and add automated checks to prevent reintroduction of fallback behaviour | Software Lead | Enterprise | 40h | — |
| Centralise and lock PAD configuration using enterprise management plane; create versioned, peer-reviewed PAD configuration templates and enforce them across environments (prod/test/DR) with change-control guardrails | Platform Engineer | Enterprise | 32h | £18,000 |
| Integrate PAD outcomes into authentication events end-to-end (device/SDK → relying application → logging pipeline → SIEM), ensuring every attempt emits PAD result with user/device/session identifiers and consistent event schema | Security Engineer | Enterprise | 40h | — |
| Configure auditability and retention: implement log retention, access controls, and tamper-evident storage approach for PAD outcomes; document evidence mapping for audit | Data Protection Officer | Enterprise | 20h | £6,000 |
| SOC/SIEM operationalisation: create detection/alert rules for repeated PAD failures/suspected attack patterns, define triage runbooks, and validate alert fidelity with test cases | Service Delivery Manager | Enterprise | 24h | — |
| Produce system design/security planning documentation covering PAD behaviour, protected modalities, decisioning rules, responsibilities, and monitoring/maintenance ownership; include architecture diagrams and control evidence checklist | Cyber Security Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 212h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Confirm that each biometric authenticator software development kit (SDK) supports presentation attack detection (PAD) or liveness detection (not just checks for sensor quality) and record which PAD outcomes are supported.
- [ ] Set the authentication rules so that biometric verification is only allowed when “presentation attack detection” (PAD) is required. If the PAD result is “fail” or “attack detected”, block the authentication attempt.
- [ ] Disable or remove any production fallback, demo, or test modes that could bypass privileged access delegation (PAD) for real sign-in.
- [ ] Centralise personal access device (PAD) settings using the enterprise management platform, using version-controlled templates that are reviewed by peers, and apply controlled change processes.
- [ ] Set up event logging so that every login attempt records the result of privileged access detection (pass, fail, or detected), along with the relevant user, device, and session identifiers, and sends this information to security information and event management (SIEM).
- [ ] Set up and run security information and event management (SIEM) alerts to detect repeated personal access device (PAD) failures and possible spoofing patterns, with documented responsibility for investigating and resolving each alert.
- [ ] Update the system design and security planning documents to explain the programme for PAD behaviour, how it is configured, and the named responsibilities for enabling and monitoring it.


---

#### IA-5.18 — Password Managers (Enhancement)

This requirement is about using a trusted password vault to create and securely store every user’s passwords, so people do not have to reuse the same password or keep it in unsafe places. Without this, users may choose weak or repeated passwords, and if a password collection is stolen or exposed, attackers could use it to break into many accounts at once.

To meet this expectation, the organisation must use an approved enterprise password manager to generate and manage unique passwords for every user account in scope. It must protect stored passwords by encrypting them while they are stored, restrict access so only authorised personnel can retrieve and use them, and keep the password collection offline using tokenised storage so it is not continuously available online.

The organisation should also be able to demonstrate that only the right people can retrieve passwords, that access is properly restricted and regularly reviewed, and that the offline token approach is in place and can be traced.

##### Approved password manager with encrypted vault and offline token access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Select and formally approve the enterprise password manager platform (vendor evaluation, security review, approval record, procurement-ready business case) | Compliance Manager | Enterprise | 24h | £25,000 |
| Define in-scope account scope and credential lifecycle requirements (inventory static-password accounts, define onboarding/rotation workflows, update standards and runbooks) | Security Engineer | Enterprise | 32h | — |
| Configure encryption at rest for the vault and integrate with approved key management (KMS/HSM-backed keys, key rotation policy alignment, encryption configuration validation) | Platform Engineer | Enterprise | 40h | £6,000 |
| Implement authorised-personnel-only access model (least-privilege roles, enterprise identity integration, strong authentication/MFA enforcement, access approval workflow) | Cyber Security Lead | Enterprise | 32h | — |
| Implement offline tokenised vault access workflow (offline token device or controlled export/import cycle, operational procedure, enforcement checks, recovery/rollback approach) | Operations Lead | Enterprise | 40h | £12,000 |
| Enable auditability and SIEM integration (log every unlock/retrieval/export/failed attempt, configure retention, map events to SIEM, test alerting and evidence exports) | Security Engineer | Enterprise | 24h | £3,000 |
| Execute end-to-end testing and acceptance (pilot with representative account types, security testing, operational readiness review, acceptance evidence pack) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £48,000

###### Actions Required for Compliance

- [ ] Approve and record the enterprise password manager as the organisation-approved solution for creating and managing unique passwords.
- [ ] Create an up-to-date list of in-scope accounts and require new accounts to be set up through onboarding, so that all in-scope accounts that use static passwords are managed using the password manager.
- [ ] Turn on and confirm encryption for data stored in the password vault (data at rest), and make sure the encryption keys are protected using the organisation-approved key management approach.
- [ ] Set up vault roles with the minimum necessary permissions, and link vault access to your organisation’s identity system so only authorised staff can retrieve passwords.
- [ ] Set up and test offline access to a secured, token-based vault (using a token device or a controlled offline export and import) so that password collection is not kept continuously online.
- [ ] Turn on audit logging for vault unlocking, data retrieval, data export, and failed access attempts, and send those logs to the security information and event management (SIEM) system so they can be used as evidence.


---

### IA-6 — Authentication Feedback (Control)

This requirement is about protecting login information so that, when people sign in, nothing they type and no on-screen login messages can accidentally reveal secret details to someone nearby or watching. Without this, an unauthorised person could learn a password or other login secret by looking over someone’s shoulder, or by capturing what briefly appears on the screen, and then use it to gain access.

To meet this requirement, the organisation must clearly document how login feedback is hidden, set out the exact approach to use (for example, showing typed passwords as obscured symbols and keeping any temporary on-screen feedback very brief), and choose the method based on the device and the level of screen risk, while balancing the risk of users making typing mistakes.

The organisation must ensure this protection is applied at every step of authentication, configure systems so the protection works as described, keep evidence and audit records showing it is enabled, and assign named people to implement and maintain it.

##### Obscure authentication feedback via central IdP and UI masking

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define masking and generic-feedback requirements for all authentication steps (password, MFA/step-up, re-auth) including “no reveal” stance and short-lived feedback rules | Compliance Manager | Enterprise | 8h | — |
| IdP/SSO configuration: enforce masked secret input rendering, disable/lock any “show password”/reveal toggles, and set generic error templates across login and step-up flows | Cyber Security Lead | Enterprise | 24h | — |
| Application integration hardening: update app/SDK/OIDC/SAML integration to ensure authentication UI is fully IdP-hosted (no bespoke secret entry) and remove/override any app-level plaintext echo or sensitive error propagation | Software Lead | Business Unit | 32h | — |
| Device-category UI behaviour: implement/verify risk-based obscuring defaults for desktop vs mobile (still masked, non-sensitive transient status, no verbose near-miss feedback) | System Design Authority | Enterprise | 16h | — |
| Automated regression checks: add CI/CD tests and configuration-as-code validation to verify masking settings, generic error templates, and absence of sensitive feedback strings in IdP/app artefacts | DevOps Lead | Department | 40h | — |
| UI verification test suite: create and execute manual/automated UI tests covering web and mobile clients and all MFA/step-up/re-authentication prompts (including negative tests for sensitive feedback) | Quality Assurance Lead | Department | 24h | — |
| Audit evidence pack: enable/retain relevant IdP/app authentication audit logs, export configuration evidence (or IaC artefacts), and produce compliance-ready sign-off report mapped to IA-6 acceptance criteria | Data Protection Officer | Enterprise | 16h | — |

Total Estimated Effort: **180h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Use a single approved login screen design that requires secret information to be hidden (for example, shown as asterisks or dots) and that displays generic error messages.
- [ ] Set up the organisation’s identity provider (IdP) and single sign-on (SSO) hosted login, including multi-factor authentication (MFA) and any “step-up” checks, so that all secret information is hidden and no option is enabled that could display or echo secrets in plain text.
- [ ] Update the application sign-in (authentication) connections to use the approved identity provider (IdP) methods (hosted sign-in pages or approved software development kit (SDK) components), without changing how sensitive information is hidden (masked).
- [ ] Set up checks for continuous integration and continuous delivery (CI/CD) to confirm that masking settings and generic feedback templates stay enabled after any changes.
- [ ] Enable and keep identity provider (IdP) and application audit logs for sign-in events, so you have evidence that the configured authentication process is running in the live (production) environment.
- [ ] Run user interface tests for all supported client types (web and mobile) to confirm that, at every step of the authentication process, no plain text authentication information is shown.


---

### IA-7 — Cryptographic Module Authentication (Control)

This requirement is about making sure only the right people can access the organisation’s cryptographic tools and use them only for the tasks they are authorised to perform. Without this, someone could pretend to be an authorised operator or take on a role they are not permitted to have. This could result in unauthorised access to sensitive protection functions and misuse of cryptographic services.

To meet this expectation, the organisation must set clear, documented rules for how it checks identity and permissions when accessing cryptographic modules. These checks must follow all relevant laws, government instructions, organisational policies, regulations, and recognised security standards.

The organisation must also explain how these checks work in its system security plan and written procedures. It must document the authentication approach and the role and permission checks in its system design and configuration records. Finally, it must keep audit records showing what authentication and authorisation decisions were made, and whether access was granted or denied.

##### IAM-gated authentication and role verification for crypto module access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IA-7-aligned authentication and role/service authorisation policy for cryptographic module access (identity source, MFA requirements, role-to-service mapping, decision logic, step-up conditions) | Compliance Manager | Enterprise | 24h | — |
| Produce system design documentation and security plan updates describing the enforced authentication/authorisation flow (access broker/module integration points, request/response authorisation checks, conditional access/step-up triggers) | System Design Authority | Enterprise | 32h | — |
| Implement broker/module authorisation enforcement (RBAC/ABAC checks for requested cryptographic services, deny-by-default, least-privilege role mapping, service-level permission model) | Software Lead | Department | 56h | — |
| Integrate with enterprise IdP for authentication and MFA assurance (token validation, session binding, identity attributes required for authorisation decisions, handling of step-up outcomes) | Platform Engineer | Department | 48h | — |
| Configure conditional access and step-up for sensitive roles/services (device compliance/session risk/location constraints, privileged access constraints, step-up policy wiring to broker/module) | DevOps Lead | Business Unit | 32h | £6,000 |
| Implement audit logging and SIEM forwarding for authentication/authorisation outcomes (identity, MFA method, role requested, cryptographic service invoked, granted/denied decision, timestamps; retention-ready event schema) | Security Engineer | Department | 40h | £3,500 |
| Execute end-to-end testing and audit readiness validation (test cases for authorised/unauthorised access, step-up flows, negative testing, log completeness, evidence pack for IA-7) | Quality Assurance Lead | Business Unit | 40h | — |

**Total Estimated Effort:** 312h  
**Total Estimated Cost:** £9,500

###### Actions Required for Compliance

- [ ] Create an IA-7 authentication and role/permission policy for access to the cryptographic module, including a compliance mapping to the applicable requirements.
- [ ] Set up an access broker (or integrate with the module interface) that requires identity provider (IdP) sign-in and enforces phishing-resistant multi-factor authentication (MFA) for operators.
- [ ] Set up role-based authorisation rules for each cryptographic service and apply them to every request for a cryptographic service.
- [ ] Use conditional access and step-up authentication for privileged and sensitive cryptographic roles and services.
- [ ] Enable audit logs for sign-in and access decisions (who the user is, the role requested, which service was called, and whether access was granted or denied) and send them to security information and event management (SIEM) with the required retention period.
- [ ] Update the system security plan and the configuration and design records to document the authentication method and the rules used to decide authorisation.
- [ ] Publish clear working instructions for requesting roles, handling access denials, and managing exceptions, and check during testing that these instructions are followed.


---

### IA-8 — Identification and Authentication (Non-organizational Users) (Control)

This expectation is about making sure that any outside user, or any automated service acting on behalf of an outside user, is properly identified and checked before being allowed into your systems. Without this, the wrong person—or an unauthorised process—could gain access, pretend to be a partner or supplier, or carry out actions that are difficult to trace and investigate, putting sensitive information and business operations at risk.

To meet this, the organisation must clearly define which users and processes are considered “non-organisational”, document any specific, approved exceptions to the usual identification and checking rules, and set out the approach in written policies, privacy and security planning, and step-by-step procedures. The system must be configured so that each outside user and each acting process has its own distinct identity, is blocked if identification or checking is missing or fails, and records what happened so the organisation can review it and demonstrate compliance later.

##### IdP-gated unique authentication for external users and workload identities

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create non-organisational identity scope & exception register (human + workload), including mapping to documented AC-14 exceptions and review cadence | Compliance Manager | Enterprise | 24h | — |
| Design IdP SSO integration for non-organisational humans (phishing-resistant MFA requirements, token/session validation rules, deny-by-default behaviour) | System Design Authority | Enterprise | 32h | — |
| Implement application/API gateway enforcement to block unauthenticated/failed-authentication requests from reaching protected endpoints (middleware/reverse proxy configuration + test harness) | Platform Engineer | Department | 40h | — |
| Implement workload identity authentication for non-interactive processes (unique service principals/app registrations, certificate/key-based client auth, short-lived tokens, deny shared/long-lived secrets) | Security Engineer | Department | 40h | £3,000 |
| Configure conditional access policies for non-organisational identities (risk/device/network/location constraints aligned to enterprise standards) and validate outcomes | Cyber Security Lead | Enterprise | 24h | — |
| Implement audit logging for authentication outcomes (unique identity, method, result, timestamp, accessed resource, source) and forward to SIEM with retention-ready configuration | Operations Lead | Enterprise | 32h | £2,500 |
| Execute end-to-end testing & evidence pack for IA-8 acceptance (failure cases, exception traceability, SIEM log verification, sign-off) | Quality Assurance Lead | Department | 24h | — |

**Total Estimated Effort:** 216h  
**Total Estimated Cost:** £5,500

###### Actions Required for Compliance

- [ ] Create and keep a record (register) of identities that are not part of the organisation (both people and automated systems), and document any exceptions that are aligned with control AC-14.
- [ ] Configure the application and application programming interface (API) gateway so that every protected endpoint only accepts requests that include a valid token issued by the identity provider (IdP). Block any requests that are missing a token or that contain an invalid token.
- [ ] Require phishing-resistant multi-factor authentication (MFA) for all non-organisation human users in the identity provider (IdP), and require additional (step-up) MFA when accessing sensitive resources.
- [ ] Set up workload identity authentication for non-interactive processes by using unique application or service identities, authenticate using certificate-based client authentication, and use short-lived access tokens where supported.
- [ ] Disable or block shared accounts and service passwords for access paths that are not part of the organisation, and replace (rotate) any old shared secrets.
- [ ] Enable and check audit logs that record each unique user identity, the authentication method and outcome, and the resource that was accessed. Send these logs to the security information and event management (SIEM) system and keep them for the required retention period.


---

#### IA-8.1 — Acceptance of PIV Credentials from Other Agencies (Enhancement)

This requirement is about allowing people in only when they present official identity cards issued by other government organisations, and only if your system checks those cards electronically and records the result. Without this, someone could enter buildings or access systems using a card that is not genuine, has been cancelled, or is not approved for your organisation. This could lead to unauthorised access and potential harm to people, information, and services.

To meet this expectation, your organisation must clearly state in its access rules that it will accept these external identity cards for both building entry and system access, but only when they meet the required standard. You must document how the electronic checking works, how access decisions are made, and what staff should do if a card fails verification.

Your systems must be set up to perform the electronic check every time. You must also keep records showing the verification outcome, the card details used, and the permissions that allowed or blocked access.

##### Verify external-agency PIV (FIPS 201) before logical/physical access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Update identification/authentication and physical access policies to define acceptance of external-agency PIV (FIPS 201) and require electronic verification before logical/physical access | Compliance Manager | Enterprise | 16h | — |
| Define and document relying-party trust configuration for external PIV issuers (SP 800-79-2 authorisation), including issuer allow-list, certificate/chain validation rules, and revocation checking requirements | Security Engineer | Enterprise | 24h | — |
| Implement logical access electronic verification (PIV-capable authentication flow) so access is granted only after cryptographic credential verification (not “card presented”); include attribute mapping to verified identity | Software Lead | Enterprise | 56h | — |
| Implement physical access electronic verification integration for PACS/reader/controller workflow (or authoritative upstream decision consumption) to ensure unlocking/authorisation occurs only after successful verification | Platform Engineer | Enterprise | 48h | — |
| Implement “verified-then-authorised” enforcement in the authorisation layer (RBAC/ABAC) so authorisation consumes only verified identity attributes and denies by default on verification failure | Architect | Enterprise | 24h | — |
| Configure audit logging and SIEM forwarding for each attempt: credential identifier elements, verification outcome, and resulting access decision/authorisation basis; validate log schema and retention alignment | Operations Lead | Enterprise | 24h | £3,000 |
| Create failure-handling operational procedures and run end-to-end testing (success/failure cases for both logical and physical access, including revocation-failure scenarios) with evidence captured for audit | Service Delivery Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Update the identification and authentication policy to explicitly allow external-agency Personal Identity Verification (PIV) credentials for both digital (logical) access and physical access only after electronic verification has been completed.
- [ ] Document and get approval for decisions about which external agencies are trusted to issue personal identity verification (PIV) credentials, following SP 800-79-2, and set up the relying party trust settings (trust anchors) accordingly.
- [ ] Set up the logical access sign-in process to verify the cryptographic Personal Identity Verification (PIV) credential on every attempt, including checking whether it has been revoked.
- [ ] Connect the public access control system (PACS) and physical card readers/controllers so that entry is only allowed after electronic verification, or after an approved verification decision from an upstream system.
- [ ] Set up authorisation mapping that uses only verified identity information and makes access decisions only after verification.
- [ ] Enable audit logging for every attempt. Record the credential identifier details used, the verification result, and whether access was granted or denied. Send these records to security information and event management (SIEM) and keep them for the required period under the relevant policy.
- [ ] Create and train an operational process for handling verification failures, including: denying access by default, escalating the issue, and capturing evidence.


---

#### IA-8.2 — Acceptance of External Authenticators (Enhancement)

This requirement is about ensuring that, when people sign in to your public services using an external sign-in provider, you only allow providers that meet the required standard for checking identity. If you do not, attackers could persuade your organisation to trust an unreliable or unsafe sign-in method, which could result in unauthorised access, fraud, or the exposure of sensitive information.

To meet this expectation, your organisation must configure its public-facing systems to accept only external sign-in options that have been shown to meet the required standard. You must also keep a documented, maintained list of every external sign-in provider you have approved for use. This list must be detailed enough to identify each provider and where it is used, and it must be kept up to date whenever providers are added, changed, or removed. For each approved provider, you must record clear evidence showing why it is acceptable.

##### Policy-as-code gate for approved external authenticators

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the **Accepted External Authenticators** registry data model (fields, scope mapping, authenticator type, assurance level mapping, evidence reference requirements) and publish the registry specification | Security Engineer | Enterprise | 16h | — |
| Implement the **evidence schema** and validation rules (mandatory fields, format checks, evidence reference integrity, versioning of evidence basis) | Security Engineer | Enterprise | 20h | — |
| Build the registry-backed configuration generator (policy-as-code source → generated IdP/app federation configuration per application scope) | Platform Engineer | Enterprise | 40h | — |
| Implement CI/CD **deployment gate** to block releases when enabled external authenticators do not exactly match registry entries for the target scope, including evidence completeness checks | DevOps Lead | Enterprise | 32h | — |
| Establish governance controls for registry updates (authorised approver workflow, approval record capture, immutability/eligibility rules, separation of duties) | Compliance Manager | Enterprise | 24h | — |
| Add automated audit evidence capture (store registry version, generated configuration artefacts, approval record IDs; integrate with existing logging/audit retention) | Operations Lead | Enterprise | 24h | — |
| Create test harness and acceptance validation (unit/integration tests for policy rules, negative tests for bypass attempts, pipeline failure scenarios, evidence-missing cases) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create an “Accepted External Authenticators” register that lists each external authentication provider’s identifier, the required assurance level, which applications it applies to, and references to the supporting evidence.
- [ ] Define a required evidence format that matches the assurance expectations in NIST Special Publication 800-63B for every registry entry.
- [ ] Implement policy-as-code in continuous integration and continuous delivery (CI/CD) to generate and check identity provider (IdP) and application authentication settings from the registry.
- [ ] Set up deployment gates so that a release fails when enabled external authentication providers are not listed in the registry for the required scope, or when there is no supporting evidence.
- [ ] Limit permission to update the registry to authorised identity and access management (IAM) and security approvers, and require that approval details are recorded as metadata.
- [ ] Enable audit logging to record the container registry version, the approval record identifiers, and the exact configuration items that were deployed.


---

#### IA-8.4 — Use of Defined Profiles (Enhancement)

This requirement is about making sure your organisation uses a consistent, agreed set of proven rules for checking people’s identities and managing their accounts, so different services can work together reliably. Without this, the wrong people could gain access, accounts might not be created or disabled correctly, and partners or new systems may not connect smoothly—raising the risk of fraud, data exposure, and operational disruption.

To meet this expectation, the organisation must adopt and use defined identity-management profiles based on the following standards: the National Institute of Standards and Technology (NIST) Special Publication 800-63A/B/C, OpenID Connect (OIDC) and OAuth 2.0, Security Assertion Markup Language (SAML) 2.0, System for Cross-domain Identity Management (SCIM) 2.0, and the NIST 800-53 Revision 5 identity assurance mappings. It must then configure and run its identity and authentication, account handling, and related system features so they match these profiles.

The organisation must also be able to demonstrate this through clear internal documentation covering its identity and authentication policy, system security plan, system design, the specific system settings used, and audit records showing relevant events and outcomes. This documentation must also name the responsibilities of the teams that operate, develop, secure, administer, and manage accounts.

##### Profile-conformant IAM configuration for app and APIs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create profile-to-implementation mapping for IA-8(4) conformance (NIST 800-63A/B/C assurance, OIDC/OAuth2, SAML2, SCIM2 behaviours; define concrete IdP/app/SCIM settings incl. MFA/step-up, session/reauth, claims, signing, bindings, redirect allowlisting, SCIM joiner-mover-leaver) | Cyber Security Lead | Enterprise | 40h | — |
| Perform interoperability/viability assessment against applicable standards and constraints (protocol support, browser/mobile/API flows, token/session handling, SCIM provisioning capabilities, legal/regulatory alignment) and produce scope/assumptions for in-scope profiles | Compliance Manager | Enterprise | 16h | — |
| Implement profile-conformant IdP integration configuration (OIDC/OAuth2 and/or SAML2 relying party settings; MFA/assurance policies; session/reauth rules; signing/encryption; redirect URI and binding constraints; required claims/groups) | Platform Engineer | Business Unit | 32h | — |
| Implement SCIM 2.0 lifecycle provisioning integration (endpoint configuration, schema/attributes, role/group mapping, create/modify/deprovision alignment to profile requirements; idempotency and error handling) | Infrastructure Lead | Business Unit | 24h | — |
| Configure application-side enforcement and token/session validation (authorisation code + PKCE where applicable, strict audience/issuer validation, required claims checks, session/step-up handling, SAML assertion validation where applicable, secure storage of keys/secrets) | Software Lead | Department | 32h | — |
| Produce/refresh System Security Plan (SSP) and System Design documentation to explicitly state in-scope profiles, protocol choices (OIDC/SAML/SCIM), enforcement/interoperability approach, and evidence sources | Security Engineer | Department | 24h | — |
| Establish auditable configuration baselines and change control for IdP + SCIM (environment segregation, versioned configuration exports, approval workflow, rollback plan, evidence capture per change) | Operations Lead | Enterprise | 24h | £3,000 |
| Define and implement audit evidence collection (log fields and retention requirements; IdP/app/SCIM event correlation; SIEM ingestion checks; sample evidence pack for authentication outcomes, MFA challenges, token/session issuance parameters, provisioning/deprovisioning actions) | Service Delivery Manager | Enterprise | 24h | — |

|  |  |  | **Total Estimated Effort** | **Total Estimated Cost** |
|---|---|---:|---:|---:|
|  |  |  | **216h** | **£3,000** |

###### Actions Required for Compliance

- [ ] Create a table that maps each user profile in this application to the corresponding configuration settings. The table should cover the National Institute of Standards and Technology (NIST) 800-63A, 800-63B, and 800-63C assurance requirements, and describe the expected behaviours for OpenID Connect (OIDC), OAuth 2.0, Security Assertion Markup Language (SAML) 2.0, and System for Cross-domain Identity Management (SCIM) 2.0.
- [ ] Set up the organisation’s identity provider (IdP) and the application connection settings to enforce the required user profile rules, including multi-factor authentication (MFA) and assurance level, how often users must re-authenticate, what information is included in tokens and sessions, which connection methods are allowed, and restrictions on redirect URLs.
- [ ] Set up System for Cross-domain Identity Management version 2.0 (SCIM 2.0) so that when people join, move roles, or leave, their account and access are created or removed in line with the agreed profiles and the defined rules for assigning roles and groups.
- [ ] Update the application security system plan (SSP) and system design documents to clearly list the in-scope security profiles, the protocols used, and how compliance is demonstrated.
- [ ] Set standard configuration settings and use a change-controlled deployment process for identity provider (IdP) integration and system for cross-domain identity management (SCIM) endpoints across production (prod), testing (test), and disaster recovery (DR) environments.
- [ ] Turn on and keep audit logs for authentication events and account lifecycle changes that relate to profiles, and confirm the evidence is complete by running test authentications and running scheduled System for Cross-domain Identity Management (SCIM) lifecycle updates.


---

#### IA-8.5 — Acceptance of PIV-I Credentials (Enhancement)

This requirement is about only allowing people in using identity cards or digital credentials that have been officially trusted for the correct purpose. If this is not done, a system could wrongly accept a credential from the wrong provider or under the wrong trust rules, which could allow unauthorised access to buildings, applications, or services.

To meet this requirement, the organisation must accept and check federated or public-key credentials only when their certificate policy matches a specific, pre-approved Federal Bridge trust policy. This policy must be mapped and approved for the relevant United States Government relying parties.

The organisation must:
- document the rules for accepting and checking credentials
- build these rules into the system settings and design
- ensure the rules work for both physical access (for example, door entry) and logical access (for example, logging into systems)
- keep evidence that each accepted credential was actually verified
- record the events showing credential acceptance and verification
- ensure the staff responsible for day-to-day operations and security can explain and follow the process

##### Enforce FBCA PIV-I certificate-policy allow-list at IdP

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish authoritative FBCA PIV-I certificate policy allow-list for `ia-08.05_odp` (including exact-match/equivalence rules, versioning, and change-control workflow) | Compliance Manager | Enterprise | 16h | — |
| Define IdP/gateway enforcement requirements and acceptance criteria (X.509 validation scope, certificate policy extraction method, pass/fail semantics, exception handling) | System Design Authority | Enterprise | 12h | — |
| Configure IdP/federation gateway to perform full X.509 validation (chain trust, validity period, and revocation handling where applicable) and to extract certificate policy identifiers from presented credentials | Infrastructure Lead | Enterprise | 24h | — |
| Implement policy-gated acceptance logic: deny authentication unless extracted certificate policy identifiers match the approved allow-list for `ia-08.05_odp` | Security Engineer | Enterprise | 20h | — |
| Implement audit-ready verification outcome logging and SIEM event forwarding (structured fields for chain result, policy match/mismatch, final decision, correlation IDs) | Operations Lead | Enterprise | 16h | — |
| Integrate downstream logical access so applications/consumers rely on IdP decision (remove/disable any bypass paths that accept raw PKI credentials without policy gating) | DevOps Lead | Enterprise | 12h | — |
| Produce enforcement documentation and evidence pack (identifiers accepted, verification steps, pass/fail criteria, exception process, and runbook for operations/support) | Compliance Manager | Enterprise | 10h | — |

**Total Estimated Effort:** 110h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and approve the Federal Bridge Certification Authority (FBCA) Personal Identity Verification (PIV) - Identity (PIV-I) certificate policy identifier allow-list for `ia-08.05_odp` through the change control process.
- [ ] Set up the identity provider (IdP) and federation gateway to check the full X.509 certificate chain and to read the certificate policy identifiers from the credentials provided.
- [ ] Set up policy-controlled acceptance so authentication is refused unless the certificate policy matches the approved allow-list.
- [ ] Set up and test structured logging to record whether certificate policy matches or does not match, and the authentication decision, then send the logs to security information and event management (SIEM).
- [ ] Update single sign-on (SSO) and application integration so that whether someone can access the system depends on the identity provider’s (IdP) policy-approved authentication result.
- [ ] Document how the system security plan and authentication policy are enforced, the pass/fail criteria, and the process for exceptions and changes


---

#### IA-8.6 — Disassociability (Enhancement)

This requirement is about stopping people from being tracked across different organisations just because they use the same login details. Without this, someone’s identity information could be quietly reused or linked between partners or services, which could lead to unwanted profiling, loss of privacy, or misuse of personal data.

To meet this expectation, the organisation must set up its federated login service so that, for the same person, each external relying party receives a different, hard-to-guess identifier. It must also ensure that identifiers and identity details cannot be linked back together across different parties. The organisation must share only the minimum identity information each relying party genuinely needs, and it must document what is shared and the reasons for doing so.

The organisation must use privacy-protecting identifier mapping to prevent cross-party linking, reflect this in its system design and configuration, and keep evidence in audit and operational records showing that these settings continue to be correctly enforced over time.

##### Pairwise identifiers and blinded attribute release per relying party

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Perform federation/IdP privacy gap assessment for pairwise identifiers, claim release, and identifier mapping/blinding capabilities (SAML/OIDC) | IAM Architect | Enterprise | 16h | — |
| Design per-relying-party pairwise identifier strategy (subject/`sub` mapping rules, rotation/consistency requirements, test vs production behaviour) | System Design Authority | Enterprise | 24h | — |
| Define deny-by-default per-RP attribute/claim release policies (minimum-claims catalogue, allowed scopes/claims, stable identifier suppression, error handling for unauthorised requests) | Compliance Manager | Enterprise | 20h | — |
| Configure IdP/federation gateway to enforce per-RP claim sets and reject unauthorised claim requests at token issuance time (including SAML attribute statements / OIDC claims) | Federation Engineer | Enterprise | 32h | — |
| Implement/enable cryptographic blinding/privacy-preserving identifier mapping using IdP-supported privacy features (ensure relying parties cannot infer cross-RP linkage via token contents, metadata, or exposed artefacts) | Security Engineer | Enterprise | 40h | — |
| Establish evidence and audit trail: design and implement logging/audit events for relying party, pairwise identifier, released claims, and configuration versioning; update monitoring dashboards/alerts for policy drift | Operations Lead | Enterprise | 24h | — |
| Execute end-to-end validation and acceptance testing (test users across multiple RPs; verify different pairwise identifiers, minimum claims, and non-correlatability; produce test evidence pack) | Quality Assurance Lead | Enterprise | 24h | £3,000 |
| Total Estimated Effort |  |  | **180h** |  |
| Total Estimated Cost |  |  |  | **£3,000** |

###### Actions Required for Compliance

- [ ] Set up pairwise pseudonymous subject identifiers for each relying party in the identity provider (IdP) and federation configuration.
- [ ] Set “deny by default” rules for each relying party to control which claims and attributes are released, using only the approved minimum set of claims.
- [ ] Set up token issuing so that only authorised scopes and claims are included, so relying parties cannot ask for unauthorised attributes.
- [ ] Ensure that cryptographic or privacy-protecting identifier mappings are not revealed through token contents, metadata, or logs that the relying party can access.
- [ ] Set up automated “configuration as code” and change control for pairwise and claim policies for each relying party.
- [ ] Collect and keep audit records of when tokens are issued, including the relying party, the pairwise identifier, and the claims that were released.


---

### IA-9 — Service Identification and Authentication (Control)

This requirement is about making sure every service and application that provides web services, database query services, and connections between services proves its identity before it is allowed to communicate with devices, people, or other services. Without this, an attacker could pretend to be a trusted service, intercept or change information, or quietly connect unauthorised components that then gain access to systems and data.

To meet this expectation, the organisation must clearly decide which services are in scope, set and keep a written policy and step-by-step procedures for how each service is uniquely identified and checked, and record this approach in both the system security plan and system design. The system must use approved methods to prove identity and origin, check those proofs before allowing communication, and ensure any separate decision-making is used only to allow or block access.

The organisation must configure the system to support this, keep audit records of the checks, and assign and oversee responsibilities so operations staff follow the procedures, developers implement them, and security staff review that the controls work as intended.

##### mTLS service identities with pre-communication authentication gates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IA-9 service scope and authoritative service catalogue (per environment) including service owners, communication paths, and in-scope protocols (web/API/db-query/east-west) | Security Architect | Enterprise | 24h | — |
| Select and design workload identity approach for services (SPIFFE/SPIRE-style or equivalent), including identity format, trust domain model, certificate lifetime targets, and failure/deny-by-default behaviour | System Design Authority | Enterprise | 32h | — |
| Implement service identity issuance and registration workflow (bootstrap, attestation/registration, issuance of unique short-lived certs per service instance) with CI/CD integration | Platform Engineer | Enterprise | 56h | £18,000 |
| Configure mTLS enforcement at communication boundaries (ingress/egress gateways and east-west paths) with strict certificate validation, SAN/SPIFFE mapping, and deny-by-default when identity cannot be validated | Infrastructure Lead | Enterprise | 48h | £12,000 |
| Implement centralised pre-communication decision enforcement (gateway/mesh/API gateway policy) that validates caller identity and produces allow/deny decisions before forwarding to target services | Security Engineer | Enterprise | 40h | £10,000 |
| Implement audit evidence capture and SIEM forwarding (per request/connection: caller identity, certificate indicators, enforcement decision, reason codes; retention-ready log schema) | Compliance Manager | Enterprise | 24h | £6,000 |
| Operationalise lifecycle controls (certificate rotation automation, revocation procedure, DR scenario testing, runbooks, and change records with evidence) | Operations Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £46,000

###### Actions Required for Compliance

- [ ] Create and keep up to date an IA-9 service catalogue for each environment, covering web services, database query services, and connections (application programming interfaces) between services.
- [ ] Choose and put in place a workload identity method that creates unique service identities and uses short-lived credentials.
- [ ] Set up incoming and outgoing network gateways, and the internal “east–west” service connections, to use mutual Transport Layer Security (mTLS) with strict certificate checks, and block all traffic by default (deny-by-default).
- [ ] Put policy checks at the gateway, service mesh, or application programming interface (API) layer to verify a user’s identity and sign-in status, and to decide whether to allow or block the request before it is forwarded.
- [ ] Set up and centralise audit logs for identity checks in the security information and event management (SIEM) system, including: the identity being checked, certificate details, whether access was allowed or denied, and the reasons for any denials.
- [ ] Use continuous integration and continuous delivery (CI/CD) to automate certificate renewal and the registration of service identities, and check that certificates are revoked and renewed in a non-production environment, with supporting evidence.


---

### IA-10 — Adaptive Authentication (Control)

This expectation is about making sure that if someone tries to access sensitive information in a suspicious way, they must prove their identity again using stronger checks. Without this, an attacker who has stolen a password could pretend to be a genuine user and access confidential files—especially if the access is from an unusual location, from an internet address with a poor reputation, if unusually large amounts of data are downloaded, or if someone tries to view information outside what their role normally allows.

To meet this expectation, the organisation must set up the system so that, in these specific trigger situations, access to Secret/Confidential information requires an extra step: a second form of identity verification using either a FIDO2 security key or an approved authenticator app, plus a check that the device being used meets the required security conditions. The organisation must document how this works, configure the system to enforce it, and keep records showing when the extra checks were triggered and whether they were successful or failed.

##### Step-up MFA + device posture for Secret/Confidential access triggers

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define trigger conditions and thresholds for Secret/Confidential step-up (out-of-pattern access, anomalous IP/geolocation, bulk-download volume/bytes) including risk-score mapping and initial tuning plan | Compliance Manager | Enterprise | 24h | — |
| Design conditional access flow: baseline MFA remains; step-up MFA + device posture attestation required only when triggers fire, including decision logic for success/failure and user messaging | System Design Authority | Enterprise | 32h | — |
| Implement application/API instrumentation for trigger signals (bulk-download events with record counts/bytes; out-of-pattern access indicators; resource/data classification tagging) and integrate with IdP/authorisation broker for pre-action challenge | Software Lead | Department | 56h | — |
| Configure IdP/authorisation broker policies for step-up MFA using FIDO2 or approved authenticator app, and device posture attestation rules aligned to enterprise device compliance standard | Infrastructure Lead | Enterprise | 40h | — |
| Implement device posture attestation integration (managed device/compliance signals, encryption/patch/EDR checks), including fallback/deny logic and exception handling process | Security Engineer | Department | 32h | — |
| Build audit logging and evidence generation: trigger reason(s), data classification, step-up method, device posture result, outcome; ensure retention and SIEM forwarding with required fields and correlation identifiers | Operations Lead | Enterprise | 40h | — |
| SOC/SIEM validation and operational readiness: test end-to-end scenarios, validate alerting/correlation, document runbooks, and perform controlled false-positive/negative tuning for thresholds | Service Delivery Manager | Enterprise | 24h | — |
| Release management and controlled rollout plan (test, staging, production), including change approvals, regression testing for baseline MFA, and post-implementation compliance sign-off | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Set the rules for when to trigger alerts for out-of-pattern access to Secret/Confidential information, unusual location or internet protocol (IP) reputation, and bulk download limits, mapped to **ia-10_odp.02**.
- [ ] Integrate the application/application programming interface (API) with the organisation’s identity provider (IdP) and authorisation service to require additional verification (“step-up”) before any Secret or Confidential data can be exported, downloaded, or returned in a response.
- [ ] Set up step-up multi-factor authentication (MFA) so that the extra verification requirement in **ia-10_odp.01** can be met only by **FIDO2 security keys** and/or **approved authenticator apps**.
- [ ] Enable device posture attestation and link the compliance signals to the organisation’s required device security settings.
- [ ] Set up audit logs for every triggered event, recording the trigger reason, the step-up method used, the resulting device security posture, and whether it succeeded or failed. Send these logs to security information and event management (SIEM).
- [ ] Test the full process using real users and devices to confirm that step-up authentication happens only when the defined triggers occur, and that it does not replace the baseline multi-factor authentication (MFA).


---

### IA-11 — Re-authentication (Control)

This requirement is about making sure people prove they are still who they say they are at the moments when mistakes or misuse would cause the most harm. It matters because if someone’s access changes, they start doing high-importance actions, or they have been away from their account for too long, an attacker or an unauthorised person could take advantage of an already-open session to make changes, approve sensitive work, or access higher-risk areas without being checked again.

To meet this expectation, the organisation must set clear rules and step-by-step procedures for re-checking identity when a user is about to carry out privileged actions, when their role or the system’s security level changes, and after 30 minutes of inactivity. It must build these checks into system settings, keep an up-to-date list of when re-checks are required, document how the system enforces them, and keep records showing both what triggered the re-check and the prompt the user received, so the organisation can demonstrate that the controls worked as intended.

##### Step-up re-auth for privileged actions, role/category changes, and 30-min idle

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IA-11 re-auth policy triggers (privileged execution, role/entitlement change, security-category change, 30-minute inactivity) and map each trigger to concrete enforcement points in the application and IdP | Compliance Manager | Enterprise | 16h | — |
| Implement privileged-function tagging and enforcement in the application (e.g., middleware/guard that blocks privileged workflows until step-up re-auth succeeds) | Software Lead | Department | 24h | — |
| Implement inactivity tracking (30-minute timer based on authenticated user activity) and integrate it into the “next privileged action requires step-up” decision path | Backend Engineer | Department | 16h | — |
| Propagate authorisation context changes into the re-auth decision (role/entitlement and security-category change events update session context / freshness requirement for next privileged action) | Security Engineer | Department | 24h | — |
| Configure IdP step-up/re-auth / conditional access for application-indicated privileged actions and session freshness, including handling of step-up outcomes (success/failure) returned to the application | IAM Engineer | Enterprise | 32h | £8,000 |
| Implement end-to-end audit logging and SIEM forwarding (trigger, challenge issued, outcome, and privileged action completion only after success) with retention aligned to organisational requirements | Security Operations Lead | Enterprise | 20h | £3,000 |
| Build test plan and execute validation (unit/integration tests, IdP sandbox tests, regression, and evidence capture for acceptance criteria) | Quality Assurance Lead | Department | 24h | — |

**Total Estimated Effort:** 156h  
**Total Estimated Cost:** £11,000

###### Actions Required for Compliance

- [ ] Define and document the IA-11 re-authentication policy triggers exactly as follows: privileged function execution, a change in role or security category, and 30 minutes of inactivity.
- [ ] Mark privileged functions and workflows in the application so the backend can request extra verification (step-up authentication) before they are executed.
- [ ] Configure the organisation’s identity provider (IdP) to require extra verification (step-up re-authentication) for privileged actions, and to ensure the session has the correct elevated context (role/category) and is still recent (session freshness).
- [ ] Set up inactivity monitoring with a 30-minute limit, and require extra approval (step-up) for the next privileged action once that limit has been exceeded.
- [ ] Ensure that any changes to roles, permissions, or security categories update the current session details, and flag the session so that any later privileged actions require step-up verification.
- [ ] Set up audit logging and security information and event management (SIEM) to track and link, in order: the trigger, the re-authentication challenge, the re-authentication result, and the completion of the privileged action.


---

### IA-12 — Identity Proofing (Control)

This requirement is about making sure you genuinely know who someone is before giving them an account to access important systems. Without proper identity checks, the organisation risks fraudulent or incorrect account registrations—for example, the wrong person being granted access, or an attacker creating an account using false information.  

To meet this expectation, the organisation must confirm a person’s identity for every account that needs access, using the required level of identity assurance for that type of account, as set out in relevant standards and guidance. It must also connect the person’s identity to one single, unique individual, so there is no confusion or duplication.  

Finally, it must collect the person’s identity information, check that it is accurate, and verify it—while ensuring any legal or privacy obligations are considered through appropriate internal privacy and legal advice.

##### IAL-based identity proofing with unique identity resolution in IdP

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IAL mapping by account category (employee/contractor/partner/privileged operator) and publish IdP identity proofing policy with evidence/verification requirements per IAL | Compliance Manager | Enterprise | 24h | — |
| Design identity resolution model for “single unique individual” using deterministic keys (e.g., authoritative employee/contractor ID + verified personal identifier), including duplicate detection logic and adjudication workflow | System Design Authority | Enterprise | 32h | — |
| Configure IdP onboarding/registration workflow to enforce IAL-specific evidence collection, validation gates, and verification steps (including step-up for higher IALs) | IAM Lead | Enterprise | 40h | — |
| Implement automated evidence validation and verification integrations (issuer allow-lists, attribute format/provenance checks, consistency rules vs authoritative sources) with configurable rule sets per IAL | Security Engineer | Enterprise | 56h | — |
| Build identity resolution and adjudication queue in IdP (ambiguous match routing, non-creation on conflict, audit trail linkage to resolution decision and adjudicator actions) | Platform Engineer | Enterprise | 48h | — |
| Implement tamper-evident audit logging, evidence retention/minimisation controls, and SIEM export for proofing outcomes and resolution decisions (audit-ready evidence pack) | Operations Lead | Enterprise | 40h | £6,000 |
| Privacy/legal review and documentation updates (lawful basis, retention schedules, minimisation approach, DPIA/records of processing, and system security plan updates) | Data Protection Officer | Enterprise | 24h | £3,000 |
| End-to-end testing, pilot rollout, and acceptance evidence (test cases for each IAL, negative tests for duplicates/ambiguous matches, performance and failure-mode testing, and go-live readiness) | Quality Assurance Lead | Enterprise | 56h | — |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Create an identity proofing policy that maps each account type to the required identity assurance level (IAL).
- [ ] Set up the identity provider (IdP) onboarding process to collect the required identity evidence details for each assurance level (IAL).
- [ ] Set up automated checks to confirm the information is correct, including its format, whether the issuer can be trusted, where it came from, and whether it matches trusted official sources.
- [ ] Carry out identity verification steps that are appropriate for the required assurance level (including, where the assurance-level mapping requires it, stronger “step-up” verification that is resistant to phishing).
- [ ] Set up a consistent way to match each record to one specific person by using unchangeable official identification details, and turn on duplicate detection so repeated records can be reviewed and resolved.
- [ ] Enable tamper-evident audit logs of proofing results and identity matching decisions to support audit readiness
- [ ] Carry out the full privacy and legal review for how evidence is reduced and how long it is kept, then put in place the approved retention controls.


---

#### IA-12.1 — Supervisor Authorization (Enhancement)

This requirement ensures that when someone requests access to the organisation’s systems and applications, their manager or nominated sponsor must explicitly approve the request before any account is created. This is important because, without that approval, accounts could be set up too easily, given to the wrong people, or granted with more access than they actually need—raising the risk of misuse, mistakes, or unauthorised access that could disrupt operations or expose sensitive information.

To meet this expectation, the organisation must use a registration process where supervisor or sponsor approval is part of the workflow before any account request can be completed. The organisation must also clearly define who is considered the approving manager. Before approval is granted, it must carry out identity checks. It must keep clear records showing who approved, when they approved, and that they confirmed the account is necessary for the person’s role and that the requested access level matches their responsibilities.

##### Block account registration until supervisor/sponsor approval

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define supervisor/sponsor eligibility rules and mapping logic (including acting/temporary sponsors and validity windows) using authoritative HR/identity attributes | Identity & Access Management Lead | Enterprise | 24h | — |
| Configure identity workflow gating so provisioning/activation cannot complete until approval is recorded (or account is created in non-usable pending state) | System Design Authority | Enterprise | 32h | — |
| Integrate identity proofing completion checks as a prerequisite for routing to supervisor/sponsor approval (including mismatch/exception handling) | Security Engineer | Enterprise | 20h | — |
| Implement structured approval evidence capture (necessity for organisational mission/functions + access appropriateness) with required fields, validation, and approver justification where applicable | Compliance Manager | Enterprise | 16h | — |
| Ensure privileged/admin access requests follow the same blocking approval workflow (no bypass via application-side admin actions; enforce via identity governance integration) | Platform Engineer | Enterprise | 20h | — |
| Configure audit logging, retention, and queryability for approval evidence (request/approver identities, timestamps, decision outcome, confirmations) and validate against audit sampling requirements | Operations Lead | Enterprise | 24h | — |
| End-to-end testing and go-live readiness (test cases for normal, temporary sponsor, identity proofing failure, and privileged access; produce evidence pack for last 30–90 days sample) | Quality Assurance Lead | Enterprise | 28h | £3,000 |
| Total Estimated Effort |  |  | **184h** |  |
| Total Estimated Cost |  |  |  | **£3,000** |

###### Actions Required for Compliance

- [ ] Define the rules for linking each supervisor to the correct sponsor approver, using official human resources (HR) and identity information, including how to handle temporary or acting sponsors.
- [ ] Set up the identity governance and identity provider (IdP) registration process so that account provisioning and activation are blocked until the supervisor or sponsor has approved the request.
- [ ] Make completion of identity checks a required step before sending the request to the supervisor or sponsor for approval.
- [ ] Add structured confirmation fields for approvers to confirm: (a) the access is necessary for the organisation’s missions or functions, and (b) the access level is appropriate.
- [ ] Link workflow results to account provisioning so new accounts stay pending/inactive until approval evidence is recorded.
- [ ] Turn on and keep audit logs for every request, recording who made the request, who approved it, the decision made, the date and time, and confirmation that the approval was completed.


---

#### IA-12.2 — Identity Evidence (Enhancement)

This requirement is about making sure the organisation genuinely verifies a person’s identity before they are officially registered. If identity evidence is not checked properly, the wrong person could pretend to be someone else, get an account, and then misuse access—potentially leading to financial loss, exposure of sensitive data, or disruption to important services.

To meet this expectation, the organisation must ensure the registration authority collects and reviews proof of identity before registration. It must use only approved types of evidence, such as official documents, and, where appropriate, a combination of documents and biometric checks.

The registration authority must decide what level and type of evidence to use based on the risks and the level of access and privileges the person will have. This includes risks related to the person’s role and the systems they will use.

The organisation must document the identity-checking process, require staff to follow it, set out the evidence requirements in its internal policy, and keep records showing what evidence was provided and reviewed for each person.

##### Risk-based identity proofing workflow with evidence capture

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define evidence tiers (Tier 0/1/2/3) and mapping to role/privilege and system criticality, including acceptable evidence types (documents only vs documents+biometrics) | Compliance Manager | Enterprise | 24h | — |
| Design the risk-based proofing workflow and decision logic (pre-registration block, step-up triggers on privilege change, separation of duties rules) | System Design Authority | Enterprise | 32h | — |
| Implement IAM/registration pipeline enforcement (block account creation/elevation until RA approval; integrate tier decision inputs; ensure requester cannot approve) | Software Lead | Enterprise | 56h | — |
| Build/Configure registration authority evidence capture and review workflow (UI/workflow, completeness/format checks, manual review steps, reviewer identity capture) | Platform Engineer | Enterprise | 48h | — |
| Implement evidence metadata and audit record storage (evidence type(s), issuer/document type, verification outcomes, reviewer identity, timestamps, decision) with retention hooks | Data Protection Officer | Enterprise | 40h | — |
| Integrate with enterprise logging/SIEM and monitoring (audit event generation, alerting on workflow failures/attempted bypass, evidence access auditing) | Security Engineer | Enterprise | 24h | — |
| Develop and execute test plan (unit/integration, negative tests for bypass, step-up proofing scenarios, audit trail verification) and deploy with change management | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define evidence levels based on a person’s role and access privileges, and on how critical the system is. Specify whether evidence is document-only or requires both documents and biometric information.
- [ ] Set up the account registration and provisioning process so that new accounts cannot be created and permissions cannot be increased until identity checks are completed and approved.
- [ ] Set up a process to collect and review proof for registrations, including recording the reviewer’s decision.
- [ ] Store and connect the proofing evidence details and results (type of evidence, verification outcome, reviewer identity, and dates/times) to the identity record.
- [ ] Ensure separation of duties so that people who submit an identity evidence request cannot approve or review their own identity evidence.
- [ ] Set up “step-up” checks to run when a user’s role or system access level increases.


---

#### IA-12.3 — Identity Evidence Validation and Verification (Enhancement)

This requirement is about making sure the person applying for an account is genuinely who they say they are, before the organisation creates or links the account. Without this check, someone could use a fake or borrowed identity to gain access, pretend to be a real customer or employee, and potentially misuse systems or permissions they should not have.

To meet this expectation, the organisation must use approved identity checks either in person or by video. Staff must review a government-issued identity document, confirm that the person on the call or in front of them matches the document (including any required credential or biometric match), and verify the information against reliable official records.

The organisation must set out these approved methods in its identity rules and step-by-step procedures, ensure the systems can support the approach, and assign named staff to carry out the checks. It must also keep clear records showing what method was used, the results of the checks, and the final decision. The organisation must not create or link an account if the evidence does not pass validation or verification.

##### Approved identity proofing workflow before account creation/linking

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define approved identity proofing methods and risk-based assurance rules aligned to IA-12(3) (validation + verification) including decision outcomes and escalation handling | Compliance Manager | Enterprise | 24h | — |
| Design the end-to-end onboarding/orchestration workflow (IdP/registration service + proofing provider + case management) with explicit “Approved/Rejected/Escalate” decision gates before account creation/linking | System Design Authority | Enterprise | 32h | — |
| Implement IdP/registration enforcement: block account creation and account linking unless proofing outcome is “Approved”, including API/SDK integration and fail-closed behaviour | Platform Engineer | Enterprise | 56h | — |
| Implement auditable case record capture: store method, validation checks (authenticity/genuineness, data correctness/currentness, relation to individual), verification checks (linkage to presenter, authoritative-record results), timestamps, and operator/automation identity | Security Engineer | Enterprise | 40h | — |
| Configure risk-based branching (e.g., privileged roles require stronger proofing) and add automated policy mapping from role/privilege to required proofing strength | Security Engineer | Enterprise | 24h | — |
| Build operational runbooks and exception workflow for “Escalate” and re-proofing (including operator responsibilities, evidence handling, and audit/retention expectations) | Operations Lead | Enterprise | 20h | — |
| Test, security review, and pilot rollout: integration testing, negative testing (no proofing → no account), audit evidence verification, and production release readiness | Quality Assurance Lead | Enterprise | 48h | £6,000 |
| Total Estimated Effort |  |  | **244h** | — |
| Total Estimated Cost |  |  | — | **£6,000** |

###### Actions Required for Compliance

- [ ] Document approved identity evidence validation and verification methods that match IA-12.03 ODP, including in-person or video checks, government identity documents, matching credentials and biometrics, and verifying against authoritative records.
- [ ] Set up an onboarding process that checks identity (proofing) before creating any account or linking any account, and that clearly returns one of these results: **Approved**, **Rejected**, or **Escalate**.
- [ ] Configure the identity provider (IdP) and registration service to prevent new accounts being created or linked unless the workflow outcome is **Approved**.
- [ ] Combine the proofing provider’s outputs and keep complete, auditable case records showing: the method used, the validation results, the verification and linking results, checks against authoritative records, the relevant dates and times, and the final decision.
- [ ] Set up risk-based assurance mapping so that roles with higher privileges must provide stronger proof of identity, in line with the defined identity rules.
- [ ] Create operational runbooks and assign named responsibilities for handling escalations, re-checking proof, and processing exceptions, including audit logging of what operators do.


---

#### IA-12.4 — In-person Validation and Verification (Enhancement)

This requirement is about ensuring that, in person, people prove who they are before an authorised registration team issues or accepts an identity credential. It matters because if identity checks are done only remotely or by the wrong people, criminals could use fake documents or pretend to be someone else to obtain credentials they should not have. Those credentials could then be used to access services, accounts, or benefits improperly.

To meet this expectation, the organisation must arrange for identity evidence to be checked and confirmed during a face-to-face meeting with a designated registration authority. The organisation must not use unauthorised staff or third parties to carry out this step.

The organisation should keep clear records showing that the person attended in person with the designated authority, that the authority checked the physical identity evidence, and that the person who carried out the check is clearly identified as an authorised registration authority.

##### In-person identity proofing by authorised registration authority

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define and approve the designated registration authority roster (role-based), including authorisation evidence, training/competency requirements, and periodic revalidation schedule | Compliance Manager | Enterprise | 24h | — |
| Establish the in-person proofing desk/procedure and controlled attendance model (including appointment workflow, identity document handling rules, and escalation paths for refusals) | Project Manager | Enterprise | 32h | — |
| Create the standard proofing checklist and outcome recording template (fields for document types, verification/validation outcome, timestamps, proofing authority attribution, and applicant session linkage) | Compliance Manager | Enterprise | 16h | — |
| Implement auditable, tamper-evident proofing record retention approach (e.g., immutable audit logging/workflow records and controlled retention of proofing forms) and define evidence sufficiency requirements | Data Protection Officer | Enterprise | 40h | — |
| Configure the credential issuance/acceptance gate to require a valid proofing reference mapped to the in-person proofing record (including validation logic, error handling, and audit trail requirements) | IAM/Identity Engineering Lead | Enterprise | 48h | — |
| Define and implement the exception process for any non-standard proofing (pre-approval workflow, documented rationale, approval reference capture, and traceability to the proofing record) | Compliance Manager | Enterprise | 24h | — |
| Conduct operational readiness and audit rehearsal (staff briefing, tabletop test of end-to-end flow, evidence review against acceptance criteria, and corrective actions) | Quality Assurance Lead | Enterprise | 24h | — |

Total Estimated Effort: **208h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create and get approval for a named list of registration authority staff, including specific roles and individuals, and provide proof that this list is reviewed and confirmed at regular intervals.
- [ ] Set up an in-person proofing process that requires the person to attend in person and meet face to face with the nominated registration authority.
- [ ] Create a proofing checklist that lists: (1) the required validation and verification steps, and (2) the required recorded information, including document type, result, date and time, and the identity of the authorised staff member.
- [ ] Use tamper-evident storage or write-once (immutable) workflow logs for proofing records, and prevent changes by locking completed sessions.
- [ ] Set up the process for issuing and accepting credentials so that it only continues after a valid proofing reference is provided and that reference is linked to an in-person proofing record.
- [ ] Set up an exception process that requires prior approval, and make sure every approved exception is recorded and linked to the relevant evidence record.


---

#### IA-12.5 — Address Confirmation (Enhancement)

This requirement is about making sure the person who signs up is genuinely connected to the address they claim. The organisation must send a temporary registration code or a proofing notice to a place where the person can be reached outside the sign-up process. If this is not done, someone could pretend to be a real customer and complete registration using another person’s details, which could lead to fraud, unauthorised access, or incorrect records.

To meet this expectation, the organisation must clearly define how it will confirm the “address of record” using an out-of-band method. It must send the code or notice to the delivery destination already held in its existing records, not to anything the user enters during the confirmation step. The organisation must be able to deliver the code or notice to either:
- a physical address (for example, a home address), or
- a digital address (for example, an email address or mobile number).

It must also deliver it using a different channel from the one used to register.

The approach must be documented in its procedures and plans, assigned to the right staff, supported by the system, and backed by records showing the code was sent to the correct address and was successfully used to complete confirmation.

##### Out-of-band address confirmation code via IdP using address-of-record

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define ia-12.05_odp out-of-band registration code flow (email/SMS), including expiry window, retry limits, and failure handling | Compliance Manager | Enterprise | 16h | — |
| Design proofing session data model and persistence: store proofing session ID, authoritative destination snapshot (masked), code hash, expiry, delivery status, and verification outcome | System Design Authority | Enterprise | 24h | — |
| Implement authoritative address-of-record retrieval at session creation (IdP profile attributes sourced from system of record) and persist masked snapshot for audit | Security Engineer | Enterprise | 32h | — |
| Implement code generation and secure delivery orchestration (short-lived code, one-time use semantics, provider integration, delivery attempt logging with correlation IDs) | Platform Engineer | Enterprise | 40h | £6,000 |
| Enforce out-of-band separation and anti-substitution controls in the registration journey (disable/ignore destination changes; ensure code is never exposed in the same channel/session) | Software Lead | Business Unit | 32h | — |
| Bind verification to proofing session (UI/API for code entry only; validate code hash + expiry; mark address confirmed per session; prevent cross-session replay) | Software Lead | Business Unit | 24h | — |
| Implement audit evidence and retention: event schema, SIEM/SOAR integration hooks, masked destination storage, delivery provider response capture, and reporting queries | Cyber Security Lead | Enterprise | 24h | — |
| Execute end-to-end testing and security assurance (unit/integration tests, negative tests for substitution/replay, accessibility checks for code entry, and audit evidence verification) | Quality Assurance Lead | Department | 32h | £2,500 |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] Set up the registration and identity-check process so it creates a short-lived registration code (`ia-12.05_odp`) and sends it to the user using a separate, out-of-band method (email or text message).
- [ ] Set up proofing-session logic to look up the delivery address from the official address-of-record details, and save a masked copy of that address so it can be used to verify the binding.
- [ ] During the confirmation step, remove or ignore any destination details provided by the user, so address substitution is not possible.
- [ ] Make sure the registration code is not shown in the registration website or application session, and that it is not included in the registration application programming interface (API) response.
- [ ] Link the code check to the identity verification session, and only mark the address-of-record as confirmed after the code is entered successfully within the allowed time limit.
- [ ] Turn on audit logging and set retention for: code generation, delivery attempts (with the destination masked), the delivery provider’s response, and the verification result—using correlation identifiers to link related events.


---

#### IA-12.6 — Accept Externally-proofed Identities (Enhancement)

This requirement is about allowing people to use your system only when their identity has been checked by an independent outside organisation to a sufficiently strong standard. If you accept identities that were verified too weakly, the wrong person could gain access, pretend to be a legitimate user, or cause harm to data and services.

To meet this expectation, the organisation must accept externally verified (federated) identities for this system only when the outside identity checks meet the required Level 3 standard. It must state this clearly in its identity and login rules, the step-by-step procedures for checking external identity proof, and the system’s security plan and supporting records.

The organisation should also make sure staff know what to do if the outside proof is missing, unclear, or below the required standard—for example, by denying access or requiring the identity to be re-checked to reach Level 3 before it is accepted.

##### Enforce Level 3-only externally-proofed identities via federation claims

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm assurance indicator sources and define Level 3 mapping logic (e.g., `acr`/`loa`/`assurance_level` values, federation metadata rules, default rejection behaviour) | Compliance Manager | Enterprise | 16h | — |
| Update identification/authentication policy and system security plan text to explicitly state “externally-proofed identities accepted only when mapped to Level 3” (including missing/malformed indicator handling) | Compliance Manager | Enterprise | 24h | — |
| Implement relying-party boundary enforcement (API gateway/reverse proxy/auth middleware/IdP integration layer) to validate presence, format, and Level 3 mapping; deny otherwise | Security Engineer | Department | 40h | — |
| Add auditable onboarding/trust mapping records per external IdP/agency (claim/metadata element used for assurance, Level 3 mapping rationale, and retained evidence references) | Data Protection Officer | Enterprise | 24h | — |
| Implement login decision logging and retention (issuer, assurance indicator value, mapping outcome, allow/deny decision, correlation IDs) and ensure SIEM integration supports audit queries | Operations Lead | Department | 24h | £3,000 |
| Create automated tests and validation scripts (unit/integration) covering: missing indicator, malformed indicator, below-Level-3 values, Level-3 success cases, and regression across environments | Quality Assurance Lead | Department | 24h | — |
| Execute rollout readiness: configuration review, change management, and audit evidence pack generation for the control IA-12(6) enhancement | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Update the identification and authentication policy to say that externally verified identities are accepted only at {{ ia-12.06_odp }} (default level 3) for this application.
- [ ] Configure the relying party (the application gateway/reverse proxy/authentication middleware) to require an assurance indicator claim (for example, `acr`, `loa`, or `assurance_level`) and map it to Level 3.
- [ ] Use a “deny by default” authentication approach when the assurance indicator is missing, invalid, or indicates a level below Level 3.
- [ ] Create and keep an auditable trust mapping record for each external identity provider (IdP) or agency. This record must show the assurance claim and supporting information (metadata), along with the evidence that supports the Level 3 mapping.
- [ ] Enable and keep records of authentication decisions, including the issuer, the assurance indicator value, the mapping result, and whether the outcome was allow or deny.
- [ ] In the system security plan, record how enforcement will be carried out and which evidence sources will be used, so the approach can be checked during audits.


---

### IA-13 — Identity Providers and Authorization Servers (Control)

This requirement is about ensuring the organisation uses trusted services to verify who (or what) is trying to access its systems, and to determine what they are allowed to do. Without this, the organisation could mistakenly treat the wrong person, device, or automated service as legitimate, which could lead to unauthorised access to sensitive information or systems, or to legitimate access being granted incorrectly.

To meet this expectation, the organisation must use approved identity services and approved authorisation services to manage the identities of people, devices, and non-person entities. It must also use the correct supporting details and access rights needed to make both login decisions and access decisions. This must be done in line with the Department of Defence (DoD) Federal Identity, Credential, and Access Management policy and the organisation’s own authentication and authorisation policy.

The organisation must use the approved methods for these interactions, including Security Assertion Markup Language 2.0 (SAML 2.0), Open Authorisation 2.0 (OAuth 2.0), OpenID Connect, device certificates, and signed access tokens. The organisation must document how this is implemented in system design and security planning, keep the related configuration information, maintain the required policy and procedure records, and assign clear responsibilities to the right staff for running and managing these services.

##### Approved IdP/AS federation with signed tokens and claim mapping

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm authoritative IdP/AS endpoints and supported protocols (OIDC/OAuth2, signed JWT, SAML for legacy) and produce an integration decision record | Compliance Manager | Enterprise | 8h | — |
| Design canonical claim/entitlement model (user/device/NPE identifiers, roles/entitlements, assurance level, tenant/organisation) and define mapping rules per integration | Security Engineer | Enterprise | 24h | — |
| Implement OIDC/OAuth2 integration for interactive and API access, including configuration of issuer/audience, token lifetimes, scopes, and signed JWT access token handling | IAM engineer | Department | 40h | — |
| Implement application-layer JWT validation and authorisation enforcement (signature verification, expiry/nbf, issuer/audience, required claims, entitlement-to-permission checks) with negative/edge-case handling | Software Lead | Department | 48h | — |
| Enable SAML 2.0 federation for required legacy/partner applications and implement signed assertion validation (metadata trust, signature validation, claim extraction) | Security Engineer | Department | 24h | — |
| Implement X.509 device certificate authentication and certificate-to-identity mapping, including revocation/expiry handling aligned to authentication/authorisation policy | Platform Engineer | Department | 32h | — |
| Produce audit-ready design/configuration documentation and evidence pack (authoritative IdP/AS, protocol usage, claim mapping, device/NPE handling, validation requirements) and run a compliance review against ia-13_odp.01/ia-13_odp.02 | Project Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Connect the application to the approved identity provider (IdP) using OpenID Connect for sign-in (authentication) processes
- [ ] Set up the application to accept and check signed JSON Web Token (JWT) access tokens, including the token’s issuer, intended audience, digital signature, expiry time, and any required claims.
- [ ] Set up Security Assertion Markup Language version 2.0 (SAML 2.0) federation to support required legacy and partner integrations, and require that signed assertions are validated.
- [ ] Set up X.509 device certificate authentication and link each certificate to the correct user or device identity for managed devices
- [ ] Define and implement a standard way to map identity provider (IdP) and authorisation server (AS) outputs to application access decisions.
- [ ] Create and keep up to date system design and configuration documents that explain how the identity provider (IdP) and authentication server (AS) are used, which protocols are used, and how user attributes and entitlements are mapped.


---

#### IA-13.1 — Protection of Cryptographic Keys (Enhancement)

This requirement is about keeping the secret keys that protect digital access tokens safe. These keys are what make the tokens trustworthy and usable only by the right people. If the keys are created carelessly, stored poorly, or accessed by the wrong person, attackers could create fake tokens, pretend to be users, or view and alter access messages. This could lead to unauthorised access to important systems and data.

To meet this expectation, the organisation must:
- decide how strongly the keys need to be protected based on the potential harm if they are compromised
- ensure the keys are created for signing tokens and protecting them
- manage the keys properly from when they are created, through any changes, and until they are retired
- store the private signing keys so that only authorised staff can use them

The organisation must use approved methods and secure components to generate and handle keys, document how this is done in system design, configuration, and security planning, assign clear responsibilities, and keep records showing that key setup, changes, and destruction are carried out as required.

##### HSM-backed lifecycle management for token signing/encryption keys

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define token key protection levels by impact (signing vs token protection) and map to required safeguards (HSM requirement, access model, rotation/retirement, audit retention) | Compliance Manager | Enterprise | 24h | — |
| Produce system design/configuration/security planning artefacts for HSM-backed key custody and lifecycle (key purposes, generation locations, signing/encryption flows, overlap/transition handling, verification strategy) | System Design Authority | Enterprise | 32h | — |
| Select and configure HSM (or cloud HSM) integration pattern for the IdP/authorisation service, including non-exportable key generation and signing/encryption operations within HSM | Platform Engineer | Department | 56h | £18,000 |
| Implement separation of duties and controlled key usage: RBAC for HSM/IdP key management, approval workflow hooks for high-impact changes, and least-privilege service invocation for signing/encryption | Security Engineer | Department | 40h | — |
| Implement auditable key lifecycle automation and evidence capture (establish, activate, rotate/change, revoke/retire, destroy) with key IDs, timestamps, operator approvals, and revocation events exported for audit | DevOps Lead | Department | 48h | — |
| Harden key management planes: phishing-resistant MFA for privileged operators, administrative network allow-listing/bastion/VPN controls, and central SIEM logging for all administrative actions | Operations Lead | Enterprise | 40h | £6,000 |
| Execute end-to-end testing and assurance: verify keys are non-exportable, signing/encryption occurs in HSM, rotation/retirement overlap works for verification, and audit evidence meets IA-13(1) expectations | Quality Assurance Lead | Business Unit | 32h | — |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Define the impact level of each token key and match each level to the required safeguards, including whether a hardware security module (HSM) is used, the access rules that apply, and how often keys must be rotated or retired.
- [ ] Connect the identity provider and authorisation service to a hardware security module (HSM) (or a cloud-based HSM) so that the keys used to sign and encrypt tokens are created and kept inside the module.
- [ ] Set up role-based access control (RBAC) for hardware security module (HSM) and identity provider (IdP) key lifecycle tasks, and ensure separation of duties for privileged actions.
- [ ] Set up automated processes to regularly change encryption keys, manage the handover between old and new keys, and retire or revoke old keys using an overlap period so the change can be verified.
- [ ] Set up and centralise audit logs for important events and administrative actions, send them to the security information and event management (SIEM) system, and keep the supporting records for audit purposes.
- [ ] Strengthen protection of the administrative access to the hardware security module (HSM) and identity provider (IdP) management system by using multi-factor authentication that cannot be phished and by limiting connections to approved network routes (such as a bastion host, virtual private network (VPN), or allow-list).
- [ ] Update the system design, configuration, and security planning documents to explain how encryption keys are generated, stored, used, protected, and how evidence is kept for their lifecycle.


---

#### IA-13.2 — Verification of Identity Assertions and Access Tokens (Enhancement)

This requirement is about making sure that, before anyone is allowed into a system or to use an application, the organisation checks that the evidence of identity they provide comes from a trusted source and has not been changed or tampered with. Without these checks, an attacker could fake or alter the information that confirms who you are or what you are allowed to do, which could lead to unauthorised access or actions being carried out at the most harmful time.

To meet this expectation, the organisation must verify both the identity evidence and the access permission “ticket” for trust and integrity every time access is requested. This includes checking that their digital protection is intact and that the details included in the request (such as who or what is being accessed and when) are present and match what is being requested. Access must be refused if any of these checks fail. The organisation should also be able to demonstrate, using documented trusted sources and system records, that these checks are completed before access is granted.

##### PEP token & assertion verification with metadata claim checks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PEP token/assertion validation requirements and failure reason codes (JWT + SAML), including required/optional claims, clock-skew tolerance, and deny-by-default behaviour | Compliance Manager | Enterprise | 24h | — |
| Implement PEP middleware/gateway validation logic for JWT: signature verification (JWKS), `iss` allow-list, `aud`/resource binding checks, `exp`/`nbf`/`iat` enforcement, mandatory claim presence, and tamper detection | Software Lead | Department | 64h | — |
| Implement PEP validation logic for SAML: XML signature verification using configured signing certificates, assertion condition window checks, required attribute enforcement, and issuer/source allow-list | Software Lead | Department | 48h | — |
| Configure trusted issuers and validation keys per environment and protected resource type (JWKS endpoints/certificates, SAML signing certs), including secure configuration management and rotation readiness | IAM engineer | Enterprise | 32h | — |
| Implement claim/metadata consistency checks against the access request (audience/resource/tenant/environment mapping, request binding identifiers where applicable, and time-based constraints before authorisation) | Security Engineer | Department | 40h | — |
| Add structured audit events for allow/deny outcomes (reason codes without leaking sensitive token contents) and integrate with SIEM/observability pipeline | Security Engineer | Enterprise | 32h | — |
| Build automated CI/CD test suite with positive and negative cases (wrong issuer, tampered signature, expired token, wrong audience/resource, missing required claims) and ensure access is denied for all invalid cases | Quality Assurance Lead | Team | 40h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Choose and document which token or assertion types are used (for example, JSON Web Tokens (JWT) and Security Assertion Markup Language (SAML)), and record the trusted issuer allow-list and the signing keys or certificates for each environment.
- [ ] Set up a policy enforcement point (PEP) — such as an API gateway, middleware, or service mesh component — so that every protected endpoint checks the required tokens or assertions before allowing authorisation.
- [ ] Validate digital signatures using cryptography, and require specific information (claims) to be present and still valid in time—`issuer` (`iss`), `audience` (`aud`), and time limits (`exp`/`nbf`/`iat`)—allowing for a defined amount of clock difference (clock-skew tolerance).
- [ ] Add checks to ensure the information inside a token (its claims) matches the intended resource or transaction context (for example, the correct audience and resource identifiers).
- [ ] Apply a “deny by default” rule: block access if any issuer, signature, or metadata check fails, and do not continue to the authorisation step.
- [ ] Set up structured audit logs that record whether access was allowed or denied, including verification details and a coded reason when metadata checks fail, and send these logs to the security information and event management (SIEM) system.
- [ ] Set up continuous integration and continuous delivery (CI/CD) tests to check both valid and invalid tokens and assertions, including cases such as the wrong issuer, a changed (tampered) signature, an expired token, the wrong audience or resource, and missing required claims. Confirm that access is denied in all invalid cases.


---

#### IA-13.3 — Token Management (Enhancement)

This requirement is about ensuring that the access rights a system gives to people and services are created, used, updated, and cancelled in a controlled way. If these access-rights records are not managed properly, an access right that is stolen or misused could continue working longer than it should, or it could be used to access the wrong system. This could lead to unauthorised access to sensitive data and services.

To meet this expectation, the organisation must have clear, documented procedures covering the full life of these access-rights records. This includes how they are created, issued, renewed, and withdrawn. The organisation must also ensure each access right is only valid for a limited time and only for the specific application or service it was intended for.

The organisation must withdraw or invalidate access rights promptly when they are suspected to be compromised, lost, or no longer needed. It must also put the right systems in place and assign responsibility so these actions are carried out consistently.

##### Enforce token audience, short lifetimes, and revocation via IdP

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define enterprise token lifecycle policy: maximum `exp` lifetimes for access tokens and authentication assertions; refresh constraints (rotation, reuse detection where supported) | Compliance Manager | Enterprise | 16h | — |
| Configure IdP token issuance: enforce audience (`aud`) per relying party/application, issuer (`iss`) consistency, signing/encryption settings, and short-lived `exp` values across environments (dev/test/prod) | Identity & Access Management Lead | Enterprise | 24h | — |
| Implement resource server/application strict validation: reject tokens with mismatched `aud`/`iss`, enforce signature validation, and ensure `exp`/clock-skew handling is consistent and tested | Software Lead | Department | 32h | — |
| Add revocation/invalidations mechanism: configure IdP-supported session/token invalidation (e.g., back-channel logout/session revocation and/or refresh token rotation with reuse detection) and document expected behaviour | Security Engineer | Enterprise | 24h | — |
| Operationalise revocation triggers: integrate IdP revocation actions with identity lifecycle events (account disablement, suspected compromise, contractor offboarding) including runbooks and escalation paths | Operations Lead | Department | 16h | — |
| Enable audit logging and evidence readiness: ensure IdP audit logs capture issuance, refresh, and revocation/invalidations with correlation fields (user, client/app, resource, ticket/incident reference) and configure retention | Data Protection Officer | Enterprise | 16h | — |
| SIEM/monitoring integration and test evidence: create detection/alerting for token validation failures (aud/iss mismatch) and for revocation events; run end-to-end tests proving revoked tokens are denied | Cyber Security Lead | Enterprise | 24h | £3,000 |
| Change management and configuration-as-code: implement controlled changes for IdP and resource server validation logic with peer review, versioning, and rollback plan | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Configure the organisation’s identity provider to use short, policy-defined lifetimes for access tokens and security statements, and to limit how refreshes can be performed.
- [ ] Issue tokens separately for each application so the `aud` claim (intended audience) matches only the correct application and security domain.
- [ ] Apply strict checks for the resource server to confirm that `aud` and `iss` match exactly (reject any mismatch), alongside verifying the signature and that the token has not expired.
- [ ] Where supported, enable refresh token rotation with reuse detection, and set up session and token revocation so that tokens are cancelled when a compromise is suspected.
- [ ] Set up processes that link user account lifecycle events and incident handling, so the identity provider can immediately revoke or invalidate access when an account is disabled, when compromise is suspected, or when a user is leaving the organisation.
- [ ] Enable retention of identity provider (IdP) audit logs for token issuance, token refresh, and token revocation or invalidation, and check that the audit correlation fields are correctly matched.

