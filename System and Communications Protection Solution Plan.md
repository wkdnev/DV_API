### SC-1 — Policy and Procedures (Control)

This requirement is about making sure your organisation has clear, written rules for protecting its communications and systems, along with practical, step-by-step guidance for how people should follow them. Without this, different teams may work to different standards, important responsibilities can be missed, and the organisation may not meet legal and regulatory expectations—making it more exposed when something goes wrong, such as a serious incident, a failed audit, or a major system change.

To meet this expectation, the organisation must create, document, and share a system and communications protection policy that explains its purpose, what it covers, who is responsible for what, the support provided by management, how different parts of the organisation work together, and how compliance will be achieved. This must be aligned with all relevant laws, directives, regulations, and internal guidance.

The Chief Information Security Officer must oversee producing, maintaining, and distributing the policy and procedures. The policy must be reviewed and updated at least every year, and also after major incidents, audit findings, legal changes, major changes to system architecture, or new regulatory requirements. The procedures must be reviewed and updated at least annually, and after specified changes such as changes to roles, system settings, or changes to monitoring tools.

##### CISO-owned policy & procedures lifecycle with role-based dissemination

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-owned **system and communications protection policy** and supporting **procedures** (preferably at organisation level, with additions for specific missions/business processes and/or specific systems only where needed). Make sure they are **shared with the defined people/roles**, and keep them up to date through **annual review** and updates triggered by specific events.

###### WHY (control requirement)
SC-1 requires that the system and communications protection policy and procedures **cover the SC family controls that have been put in place**, are created using the **risk management strategy**, and are supported by **written procedures** that explain **how** the policy and controls are carried out (not just repeating the control statements). It also requires collaboration between the **security and privacy programmes**, naming an **official responsible** for managing the policy and procedures, and setting clear **review/update timing** and **events** that trigger updates.

###### HOW (specific steps/approach)
1. **Define scope and structure**: publish an organisation-level baseline policy (or multiple policies if the organisation is complex) and create system/mission add-ons only when required.
2. **Assign ownership and governance**: appoint the **Chief Information Security Officer (CISO)** as the official responsible for managing the policy and procedures; set up a joint working group with the **Security Programme Manager** and **Privacy Officer** to ensure security and privacy work together.
3. **Document who receives what**: keep an authoritative list of the people/roles who must receive the policy and procedures, including **Information System Security Officers (ISSOs) and system owners** (for policy sharing) and **security/privacy programme staff, ISSOs, system owners, and relevant IT operations personnel** (for procedure sharing).
4. **Use a controlled document process**: use a document control method (for example, a policy management platform or controlled repository) with version numbers, effective dates, approval records, and a change log that can be audited.
5. **Set review/update timing and triggers**:
   - **Policy**: review/update **annually** and after events including **a serious security incident or breach, audit/assessment findings, changes to relevant laws/directives, major system/operational technology (OT) architecture changes, or a new regulatory requirement**.
   - **Procedures**: review/update **annually** and after events including **a serious incident/breach, audit/assessment findings, changes to roles/responsibilities, changes to system configuration, changes to logging/monitoring tools, or changes to regulatory/contractual obligations**.
6. **Make procedures practical and implementation-focused**: for each SC family control used, write procedures that describe the **step-by-step actions** and **who performs them** (the role/object of the procedure), and state where the procedures are kept (for example, system security/privacy plans or separate documents).
7. **Share and keep proof of sharing**: publish the documents on an internal portal and notify the defined role groups using the organisation’s identity/role model; keep evidence that the correct roles received the latest versions (for example, access logs, acknowledgement records, or distribution attestations).

###### WHO (role responsible)
- **CISO**: owner of the policy/procedures and accountable official for managing and sharing them.
- **Security Programme Manager** and **Privacy Officer**: co-author/review to ensure security and privacy are aligned.
- **ISSOs and System Owners**: recipients and contributors for system-specific add-ons to the procedures.
- **IT Operations Lead**: recipient for the operational steps in the procedures.

###### Acceptance criteria
- A current **system and communications protection policy** exists, is approved by the **CISO**, and clearly links to the **SC family controls implemented**.
- Supporting **procedures** exist for implementation (not just restating the policy) and name the roles responsible for carrying them out.
- Sharing lists are defined, and the policy/procedures are distributed to the specified roles (including **ISSOs and system owners** for the policy; **security/privacy programme staff, ISSOs, system owners, and relevant IT operations personnel** for the procedures).
- There is document control evidence showing **annual review** and that updates happen after the defined **trigger events**.
- The security and privacy programmes show collaboration in creating and maintaining the policy and procedures (for example, documented review/approval records).

###### Actions Required for Compliance

- [ ] Appoint the Chief Information Security Officer (CISO) as the official responsible for managing the system and communications security policy and procedures.
- [ ] Publish an organisation-wide system and communications protection policy, and create system or mission add-ons only where required, mapped to the SC family controls that have been implemented.
- [ ] Draft implementation-focused procedures that explain how each policy or control is carried out, including the roles responsible for each procedure.
- [ ] Define and keep up to date the lists of who should receive each type of information:  

- **Dissemination role lists** for policy recipients, including **information system security officers (ISSOs)** and **system owners**  
- **Dissemination role lists** for procedure recipients, including **security and privacy programme staff**, **ISSOs**, **system owners**, and relevant **information technology (IT) operations personnel**
- [ ] Set governance for an annual review and update of the policy and procedures, and define when updates must be made. Trigger updates when there are incidents or breaches, audit or assessment findings, changes to legal or regulatory requirements, major changes to the system architecture, changes to configurations or tools, or changes to roles and responsibilities.
- [ ] Set up controlled document lifecycle management, including version numbers, approval steps, start (effective) dates, and a change log that can be audited.
- [ ] Share the current policy and procedures with the assigned roles, and keep records showing they were shared and reviewed.


---

### SC-2 — Separation of System and User Functionality (Control)

This requirement is about keeping everyday user features—such as the screens and functions people use—clearly separate from the behind-the-scenes tools used to run and manage systems. This matters because, if the same routes are used for both, a mistake or misuse by a user could potentially reach powerful management functions. That could result in unauthorised changes, disruption to services, or exposure of sensitive information.

To meet this expectation, the organisation must decide and document how it will separate user functions from system management functions. This separation can be done through physical separation or logical separation, for example using different machines, separate operating environments, separate processing resources, separate network locations, or virtualised setups.

Where web-based administration is used, it must be separated from user pages. Administrators must use different ways to prove their identity compared with ordinary users, and additional access checks must be applied. Administrative interfaces should also be isolated so they are accessed from different domains (or an equivalent mechanism).

The organisation must keep design documents, operating procedures, configuration records, a security plan that describes the separation, and audit records showing that the separation is implemented and maintained as intended.

##### Dual-plane user/admin architecture with isolated admin web access

- Category: Software
- Priority: Critical

###### WHAT
Create a clear separation between **user functionality** (including user interface services) and **system management functionality** (privileged administration of databases, network components, workstations, servers, and any web administrative interfaces).

###### WHY (control requirement)
Security Control SC-2 requires that user functionality is separated (physically or logically) from system management functionality. This ensures that normal user actions cannot directly access or change privileged administrative capabilities. This also includes making sure that **web administrative interfaces** are separated from user interfaces and that **administrators and users use different ways of proving who they are**.

###### HOW (specific steps/approach)
1. **Define a separation model (user plane vs admin plane)** in the system security design: clearly label which components/endpoints are for user functionality and which are for system management functionality.
2. **Separate the computing resources used for each area** by running admin-plane services on separate compute/operating system instances (or separate virtual environments) from user-plane services. Place them in **separate network segments** (for example, different virtual private clouds/subnets) and use deny-by-default routing/firewall rules so user-plane traffic cannot reach admin-plane endpoints.
3. **Isolate administrative web interfaces** by hosting them on **separate domains** (or an equivalent approach such as separate admin subdomains with different routing/web application firewall policies) from user-facing web interfaces.
4. **Use different sign-in methods for administrators versus users** for the admin web interfaces (for example, separate identity provider application registration/policy, phishing-resistant multi-factor authentication (MFA) for administrators, and stronger conditional access/step-up authentication for admin sessions).
5. **Add extra access controls for admin interfaces** beyond normal user authorisation (for example, IP allowlisting, virtual private network (VPN) or zero trust network access (ZTNA), re-checking sign-in for sensitive actions, and role-based authorisation limited to privileged roles).
6. **Keep audit-ready evidence**: retain architecture/design documents, configuration records that show the separation (network rules, domains/endpoints, identity provider policies), and operational procedures showing that the separation is maintained.

###### WHO
- **Solution Architect / Security Architect**: define the separation model and target architecture.
- **Cloud/Infrastructure Engineer**: set up separate compute/operating system instances and network segmentation.
- **Application Engineer**: ensure admin endpoints are hosted separately and do not share user-plane sign-in/session flows.
- **Identity and Access Management (IAM) Engineer**: configure separate administrator versus user sign-in policies and privileged access controls.
- **Security/Compliance Lead**: check that the evidence needed for SC-2 is complete.

###### Acceptance criteria
- User-facing endpoints (UI/API) are reachable only through the **user plane**; admin-plane endpoints are reachable only through the **admin plane**.
- Admin web interfaces are provided from **separate domains** (or an equivalent isolation method) from user interfaces.
- Admin web interfaces use **different sign-in methods/policies** from user access (documented and shown to be enforced).
- Network/security controls prevent user-plane traffic from directly reaching admin-plane management interfaces (deny-by-default with explicit allow rules).
- Evidence is available for: system design/separation, network segmentation/configuration, admin/user domain mapping, identity and access management (IAM) policy differences, and operational procedures/audit logs supporting ongoing maintenance.

###### Actions Required for Compliance

- [ ] Create a diagram showing how the user functions and the administration functions are separated, mapping all user and system management endpoints.
- [ ] Run administrative (“admin-plane”) services on separate computers or operating system instances (or in separate virtual environments) from the user-facing (“user-plane”) services.
- [ ] Set up network segmentation with a “deny by default” rule, so user network segments cannot access admin network management endpoints.
- [ ] Run the host’s administrative web pages on a separate domain (for example, `admin.example.com`) and use separate routing and web application firewall (WAF) rules from the domains used for normal users.
- [ ] Set up identity and access management (IAM) so that the admin web pages use different login rules from those used for normal users. The admin login rules should include phishing-resistant multi-factor authentication (MFA), step-up authentication, and conditional access.
- [ ] Apply additional controls for administrator access, such as IP allowlisting, virtual private network (VPN) access, or zero trust network access (ZTNA), and use role-based authorisation (RBAC). Then verify these controls are working as intended using test cases.
- [ ] Record and store evidence: architecture and design documents, exports of network and identity and access management (IAM) settings, and operational procedures for maintaining separation.


---

#### SC-2.1 — Interfaces for Non-privileged Users (Enhancement)

This requirement is about ensuring that normal users can neither see nor access the parts of a system used for administration. In everyday terms, it stops someone without permission from accidentally finding, guessing, or clicking their way into settings that control users, permissions, or the system itself.

Without this separation, a non-authorised person could change system settings, manage other users, or carry out maintenance actions. This could lead to disruption, fraud, or long-lasting damage.

To meet this expectation, the organisation must design and set up the system so that any administrator functions, or other privileged management options, are not shown in the menus, screens, or buttons available to non-privileged users. This includes anything that might appear “greyed out” or hidden.

The system must also hold back management options until a user is genuinely signed in with administrator-level privileges. It must block direct attempts to open administrative pages even if someone knows the page address.

##### Hide and gate admin UI and endpoints for non-privileged users

- Category: Software
- Priority: Critical

###### WHAT
Implement a role- and permission-aware way to build the user interface, and enforce authorisation checks on the server, so that system management features are neither shown nor accessible to users without the required privileges. This also avoids “greyed-out” or disabled admin options that still reveal that management capability exists.

###### WHY (control requirement)
NIST SP 800-53 **SC-2(1)** (enhancement) requires: **“Prevent the presentation of system management functionality at interfaces to non-privileged users.”** The guidance also stresses preventing discovery (including the “grey-out” pattern) and recommends hiding system administration options until users have an administrator-privileged session.

###### HOW (specific steps/approach)
1. **Define management privileges** (for example, Admin, Configuration, Maintenance) and link them to authorisation claims/roles issued by the enterprise identity provider.
2. **Conditional user interface display (no disabled/greyed-out leakage):**
   - Show management navigation items, tabs, buttons, and pages **only** when the signed-in session includes the required privileged claims.
   - Ensure management components are **not included in the page at all** for non-privileged users (not just disabled using CSS or HTML attributes).
3. **Step-up / privileged session gating:**
   - For sensitive management areas, require a privileged step-up (for example, re-authentication or an elevated session token) so the management interface appears only after a privileged session is established.
4. **Server-side enforcement on every management endpoint:**
   - Apply authorisation checks at the application programming interface (API) and service/controller level for every management route (and any underlying service actions), returning **403/Not authorised** for non-privileged requests.
   - Avoid error messages that would help a user determine whether a management resource exists.
5. **Client-side and routing hardening:**
   - Ensure the client cannot display management pages without the required privileged claims (for example, use route checks that block or redirect before anything is shown).
   - Treat client-side checks as extra protection only; the real control must be on the server.
6. **Audit-ready verification:**
   - Add automated user interface tests that sign in as a non-privileged user and confirm management labels, links, keyboard-focusable elements, and routes are absent.
   - Add API tests that try to call management endpoints directly and confirm **403** responses.

###### WHO
- **Application Security Engineer / Backend Engineer:** implement server-side authorisation checks and privileged step-up logic.
- **Frontend Engineer:** implement conditional user interface composition and route checks so management components are omitted for non-privileged users.
- **Identity and Access Management (IAM) Lead:** ensure privileged claims/roles are correctly issued by the enterprise identity provider.
- **QA/Test Engineer:** implement automated negative tests for non-privileged users and for direct access to endpoints.

###### Acceptance criteria
- When signed in as a non-privileged user, the application **does not present** any system management functionality in the user interface: there are no visible, disabled, greyed-out, or discoverable management controls.
- Management pages/components are **not rendered** (not present in the page content) and cannot be reached through client-side navigation.
- Direct requests to all management endpoints from a non-privileged user are denied with **403/Not authorised** (and do not reveal whether resources exist).
- After establishing a privileged/step-up session, management user interface elements appear as intended for authorised users.
- Automated tests exist and pass in continuous integration (CI) for both user interface absence and API denial for non-privileged accounts.

###### Actions Required for Compliance

- [ ] Define management privilege roles and access claims, and link them to the enterprise identity provider’s authorisation attributes.
- [ ] Implement conditional user interface composition so that management navigation and components are not included (not merely disabled) for non-privileged sessions.
- [ ] Add “privileged step-up” checks for sensitive management areas, so the admin user interface is shown only after an elevated (higher-authority) session has been established.
- [ ] Carry out authorisation checks on the server for every management application programming interface (API) endpoint and every management controller/service method, and return “403 Forbidden” for requests from users without sufficient privileges.
- [ ] Use route guards to protect client navigation, blocking or redirecting non-privileged users before any management pages are displayed
- [ ] Create automated tests to confirm that non-privileged users cannot see management interface elements, and that direct calls to management endpoints are blocked with a “403 Forbidden” response.


---

#### SC-2.2 — Disassociability (Enhancement)

This requirement is about keeping the software itself separate from the information it collects about how people use it. The real-world risk is that if a system is compromised, attackers could use stored details about user activity (such as session or activity information) to invade privacy, identify individuals, or reveal sensitive behaviour—especially if that information is stored together with the software files.

To meet this expectation, the organisation must set up its systems so that the application and software code is stored in one location, while the “state” information that records users’ interactions is stored in a different location. These must use separate storage areas and must not be mixed in the same place.

The organisation must:
- document this separation in its security and privacy plans
- keep clear procedures for how the separation is maintained during setup and updates
- record the relevant design and configuration details
- keep audit records showing that separation is maintained during day-to-day operation
- assign responsibility to the people who build and run the systems

##### Separate code artefacts from user-interaction state storage

- Category: Software
- Priority: Critical

###### WHAT
Keep application/software code artefacts separate from information that records users’ activity (for example, sessions, progress through workflows, and other activity or event status). Make sure the code and the user-interaction information are saved in different storage locations and are not stored together.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 control SC-2(2) enhancement requires: **“Store state information from applications and software separately.”** The guidance explains that if a system is compromised, keeping application/software separate from user-interaction information can better protect individuals’ privacy.

###### HOW (specific approach)
1. **Set clear separation rules**: For the application, clearly define what counts as “code/software” (for example, container images, compiled files, web files, configuration templates) versus “state/interaction information” (for example, session data, workflow status, user activity status, and interaction logs that show user behaviour).
2. **Store interaction information outside the code area**: Configure the application so that, during normal operation, it writes interaction state only to dedicated state services (for example, a session store, a workflow/state database, or an event/state store). Do not write this to the same filesystem paths, database tables, or object storage locations used for code artefacts.
3. **Use different storage locations**: Put code and state in separate places:
   - Code: an immutable artefact register (for example, a container registry) and/or read-only application deployment directories.
   - State: dedicated database instances/schemas, dedicated Redis/session clusters, and/or dedicated object storage buckets/paths for state.
4. **Stop mixing at the platform level**: Use technical safeguards to enforce separation:
   - Mount code directories as **read-only** while the application runs.
   - Use separate credentials/roles for accessing code versus reading/writing state.
   - Add continuous integration/continuous delivery (CI/CD) configuration checks (policy-as-code) to confirm that state endpoints/paths match approved state destinations.
5. **Keep evidence that can be audited**: Keep records of the design and configuration that show the separation (architecture diagrams, configuration baselines, CI/CD checks, and runtime configuration proof such as environment variables and connection details pointing to approved state stores).
6. **Assign responsibility**: Name accountable roles (application owner plus platform/infrastructure owner) who are responsible for maintaining the separation during releases, scaling, and incident response.

###### WHO
- **Application owner / Solution architect**: defines what is code versus state and approves the target design.
- **Platform/infrastructure engineer**: implements the storage separation (read-only mounts, dedicated state services, access controls).
- **DevOps/CI-CD engineer**: implements CI/CD checks and ensures deployments use code-only artefacts.
- **Security/privacy lead**: reviews the evidence and confirms that interaction state is not stored alongside code.

###### Acceptance criteria
- During operation, the application writes interaction state only to the approved dedicated state storage locations (confirmed through configuration review and controlled test writes).
- Code artefacts are deployed from immutable code-only sources and are not writable by the application during operation (confirmed through read-only filesystem/container settings).
- Separate access controls are in place for code storage versus state storage (confirmed through identity and access management (IAM) and database role review).
- CI/CD includes automated checks that prevent incorrect state destination settings (confirmed through pipeline evidence).
- Audit evidence exists showing the separation (architecture/configuration records and runtime configuration snapshots).

###### Actions Required for Compliance

- [ ] Define and document which data items are treated as application or software code, and which data items are treated as user-interaction state, for the target application.
- [ ] Configure the application so that it stores interaction information in dedicated state services (for example, session, workflow, and event state), rather than keeping that information in local code directories.
- [ ] Store application code and application state in different locations (use separate paths for code and deployment, and separate database/schema/bucket/volume locations for state).
- [ ] Prevent mixing of code artefacts by making the paths to code files read-only when the system is running, and by using separate credentials and permissions for reading and for writing state.
- [ ] Implement continuous integration and continuous delivery (CI/CD) checks that use policy rules to confirm that state endpoints or paths match the approved state destinations, and prevent deployments that break the required separation.
- [ ] Collect and store evidence that is ready for audit, showing that responsibilities are kept separate during day-to-day operations. This evidence should include: the architecture and configuration baseline, snapshots of the system’s live configuration, and the results of pipeline checks.


---

### SC-3 — Security Function Isolation (Control)

This expectation is about keeping the parts of a system that protect security separate from the everyday parts that do normal work, so they cannot be interfered with. Without this separation, an error or a malicious action in ordinary software could tamper with security features such as access controls, data protection, key management, or security event logging. This could allow unauthorised people to bypass protections or quietly change how the system behaves.

To meet this requirement, the organisation must clearly identify which security functions must be kept separate, document how that separation is achieved, and follow written procedures to maintain it during design, building, configuration, day-to-day operation, and any changes. The system must enforce the separation using a clear isolation boundary and restricted access, protect security components from being altered or replaced, and give only the minimum permissions needed.

The organisation must record the relevant configuration and keep audit records showing that separation is enforced, then review those records for any signs of failures or exceptions.

##### Isolate security functions using enforced host/VM boundary

- Category: Software
- Priority: Critical

###### WHAT
Set up a clear separation (an “isolation boundary”) so that security features—such as enforcing authentication/authorisation, managing encryption keys, running security logging and monitoring agents, and applying security policies—run apart from the non-security parts of the application. Use separate partitions or domains and control who or what can access them.

###### WHY (control requirement)
NIST SP 800-53 **SC-3 Security Function Isolation** requires that security features are **kept separate from non-security functions**. This must be done using an isolation boundary that controls access and protects the integrity of the hardware, software, and firmware used for security functions.

###### HOW (specific approach)
1. **Identify the security functions to separate** for this application, and link each one to the real runtime parts that perform security actions (such as services, agents, libraries, and configuration files).
2. **Create an isolation boundary at the hosting layer**:
   - Run security functions in a **separate execution environment** (for example, a dedicated virtual machine or instance, a hardened container or namespace with limited permissions, or a dedicated security-service layer) that is separate from the main application environment.
   - Use operating system or host features for **code separation** (where supported, use processor privilege separation) and ensure only the security environment can access security-critical resources.
3. **Control access across the boundary**:
   - Use least privilege for service identities (use separate service accounts or roles for security functions versus application functions).
   - Limit network and application programming interface (API) access so non-security components can only call security functions through **approved interfaces** (for example, endpoints using mutual Transport Layer Security (mTLS) authentication, only allowing specific ports, and requiring explicit authorisation checks).
4. **Protect the integrity of security components**:
   - Store security-function binaries and configuration in protected locations, with write access limited to approved build and release identities.
   - Reduce the risk of tampering during operation by disabling or limiting interactive access to the security environment and restricting debugging and administrative capabilities.
5. **Protect security code on disk and in memory**:
   - Use hardened operating system settings for the security environment (for example, restricted permissions on executable and configuration files; disable non-administrator debugging; restrict process injection and tracing where supported).
   - Ensure only the security environment can load and run the security-function code.
6. **Keep audit-ready evidence**:
   - Turn on and retain logs that show the isolation boundary is being enforced (for example, access denials across the boundary, service identity usage, integrity or attestation events where available, and administrative actions affecting security-function components).
   - Review these logs on a defined schedule to detect isolation failures or any exceptions that are not justified.

###### WHO
- **Application Owner / System Owner**: owns the list of security functions and the boundary design.
- **Platform/Infrastructure Engineering**: builds the isolation boundary (virtual machine or container setup, host hardening, identity separation, network allow-lists).
- **Security Engineering**: checks that the boundary protects integrity and that any exceptions (if needed) are justified and documented.
- **Operations / DevOps**: ensures deployment and change processes do not break the boundary.

###### Acceptance criteria
- Security functions identified in the inventory run only inside the defined isolation boundary (no direct execution in the non-security application environment).
- Non-security components cannot change security-function binaries or configuration (enforced through storage access control lists (ACLs) and restricted management routes).
- Any communication across the boundary happens only through approved interfaces, using least-privilege service identities and explicit authorisation.
- Audit logs exist and show: (a) boundary access attempts and denials, (b) administrative changes to security-function components, and (c) service identity usage when invoking security functions.
- A documented exception process exists for any required inclusion of non-security code within the boundary, and all exceptions can be traced back to the security-function inventory.

###### Actions Required for Compliance

- [ ] Create and get approval for a list of the application’s security functions, and link each one to the specific software and services that run during operation.
- [ ] Deploy security functions inside a dedicated isolation boundary—such as a separate virtual machine (VM) or instance, or a hardened container/namespace—separate from the non-security application tier.
- [ ] Set up service accounts with the minimum permissions needed (least privilege) and allow only approved network and application programming interface (API) connections for calls between different systems or boundaries.
- [ ] Strengthen the storage and operating environment for security code by limiting write access to the identities used for building and releasing, and by turning off any debugging or code-injection routes that are available to non-administrators.
- [ ] Put in place and check controls that separate operating system or host code (including privilege separation or restricted modes where they apply), so non-security code cannot access the operating environment used to run security functions.
- [ ] Enable audit logging for boundary enforcement and for administrative changes that affect security-function components, and set a regular review schedule.


---

#### SC-3.1 — Hardware Separation (Enhancement)

This requirement is about keeping the system’s “security parts” physically and logically separate from everything else, so normal day-to-day functions cannot access them or interfere with them. Without this separation, a weakness or misuse in non-security software could potentially read or change sensitive security information, such as protection settings, security logs, or secret keys. That would weaken the organisation’s ability to keep data and services safe.

To meet this requirement, the organisation must design, configure, and run the system so that security functions operate in an isolated environment enforced by the hardware. This includes keeping the storage used for security functions separate from the storage used for non-security functions, and making sure the required security settings are enabled.

The organisation must also document how the separation works, keep its security plan up to date with responsibilities and the approach to isolation, and keep audit records showing that any changes affecting isolation were authorised and that the separation remains in place, so it can be verified.

##### Hardware-enforced secure execution for security functions

- Category: Software
- Priority: Critical

###### WHAT
Put security functions inside a hardware-enforced “locked” environment (for example, a processor secure execution environment, a secure world, or a trusted execution environment) so that non-security software cannot read or change the security function code or any security-related data.

###### WHY (control requirement)
SC-3(1) enhancement requires the organisation to **use hardware separation mechanisms to keep security functions isolated**. This includes hardware-enforced address separation and/or hardware ring designs that allow **separate storage areas with different access rules** (for example, areas that are readable/writable only by authorised security components).

###### HOW (specific steps/approach)
1. **Choose and document the hardware isolation method** provided by the hosting platform (for example, trusted execution environment/secure world, hardware ring separation, or hardware-protected address spaces). Define the **security functions** that must be isolated (for example, key handling, signing/verification, security policy decision-making, and protection of security settings/secrets).
2. **Build the security services inside the isolated environment** so the non-secure operating system/application layer can only use a small, clearly defined interface (for example, sign/verify/decrypt/encrypt). Ensure it cannot directly access isolated memory or security storage.
3. **Separate security-related data stores** using the platform’s hardware-enforced separation (for example, protected memory areas or secure storage). Ensure security data is configured with the correct access rules so non-security contexts cannot read or write it.
4. **Set up and enforce isolation during operation** by turning on the required platform security settings (for example, secure boot and secure execution enablement). Prevent any fallback to non-isolated execution paths for the security functions.
5. **Produce audit-ready evidence**: record the configuration and enforcement state (for example, attestation or secure-environment health checks) and log every isolation-related configuration change through the organisation’s change management process.
6. **Keep documentation and responsibilities up to date**: update system security documentation to explain the isolation boundaries, how each security function maps to the isolated environment, and who is responsible for configuration, verification, and approving changes.

###### WHO
- **Solution/Platform Architect**: selects the hardware isolation method and defines the isolation boundaries.
- **Security Engineer**: implements the isolated security services and checks that storage separation works.
- **Infrastructure/Cloud Engineer**: enables and maintains the platform configuration (secure boot/secure execution) and prevents fallback to non-isolated execution.
- **Change Manager / Security Governance**: ensures isolation-related configuration changes are authorised and properly evidenced.
- **Security Operations (SOC)**: collects and retains attestation/enforcement evidence and monitors for isolation failures.

###### Acceptance criteria
- Security functions run only inside the selected hardware-enforced isolated environment; non-secure components cannot directly access isolated code or data.
- Security-related data stores are hardware-separated with enforced access rules (non-security contexts cannot read or write them).
- Isolation-enabling platform configuration is turned on and verified during operation (for example, through attestation or secure-environment health checks), with results recorded.
- Isolation-related configuration changes can be traced to authorised change records and kept as audit evidence.
- System documentation (including the parts of the system security plan relevant to isolation) describes the isolation method, boundaries, and responsibilities.

###### Actions Required for Compliance

- [ ] Identify the hardware isolation method supported by the platform, and specify which security functions must be isolated.
- [ ] Set up the security services so they run only within the isolated environment, and expose only a minimal interface to the non-secure operating system.
- [ ] Set up hardware-based protected memory and storage for security information, and confirm that non-secure parts of the system cannot read or write it.
- [ ] Set up and confirm the runtime protection settings (for example, secure boot/secure execution) and turn off any non-isolated fallback routes.
- [ ] Set up checks that confirm the device is in a trusted, secure state and send the results to central logging systems so they can be used as audit evidence.
- [ ] Update the system security documentation to explain the separation boundaries, who is responsible for what, and where audit evidence comes from.
- [ ] Ensure that any configuration changes related to isolation are approved through the authorised change management process and are kept for audit traceability.


---

#### SC-3.2 — Access and Flow Control Functions (Enhancement)

This expectation is about keeping the parts of your system that decide **who is allowed to do what** and the parts that control **how information is allowed to move** clearly separated from normal business features and from other protective tools. If they are not separated, a mistake or weakness in a non-essential feature could accidentally affect, bypass, or confuse the controls that protect access and information movement—leaving your organisation exposed even if you have individual security tools in place.

To meet this, you must:
- First, identify and document the key functions that make access decisions and the key functions that control information movement.
- Then, in your system design, explain how each of these functions is isolated from non-security functions and from other security functions.
- Implement this isolation in practice (not just in documentation), keep it consistent in your system configuration, and make sure the isolated functions can still be checked, scanned, and monitored.
- Record enough log information to show that the isolated functions are working as intended.
- Keep your procedures and plans up to date so the live system matches the documented approach.

##### Isolate access & flow enforcement via dedicated PDP/guard gateways

- Category: Software
- Priority: Critical

###### WHAT
Set up access-control enforcement and information-flow control enforcement as separate, technically isolated parts of the system (for example, a **policy decision point (PDP)** service and a **data-flow gateway/egress proxy**). These must be kept apart from normal business functions and from other security functions.

###### WHY (control requirement)
**Security control SC-3(2)** requires that the security functions that enforce **access** and **information flow control** are **isolated** from **nonsecurity functions** and from **other security functions**. This isolation must be achieved through the way the system is built (not just written down), while still allowing the isolated parts to be **scanned and monitored**.

###### HOW (specific steps/approach)
1. **Identify and record enforcement functions**: Keep an up-to-date inventory that maps:
   - (a) the component(s) that make authorisation decisions (access-control enforcement), and
   - (b) the component(s) that enforce which information movement paths are allowed (information-flow enforcement).
2. **Create runtime isolation boundaries**:
   - Run the **PDP/access-enforcement** component in its own runtime environment (separate process/container/virtual machine) with its own dedicated service identity.
   - Run the **information-flow enforcement** component as the only permitted route for moving sensitive data (for example, an API gateway/egress proxy/secure broker), also in its own runtime environment.
   - Make sure business applications cannot bypass these components (for example, send all sensitive API calls and all outgoing traffic through the gateway; block direct access to destinations at the network/service level).
3. **Avoid linking to other security functions**:
   - Do not build access/flow enforcement into auditing, intrusion detection systems (IDS), anti-malware, or malicious-code protection agents.
   - Ensure enforcement components do not rely on IDS/anti-virus (anti-malware) or audit agents to make decisions. Enforcement must still work in a predictable way even if those other agents are degraded.
4. **Strengthen interfaces and inputs**:
   - Use limited, authenticated interfaces between business applications and the PDP (for example, **mutual Transport Layer Security (mTLS)** and workload identity), and between applications/gateways and downstream services.
   - Use “**deny by default**” behaviour and check the request details used for enforcement (for example, identity information, resource identifiers, and data classification tags).
5. **Support scanning, monitoring, and clear ownership**:
   - Set up monitoring so activity can be traced back to the enforcement components (separate logs/metrics per component).
   - Ensure vulnerability scanning and configuration checks can target the enforcement components directly (separate deployment units, clear ownership, and standard endpoints for scanners).
6. **Keep documentation and configuration aligned**:
   - Update system design documentation and the system security plan to reflect the isolation approach and the enforced routing/decision paths.
   - Keep configuration baselines (deployment manifests, network rules, gateway routing rules) so the live system matches what is documented.

###### WHO (role responsible)
- **Solution/Platform Architect**: defines the enforcement boundaries, routing model, and interface agreements.
- **Security Engineering Lead**: checks that isolation meets the intent of SC-3(2) (no enforcement coupling with IDS/anti-virus/audit).
- **Application/Platform Engineers**: implement deployment, network/service controls, and logging/monitoring.
- **Security Operations Centre (SOC)/security information and event management (SIEM) Engineer**: ensures audit/monitoring attribution and alerting for enforcement activity.

###### Acceptance criteria
- Access-control enforcement decisions are made only by the designated PDP/access-enforcement component(s), which run in a separate runtime environment from business functions.
- Information-flow enforcement is performed only by the designated gateway/egress enforcement component(s), and sensitive data movement cannot bypass it (enforced through network/service routing controls).
- Enforcement components are not dependent on, and do not run in the same runtime environment as, potentially isolated security functions such as auditing, IDS, or malicious code protection.
- Enforcement components can be found and targeted by vulnerability scanning and are continuously monitored.
- Audit and telemetry show enforcement activity attributable to the enforcement components (for example, decision logs, information flow allow/deny events, and gateway routing decisions).
- System design documentation and the system security plan accurately describe the implemented isolation and match current configuration baselines.

###### Actions Required for Compliance

- [ ] Create and keep up to date an inventory of the components that enforce access control and control how information moves between systems.
- [ ] Deploy the access decision service (policy decision point (PDP)) inside its own protected runtime environment, using its own dedicated service identity.
- [ ] Set up the information-flow enforcement gateway (also known as an egress proxy) in its own protected runtime environment, and route all sensitive data traffic through it.
- [ ] Prevent users from bypassing the routing controls by blocking direct access to sensitive destinations, except through the enforcement gateway.
- [ ] Remove any dependency between enforcement components and auditing, intrusion detection system (IDS), or anti-malware agents, and ensure they do not run at the same time as those agents.
- [ ] Set up enforcement-specific logging and performance reporting so that decisions and allow/deny events can be traced back to the relevant enforcement components.
- [ ] Update the system design documentation and the system security plan to reflect the separation boundaries, and check that the live configuration matches the documented baseline settings.


---

#### SC-3.3 — Minimize Nonsecurity Functionality (Enhancement)

This requirement is about keeping the parts of your systems that make security decisions as small and simple as possible, so there are fewer opportunities for errors. If non-essential functions are placed in the same protected area as the security features, mistakes or harmful software could interfere with those security decisions and allow unauthorised people to access information or systems.

To meet this expectation, the organisation must:
- clearly define the boundary around the security functions,
- identify and document any non-security functions inside that boundary, and
- design and configure the system so the number of non-security functions within the boundary is as small as possible.

Where full separation is not practical, the organisation must:
- record why separation is not practical, and
- reduce any non-security functions that could affect security to the minimum needed.

The organisation must also:
- keep the security-enforcing parts mainly limited to essential access decisions,
- configure systems to match the documented design, and
- keep the relevant design, configuration, audit, and security planning records, with named staff responsible for maintaining this approach.

##### Minimise nonsecurity code in security boundary via hardened security services

- Category: Software
- Priority: Critical

###### WHAT
Set a clear isolation boundary around the application’s security functions (mainly access control) and redesign or configure the system so the boundary includes the smallest practical amount of non-security functionality. If full separation is not possible, record why and reduce any non-security functions inside the boundary to the minimum needed.

###### WHY (control requirement)
SC-3(3) requires keeping the number of non-security functions inside the isolation boundary around security functions as small as possible. The guidance explains that non-security functions inside the boundary become security-relevant because mistakes or malicious code could directly affect the security functions. So, the trusted part that enforces security rules must be as small and simple as possible.

###### HOW (specific approach)
1. **Identify security functions and link them to the actual runtime parts**: Create a list mapping each security function to the specific component that runs it (for example, an authorisation decision service, a token validation module, or policy enforcement middleware), rather than treating entire servers as “security”.
2. **Define the isolation boundary for each security function**: For each security component, specify what is inside and outside the boundary (scope of process/container/module, required libraries, configuration inputs, where secrets can be accessed, and which network destinations are allowed).
3. **Minimise non-security functionality inside the boundary**: Remove or disable optional features and non-essential modules that do not directly support access control or closely related policy checks. Limit dynamic code loading and plugins, reduce runtime dependencies, and make sure the security component does only what is required.
4. **Control interfaces when separation is not perfect**: If the security component must call other services, use strict allow-lists for outgoing calls, set time limits, and control how data is handled, so any non-security behaviour is limited to what is needed for policy decisions.
5. **Ensure configuration matches the design**: Use “configuration as code” (for example, hardened container images, module allow-lists, and locked-down feature flags) and ensure deployments cannot enable additional modules without change control.
6. **Keep evidence that can be audited**: Maintain versioned boundary definitions, module inventories, and configuration snapshots showing which components are enabled or disabled and the runtime versions used in each environment (production, test, and disaster recovery).

###### WHO
- **Application Security Architect / Security Engineering Lead**: responsible for mapping security functions, defining boundaries, and making minimisation decisions.
- **Application Owner / Engineering Manager**: ensures the changes are implemented in the application code and configuration, and approves changes.
- **Platform/Cloud Engineers (or OT/Infrastructure team where applicable)**: implement hardened images, restrict containers/modules, and set deployment safeguards.
- **Change Management / Configuration Management owner**: ensures boundary changes follow controlled release processes and that evidence is retained.

###### Acceptance criteria
- For each identified security function, there is a documented isolation boundary showing which components are included/excluded and which dependencies are permitted.
- A measurable inventory exists showing the non-security functions/modules present within each boundary, and each boundary contains only what is required for access control and policy checks.
- Non-essential modules/features/plugins are disabled or removed from the security component runtime; dynamic code loading is prevented or tightly controlled.
- If any non-security-relevant functionality remains inside the boundary, there is an approved documented justification and documented minimisation steps (for example, allow-listed outgoing calls and reduced dependencies).
- Deployment evidence (versioned boundary definition plus a configuration snapshot) is produced for each release/environment and shows alignment with the boundary design.

###### Actions Required for Compliance

- [ ] Create an inventory that maps each security function to the application components that enforce access rules and make policy decisions.
- [ ] For each security component, define and document its isolation boundary, including what is in scope and out of scope, which software libraries it must use, what secrets it is allowed to access, and which network destinations it is permitted to connect to.
- [ ] Remove or turn off any non-essential modules, features, or plug-ins in the security system while it is running, and where possible stop the system from loading new code dynamically.
- [ ] Set up an approved (allow-listed) list of outbound connections and enforce strict rules on the interfaces for any required calls made from within the security boundary.
- [ ] Encode boundary configuration as hardened images, module allow-lists, and feature-flag locks, and enforce this through deployment controls (deployment guardrails).
- [ ] For each software release and each environment, produce and keep versioned proof (boundary definition, list of enabled modules, software versions in use, and copies of the configuration settings).


---

#### SC-3.4 — Module Coupling and Cohesiveness (Enhancement)

This requirement is about designing security features like well-made building blocks. Each block should be organised internally and should not rely heavily on other blocks. If security features are mixed together, a change in one area can accidentally break or weaken another. This makes the system harder to understand and maintain, and it increases the risk that mistakes (or misuse) can spread.

To meet this expectation, the organisation must design and implement security functions as separate, mostly independent modules rather than one combined component. Each module’s responsibilities should be closely related, and the links between modules should be kept as small as possible. The organisation should reduce and simplify how modules interact, use a layered approach where appropriate, and document how modules are kept separate, including module boundaries, responsibilities, interfaces, and dependencies.

The organisation must also set up and record configuration that supports this independence, keep audit records of changes that could affect how modules connect, include this approach in the system security plan, assign responsibility to system and network administrators or information security staff, and follow defined processes to keep the system cohesive and loosely connected. This should be supported by mechanisms such as clear interfaces and controlled communication.

##### Security modules with strict interfaces and dependency controls

- Category: Software
- Priority: High

###### WHAT
Design and build security features as mostly separate, clearly defined components. Each component should do one main job well, and components should rely on each other as little as possible. Components must have clear responsibilities and should only communicate through agreed ways of working (defined interfaces), with controlled information sharing.

###### WHY (control requirement)
SC-3(4) enhancement requires security features to be implemented as mostly independent components that are easy to understand and keep changes contained. Limiting how much components interact helps manage complexity and reduces the “blast radius” when something changes.

###### HOW (specific steps/approach)
1. **Break the application into security components** (for example: authentication integration, authorisation decision and enforcement, session or token handling, audit logging and telemetry, secrets management, input validation and security policy enforcement). For each component, define:
   - one clear responsibility (high cohesiveness)
   - the security functions it owns
   - its explicit dependencies (what it may call or use)
   - its explicit outputs (what it may produce)
2. **Set rules (service contracts) for how components communicate**:
   - For IT components: use internal application programming interfaces (APIs) and/or event or message contracts with strict formats (request/response/event types, how errors are handled, and which fields are allowed).
   - For shared libraries: expose only a small, public interface, and keep the internal workings private.
   - For data: clearly state which component is the “source of truth” for specific security information (for example, identity claims and authorisation decisions) to prevent hidden dependencies.
3. **Put technical controls around component boundaries**:
   - Use an internal API gateway, service mesh policy, or middleware layer so only approved callers can access each component’s endpoints.
   - Validate message formats at component boundaries (reject unexpected fields or types).
   - Add build pipeline controls (for example, dependency allow-lists and architecture checks) to stop unauthorised cross-component imports or calls.
4. **Use clear separation within security**:
   - Where appropriate, separate “decision” from “enforcement” (for example, an authorisation decision component versus enforcement middleware).
   - Separate “security policy evaluation” from “telemetry and audit output” so that logging does not mix in authorisation logic.
5. **Record and maintain the coupling and cohesiveness model**:
   - Keep a component boundary document (responsibilities, interfaces, dependency map, and data ownership).
   - Record interface or contract versions and the reason for changes.
6. **Keep audit-ready proof of changes that affect coupling**:
   - In continuous integration and continuous delivery (CI/CD), capture deployment differences and contract version changes.
   - Ensure audit logs include the component identifier(s) and the contract or policy version identifiers for releases that could affect how components interact.

###### WHO (role responsible)
- **Solution Architect / Application Architect**: defines the component breakdown, responsibilities, and layered design.
- **Software Engineering Lead**: implements the interface contracts and enforces component boundaries.
- **Security Engineering / Identity and Access Management (IAM) & Application Security (AppSec)**: checks that component responsibilities match the security functions and that coupling is kept to a minimum.
- **DevOps / Release Manager**: ensures CI/CD architecture checks and evidence capture are included in release processes.

###### Acceptance criteria
- A documented component breakdown exists, with a dependency map showing **low coupling** (only approved dependencies) and **high cohesiveness** (each component has a single security responsibility).
- All component-to-component calls use **defined contracts** (schemas and error handling rules) and are validated during runtime.
- Build and CI include automated checks that fail if a component introduces unauthorised dependencies or calls outside its contract.
- Release evidence shows contract or interface version changes and deployment differences for any changes that affect coupling.
- Security functions can be changed within a component without requiring changes to other components, other than contract version updates (confirmed by tests and architecture checks).

###### Actions Required for Compliance

- [ ] Define a security module catalogue where each module has a single clear responsibility, is owned by a named security function, and includes an explicit map of how modules depend on each other.
- [ ] Create and publish service agreements for every interaction between modules, including the API or event formats, how errors are handled, and which fields are allowed.
- [ ] Put technical controls in place to enforce module boundaries, using rules at the application entry points (API gateway and service mesh rules) and checking that data matches the required format (schema validation) at each interface.
- [ ] Add continuous integration and continuous delivery (CI/CD) architecture tests and dependency allow-lists to prevent unauthorised imports and calls between modules.
- [ ] Separate the decision-making part of security from the part that enforces it, and separate the collection and recording of audit information from the part that evaluates security policy.
- [ ] Keep version-controlled documentation showing the boundaries between modules, how they connect (interfaces), and who owns each type of data, and link this documentation to the release files.
- [ ] Capture and keep audit evidence for releases that change module interfaces/contracts or dependency relationships.


---

#### SC-3.5 — Layered Structures (Enhancement)

This requirement is about building security in layers, so one security measure does not quietly rely on another measure working correctly. In everyday terms, it helps prevent a situation where, if one security feature fails or is temporarily unavailable, other protections also fail—leaving weaknesses that attackers could exploit.

To meet this expectation, the organisation must design and implement its security functions as separate layers with as little connection between them as possible. It must also ensure that lower layers do not depend on higher layers for their main protection, or on higher layers to confirm whether higher layers are working correctly.

The organisation must:
- document how the layers are arranged and how dependencies are avoided
- create and follow procedures to maintain this separation
- include the approach in its security plan
- set and record system settings that support the layered design
- keep audit records showing the layered protections are in place and are being maintained

##### Non-dependent layered security with one-way interfaces

- Category: Software
- Priority: Critical

###### WHAT
Set up the application’s security controls in separate layers, with clear boundaries and tightly controlled connections between layers. Make sure lower layers do not rely on higher layers for their main security decisions, or for the correctness and availability of higher-layer security functions.

###### WHY (control requirement)
Control SC-3(5) requires security controls to be built as a layered structure that reduces interactions between layers and prevents lower layers from depending on higher layers’ functionality or correctness. This lowers the risk that a failure or misconfiguration in one security component causes other protections to fail.

###### HOW (specific steps/approach)
1. **Define security layers and responsibilities** in the system security design (for example: *Network enforcement → Access control/session gate → Application authorisation → Data protection → Monitoring/response*). For each layer, specify: (a) what it must enforce, (b) what it may only observe or add information to, and (c) what it must never require from higher layers.
2. **Build in “no runtime dependency” from lower to higher layers** by design: lower layers must make allow/deny decisions using only local, predictable information (for example: fixed rules, local policy, network/protocol details, and any locally available or cached credentials where relevant). Higher layers may add extra information (for example: risk scoring or analytics), but they must not be needed for lower-layer enforcement decisions.
3. **Use one-way interfaces between layers**: lower layers should send security-relevant information upward (for example: logs and audit events), and higher layers should use it. Prohibit patterns where lower layers call higher-layer services for decisions (for example: a firewall or edge policy system asking an application service for authorisation).
4. **Add dependency checks and failure tests** during design and build: run automated checks (for example: service dependency maps and scanning for “decision-path” calls) and carry out controlled failure tests (for example: temporarily turn off higher-layer authorisation or analytics services) to confirm that lower-layer enforcement results do not change.
5. **Record and keep evidence**: update the security plan and architecture documentation with the layer model, interface agreements, and the results of dependency checks and failure tests. Ensure configuration baselines reflect the layered design (for example: “deny by default” at the lowest enforcement points).

###### WHO
- **Solution Architect / Security Architect**: defines layer boundaries, interface agreements, and the “no dependency” rules.
- **Application/Platform Engineers**: implement enforcement and remove any decision-path dependencies.
- **DevSecOps / Security Engineering**: implement automated dependency checks and run failure tests.
- **System Owner / Change Manager**: ensures changes keep the layered boundaries through change reviews.

###### Acceptance criteria
- The security architecture documentation includes clear layer boundaries, responsibilities, and an explicit rule that lower layers do not depend on higher layers for enforcement decisions.
- Evidence exists (for example: dependency scan reports and architecture diagrams) showing there are no runtime calls from lower-layer enforcement components to higher-layer security decision or correctness services.
- Controlled failure testing shows that when higher-layer security services (for example: monitoring enrichment, risk scoring, or higher-tier authorisation support) are unavailable or degraded, lower-layer enforcement still blocks/allows traffic based on its own deterministic policy.
- Audit-ready evidence is retained showing layered enforcement is implemented and maintained through configuration baselines and change control.

###### Actions Required for Compliance

- [ ] Create a security-layer architecture diagram that shows where each layer starts and ends, what each layer is responsible for, and the explicit rules that prevent one layer from relying on another.
- [ ] Set up the lowest level of control using fixed, local policy settings, and use “deny by default” where it applies.
- [ ] Remove or redesign any “decision-making” calls made during operation by lower-level enforcement components to higher-level security services.
- [ ] Define one-way interfaces so lower layers only send events upward, and higher layers only receive and use those events.
- [ ] Run automated checks of dependencies in services, configuration, and code to confirm there are no cases where a lower level is enforced before a higher level.
- [ ] Run controlled tests that intentionally disable higher-level security services, and confirm that the lower-level allow/deny decisions produce the same results as before.
- [ ] Update the security plan and keep the proof needed for audits, including the system design, dependency check results, failure test results, and configuration baseline records.


---

### SC-4 — Information in Shared System Resources (Control)

This requirement is about making sure that when shared parts of your systems are passed from one person or task to another, nothing from the previous user’s work is left behind for the next user to see. Without this, someone could accidentally or deliberately view leftover documents, messages, or other information that should have been cleared, including information stored in protected or encrypted form. This could lead to data leaks, privacy breaches, and loss of trust.

To meet this expectation, the organisation must set clear, written rules for how shared storage, shared work areas, and shared computing spaces are cleaned or reset when they are released for reuse. The organisation must also have documented procedures that staff follow every time.

The organisation must ensure the system’s design and settings actually enforce these protections for both people and automated tasks acting on their behalf. It must also keep audit records showing that the clean-up or reset was completed successfully.

##### Enforce shared-resource reuse cleanup with key destruction and audit logs

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated “release-to-reuse” process for all shared system resources (for example: shared workspaces, temporary upload areas, scratch storage, shared caches, job working folders, and any shared multi-tenant storage). When one user, role, or process releases a resource, nothing unauthorised or unintended—including encrypted versions of data—should remain accessible to the next user, role, or process.

###### WHY (control requirement)
Security Control SC-4 requires preventing unauthorised and unintended information transfer through shared system resources, including leftover information that may still be present in encrypted form, when resources are released and then reused. This reflects the practical expectation for “object reuse / residual information protection”.

###### HOW (specific steps/approach)
1. **List shared resources and define the “release event” for each type** (for example: closing a workspace, finishing or failing a job, ending a session, removing an item from a queue, temporary directory time-to-live expiry, stopping a container or virtual machine, cache removal).
2. **Carry out predictable cleanup when the resource is released**, using one of:
   - **Destroying encryption keys (preferred):** set encryption keys per tenant, job, session, or workspace so that cleanup is achieved by revoking or destroying the relevant keys before the resource is reassigned.
   - **Secure deletion/overwriting** when key destruction is not possible (ensure it is applied to the real storage area that backs the shared resource).
3. **Ensure cleanup also happens for background processes acting on behalf of users/roles** by linking cleanup to the workflow or job engine and the orchestration layer—not just interactive logout or session ending.
4. **Do not allow reuse until cleanup is complete** by blocking reassignment or visibility until cleanup succeeds (for example: mark the resource as “released-pending-cleanup”, then only mark it “available” after cleanup confirmation).
5. **Create audit evidence for every release/cleanup cycle:** resource identifier, tenant/job/workspace identifier, cleanup method used, start and end times, result (success or failure), and key-destruction events (or secure-delete completion markers). Send this to the enterprise security information and event management (SIEM) and logging platform.
6. **Test effectiveness using residual checks:** run “User A then User B” tests for both plain text and encrypted data, including cases where jobs fail or are cancelled and where resources are reused quickly.

###### WHO (role responsible)
- **Application owner / engineering lead:** implement release hooks, encryption scoping, and cleanup gating in the application and workflow layer.
- **Infrastructure/cloud engineer:** configure storage lifecycle, integrate key management, and enable secure deletion capabilities for the underlying platforms.
- **Security/compliance engineer:** set evidence requirements, review test results, and confirm audit logs are complete.

###### Acceptance criteria
- For every defined shared resource type, there is a documented and implemented **release event** and **cleanup action** that runs even if the user who initiated the release remains logged in.
- For encrypted data, the system uses **scoped keys** so that after release, the next user cannot decrypt the previous contents (with key destruction or revocation evidenced).
- The shared resource is reassigned or made visible to the next user/role **only after cleanup success is recorded**.
- Audit logs show, for each release cycle, the **cleanup outcome** and the evidence for **key destruction or secure deletion**.
- Residual checks confirm that User B cannot access User A’s previous data (including encrypted versions) under normal operation, failure scenarios, and rapid-reuse scenarios.

> Note: This solution addresses SC-4’s shared-resource reuse/residual information protection. It does not attempt to mitigate covert channels or general data leftovers beyond the shared-resource reuse scope.

###### Actions Required for Compliance

- [ ] List all shared computing resources the application uses (workspaces, temporary areas, scratch volumes, shared caches, and job work directories) and define what “release” means for each one.
- [ ] Set up encryption keys so that each tenant, job, and session uses its own keys when writing data to shared resources. This lets us enforce release by destroying or revoking the relevant keys.
- [ ] Add workflow and orchestration “hooks” so cleanup runs for both interactive users and background processes acting on their behalf, including when those processes fail or are cancelled.
- [ ] Reuse is allowed only after cleanup finishes successfully: mark the resources as unavailable during cleanup, and only re-enable access once confirmation is received.
- [ ] Record cleanup and key-destruction events in the central logging system and security information and event management (SIEM), including the resource identifier, the time the event happened, and the result.
- [ ] Run checks to confirm access still works correctly after residual data remains, using User A and then User B. Do this for both plain (unencrypted) and encrypted versions, including tests where the same data is reused quickly and where the job fails. Record the results.


---

#### SC-4.2 — Multilevel or Periods Processing (Enhancement)

This expectation is about preventing sensitive information from being “carried over” when systems move between different levels of confidentiality. In practice, the risk is that if a shared computer, storage area, printer service, or other shared component is reused without proper cleaning and checks, information from one confidentiality level could be accessed or transferred at another level. It can also mean the organisation cannot prove what happened.

To meet this expectation, the organisation must follow multi-level processing procedures approved by the Department of Defense (DoD) whenever processing explicitly changes between different confidentiality levels or security categories, including when shared hardware is reused. After any such change, before reusing a shared resource, the organisation must first properly clear it, and then check it to confirm the information has been correctly reclassified for the new level.

Access to shared resources must be limited based on the information’s labels. Every change must be recorded in audit logs with enough detail to show the change occurred, the access decision made, and that the required clearing and reclassification steps were completed.

##### Label-aware shared-resource gate for multilevel processing switches

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated “processing-mode gate” that controls when shared resources (for example: shared storage/buckets, file shares, print services, virtual machine/container images, shared workspaces, shared databases/caches) can be reused whenever the application explicitly changes between information classification levels or security categories.

###### WHY (control requirement)
This requirement (SC-4(2) enhancement) means we must stop unauthorised information being transferred through shared resources **in line with the organisation’s defined procedures** (parameter **sc-04.02_odp**) when the system **explicitly switches** between different information classification levels or security categories. This also covers reusing hardware/components in sequence. The solution must ensure sanitisation and reclassification checks happen **before** any shared-resource reuse, enforce access based on labels, and record an audit trail for every switch.

###### HOW (specific steps/approach)
1. **Define processing modes and switch triggers** in the application or infrastructure orchestration layer (for example: “High/Low” or “Category A/B”). Identify the explicit events that cause a switch (operator action, workflow step, scheduled batch window, job orchestration event, environment promotion, and so on).
2. **Create a label-to-mode policy mapping** (attribute-based/label-based access control) that sets which information labels/categories are allowed to use each shared resource in each processing mode.
3. **Implement the shared-resource gate** as the only way a shared resource can be released for use after a mode switch:
   - When switching, **remove access** for the previous mode.
   - Run **sanitisation** steps according to the organisation’s DoD-approved multilevel processing procedures (parameter **sc-04.02_odp**), including any required clearing/purge/cryptographic erase/reinitialisation appropriate to the resource type.
   - Run **reclassification/verification checks** to confirm the resource is in the correct “clean” state for the target mode (for example: verify label metadata/state, run integrity checks, and confirm the resource is ready for the target classification/category).
   - **Default deny**: if sanitisation or reclassification checks fail, the gate must block reuse (no exceptions).
4. **Enforce label-based access at the point of use** so that even if a user or service can authenticate, access to the shared resource is allowed only when the request’s information label/category matches the current processing-mode policy.
5. **Audit every switch and gate decision**: create tamper-evident audit records that, at minimum, include the processing-mode switch identifier, the initiating actor/service, timestamps, target mode, shared resource identifier, sanitisation procedure identifier and step results, reclassification verification results, and the final allow/deny decision. Ensure logs are sent to the enterprise security information and event management (SIEM) system and kept according to the organisation’s logging requirements.

###### WHO (role responsible)
- **Application Owner / Security Architect**: define processing modes, label-to-mode mapping, and acceptance criteria.
- **Platform/Infrastructure Engineers**: implement the gate integration with storage, compute, print, database, and other shared services.
- **Security Engineering / Identity and Access Management (IAM) Team**: implement label-based access enforcement and policy-as-code.
- **Security Operations Centre (SOC)/SIEM Team**: ensure audit log ingestion, alerting, and retention.

###### Acceptance criteria
- For every explicit processing-mode switch, shared-resource reuse is allowed only after sanitisation and reclassification/verification checks complete successfully.
- If sanitisation or reclassification checks fail, the gate blocks reuse and denies access attempts.
- Label-based access enforcement prevents access to shared resources across categories/levels when the system is in the wrong processing mode.
- Audit logs exist for each switch and each gate decision, and can be used to prove: (a) the switch occurred, (b) the checks ran, and (c) the allow/deny decision was made based on the results.
- Evidence is available for both normal operation and failure scenarios (for example, sanitisation verification failure).

###### Actions Required for Compliance

- [ ] Define the different processing modes and document the specific conditions that trigger the application or workflow orchestration to switch between them.
- [ ] Set up a rule that maps each label to the correct access mode for every shared resource type (storage, computing, printing, databases, and caching), using the organisation’s label system (taxonomy).
- [ ] Set up a shared-resource checkpoint that removes earlier access permissions, cleans and sanitises the data, and then reclassifies and verifies it before it is released.
- [ ] Set the gate to block any reuse by default if the sanitisation or reclassification checks fail (no manual override).
- [ ] Apply label-based access controls at the point where shared resources are used, based on the current processing mode and the request’s information labels.
- [ ] Set up tamper-evident audit logs for every change of processing mode and every gate decision, and send those logs to the security information and event management (SIEM) system with data retention.
- [ ] Run integration tests and failure-mode tests to prove that cross-level reuse is blocked and that complete audit evidence is available.


---

### SC-5 — Denial-of-service Protection (Control)

This requirement is about keeping your online services running even when they are targeted with extremely high volumes of traffic intended to take them offline. Without these protections, attackers—or even poor capacity planning—could overwhelm your systems with harmful requests, leading to slow performance, outages, or customers being unable to access websites, apps, or key services such as name lookups.

To meet this expectation, the organisation must address four main types of denial-of-service events and focus on reducing their impact, rather than necessarily stopping every attempt. It must put protections in place at the network edge to block harmful traffic, slow down excessive requests, remove suspicious traffic before it reaches your services, and run services with built-in resilience so that one failure does not stop everything. It must also be able to increase bandwidth and processing capacity when needed.

The organisation must document how these measures are implemented, keep records of relevant events, maintain up-to-date lists of the threats and safeguards, ensure the right people are responsible for implementation and incident response, and include this approach in system plans and design documentation.

##### Layered edge DoS protection for defined DoS types

- Category: Software
- Priority: Critical

###### WHAT
Put in place layered denial-of-service (DoS) protections for the DoS event types defined by the organisation—volumetric (UDP flood), protocol (SYN/ACK flood), application-layer (HTTP flood), and reflection/amplification (DNS/NTP)—to **limit** their impact on the application.

###### WHY (control requirement)
Security control SC-5 requires denial-of-service protection that limits the effects of DoS events. The guidance specifically expects measures such as **boundary protection devices** (boundary filtering), **rate limiting**, **traffic scrubbing**, **service redundancy**, and **capacity/bandwidth scaling** to reduce how vulnerable the service is.

###### HOW (specific steps/approach)
1. **Define the DoS coverage mapping** in system design documentation: link each DoS type to the safeguards you will use (boundary filtering, rate limiting, traffic scrubbing, redundancy, capacity scaling) and set the goal as **limit** (not absolute prevention).
2. **Boundary filtering at the network edge**: configure perimeter firewalls / cloud edge gateways / load balancers to block or reject traffic patterns consistent with UDP flood and SYN/ACK flood, and to restrict incoming access paths to only what the application needs.
3. **Rate limiting at the edge**: set connection/traffic limits for protocol-layer floods and apply per-route/per-endpoint throttling for application-layer HTTP floods (including per-source and, where applicable, per-session/token limits). Make sure limits are tuned to normal application behaviour and do not block genuine business traffic.
4. **Traffic scrubbing for volumetric and reflection/amplification**: send relevant incoming traffic through an inline scrubbing capability (or a protected upstream service) for UDP flood and DNS/NTP reflection/amplification, ensuring scrubbing happens before traffic reaches the application.
5. **Service redundancy and capacity scaling**: run the application behind redundant load balancers and use failover-capable, stateless components. Turn on automated scaling (compute/network) so that, during an identified DoS event, capacity can increase to keep the service available.
6. **Operational evidence and configuration traceability**: record and keep evidence of DoS-related actions (dropped/throttled/scrubbed events, challenge/rate-limit triggers, failover events, and scaling actions). Keep the configuration/rules and threshold settings in version-controlled infrastructure configuration, with change records.

###### WHO
- **Network/Cloud Security Engineer**: implements boundary filtering, rate limiting, and scrubbing routing.
- **Application/Platform Engineer**: implements redundancy and capacity scaling (load balancer configuration, stateless design, automated scaling).
- **Security Operations (SOC) / Incident Response Lead**: checks that alerts work, ensures evidence is kept, and supports incident response during DoS events.
- **System Owner / Authorising Officer (or equivalent)**: approves the documented DoS coverage mapping and the “limit” objective.

###### Acceptance criteria
- Documentation exists showing the organisation-defined DoS types (UDP flood, SYN/ACK flood, HTTP flood, DNS/NTP reflection/amplification) and the safeguard(s) used for each.
- Edge controls are implemented and can be shown to work: boundary filtering for UDP/SYN-ACK patterns and rate limiting for HTTP endpoints.
- Traffic scrubbing is in place for the DoS types where the organisation’s mapping requires it (at minimum for volumetric and reflection/amplification as defined).
- Redundancy and capacity scaling are enabled so that failover and scaling events are visible and logged.
- Audit evidence is kept for at least the organisation’s standard log retention period, and includes blocked/throttled/scrubbed actions as well as failover/scaling events.

###### Actions Required for Compliance

- [ ] Document how each denial-of-service (DoS) attack type maps to the corresponding safeguards for UDP flood, SYN/ACK flood, HTTP flood, and DNS/NTP reflection and amplification attacks, with the explicit objective of limiting the impact.
- [ ] Set up boundary filtering on perimeter firewalls, cloud edge services, and load balancers to block or reject the identified UDP flood and SYN/ACK flood traffic patterns.
- [ ] Set up rate limits at the network edge to control the maximum number of connections and data flows, and add request throttling for each specific web address (endpoint/route) to prevent HTTP flooding.
- [ ] Send relevant incoming network traffic through an inline traffic “scrubbing” service to filter out large-scale flooding and reflection/amplification attacks before the traffic reaches the application layer.
- [ ] Set up redundant load balancing and failover that does not rely on saved session information, and enable automatic capacity scaling for the application tiers.
- [ ] Turn on and keep audit logs for events that are dropped, limited, or filtered out, for failover actions, and for scaling events. Store the related configuration and thresholds in version control.


---

#### SC-5.1 — Restrict Ability to Attack Other Systems (Enhancement)

This expectation is about preventing people who have access to your systems from using them to overwhelm other organisations’ services with large volumes of traffic, such as UDP/TCP floods, SYN floods, web (HTTP/HTTPS) floods, and attacks that drain a service’s resources. Without these protections, a hostile insider or an external attacker who gains access to your environment could turn your network into a weapon. This could cause outages, slow performance, and reputational damage for others, while also putting your own systems at risk.

To meet this expectation, your organisation must clearly state which denial-of-service attack types you will defend against, document how you will detect and respond to them, and keep records of any such activity you see. You must put in place technical safeguards—especially at the points where traffic leaves your network or reaches key services—to block or strictly limit the common ways these attacks are carried out. You must also restrict unauthorised or forged traffic and limit excessive use of network and computing resources. Ensure these safeguards apply to all relevant users and systems, and keep audit evidence showing the protections were in place and acted when needed.

##### Boundary egress controls to block DoS attack traffic types

- Category: Software
- Priority: Critical

###### WHAT
Put in place restrictions at the network boundary that make it hard or impossible for any person (including a compromised internal host) to launch the in-scope denial-of-service (DoS) attacks against other systems: **volumetric UDP/TCP floods, SYN floods, HTTP(S) floods, and application-layer resource exhaustion attacks**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) **SC-5(1)** enhancement requires limiting people’s ability to launch the specified DoS attacks against other systems by making sure the **common methods used for these attacks are not available**. The guidance specifically asks to restrict **outbound (egress) traffic**, limit **excessive use of system resources**, and apply protections at **boundary devices** that block outbound traffic to likely target systems.

###### HOW (specific approach)
###### 1) Define enforceable traffic patterns for each in-scope DoS type
Match each in-scope DoS type to clear, enforceable network or application behaviours:
- **Volumetric UDP/TCP floods**: high-rate UDP/TCP traffic sent to many destinations, or sustained traffic above set bandwidth/packet thresholds.
- **SYN floods**: too many new connection attempts or “half-open” connections coming from internal sources.
- **HTTP(S) floods**: very high-rate HTTP/HTTPS requests (including short bursts) sent to external endpoints.
- **Application-layer resource exhaustion**: patterns that look like expensive requests (for example, high numbers of simultaneous requests, long-running sessions, and repeated access to costly endpoints) that can drain resources.

###### 2) Centralise outbound traffic so all traffic is controlled by policy
Make sure all outbound traffic from user/server subnets goes through a controlled route (for example, software-defined wide area network (SD-WAN) policy, routing through a next-generation firewall (NGFW), or via a secure web gateway/reverse proxy). This stops people from bypassing controls using alternate routes.

###### 3) Apply transport-layer DoS protections at the network boundary
On next-generation firewalls (NGFWs), firewalls, and DoS-capable outbound gateways:
- Turn on **SYN/half-open protections** (for example, SYN cookies or half-open limiting) and set **new-connection rate** thresholds.
- Apply **rate limiting** for UDP and TCP based on both **source and destination** (bandwidth/packet caps with burst handling) and **connection limiting** (limits on concurrent sessions and new sessions per second).
- Block or strictly limit traffic that matches flood-like behaviour (for example, sustained high-rate outbound traffic, or excessive connection churn).

###### 4) Apply application-layer DoS protections for web/API outbound traffic
For HTTP/HTTPS outbound traffic:
- Send outbound web/API traffic through a **reverse proxy and/or web application firewall (WAF)** (or a managed DoS/WAF service).
- Set **request rate limiting**, **limits on concurrent requests**, and **burst controls** per source identity (where available) and per destination.
- Apply protections for resource-draining patterns (for example, limit access rates to expensive endpoints, cap long-running sessions, and enforce reasonable timeouts).

###### 5) Add measurable resource controls and keep audit evidence
- Configure boundary devices to record enforcement actions (drops/blocks/rate-limit events) with enough detail for investigation (source, destination, protocol, ports, action taken, and counters).
- Send logs to a security information and event management (SIEM) system for correlation and evidence.

###### WHO
- **Network Security Engineer / Security Architect**: define the enforceable mappings and thresholds, and design the boundary enforcement.
- **Network Operations / Platform Team**: implement the NGFW/SD-WAN/proxy/WAF configurations and routing.
- **Security Operations Centre (SOC) / Security Operations (SecOps)**: check alerting and review enforcement logs to fine-tune settings.

###### Acceptance criteria (verifiable)
1. For each in-scope DoS type (volumetric UDP/TCP floods, SYN floods, HTTP(S) floods, application-layer resource exhaustion), there is a boundary control that **blocks or strictly limits** the matching traffic patterns.
2. All outbound traffic from the application’s relevant subnets is routed through the enforcement points (with no alternate outbound path that can bypass controls).
3. Enforcement actions (block/drop/rate-limit) produce audit logs in the SIEM showing at least: source IP/identity, destination, protocol/port, and action taken.
4. During controlled testing (for example, using a lab DoS simulator), the boundary controls demonstrably reduce or prevent an internal test host from sustaining the specified flood patterns beyond the configured thresholds.

###### Actions Required for Compliance

- [ ] For each in-scope denial-of-service (DoS) type (sc-05.01_odp), identify the specific network protocol, port, and application request patterns to enforce.
- [ ] Ensure that all outgoing network traffic from the relevant application subnets goes through the approved boundary protection route (next-generation firewall (NGFW), software-defined wide area network (SD-WAN), proxy, or web application firewall (WAF)).
- [ ] Set up network firewall (NGFW) traffic controls to protect against SYN and half-open connection attempts, and to limit the number of TCP and UDP connections and traffic rates separately for each source and each destination.
- [ ] Send all outbound web traffic using Hypertext Transfer Protocol (HTTP) and Hypertext Transfer Protocol Secure (HTTPS) through a reverse proxy and web application firewall (WAF), and turn on protections that limit how fast requests can be made, cap the number of simultaneous requests, and control short bursts of traffic.
- [ ] Set the trigger thresholds using normal (baseline) traffic, and decide what to do when flood-like patterns are detected—either block/deny them or apply strict limits.
- [ ] Enable and send audit logs for all enforcement actions to the security information and event management (SIEM) system, including enough details to support incident investigation.


---

#### SC-5.2 — Capacity, Bandwidth, and Redundancy (Enhancement)

This requirement is about making sure your services have enough capacity and built-in resilience to keep working even if someone tries to overwhelm them with a flood of requests. Without this planning, a busy website, app, or online service could become slow or completely unavailable, disrupting customers, day-to-day operations, and revenue.

To meet this expectation, the organisation must define, approve, and follow clear procedures for denial-of-service protection. It must also design and configure the system with practical measures, such as:
- giving priority to the most important functions
- limiting how much any one user or service can use
- separating resources so an attack affects only part of the system
- spreading traffic across multiple resources
- maintaining redundancy so a failure does not cause a complete shutdown

The organisation must keep evidence that these measures are in place and actively managed. This includes system design and configuration records, audit logs of relevant actions, and a security plan that brings these elements together.

##### DoS capacity controls: quotas, priority traffic, and partitioned pools

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement and run defined capacity and redundancy controls that reduce the impact of information-flooding denial-of-service (DoS) attacks by:
- giving selected usage priority to critical functions,
- using quotas, rate limits, and session limits,
- separating resources so flooding affects only non-critical traffic types.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SC-5(2)** (enhancement) requires the organisation to **manage capacity, bandwidth, or other redundancy** to **limit the effects of information-flooding DoS attacks**. The guidance states that managing capacity includes **selected usage priorities, quotas, separation (partitioning), or load balancing**.

###### HOW (specific steps/approach)
###### 1) Define the DoS capacity/bandwidth approach (design + thresholds)
- Identify the entry points in scope (for example: content delivery network (CDN) / web application firewall (WAF), load balancer / reverse proxy, application programming interface (API) gateway, service entry point).
- Define **critical functions** (for example: authentication, payments, placing orders, admin read-only dashboards) and assign them to traffic types.
- Set measurable thresholds for each traffic type (examples of what to set; not fixed values):
  - rate limits per internet protocol (IP) address and per customer account (tenant),
  - limits per route,
  - maximum simultaneous connections/sessions for each protocol (hypertext transfer protocol secure (HTTP(S)), WebSocket, gRPC),
  - overall circuit-breaker limits to prevent failures spreading to other parts of the system.
- Record what should happen during an attack (for example: “critical endpoints stay within agreed latency / service level objectives (SLOs); abusive traffic gets 429/503 responses; non-critical traffic types are throttled first”).

###### 2) Configure priority handling and separated traffic pools
- Set up **priority queues / traffic classes** at the edge (load balancer / reverse proxy and/or API gateway) so critical functions use dedicated capacity.
- Separate resources into different pools or virtual services per traffic type, so throttling one type does not starve others.
- Make backpressure behaviour clear (for example: queue limits and rejection rules) to avoid running out of resources.

###### 3) Enforce quotas and capacity limits in the data path
- Apply rate limiting and quota enforcement as early as possible (typically via CDN/WAF or the edge proxy), and again at application entry where needed.
- Apply connection and session caps for protocols that keep state.
- Use circuit breakers for downstream dependencies (for example: database or API calls) to prevent exhaustion of threads or connection pools.

###### 4) Produce audit-ready evidence and run it actively
- Set up monitoring and logging for:
  - events where throttling or quotas are exceeded,
  - circuit-breaker activations,
  - queue saturation and rejections,
  - which traffic type was affected.
- Send logs to the enterprise security information and event management (SIEM) system with timestamps, component identifiers, and what action was taken.
- Keep configuration evidence (infrastructure-as-code and configuration management records) showing the approved thresholds and how they map to critical functions.

###### 5) Validate using controlled tests that mimic flooding
- In a non-production environment (or during a controlled production window), generate traffic patterns that resemble information flooding.
- Check that:
  - critical endpoints remain responsive (within agreed SLO/latency targets),
  - non-critical traffic is throttled or rejected according to policy,
  - the service does not completely stop (no total outage caused by resource exhaustion),
  - the logs and metrics show the intended protective actions.

###### WHO (role responsible)
- **Application Owner / Service Owner**: defines critical functions and acceptable service behaviour.
- **Infrastructure/Network Engineering**: implements the edge, load balancer, and API gateway configurations.
- **Security Engineering**: approves thresholds and the priority policy, and ensures logging/evidence meets audit needs.
- **Operations / site reliability engineering (SRE)**: runs validation tests and monitors effectiveness during operation.

###### Acceptance criteria
- Documented and approved mapping of **critical functions → traffic classes**.
- Enforced **rate limits, quotas, and session caps**, with **priority handling** configured at the system entry point.
- **Separation (partitioning)** is demonstrated (throttling one traffic class does not degrade critical functions beyond agreed targets).
- SIEM receives logs/metrics showing throttling/quota and circuit-breaker actions with enough detail for investigation.
- Controlled flooding-like testing confirms critical endpoints stay available and non-critical traffic is constrained, with supporting evidence captured.

###### Actions Required for Compliance

- [ ] Identify the incoming network entry points that are in scope, and define traffic categories mapped to critical business functions.
- [ ] Define and get approval for measurable limits on rates, connections, and sessions for each category, and for what the circuit breaker should do when those limits are reached.
- [ ] Set up priority queues and traffic categories at the edge (load balancer, reverse proxy, or application programming interface (API) gateway) so that critical functions are handled first.
- [ ] Divide capacity into separate pools (or virtual services) for each type of traffic class, so that during traffic surges no class is left without resources.
- [ ] Set and enforce limits on how many requests can be made (rate limits), how many sessions can be active at once (session caps), and add automatic “stop-gap” protections (downstream circuit breakers) along the request route.
- [ ] Track and record events related to throttling, quotas, and circuit breakers, and send the logs and performance measurements to the enterprise security information and event management (SIEM) system for audit evidence.
- [ ] Run controlled tests that mimic flooding conditions, and check that the most important system endpoints meet the agreed availability and response-time targets, while limiting abusive traffic.


---

#### SC-5.3 — Detection and Monitoring (Enhancement)

This requirement is about spotting and responding early when someone tries to overwhelm your systems so they slow down or stop working. Without clear detection and ongoing checks, a denial-of-service attack could flood your services, use up key computing resources, and leave customers unable to access what they need. It could also make it harder to understand and trace what happened.  

To meet this expectation, the organisation must use tools that can recognise suspicious attack patterns and connect related events recorded by systems. This includes dedicated tools for denial-of-service warning signs, systems that watch network traffic for unusual behaviour, automated linking of security log events, and monitoring of how well applications are performing.  

The organisation must also continuously check whether there is enough spare capacity to withstand attacks. This means monitoring processor load, memory use, network traffic volume, message rates, and available disk space and disk performance capacity.  

The approach, settings, and monitoring methods must be documented, supported by audit records, included in the system security plan, and assigned to responsible administrators. There must be clear procedures showing how monitoring results are used for denial-of-service protection.

##### DoS/DDoS detection and resource-capacity monitoring with SIEM correlation

- Category: Software
- Priority: Critical

###### WHAT
Set up continuous detection and monitoring for denial-of-service (DoS/DDoS) warning signs, and continuously check whether key system resources have enough spare capacity (central processing unit (CPU), memory, network, and disk/inputs–outputs per second (IOPS) headroom). This helps ensure attacks cannot succeed.

###### WHY (control requirement)
Security and control (SC)-5(3) (Detection and Monitoring) enhancement requires the organisation to consider denial-of-service (DoS) risk. It also requires using monitoring tools and techniques to detect DoS/DDoS warning signs and to monitor system resources that are most affected by DoS (physical disk storage, memory, and CPU processing capacity). The guidance also highlights techniques such as raising alerts when storage capacity thresholds are reached and monitoring whether resources remain sufficient.

###### HOW (specific steps/approach)
1. **Define what will be monitored and where the data will come from** for DoS/DDoS detection and resource sufficiency, using the organisation’s agreed parameters:
   - **Monitoring tools**: DoS/DDoS detection sensors, network intrusion detection and prevention systems (IDS/IPS), security information and event management (SIEM) correlation rules, and application performance monitoring.
   - **System resources**: CPU usage, memory usage, network bandwidth/packet rates, and physical disk space/IOPS headroom.
2. **Deploy and enable DoS/DDoS detection sensors** at the system’s external-facing entry points (for example, internet edge, load balancer entry, content delivery network (CDN)/web application firewall (WAF) origin) to detect DoS/DDoS attack indicators aimed at the system and originating from it.
3. **Deploy and configure network intrusion detection and prevention systems (IDS/IPS)** (or equivalent inline detection) at key traffic choke points to identify suspicious traffic patterns consistent with DoS/DDoS (for example, sudden increases in traffic volume, connection floods, or misuse of network protocols).
4. **Send monitoring data into the SIEM** and implement **detection-as-code** correlation rules that:
   - Link network detections (from sensors/IDS/IPS) with application or service effects (for example, higher error rates, increased delays, or reduced throughput) and with signs that resources are under pressure.
   - Separate “attack happening right now” from “capacity already fully used” by requiring both: (a) DoS/DDoS warning signs and (b) resource saturation and reduced headroom.
5. **Enable application performance monitoring (APM)** and send key APM signals to the SIEM or observability pipeline so application-level effects are included in the correlation logic.
6. **Continuously monitor resource capacity** by collecting and sending metrics for:
   - CPU usage
   - Memory usage
   - Network bandwidth/packet rates
   - Physical disk space and **IOPS headroom**
   Set alert thresholds for storage capacity (and disk performance headroom where applicable) so administrators are automatically alerted when thresholds are reached.
7. **Document the monitoring approach and configuration** (data sources, collection intervals, alert thresholds, correlation logic, and routing) and ensure it is included in the system security plan. Keep audit records of monitoring configuration changes and the full lifecycle of alerts and rules.
8. **Assign operational ownership and procedures**: define who investigates (triages) SIEM alerts, who adjusts (tunes) detections, and how monitoring results trigger DoS protection actions (for example, escalation, engaging mitigation teams, or taking capacity/partitioning actions).

###### WHO
- **Security Operations Centre (SOC) / Security Operations Lead**: triage and escalation procedures for SIEM-correlated DoS/DDoS alerts.
- **Network/Security Engineering**: tuning of intrusion detection and prevention systems (IDS/IPS) and DoS/DDoS sensors, and maintenance of detection-as-code.
- **Site Reliability Engineering (SRE) / Platform Engineering**: collection of resource monitoring metrics, tuning of thresholds, and ensuring disk/IOPS headroom telemetry is accurate.
- **System Owner / Information Security Officer**: ensures documentation, inclusion in the system security plan, and retention of audit evidence.

###### Acceptance criteria
- SIEM correlation rules are implemented (under version control) and produce alerts when DoS/DDoS warning signs correlate with resource pressure and/or application degradation.
- CPU, memory, network (bandwidth/packet rates), and disk space/IOPS headroom are continuously collected and visible in monitoring dashboards and/or the SIEM.
- Automatic alerts are configured to notify administrators when storage capacity thresholds (and disk performance headroom where applicable) are reached.
- The monitoring approach and configuration are documented, included in the system security plan, and audit records exist for rule/configuration changes and alert handling.
- Named roles and documented procedures exist for triage, tuning, and response actions triggered by monitoring outputs.

###### Actions Required for Compliance

- [ ] Identify the data sources and required measures for denial-of-service (DoS) and distributed denial-of-service (DDoS) monitoring for the system, including CPU usage, memory usage, network packet and bandwidth levels, available disk space, and input/output operations per second (IOPS) capacity headroom.
- [ ] Set up or turn on distributed denial-of-service (DDoS) detection sensors at the system’s external entry and exit points, and confirm they can see both incoming and outgoing network traffic.
- [ ] Set up a network intrusion detection and prevention system (IDS/IPS), or an equivalent tool, to spot traffic patterns that match denial-of-service (DoS) or distributed denial-of-service (DDoS) attacks, and send any detections to the security information and event management (SIEM) system.
- [ ] Set up security information and event management (SIEM) “detection-as-code” rules that connect network security alerts with signs of resource strain and application or service performance problems.
- [ ] Integrate application performance monitoring (APM) signals into the security information and event management (SIEM) and observability pipeline, and include them in the correlation logic.
- [ ] Set up automatic alerts when storage capacity reaches set limits and when disk performance has less remaining capacity than expected, and send these alerts to the named administrators.
- [ ] Document the monitoring setup and procedures. Include this approach in the system security plan. Keep audit evidence showing any changes to rules or configurations.


---

### SC-6 — Resource Availability (Control)

This requirement is about ensuring your most important services keep working even during periods of very high demand. It does this by reserving and protecting the computer power, memory, and internet data capacity those services need. Without these protections, a busy period, a faulty application, or a surge of requests could overwhelm shared resources. This can lead to slow responses, failed transactions, or downtime for services your business depends on.

To meet this expectation, the organisation must first clearly identify which services are mission-critical. It must then set priority rules and fixed limits for computer processing power (CPU), memory, and network bandwidth, so lower-priority activity cannot affect higher-priority services. It must also ensure that no user or process can use more than the agreed amounts.

The organisation must document how these priorities and limits are set and kept in place, retain evidence that the system design and configuration apply them, record who changes them and when, and assign named roles responsible for managing them.

##### Enforce priority and quotas for mission-critical workloads

- Category: Software
- Priority: Critical

###### WHAT must be done
Protect the availability of key resources by assigning the organisation-defined **resources** (for example, priority central processing unit [CPU], memory, and network bandwidth for mission-critical services) using the organisation-defined **priority** and **quota** values.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SC-6 Resource Availability** requires: “Protect the availability of resources by allocating {{resources}} by {{priority, quota}}.” The guidance also requires:
- **priority protection** (so lower-priority processes cannot slow down higher-priority services), and
- **quotas** (so users and processes cannot use more than the agreed resource amounts).

###### HOW (specific steps/approach)
1. **Define the resources to protect and the mission-critical services**: create a list that links mission-critical services to the protected resources (CPU, memory, network bandwidth). Then assign the organisation-defined priority values and quota limits.
2. **Set priority protection where resource control is enforced** (choose the right layer for your hosting setup):
   - **Containers (for example, Kubernetes)**: configure **PriorityClasses** for mission-critical workloads and set CPU/memory **requests/limits** so lower-priority workloads cannot “take over” and starve them.
   - **Virtual machines / hypervisors**: configure CPU scheduling tiers/shares and memory reservations/caps for mission-critical workloads.
   - **Network bandwidth**: set per-workload/per-namespace/per-service bandwidth caps using built-in platform controls or traffic shaping (for example, ingress/egress shaping) so network congestion does not harm mission-critical services.
3. **Enforce quotas so usage is capped**:
   - **CPU**: apply hard limits where supported (or equivalent quota controls).
   - **Memory**: set strict caps to stop uncontrolled memory use from causing problems.
   - **Network**: limit bandwidth per service/namespace to the agreed quota.
4. **Ensure enforcement can be checked and changes are controlled**:
   - Use infrastructure-as-code and/or platform admission and policy controls so only approved priority/quota profiles can be deployed.
   - Record configuration changes (who/what/when) and keep proof (current configuration export plus change logs) for audit.
5. **Test under stress (contention)**:
   - Run controlled load that heavily uses CPU/memory/network with lower-priority workloads, and confirm mission-critical services still get preferential access.
   - Try to exceed quotas and confirm enforcement happens as intended (for example, throttling/limiting).

###### WHO (role responsible)
- **Infrastructure/Platform Engineer**: sets the priority/quota configuration in the hosting platform (Kubernetes, virtual machines, and network shaping).
- **Application Owner / Service Owner**: confirms which services are mission-critical and provides the required priority/quota values.
- **Security/Compliance Engineer**: ensures audit evidence, the testing approach, and change-control processes align with SC-6.

###### Acceptance criteria
- There is a documented mapping of mission-critical services to the protected resources (CPU, memory, network bandwidth) and to the organisation-defined **priority** and **quota** values.
- Priority protection is clearly enforced: during resource contention, mission-critical services keep preferential CPU scheduling and are not materially delayed by lower-priority workloads.
- Quota enforcement is clearly enforced: when lower-priority workloads/users try to exceed agreed resource use, the platform throttles/limits them and mission-critical services stay within their protected performance range.
- Audit evidence is available: current configuration exports and tamper-resistant (immutable) change logs show who changed priority/quota profiles and when.
- Contention tests and quota-exceed tests produce results consistent with the configured priorities and quotas.

###### Actions Required for Compliance

- [ ] Set up a mission-critical mapping between services and the resources they use—CPU, memory, and network bandwidth—so each service has an assigned priority level and resource quota.
- [ ] Set higher processing priority for mission-critical workloads (for example, using Kubernetes priority classes or the hypervisor’s scheduling tiers).
- [ ] Set CPU and memory requests and limits (also called reservations and caps) to control how much of the quota each workload profile can use.
- [ ] Set limits on network bandwidth for each service or namespace using built-in platform controls or traffic management, for both incoming (ingress) and outgoing (egress) traffic where this applies.
- [ ] Use approved priority and quota settings by applying them through infrastructure-as-code and/or platform admission and policy controls.
- [ ] Enable and keep records that can be audited showing the priority or quota settings and any changes to them (configuration exports and change logs).
- [ ] Run tests for service demand and quota limits to confirm mission-critical services keep priority access and that quota limits are enforced.


---

### SC-7 — Boundary Protection (Control)

This requirement is about putting clear, managed “front door and back door” controls around your systems, and closely monitoring what is allowed to come in and go out. Without these controls, unwanted visitors could enter without being noticed, harmful traffic could reach important services, and internal systems could be exposed through accidental or unauthorised connections.

To meet this expectation, the organisation must identify the main connection points where the system connects to the outside world and where important internal traffic moves between major areas. It must then monitor those points and apply rules so that only approved communications are allowed.

Any parts of the system that are available to the public must be placed in a separate, isolated network area, so they are not treated as part of the internal environment.

Finally, every connection to external networks or partners must pass through approved boundary protection devices. These devices must be configured to match the organisation’s security and privacy design, and there must be no hidden routes that bypass these protections.

##### Managed boundary protection with DMZ isolation and anti-spoofing

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up managed boundary protection on all **external managed interfaces** and **key internal managed interfaces**. Continuously watch network traffic and strictly control which communications are allowed. Put any **publicly accessible components** into a **logically separated DMZ-style subnetwork** that is not treated as part of internal networks. Make sure every route to/from the outside world goes through the managed boundary devices (no bypass routes).

###### WHY (control requirement)
Security Control SC-7 requires limiting or preventing connections between parts of an organisation’s systems by using managed interfaces (for example, gateways, routers, firewalls, guards, and encrypted tunnels) to control what can enter and leave. It also specifically requires:
- **Monitoring and controlling** traffic at external managed interfaces and key internal managed interfaces.
- **DMZ-style logical separation** for publicly accessible components.
- **Blocking spoofing**, where traffic pretends to come from internal addresses when it is external (or from external addresses when it is internal), using **source address validation** techniques.

###### HOW (specific steps/approach)
1. **Create an authoritative boundary inventory and map** covering: internet/partner edge devices (firewalls, secure web gateways, virtual private network (VPN) concentrators/tunnel endpoints, malware-analysis gateways) as external managed interfaces; and segmentation/transit firewalls or gateways between major internal zones as key internal managed interfaces.
2. **Design DMZ-style logical separation** for public-facing tiers (for example, web/application programming interface (API) front ends). Ensure DMZ routing and security group/access control list (ACL) membership mean DMZ hosts are not automatically treated as internal. Allow only the specific DMZ→internal and internal→DMZ traffic that is required.
3. **Use default-deny, explicit allow rules** for each zone-to-zone/service on every managed interface, aligned to the application’s multi-tier design (presentation/application/data/admin separation). Where possible, add rules that permit only the required protocols/ports and the required identity/service users.
4. **Apply anti-spoofing/source address validation** on boundary devices and tunnel endpoints to stop traffic using fake source/destination address characteristics (external traffic appearing to come from internal addresses; internal traffic appearing to come from external addresses). Where supported, enable ingress/egress filtering and strict route/source validation.
5. **Enable continuous monitoring with logs that can be reviewed** for every boundary device and tunnel endpoint. Log at least source/destination/service, whether traffic was allowed or blocked, the rule identifier, and timestamps. Send logs to the organisation’s security information and event management (SIEM) system for correlation and audit evidence.
6. **Check and prove “no bypass” connectivity** by reviewing routing and network paths to confirm that all external connectivity goes through the managed interfaces. For example, verify that default gateways for DMZ/internal segments point only to the managed boundary devices, and disable or lock down any unmanaged interfaces that could create alternate paths.
7. **Put change control in place for boundary rules** using policy-as-code or equivalent configuration management. Use peer review, automated checking (linting/validation), and drift detection to keep boundary behaviour consistent with the documented security design.

###### WHO (role responsible)
- **Network Security Engineer / Security Architecture Lead**: boundary inventory, DMZ design, rule model, anti-spoofing configuration.
- **Platform/Infrastructure Engineer**: implement routing/segmentation changes and ensure traffic must pass through managed interfaces.
- **Security Operations Centre (SOC) / SIEM Engineer**: ensure log forwarding, retention, and alerting for boundary anomalies.
- **Change Manager / Change Advisory Board (CAB)**: approve boundary rule changes and topology/routing modifications.

###### Acceptance criteria
- A documented boundary inventory/topology exists and can be traced to the application’s deployment (production/test/disaster recovery (DR) as applicable).
- Publicly accessible components are placed in a logically separated DMZ subnetwork, with only explicit allow rules.
- All external inbound/outbound traffic and key internal inter-zone traffic passes through managed boundary devices (no validated bypass paths).
- Boundary devices use default-deny with explicit allow rules; spoofing patterns are blocked using source address validation/anti-spoofing controls.
- Boundary devices/tunnel endpoints generate logs that are sent to the SIEM and kept for audit. Logs include rule/action and enough addressing/service detail.
- Evidence exists (routing validation outputs and configuration snapshots) showing managed-interface traversal and rule consistency after changes.

###### Actions Required for Compliance

- [ ] Create and get approval for an official record of the application’s network boundaries and connections, covering all externally managed connection points and the key internally managed connection points.
- [ ] Set up separate “demilitarised zone (DMZ)” style network sections for every component that is publicly accessible, and allow only explicitly defined traffic rules between the DMZ and the internal network (and from the internal network back to the DMZ).
- [ ] Configure each boundary device and tunnel endpoint to block everything by default, and then add only the specific “allow” rules needed for the application’s required zone-to-zone connections.
- [ ] Set up and check source address validation and anti-spoofing protections on boundary devices to stop traffic that tries to pretend it is coming from internal or external addresses.
- [ ] Turn on complete boundary and tunnel logging (including the identifiers for each rule and action) and send the logs to the security information and event management (SIEM) system with audit-ready retention.
- [ ] Check that traffic is routed correctly and that network paths follow the approved, managed connections, so that all external access goes through the managed interfaces. Keep and record evidence showing there are no alternate “bypass” routes.
- [ ] Use configuration management and policy-as-code to manage changes to boundary rules, with peer review, automated checks to confirm changes are valid, and monitoring to detect any drift from the approved settings.


---

#### SC-7.3 — Access Points (Enhancement)

This requirement is about keeping the number of “entry and exit points” between your organisation and the outside world to a sensible maximum, so the system cannot be reached through too many external links at the same time. If too many external connections are allowed, it becomes harder to spot suspicious activity, harder to control what traffic is allowed in and out, and easier for attackers to find an unexpected way into your systems.

To meet this expectation, the organisation must:
- set a clear maximum number of external inbound and outbound connections the system may use at any time;
- configure the system so it cannot exceed that limit; and
- be able to tell how many connections are currently active.

The organisation must monitor traffic using only the permitted connections, and keep records and documentation showing:
- how the boundary protection is implemented;
- how the system is designed and configured to enforce the limit; and
- how this is covered in the security plan.

This must also be maintained during technology changes, such as running older and newer network protocols at the same time. During the transition, the limit must be reviewed and updated when the change affects it.

##### Enforce a connection budget at the network edge for the system

- Category: Software
- Priority: Critical

###### WHAT must be done
Set a maximum number of simultaneous external network connections (both incoming and outgoing) that the application system is allowed to have at any one time. Make sure the network boundary controls stop the system from going over this limit. Keep audit-ready records proving the limit is applied, and that monitoring only covers the connections that are within the permitted limit.

###### WHY (control requirement)
SC-7(3) (Enhancement) requires: **“Limit the number of external network connections to the system.”** The guidance explains that limiting external connections helps you monitor incoming and outgoing traffic. This is especially important during **transition periods** (for example, **Internet Protocol version 4 (IPv4) to Internet Protocol version 6 (IPv6)**), when both technologies may run at the same time and create more possible access points.

###### HOW (specific steps/approach)
1. **Define the connection limit (“connection budget”)** for the application system: set a maximum number of simultaneous external connections, and clearly document what counts as one connection. For example: incoming sessions to public entry points, outgoing sessions started by the system, virtual private network (VPN) or tunnel sessions, and any sessions that are specific to a protocol family during transition.
2. **Enforce the limit at the boundary** (next-generation firewall (NGFW)/edge firewall/load balancer/secure gateway):
   - Use a **default-deny** approach and **allow-lists** for permitted sources, destinations, ports, and protocols.
   - Apply **simultaneous session/connection limits** where supported (or equivalent options such as per-policy session concurrency caps, tunnel concurrency caps, and rate/concurrency controls for protocols that can create many sessions).
   - During Internet Protocol version 4 (IPv4)/Internet Protocol version 6 (IPv6) transition, treat both protocol paths as part of the same overall budget (or document a combined budget with separate tracking by protocol family) so the system cannot exceed the total allowed external connection instances.
3. **Record and provide evidence of active connection counts**:
   - Configure boundary devices to log when sessions/tunnels start and stop, and when connection attempts are denied.
   - In the security information and event management (SIEM) or monitoring platform, calculate a derived measure for **“active external connections for system X”** using boundary logs.
4. **Monitor and alert when the budget is under pressure**:
   - Create alerts for sustained or sudden increases that approach or exceed the budget.
   - Ensure dashboards and investigations can show what was allowed versus what was blocked/denied.
5. **Keep the limit in place when changes happen**:
   - When network layout or protocol transition changes (for example, enabling Internet Protocol version 6 (IPv6), adding a new partner connection, or changing public endpoints), update the connection budget and boundary rules through the organisation’s change and configuration management process.

###### WHO (role responsible)
- **Network Security Engineer / Edge Firewall Administrator**: defines and implements boundary enforcement and logging.
- **Application Owner / System Owner**: confirms what counts as an external connection for the system, and checks that the budget matches operational needs.
- **Security Operations Centre (SOC) / SIEM Analyst**: builds the active-connection measure, dashboards, and alerts.
- **Governance, Risk and Compliance (GRC) / Security Assurance**: checks that audit evidence is complete and that transition-period handling is documented.

###### Acceptance criteria
- A documented **connection budget** exists for the application system, including a clear definition of what counts as an external connection (incoming/outgoing and how transition protocol activity is counted).
- Boundary controls are configured to **prevent** the system from exceeding the defined maximum simultaneous external connections (using a default-deny/allow-list approach).
- Boundary logs are available to determine **active** external connection counts at any time, and SIEM-derived measures/dashboards reflect those counts.
- Alerts and reporting show that attempts to exceed the budget are blocked/denied and are visible in monitoring.
- The evidence package includes boundary configuration snapshots/rule sets, logging configuration, and sample audit logs showing enforcement outcomes, including during any Internet Protocol version 4 (IPv4)/Internet Protocol version 6 (IPv6) transition period.

###### Actions Required for Compliance

- [ ] Create a documented connection budget for the application system, including what is counted as an external connection (inbound, outbound, tunnels, and how protocol families are counted during the transition).
- [ ] Set up edge, next-generation firewall (NGFW), and load balancer rules to block everything by default (default-deny) and only allow approved external sources, destinations, ports, and network protocols (allow-lists).
- [ ] Set up and adjust controls for concurrent sessions and connections (or an equivalent boundary mechanism) to limit the maximum number of external connection instances.
- [ ] Configure boundary devices to record when sessions or tunnels start and stop for the application system, and to record any denied access attempts.
- [ ] Set up security information and event management (SIEM) to calculate and show how many active external connections the system currently has, and to report which connections are allowed versus blocked.
- [ ] Set up alerts when budget pressure lasts for a sustained period or crosses a defined limit, and confirm that any further attempts to exceed the limit are blocked or denied.
- [ ] Update the connection budget and boundary policy through change management whenever endpoints, partners, or Internet Protocol version 4 (IPv4) / Internet Protocol version 6 (IPv6) transition settings change.


---

#### SC-7.4 — External Telecommunications Services (Enhancement)

This requirement is about closely controlling how your organisation’s external communication connections link to the outside world. The goal is to ensure only the right information can pass through, and that it cannot be secretly read, changed, or misused. Without this, an attacker could try to access your internal management and routing functions from the internet, or could trick other networks into trusting unauthorised instructions. This could disrupt services or lead to loss of control.

To meet this expectation, you must set up a clearly controlled connection for every external communications service you use. For each connection, you must have written rules that state what traffic is allowed and what is blocked. You must also protect the information while it is being sent, so it stays confidential and cannot be altered.

Any temporary exceptions to these rules must be formally recorded, including the specific business reason and the exact time period. These exceptions must be reviewed every quarter and removed when they are no longer justified.

You must also publish information that helps other networks identify unauthorised management traffic coming from you, and you must filter unauthorised management traffic attempting to enter from external networks.

##### Managed boundary for external telecom services with time-bounded exceptions

- Category: Manual
- Priority: Critical

###### WHAT must be done
For each external telecommunications service (for example: provider connectivity, domain name system (DNS), border gateway protocol (BGP)-related services, remote management links), connect it through a **managed, policy-controlled interface**. This must enforce **confidentiality and integrity for data in transit**, stop **unauthorised sharing of control traffic**, and allow only **time-limited exceptions** to traffic rules. These exceptions must be **reviewed every quarter** and removed when they are no longer justified.

###### WHY (control requirement)
Security Control SC-7(4) (Enhancement) requires that external telecommunications services are handled through controlled interfaces with a defined traffic rule set. It also requires protected transmission (confidentiality and integrity), clear controls for control traffic, and formal management of exceptions—covering **mission or business need** and **duration**—with **quarterly review** and removal.

###### HOW (specific steps/approach)
1. **Create an External Telecommunications Services Register** that maps each service to a **named managed interface** (for example: provider handover port, cloud edge connection, firewall zone/interface, software-defined wide area network (SD-WAN)/virtual private network (VPN) termination).
2. **Define and implement a traffic rule policy for each managed interface** (allow/deny rules) with **default-deny** for management/control traffic. Only create explicit allow rules for the specific, required, validated traffic.
3. **Protect confidentiality and integrity for data in transit** for all traffic using each managed interface, using protections appropriate to the technology (for example: transport layer security (TLS) 1.2 or higher / mutual TLS (mTLS) for management application programming interfaces (APIs), internet protocol security (IPsec) for site-to-site links, VPN with strong encryption for remote access). Ensure the policy requires secure transport for the relevant protocols.
4. **Protect control traffic**: apply explicit filtering to prevent unauthorised control traffic being exchanged from external networks (for example: deny unauthorised BGP/management protocol traffic at the boundary; allow only narrowly defined, authenticated and validated control interactions).
5. **Publish detection information** so remote networks can identify unauthorised management/control traffic from your network (for example: publish or maintain the required routing security and detection information where applicable, such as resource public key infrastructure (RPKI)-related information for BGP route validation).
6. **Manage exceptions with expiry and evidence**: keep an exceptions register where each exception records the **exact rule change**, **mission/business need**, **start/end dates**, **approver**, and **rollback plan**. Make exceptions expire and require evidence of quarterly review; remove exceptions that have expired or are no longer needed.
7. **Run the quarterly review in practice**: produce a quarterly review pack from the exceptions register and boundary policy configuration evidence. Obtain formal confirmation (attestation) from the accountable owner, and update policies to remove exceptions that are no longer justified.

###### WHO (role responsible)
- **Network Security Lead / Security Engineering**: designs boundary policies, control traffic filtering, and secure transport requirements.
- **Network Operations / Infrastructure Engineering**: implements and maintains managed interfaces and policy-as-code/configuration management.
- **Service Owner / Business Owner**: provides the mission/business need for exceptions and confirms quarterly reviews.
- **Information Security / Compliance**: checks the evidence, ensures exceptions are governed properly, and confirms the review schedule is followed.

###### Acceptance criteria
- Every external telecommunications service in scope is listed in the register and mapped to a **managed interface**.
- For each managed interface, there is an auditable **traffic rule policy** (allow/deny rules) with **default-deny** for unauthorised management/control traffic.
- Confidentiality/integrity protections are enforced for in-scope protocols using each managed interface (evidence: configuration and test results).
- Boundary filtering demonstrably prevents unauthorised control traffic from external networks (evidence: rule review and test/scan results).
- Exceptions are recorded with **mission/business need** and **start/end dates**, and the organisation can show **quarterly review evidence** and removal of expired exceptions.
- Where applicable to the service type, detection information is published or maintained to support remote detection of unauthorised management/control traffic (evidence: published artefacts and validation checks).

###### Actions Required for Compliance

- [ ] Create and keep an External Telecommunications Services register that lists each external service and links it to a named managed interface.
- [ ] Create a documented rule for each managed network interface that clearly states which traffic is allowed and which is denied, with a default of denying all management and control-plane traffic.
- [ ] Set up and check the protections for keeping data confidential and unaltered while it is being sent for each connection (for example, Transport Layer Security (TLS) / mutual Transport Layer Security (mTLS) or Internet Protocol Security (IPsec) / virtual private network (VPN)), and keep records showing the configuration was applied.
- [ ] Set up boundary filtering to block unauthorised control-plane network traffic coming from external networks, and confirm it works using focused tests.
- [ ] Create an exceptions register that records the change being requested, the mission or business reason, the start and end dates, the person who approves it, and the plan for how to undo the change if needed.
- [ ] Run a quarterly review of all active exceptions, keep a record of the approval evidence, and remove any exceptions that are no longer justified.
- [ ] Publish and check detection evidence that is relevant to the service type (for example, RPKI-related information for Border Gateway Protocol (BGP)) to support remote detection.


---

#### SC-7.5 — Deny by Default — Allow by Exception (Enhancement)

This requirement is about blocking all network traffic by default, and then allowing through only the specific connections you have explicitly approved. Without this, unwanted or harmful connections could be able to enter or leave your systems, which could lead to unauthorised access, data theft, or disruption—especially when your systems connect to outside services or partners.

To meet this requirement, the organisation must set up the managed connection points (such as network boundary devices) so that both incoming and outgoing traffic is blocked unless it matches a clearly defined and documented exception. The organisation must:

- define the permitted exceptions for each direction (incoming and outgoing),
- apply the same approach to connections to external systems,
- keep clear records showing the approved exceptions and the settings that were put in place.

The organisation must also have written procedures, documented plans and designs, and evidence from configuration and audit records showing that the blocking and approved exceptions are actually enforced.

##### Default-deny firewall policy with exception catalogue at managed interfaces

- Category: Software
- Priority: Critical

###### WHAT
Put a **deny-by-default (catch-all deny)** rule in place on every **managed interface** for both **incoming and outgoing** network traffic. Only allow traffic when it matches an explicitly approved **exception**, including connections to **external systems**.

###### WHY (control requirement)
SC-7(5) requires the organisation to **deny network communications traffic by default** and **allow network communications traffic by exception** at managed interfaces. This must apply to **incoming and outgoing** traffic and to systems connected to **external systems**.

###### HOW (specific steps/approach)
1. **Define managed interfaces** in an inventory (for example: boundary firewalls, cloud security gateways, ZTNA egress points, SD-WAN edge, router boundary interfaces). Assign an owner and the environment (production, test, disaster recovery).
2. **Create an exception catalogue**. Each exception must be specific to direction (incoming or outgoing) and include: source and destination (IP address/range, fully qualified domain name, or network zone), protocol and port(s), the required application/service context, and a **traceable approval reference** (for example, change ticket or authorisation ID). Treat external systems (partners, software-as-a-service, and internet egress destinations) as standard destinations.
3. **Set default deny** on each managed interface for both directions (incoming and outgoing). Ensure there is no broad “allow all/any” rule that would override the deny-by-default approach.
4. **Create allow rules only from the exception catalogue**. Generate or manually configure rules so that every permitted network flow matches **exactly one** approved exception. Keep scope tight (avoid broad wildcard ports or IP ranges unless there is an explicit justification and approval).
5. **Enforce and keep evidence**: use configuration management so deployed rules are recorded (for example, device configuration snapshots, infrastructure-as-code commit IDs, and change records). Add automated checks to confirm the live configuration has the expected default-deny posture and includes only the approved exception rules.
6. **Test exception enforcement**: run periodic rule-matching tests (for example, simulated connection attempts from controlled test hosts) to confirm approved flows work and non-approved flows are blocked, including for external system destinations.

###### WHO (role responsible)
- **Network Security Engineer / Firewall Administrator**: implement and maintain managed interface configurations.
- **Security Governance / Risk Owner**: approve exceptions and ensure they are correct for direction and scope.
- **Change Manager / CAB** (Change Advisory Board): ensure approvals are traceable to change records.
- **Compliance/Assurance Analyst**: check evidence (configuration snapshots, approvals, and test results) for audit.

###### Acceptance criteria
- For every managed interface, **incoming and outgoing** traffic is **denied by default** (confirmed through configuration evidence).
- Every allowed traffic flow matches an **explicitly approved exception** (confirmed by comparing the exception catalogue with the deployed rules).
- No broad catch-all allow rules exist that conflict with deny-by-default.
- Connections to **external systems** are controlled using the same exception catalogue and enforcement approach.
- Evidence exists for: (a) exception approvals with traceable references, (b) the deployed configuration state, and (c) periodic test results showing approved flows are allowed and non-approved flows are denied.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of all managed interfaces where “deny by default, allow only when specifically approved” must be enforced.
- [ ] Create an exceptions register that lists, for each allowed data flow, the reason for the exception, the source and destination, the network method and ports used, and a reference to the approval that can be traced back.
- [ ] Set a “default deny” rule (a catch-all block) for both incoming and outgoing network traffic on every managed network interface.
- [ ] Implement “allow” rules that are taken strictly from the approved exception catalogue only (no broad “allow all” wildcard rules).
- [ ] Set up configuration management and produce audit-ready evidence that links the deployed rules to the approved exceptions and the related change records.
- [ ] Run regular “synthetic” connectivity checks to confirm that any approved exceptions still work, and that traffic to destinations that are not approved is blocked, including connections to external systems.


---

#### SC-7.7 — Split Tunneling for Remote Devices (Enhancement)

This requirement is about preventing remote workers’ devices from using a “workaround” that lets some internet traffic avoid the organisation’s secure connection while they are accessing internal systems. If this is not controlled, a device could be tricked into sending traffic to the wider internet or other places that are not approved at the same time as it connects to organisational services. This increases the risk of unauthorised access and the theft or leakage of organisational information.

To meet this requirement, the organisation must block split tunnelling by default for any remote device connecting to organisational systems. Split tunnelling should only be allowed when the connection is set up through the organisation’s centrally managed virtual private network (VPN) approach. This approach must use pre-defined, named connection profiles that route traffic only to pre-approved Department of Defense (DoD) networks and only to a fixed list of approved destinations. Users must not be able to change routing or destination choices.

The organisation must also detect any attempt to enable split tunnelling (or any settings that would allow it) and refuse the connection if such an attempt is detected. In addition, the organisation must ensure users cannot change those settings.

##### Enforce no-split tunnelling via managed, locked VPN profiles

- Category: Software
- Priority: Critical

###### WHAT
Stop remote devices from using split tunnelling to bypass the organisation’s approved secure remote-access route, **unless** split tunnelling is **set up securely** using the organisation-defined safeguards in **{{ insert: param, sc-07.07_odp }}** (managed, named VPN split-tunnel setup with exclusive routing and fixed destination allowlists, with **no user control**).

###### WHY (control requirement)
SC-7(7) requires that split tunnelling for remote devices is **blocked by default**, and only allowed when the split tunnel is **set up securely** using the specified organisation safeguards. This lowers the risk that remote users or devices can access uncontrolled external networks (for example, the internet) while still being able to reach organisational systems, which increases the risk of unauthorised access and data being taken out of the organisation.

###### HOW (specific steps/approach)
Apply controls at both the **VPN gateway** and the **remote device configuration** so that split tunnelling cannot be enabled by users, and any attempt is stopped when the connection is made.

1. **Create centrally managed, named VPN access profiles** aligned to the **sc-07.07_odp** safeguards. Each profile must define:
   - exclusive routing mode (tunnel-only for approved environments)
   - permitted destination networks and hosts using a **fixed destination allowlist** (pre-approved DoD networks)
   - a clear ban on user changes to routes or destinations
2. **Configure the VPN gateway to block split tunnelling by default**:
   - require that traffic follows only the selected approved profile
   - disable or ignore any route information or split-tunnel settings provided by the VPN client
   - ensure that if the session is not established using an approved named profile, the connection is ended or quarantined
3. **Lock the VPN client configuration so users cannot change routing or allowlists**:
   - deploy the VPN client profile through enterprise endpoint management (for example, mobile device management (MDM) / unified endpoint management (UEM)) as a managed, signed, and unchangeable configuration
   - remove user permissions to edit VPN routing, DNS, split-tunnel settings, or destination lists
4. **Add checks and enforcement at connection time**:
   - confirm when the session starts that the connected device is using the approved named profile
   - if split-tunnel-capable settings are detected (or the session does not match the allowed destinations), **refuse the connection** (end or quarantine it)
5. **Create audit evidence for each remote session**:
   - record the user identity, device compliance status, VPN profile name, and the enforced routing/allowlist result
   - keep the logs for audit and incident investigation linking

###### WHO (role responsible)
- **Network/VPN engineering lead**: VPN gateway configuration, profile definitions, and enforcement at connection time.
- **Endpoint management (MDM/UEM) administrator**: deploy the locked VPN client profile and restrict user changes.
- **Security operations (SOC) / security information and event management (SIEM) analyst**: monitor, raise alerts, and verify evidence.
- **Information security and compliance owner**: approves the set of profiles aligned to sc-07.07_odp and reviews them regularly.

###### Acceptance criteria
- For remote devices, **split tunnelling is blocked by default** for all connections to organisational systems.
- Split tunnelling is only possible when the VPN session uses a **centrally managed, named profile** that enforces **exclusive routing** to **pre-approved DoD networks** and a **fixed destination allowlist**.
- Users cannot change VPN routing or destination settings (any attempts do not change the enforced behaviour).
- If a client tries to use split-tunnel-capable settings or deviates from the approved profile, the VPN connection is **refused** (ended or quarantined) at connection time.
- For each session, there is evidence showing the **profile name** used and the enforced routing/allowlist outcome.

###### Actions Required for Compliance

- [ ] Set up centrally managed, named virtual private network (VPN) split-tunnel profiles that follow control sc-07.07_odp by using exclusive routing and fixed destination allowlists, with no user ability to change the settings.
- [ ] Set up the virtual private network (VPN) gateway to ignore any split-tunnel instructions provided by clients, and make “tunnel-only” routing the default behaviour.
- [ ] Set up the virtual private network (VPN) client configuration through mobile device management (MDM) or unified endpoint management (UEM) as an unchangeable managed profile, and remove users’ ability to edit routing, domain name system (DNS), or split-tunnel settings.
- [ ] Set up checks when a connection starts to confirm the session uses an approved named profile. If it does not, or if it shows settings that could allow split tunnelling, immediately end the session and place it in quarantine.
- [ ] Link virtual private network (VPN) session logs to security information and event management (SIEM) so that records include the user identity, whether the device meets compliance requirements, the selected profile name, and the final destination and routing result that was enforced.
- [ ] Run a test suite to confirm that users cannot enable split tunnelling, and that when using the approved profiles, devices can only reach destinations that have been approved under **sc-07.07_odp**.


---

#### SC-7.8 — Route Traffic to Authenticated Proxy Servers (Enhancement)

This requirement ensures that when staff or systems in your organisation need to access the internet or other external networks, they do so through your approved and authenticated proxy servers at the connection points you control, rather than connecting directly. Without this, unauthorised access could go unnoticed, sensitive information could be sent without oversight, and it would be harder to detect and investigate misuse because external activity would not consistently pass through a controlled checkpoint.

To meet this requirement, the organisation must:
- clearly identify which internal communications are intended for external networks
- configure systems so that this traffic is directed through the authenticated proxy at the managed connection points
- ensure that only authorised users or systems can use the proxy

The organisation must also:
- document the boundary approach and how traffic is routed
- record which proxy components are used and where they are located
- keep evidence that the settings are in place
- retain audit records showing that external requests were handled by the proxy
- include this approach in the security plan, with named responsibilities for implementation and ongoing oversight

##### Force external-destined traffic via authenticated proxy at egress

- Category: Software
- Priority: Critical

###### WHAT
Route the organisation-defined **internal communications traffic intended for external networks** ({{param:sc-07.08_odp.01}}) to the organisation-defined **external networks** ({{param:sc-07.08_odp.02}}) **through authenticated proxy servers at managed network interfaces**. This ensures the proxy is the go-between, and that access to the proxy is authenticated.

###### WHY (control requirement)
SC-7(8) enhancement requires that the covered traffic is routed **through authenticated proxy servers at managed interfaces**. This reduces direct connections to external networks and allows controlled inspection, policy enforcement, and clear audit records.

###### HOW (specific steps/approach)
1. **Define the covered traffic clearly**: create an outbound (egress) policy that links {{param:sc-07.08_odp.01}} to destinations in {{param:sc-07.08_odp.02}} (for example, the Internet and other non-organisational networks). Include the network types (protocols) your proxy supports—at minimum, web traffic for typical deployments.
2. **Place proxy servers on managed outbound (egress) interfaces**: install forward proxy (or web proxy) instances in the DMZ/egress area behind the organisation-controlled boundary (managed interface), with predictable routing from internal networks to the proxy.
3. **Enforce “proxy-only” routing for covered traffic**:
   - Use **transparent/forced proxy** (intercept and redirect) or **explicit proxy enforcement** (endpoint or network policy) so covered traffic cannot leave directly.
   - Use firewall and routing controls to block direct outbound paths for the covered destinations/protocols, ensuring the proxy is the go-between.
4. **Require authenticated access to the proxy**:
   - Connect proxy authentication to the enterprise identity provider (single sign-on (SSO)) and require multi-factor authentication (MFA) for users who interact with the system.
   - For service accounts and automated workloads, use workload identity/service principals and short-lived credentials where supported.
5. **Limit destinations and record proxy activity**:
   - Configure proxy allow/deny lists that match {{param:sc-07.08_odp.02}} and block unauthorised destinations.
   - Turn on detailed proxy logging (user/workload identity, source, destination, time, protocol, and the proxy’s decision and authentication result) and send logs to the security information and event management (SIEM) system for audit.
6. **Document and keep evidence of the boundary protection**:
   - Update the system or network security design and security plan to show where the proxy sits, which interfaces are managed, and how routing is enforced.
   - Keep configuration evidence (proxy configuration, firewall rules, routing/redirect rules) and retain audit logs showing that external requests were handled via the proxy.

###### WHO (role responsible)
- **Network/Security Engineering Lead**: designs and implements outbound routing enforcement and proxy placement.
- **Identity and Access Management (IAM) Owner**: integrates proxy authentication with the enterprise identity provider and multi-factor authentication (MFA)/workload identity.
- **Security Operations Centre (SOC) / SIEM Engineer**: checks logging, retention, and alerts for proxy use and attempts to bypass it.
- **System Owner / Authorising Official (AO)**: ensures the security plan and evidence package are maintained for audit.

###### Acceptance criteria (verifiable)
- For traffic matching {{param:sc-07.08_odp.01}} to {{param:sc-07.08_odp.02}}, **all** outbound connections go through the authenticated proxy at the managed egress interface (there is no direct outbound route for covered traffic).
- Proxy access requires successful authentication; unauthenticated requests are blocked.
- Proxy logs sent to the SIEM show client/workload identity, destination, and the decision outcome for covered external requests.
- Firewall and routing controls prevent direct outbound connectivity to {{param:sc-07.08_odp.02}} for the covered protocols/destinations.
- Security design documentation and configuration evidence are available and match the deployed setup.

###### Actions Required for Compliance

- [ ] Define and publish the “covered egress” policy mapping from {{param:sc-07.08_odp.01}} to {{param:sc-07.08_odp.02}}, broken down by protocol and destination scope.
- [ ] Set up authenticated forward and web proxy servers at the organisation’s managed exit points (demilitarised zone (DMZ) / egress tier).
- [ ] Set up proxy enforcement that is mandatory (transparent or explicitly required) so that covered traffic cannot avoid using the proxy.
- [ ] Set up proxy authentication using the organisation’s identity provider (single sign-on (SSO) and multi-factor authentication (MFA) for people using the system; workload identity for services)
- [ ] Set proxy destination allow/deny rules in line with {{param:sc-07.08_odp.02}} and block any destinations that are not authorised.
- [ ] Enable and centralise proxy session logging in security information and event management (SIEM), including the client identity, destination, and the outcome of each access decision.
- [ ] Update the system and network security design and security plan, including route diagrams, and keep the configuration and audit log records as evidence for review.


---

#### SC-7.9 — Restrict Threatening Outgoing Communications Traffic (Enhancement)

This requirement is about stopping suspicious messages from leaving your organisation and being able to identify exactly which person inside caused them. It helps prevent internal systems being used to attack or harm outside services—for example by overwhelming them with traffic, hiding where the traffic really comes from, or sending harmful code—which could cause service disruption, legal issues, and damage to your reputation.

To meet this expectation, your organisation must monitor outgoing communications at the points where your systems connect to the outside world. It must automatically detect activity that matches your agreed criteria for “threatening” behaviour and immediately block that traffic. For every blocked attempt, you must record which internal user account was responsible and keep those records available for review, so the actions can be audited.

You also need to define, document, and keep up to date the criteria used to spot these threats, along with the procedures, system design, configuration, and the tools involved. Finally, you must assign clear responsibility for running the checks and reviewing the results.

##### Identity-aware egress gateway blocks threatening extrusion traffic

- Category: Software
- Priority: Critical

###### WHAT
Implement extrusion detection at the organisation’s **managed exit/boundary points** so that **dangerous outgoing communications** are **detected and automatically blocked**, and each blocked event is **linked to the internal user identity** responsible.

###### WHY (control requirement)
SC-7(9) enhancement requires **extrusion detection** for outgoing communications traffic that results from internal actions which could threaten external systems, carried out **within the system at managed boundary points**. This includes checking outgoing traffic for signs such as **denial-of-service patterns, spoofed source address indicators, and malicious-code indicators**. The organisation must also have **criteria to decide, update, and manage identified threats** related to extrusion detection.

###### HOW (specific steps/approach)
1. **Send all outgoing traffic through managed exit points** (for example, a secure web gateway, secure access gateway, ZTNA exit, or a cloud egress firewall) for both the application’s production and test environments, ensuring the exit layer is the place where enforcement and detection happen.
2. **Turn on identity-aware session/flow tagging** at the exit gateway by integrating with the organisation’s enterprise identity provider (single sign-on) so each forwarded connection includes the **internal user principal/ID**, internal host, device/session identifiers, destination, and protocol/port.
3. **Set up extrusion detection rules** at the exit layer using the organisation’s agreed threat indicators, covering at least:
   - **DoS-like/excessive-rate behaviour** (for example, unusual connection rates, repeated failed handshakes, protocol anomaly patterns)
   - **Spoofing indicators** (for example, mismatches between the claimed source characteristics and what is observed at the exit)
   - **Malicious-code indicators** (for example, content/file-type checks where allowed, known-bad destinations, and other approved indicators)
4. **Set enforcement to block only after a positive detection decision**: when a rule matches, the exit gateway must **block** the outgoing traffic at the managed boundary point and stop further transmission for that flow/session.
5. **Create audit records for every blocked event** that include enough information to identify the internal user account responsible (for example: timestamp, internal host, internal user principal/ID, device/session ID, destination, protocol/port, rule identifier, and action taken).
6. **Centralise log sending and review** by sending exit denial/audit logs to the security information and event management (SIEM) system and creating searches/detections for “blocked extrusion events by user”, including alerts for repeat offenders and high-impact destinations.
7. **Manage and update extrusion detection criteria** using detection-as-code/policy-as-code with controlled change management: keep versioned rules, require review/approval, test in non-production, deploy with rollback, and keep an auditable record of all criteria updates.

###### WHO (role responsible)
- **Network/Security Engineering**: implement and maintain the exit gateway enforcement and detection configuration.
- **Identity/Access Management (IAM) Team**: ensure correct identity provider integration and reliable user principal tagging.
- **Security Operations Centre (SOC)/Security Operations (SecOps)**: confirm alerting works, investigate blocked events, and help tune the criteria.
- **Governance, Risk and Compliance (GRC)/Compliance**: check that evidence is sufficient (criteria versions, approvals, and audit log retention).

###### Acceptance criteria
- All outgoing traffic for the application passes through the **managed exit interface** where extrusion detection is applied.
- For a set of test cases that match the organisation’s extrusion indicators (DoS-like, spoofing-like, malicious-code-like), the system **blocks** the outgoing traffic and produces an audit record.
- Each blocked event is traceable to an **internal user identity** (user principal/ID) and includes the required context fields (internal host, destination, protocol/port, rule ID, action).
- Extrusion detection criteria are stored in a controlled repository with **versioning**, **review/approval**, and **deployment evidence** (including non-production testing and rollback capability).
- Blocked-event logs are sent to the SIEM and can be searched for “blocked extrusion events by user”.

###### Actions Required for Compliance

- [ ] Define and document the organisation’s approved network exit and boundary points for the application, so that all outgoing traffic is checked at those locations.
- [ ] Connect the egress gateway to the organisation’s identity provider to label every outgoing connection with the internal user’s name or ID and the details of the user session.
- [ ] Set up rules at the point where traffic leaves the network to detect denial-of-service (DoS)-like behaviour, signs of address spoofing, and approved indicators of malicious code.
- [ ] Set the egress gateway to block outgoing traffic only after a positive extrusion detection decision, and then stop the flow or session.
- [ ] Set up audit logging so that every denied event records: the internal user identity, the internal host, the destination, the protocol and port, the rule identifier, and the action that was taken.
- [ ] Send “outbound traffic blocked” and audit logs to the security information and event management (SIEM) system, and set up alerts and searches for blocked data-exfiltration attempts by user.
- [ ] Set up “detection-as-code” and “policy-as-code” controls for extrusion criteria, including version tracking, review and approval, testing, deployment, and proof of rollback.


---

#### SC-7.10 — Prevent Exfiltration (Enhancement)

This expectation is about preventing sensitive information from leaving your organisation without being noticed—whether someone tries to steal it on purpose or it leaks by accident—and then showing that the protections still work. Without this, confidential data could be sent to unauthorised places, which could lead to financial loss, legal issues, reputational damage, or harm to customers and staff.

To meet this, the organisation must put safeguards in place to stop information being sent out from internal devices, through the organisation’s external connection points, or over managed connections. These safeguards must control the right types of outgoing communication and detect unusual “check-in” activity or abnormal sending patterns.

The organisation must also run data-exfiltration tests at least once every quarter to confirm both prevention and detection. It must keep clear records of what was tested, what the results were, and any fixes that were needed.

##### Quarterly exfiltration prevention tests with egress/DLP enforcement

- Category: Software
- Priority: Critical

###### WHAT
Put in place controls to stop and monitor **outbound** data leaving the application from its **internal endpoints**, **external boundaries**, and **managed interfaces**, and check that the controls work by running **quarterly exfiltration tests**.

###### WHY (control requirement)
SC-7(10) enhancement is designed to stop both **intentional and unintentional data theft**, including:
- enforcing that outbound communication follows the correct **protocol** rules,
- spotting **beaconing** and unusual changes in network traffic, and
- running exfiltration testing at a set **frequency**.

The organisation sets this test frequency to **quarterly** (sc-07.10_odp).

###### HOW (specific approach)
###### 1) Stop exfiltration at endpoints and within the application
- Set up or enable **endpoint and server-side data loss prevention (DLP)** rules for the application’s supported data types (for example, documents, records, exports) to block or limit copying/exporting to unauthorised places (for example, personal webmail, unauthorised cloud storage, removable media).
- Use **outbound allowlisting** for sensitive workflows, so only approved destinations (domains/Internet Protocol addresses/protocols) can be reached from application systems and user devices when handling sensitive data.
- Make sure application and application programming interface (API) services enforce **correct outbound message formats** (for example, strict validation of JSON/XML content; reject malformed or unexpected fields) to reduce the risk of hidden data theft using incorrect formats.

###### 2) Stop exfiltration at external boundaries and managed interfaces
- Configure boundary controls (for example, deep packet inspection firewalls and XML gateways where applicable) to check that outbound traffic follows the expected application-level protocol rules, and to block traffic that does not conform.
- Apply network-level traffic profile controls to detect deviations in the **volume and types of traffic** expected for the application and its managed interfaces.

###### 3) Detect beaconing and exfiltration-like outbound behaviour
- Add detection rules in the security operations centre (SOC) pipeline for:
  - **Beaconing/check-in** patterns (regular outbound connections to unusual destinations/ports)
  - **Out-of-profile upload/download** behaviour (new destinations, unusual timing, repeated small transfers)
  - **Protocol/format issues** (unexpected message structures, repeated failures of schema/format validation)
- Make sure alerts are linked to the relevant identity and session details (user/service account, device compliance status, and the data classification involved).

###### 4) Run and keep evidence from quarterly exfiltration tests (intentional and accidental)
- Create a repeatable test plan and run it **at least quarterly**:
  - **Intentional scenarios:** try to export sensitive test data to an unauthorised destination using realistic user workflows and scripted attempts.
  - **Accidental scenarios:** try common leakage routes (copy/export to unauthorised storage, incorrectly shared links, unintended uploads).
  - **Beaconing scenarios:** try low-and-slow outbound patterns to confirm detection and blocking.
- Keep audit evidence including: test case, dataset classification, attempted destination(s), actions taken by controls (blocked/allowed), detection results, and remediation items.

###### WHO
- **Security Engineering / SOC Engineering:** implement outbound controls (egress) and DLP enforcement, and set up detection rules.
- **Application Owner / Platform Team:** ensure correct application-level protocol validation and that integrations are implemented properly.
- **Information Security (governance, risk and compliance (GRC)/Compliance):** approve the quarterly test plan, ensure evidence is retained, and track remediation.
- **Red Team / Penetration Testing function (or contracted provider):** carry out the intentional exfiltration test scenarios.

###### Acceptance criteria
- Quarterly exfiltration tests are carried out **at least once every quarter**, and evidence is retained (plan, execution logs, results, and remediation tracking).
- For unauthorised destinations, outbound exfiltration attempts are **blocked or prevented** by endpoint/server controls and/or boundary/managed-interface controls.
- Detection rules produce alerts for beaconing/check-in and traffic deviations, and alerts are reviewed using identity/session context.
- Application-level protocol compliance checks reject outbound messages that do not match the application’s supported formats.
- Documented remediation either closes any control gaps found during the quarterly tests or records an approved risk acceptance.

###### Actions Required for Compliance

- [ ] Set up data loss prevention (DLP) rules for the application’s sensitive data on endpoints and servers, and either block copying or exporting to unauthorised destinations, or require approval first.
- [ ] Set up rules for outgoing network traffic from hosts and applications so sensitive workflows can only connect to approved destinations (specific domain names, IP addresses, and network protocols).
- [ ] Enable checks on outgoing application data at the message level (for example, enforce strict JSON or XML format rules) and reject any outgoing messages that do not match the required format.
- [ ] Adjust boundary and managed-interface controls (for example, deep packet inspection firewall rules and XML gateway policies) to enforce correct protocol behaviour and block traffic that does not meet requirements.
- [ ] Set up security operations centre (SOC) alert rules to detect “beaconing” or regular check-in behaviour and unusual outbound network traffic. This includes changes in the amount, type, and timing of traffic, and any new destination addresses.
- [ ] Run quarterly data-exfiltration tests that cover intentional, accidental, and “beaconing-like” behaviour. Use test data sets and record the results.
- [ ] Review the test results, fix any control weaknesses found, and keep the audit evidence for each quarterly testing cycle.


---

#### SC-7.11 — Restrict Incoming Communications Traffic (Enhancement)

This expectation is about putting a strict “who can enter and where they can go” control on your network. It means only approved external partner addresses and your on-premises management subnets are allowed to access your public-facing services in the demilitarised zone (DMZ) and the specific internal application endpoints you have chosen.

Without this control, unwanted outsiders could try to access your systems, test for weaknesses, or reach services they were never meant to use. This could lead to data theft, service disruption, or unauthorised changes.

To meet this requirement, the organisation must clearly define and document:
- the approved incoming source address ranges, and
- the approved destination services/endpoints.

It must then configure the boundary protection devices so traffic is allowed only when the source and destination match the approved pairs. All other traffic must be blocked, including traffic that could be allowed through any forwarding or mapping rules.

The organisation must keep the relevant configuration, design, policy and procedure, security plan, and audit evidence showing that the allow and block decisions are enforced and can be reviewed.

##### Default-deny inbound allowlist by source/destination pairs

- Category: Software
- Priority: Critical

###### WHAT
Set up an explicit “only allow” list on boundary protection devices, so that inbound traffic is allowed **only** when the **source IP address** is in the **authorised sources** (parameter: sc-07.11_odp.01) and the **destination** is in the **authorised destinations** (parameter: sc-07.11_odp.02). All other inbound traffic to those destinations is blocked.

###### WHY (control requirement)
SC-7(11) enhancement requires: **“Only allow incoming communications from {{ sc-07.11_odp.01 }} to be routed to {{ sc-07.11_odp.02 }}.”** The guidance also expects **source address checking** and enforcement using **router access control lists and firewall rules**, recognising that IP addresses can be faked.

###### HOW (specific steps/approach)
1. **Create or confirm the authoritative list** of allowed **(source IP range) → (destination endpoint)** pairs. Include the **protocol** and **port** for each authorised destination endpoint (for example, demilitarised zone (DMZ) service ports and the approved internal application endpoints).
2. On each relevant **network boundary firewall/router**, set a **default block** for inbound traffic to the authorised destination endpoints, and add clear **allow rules** that match both:
   - **Source**: only the configured authorised source ranges (sc-07.11_odp.01)
   - **Destination**: only the configured authorised destination endpoints (sc-07.11_odp.02)
   Make sure the rules are in the correct order (most specific first) and remove or disable any older broad rules (for example, “any source” to DMZ web/admin ports).
3. If there is **network address translation (NAT)/port forwarding** or any external-to-internal routing that reaches the authorised destinations, apply the same **source restrictions** to the forwarding/NAT rules as well (not only to the post-NAT firewall rules) to prevent bypass.
4. Turn on **source address validation** features on the boundary device where available (for example, anti-spoofing/bogon filtering/invalid source rejection) on the inbound interfaces/zones used for partner access.
5. Configure **logging** for both **allowed** and **blocked** decisions, at minimum capturing: source IP address, destination IP address, destination port, protocol, and action. Send these logs to the **security information and event management (SIEM)** system so evidence can be produced that the allowlist is being enforced.
6. Manage the rules using **policy-as-code** (or an equivalent configuration-as-code approach) with peer review and controlled change management, ensuring the deployed configuration matches the documented authorised source/destination definitions.

###### WHO
- **Network Security Engineer / Firewall Administrator**: implement and maintain boundary rule sets, NAT/forwarding restrictions, and source validation settings.
- **Security Architect**: approve the authorised source/destination list and ensure it matches the organisation’s defined parameters.
- **Change Manager / Configuration Manager**: enforce a controlled change process and maintain configuration baselines.
- **Security Operations Centre (SOC) / SIEM Administrator**: ensure logging/forwarding and retention are in place for audit evidence.

###### Acceptance criteria
- For every authorised destination endpoint in sc-07.11_odp.02, inbound traffic is **allowed only** when the source IP is within sc-07.11_odp.01 and the destination/protocol/port match the allowlist.
- Any inbound attempt from a non-authorised source to an authorised destination is **blocked** at the boundary (including when using NAT/port-forwarding paths).
- Source address validation (anti-spoofing/bogon/invalid source rejection) is enabled on the relevant inbound interfaces/zones.
- Boundary devices produce audit evidence showing **allow/block** decisions with source/destination/port/protocol/action, and the deployed configuration can be traced back to the documented allowlist matrix.

###### Actions Required for Compliance

- [ ] Create a record of the approved allowlist rules showing which source IP address ranges are permitted to access which destination endpoints, including the network protocol and port number.
- [ ] Set up boundary firewall and router rules so that all incoming traffic is blocked by default (default-deny), and only allow traffic that matches approved source and approved destination pairs (explicit permit rules).
- [ ] Remove or turn off any wide-ranging incoming access rules that would allow traffic from sources or to destinations other than the authorised source and destination pairs.
- [ ] Update network address translation (NAT), port-forwarding, and forwarding rules so that the same authorised source restrictions are enforced end to end.
- [ ] Enable boundary checks on incoming network interfaces/zones to reject invalid or fake source addresses (anti-spoofing, bogon and invalid source rejection).
- [ ] Set up and centralise logging of both allowed and denied decisions, and confirm that the security information and event management (SIEM) system is receiving those logs for audit evidence.
- [ ] Set up the rule set using configuration-as-code, with peer review and deployments that follow change control procedures.


---

#### SC-7.12 — Host-based Protection (Enhancement)

This requirement is about putting a protective “gatekeeper” on every device your organisation uses, so unwanted connections are blocked before they can reach your systems. If host-based firewalls are not switched on and set correctly, attackers could test servers, workstations, laptops, and phones/tablets and potentially gain access, disrupt services, or steal information.

To meet this expectation, the organisation must install and keep host-based firewall software running on all servers, workstations, notebook computers, and mobile devices, and ensure it remains enabled during normal day-to-day operations. The organisation must also document, in clear internal records, which firewall rules and settings are required, how they are configured and updated, and which firewall products are used.

The organisation must be able to demonstrate, using system design records, security plans, configuration records, and audit logs, that the required firewall settings are actually applied on each type of device, including mobile devices. It must also identify any gaps or devices that do not meet the requirement, with supporting evidence.

##### Enforce host-based firewall baselines on all endpoints

- Category: Software
- Priority: Critical

###### WHAT
Implement the organisation-defined **host-based boundary protection mechanisms** (host-based firewalls) on the organisation-defined **system components** (servers, workstations, notebook computers, and mobile devices). Ensure the required baseline settings are applied and that you can prove this with evidence.

###### WHY (control requirement)
NIST SP 800-53 **SC-7(12) Host-based Protection (enhancement)** requires: **“Implement {{ sc-07.12_odp.01 }} at {{ sc-07.12_odp.02 }}.”** The guidance specifically includes **host-based firewalls** and the listed device types (servers, workstations, notebooks, mobile devices). This helps ensure unwanted connections are blocked at the device boundary.

###### HOW (specific steps/approach)
1. **Set standard firewall settings for each device type and operating system** (for example, Windows Defender Firewall profiles, macOS application firewall, and Linux host firewall rules) in line with the organisation’s approved boundary protection standard. Baselines must include: a default **deny/block** position for incoming connections, the **required allow** rules for business functions, and **logging enabled** for firewall decisions.
2. **Roll out the standard settings using central endpoint management** for managed devices (for example, Microsoft Intune, Jamf, or Workspace ONE) and/or **endpoint detection and response (EDR) policy management** where available. Ensure the firewall is **installed and enabled**, and record the baseline policy version.
3. **Ensure mobile device coverage** using **unified endpoint management (UEM)** profiles for supported platforms. If a platform cannot reliably enforce firewall settings, apply alternative access restrictions (for example, only allow access from devices that meet compliance requirements) so only compliant devices can reach the application.
4. **Check for changes and fix them**: continuously verify that the firewall service is running/enabled and that the expected rule set and logging settings are in place. Automatically fix issues or raise a ticket for manual fixing when changes are detected.
5. **Produce audit-ready evidence**: export reports from the management system (showing whether the policy was applied and enabled) and keep device-level logs/events (firewall enablement and rule-change events) in the **security information and event management (SIEM)** or log repository.
6. **Update system design and security documentation** to clearly state the enforcement method (management/EDR/UEM) and the baseline for each device type, so auditors can link the “what/where/how” to the evidence.

###### WHO (roles responsible)
- **Endpoint Security Engineer / Cybersecurity Operations**: create and maintain firewall baselines and the change-checking and fixing process.
- **IT Infrastructure / Platform Engineering**: implement and maintain endpoint management/EDR/UEM policy deployment.
- **Security Governance / GRC**: ensure documentation (system design/security plan) is updated and that evidence retention meets audit requirements.
- **Service Owner (application/infrastructure owner)**: confirm that the required incoming allow rules match the application’s needs.

###### Acceptance criteria
- For **all** in-scope endpoints (servers, workstations, notebooks, mobile devices), the host-based firewall is **present and enabled** during normal operations.
- The organisation-approved firewall baseline is **applied** for each device type/operating system, including required allow rules and **firewall logging enabled**.
- Change detection identifies any endpoint where the firewall is disabled or the baseline has been altered, and remediation starts within the organisation’s defined service level agreement (SLA).
- Audit evidence is available: management-system compliance reports (policy applied/enabled status) and retained device/firewall logs showing enablement and relevant configuration/rule-change activity.

###### Actions Required for Compliance

- [ ] Create and get approval for standard host-based firewall settings for each device type and operating system (servers, workstations, notebooks, and mobile devices). These standards must include a default “deny/block” rule, the specific “allow” rules that are required, and rules for recording (logging) firewall activity.
- [ ] Deploy the approved firewall settings to all managed servers and devices using endpoint management (mobile device management (MDM) / unified endpoint management (UEM)) and/or endpoint detection and response (EDR) policy.
- [ ] Set up mobile device firewall rules using unified endpoint management (UEM) profiles where available, and block access for devices that are not compliant or are not managed.
- [ ] Set up ongoing compliance checks to spot when a firewall is turned off and when settings drift from the agreed baseline, and put in place automated fixes or automatic ticket creation.
- [ ] Store and keep evidence of firewall setup and any firewall rule changes in the security information and event management (SIEM) or log repository, using device identifiers.
- [ ] Update the system design and security plan documents to name the enforcement method and the baseline configuration for each device.


---

#### SC-7.13 — Isolation of Security Tools, Mechanisms, and Support Components (Enhancement)

This requirement is about keeping the tools your organisation uses to spot threats, check for weaknesses, and support investigations in a separate, tightly controlled part of your internal computer network. The risk it addresses is that if these tools are placed too close to everyday business systems, an attacker could potentially reach them, learn how your investigations work, or use them to move further into your environment.

To meet this expectation, the organisation must:
- identify the specific security monitoring and log analysis tools, vulnerability scanners, and forensic support components that need to be isolated;
- place them into physically separate network areas; and
- connect those areas to the rest of the organisation only through managed, rule-based network connections.

The organisation must also:
- document the design;
- record the network settings that enforce the separation;
- ensure the supporting hardware and software can maintain the separation;
- generate audit records for these isolated tools; and
- include this approach in its security plans and boundary-protection procedures, with any changes to the setup properly approved and evidenced.

##### Physically isolated security tools zone with managed interfaces

- Category: Software
- Priority: Critical

###### WHAT
Set up one or more **physically separate network segments** dedicated to the organisation’s **information security tools, security mechanisms, and support components** (for example, security monitoring and log analysis tools, vulnerability scanners, and forensic support components). Connect these segments to the rest of the internal system **only through managed connections**.

###### WHY (control requirement)
NIST SP 800-53 **SC-7(13)** enhancement requires that the specified security tools and components (parameter **sc-07.13_odp**) are **kept separate from other internal system components** by using **physically separate network segments** and **managed connections** to other components. This guidance is intended to stop attackers from learning how the organisation analyses data and performs forensics.

###### HOW (specific steps/approach)
1. **Inventory and scope**: Keep an up-to-date, authoritative list of the exact computers and services that make up **sc-07.13_odp** (security information and event management, log analysis, vulnerability scanners, forensic support components). Include the system owners, IP addresses, network connections, and the required inbound and outbound connections.
2. **Build physically separate network segments**: Place these components into a dedicated network segment or zone (for example, a “Security Services Zone”) that is **physically separate** from the production and business network segments (use dedicated network equipment and ports where possible; otherwise use dedicated virtual routing and forwarding instances and uplinks, with a documented reason for the physical separation).
3. **Allow only managed connections**: Send all traffic between the isolated zone and other internal components through **managed boundary devices** (firewalls, secure gateways, or controlled routers). Use **default deny** and **explicit allow-list** rules for only the required traffic (for example, application servers sending logs to log collectors; scanner control from a management or jump host; forensic support access only from authorised incident response or security operations centre jump hosts).
4. **Eliminate bypass routes**: Disable or remove any other ways to connect (such as direct network routing, unmanaged switches, direct peer connections, or temporary network tunnels) that could allow communication outside the managed connections. Confirm this using network path testing.
5. **Operate and keep proof**: Document the design (network diagrams, addressing, routing, firewall rule sets, and who owns each interface). Keep evidence of the configuration (exported firewall settings, routing tables, and change-control records). Ensure the isolated tools produce their own audit logs.
6. **Change control and regular checks**: Any change to which systems are in the isolated zone, or to the connection rules, must be approved through change management and re-checked (rule review plus connectivity testing) to maintain separation over time.

###### WHO
- **Security Architect / Network Security Engineer**: designs the isolated zone, boundary controls, and the managed connection rules.
- **SOC/IR Lead (Security Operations Centre / Incident Response Lead)**: confirms what connectivity is needed for monitoring, scanning, and forensic activities.
- **Infrastructure/Platform Team**: implements the network segmentation and configures the boundary devices.
- **Change Manager / CAB (Change Advisory Board)**: approves changes affecting isolated-zone membership and connection rules.
- **Compliance/Assurance**: checks that evidence is complete and performs periodic validation.

###### Acceptance criteria (verifiable)
- Every system listed in the **sc-07.13_odp** register is located in the dedicated **physically separate** network segment(s).
- No traffic between the isolated zone and other internal components is possible except through **managed boundary devices** using **default deny** and explicit allow-list rules.
- Network testing confirms there are **no bypass routes** (such as direct routing, direct peer connections, or tunnels) that allow prohibited communication.
- The organisation keeps auditable evidence for the isolation design, including network diagrams, boundary device configurations, routing and interface configurations, and change-control records.
- Regular re-validation shows isolation remains in place after changes (system membership and rule changes).

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, official list (register) of all security tools and components covered by **SC-07.13 ODP**, including the computers and services involved, the responsible owners, the relevant IP addresses, and the connections that are required.
- [ ] Set up a dedicated, physically separate network zone for the registered tools, with documented rules for IP addressing and routing boundaries.
- [ ] Set up managed boundary devices between the isolated zone and other internal networks so that traffic is blocked by default, and only the specific, required traffic is allowed using an explicit allow-list.
- [ ] Remove or disable any possible ways to bypass the network controls (for example, flat routing, unmanaged switching, direct peering, or ad-hoc tunnels) and document the measures that prevent bypass.
- [ ] Create and keep audit-ready evidence, including network diagrams, exported firewall and routing settings, records showing who owns each network interface, and change-control records.
- [ ] Run and record connectivity and route checks to confirm that only approved managed-interface communications are possible.


---

#### SC-7.14 — Protect Against Unauthorized Physical Connections (Enhancement)

This requirement is about preventing unauthorised people from physically connecting to, or interfering with, the network connection points hidden in equipment rooms and wiring closets. Without clear protection, someone could quietly redirect or intercept communications by plugging cables into the wrong place. This could disrupt services or expose information.

To meet this requirement, the organisation must keep a documented list of the specific patch panels, fibre and copper cable routes, and managed connection ports that are in scope. These must be clearly labelled and physically separated for each managed connection, so cables and connections for different connections are not mixed.

Access to these areas and connection points must be restricted to authorised personnel only. This should be done using locked doors, controlled entry, and locked or covered patch panel and connection frames where needed.

The approach must be written down, kept up to date, and aligned with the site wiring diagrams. Records must be kept to show the protections are in place and that access is properly granted and then removed when no longer needed.

##### Segregate and lock managed-interface patching and cable routes

- Category: Manual
- Priority: Critical

###### WHAT
Put physical protections in place for the organisation-defined **managed interfaces** (network patch panels, fibre/copper cable trays/routes, and managed interface ports in equipment rooms and wiring closets) so unauthorised people cannot access, reroute, or connect cables in a way that creates unauthorised physical connections.

###### WHY (control requirement)
SC-7(14) enhancement requires the organisation to **protect against unauthorised physical connections** within the defined scope (**managed interfaces**). The guidance also expects protection using **clearly identified and physically separated cable trays, connection frames, and patch panels** for each managed interface, combined with **physical access controls that limit authorised access**.

###### HOW (specific approach)
1. **Create and keep an accurate in-scope physical inventory** of managed interfaces for each equipment room/wiring closet, including unique IDs for: patch panels, tray sections/routes, and managed interface ports. Make sure the inventory matches the site wiring diagrams and is kept up to date.
2. **Physically separate** cabling infrastructure for each managed interface by using dedicated or partitioned tray sections (or tray barriers/partitions), and ensure cable routes for one managed interface are not mixed with others.
3. **Physically separate** patching infrastructure for each managed interface by using distinct patch panel areas or locked/partitioned patch frames/cabinets, so patching for one managed interface cannot be easily done on another.
4. **Add durable, clear identification** at the connection frames and patch panel port blocks (and at tray entry/exit points where practical) showing the managed interface ID and the relevant side/role.
5. **Limit authorised physical access** to the protected items (equipment rooms/wiring closets and the patching infrastructure) using locked doors and controlled entry. Where feasible, use locked patch panel/cabinet doors or locked/covered patch frames, and protective covers over unused ports.
6. **Create audit-ready evidence** by setting up an inspection routine (for example, quarterly) to check that: segregation barriers/partitions are still in place, labels are present and readable, locked covers/cabinets are in place, and only authorised personnel can access the areas. Store the results against the in-scope inventory.

###### WHO
- **Infrastructure/Network Engineering Lead**: owns the managed interface physical inventory, segregation design, and label standards.
- **Facilities/Physical Security Manager**: ensures room/closet access controls and lock management match authorised access.
- **IT/OT Operations (Network Cabling Team)**: implements physical segregation, locked patching equipment, and carries out inspections.
- **Information Security/Compliance**: reviews the evidence and ensures the approach stays within the SC-7(14) scope.

###### Acceptance criteria
- For each managed interface in the in-scope inventory, there are **clearly identified** and **physically separated** cable tray section(s) and patch panel/connection frame area(s).
- The protected patching infrastructure is **not directly accessible** without authorised physical access (locked/covered patch frames/cabinets and controlled room/closet entry).
- Labels at the point of use correctly reference the managed interface ID and are readable during inspection.
- Inspection records exist for the most recent inspection cycle showing segregation integrity, label presence, and the condition of locks/covers for all in-scope managed interfaces.

###### Actions Required for Compliance

- [ ] Define and get approval for the list of managed interfaces that are in scope—patch panels, tray sections/routes, and managed interface ports—ensuring each one has a unique ID for every equipment room and wiring closet.
- [ ] Redesign the cable routes so that each managed connection uses its own dedicated (or separated) cable tray sections or routes, with physical barriers to stop cables being accidentally connected to the wrong place.
- [ ] Set up the patching equipment so that patch panels are in physically separate, clearly labelled areas, or use locked or partitioned patch frames for each managed network connection (interface).
- [ ] Fit locked doors to the patch panel or cabinet, and/or use locked or covered patch frames. Where possible, add protective covers over any unused managed network interface ports.
- [ ] Apply long-lasting labels at the patch panel port blocks and connection frames (and, where practical, at the tray entry and exit points). Each label should reference the managed interface ID.
- [ ] Ensure only authorised people can physically access equipment rooms and wiring closets, and the protected patching infrastructure, using an approved access list and lock and key management.
- [ ] Carry out and record regular inspections to confirm that separation barriers are intact, labels are readable, and locks and covers are in good condition, compared against the managed interface inventory that is in scope.


---

#### SC-7.15 — Networked Privileged Accesses (Enhancement)

This requirement is about ensuring that any remote access to important systems using high-level permissions goes through one controlled entry point, rather than connecting directly to the target system. Without this, if an attacker gains remote administrative access, they could more easily misuse powerful functions, steal sensitive information, or disrupt critical services. It would also be harder for the organisation to show what happened.

To meet this expectation, the organisation must clearly define what counts as high-privilege access and what counts as network-based access. It must then route all remote high-privilege requests through a dedicated managed access point that controls who can connect and to which systems.

The same entry point must also keep a reliable record (log) of every attempt, whether it succeeds or fails, with enough detail to review later. The organisation must be able to retrieve these records for the required period and follow a defined process to regularly review them.

##### Broker all networked privileged access via managed PAM interface

- Category: Software
- Priority: Critical

###### WHAT
Route all **network-based privileged access** (for example, remote administration actions sent over routable networks such as virtual private network (VPN) or zero-trust tunnels, secure shell (SSH), remote desktop protocol (RDP), remote console, and web-based administration) through a **dedicated, managed interface** (privileged access management (PAM) access gateway or jump interface). This interface must control who can connect and must create records that can be audited.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SC-7(15)** (enhancement) requires that **networked, privileged access** is routed through a **dedicated, managed interface** for **access control and auditing**. This lowers the chance that attackers can misuse privileged capabilities and improves the quality of evidence for investigations.

###### HOW (specific approach)
1. **Define scope and routing rules**: Create an organisation-approved list that defines (a) what counts as **privileged access** in this environment (for example, administration and security functions, configuration changes, access to security tools, and similar activities) and (b) what counts as **network-based access** (connections started over network paths, including VPN and remote tunnels). Exclude access that is only available from a local console.
2. **Set up a dedicated managed interface**: Deploy hardened PAM gateways or jump hosts in a dedicated management network segment. Register all privileged targets (servers, network devices, admin consoles, and privileged application administration endpoints) so that the PAM gateway is the only permitted network route for privileged sessions.
3. **Prevent bypass**: Update network controls so that privileged protocols and ports to targets are blocked from user networks and only allowed from the PAM gateway or jump interface (for example, firewall rules, access control lists (ACLs), or security group rules that permit gateway-to-target traffic only).
4. **Control access at the interface**: Configure PAM to allow users based on their identity (identity provider (IdP)), role and least privilege, source restrictions, and—where required—approval for high-risk actions. Ensure PAM brokers the session (so users cannot create a direct privileged connection from themselves to the target).
5. **Create auditable records for every attempt**: Configure PAM to produce audit events for **both successful and failed** privileged access attempts. At minimum, record: user identity, source (internet protocol (IP) address/connection), target, session type or action, time, result, and the reason for denial where applicable.
6. **Centralise retention and review**: Send PAM audit logs to the organisation’s security information and event management (SIEM) and logging platform, and keep them for the required period. Use an evidence-based review process (for example, scheduled review of privileged access denials and successful sessions, with links to related tickets).

###### WHO
- **Security Engineering / identity and access management (IAM) and PAM team**: implement the PAM gateway, policies, and logging integrations.
- **Network Engineering**: implement firewall and ACL rules to prevent bypass.
- **System Owners / Application Owners**: maintain the list of privileged targets and approve the scope mappings.
- **Security Operations Centre (SOC) / Security Operations**: carry out periodic review and triage of privileged access audit records.

###### Acceptance criteria
- All privileged remote administrative access to in-scope targets is only possible through the PAM managed interface (direct network access to targets for privileged protocols is blocked).
- PAM enforces authorisation when the session is set up (users who are not authorised cannot start privileged sessions).
- For every privileged access attempt (successful and failed), an auditable event is generated and sent to SIEM with the required details (user, source, target, time, outcome, and denial reason where applicable).
- Privileged access audit logs are kept centrally and can be retrieved for review and investigation within the organisation-defined retention period.

###### Actions Required for Compliance

- [ ] Define and document what counts as privileged access and what counts as network-based access for this environment.
- [ ] Set up and secure a dedicated privileged access management (PAM) gateway/jump interface, and register all systems and accounts that privileged users can access.
- [ ] Set up network firewall and access control list (ACL) rules to block privileged network protocols from reaching the target systems, except when the traffic comes through the privileged access management (PAM) interface.
- [ ] Set up privileged access management (PAM) rules for identity-based authorisation, approved target allow-listing, and restrictions on where access requests can come from
- [ ] Enable privileged access management (PAM) session brokering so privileged sessions are created only through the managed interface.
- [ ] Connect privileged access management (PAM) audit events to the organisation’s security information and event management (SIEM) system, and make sure the logs record both successful and failed access attempts.
- [ ] Set up a scheduled review process for audit records of privileged access, including capturing supporting evidence.


---

#### SC-7.16 — Prevent Discovery of System Components (Enhancement)

This requirement is about protecting the “front door” systems that allow staff to connect in a controlled way, so they are not easily found by outsiders. If an attacker can learn the exact network locations of these managed interface components, they can target them directly using common scanning and device-finding tools, which increases the risk of unauthorised access or disruption.

To meet this expectation, the organisation must:
- identify which specific components act as managed interfaces
- decide what information must not be discoverable, especially their network locations
- ensure those locations are not published in public places, not listed in public naming records, and not directly reachable in a way that reveals internal details

Where appropriate, the organisation should hide internal locations behind translated addresses and ensure direct routing to the internal locations is not possible. The organisation must also:
- periodically change the relevant addresses
- implement these protections using real technical settings
- keep clear records of what was done and when
- test from outside to confirm that outsiders cannot discover or reach the managed interfaces

##### Hide managed-interface endpoints via NAT, controlled routing and external tests

- Category: Software
- Priority: Critical

###### WHAT must be done
Prevent unauthorised discovery of specific system components that act as a **managed interface** by making sure their **network locations (for example, Internet Protocol/port reachability and any identifiers that can be resolved from outside the trusted boundary)** cannot be discovered from outside that boundary.

###### WHY (control requirement)
SC-7(16) (Enhancement) requires: **“Prevent the discovery of specific system components that represent a managed interface.”** The guidance says this can be achieved by **not publishing network addresses**, using **network address translation (NAT)**, **not putting addresses into the domain name system (DNS)**, and/or **periodically changing network addresses**.

###### HOW (specific steps/approach)
Use an external “address indirection” approach for each managed-interface component:

1. **Create a managed-interface inventory** that maps each managed interface (for example, a jump host, management gateway, remote access broker, or admin application programming interface (API) endpoint) to its internal Internet Protocol/port and the externally reachable translation endpoint(s).
2. **Place managed interfaces behind a boundary NAT layer** (for example, a cloud NAT gateway, edge firewall, reverse proxy, or load balancer using destination NAT/source NAT (DNAT/SNAT)) so external parties can only reach **translated** endpoints. Ensure the internal managed-interface Internet Protocol addresses are **not directly reachable** from outside.
3. **Use a deny-by-default inbound rule set** at the boundary, and allow only the explicitly required services/ports to the translation endpoints. Ensure firewall/security-group rules do not reveal internal managed-interface addressing (for example, avoid exposing internal Internet Protocol addresses in error messages, banners, or incorrect redirects).
4. **Remove or avoid publishing internal network locations**: make sure internal managed-interface Internet Protocol addresses/ports are not included in public documentation, support pages, public dashboards, or external configuration repositories. Also ensure any cloud metadata/tags that could be used to discover them are not publicly exposed.
5. **Control DNS exposure for managed interfaces**: do not publish internal managed-interface addresses in public DNS. If external DNS names are needed for access, ensure they resolve only to the boundary translation endpoints (not to internal addresses).
6. **Optionally rotate internal addresses** for managed interfaces on a defined schedule (or use short-lived/temporary instances) to align with the guidance on **periodically changing network addresses**, where this will not disrupt authorised access.
7. **Test and keep evidence of external discovery attempts**: from the viewpoint of a non-authorised network, run an approved discovery/scanning method to confirm that internal managed-interface Internet Protocol addresses/ports are not discoverable or reachable from outside, and that only the intended translated endpoints are visible.

###### WHO (role responsible)
- **Network Security Engineer / Cloud Network Engineer**: implement NAT, routing, and boundary firewall rules.
- **Application/Platform Owner**: keep the managed-interface inventory up to date and ensure access methods continue to work.
- **Security Assurance / governance, risk, and compliance (GRC)**: set acceptance criteria, review evidence, and maintain audit records.

###### Acceptance criteria
- For each managed interface in the inventory, an external party cannot discover or directly reach the **internal** managed-interface Internet Protocol/port (there is no externally reachable internal addressing).
- External scanning from a non-authorised network segment shows only the intended **translated** endpoints (and not internal managed-interface addresses).
- Public DNS (or any other externally resolvable naming) does not resolve to internal managed-interface addresses.
- Evidence is available for: boundary NAT/routing configuration, the managed-interface inventory, and the results of external discovery tests (including date/time and tool/source).

###### Actions Required for Compliance

- [ ] Identify and record each managed interface component, including how its internal Internet Protocol (IP) address and port are mapped to an external translation endpoint.
- [ ] Set up boundary network address translation (NAT) so that outside users can reach only the translated endpoints. Ensure internal managed-interface Internet Protocol (IP) addresses are not directly reachable (routable) from outside.
- [ ] Set inbound firewall and security-group rules to “deny by default” and allow only the required translated services and ports to the managed-interface translation endpoints.
- [ ] Remove any internal managed network interface Internet Protocol (IP) addresses and port numbers from all public-facing documentation, dashboards, and external configuration files.
- [ ] Ensure that public Domain Name System (DNS) records for managed interfaces resolve only to the boundary translation endpoints (and not to internal addresses).
- [ ] Set up and run a regular internal process to change network addresses when it is practical (for example, using temporary systems or scheduled address changes), while ensuring authorised access is not disrupted.
- [ ] Carry out and keep records of external discovery tests to prove that internal managed interface addresses and ports cannot be found or reached from a non-authorised network.


---

#### SC-7.17 — Automated Enforcement of Protocol Formats (Enhancement)

This requirement is about making sure every message your systems receive has the exact expected structure and follows the required rules before the message is allowed to be used. Without this, attackers or faulty partners could send incorrectly formed or unexpected messages that pass through, which could expose weaknesses or cause systems to behave incorrectly.

To meet this expectation, the organisation must set up and run automated checks at the application level (for example, through an XML or message gateway) that review all relevant communications between users and systems. These checks must reject or flag anything that does not match the required format, including issues that lower-level network checks might not catch.

The organisation must document how these checks are built into the system design, define the required message rules, configure the enforcement so it is clearly active, and keep audit records showing what was blocked or flagged and why, for the required retention period. The organisation must also ensure named roles and developers are able to operate the checks, and be able to show they work using evidence from configuration and audit logs.

##### Schema-enforcing API/XML gateway for protocol format validation

- Category: Software
- Priority: Critical

###### WHAT
Set up automated checks at defined entry points (for example, an application programming interface (API) gateway and/or an extensible markup language (XML) gateway) to ensure every incoming message (and, where practical, outgoing messages) matches the official protocol rules (schemas/contracts). Messages that do not comply are either blocked or marked for follow-up using consistent handling.

###### WHY (control requirement)
Security Control (SC)-7(17) enhancement requires the system to **enforce correct protocol formats**. Guidance says that application-level enforcement components (for example, **XML gateways** and “deep packet inspection” firewalls) should check whether the protocol format is correct and spot weaknesses that are not visible at network or transport layers.

###### HOW (specific steps/approach)
1. **Define the official message rules** for each protocol/message type in scope:
   - REST/JSON: create and maintain OpenAPI (or an equivalent) request/response schemas, including required fields, data types, allowed values (enums), length limits, and structural rules.
   - XML: create and maintain XML Schema Definition (XSD) rules and, where needed, Schematron rules for allowed number of elements (cardinality) and business constraints.
   - For any other application protocols supported by the gateway, define equivalent message contracts.
2. **Apply enforcement at the boundary** so checks happen before the receiving application processes the message:
   - Configure the API gateway/XML gateway as an inline enforcement point for all relevant user and system-to-system traffic paths (including partner/vendor integrations and any alternate routes).
3. **Use strict validation and consistent outcomes**:
   - Configure the gateway to validate using strict mode.
   - Set behaviour to **reject invalid** messages (for example, HTTP 400/422 for REST; an XML-appropriate error) or **flag** them according to an organisation-approved handling policy.
   - Ensure error responses do not reveal sensitive information (consistent with existing error-handling standards).
4. **Make enforcement traceable for audits**:
   - Configure logs to record, at minimum: the enforcement component identifier, endpoint/service, message type, enforcement outcome (blocked/flagged), and a **reason category** (for example, schema mismatch, missing required field, invalid allowed value).
   - Send logs to the central security information and event management (SIEM) / logging platform with access controls and retention that match organisational requirements.
5. **Run it with controlled, testable updates**:
   - Store gateway rule sets and schema files in version control.
   - Use continuous integration/continuous deployment (CI/CD) to release changes with peer review and automated regression tests (both valid and intentionally malformed payloads).
6. **Prove it works with evidence**:
   - Run regular test cases (including malformed payloads) to show the gateway blocks/flags non-compliant messages and that the matching audit records are created.

###### WHO
- **Application Security Engineer / Security Architect**: defines the enforcement approach, message rule requirements, and audit logging expectations.
- **API/Integration Engineer**: implements the gateway configuration and validation modes.
- **Developers / Schema Owners**: maintain OpenAPI/XSD/Schematron contracts and keep them aligned with how the application behaves.
- **Operations / Platform Team**: ensures the gateway is deployed correctly, that logs are forwarded, and that retention/access controls are in place.

###### Acceptance criteria
- For each protocol/message type in scope, there is an official schema/contract (OpenAPI/XSD/Schematron or equivalent) used by the gateway.
- All configured boundary routes for in-scope traffic are validated by the gateway before messages reach the application.
- If a message does not match the schema/contract, the gateway returns the configured rejection/flag outcome and creates an audit log entry that includes the outcome and reason category.
- Gateway rule sets and schemas are stored in version control and deployed through the organisation’s change/release process.
- Evidence is available showing that compliant messages are successfully validated and that malformed messages are blocked/flagged, with corresponding audit records accessible in the SIEM.

###### Actions Required for Compliance

- [ ] Identify and list all in-scope user connections and system-to-system connections, then map each one to the gateway boundary enforcement point.
- [ ] Create or update the approved protocol definitions (OpenAPI for JSON/representational state transfer (REST); XML schema definition (XSD) and XML schema language (Schematron) for XML) for every message type that is in scope.
- [ ] Set up the API gateway and XML gateway to check that incoming messages strictly match the required format and contract before they are processed by the backend systems.
- [ ] Ensure violations are handled in a consistent, predictable way (either rejected or flagged), and standardise error messages so they do not reveal sensitive information.
- [ ] Enable and centralise audit logs for enforcement outcomes, including the reason categories. Then check that security information and event management (SIEM) forwarding is working correctly and that logs are kept for the required retention period.
- [ ] Set up gateway rule sets and data structure files under version control, and deploy them using continuous integration and continuous delivery (CI/CD) with automated tests that check for incorrectly formed data payloads.


---

#### SC-7.18 — Fail Secure (Enhancement)

This requirement is about making sure that if a key security control (such as a router, firewall, or application gateway) fails or stops working, the systems behind it do not suddenly become exposed or act in an unsafe way. Without this, a failure could accidentally allow outsiders to gain access, or could cause unauthorised information to be released, weakening the protections the organisation relies on to keep data and services safe.

To meet this expectation, the organisation must clearly define what “safe on failure” means for each protected network boundary, document what staff should do when the device fails, and identify which network connections are covered. The organisation must design and configure its systems so that, during the device failure, the intended protections still work—external access is blocked and unauthorised release is prevented.

The organisation must also keep evidence by recording and reviewing failure events. This approach must be included in the security plan, assigned to named roles, and tested so that the logs show the secure outcome during and after the failure.

##### Fail-secure boundary enforcement with fail-closed defaults and HA

- Category: Software
- Priority: Critical

###### WHAT
Set up “fail-secure” behaviour on managed boundary protection devices (routers, firewalls, and application gateways in the demilitarised zone (DMZ) or protected network areas). This ensures that if the device has an operational problem, connected systems are not left in an unsafe state. In particular, when a boundary device fails, it must block incoming access from the outside world and prevent any unauthorised release of information.

###### WHY (control requirement)
SC-7(18) Enhancement requires stopping systems from ending up in unsafe states because of an operational failure of a boundary protection device at managed connection points. The guidance says failures must not allow outside information to enter the devices, and must not allow unauthorised information to be released.

###### HOW (specific steps/approach)
1. **Define fail-secure rules for each boundary type and network area**: For every managed connection (for example, Internet to DMZ, DMZ to internal, and between zones), clearly define the unsafe “fail” outcomes that must be prevented (for example, any-to-any access being allowed, inspection being skipped, switching to permissive rules, or using a fallback that allows traffic that was previously blocked).
2. **Set fail-closed defaults on boundary devices**: Configure default actions to **deny/drop** for incoming and between-zone traffic. Disable or remove any features that “allow on error” or “bypass on failure”. Make sure policy enforcement does not switch into an “allow by default” mode when services or processes fail.
3. **Use redundant protection (high availability) so failure does not remove the boundary**: Deploy boundary devices in a high availability (HA) setup (for example, active/standby or an equivalent arrangement) so the remaining device continues enforcing the same rules. Configure health checks so failover happens only when policy enforcement is active. Avoid failover designs that temporarily open paths.
4. **Stop routing/forwarding from bypassing protections during failure**: Ensure the network cannot automatically redirect traffic to an unrestricted route. Use controlled routing (for example, static routes with change control, or dynamic routing with strict policy and authentication) so that losing the boundary device does not create an unintended “direct” path between external networks and protected network areas.
5. **Record and confirm outcomes using logging and joined-up analysis**: Turn on logging for interface state changes, policy denials/drops, and session results. Connect this to security information and event management (SIEM) and set up correlation checks for “boundary device failure → blocked traffic / no unauthorised release”.
6. **Test fail-secure outcomes using controlled failure exercises**: During a planned maintenance window, simulate boundary device operational failures (such as stopping a service, taking an interface down, or performing an HA failover). Confirm that unauthorised traffic is denied or times out, and that authorised traffic only works for the explicitly allowed paths.

###### WHO (role responsible)
- **Network Security Engineer / Firewall and Application Gateway Engineer**: implement fail-closed and high availability configurations.
- **Infrastructure Architect**: confirm routing/forwarding cannot bypass the protection rules.
- **Security Operations (SOC) / SIEM Engineer**: implement logging, correlation, and evidence retention.
- **Change Manager / Change Advisory Board (CAB)**: approve and schedule the controlled failure testing.

###### Acceptance criteria
- During a simulated operational failure of the boundary device at each in-scope managed connection point, **no unauthorised external traffic can enter** the protected network areas (default deny/drop is enforced; no bypass).
- During the simulated failure, **no unauthorised information release** occurs (for example, no unintended exposure of internal services or data paths; only explicitly allowed traffic succeeds).
- High availability failover does not create any period where rules are turned off or traffic is permitted by default.
- Evidence is produced: logs show the boundary failure event(s) and the matching deny/drop outcomes; SIEM correlation confirms “failure → secure outcome”.
- Controlled failure tests are carried out and results are documented to support audit readiness.

###### Actions Required for Compliance

- [ ] For each managed interface or zone in scope (demilitarised zone (DMZ) boundaries and protected subnetworks), define what “fail-secure” means and list any unsafe states that are not allowed.
- [ ] Configure boundary devices to block all traffic by default (deny/drop), and remove or disable any features that allow traffic when errors occur or that bypass controls when failures happen.
- [ ] Set up high availability (HA) for boundary enforcement and configure health checks so failover happens only when policy enforcement is active.
- [ ] Check that routing and forwarding cannot get around the security boundary during a failure, so there are no unintended direct paths to protected subnetworks.
- [ ] Keep records (logs) of boundary failure events, changes in interface status, and when policies block or drop traffic; send these logs to a security information and event management (SIEM) system for correlation.
- [ ] Run controlled failure tests (stop the service, bring down the interface, and fail over the high-availability system) and record evidence that unauthorised access and unauthorised release of information do not occur.


---

#### SC-7.19 — Block Communication from Non-organizationally Configured Hosts (Enhancement)

This requirement is about preventing instant messaging and video-calling software that individual users or outside service providers have set up from connecting to your organisation’s network, unless your organisation has clearly approved that software for a specific, permitted purpose. Without this, someone could install an unapproved messaging or calling app and use it to share information inappropriately, receive unwanted messages, or connect to services your organisation has not checked—creating an easy route for data loss or unwanted access.

To meet this expectation, your organisation must keep an up-to-date list of:
- instant messaging and video conferencing clients that are set up independently by users, and
- which clients are approved by the organisation for authorised uses.

Your organisation must then apply controls that block both incoming and outgoing messages and calls for the independently configured clients. The organisation must document how this protection is applied, keep evidence that the blocking took place, and include the approach in its system plans so it can be demonstrated and enforced consistently.

##### Default-deny IM/video traffic for non-approved clients (inbound/outbound)

- Category: Software
- Priority: Critical

###### WHAT
Implement a boundary enforcement capability that **blocks incoming and outgoing communication traffic** for **communication clients** that are **set up independently by end users and external service providers**, while allowing only **organisation-approved clients** that perform **authorised functions**.

###### WHY (control requirement)
SC-7(19) enhancement requires blocking **both incoming and outgoing** traffic between the organisation-defined set of **communication clients** (parameter: `sc-07.19_odp`) that are **set up independently by end users or external providers**. The guidance makes clear this **does not** apply to clients set up by the organisation for **authorised functions**.

###### HOW (specific steps/approach)
1. **Create an authoritative approved list (allowlist)** of organisation-approved instant messaging (IM) and video clients and their managed configuration profiles (for example: approved application versions, managed tenant/account, and approved destination patterns such as conferencing domains/regions).
2. **Identify endpoints/clients at the network boundary** using enterprise information (for example: device management status, user group, and—where available—application identity from proxy/secure gateway monitoring). Treat any client that does not match the approved list as **independently configured** for enforcement purposes.
3. **Apply “default block” at the edge** using an application-aware firewall, secure web gateway, cloud firewall, or zero trust network access (ZTNA) policy:
   - Add **incoming block** rules to stop unsolicited IM/video signalling and media traffic reaching endpoints running non-approved clients.
   - Add **outgoing block** rules to stop non-approved clients from starting IM/video signalling and media traffic to external services.
   - Add **explicit allow** rules only for organisation-approved clients (and only to approved destinations/tenants where feasible).
4. **Provide two-way logging and evidence**: configure the enforcement point to record both **blocked incoming** and **blocked outgoing** attempts with enough information for audit (time, source/destination, the client/application identity signal used, the rule that matched, and action=block).
5. **Manage changes operationally**: every new approved IM/video client (or new approved destination/tenant) must go through configuration/change management, updating the approved list and test cases.

###### WHO
- **Network/Security Engineering Lead**: designs and implements edge enforcement rules and logging.
- **Endpoint Management Lead (for example, mobile device management (MDM)/endpoint detection and response (EDR))**: provides device posture and application-identity signals and maintains managed client configurations.
- **Information Security / Compliance Owner**: owns the approval process for authorised IM/video clients and checks audit evidence.

###### Acceptance criteria
- For endpoints running **non-approved/independently configured** IM/video clients, **both incoming and outgoing** IM/video traffic is **blocked** at the boundary.
- For endpoints running **organisation-approved** IM/video clients for **authorised functions**, required IM/video connectivity works (within approved destinations/tenants).
- Enforcement logs show **blocked events** for both incoming and outgoing traffic, with auditable rule matches, and are kept according to the organisation’s logging retention requirements.
- The approved list and enforcement policy are demonstrably up to date (for example: versioned and controlled through change management) and are updated when authorised clients/destinations change.

###### Actions Required for Compliance

- [ ] Define and publish an organisation-approved list of permitted instant messaging and video clients, and the managed configuration profiles for each client.
- [ ] Set up endpoint (device) and client type classification at the network edge, using device status (posture), the user’s group, and any available application identity information.
- [ ] Set up edge enforcement using an application-aware firewall, secure gateway, or zero trust network access (ZTNA) with “deny by default” rules. Block any instant messaging (IM) and video traffic that is not approved, for both incoming (inbound) and outgoing (outbound) connections.
- [ ] Where possible, create clear “allow” rules only for IM and video clients that the organisation has approved, and only for approved destinations or tenants.
- [ ] Set up and centralise logging for all blocked inbound and blocked outbound instant messaging and video attempts, including the rule-matching details needed for audit purposes.
- [ ] Set up change control so that when new authorised clients or destinations are approved, the system updates its approved lists, enforcement rules, and test cases.


---

#### SC-7.20 — Dynamic Isolation and Segregation (Enhancement)

This requirement is about being able to quickly and selectively stop specific external services and supplier connections from reaching the rest of your systems when you need to—without shutting everything down.

In real life, the risk is that an external service of unclear or questionable origin, or one that becomes compromised or malfunctions, could connect back into your internal systems and cause wider damage. This increases the chance of data loss or service disruption.

To meet this expectation, the organisation must:
- keep a clear, up-to-date list of the exact third-party services and other externally provided components that must be isolated;
- document how isolation will work in practice, including which connections or data exchanges are blocked;
- ensure the system can apply and remove this separation during normal operations, as needed.

The organisation must also:
- have written procedures that match its boundary protection approach;
- configure and document the relevant settings;
- include this information in its security planning and architecture records; and
- keep audit evidence showing when isolation actions (and any reversals) are carried out by authorised people or systems.

##### Dynamic quarantine of third-party integrations via policy enforcement

- Category: Software
- Priority: Critical

###### WHAT
Set up a capability to **dynamically isolate the specified third-party and externally sourced components** ({{ param, sc-07.20_odp }}). This means selectively blocking those components from starting or receiving connections and exchanging data with other internal system components.

###### WHY (control requirement)
NIST SP 800-53 **SC-7(20)** enhancement requires: *“Provide the capability to dynamically isolate {{ insert: param, sc-07.20_odp }} from other system components.”* The goal is to reduce the attack surface and limit impact if an external component is compromised or malfunctions.

###### HOW (specific steps/approach)
1. **Create and keep an up-to-date isolation inventory** for each vendor or external integration listed in {{ param, sc-07.20_odp }}. For each entry, record: integration name, the owning service or application, the identity used (for example, workload identity/service principal), source and destination endpoints, protocols and ports, and the enforcement points that control traffic (for example, zero trust network access/secure access service edge policy, firewall/egress gateway, service mesh).
2. **Define the isolation design** as a clearly documented “quarantine” state for each integration:
   - block by default all initiation and response traffic between the external component and internal components;
   - allow only the specific exceptions that are required (for example, health checks to monitoring endpoints), and ensure exceptions are limited to the required destinations and ports.
3. **Put the enforcement in place at the network or access boundary** using centrally managed rules that can be switched on and off during operation:
   - Use **zero trust network access/secure access service edge (ZTNA/SASE)** or an equivalent access gateway policy to block vendor identities from reaching internal destinations during quarantine.
   - Apply **outbound controls** (domain name system filtering and firewall/egress deny rules) so internal systems cannot reach the quarantined external component when isolation is enabled.
   - If applicable, enforce at the **service mesh** or **application gateway** layer for internal-to-internal traffic and application programming interface (API) traffic.
4. **Enable dynamic isolation and reversal** using an automated control system:
   - Provide an operational trigger (for example, an incident response action) that switches the integration’s policy profile to **quarantine**, and later restores the previously approved policy.
   - Ensure reversal returns to the last known safe configuration (safe rollback) and does not require manual changes to individual rules.
5. **Make the isolation capability auditable**:
   - Send audit events to the **security information and event management (SIEM)** system for every isolation enable or disable action, including: integration identifier, affected endpoints, date and time, and actor identity (a person or an automated system/service).
   - Link policy changes to change records or tickets where your governance requires it.
6. **Include this in security planning and architecture records**:
   - Record the isolation inventory, quarantine state definition, enforcement points, and operational runbooks in the system’s security architecture and security plan documents.

###### WHO (role responsible)
- **Security Architect / Security Engineering Lead**: defines the quarantine state and isolation design; ensures it aligns with the chosen boundary protection approach.
- **Platform/Network Engineering (ZTNA/SASE/Firewall/Service Mesh owners)**: implements the enforcement points and the policy switching.
- **Security Operations Centre (SOC) / Incident Response Lead**: triggers isolation during incidents and checks that service is restored correctly.
- **System Owner / Authorising Official (where applicable)**: approves the isolation inventory and any exceptions.

###### Acceptance criteria
- For every integration in {{ param, sc-07.20_odp }}, there is a documented inventory entry that maps it to the enforcement points and the exact traffic scope.
- When quarantine is enabled for a listed integration, attempts to communicate with internal components are blocked in line with the defined quarantine state (default deny, with only approved exceptions).
- When quarantine is disabled, communication returns to the previously approved state without needing manual rule-by-rule changes.
- Every enable or disable action produces an audit record containing the integration identity, affected scope, date and time, and actor identity, and these events are sent to SIEM.
- The isolation design and operational runbooks are recorded in the system’s security planning and architecture documentation.

###### Actions Required for Compliance

- [ ] Create an isolation inventory that maps each `{{ param, sc-07.20_odp }}` integration to the user identities involved, the devices (endpoints) it connects to, the communication methods (protocols and ports), and the points where access is enforced.
- [ ] Set up a separate quarantine state for each integration (default to blocking everything, except for explicitly approved exceptions) and document how the isolation works.
- [ ] Set up centrally managed, runtime-switchable rules to enforce policy for each integration (for example, zero trust network access (ZTNA) / secure access service edge (SASE) and outbound traffic, Domain Name System (DNS) controls).
- [ ] Automate turning isolation on and off, with a safe rollback back to the last approved policy profile.
- [ ] Set up security information and event management (SIEM) audit logs for every time an isolation feature is turned on or off, recording the integration identity, scope, time of the event, and the identity of the person or system that triggered it.
- [ ] Publish and keep operational runbooks up to date, and update security planning and architecture records to reflect the isolation capability.


---

#### SC-7.21 — Isolation of System Components (Enhancement)

This expectation is about placing the organisation’s most important computer systems into separate, protected areas so they cannot freely communicate with each other. It matters because, if mission systems, the databases they depend on, and the tools used to manage and monitor them are all reachable from the same places, an attacker—or a serious mistake—could move from one area to another, spread harm, or access sensitive information more easily.

To meet this requirement, the organisation must clearly identify and document which mission application servers, database servers, and management or administrative access points need to be separated, and explain that the aim is to prevent unauthorised information moving between them while still allowing stronger protection for the most critical systems. It must then use suitable boundary protections—such as firewalls, gateways, or equivalent network separation—to limit the allowed communication routes so that only authorised connections are possible. The organisation must also record how this separation is designed, set up, and managed in its security plans and procedures.

Finally, it must keep evidence that the separation is actually enforced and regularly reviewed, including audit records showing activity related to boundary protection.

##### Zone-based boundary protection for mission, database, and admin

- Category: Software
- Priority: Critical

###### WHAT
Put in place enforced boundary protection that separates the organisation-defined **system components** (mission application servers, database servers, and management/administrative interfaces) so they cannot freely communicate. Only the information flows that are required should be allowed between them.

###### WHY (control requirement)
SC-7(21) enhancement requires: **“Employ boundary protection mechanisms to isolate {{system components}} supporting {{missions and/or business functions}}.”** The guidance explains that isolation reduces **unauthorised information flows** and allows **stronger protection** for the selected components.

###### HOW (specific steps/approach)
1. **Define the separation boundaries** by mapping each component to its role and network location (for example, mission tier subnet/VLAN, database tier subnet/VLAN, management/admin subnet/VLAN). Include the specific **missions/business functions** supported by each separated component.
2. **Create separate security zones** (separate physical networks/subnetworks or logically separated using equivalent methods) for:
   - Mission processing (mission application servers)
   - Data storage/retrieval (database servers)
   - System administration/monitoring (management/administrative interfaces)
3. **Install boundary protection at each zone boundary** (routers/gateways/firewalls or equivalent cross-domain devices). Make sure these boundary devices are the main points where traffic must pass between zones.
4. **Use deny-by-default with clear allow rules** so only the required flows are permitted. For example:
   - Mission → Database: only the database ports/protocols the application needs
   - Management → Operational components: only the specific admin/monitoring endpoints, ports, and source hosts needed (for example, a dedicated jump/bastion host or admin monitoring collectors)
   - Block all other cross-zone traffic (including paths that could be used to move laterally)
5. **Apply stronger protection to selected components** by tightening the rules for the management zone (for example, restrict management access to a dedicated admin subnet/jump host, limit allowed protocols, and restrict destinations to only the required management agents/services).
6. **Keep records and proof that enforcement is in place**, by retaining:
   - The zone/component mapping and boundary design (architecture/system documentation)
   - The firewall/gateway rule sets (current and versioned)
   - Change approvals and periodic review records showing the boundary rules still match the required information flows.

###### WHO
- **System/Network Architect**: defines the zones, boundary design, and the required traffic plan.
- **Infrastructure/Network Engineering**: implements the firewall/gateway rules and zone routing.
- **Security Engineering/Compliance**: checks the rules against the required traffic plan and maintains audit-ready evidence.
- **Change Manager**: ensures boundary changes follow the organisation’s change management process.

###### Acceptance criteria
- The mission application servers, database servers, and management/administrative interfaces are each placed into their defined separated zones.
- Boundary devices enforce **deny-by-default** between zones, with **only the required allow rules** for the defined missions/business functions.
- Traffic into the management zone is more restricted than the operational mission-to-database traffic (with clearly tighter boundary rules).
- Evidence is available showing the implemented rule sets, the component-to-zone mapping, and review/change records confirming ongoing enforcement.

###### Actions Required for Compliance

- [ ] Document which mission application servers, database servers, and management or administrative interfaces are located on which networks, and what role each one plays.
- [ ] Set up separate security zones for (1) mission processing, (2) storing and retrieving data, and (3) system administration and monitoring.
- [ ] Set up boundary protection (firewalls, gateways, and cross-domain devices) at every zone boundary so that all traffic moving between zones must pass through that boundary.
- [ ] Set up “deny by default” rules and then add clear “allow” rules only for the specific ports and network protocols that are required between each zone.
- [ ] Limit access to the management zone to only approved source computers (for example, jump servers, bastion hosts, or admin collectors) and only the management and monitoring endpoints that are required.
- [ ] Publish and keep the current firewall and gateway rule sets, the required traffic matrix, and approved change records (with version numbers) as audit evidence.
- [ ] Carry out an initial and regular review (with supporting evidence) to confirm that the boundary rules still match the defined missions or business functions and the required data flows.


---

#### SC-7.22 — Separate Subnets for Connecting to Different Security Domains (Enhancement)

This requirement is about keeping different types of information in separate “network areas” so they cannot be mixed up by accident. In everyday terms, it means systems that handle different security levels—for example, more sensitive information versus less sensitive information—must not use the same network space. Instead, each security level must have its own separate network segment.

Without this separation, a device that handles sensitive information could become accessible from the wrong part of the organisation. That increases the risk of unauthorised access, data being leaked, or mistakes spreading from one area to another.

To meet this expectation, the organisation must:
- identify which systems belong to each security domain,
- set up separate subnets for each domain, and
- ensure systems use the correct subnet.

The organisation must also document the network design, how protection is applied at the boundaries between these areas, the relevant system architecture and configuration settings, and keep records showing the separation is in place and remains correct over time. These documents must be available for review.

##### Separate subnets per security domain with enforced routing

- Category: Software
- Priority: Critical

###### WHAT
Set up separate network address spaces (separate subnets) for systems in different security domains, and limit traffic between those domains to approved routes only.

###### WHY (control requirement)
SC-7(22) enhancement requires: **"Implement separate network addresses to connect to systems in different security domains."** The guidance explains that splitting systems into sub-networks helps ensure the right level of protection for network connections between different security domains, where information may have different security categories/classification levels.

###### HOW (specific steps/approach)
1. **Define security domains and map systems**: Use the organisation’s data classification and security domain model to identify which application components (presentation, application, data, administration, integration services, vendor access points) belong in each security domain.
2. **Create a non-overlapping IP/subnet plan**: Assign dedicated, non-overlapping Classless Inter-Domain Routing (CIDR) ranges for each security domain (for example: Prod-Confidential, Prod-Internal, Admin, Test, Disaster Recovery (DR), Vendor/De-militarised Zone (DMZ) where applicable). Record the intended default gateways and any required routing boundaries.
3. **Enforce separation at network control points**: Configure Layer 3 (L3) boundary devices (firewalls/routers/load balancers with L3 controls) so that **traffic between security domains is blocked by default**, and only explicitly permitted using **source and destination subnet ranges** (not just hostnames or job roles).
4. **Place systems only within their domain network**: Configure each system’s network interface card (NIC) or interface IP address, subnet mask, and gateway so it sits only in its domain’s subnet. If routing is used, ensure routing rules and segmentation (for example, Virtual Routing and Forwarding (VRF) instances and Virtual Local Area Networks (VLANs)) prevent unintended connections across domains.
5. **Document the network design and enforcement**: Produce an audit-ready network diagram and IP plan showing which domains map to which subnets, where enforcement happens, and the approved traffic paths between domains.
6. **Keep evidence and detect changes**: Export and retain configuration evidence (for example, firewall rule sets, router/VRF/VLAN mappings, load balancer listener and network settings, and system network configuration baselines). Link any changes to the relevant change records. Add automated checks to detect drift in subnet assignments and references to boundary rules.

###### WHO (role responsible)
- **Network/Infrastructure Architect**: owns the domain-to-subnet IP plan and the network design.
- **Network Engineers**: implement VLAN/VRF and Layer 3 (L3) boundary configurations, and set system interface/network settings.
- **Application/Platform Engineers**: ensure application components are deployed into the correct subnets and do not change network placement.
- **Security/Compliance**: checks that documentation is complete and that evidence is retained for audit.

###### Acceptance criteria
- Every system/component has an IP address in the **correct security domain’s dedicated subnet**.
- Subnets for different security domains are **non-overlapping** and match the authoritative IP plan.
- Connections between security domains are **blocked by default**, with explicit allow rules that reference **subnet ranges** at the defined boundary points.
- Network diagrams and IP plan documentation clearly show domain-to-subnet mapping and enforcement points.
- Evidence is available for review: exported boundary device rules and system network configuration baselines, with change records showing controlled updates.

###### Actions Required for Compliance

- [ ] Identify and record the security area for each part of every application (the user interface, application logic, data, administration, integrations, and vendor access).
- [ ] Create a non-overlapping Internet Protocol (IP) address plan that maps each security domain to its own dedicated subnet(s).
- [ ] Set up Layer 3 boundary controls (firewalls, routers, and virtual routing and forwarding instances) to block all traffic by default and only permit traffic that matches explicitly approved source and destination subnet ranges.
- [ ] Update the system’s network settings so that each component’s network connections and gateway only place it within the subnet for its own domain.
- [ ] Create an audit-ready network diagram and IP address plan that show which domains map to which subnets, and list the approved traffic connections between different domains.
- [ ] Carry out checks for configuration drift (unexpected changes) and keep exported evidence—such as boundary rules, virtual routing and forwarding (VRF) and virtual local area network (VLAN) mappings, and system network baselines—linked to the relevant change records.


---

#### SC-7.23 — Disable Sender Feedback on Protocol Validation Failure (Enhancement)

This requirement is about keeping your system from giving information back when it receives a badly formed message. If an incoming message does not follow the expected format, the organisation must not send any reply or explanation back to the sender about why it was rejected.

This matters because detailed rejection messages can help attackers understand how your message checks work, making it easier for them to create messages that pass.

To meet this requirement, the organisation should set up its entry-point protections and related procedures so that “no feedback” is used for message format problems only, not for other types of errors. The behaviour should be built into the relevant software or hardware at the system boundary.

The organisation should also clearly document this approach in its security policy, boundary protection procedures, system design and architecture, and record the exact configuration settings.

Finally, it must keep audit records showing that malformed messages are handled without format-validation-specific feedback, while correctly formed messages still receive the normal outcome.

##### Silent reject protocol-format failures at boundary

- Category: Software
- Priority: Critical

###### WHAT
Configure all externally reachable boundary components (for example, application programming interface (API) gateway, reverse proxy, web application firewall (WAF), load balancer, webhook entry point, and any email/simple mail transfer protocol (SMTP) gateway) so that when an incoming message fails **protocol format/structure checks**, the system **does not provide feedback to the sender**. For these failures, the system must **not** return validation-specific details (for example, hints about individual fields or schemas, “invalid JSON” style diagnostics, or rule identifiers). Instead, it must **drop or close** the connection, or return a **generic, non-specific** rejection.

###### WHY (control requirement)
Security Control SC-7(23) requires: **“Disable feedback to senders on protocol format validation failure.”** The guidance explains that hiding feedback for protocol format failures prevents attackers from learning how the checks work.

###### HOW (specific steps/approach)
1. **List all boundary entry points** for each protocol the application exposes (hypertext transfer protocol secure (HTTPS)/representational state transfer (REST), webhooks, client-to-server endpoints, SMTP/internet message access protocol (IMAP) if applicable, and any message intake endpoints).
2. **Apply protocol-aware validation at the boundary** (where supported) so that format/structure problems are detected before application code generates responses.
3. **Set handling for protocol format/structure validation failures to “silent reject / generic rejection”**:
   - HTTP/API/webhooks: return a standard status with an **empty response body** or a **fixed generic message** that does not mention validation rules, schema names, missing fields, or parsing errors.
   - Connection-based protocols: close the connection without application-level explanation where feasible.
   - Redirect/error-page paths: ensure no validation-specific redirect or error page is produced.
4. **Limit the “no feedback” behaviour to protocol format/structure failures only** (for example, malformed JSON, incorrect content type, or invalid message framing). For other error types (authorisation failures, business-rule rejections, rate limiting), keep the organisation’s normal handling.
5. **Add boundary-level audit logging** for evidence (log internally, not to the sender): source internet protocol (IP) address, endpoint, time, protocol, and a broad category such as “protocol format validation failure”, without including the specific validation rule details in the response.
6. **Test and confirm** using negative test cases (malformed payloads, missing required structural elements, invalid content type, invalid message framing) to ensure responses contain no validation-specific feedback, while valid requests still receive the normal outcome.

###### WHO (role responsible)
- **Boundary/Platform Engineer** (API gateway/WAF/reverse proxy configuration)
- **Application Security Engineer** (defines what counts as “protocol format validation failure” and approves the response-suppression approach)
- **Quality Assurance (QA)/Test Engineer** (runs negative and positive tests and records evidence)

###### Acceptance criteria
- For every externally reachable endpoint/protocol, when a request fails **protocol format/structure validation**, the sender receives **no validation-specific feedback** (no per-field/schema/rule hints; no parsing diagnostics; no explanatory error body).
- The behaviour is enforced at the **boundary** (responses are suppressed before application-layer error handling can reveal details).
- Valid requests are processed normally and receive normal responses.
- Internal logs/audit records exist showing malformed requests were classified as protocol format validation failures.
- Evidence is provided showing the above through automated tests and configuration screenshots/exports.

###### Actions Required for Compliance

- [ ] List every externally accessible entry point and the communication methods (protocols) that the application uses at its boundaries.
- [ ] Set up the API gateway, web application firewall (WAF), and reverse proxy to detect and block requests with invalid protocol format or structure at the point where traffic enters the system (the edge).
- [ ] For failures during format and structure checks at the edge, either silently reject the request, or return a fixed generic rejection message with an empty or non-descriptive response body.
- [ ] Remove or disable any validation-specific error messages, redirects, or enhanced error templates that apply when inputs are malformed.
- [ ] Set up internal audit logging that records protocol format validation failures, without revealing the specific validation rules to the sender.
- [ ] Run both negative and positive test cases to confirm that no validation-related messages are returned, and that valid requests still succeed.


---

#### SC-7.24 — Personally Identifiable Information (Enhancement)

This expectation is about making sure that any system that handles people’s personal information is used in a controlled, approved way, and that the information is protected from misuse. Without these rules, personal data could be collected for the wrong reasons, accessed by the wrong people, sent or stored insecurely, kept longer than necessary, or shared in ways that breach privacy commitments—causing real harm to individuals and creating legal and reputational risk for the organisation.

The organisation must apply approved handling rules to every type of personal information it processes: collect, use, store and share it only for authorised purposes; protect it by encrypting it both while it is being transferred and while it is stored; allow access only to the minimum permissions needed; record and review every access; keep it only for the time set out in policy; and delete it when it is no longer needed.

It must also monitor that only permitted processing happens at the system’s entry and exit points and at key internal handover points, document any exceptions, and regularly review and remove exceptions that are no longer supported.

##### Enforce approved PII processing rules with monitored exceptions

- Category: Software
- Priority: Critical

###### WHAT
Put in place a system that can be checked (audited) to enforce **approved personal data (PII) handling rules**. These rules cover: authorised purpose, encryption while data is moving and when it is stored, least-privilege access, logging, how long data is kept, and how it is deleted. Also, continuously check that only **permitted PII handling** happens at system entry and exit points, and at key internal handover points.  

Keep a controlled process for exceptions: if anything differs from the rules, it must be **recorded, approved, reviewed on a regular schedule, and removed when it is no longer needed**.

###### WHY (control requirement)
SC-7(24) (Enhancement) requires that for systems that process PII, the organisation applies, checks for, and records **exceptions to handling rules**. This ensures PII is processed only in line with agreed privacy requirements. This includes controlling permitted handling at entry/exit points and key internal boundaries, and making sure exceptions are reviewed and removed when they are no longer supported.

###### HOW (specific steps/approach)
1. **Create and maintain a PII inventory and data-flow map** for the application. This should show: the types of PII, where it is collected, stored, processed, and shared, and which interfaces or data flows carry PII.
2. **Define “PII handling rules” that can be enforced automatically**. These should match the organisation’s PII handling requirements, including: authorised purposes; encryption while data is moving and when it is stored; least-privilege access; audit logging; retention time periods; and deletion or anonymisation when the data is no longer needed.
3. **Enforce the rules at technical enforcement points**:
   - **Encryption while data is moving**: require Transport Layer Security (TLS) for all external and service-to-service connections; block non-TLS or weak encryption at gateways and load balancers.
   - **Encryption when data is stored**: ensure databases and object storage used for PII are configured to encrypt using enterprise key management.
   - **Least privilege**: use role-based access control (RBAC) linked to enterprise identity; limit service accounts; use just-in-time or conditional access for privileged actions.
   - **Logging**: turn on audit logging for PII access and processing activities; send logs to security information and event management (SIEM) and monitoring tools with tamper-resistant retention.
   - **Retention and deletion**: use data lifecycle controls (for example, time-to-live and partitioning for databases; object lifecycle policies) and scheduled deletion or anonymisation jobs that are checked against the retention policy.
4. **Monitor permitted PII handling at boundaries and key internal handover points**:
   - Set up monitoring on **application programming interface (API) gateways and web application firewalls (WAFs)** and on data export paths to detect and alert on unauthorised PII flows (for example, destinations, endpoints, or actions not covered by the authorised-purpose mapping).
   - Set up monitoring on **internal handover points** (for example, message bus topics or queues, extract-transform-load (ETL) jobs, and replication or export services) listed as “key internal boundaries”.
   - Keep evidence: logs and monitoring data showing permitted processing events and any blocked or denied attempts.
5. **Create an exception process** for any deviation from the handling rules:
   - Require an approval record that links the exception to: the affected PII elements and data flows, the specific rule(s) being overridden, the authorised purpose, compensating controls, and an expiry date.
   - Ensure exceptions are implemented as time-limited configuration changes (for example, feature flags or policy overrides) with automatic expiry.
6. **Review and remove exceptions on a defined schedule**:
   - Run regular reviews comparing active exceptions against the current system design and privacy requirements.
   - Remove exceptions when they are no longer supported, and record evidence that the exception has been closed.

###### WHO
- **Application Owner / Data Protection Lead**: owns the PII inventory, the mapping of authorised purposes, and exception governance.
- **Security Engineering / Platform Team**: implements enforcement points (gateway/WAF, identity and authorisation, encryption settings, logging, and retention/deletion automation).
- **SIEM/Monitoring Team**: ensures boundary monitoring rules, alerting, and evidence retention.
- **Change Manager / Change Advisory Board (CAB)**: ensures exception-related configuration changes follow approved change control.

###### Acceptance criteria
- A current **PII inventory and data-flow map** exists and can be traced to application components and interfaces.
- Technical enforcement shows that **encryption while data is moving and when it is stored**, **least-privilege access**, and **audit logging** are in place for PII processing paths.
- **Retention and deletion/anonymisation** are implemented and can be verified (with evidence of lifecycle controls and deletion outcomes).
- Boundary and internal handover monitoring is in place for all identified key internal boundaries, producing auditable evidence of permitted processing and blocked or denied events.
- Any deviations from handling rules are managed through an **exception process** with documented approval, scope, authorised purpose, expiry, and regular review; exceptions are removed when no longer supported.

###### Actions Required for Compliance

- [ ] Create and keep up to date a record of all personal data (PII) used by the application, and a map showing how that data moves through the system—covering every point where personal data enters or leaves the application, and every internal handover point.
- [ ] Put the organisation’s personal data (PII) handling rules into clear, enforceable application and platform settings, covering authorised use, encryption, least privilege access, logging, how long data is kept, and how it is deleted.
- [ ] Set up and check that data is encrypted while it is being sent through gateways and load balancers, and that all personally identifiable information (PII) stored in databases is encrypted when stored, using the organisation’s enterprise key management system.
- [ ] Set up and centralise audit logs for access to and processing of personal information (PII), and ensure the logs are sent to security information and event management (SIEM) with tamper-resistant storage for a defined retention period.
- [ ] Set up automated rules to keep data for the required period and then delete or anonymise it in line with the retention policy, and confirm that deletions worked by keeping test evidence.
- [ ] Monitor the boundaries at external entry points and the agreed key internal handover points to detect unauthorised processing of personal information (PII) and to produce records that can be audited (auditable telemetry).
- [ ] Set up an exception process that allows time-limited policy overrides, with approval records that clearly state the scope, which personal data (PII) elements or rules are affected, the authorised reason for the override, and when it expires. Then review and remove these exceptions on the agreed schedule.


---

#### SC-7.25 — Unclassified National Security System Connections (Enhancement)

This expectation is about making sure your unclassified national security systems do not connect directly to outside networks without checks at the network boundary. If systems can connect straight to places such as the public internet, some traffic could avoid safeguards. That makes it easier for malicious activity, data to be leaked, or unauthorised access to happen without being noticed or controlled.

To meet this requirement, the organisation must:
- identify which in-scope systems and services are inside its network boundary; and
- prohibit any dedicated direct connection from those systems to external networks unless the connection goes through Department of Defense (DoD)-approved firewall or gateway devices.

These approved devices must be set up to control how network addresses are handled and to inspect the actual application data being sent and received—not just basic connection information.

The organisation must also:
- stop any technical workaround that would bypass these devices;
- document how boundary protection works in its plans and designs; and
- keep records showing that the approved devices mediate external traffic.

##### Mediated egress chokepoints for unclassified national security systems

- Category: Software
- Priority: Critical

###### WHAT
Prevent any in-scope **unclassified national security system** from making a **direct connection** to an external network unless all communications go through the organisation’s **boundary protection device**.

###### WHY (control requirement)
SC-7(25) requires: **“Prohibit the direct connection of {{sc-07.25_odp.01}} to an external network without the use of {{sc-07.25_odp.02}}.”** A “direct connection” is a dedicated physical or virtual link that avoids the boundary controls; therefore, the system must not be able to reach external networks through any bypass route.

###### HOW (specific steps/approach)
1. **Identify in-scope systems/services**: Mark all assets (computers, virtual machines, containers, software-as-a-service integrations, and service accounts) that meet **{{sc-07.25_odp.01}}**. For each one, record where it sits on the network (subnet/VLAN/tenant/route domain) and which environment it is in (production/test/disaster recovery).
2. **Set approved exit points (“egress chokepoints”)**: Choose one or more **Department of Defense (DoD)-approved firewall/gateway devices** as the only allowed way out to external networks for those in-scope network areas. Configure routing so each in-scope area has only one default route to the approved exit point (or the equivalent cloud routing/egress gateway setup).
3. **Enforce boundary mediation**: Configure **{{sc-07.25_odp.02}}** to provide **managed network address translation (NAT)** and **application-layer inspection** for the relevant outbound traffic from in-scope sources. Where possible, use clear allow-lists for each application/protocol, and block any traffic that does not match the approved exit policy.
4. **Stop bypass routes**: Block or remove any alternative ways out that could create a “direct connection” bypass (for example: alternate default routes, routing exceptions, unmanaged virtual private network (VPN) or software-defined wide area network (SD-WAN) direct breakout, incorrect cloud egress settings, direct vendor connections, or routing that skips the approved gateway). Confirm this through configuration reviews and network path testing.
5. **Automate change control and keep proof**: Use configuration management and “policy as code” so NAT and application-layer inspection settings cannot be removed without an approved change. Regularly check that the gateway device identity and settings match an approved baseline, and keep records showing mediation (source subnet/host, destination, gateway device identity, NAT translations, and inspection results).
6. **Operational verification**: Run scheduled tests from representative in-scope systems to approved external destinations, and confirm that the gateway logs show the traffic passed through the approved boundary device within an expected time window.

###### WHO (role responsible)
- **Network Security Engineering Lead**: designs the approved exit points, routing restrictions, and boundary device settings.
- **System Owner / Application Owner**: ensures in-scope tagging is correct and that outbound network needs are documented for allow-listing.
- **Cloud/Infrastructure Engineer (if applicable)**: implements route-table/egress gateway controls and removes any bypass routes.
- **Security Operations (SOC) / Monitoring Lead**: checks log evidence, raises alerts for bypass indicators, and supports verification testing.

###### Acceptance criteria
- Every in-scope asset ({{sc-07.25_odp.01}}) has an enforced network path to external networks that goes through the approved **{{sc-07.25_odp.02}}** (no other exit routes exist).
- For outbound traffic from in-scope sources, the boundary device performs **managed NAT** and **application-layer inspection** according to the configured policy.
- Any attempt to use alternative exit paths (routing changes, tunnels, or direct breakout setups) is blocked or cannot reach external destinations without passing through the approved boundary device.
- Evidence is available showing: (a) the network design/routing configuration that provides a single mediated exit path, (b) the boundary device configuration showing NAT plus application-layer inspection enabled, and (c) retained gateway logs demonstrating mediation for representative external connections.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date official inventory label for every asset that meets **SC-07.25_ODP.01**, and assign each one to its network segment and route domain.
- [ ] Using **sc-07.25_odp.02**, identify and mark the approved “exit points” (egress chokepoints). Then configure **single-path routing**—using the default route, **virtual routing and forwarding (VRF)**, and the **egress gateway**—for the segments that are in scope.
- [ ] Set up the **sc-07.25_odp.02** policies to allow managed network address translation (NAT) and inspection of outbound traffic at the application level for in-scope outgoing connections.
- [ ] Set up clear allow-lists of which external destinations and network protocols are permitted, and block any traffic that does not match the approved outbound (egress) policy.
- [ ] Remove or block any ways to bypass the normal route (for example, alternate default routes, exceptions in policy-based routing, direct tunnel or software-defined wide area network (SD-WAN) breakouts, and unmanaged virtual private network (VPN) or direct vendor connections), and confirm everything works as intended by testing the network paths.
- [ ] Automate checks to prevent unauthorised changes to network address translation (NAT) and inspection settings, and produce evidence suitable for audits using gateway configuration exports and logs.
- [ ] Run scheduled checks on representative in-scope systems and confirm that the matching gateway mediation records are logged within the expected time window.


---

#### SC-7.26 — Classified National Security System Connections (Enhancement)

This requirement is about preventing a highly sensitive, classified system from being connected directly to the outside world without proper safeguards in place. If a classified system could connect straight to an external network, such as the internet, it would be harder to control what information goes in or out. This increases the risk of unauthorised access, data being leaked, or harmful activity passing through without being noticed.

To meet this expectation, the organisation must clearly define what it considers a “direct connection” and what it means by an “external network”. It must then ensure that any classified system that needs outside connectivity can only reach external networks through an organisation-approved cross-domain solution. This solution must include managed interface boundary protection, and there must be no hidden routes that bypass it.

The organisation must also:
- document how the boundary protection is set up and operated
- keep records of the system design and architecture showing the approved connection path
- record the relevant configuration settings
- include this requirement in the system security plan
- keep audit evidence that the protection is working
- assign named responsibilities to the right staff for oversight, implementation, and compliant design

##### Enforce approved CDS boundary for classified external connectivity

- Category: Software
- Priority: Critical

###### WHAT
Prevent any direct physical or virtual connection from the classified national security system to any external network unless communications are handled through the organisation-approved **boundary protection device** ({{ insert: param, sc-07.26_odp }})—meaning an **approved cross-domain solution (CDS) with managed interface boundary protection**.

###### WHY (control requirement)
SC-7(26) requires that a classified national security system must not be directly connected to an external network without using the specified boundary protection device. A “direct connection” means a dedicated physical or virtual connection between systems. Boundary protection devices (for example, firewalls, gateways, and routers) and approved cross-domain systems must control and manage how information moves between networks.

###### HOW (specific steps/approach)
1. **Define and publish scope**: Write down what counts as a “direct connection” (dedicated physical or virtual links, network peering, site-to-site tunnels, direct virtual private network (VPN) connection termination, cloud virtual private cloud (VPC) peering, and similar arrangements) and what counts as an “external network” (any network outside the classified enclave or zone, including the Internet and partner networks). Make sure these definitions match how your teams request connectivity.
2. **Design the only permitted path**: Place the approved CDS at the boundary and require that all traffic between the classified environment and external networks uses it as the only entry and exit point (for example, a “single entry/exit” approach). Remove or disable any other paths that could allow bypass (such as direct Internet gateways, direct partner VPN termination on classified segments, unmanaged routing, or additional peering or tunnels).
3. **Control routing and lock down interfaces**: Set up routing so classified subnets can use only the CDS as their default route to external networks (for example, using virtual routing and forwarding (VRF) or route-table restrictions). Configure security rules so classified workloads can reach only the CDS interfaces and addresses, and only the explicitly approved ports and protocols.
4. **Use change-controlled guardrails**: Include CDS boundary configuration in your formal change and configuration management process. Use policy automation (or an equivalent approach) to ensure boundary rules are applied consistently and are reviewed and approved before changes take effect.
5. **Continuously confirm mediation**: Add checks to detect changes and verify traffic paths, so you can provide audit evidence that traffic from classified segments to external networks always goes through the CDS (for example, regular checks of routes, peering, and tunnels, and flow logs that show the CDS as the mediation point).

###### WHO (role responsible)
- **System Owner / Authorising Official (AO)**: Responsible for ensuring the classified system’s external connectivity design meets SC-7(26).
- **Network/Boundary Protection Engineering Lead**: Designs and implements the CDS boundary, routing restrictions, and interface restrictions.
- **Security Engineering / Compliance**: Maintains the definitions of “direct connection” and “external network”, checks the evidence, and carries out compliance review.
- **Change Management / Configuration Management Owner**: Ensures CDS boundary changes follow approved processes and produce records that can be audited.

###### Acceptance criteria (verifiable)
- No classified system has a dedicated physical or virtual connection to an external network that bypasses the approved CDS boundary protection device.
- Routing and interface controls ensure classified workloads can reach external networks only through the CDS (with no alternative default routes, peering, or direct tunnels/VPN terminations on classified segments).
- CDS boundary configuration is managed under change control and can be traced to approved design documentation.
- Audit evidence exists showing (a) the CDS is the point that mediates external traffic and (b) any configuration drift or unauthorised changes to routes, peering, or tunnels are detected and flagged.

###### Actions Required for Compliance

- [ ] Publish clear definitions for “direct connection” and “external network”, in line with your enclave or zone boundaries.
- [ ] Design the classified system network so that all connections to and from external networks pass through the approved CDS boundary protection device.
- [ ] Set routing rules so that any classified subnet can send traffic only through the CDS as its default (outgoing) next hop, and remove any other backup routes, peer connections, and tunnels.
- [ ] Set up network interface connections and firewall or gateway rules so that only pre-approved CDS-mediated data flows are allowed.
- [ ] Add the Clinical Decision Support (CDS) boundary settings to the organisation’s change and configuration management process, using peer review and keeping records that can be audited.
- [ ] Enable continuous checks to detect changes (drift) and verify the actual data flow/path, so you can prove the CDS remains the mediation point and raise alerts when there are signs of bypass.


---

#### SC-7.27 — Unclassified Non-national Security System Connections (Enhancement)

This requirement is about preventing your internal, non-national security services from having a direct, unfiltered route to the outside world. If an internal service can connect straight to the wider Internet (or other external networks) without going through the organisation’s approved firewall or gateway, it becomes much easier for harmful activity, data leaks, or unauthorised access to get through. This is because you lose control over, and visibility into, what is leaving and entering.

To meet this expectation, the organisation must:
- define what counts as a “direct connection”; and
- prohibit any dedicated physical or virtual link from unclassified, non-national security systems (for example, internal IT services not designated as national security systems) to external networks, unless all traffic first passes through an approved firewall or gateway.

The approved firewall or gateway must use managed routing and check traffic at the application level (not just basic network information).

The organisation must also:
- document how this boundary is built into system design and security plans;
- configure systems so that bypassing the gateway is not possible;
- assign named responsibilities; and
- keep evidence (such as audit records and configuration documentation) showing the gateway is used and performs the required checks.

##### Enforce approved gateway mediation for unclassified external links

- Category: Software
- Priority: Critical

###### WHAT
Prevent any dedicated physical or virtual link from the defined **unclassified, non-national security system** to an external network unless all traffic is handled through the organisation’s **approved boundary protection device**.

###### WHY (control requirement)
Control SC-7(27) requires the organisation to **block direct connections** of the specified system to external networks **without** using the specified **boundary protection device**. A “direct connection” is a dedicated physical or virtual link. The boundary protection device (for example, firewalls, gateways, or routers) must be the point that manages and controls communications.

###### HOW (specific steps/approach)
1. **Define “direct connection” in the system and network design** so it includes any dedicated tunnel, peering arrangement, private interconnect, fixed route path, or virtual link where the first external step is not the approved boundary protection device.
2. **Set up controlled entry and exit so the gateway is the only first step** for the unclassified, non-national security system:
   - Create and maintain network separation (for example, virtual routing and forwarding instances, virtual local area networks, or security zones) for the unclassified system.
   - Configure routing so that only the approved gateway is available as the next step to external networks. Remove or lock down any other ways to reach external networks, including:
     - alternative default routes,
     - bypass paths,
     - host-level default gateways,
     - alternative software-defined wide area network (SD-WAN) policies,
     - any direct network address translation (NAT) or direct exit rules that do not pass through the gateway.
3. **Configure the approved boundary protection device to manage traffic and inspect application behaviour**:
   - Turn on application-level inspection for the relevant protocols used by the application (for example, web traffic over HTTP(S), domain name system (DNS), and any other application protocols as applicable).
   - Ensure logging is enabled for session or traffic records and inspection results, in a way that is sufficient to prove that traffic is being mediated.
4. **Enforce changes using policy-based automation and change control**:
   - Manage gateway rules, routing settings, and inspection profiles using infrastructure automation (infrastructure-as-code), with peer review.
   - Add automated checks that block any change if any unclassified system network segment or host can reach external networks without passing through the gateway.
5. **Continuously verify with supporting evidence**:
   - Match the unclassified system’s source IP addresses and hostnames against the gateway logs to confirm that external connections are being mediated.
   - Raise alerts when traffic appears to external destinations without matching gateway log records.

###### WHO (role responsible)
- **Network Security Engineer / Security Architecture Lead**: define “direct connection”, design network separation and routing, and approve gateway inspection settings.
- **Platform/Infrastructure Engineer**: implement routing and network separation, and configure the gateway.
- **Change Manager / Configuration Manager**: enforce the policy-based automation workflow and manage any authorised exceptions.
- **Security Operations Centre (SOC) / Monitoring Engineer**: implement log matching and alerts to detect bypass attempts.

###### Acceptance criteria
- For the defined **unclassified, non-national security system**, there is **no dedicated route** to external networks where the first external step is not the approved boundary protection device.
- Routing and exit controls prevent alternative default routes and bypass exit paths (confirmed through configuration review and automated compliance checks).
- The approved boundary protection device performs **managed routing** and **application-level inspection** for the relevant application protocols.
- Evidence is available showing mediation: gateway logs show that external sessions from the unclassified system are present and can be matched to those sessions; bypass alerts are raised (or are shown to be impossible) during validation testing.

###### Actions Required for Compliance

- [ ] Define and publish the organisation’s technical definition of “direct connection” for the unclassified, non-national security system. This includes tunnels, peering, and static routes where the first external connection goes around the gateway.
- [ ] Divide the unclassified system into separate network areas (virtual routing and forwarding instances) and set up the routing rules so that the approved boundary protection device is the only route to any external networks.
- [ ] Remove or restrict any backup ways for traffic to leave the network—such as default gateway settings on hosts, alternate software-defined wide area network (SD-WAN) policies, or direct network address translation (NAT) and outbound (egress) rules—that could allow traffic to bypass the gateway.
- [ ] Set up the approved boundary protection device to use the agreed routing settings and application-level inspection profiles for the application’s relevant network protocols, and turn on inspection and session logging.
- [ ] Set up “policy-as-code” (using infrastructure-as-code) to define gateway rules, routing settings, and inspection profiles. Require peer review and run automated checks that confirm “gateway mediation required” compliance.
- [ ] Set up log correlation and alerts to identify any incoming external traffic from the unclassified system that does not have matching evidence that it passed through the gateway mediation process.


---

#### SC-7.28 — Connections to Public Networks (Enhancement)

This requirement is about ensuring the special on-premises gateway computer used for Secret and Confidential work is never directly connected to any public network, such as the Internet or any partner network that can be accessed from outside your organisation. If it were directly connected, attackers could potentially reach the gateway from outside your organisation, increasing the risk of unauthorised access, data theft, or disruption to sensitive services.

To meet this expectation, your organisation must set up and maintain the gateway so it has no dedicated direct connection to public networks. You must treat any dedicated link between the gateway and another system as a “direct connection”, and you must treat any publicly accessible network as “public”.

You should check in practice that the gateway’s network connections, firewall and routing settings, and real-world tests from outside your organisation all show that it is not directly reachable. You must also ensure that any network-related changes are reviewed and approved by the people responsible for boundary protection, so nothing accidentally creates a public connection over time.

##### Enclave gateway VM: prevent any direct public network attachment

- Category: Software
- Priority: Critical

###### WHAT
Ensure the on-premises dedicated enclave gateway virtual machine (DMZ-to-internal bridge) for Secret and Confidential workloads ({{ param, sc-07.28_odp }} = the gateway virtual machine) is **never directly connected** to any **public network** (the Internet or any organisational extranet that is publicly accessible). A “direct connection” includes any dedicated physical or virtual link between the gateway virtual machine and other systems.

###### WHY (control requirement)
SC-7(28) (enhancement) requires: **“Prohibit the direct connection of {{ insert: param, sc-07.28_odp }} to a public network.”** The control guidance defines a direct connection as a dedicated physical or virtual connection, and a public network as the Internet and publicly accessible extranets. Therefore, the gateway virtual machine must not be connected to any dedicated network segment/port group that provides a route to public networks.

###### HOW (specific steps/approach)
Put in place technical and operational safeguards that make public connection impossible by design, and detect and stop any change that would create a dedicated link to a public network.

1. **Network inventory and classification**: Keep an up-to-date, authoritative inventory showing every virtual network/port group/virtual local area network (VLAN)/segment used by the gateway virtual machine, classified as either *Public/Extranet-Public* or *Internal/Private*. This inventory must also list the upstream connectivity options that could create a dedicated route to the Internet or a public extranet.
2. **Remove/avoid public attachment at the hypervisor layer**: Configure the gateway virtual machine with **only** network interface cards (NICs) connected to *Internal/Private* virtual networks/port groups. Make sure there is **no** dedicated virtual link (no NIC attachment, no additional virtual NIC (vNIC), no secondary interface, no single root input/output virtualisation (SR-IOV) mapping, no port mirroring target, no management interface) to any *Public/Extranet-Public* segment.
3. **Enforce attachment restrictions**: Limit who can attach NICs or change port group/VLAN settings for the gateway virtual machine to a small group of privileged administrators. Changes must follow an approval process that includes sign-off from the boundary protection owner. This reduces the risk of accidental or unauthorised creation of a dedicated public link.
4. **Policy-as-code guardrails**: Add automated checks in infrastructure-as-code pipelines (for example, Terraform, Ansible, or continuous integration (CI)) that stop deployments if the gateway virtual machine is assigned to any network object labelled *Public/Extranet-Public* (including any future network created with that label).
5. **Drift detection and alerting**: Continuously monitor and alert on any change to the gateway virtual machine’s network connections (NIC-to-port group/VLAN mapping). If a change is detected, automatically isolate the virtual machine (for example, disable NICs or move it to a known internal-only port group) and raise a ticket for boundary protection review.
6. **Evidence via reachability validation (operational test)**: Run and record periodic external reachability tests from a controlled “outside” viewpoint to confirm the gateway virtual machine is not directly reachable through public routing paths. Although SC-7(28) focuses on preventing direct connections, this test provides audit-ready evidence that the restriction works in practice.

###### WHO (role responsible)
- **Infrastructure/virtualisation engineer**: Implements hypervisor network configuration and connection restrictions.
- **Security architect / boundary protection owner**: Defines the *Public/Extranet-Public* classification and approves exceptions.
- **DevOps/Platform engineering**: Implements policy-as-code checks and drift detection automation.
- **Security operations centre (SOC)/monitoring team**: Runs alerting, isolation response, and evidence collection.

###### Acceptance criteria (audit-ready)
- The gateway virtual machine has **zero** NICs/vNICs/virtual interfaces attached to any network segment/port group/VLAN classified as *Public/Extranet-Public*.
- Any attempt to change infrastructure to attach the gateway virtual machine to a *Public/Extranet-Public* network is **blocked** by automated pipeline policy.
- Drift detection shows **no** unauthorised network connection changes; any detected change triggers isolation and boundary protection review.
- External reachability tests (from an approved external viewpoint) show the gateway virtual machine is **not directly reachable** via public routing paths, and the results are kept as evidence.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, authoritative list that maps all virtual networks, port groups, and virtual local area networks (VLANs) that are relevant to gateways to either “Public/Extranet-Public” or “Internal/Private” classifications.
- [ ] Reconfigure the gateway virtual machine so that all network cards (NICs) and virtual network cards (vNICs) are connected only to internal/private network groups, and remove any interface that is connected to public or extranet-public network segments.
- [ ] Limit hypervisor permissions so only approved administrators can change the gateway virtual machine’s network card (NIC) connections to the correct port group and virtual local area network (VLAN), with sign-off from the boundary protection team.
- [ ] Set up “policy as code” checks in the infrastructure deployment process so that any change that assigns the gateway virtual machine (VM) to a **Public/Extranet-Public** network label is blocked.
- [ ] Set up continuous monitoring to detect changes (drift) in the gateway virtual machine’s network connections, and automatically isolate (quarantine) and revert any attempt to connect it to a public network.
- [ ] Run and keep periodic checks of whether the system is reachable from the public internet, using an approved external location, to provide evidence that it is not directly publicly accessible.


---

#### SC-7.29 — Separate Subnets to Isolate Functions (Enhancement)

This requirement is about keeping the most important parts of your system in their own protected areas, so problems elsewhere cannot easily spread. In everyday terms, it means separating the system’s command and control functions, safety or mission control functions, and day-to-day operational process control functions into clearly separate network areas, away from less critical functions. Without this separation, a breach or malfunction that starts in a less critical area could spread and disrupt safety-critical operations, potentially causing system failure.

To meet this expectation, your organisation must first identify and document which functions are critical. You must then design and implement the system so those critical functions run in logically separate network segments. You must record how this separation is built into your system design and architecture, keep the network configuration details in your configuration records, explain the reasoning in a criticality analysis, include the approach in your security plan, and keep audit records showing that the separation is in place and working as intended. You must also assign clear responsibility to the relevant administrators and boundary protection staff.

##### Logically separate critical functions into dedicated subnetworks

- Category: Software
- Priority: Critical

###### WHAT
Implement {{ insert: param, sc-07.29_odp.01 }} separate network segments to isolate {{ insert: param, sc-07.29_odp.02 }} (command-and-control, safety/mission control, and operational technology (OT) process control functions) from non-critical functions.

###### WHY (control requirement)
SC-7(29) enhancement requires separate network segments to reduce the risk of a serious breach or compromise that could cause system failure. The goal is to stop problems in non-critical areas from spreading into critical functions.

###### HOW (specific steps/approach)
1. **Define what must be isolated**: Create a list that links each application or service component to the function it supports—command-and-control, safety/mission control, and operational technology (OT) process control—or to non-critical functions.
2. **Create clearly separate network segments**: For each critical function, create a dedicated network segment (or an equivalent logical network area). Place non-critical components in different segments. Keep separate segments for each critical function rather than using a shared “production” segment.
3. **Apply isolation at the boundaries**: Set up network boundary controls (for example, firewalls/segmentation gateways/security groups) so that traffic is **blocked by default** between critical and non-critical segments. Allow only the specific traffic that is required, using approved lists (protocols/ports/destinations).
4. **Control how traffic and administrators can reach systems**: Set routing rules so that there is no unintended “sideways” (east-west) communication between segments. Limit administrative access so that management interfaces for critical functions can be reached only through approved management jump hosts/bastions and management network segments.
5. **Document and keep proof of the separation**: Update system design diagrams and network configuration records to show the segment boundaries, routing, and boundary control rules that support the isolation. Keep audit evidence (for example, exported firewall/segmentation policy settings and up-to-date network layout snapshots).
6. **Link to the criticality assessment and security plan**: Record the reason for this design in the organisation’s criticality assessment (how it reduces the chance and impact of catastrophic failure) and include the segmentation approach in the system security plan.

###### WHO (role responsible)
- **System/Network Architect**: creates the function-to-segment mapping and overall network design.
- **Network Security Engineer**: implements the boundary protections (firewall/segmentation policies) and routing restrictions.
- **Security/Compliance Lead**: ensures the reasoning is captured in the criticality assessment and reflected in the system security plan.
- **Configuration Manager**: maintains configuration records and keeps audit evidence.

###### Acceptance criteria
- A documented mapping exists showing each critical function is placed in its own logically separate network segment(s), separate from non-critical functions.
- Boundary controls enforce “blocked by default” between critical and non-critical network segments, with only explicitly approved traffic allowed.
- Routing and administrative access routes do not permit unintended connectivity between critical and non-critical network segments.
- System design documentation and network configuration records accurately reflect the implemented network segments, boundary rules, and routing.
- The system security plan and criticality assessment explicitly reference the reason for segmentation and the isolation design.
- Audit evidence is retained showing the current network segment boundaries and enforcement policies.

###### Actions Required for Compliance

- [ ] Identify and record which system components and functions are responsible for command-and-control, safety and mission control, and operational technology (OT) process control, compared with functions that are not critical.
- [ ] Create a mapping from each function to its subnetwork, and update the system architecture diagrams to show a dedicated subnetwork for every critical function.
- [ ] Set up clearly separated network sections for each critical function (for example, dedicated virtual local area networks (VLANs), virtual private cloud (VPC) subnets, virtual routing and forwarding (VRF) instances, or other equivalent logical network segments).
- [ ] Set up network boundary controls so that traffic between critical and non-critical network segments is blocked by default, and only allow the specific traffic that is explicitly required.
- [ ] Limit network routing and administrative access routes so that management of critical functions is only available through approved management subnets and jump hosts.
- [ ] Update the configuration records with the current subnet, routing, and boundary policy details, and keep the audit evidence exports.
- [ ] Document the reason for the network segmentation in the criticality assessment, and include this approach in the system security plan.


---

### SC-8 — Transmission Confidentiality and Integrity (Control)

This expectation is about keeping information safe while it moves between people, devices, and services, so it cannot be secretly read or changed without authorisation while in transit. Without this, sensitive information sent across internal and external networks, or through devices such as servers, laptops, mobile phones, printers, scanners, and radios, could be intercepted or altered. That could lead to fraud, data leaks, or decisions being made using incorrect information.

To meet this requirement, the organisation must clearly state which types of data transfers and which devices are covered. It must then ensure both confidentiality (keeping the information secret) and protection against unauthorised changes by using suitable safeguards, such as protected communication routes or encryption.

The organisation must document how it achieves this in its policy and step-by-step procedures, reflect it in system design and configuration settings, keep evidence through audit records, and include it in the system’s security plan. If it uses standard commercial communication services, it must check what protection those services include and put in additional compensating measures if needed.

##### Encrypt and authenticate all in-scope transmissions (confidential+integrity)

- Category: Software
- Priority: Critical

###### WHAT
Implement and enforce approved **confidentiality and integrity protections for all in-scope transmitted information** across internal and external networks and all sending devices/components (for example: servers, computers/endpoints, mobile devices, printers/scanners, and any radio/operational technology links where applicable).

###### WHY (control requirement)
NIST SP 800-53 **SC-8** requires: “Protect the {{param, sc-08_odp}} of transmitted information.” The guidance states that unprotected communication paths can be intercepted and altered, and that protection can be achieved by **physical or logical measures**, with **logical protection typically achieved through encryption**.

###### HOW (specific approach)
1. **Define the in-scope transmission types and endpoints** for the application/system (map the protocols and data flows: web, application programming interfaces (APIs), service-to-service communication, messaging, file transfer, remote access, management traffic, and any imaging/printing/scanning workflows that transmit data).
2. **Choose approved encryption and authentication settings** that protect both confidentiality and integrity (for example: Transport Layer Security (TLS) with authenticated encryption; require server authentication and, where appropriate, mutual authentication; prevent fallback to unencrypted communication).
3. **Enforce encryption while data is in transit at configuration level**:
   - Configure load balancers, application programming interface (API) gateways, and service meshes to **require TLS** and reject any non-TLS connections.
   - Configure application clients and servers to **block weak or legacy encryption settings and older protocol versions** and to **check certificates**.
   - Enforce secure transport for service-to-service calls (for example, mutual TLS (mTLS) where supported) and for any third-party connections.
4. **Ensure integrity is protected using cryptography**:
   - Use protocols and encryption methods that provide integrity (authenticated encryption) and support verification of the other party’s identity.
   - Where message-level integrity is required (for example, asynchronous messaging), apply message signing and verification or use authenticated message formats.
5. **Manage risk from “commodity” transmission services**:
   - For any third-party, internet service provider (ISP), or software-as-a-service (SaaS) transmission paths, document what confidentiality and integrity protections are included in the standard service.
   - If the provider’s assurances are not sufficient or cannot be obtained, implement **additional compensating controls** (for example: application-level TLS/mTLS, virtual private network (VPN) or overlay encryption, message signing).
6. **Create audit-ready evidence**:
   - Centralise logs and monitoring data showing that encrypted sessions were agreed (for example: TLS handshake details, cipher/protocol details, certificate validation results, and rejected attempts to use unencrypted or downgraded connections).
   - Record any exceptions (if they exist) along with the compensating controls and approval.
7. **Include this approach in the System Security Plan (SSP)** and keep it effective through configuration management, so it remains in place across all environments (production, testing, and disaster recovery).

###### WHO
- **Application Owner / Security Architect**: define in-scope transmissions and approved encryption settings.
- **Infrastructure/Platform Engineers**: implement gateway/load balancer/service mesh and endpoint configurations.
- **Developers**: ensure client/server libraries enforce TLS and certificate checking; implement message signing where needed.
- **Security Operations Centre (SOC) / Identity and Access Management (IAM) Team**: verify certificate lifecycle, monitor logs, and manage exception handling.

###### Acceptance criteria
- All identified in-scope transmission paths **fail closed**: any unencrypted or downgraded transport is rejected.
- For each transmission type, there is a documented **approved logical protection method** that protects both confidentiality and integrity.
- Evidence exists (from central logs and monitoring data) that encrypted sessions are negotiated using approved settings, and that non-compliant attempts are blocked.
- For any commodity transmission services, the organisation has documented the provider’s protections and either obtained sufficient assurance or implemented compensating controls.
- The implementation is recorded in the **System Security Plan (SSP)** and is maintained through configuration management (changes must not weaken or remove encryption enforcement).

###### Actions Required for Compliance

- [ ] Create a list of all transmission types and transmitting components that are in scope for the application or system.
- [ ] Define and publish the approved encryption and authentication settings for each type of data transmission to protect both confidentiality (keeping data secret) and integrity (preventing unauthorised changes).
- [ ] Set up gateways, load balancers, and service-to-service components to use Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS), and to block any unencrypted (plaintext) connections or attempts to reduce security (downgrade).
- [ ] Update application and client settings to use the approved protocol and cipher settings, and to verify certificates (with no insecure fallback options).
- [ ] Where needed, ensure message integrity for asynchronous message flows or any message flows not protected by transport layer security (TLS) by digitally signing and verifying messages.
- [ ] Document the protections used by commodity transmission providers. Where these protections are not sufficiently assured, put in place additional safeguards (for example, extra encryption on top of existing encryption or message signing).
- [ ] Keep audit evidence in one place showing that encrypted sessions were agreed and that non-compliant connection attempts were blocked. Record any exceptions in the system security plan (SSP).


---

#### SC-8.1 — Cryptographic Protection (Enhancement)

This requirement is about keeping information safe while it moves between your systems and users. It must not be readable by unauthorised people, and it must not be changed secretly without being detected. Without these protections, sensitive information such as login or account details could be exposed while it is being sent, or attackers could alter messages so that actions are carried out using changed or fake information.

To meet this expectation, the organisation must use approved methods to protect data in transit, such as secure encrypted connections for web and network traffic, and integrity checks that can detect any change to the data while it is on the move. The organisation should clearly document the rules and procedures for how confidentiality and integrity are achieved, make sure system settings actually enforce these protections, and keep records showing that secure connections were used and that any tampering attempts were rejected or failed.

##### Enforce TLS (confidentiality + integrity) for all in-transit traffic

- Category: Software
- Priority: Critical

###### WHAT
Implement cryptographic protections to secure information **while it is being sent** by enforcing **Transport Layer Security (TLS)** (and where required, **Internet Protocol Security (IPSec)**). This ensures traffic is protected against **unauthorised disclosure** and **changes while in transit**.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **Security and Privacy Controls (SC-8(1))** enhancement requires: *“Implement cryptographic mechanisms to {{ insert: param, sc-08.01_odp }} during transmission.”* The organisation-defined parameter **sc-08.01_odp** is to **prevent unauthorised disclosure** and **detect changes** to information. The guidance states that encryption for confidentiality and cryptographic integrity protections during transmission include **TLS and IPSec**.

###### HOW (specific steps/approach)
1. **Standardise and enforce TLS-only** for all relevant application communication paths (web, application programming interfaces (APIs), and service-to-service) by configuring edge components (load balancers/reverse proxies/API gateways) to:
   - Redirect or block plain **Hypertext Transfer Protocol (HTTP)** and refuse any non-TLS connections.
   - Require TLS using **approved minimum protocol versions** and **approved cipher suites**.
   - Use **authenticated TLS** (server certificates; use **mutual TLS (mTLS)** for service-to-service where feasible).
2. **Remove downgrade options** by rejecting weak or legacy protocol versions and ensuring clients and servers negotiate only approved TLS settings.
3. **Ensure integrity is provided by the cryptographic protocol** by using TLS cipher suites that provide authenticated encryption (for example, **authenticated encryption with associated data (AEAD)**), so tampering is detected at the transport level.
4. **Check enforcement continuously** by running automated tests from representative client networks and internal scanners. These should record the negotiated TLS version/cipher and certificate validity, and raise alerts if settings drift (for example, if any negotiation uses non-approved parameters).
5. **Produce audit-ready evidence** by centralising logs from gateways/proxies (handshake success/failure, negotiated protocol/cipher, certificate details, and any rejected downgrade attempts) into **security information and event management (SIEM)** for review.
6. **Document the implementation** in system design and configuration baselines showing where TLS is ended, how it is configured, and how confidentiality and integrity are achieved for each transmission path.

###### WHO (role responsible)
- **Security architect / security engineering lead**: sets the approved TLS configuration baseline and the confidentiality/integrity requirements.
- **Platform/infrastructure engineers**: implement TLS enforcement on gateways/load balancers and service-to-service endpoints.
- **Application owners**: ensure application clients and service consumers validate certificates (no “trust all” behaviour).
- **Security operations centre (SOC)/SIEM operations**: configure detections and retention for TLS posture and handshake failure events.

###### Acceptance criteria
- All external and internal application transmission paths that carry sensitive data **refuse non-TLS** connections and **only negotiate approved TLS parameters**.
- TLS sessions provide **confidentiality and integrity** (no unauthenticated or unencrypted transport for in-scope traffic).
- Automated checks confirm that **no downgrade to disallowed TLS versions/ciphers** occurs over time.
- Centralised logs provide evidence of **TLS negotiation parameters** and **rejected handshake/downgrade attempts**.
- System design and configuration documentation clearly maps transmission paths to TLS termination points and configuration baselines.

###### Actions Required for Compliance

- [ ] Define an approved Transport Layer Security (TLS) baseline, including the minimum allowed protocol versions and the approved cipher suites, in line with organisational standards.
- [ ] Configure edge gateways, load balancers, and API gateways to allow only Transport Layer Security (TLS) connections—block or refuse plain Hypertext Transfer Protocol (HTTP) and any TLS versions or certificates that are not approved.
- [ ] Use authenticated Transport Layer Security (TLS) for communication between services (use mutual TLS (mTLS) where possible; otherwise require strict certificate checks).
- [ ] Set up automated checks for “configuration as code” to stop deployments that use disallowed Transport Layer Security (TLS) versions or encryption settings, and to prevent insecure client and server settings.
- [ ] Set up automated checks of Transport Layer Security (TLS) settings that record the negotiated protocol and cipher and the certificate status, and raise alerts if these settings change (drift).
- [ ] Send Transport Layer Security (TLS) connection handshake and rejection logs to the security information and event management (SIEM) system, and set up alerts for attempted security downgrades and repeated handshake failures.
- [ ] Update the system design and configuration baseline documents to record where Transport Layer Security (TLS) is terminated, and explain how confidentiality and integrity are achieved for each data transmission path.


---

#### SC-8.2 — Pre- and Post-transmission Handling (Enhancement)

This requirement is about keeping information safe while it is being prepared to send and while it is being received, so it cannot be accidentally exposed or secretly changed. Without this, sensitive details could leak during steps such as combining data, converting it into a different format, or packing it for delivery. The recipient might then receive information that looks genuine but is wrong.  

To meet this expectation, the organisation must have clear, followed procedures for preparing outgoing information and for handling incoming information. These procedures must cover both confidentiality (keeping it private) and correctness (ensuring it is accurate) from start to finish. This includes protecting the information during preparation, packing, any combining, and any format or protocol changes, as well as during reception, unpacking, and any conversion back again.  

The organisation should also be able to demonstrate that integrity checks are carried out at the right points, and that if a check fails, the data is not accepted as valid.

##### Cryptographically bound transfer packaging with verify-before-unpack

- Category: Software
- Priority: Critical

###### WHAT
Create a standard “secure transfer package” for all confidential information that is prepared for sending and while it is being received. The package must protect **confidentiality** and **integrity** at every step of the process, including combining data, packing/unpacking, and any changes to the data’s format or communication method.

###### WHY (control requirement)
SC-8(2) requires the organisation to **maintain the {{ insert: param, sc-08.02_odp }} of information during preparation for transmission and during reception**. The guidance highlights the risk of **accidental or deliberate disclosure or alteration** during data combining, changes to the communication method, and packing/unpacking. Using encryption and integrity protection on the final transformed package, and checking it before unpacking or processing, addresses these risks for **confidentiality and integrity**.

###### HOW (specific steps/approach)
###### Outbound (preparation for transmission)
1. **Combine → transform → pack → protect cryptographically**: Make sure the application combines the data and applies any format or communication changes first, then produces a final “ready-to-send” sequence of bytes.
2. **Encrypt for confidentiality**: Encrypt the final byte sequence using an organisation-approved encryption method and key management service (for example, keys protected by a hardware security module (HSM) or an enterprise key management service (KMS)).
3. **Sign for integrity**: Digitally sign the encrypted payload (or sign the final transformed bytes and link the signature to the encrypted container) so that any change during preparation, transit, or storage makes the signature invalid.
4. **Link metadata to the package**: Include transfer identifiers, sender identity, content type/version, and declared hashes in the signed information so that any changes to the metadata are detected.
5. **Create audit evidence**: Record key identifiers, the payload hash, signature verification status (for self-checks), and transfer identifiers.

###### Inbound (reception)
6. **Store as delivered with restricted access**: Receive and store the package in a restricted area that is accessible only to the verification process.
7. **Check integrity before unpacking/decrypting**: Verify the digital signature first. If verification fails, reject the package and do not unpack it or perform any further format or communication changes.
8. **Decrypt and then unpack**: Only after successful verification, decrypt and unpack into the processing workflow.
9. **Validate after unpacking**: Check that the content meets the required structure and business rules, and confirm the decrypted content hash matches what was included in the signed information.
10. **Handle failures safely**: If any verification or hash check fails, raise an alert, record the event for security information and event management (SIEM), and quarantine the package.

###### Implementation notes (fit to enterprise application context)
- Implement this as a reusable library or service used by all relevant application components (web/application programming interface (API) clients, batch jobs, message producers/consumers, and file export/import jobs).
- Ensure the transformation is repeatable and consistent (deterministic) or that the final transformed bytes are signed in a way that keeps integrity protection intact across format/communication change points.
- Use automated pipeline steps so that signing and encryption happen only after the final package is produced.

###### WHO (role responsible)
- **Application Security Engineer / Security Architect**: Define the secure transfer package format, cryptographic rules, and the verification workflow.
- **Backend/Platform Engineers**: Build the packaging library/service and integrate it into sending and receiving processes.
- **Operations/Site Reliability Engineering (SRE)**: Set up key management integration, restricted storage/quarantine, and monitoring/alerting.
- **Compliance/Assurance**: Check that evidence is produced and that audit acceptance criteria are met.

###### Acceptance criteria
- For every outbound transfer of confidential information, the sent item is an encrypted container with a valid digital signature applied after combining/packing/format or communication transformation.
- On receipt, the system verifies the signature and rejects/quarantines the package on any signature or bound-hash mismatch **before** unpacking/decrypting into the processing workflow.
- Audit records show, for each transfer identifier: sender identity, key identifier(s), payload hash, signature verification result, and quarantine/rejection reasons.
- Tampering tests (changing bytes at any stage, including after packing or during transformation) cause verification to fail, and the altered content is not processed.

###### Actions Required for Compliance

- [ ] Define a standard secure transfer format that digitally signs the transfer details and the final hash of the transformed data.
- [ ] Set the outbound pipeline order so that data is aggregated and converted into the required protocol and format before it is encrypted and digitally signed.
- [ ] Use organisation-approved key management tools (hardware security modules (HSMs) and key management services (KMSs)), and enforce separation so that packing/signing systems cannot decrypt data, while receiving systems can only verify and decrypt it through authorised workflows.
- [ ] Set up an incoming receiving process that records parcels as delivered, checks the sender’s signature before opening or decrypting them, and places parcels in quarantine if the check fails.
- [ ] Add a post-unpacking check to confirm that the decrypted content matches the signed or bound hash and meets the required schema and business rules.
- [ ] Set up audit logs and security information and event management (SIEM) alerts for the results of signature checks, key identifiers, transfer identifiers, and the reasons for quarantining or rejecting items.


---

#### SC-8.3 — Cryptographic Protection for Message Externals (Enhancement)

This requirement is about keeping the important “routing details” of messages safe while they are being sent, so that outsiders cannot read them or secretly change them.

Message headers and routing information can show who is contacting whom and how messages move through systems. If these details are not protected, an attacker could monitor communications or tamper with delivery information to disrupt services or redirect information.

To meet this expectation, the organisation must set out and follow documented rules and step-by-step procedures for protecting these message details. It must use approved methods that both keep the information secret and help detect any unauthorised changes while the message is in transit.

The organisation must document how the protection is designed, record the system settings that implement it, and keep audit records showing that the protection is working in practice.

Encryption should be used by default, unless the organisation can demonstrate that, for the relevant message path, protected delivery systems are already in place with tamper-evident packaging and controlled access to the message routing components.

##### Encrypt message headers/routing externals in transit (TLS/mTLS)

- Category: Software
- Priority: Critical

###### WHAT
Protect message “externals” (message headers and routing information) while data is being sent, using approved methods that provide confidentiality and integrity. Use cryptography by default.

###### WHY (control requirement)
SC-8(3) requires: “Implement cryptographic mechanisms to protect message externals unless otherwise protected by {{ insert: param, sc-08.03_odp }}.” Message externals include headers and routing information. Without protection, these could be sent in clear text and be visible to unauthorised people. Cryptographic protection must stop unauthorised disclosure and misuse of message externals.

###### HOW (specific steps/approach)
1. **Define approved cryptographic transport settings** for every message path that carries headers/routing information (for example, only Transport Layer Security (TLS) version 1.2 or 1.3; approved cipher suites; strict certificate checks; disable downgrade or weak renegotiation where applicable). Treat these as the organisation’s “approved methods” for SC-8(3).
2. **Find and map where message externals could be exposed** across the application’s multi-tier and integration setup (for example, web/application programming interface (API) gateways, load balancers, reverse proxies, service-to-service connections, message brokers/queues, webhook endpoints, and any intermediary components that could reveal header/routing data).
3. **Require encryption in transit at the right points**:
   - For **client-to-service** and web/API traffic: enforce **Hypertext Transfer Protocol Secure (HTTPS)** with HTTP Strict Transport Security (HSTS) and strict TLS settings at gateways/load balancers.
   - For **service-to-service** and system-to-system integrations: enforce **mutual Transport Layer Security (mTLS)** (or an equivalent workload identity-based mutual authentication) so intermediaries cannot quietly switch to plaintext.
   - For **messaging systems/webhooks**: ensure producer/consumer connections use TLS, and ensure any proxy/relay components do not break end-to-end encryption unless explicitly approved and still protected end-to-end.
4. **Stop configuration changes that cause plaintext fallbacks** using policy-as-code and configuration baselines (for example, infrastructure-as-code templates and continuous integration/continuous deployment (CI/CD) checks that block deployments where TLS is disabled or weak).
5. **Keep auditable proof of configuration** for each relevant endpoint/link (for example, gateway/load balancer TLS policy, service mesh/mTLS settings, certificate validation mode, and enforcement flags) in the configuration management repository.
6. **Produce and retain audit proof that encryption was actually used** for message externals in transit (for example, logs/telemetry showing TLS session setup and that encryption was agreed; alerts for any plaintext or downgrade attempts).
7. **Use the exception only when justified**: if cryptography is intentionally not used for a specific message path, document that the alternative physical controls apply exactly as defined in **sc-08.03_odp** (protected distribution systems with tamper-evident packaging and controlled access to message routing components) and keep evidence that those physical safeguards are in place.

###### WHO (role responsible)
- **Application Owner / System Owner**: responsible for ensuring all message paths carrying header/routing externals are covered.
- **Infrastructure/Network Engineering**: implements and enforces TLS/mTLS at gateways, load balancers, proxies, and service-to-service connections.
- **Security Engineering / Compliance**: sets the approved cryptographic standards, checks coverage, and reviews audit evidence.
- **DevOps/Platform Engineering**: implements policy-as-code, configuration baselines, and CI/CD enforcement.

###### Acceptance criteria
- For every identified message path where headers/routing information could be visible, **TLS/mTLS is enforced** and plaintext transmission is blocked through configuration.
- Configuration evidence exists showing the approved TLS/mTLS settings are applied to each relevant endpoint/link.
- Audit/telemetry evidence exists showing that encrypted sessions were agreed for message traffic (and alerts exist for any plaintext/downgrade attempts).
- Any use of the exception is rare, clearly documented against **sc-08.03_odp**, and supported by evidence of tamper-evident packaging and controlled access to message routing components.

###### Actions Required for Compliance

- [ ] Define and publish approved Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS) encryption standards for messages sent outside the system, including the communication protocols, approved cipher suites, certificate checking rules, and rules to prevent weaker “downgrade” versions from being used.
- [ ] Create an inventory of message paths that lists every place where header information and routing details could be exposed (for example: gateways, proxies, message brokers, webhooks, and service-to-service connections).
- [ ] Require Transport Layer Security (TLS) and mutual Transport Layer Security (mTLS) on every identified message route, and prevent any unencrypted (plaintext) connections by blocking plaintext fallback at gateways/load balancers and intermediary components.
- [ ] Set up “policy as code” and standard security configurations so deployments fail if Transport Layer Security (TLS) is turned off or is too weak for any covered endpoint or connection.
- [ ] Record configuration settings that can be audited for each covered endpoint or link in the configuration management repository.
- [ ] Set up and keep records (telemetry and logging) that show encrypted sessions were agreed for sending messages. Alert if anyone tries to send messages in plain text or to reduce (weaken) the encryption.
- [ ] Document and provide evidence for any exception use only against **sc-08.03_odp** (protected distribution systems that use tamper-evident packaging and have controlled access to message routing components).


---

#### SC-8.4 — Conceal or Randomize Communications (Enhancement)

This requirement is about preventing outsiders from learning useful information just by observing how your messages are sent and when they arrive. Even if the message content is protected, details such as how often communications happen, how predictable the timing is, and how much data is sent can still reveal sensitive information when combined with other data.

To meet this requirement, the organisation must use approved encryption and related protections so that communication patterns are hidden or made less predictable for both internal and external connections that unauthorised people might be able to observe. This should be done unless the organisation’s protected systems for sending external links and mission circuits already provide the needed protection.

The organisation must:
- set clear internal rules for when pattern concealment is required
- document how transmissions are kept confidential and protected from unauthorised changes
- ensure the system design and configuration show these protections are enabled
- keep records proving the protections are working
- include this approach in the system security plan, with clear responsibility assigned to the relevant information technology (IT) and security staff when relying on the alternative protected distribution approach

##### Conceal comms patterns via encrypted fixed/randomised egress scheduling

- Category: Software
- Priority: Critical

###### WHAT
Put in place protections for secure, encrypted communications. Also, where unauthorised people could work out sensitive information from observable communication behaviour (such as how often messages are sent, when they are sent and how predictable that is, and how much data is sent), add measures to hide or randomise those observable patterns. Apply this unless the organisation’s authorised **alternative physical controls** for external links and mission circuits already provide the needed protection.

###### WHY (control requirement)
The SC-8(4) enhancement requires: **“Implement cryptographic mechanisms to conceal or randomize communication patterns unless otherwise protected by {{ insert: param, sc-08.04_odp }}.”** Even if message content is encrypted, the observable communication patterns (frequency, timing, predictability, and data amount) can still reveal sensitive information. Therefore, concealment or randomisation must cover those observable patterns for both internal and external links that could be seen by unauthorised people.

###### HOW (specific approach)
1. **Identify which communications need pattern concealment**: Create a mapping of traffic types in the communications protection design that shows (a) which internal and external links could be visible to unauthorised observers, and (b) which application traffic types (for example, application programming interface (API) calls, service-to-service traffic, administrative or privileged workflows, and supplier/vendor integrations) must use pattern concealment.
2. **Use encryption for confidentiality and integrity**: Make sure all identified traffic types use enterprise-approved encrypted transport (for example, Transport Layer Security (TLS) 1.2 or later with strong cipher suites and/or Internet Protocol Security (IPsec) tunnels) so that message content is protected.
3. **Add pattern concealment/randomisation at controlled exit points**: Adjust how traffic is sent so that observable timing and data volume are less predictable than “send immediately when an event happens” bursts. Use the approach that fits your architecture:
   - **Service mesh exit / application programming interface (API) gateway**: apply per-route rate limiting and queuing, using either (i) continuous fixed-rate sending for selected traffic types or (ii) controlled randomised sending (limited jitter) for selected traffic types.
   - **Secure software-defined wide area network (SD-WAN) / edge gateway**: apply flow-based rate limiting and packet pacing for selected destinations and ports.
   - **Network virtualisation / overlay**: apply per-tunnel pacing and batching rules.
   The sending schedule must be designed to reduce what can be inferred from **frequency, timing/predictability, and data amount/volume**.
4. **Apply the exception where alternative physical controls already protect the link**: For external links/mission circuits that are explicitly covered by the organisation’s authorised **protected distribution systems** (sc-08.04_odp), document that pattern concealment/randomisation is not required for those specific circuits because the alternative physical controls provide the protection.
5. **Ensure the behaviour can be checked and proven**: Turn on logging and monitoring at the traffic exit control layer to show that pattern concealment/randomisation is active (for example, configuration version, policy identifiers, and runtime counters for pacing/rate limiting). Keep the evidence for audit.
6. **Update system documentation**: Record the pattern concealment approach, the scoping rules, the cryptographic mechanisms, and how exceptions are handled (protected distribution systems) in the System Security Plan and the relevant configuration and design documents.

###### WHO (roles responsible)
- **System Owner / Application Owner**: approves the traffic-type scoping and any exception decisions.
- **Network/Platform Engineering Lead**: implements the exit-point scheduling (gateway/service mesh/SD-WAN) and ensures it is configured correctly.
- **Security Architect**: checks that the design meets the intent of SC-8(4) (hiding frequency/timing/data amount patterns) and that exceptions match sc-08.04_odp.
- **DevOps/Release Manager**: ensures changes are deployed through controlled release processes and configuration baselines.

###### Acceptance criteria (verifiable)
- For every scoped traffic type, encrypted transport is enabled end-to-end (in line with enterprise standards).
- For every scoped traffic type not covered by sc-08.04_odp, the exit control layer enforces either continuous fixed-rate sending or bounded randomised scheduling, so that traffic timing/data volume is measurably less predictable than baseline event-driven bursts.
- There is runtime evidence that the pattern concealment/randomisation policy is active (for example, policy identifiers and pacing/rate-limiting counters), and this evidence is retained for audit.
- The System Security Plan and communications protection design explicitly document: (a) scoping rules, (b) cryptographic mechanisms, (c) the pattern concealment/randomisation mechanism, and (d) which external links/mission circuits are excluded due to protected distribution systems (sc-08.04_odp).

###### Actions Required for Compliance

- [ ] Define traffic categories and the rules for which internal and external network connections must use pattern concealment or randomisation.
- [ ] Confirm and apply enterprise-approved encrypted network connections—using Transport Layer Security (TLS) and Internet Protocol Security (IPsec)—for all in-scope data flows.
- [ ] Set up traffic scheduling at a controlled exit point (for example, an application programming interface (API) gateway, service mesh, or software-defined wide area network (SD-WAN) edge) so that selected types of traffic are sent at a fixed rate or within defined limits, using randomised timing, for specific traffic categories.
- [ ] Record and set up clear exceptions for external links and mission circuits that are included in protected distribution systems (SC-08.04_ODP).
- [ ] Enable and keep audit records from the data-exit control layer to show that the pattern-concealment and randomisation rules are active while the system is running.
- [ ] Update the System Security Plan and the configuration and design documentation to reference the concealment and randomisation mechanism and the sc-08.04_odp exceptions.


---

#### SC-8.5 — Protected Distribution System (Enhancement)

This requirement is about ensuring Secret and Confidential information is sent only through approved, protected routes. This prevents unauthorised people from reading the information while it is being transmitted, and it allows the organisation to detect whether the information was changed during transit. Without these protections, sensitive documents could be intercepted, copied, or altered while they are being sent, which could seriously harm the organisation and its stakeholders.

To meet this expectation, the organisation must define and document its protected method for distributing Secret and Confidential data. This should include the practical steps and procedures used to keep transmissions private and to detect any changes. The organisation must also keep evidence of how the protected routes are designed and configured, showing that the routes are actually in place. It must record relevant activity so that protection and detection can be checked later, and include this in its security planning.

Finally, the organisation must ensure staff systems enforce the use of the approved protected routes. Any attempt to send Secret or Confidential data through unapproved channels must be blocked or redirected.

##### Mandatory PDS via approved secure transfer service for Secret/Confidential

- Category: Software
- Priority: Critical

###### WHAT
Set up a **Protected Distribution System (PDS)** for **Secret and Confidential** information by sending all in-scope messages through an **approved secure transfer service**. This service must provide **protection while data is being sent** (confidentiality in transit) and **detect any tampering or changes** (for example, using encrypted messaging with integrity checks). It must also create **audit records** and **enforce controls** so that staff cannot use unapproved sending routes.

###### WHY (control requirement)
SC-8(5) enhancement requires: **“Implement {{ param, sc-08.05_odp.01 }} to {{ param, sc-08.05_odp.02 }} during transmission.”**
- The PDS must be defined for **Secret and Confidential data** (sc-08.05_odp.01).
- It must **prevent unauthorised disclosure** and **detect changes to information** while it is being sent (sc-08.05_odp.02).

###### HOW (specific steps/approach)
1. **Define the PDS scope and routing rules**: document which information labels/types are in scope (Secret/Confidential) and which sending methods are allowed (the approved secure transfer service). Include any exceptions, with expiry dates and required approvals.
2. **Implement mandatory routing and enforcement**: connect the application and enterprise messaging/email/application programming interface (API) routes to policy enforcement (for example, data loss prevention (DLP) and email gateway rules, API gateway policies, or application-side routing). Any attempt to send in-scope information via an unapproved route must be **blocked or redirected** to the PDS.
3. **Configure the secure transfer service for confidentiality and integrity**: ensure the service uses **encrypted protection with authentication** and checks that the content has not been altered (integrity verification) when received. Set it to **fail safely** (reject or quarantine transfers when integrity checks fail).
4. **Integrate identity and authorisation**: require authenticated access to the PDS using the organisation’s enterprise identity service (single sign-on (SSO)) and enforce role/recipient authorisation so only the intended recipients can access the transferred content.
5. **Enable and keep audit evidence**: record transfer events, including sender, recipient, classification label, transfer identifiers, authentication outcomes, and whether integrity checks passed or failed. Send these logs to the security information and event management (SIEM) system and keep them according to the security plan.
6. **Produce audit-ready design and operating documentation**: create architecture diagrams and configuration baselines showing where enforcement happens (application/API/email gateway), how the PDS protects confidentiality and integrity, and how operators handle failures.
7. **Update the system security plan**: explicitly reference the PDS for Secret/Confidential transmissions, including enforcement points, monitoring, and log retention.

###### WHO (role responsible)
- **Application Security/Architecture Lead**: responsible for PDS design, scope definition, and updates to the security plan.
- **Platform/Network/Integration Engineers**: implement enforcement (API/email/data loss prevention (DLP) routing) and configure the secure transfer service.
- **Identity and Access Management (IAM) Lead**: ensures integration with single sign-on (SSO) and multi-factor authentication (MFA), and authorisation for PDS access.
- **Security Operations Centre (SOC)/SIEM Operations**: checks that logging and alerts work (including integrity failures) and that logs are retained.

###### Acceptance criteria
- All Secret/Confidential transmissions from the application are routed through the approved secure transfer service; unapproved routes are blocked or redirected.
- Transfers provide confidentiality while data is in transit, and are rejected or quarantined when integrity verification fails.
- Audit logs exist for each transfer, including integrity pass/fail results, and are retained and available for review.
- The system security plan and PDS design/configuration documentation are updated and match the enforcement points that are deployed.

###### Actions Required for Compliance

- [ ] Define and document the scope for handling Secret and Confidential information, including which transfer methods are allowed and any approved exceptions.
- [ ] Set up the application/programming interface (API) and the company email and messaging routes so that all in-scope data is automatically sent through the approved secure file transfer service.
- [ ] Set up the secure transfer service to use authenticated encryption and to verify data integrity, and configure it to fail closed if the integrity check fails.
- [ ] Link PDS access to the organisation’s single sign-on (SSO) system and require approval based on the intended recipient and their role for transfers of Secret and Confidential information.
- [ ] Enable audit logging for when transfers start and finish, the sender and recipient, the classification tags, the results of authentication, and whether integrity checks pass or fail. Send these logs to security information and event management (SIEM) and set how long they are kept.
- [ ] Publish architecture diagrams, configuration baseline documents, and operator instructions for enforcing PDS requirements and handling integrity failures
- [ ] Update the system security plan to clearly describe how the PDS is used, how it is monitored, and how long logs are kept for Secret and Confidential transmissions.


---

### SC-10 — Network Disconnect (Control)

This requirement ensures that when a user’s online session finishes, the system closes it properly. It also ensures that if a user is inactive for 15 minutes, the system ends the session automatically. Without this, users could remain connected longer than intended, which could leave a security risk, allow unauthorised use, enable accidental access, or waste resources that should have been released.

To meet this expectation, the organisation must set a clear 15-minute inactivity rule and make sure sessions are ended either when the session ends normally or when the inactivity limit is reached, for both internal and external connections. When ending a session, the system must free the network resources it was using. If multiple session activities use the same underlying connection, the system must separate them correctly.

The organisation must document how this is done, configure it in system settings, keep evidence that it is working, and record session end events including the time they occurred. It must also assign named responsibility so administrators and developers can support the capability.

##### Enforce 15-min inactivity session disconnect at edge and app

- Category: Software
- Priority: Critical

###### WHAT
Set up automatic network disconnection for every communications session, so the connection is ended when the session finishes, or after **15 minutes of inactivity** (organisation setting **sc-10_odp**, default **15 minutes**), for both internal and external network access.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) **SC-10 Network Disconnect** requires: “End the network connection linked to a communications session when the session ends, or after {{ insert: param, sc-10_odp }} of inactivity.” It also requires releasing **operating system (OS)-level** network assignments (for example, TCP/IP address and port pairs) and **application-level** network assignments when multiple application sessions share a single OS-level network connection.

###### HOW (specific steps/approach)
###### 1) Enforce disconnect at the network edge (internal + external)
- Send all user communications (web, application programming interface (API), and client-server traffic) through a session-aware edge component (for example, a reverse proxy, API gateway, ZTNA broker, or virtual private network (VPN) gateway) that can apply inactivity time limits per session.
- Configure the edge to apply an inactivity timeout of **sc-10_odp (15 minutes)** for each session type (web, API, admin consoles, remote access) and to immediately end the session when the user explicitly logs out/disconnects.
- Make sure the edge closes the underlying network transport (socket teardown) so OS-level TCP/IP mappings are released.
- For shared-connection situations (for example, HTTP/2 multiplexing or connection pooling), make sure the edge invalidates the specific logical session (for example, cookie/token/session-id expiry) even if the underlying transport connection stays open.

###### 2) Match application session timing to ensure logical disconnect
- Implement or confirm application session inactivity expiry at **sc-10_odp (15 minutes)**, so that after inactivity the application rejects any further requests for that session (even if the transport connection remains open).
- Ensure end-of-session events (logout, session close, connection close) trigger application-side session invalidation and any required cleanup between sessions and connections.

###### 3) Keep audit evidence for disconnect timing and cause
- Record audit logs that include: session identifier, user/service identity, last activity time, disconnect time, and disconnect cause (**end-of-session** versus **inactivity timeout**).
- Send the logs to the organisation’s security information and event management (SIEM) or monitoring platform for retention and auditability.

###### WHO
- **Platform/Network Engineering Lead**: configure the edge gateway/proxy/VPN/waswo for inactivity timeouts and session teardown.
- **Application Security/Engineering Lead**: configure application session inactivity expiry and session invalidation behaviour.
- **Security Operations Centre (SOC) / Compliance Analyst**: check audit evidence, retention, and reporting.

###### Acceptance criteria
- For each supported session type (internal and external), the session is terminated when the user logs out/disconnects.
- For each supported session type, if there is **no activity for sc-10_odp (15 minutes)**, the session is disconnected/invalidated and further requests are denied.
- OS-level network resources are released on disconnect (confirmed using gateway telemetry and/or host/network socket and resource counters).
- For shared-connection situations, the logical session is invalidated after **15 minutes of inactivity** (not just the underlying transport).
- Audit records exist for disconnect events, including disconnect cause and timestamps, and are sent to SIEM as evidence.

###### Actions Required for Compliance

- [ ] Choose and standardise the session-aware edge component(s)—such as a reverse proxy, application programming interface (API) gateway, zero trust network access (ZTNA), or virtual private network (VPN)—for all internal and external access routes.
- [ ] Set a per-session inactivity timeout at the edge for sc-10_odp to 15 minutes, and make sessions end immediately when a user logs out or disconnects.
- [ ] Set up, or confirm, that application sessions at **sc-10_odp** expire after **15 minutes of inactivity**, and make sure that once a session expires it is blocked from making any further requests.
- [ ] Check that shared-connection handling correctly ends each logical session after 15 minutes, even if the underlying transport connection continues to be reused through multiplexing or pooling.
- [ ] Enable audit logging for disconnect events, including the session ID, the time of the last activity, the time the disconnect occurred, and the reason for the disconnect (end of session versus inactivity timeout).
- [ ] Test and record evidence: confirm the operating system’s network socket and port mapping for the release, and confirm that the connection is disconnected exactly at the end of the session or after 15 minutes of inactivity.


---

### SC-11 — Trusted Path (Control)

This requirement is about ensuring that when people log in or confirm they are still authorised, they do it using a special, protected method that normal software cannot interfere with. Without this, a malicious or untrusted programme could mislead users with a fake login screen, record what they type, or change what the system accepts, which could lead to unauthorised access.

The organisation must provide a physically separate, trusted communication link between the user and the system’s trusted security functions. This ensures that any user information sent through that link cannot be seen or altered by untrusted applications.

Users must be able to use this trusted link not only for the initial login, but also for identity checks when required, at a minimum. The organisation should document how this trusted link works, make sure it is implemented as described, and be able to provide evidence that both authentication and re-authentication happen through the trusted link.

##### Physically isolated trusted authentication terminal for auth & re-auth

- Category: Software
- Priority: Critical

###### WHAT
Set up a **physically separate, trusted communication route** so users can carry out **authentication** and **re-authentication** using the system’s **trusted security functions**. This trusted route must ensure that **user responses cannot be changed or seen by untrusted applications**.

###### WHY (control requirement)
SC-11 requires trusted routes that:
- Provide a **way** for users to communicate directly with the system’s **trusted security functions** (at least **authentication** and **re-authentication**, using parameters defined by the organisation).
- Are **physically separate** and enforced through a specific implementation that matches the **reference monitor** concept.
- Protect user responses from **being changed or disclosed by untrusted applications**.

###### HOW (specific approach)
Use a dedicated **trusted authentication terminal/appliance** (separate keyboard/screen or a hardened hardware security appliance) to handle credential entry and verification for the application’s trusted security functions.

1. **Trusted terminal design**: Use a dedicated device with its own user interface for entering credentials and showing trusted prompts. The main application workstation must not display credential-entry screens for trusted authentication.
2. **Physically isolated path**: Put the trusted terminal in a physically separate location (for example, near the workstation but on a dedicated, controlled device). Ensure credential exchange happens only between the user and the trusted terminal.
3. **Trusted security function integration**: Connect the terminal to the organisation’s identity and access management so the terminal performs authentication and sends back only an **authorisation result** (for example, success/failure, or a session/step-up token) to the application.
4. **Trusted route use**:
   - Users must start trusted authentication using a **user action** that untrusted applications cannot take over (for example, a dedicated hardware button on the terminal, or a workstation action such as “connect to trusted terminal” that does not show credential prompts).
   - The application’s **security functions** must be able to trigger **re-authentication** using a server-led step-up process that starts a trusted terminal session.
5. **Reference monitor enforcement**: In the application/security layer, accept authentication/re-authentication for protected actions **only** when it includes a **cryptographically verifiable indicator** that the trusted terminal was used (for example, a signed assertion/token issued by the trusted terminal or its trusted service).
6. **Auditability**: Record clear events for both **authentication** and **re-authentication** that include a “trusted route used” indicator, and keep evidence suitable for audit.

###### WHO
- **Security Architect / Identity and Access Management (IAM) Lead**: Own the trusted route design, integration with identity, and reference monitor enforcement.
- **Application Owner**: Add step-up/re-authentication triggers for protected functions.
- **Platform/Infrastructure Team**: Purchase, deploy, and secure (harden) the trusted terminal(s) and set up network connectivity.
- **Security Operations Centre (SOC)/Monitoring Team**: Configure security information and event management (SIEM) alerts and ensure audit events are collected.

###### Acceptance criteria
- Authentication and re-authentication for defined protected functions happen **only** via the trusted terminal (no credential entry through untrusted application prompts).
- The application accepts authentication/re-authentication **only** when the request includes a **verifiable trusted-route indicator** produced by the trusted terminal.
- Audit logs show successful and failed authentication/re-authentication events with a **trusted route used** flag.
- Demonstrated test: attempts to fake, intercept, or tamper with credential prompts in the main application do not capture or alter the user responses used for authentication/re-authentication.

###### Actions Required for Compliance

- [ ] Procure and deploy a dedicated trusted authentication device (terminal or appliance) with a separate, isolated keyboard and screen for entering credentials.
- [ ] Connect the terminal to the organisation’s identity system so it can verify users, and so it only sends the application a signed approval (including any required extra verification).
- [ ] Set up a reference monitor on the application side to allow authentication and re-authentication only when a trusted-path indicator is present.
- [ ] Set up the application so that, for certain high-risk actions, it asks the user to sign in again using the trusted device (a “step-up” sign-in flow).
- [ ] Disable or block prompts that ask users to enter credentials in the main application for trusted sign-in and re-authentication routes.
- [ ] Enable audit logging and security information and event management (SIEM) reporting for authentication and re-authentication events, including an indicator that a trusted path was used.
- [ ] Run a test to show that prompts from untrusted applications cannot capture or change the user responses used for trusted authentication and re-authentication.


---

#### SC-11.1 — Irrefutable Communications Path (Enhancement)

This requirement is about making sure the system communicates with you in a way you can always trust and immediately recognise as coming from the organisation’s own security features—not from a normal app or a misleading message. Without this, a malicious or faulty message could appear convincing and persuade you to share information, approve changes, or confirm actions that should only be handled by the organisation’s security safeguards.

To meet this expectation, the organisation must set up the system so that the trusted way of communicating is clearly and unmistakably different from all other messages. For example, it could use a dedicated on-screen area that other software cannot access, or display a fixed trusted indicator that cannot be copied or imitated.

The system must also automatically start this trusted communication route whenever communication is needed between the system’s security functions that set it up and you. The organisation must ensure consistent behaviour and keep evidence through documented procedures, system design and configuration records, and audit or test results.

##### Trusted communications path via non-spoofable secure UI surface

- Category: Software
- Priority: Critical

###### WHAT
Set up a communication route that users can trust and that cannot be faked. This route must use a dedicated security-controlled screen area or indicator that users can clearly recognise as coming from the organisation’s security team, and that other applications cannot copy, overlay, or replace. Start this trusted route automatically whenever the defined **security functions** need to communicate with the user.

###### WHY (control requirement)
SC-11(1) enhancement requires a trusted communication route where the user can **clearly recognise** the source as a trusted system component, and where the trusted route is **started automatically** for communications between the system’s **security functions** and the user. The guidance also expects the trusted route to be clearly distinguishable (for example, a dedicated display area that other applications cannot access) and/or based on an identifier that cannot be spoofed.

###### HOW (specific steps/approach)
1. **Define the security functions** responsible for setting up the trusted communication route (per organisation parameter sc-11.01_odp) and link each one to the user journeys that need trusted communication (for example: sign-in, re-authentication, “step-up” authentication, and confirming privileged actions).
2. **Use secure platform or identity user interface features** that create a surface that cannot be spoofed (for example: operating system secure desktop / secure attention / secure input focus, or an equivalent enterprise identity or privileged access management (PAM) trusted prompt mechanism). Make sure the trusted prompt is shown by the security component, not by the business application.
3. **Use a dedicated trusted display area or indicator** that is fixed and controlled by the security component (for example: consistent wording, position, and appearance). Configure it so normal applications cannot draw over it, replace it, or imitate it.
4. **Start the trusted route automatically** from the security component at the correct point in the user journey (for example: before credentials are entered, or before a privilege change or approval). This means the user does not have to choose or confirm the trusted route.
5. **Collect evidence**: record security-component events showing when the trusted route was started, which security function started it, and whether it succeeded or failed. Produce test evidence (for example: automated user interface verification screenshots or recorded test runs) showing that the trusted indicator/display area is present and cannot be spoofed.
6. **Add regression checks** in continuous integration/continuous delivery (CI/CD) and release pipelines to stop “lookalike” prompts being reintroduced (for example: policy checks that confirm trusted prompts are triggered only through the security component and secure user interface mechanism).

###### WHO
- **Security architect / identity and access management (IAM) or privileged access management (PAM) engineer**: defines the security functions and where the trusted prompt must be integrated.
- **Application security lead / platform engineer**: implements the secure user interface invocation and configures the non-spoofable indicator.
- **Identity/PAM/single sign-on (SSO) administrator**: configures the organisation’s identity flows and how the trusted prompt behaves.
- **Quality assurance (QA) automation engineer**: builds automated tests and captures evidence to confirm the trusted prompt is present and started correctly.

###### Acceptance criteria
- Users can clearly recognise the trusted communication route using a **fixed, consistent, non-imitable indicator/display area** controlled by the security component.
- The trusted prompt cannot be spoofed by the business application (confirmed by tests attempting to overlay or replace the prompt; other applications cannot access the trusted display area).
- For each mapped user journey, the trusted route is **automatically started** by the defined security functions at the correct decision point.
- Audit and test evidence exists showing trusted route start events and successful verification that the trusted indicator/display area appears as designed.

###### Actions Required for Compliance

- [ ] Define and document the system security functions that must create the trusted communication path (sc-11.01_odp), and link them to user journeys.
- [ ] Choose and set up a secure user interface for the platform, identity system, and privileged access management (PAM) that creates a trusted screen that cannot be imitated or faked.
- [ ] Set up the trusted prompt so it is only displayed or triggered by the security component (not by the business application).
- [ ] Set up a fixed, consistent trusted indicator or region, and check that other applications cannot place content over it or copy it to look the same.
- [ ] Set up automatic start so the trusted path is activated at the right moment in every security decision flow.
- [ ] Add logging and automated user interface (UI) tests to produce audit-ready evidence that the trusted path was used correctly and that it behaved as expected.


---

### SC-12 — Cryptographic Key Establishment and Management (Control)

This requirement is about making sure that whenever your organisation uses encryption, the secret keys that make encryption work are created, managed, and taken out of use properly. If keys are created with unapproved tools, sent using the wrong method, stored in the wrong place, accessible to too many people, not updated on time, or not truly destroyed when they are no longer needed, attackers could steal them and use them to read or change protected information, pretend to be trusted services, or weaken trust in digital certificates.

To meet this expectation, the organisation must generate keys using cryptographic modules that have been validated under the Federal Information Processing Standards Publication 140-3 (FIPS 140-3), share keys only through approved channels, and store keys only in approved managed key storage such as a hardware security module (HSM) or a key management system (KMS). Access must be limited to the minimum permissions needed. Keys must be replaced (rotated) according to the organisation’s key-management policy, and old keys must be securely destroyed using secure erase or crypto-shredding.

The organisation must also ensure that every trust store contains only approved trust anchors, and that externally visible and internal certificates are included only when they are approved.

##### Policy-driven KMS/HSM key lifecycle with approved trust anchors

- Category: Software
- Priority: Critical

###### WHAT
Set up a central, policy-driven service to manage cryptographic keys and certificates throughout their full life cycle, using cryptographic modules that have been validated to **FIPS 140-3** (hardware security modules / key management services). Make sure every encryption key is generated, sent to the right places, stored, accessed, renewed (rotated), and permanently removed through this service. Also ensure every trust store used by the application contains only approved trust anchors.

###### WHY (control requirement)
**Security Control SC-12** requires the organisation to “establish and manage cryptographic keys when cryptography is employed within the system” in line with the organisation’s key management requirements (**SC-12 ODP**). This includes: FIPS 140-3 validated key generation, approved ways of distributing keys, storing keys in hardware security modules / key management services, least-privilege access, renewing keys according to policy, secure destruction (secure erase / crypto-shredding), and trust stores limited to approved anchors.

###### HOW (specific steps/approach)
1. **List where encryption is used** in the application and its supporting components (for example: Transport Layer Security (TLS) termination, mutual TLS (mTLS), database encryption, message signing/encryption, code signing, and S/MIME if used). For each use, identify the required key/certificate type.
2. **Standardise key generation and certificate issuance** so that keys are created inside the central key management service / hardware security module using only **FIPS 140-3 validated modules**. Issue and renew certificates using controlled templates and workflows.
3. **Use only approved distribution routes** by connecting applications and services to the key service application programming interfaces (APIs) and workflows. Do not allow manual copying of keys/certificates or any ad-hoc transfer. Block or detect any non-approved distribution paths.
4. **Store and protect keys in hardware security modules / key management services** and enforce **least-privilege** access. Use workload identities for services, and separate roles for human or administrator key management.
5. **Automate renewal and retirement** using “policy as code”. Set rotation intervals, renewal time windows, and disable/retire triggers that match the organisation’s key management policy. Ensure applications automatically switch to new keys/certificates without manual changes.
6. **Permanently remove retired keys and certificates** through the key service (crypto-shredding / secure deletion), and keep records of removal actions for audit purposes.
7. **Control trust stores** by maintaining an approved trust-anchor register and deploying trust stores from a single source of truth (for example, configuration management / GitOps). Include external-facing and internal-operation certificates/anchors only when they are explicitly approved.
8. **Create audit-ready evidence** by keeping tamper-resistant records of key life cycle events (generate/issue/rotate/disable/delete) and trust-store deployments and changes, including links to approvals and change records.

###### WHO
- **Security Architect / Cryptography Lead**: defines key/certificate types, trust-anchor governance, and policy-as-code requirements.
- **Platform/Cloud Engineer / Operational Technology (OT) Gateway Engineer**: implements key management service / hardware security module integration, service connections, and enforcement of approved distribution routes.
- **Application Owner / DevOps Lead**: updates application settings so the application uses keys/certificates from the central service.
- **Identity and Access Management (IAM) Administrator**: sets up least-privilege roles and workload identity access.
- **Compliance / Assurance**: checks that evidence is complete against SC-12 and SC-12 ODP.

###### Acceptance criteria
- For every identified encryption use-case, key/certificate generation and life cycle management are carried out via the central key management service / hardware security module using **FIPS 140-3 validated modules**.
- Keys/certificates are distributed only through the approved key-service workflows/APIs; any non-approved manual copying routes are blocked or detectable.
- Keys are stored in hardware security modules / key management services; access is enforced using least-privilege roles and workload identities.
- Key renewal/rotation and retirement follow the organisation’s policy; key removal events are recorded and carried out using secure deletion/crypto-shredding.
- Every trust store used by the application contains only approved trust anchors; trust-store changes are traceable to approvals and logged.
- Audit logs provide evidence of key life cycle actions and trust-store deployments/changes for the relevant environments (production/test/disaster recovery as applicable).

###### Actions Required for Compliance

- [ ] List all locations where the application and its supporting components use encryption, and identify which types of keys and certificates are needed.
- [ ] Choose and set up a central key management service and hardware security module (KMS/HSM) that uses only cryptographic modules validated to Federal Information Processing Standards (FIPS) 140-3 for key generation.
- [ ] Connect applications and services so they can request, renew, rotate, and retire encryption keys and certificates through the key service’s application programming interfaces (APIs) and workflows—without any manual copying of keys or certificates.
- [ ] Set up least-privilege access controls for key use and key administration by using workload identities and separate roles for administrators.
- [ ] Set up automated rules to rotate, renew, and retire credentials, including the conditions that should disable or retire them, and how applications should re-connect or re-bind to use the updated credentials.
- [ ] Enable secure destruction (cryptographic shredding/secure deletion) through the key management service, and keep records of the destruction events.
- [ ] Create and enforce an approved list of trust anchors, and distribute the trust stores from a single agreed source of truth, with a record of all changes.


---

#### SC-12.1 — Availability (Enhancement)

This requirement is about making sure your protected information remains available even if a user can no longer use the secret needed to unlock it—for example, if they forget a passphrase. If there are no clear recovery arrangements, a lost key could mean files, messages, or systems cannot be accessed again, leading to delays, lost productivity, and possible business disruption.

To meet this expectation, the organisation must plan for key loss and keep documented, up-to-date, step-by-step procedures that explain:
- how keys are created,
- how they are handled day to day, and
- exactly how access is recovered when a user can no longer use their key.

Where appropriate, the organisation must put recovery arrangements in place (such as key escrow) so authorised staff can restore access.

The organisation must also ensure the system’s design and settings support recovery, keep audit records showing that recovery actions were carried out, and include this “availability even if keys are lost” approach in the system’s security plan.

##### Key escrow and auditable recovery workflow for lost user keys

- Category: Software
- Priority: Critical

###### WHAT
Set up a way to recover the application’s encryption keys if they are lost (for example, by storing backup copies of the keys that protect other keys, and/or backup copies of the keys used to protect the data). Also put in place a controlled, auditable process for restoring access when a user loses their cryptographic keys (for example, a forgotten passphrase).

###### WHY (control requirement)
SC-12(1) (Availability enhancement) requires the organisation to **keep information available if cryptographic keys are lost by users**. The guidance notes that **storing encryption keys in escrow (backup storage) is common** to ensure availability when keys are lost (for example, a forgotten passphrase). Without a recovery route, lost keys can make data permanently inaccessible.

###### HOW (specific steps/approach)
1. **Identify key-loss scenarios and what is covered by encryption**: list where the application uses encryption keys (for data stored and, where relevant, data sent over networks) and clearly show which keys are provided by users (for example, keys derived from a passphrase or keys used on the client side) versus keys managed centrally.
2. **Set up escrow/backup for keys that can be recovered (where appropriate)**: configure a central key management approach (for example, a key management service (KMS), hardware security module (HSM), or key vault pattern) so that the encryption keys used to protect application data can be **recovered from escrowed/backup-protected key material**. Make sure recovered keys can be linked back to the correct tenant, account, or service identity and used to restore access without broadly exposing unencrypted (plaintext) keys.
3. **Create a controlled recovery workflow**: implement an operator process that requires (a) identity checks and stronger authentication (step-up authentication) for recovery staff, (b) separation of duties (requester, approver, executor), and (c) explicit authorisation checks before any recovery action is carried out.
4. **Write runbooks for user key-loss**: create step-by-step instructions for at least these scenarios: forgotten passphrase, lost device, and account lockout. Include what evidence is required, how to find the correct escrowed key material, how to perform the recovery, and how to confirm that access to the intended data has been restored.
5. **Use tamper-resistant audit logging and keep evidence**: record every key recovery-related activity (request, approval, execution, key material retrieval/unwrapping, re-linking to the correct identity, and verification) in the enterprise security information and event management (SIEM) system, with protected retention and integrity controls.
6. **Update the system security plan and follow change management**: update the system security plan and related key management documentation to reference the recovery procedures and the escrow mechanism. Ensure changes to recovery logic are managed through the organisation’s change and configuration management process.

###### WHO
- **Application Owner / Data Protection Lead**: owns the key-loss availability design and defines the recovery scope.
- **Security Engineering / identity and access management (IAM) and KMS/HSM Administrators**: implement the escrow/backup configuration and the recovery workflow controls.
- **Privileged Access Management (PAM) / Security Operations**: ensure step-up authentication, approvals, and audit logging to the SIEM.
- **Service Desk / authorised recovery operators**: carry out recovery using the documented runbooks under the approved workflow.

###### Acceptance criteria
- For each identified user key-loss scenario, there is a recovery method that restores access to the intended encrypted information (or a documented, approved exception where recovery is not technically possible).
- Escrow/backup of relevant encryption key material is implemented in the approved KMS/HSM/key vault, and recovery re-links keys to the correct identity context.
- Recovery actions must use authorised workflow controls (step-up authentication, approvals, separation of duties) and cannot be performed through unauthorised direct access.
- All recovery activities produce auditable, tamper-resistant logs in the enterprise SIEM, including who did what, when, which key material was used, and the verification results.
- Up-to-date runbooks are documented and in place, and the system security plan references them.
- A test or tabletop exercise shows that a simulated forgotten passphrase/key-loss event restores access within the defined operational expectations.

###### Actions Required for Compliance

- [ ] List all types of encryption keys the application uses, and identify which ones users could lose (for example, keys derived from a passphrase that a user forgets).
- [ ] Set up key management services (KMS), hardware security modules (HSMs), and key vault escrow or backup so that recoverable key material (key encryption keys (KEKs), data encryption keys (DEKs), or equivalent wrapped forms) can be restored. Also ensure that any recovered keys can be linked back to the correct user or system identity context.
- [ ] Set up an authorised recovery process that requires additional identity checks (step-up authentication), ensures different people handle different recovery tasks (separation of duties), and includes clear approval checkpoints that recovery operators must obtain before proceeding.
- [ ] Create and get approval for step-by-step instructions (runbooks) for situations where a user’s key is lost, such as a forgotten passphrase, a lost device, or account lockout. Include what proof (evidence) is required and the checks needed to confirm the issue and resolution.
- [ ] Enable tamper-resistant audit logging for key recovery events (request, approval, execution, unwrapping, re-association, and verification) and send the logs to security information and event management (SIEM) with retention controls.
- [ ] Update the system security plan and key management documents to include the recovery procedures and the escrow mechanism that has been put in place. Then confirm this by running a recovery test or a tabletop exercise.


---

#### SC-12.2 — Symmetric Keys (Enhancement)

This requirement is about ensuring the secret “lock-and-key” codes used to protect data are created, safeguarded, and sent to the correct systems in a safe, approved way. If these keys are created informally, stored carelessly, or shared outside the proper process, an attacker could steal them and then read or change protected information, or pretend to be trusted systems.

To meet this expectation, the organisation must use key-management tools and documented steps that are validated under the National Institute of Standards and Technology Federal Information Processing Standards (NIST FIPS) to generate symmetric keys (the same key is used to both lock and unlock data). The organisation must keep these keys protected from unauthorised access throughout their whole life, and distribute them only using the approved method to authorised recipients.

The organisation must also keep clear written procedures, document how this is handled in system design and configuration records, keep audit evidence showing key creation, protection, and distribution, and maintain an up-to-date list of the approved, validated key-management products used in practice.

##### FIPS-validated KMS/HSM for symmetric key generation and automated distribution

- Category: Software
- Priority: Critical

###### WHAT
Implement **symmetric key creation, lifecycle management, and distribution** using **{{ insert: param, sc-12.02_odp }} key management technology and processes**, ensuring symmetric key material is **created and handled only** by approved, **FIPS-validated** cryptographic components and workflows.

###### WHY (control requirement)
SC-12(2) enhancement requires the organisation to **create, control, and distribute symmetric cryptographic keys** using the specified **key management technology and processes**. This stops keys being created informally, handled insecurely, or shared without authorisation.

###### HOW (specific steps/approach)
1. **Choose and record FIPS-validated key-management technology**: keep an official register of the approved cryptographic products used for symmetric key creation/control/distribution (including supplier, product, version/build, and the FIPS validation reference/scope).
2. **Centralise symmetric key creation in a KMS/HSM-supported service**: configure the service so that applications request keys through an application programming interface (API) and workflow, and receive **key identifiers/handles** rather than the raw key material.
3. **Apply key lifecycle controls through the KMS/HSM**: set up role-based authorisation for key creation, change (rotation), and retirement; define key-use rules (who can encrypt and decrypt); and ensure keys are rotated/re-keyed and retired only through the approved workflow.
4. **Automate distribution to authorised recipients/workloads**: link the provisioning process (continuous integration and continuous delivery (CI/CD) or infrastructure-as-code) with the KMS/HSM so that when workloads are deployed, the approved sequence runs: create/select key → grant permission to use it → attach the key identifier to the workload configuration.
5. **Stop manual or informal handling of key material**: block or detect any application paths that try to create, import, or export raw symmetric key material; ensure key material never appears in logs, build outputs, or code/configuration repositories.
6. **Create audit evidence**: enable and retain audit logs from the key-management service covering key creation, permission grants, rotation/re-keying, and retirement; send logs to the security information and event management (SIEM) system for audit-ready evidence.

###### WHO (role responsible)
- **Security Architect / Crypto Governance Lead**: owns the FIPS-validated product register and approves the key-management workflows.
- **Platform/Cloud Engineer or OT Systems Engineer (as applicable)**: implements the KMS/HSM connection and automated provisioning.
- **Application Owner / DevOps Lead**: updates applications to request keys from the KMS/HSM and removes any local key creation/import logic.
- **Identity and Access Management (IAM) Engineer**: connects workload/service identities and sets least-privilege authorisation for key use.
- **Security Operations (SOC)**: monitors and retains audit logs and investigates unusual key-management activity.

###### Acceptance criteria
- Symmetric keys used by the application are **created by the approved FIPS-validated key-management technology** (no application-side informal creation/import of raw key material).
- Key distribution happens only through the **approved automated workflow** (the provisioning pipeline grants permission to use keys and attaches key identifiers to workloads).
- The organisation keeps a **current register** of FIPS-validated key-management products (including versions/builds and validation scope).
- Audit logs exist and show, for representative key events: **key creation/selection, permission grants, rotation/re-keying, and retirement**, with traceability to the requesting identities/workflows.
- Attempts to import/export or manually handle raw symmetric key material are prevented or trigger alerts, and it is clearly demonstrated that this is not part of the key creation process.

###### Actions Required for Compliance

- [ ] Create and keep a record (register) of approved Federal Information Processing Standards (FIPS)-validated key-management products. This record must include the specific versions or builds and the scope of what each product is validated to cover, for use in producing, controlling, and distributing symmetric keys.
- [ ] Set up and configure a central key management service backed by a hardware security module (HSM) to generate symmetric encryption keys, and provide applications with the key identifiers or handles.
- [ ] Update applications so they obtain encryption keys from the key management service (KMS) or hardware security module (HSM), and remove any ability to create or import raw symmetric key material.
- [ ] Set up automated workload provisioning that follows the approved steps in order: create or select the key, give the workload permission to use it, and add the key identifier to the workload configuration.
- [ ] Apply the principle of least privilege by limiting access to key lifecycle actions and key usage, using built-in service identities and assigned roles.
- [ ] Enable, keep, and send audit logs about key management—covering key creation, permission approvals, key rotation or re-keying, and key retirement—to the security information and event management (SIEM) system so they can be used as evidence for audits.
- [ ] Add detection and controls to stop or alert on key import, export, or manual handling of key material outside the approved process.


---

#### SC-12.3 — Asymmetric Keys (Enhancement)

This requirement is about ensuring the secret signing keys used to protect important digital activities are created correctly, kept secure, and given to authorised people or services in a controlled way. If these keys are created using the wrong certificates or stored in ordinary software, they could be copied or stolen. That could let criminals pretend to be staff, alter messages, or create fake documents that appear trustworthy.

To meet this requirement, the organisation must create, manage, and distribute asymmetric cryptographic keys only using Department of Defense (DoD)-approved or DoD-issued Medium Hardware Assurance public certificate types, together with approved hardware security tokens. These tokens must keep the user’s private key protected inside the device, so it is not exposed or sent in an unprotected form.

The organisation must be able to demonstrate, using documented procedures and audit records, that for each active user or service identity:
- the correct certificate type and approved token model were used
- the private key could not be exported or copied out during normal operations
- provisioning and distribution were carried out through the approved token-based process, without insecure delivery of private key material.

##### Token-bound asymmetric key generation using approved Medium HA PKI

- Category: Software
- Priority: Critical

###### WHAT
Set up a certificate and key delivery process where **asymmetric key pairs** are created and protected using **Department of Defense (DoD)-approved or DoD-issued Medium Hardware Assurance Public Key Infrastructure (PKI) certificates**, along with **hardware security tokens that keep the user’s private key protected**.

###### WHY (control requirement)
Security and control requirement **SC-12(3)** says the organisation must **create, manage, and distribute asymmetric cryptographic keys using {{ insert: param, sc-12.03_odp }}**. This means the private key must be protected using the approved Medium Hardware Assurance PKI certificate and token approach, and private key information must not be shared in an unsafe way.

###### HOW (specific steps/approach)
1. **Create an approved list (allow-list)** of permitted Medium Hardware Assurance PKI certificate profiles/types and permitted hardware security token models (including any required token features, such as private keys that cannot be exported).
2. **Require token-based key creation**: set up the enrolment/certificate issuing process so that the **Certificate Signing Request (CSR)** (or equivalent key-generation request) is created in a way that the **private key is generated and stays inside the approved token** (cannot be exported or moved), and the PKI issues a certificate only for CSRs that are tied to that token.
3. **Link issuing to identity and proof**: for every issued certificate, keep an auditable record linking: (a) identity/service account, (b) token identifier/model, (c) certificate profile/type, (d) time of issuance, and (e) CSR request identifier.
4. **Control distribution**: send only the **certificate (and enrolment instructions)** to the user/device. Make sure the process clearly prevents exporting or sending private key material (for example: block file export, prevent sending via email or tickets, stop placing on shared drives, and prevent API responses that include private key material).
5. **Run lifecycle controls**: connect certificate revocation and renewal triggers to the identity and PKI processes. When access is removed or tokens are replaced, revoke or update the related certificates according to the organisation’s PKI procedures.
6. **Add checks and monitoring**: build automated checks that reject any certificate request that does not match the approved Medium Hardware Assurance certificate profile/type and the approved token model. Log and alert on any attempted private-key export or any certificate issuance outside the approved process.

###### WHO
- **PKI/Identity Engineering Lead**: designs the token-based enrolment workflow and integrates it with PKI.
- **Security Architect (Cryptography/Key Management)**: confirms the required certificate profile/token settings and that private keys cannot be exported.
- **IAM/Privileged Access Management (PAM) Administrator**: manages the mapping between identities and certificates, and controls privileged access to token operations.
- **Operations/Security Operations Centre (SOC)**: monitors alerts and keeps audit evidence for retention.

###### Acceptance criteria
- For every active user/service identity, the issued asymmetric certificate can be traced to an **approved Medium Hardware Assurance PKI certificate profile/type** and an **approved hardware security token**.
- During normal operation, the private key is **not exportable** and is not sent or stored outside the token (confirmed through workflow tests and audit sampling).
- The distribution process provides only the certificate/enrolment capability; there is **no private key material** in logs, tickets, emails, API responses, or exported files.
- Audit records exist showing the link between identity, token identifier/model, CSR/enrolment request, and certificate issuance details.
- Automated controls stop certificate issuance when the requested certificate profile/type or token model is not approved, and generate alerts for policy violations.

###### Actions Required for Compliance

- [ ] Define and publish allow-lists of approved Medium Hardware Assurance public key infrastructure (PKI) certificate profiles or types, and approved hardware security token models.
- [ ] Set up the certificate request process so that the private and public keys are created inside the approved security token, and so that the certificate signing request (CSR) is linked to the token’s key.
- [ ] Set up automated checks that apply the security policy to every certificate request, and reject any request that does not match the approved certificate profile or type and the approved token model.
- [ ] Issue instruments in a way that creates a traceable, auditable link between the user identity, the token identifier/model, the certificate signing request (CSR) or enrolment request ID, and the certificate issuance details.
- [ ] Secure the distribution so it delivers only certificates (and enrolment instructions). Use clear technical safeguards to prevent private keys from being exported or sent anywhere.
- [ ] Link account access changes (joiners, movers, leavers) and access token updates (revocation and rotation) to the identity lifecycle events, and confirm the behaviour using test cases.
- [ ] Set up monitoring and alerts for attempts to export private keys, certificates being issued outside policy, and misuse of tokens.


---

#### SC-12.6 — Physical Control of Keys (Enhancement)

This requirement is about making sure the secret keys used to protect encrypted information are kept under the organisation’s physical control, even when data is stored with outside providers such as cloud or data-centre companies. Without this, the provider could potentially share the keys with unauthorised people or change them, which could allow others to read, alter, or permanently misuse your protected data.

To meet this expectation, the organisation must clearly list which outside providers store encrypted information, document who is responsible for keeping physical control of the keys, and maintain clear procedures for how keys are created, managed, and recovered. The organisation must also ensure the provider cannot access, disclose, or change the keys, and that system settings and design records show this is enforced.

The organisation should keep evidence of the relevant settings and key-related access activity, regularly review key-related records, and have a practical plan for what to do if key control is ever suspected to be compromised.

##### Customer-managed keys with provider key isolation for external storage

- Category: Manual
- Priority: Critical

###### WHAT
Set up customer-controlled encryption keys (customer-managed cryptographic keys (CMK)) so the organisation keeps physical control of the key material used to encrypt data stored by external service providers (for example, cloud storage, managed databases, and backup/software-as-a-service (SaaS) storage). Configure external providers to use only customer-controlled key identifiers and rules, so the provider cannot reveal or change the key material.

###### WHY (control requirement)
Security control SC-12(6) enhancement requires the organisation to **keep physical control of encryption keys** when information is encrypted by **external service providers**. This provides assurance that stored information cannot be accessed, disclosed, or altered without authorisation.

###### HOW (specific steps/approach)
1. **Create an external-provider encryption and key custody register** that lists each external provider and the specific services that store encrypted information (including production and disaster recovery where relevant), and records which encryption method is used.
2. **Use a key custody approach where the external provider does not receive plaintext key material** (for example, hardware security module (HSM)-backed key management under organisational control, or a cloud key management system (KMS)/HSM model where the provider cannot access plaintext key material). Make sure the provider is configured to encrypt and decrypt using **customer-managed keys** referenced by key identifiers, not provider-held secrets.
3. **Define and document key-custody responsibilities** (for example, Key Custodian, Security Approver, Recovery Controller) and require **dual control** for sensitive key actions (key policy changes, key disablement, rotation, deletion, and recovery activities).
4. **Configure external services to prevent key disclosure or key changes** by enforcing: (a) encryption at rest uses the customer-managed key identifier; (b) the provider cannot change the key identifier or policy without organisational approval; and (c) the provider cannot decrypt without the organisation-controlled key access route.
5. **Apply configuration drift controls** using infrastructure-as-code and safeguards, plus change management, so any deviation from the approved key identifier or policy requires formal approval and can be audited.
6. **Enable and keep audit evidence** from the key management system and the external storage services for: key access, key policy changes, key rotation, key disablement/deletion, and encryption configuration changes; send logs to the security information and event management (SIEM) system.
7. **Update system design documentation and the system security plan** to clearly state the custody model (where the key material sits, who can access it, and how the external provider is prevented from disclosing or changing keys).

###### WHO
- **Security Architect / Chief Information Security Officer (CISO) Office**: approves the custody model and control objectives.
- **Key Management Owner (for example, Security Engineering)**: implements key custody, defines roles, and sets up audit logging.
- **Cloud/Infrastructure Engineering**: configures external services to use customer-managed keys and implements drift controls.
- **Service Owner / Application Owner**: ensures the application uses the approved encrypted storage services and key identifiers.

###### Acceptance criteria (audit-ready)
- A complete register exists of all external providers and services storing encrypted data for the application, including the associated customer-managed key identifiers.
- Evidence shows the external provider is configured to use **customer-managed keys** (key identifiers and policies) and that the provider does not receive plaintext key material.
- Documented role-based procedures exist for key setup, management, and recovery, including dual control for sensitive actions.
- System design documentation and the system security plan explicitly describe where keys are kept and how enforcement is achieved.
- Audit logs show key access and key policy/encryption configuration changes are recorded, retained, and sent to the SIEM.
- A configuration drift safeguard mechanism exists and is evidenced (for example, infrastructure-as-code policy checks and change approvals) for encryption key identifier and policy settings.

###### Actions Required for Compliance

- [ ] Create and keep an external provider encryption and key custody register for every service that stores the application’s encrypted data.
- [ ] Choose and implement a key custody approach that ensures the external provider cannot access the unencrypted key data (for example, using a hardware security module (HSM) under the organisation’s control, or using a customer-controlled key management system (KMS)).
- [ ] Define the responsibilities for key custody and document the procedures for creating, managing, rotating, disabling, deleting, and recovering keys, using dual control (two authorised people working together).
- [ ] Set up each external storage service to use encryption keys and rules chosen and managed by the customer, and prevent the service provider from changing the encryption key identifiers or rules unless the organisation has approved it.
- [ ] Put in place drift controls (for example, rules in infrastructure-as-code) to make sure encryption key identifier and policy settings stay compliant.
- [ ] Turn on and send audit logs for important access events and for changes to key and encryption settings to the security information and event management (SIEM) system, keeping them for the period required by policy.
- [ ] Update the system security plan and system design documents to show the main custody locations for encryption keys and how the provider keeps those keys isolated and protected.


---

### SC-13 — Cryptographic Protection (Control)

This requirement is about ensuring sensitive information is properly protected using approved methods of “scrambling” and checks, so that even if data is intercepted or stolen, it cannot be read or misused. Without this, confidential files could be exposed when stored, messages could be read or changed while travelling between systems, signed items could be forged, and people who are generally allowed to access information but are not formally approved could still gain access to information they should not see.

To meet this expectation, the organisation must first identify which protection needs apply to its systems, including: data stored on devices, data moving across networks, digital signatures, and situations where information must be kept separate between groups. It must then put the required encryption in place for each of these uses, using Federal Information Processing Standards (FIPS)-validated encryption for digital signatures and National Security Agency (NSA)-approved encryption for classified data. The organisation must also keep clear documentation and records showing what was selected, how it is configured, and that it is working as intended.

##### Approved cryptography mapping and enforcement for data, signatures, separation

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable “approved encryption and protection” baseline for the application that:
- Lists the organisation’s approved cryptographic uses in scope: **data at rest**, **data in transit**, **digital signatures**, and **separation of information**.
- Uses the organisation-approved encryption/protection types for each use: **FIPS-validated cryptography for digital signatures** and **NSA-approved cryptography for classified data** (covering protection for both **data at rest** and **data in transit**).
- Ensures the running system uses only approved cryptographic modules/algorithms and that proof (evidence) is kept.

###### WHY (control requirement)
The SC-13 guidance requires cryptography to be used in line with relevant laws and policies, and to follow widely used cryptographic standards (for example, **FIPS-validated** for digital signatures and **NSA-approved** for classified data). The organisation’s requirements also specify that **cryptographic uses must be defined**, and that the **type of cryptography required for each use must be defined**.

###### HOW (specific steps/approach)
1. **Create a per-application cryptographic use inventory** that links each in-scope use (data at rest, data in transit, digital signatures, separation of information) to the specific application parts and data flows involved (for example: database/storage encryption, TLS endpoints, signing/verification services, and any cryptographic isolation methods used for separation).
2. **Create a cryptography mapping matrix** that clearly matches each use to the required cryptography type from the organisation’s requirements:
   - Digital signatures → **FIPS-validated cryptography** (approved algorithms, hash functions, signature formats, and the signing/verification component, including any hardware security module (HSM) integration).
   - Classified data → **NSA-approved cryptography** for both **at-rest** and **in-transit** protection.
3. **Only allow approved cryptographic modules through configuration and build-time controls**:
   - Configure Transport Layer Security (TLS) and network security to allow only approved protocol versions and cipher suites, and make sure certificate checks match the approved baseline.
   - Configure encryption for storage and backups so that only approved **NSA-approved** cryptographic mechanisms are used for classified data.
   - Configure digital signature services so they use only **FIPS-validated** cryptographic modules (for example, approved libraries or approved HSM profiles) and record the module identifiers.
4. **Add automated checks to detect changes and block unsafe deployments**:
   - Add continuous integration/continuous delivery (CI/CD) checks that compare the deployed settings (TLS settings, encryption-at-rest settings, and signature service module/library identifiers) against the approved baseline.
   - Add runtime and configuration verification (for example, periodic configuration reviews) to detect and alert on any deviation from approved cryptography.
5. **Keep audit-ready evidence**:
   - Keep current **FIPS validation evidence** for signature modules and current **NSA-approved cryptography evidence** for classified-data encryption and in-transit protection.
   - Store the cryptographic use inventory, cryptography mapping matrix, system design/configuration records, and the results of automated checks.
   - Make sure the System Security Plan (or equivalent security planning document) points to the cryptographic protection requirements and explains how they are implemented.

###### WHO (role responsible)
- **Application Security Architect / Security Engineering Lead**: owns the cryptographic use inventory and mapping matrix.
- **Platform/Infrastructure Engineer**: implements TLS and encryption-at-rest configuration and key-management integration.
- **Application/Integration Engineer**: implements digital signature service configuration using approved **FIPS-validated** modules.
- **DevSecOps / CI/CD Engineer**: implements policy-as-code checks and deployment gates.
- **Security Compliance/Assurance**: checks that evidence is complete and that it is ready for audit.

###### Acceptance criteria
- The application has a documented cryptographic use inventory covering **data at rest, data in transit, digital signatures, and separation of information**.
- For each use, the cryptography mapping matrix shows the required cryptography type: **FIPS-validated for digital signatures** and **NSA-approved for classified data** (for both at rest and in transit).
- Deployed configurations for TLS, encryption-at-rest, and signature services are verified by automated checks against the approved baseline.
- Evidence is available and up to date: FIPS validation artefacts for signature modules, NSA-approved cryptography artefacts for classified-data protection, and audit logs/results of configuration verification.
- The System Security Plan (or equivalent) references how cryptographic protection is implemented and matches the documented baseline.

###### Actions Required for Compliance

- [ ] Document a per-application record of how cryptography is used, covering data stored on systems (data at rest), data sent over networks (data in transit), digital signatures, and separation of information.
- [ ] Create a cryptography mapping matrix that links each use to either **Federal Information Processing Standards (FIPS)-validated digital signatures** or **National Security Agency (NSA)-approved cryptography** for **classified data stored at rest and transmitted in transit**.
- [ ] Set up Transport Layer Security (TLS) and certificate checks to use only the approved encryption settings to protect data while it is being sent.
- [ ] Set up encryption for data stored on disk and encryption for backups so that, for classified information, only cryptography approved by the United States National Security Agency (NSA) is used.
- [ ] Set up digital signature services to use only FIPS-validated cryptographic modules, and record the identifiers for the module, library, and hardware security module (HSM).
- [ ] Set up continuous integration and continuous delivery (CI/CD) controls using policy-as-code, and add deployment gates that check the cryptography settings used in deployments against the approved baseline before releases are allowed.
- [ ] Collect and keep current Federal Information Processing Standards (FIPS) and National Security Agency (NSA) approval evidence, and store automated verification results for audit purposes.


---

### SC-15 — Collaborative Computing Devices and Applications (Control)

This requirement is about preventing people from secretly switching on shared meeting tools—such as cameras, microphones, connected whiteboards, and remote meeting devices—from a distance. Without these controls, someone could turn these tools on without the people in the room knowing, which could lead to privacy breaches, covert recording, or disruption during meetings and work.

To meet this expectation, the organisation must set clear rules so that remote activation is blocked by default and only allowed for three specific purposes:
- authorised incident response
- emergency maintenance
- accessibility support sessions that have been approved by the system owner

For accessibility support, the system must confirm that the system owner’s approval exists and is still valid before anything is switched on.

In addition, whenever a device or application is turned on while people are physically present, it must provide an unmistakable, immediate signal that it is in use, and this signal must match the actual on/off state.

##### Brokered remote activation with deny-by-default and in-use indicators

- Category: Software
- Priority: Critical

###### WHAT
Set up a central control that checks identity and approval before allowing remote activation of collaborative computing devices and applications (for example: meeting endpoints, networked whiteboards, cameras, and microphones). By default, remote activation is blocked, and it is only allowed for:
1) authorised incident response,
2) emergency maintenance, and
3) accessibility support that has been approved by the system owner.

Also ensure that if activation happens while users are physically present, the device or application shows a clear, unmistakable indication that matches the real activation state.

###### WHY (control requirement)
Security and privacy control SC-15 requires that collaborative computing devices and applications cannot be secretly activated remotely, and that users are given a clear indication when devices or applications are activated. The organisation-defined exception parameter (sc-15_odp) lists the only permitted remote activation purposes: authorised incident response, emergency maintenance, and system owner-approved accessibility support sessions.

###### HOW (specific steps/approach)
###### 1) Set up and enforce exception-based authorisation (deny by default)
- Create an “exception taxonomy” in the remote activation broker aligned to sc-15_odp: **incident response**, **emergency maintenance**, **accessibility support**.
- Configure the collaboration and device control system so that **remote activation endpoints only accept a broker-issued, short-lived, limited-scope authorisation token**. All other remote activation routes must be blocked or disabled.

###### 2) Perform identity checks first for each exception type
- Require strong authentication (integrated with the organisation’s identity provider) for all remote activation requests.
- For **incident response** and **emergency maintenance**, require a linked ticket or work order reference, and check the requester’s role and entitlement before issuing a token.
- For **accessibility support**, require a **system owner approval** that exists and is valid at the time of activation (for example, not expired or revoked) before issuing a token.

###### 3) Show “in use” status to users where activation happens
- Ensure the broker’s activation event is sent to the relevant endpoint user interface so that when activation occurs, users who are physically present receive an **obvious on-the-spot signal** (for example: a camera or microphone “in use” light, a meeting-room overlay, or a device screen banner) that reflects the real activation state.
- Ensure deactivation removes the indicator.

###### 4) Keep audit evidence and enable detection
- Record every remote activation request, authorisation decision, token issuance, and activation/deactivation result (including exception type, requester identity, ticket/work order reference, and for accessibility support the system owner approval reference and validity).
- Monitor for and detect unusual activation attempts (for example: outside working hours, repeated failures, or activation outside approved time windows).

###### WHO
- **Application/Platform Owner**: responsible for implementing the remote activation broker and integrating it with endpoints.
- **Security Engineering / Identity and Access Management (IAM) Team**: implements identity checks, token issuance, and approval validation.
- **Service Desk / Incident Response Lead**: provides incident response and emergency maintenance ticket or work order references.
- **System Owner (for each application/device area)**: grants and maintains the validity of accessibility support approvals.

###### Acceptance criteria
- Remote activation of collaborative devices and applications is **blocked by default**; only broker-issued, short-lived authorisations allow activation.
- Remote activation works only for the three sc-15_odp exception purposes, with correct requester entitlement and required supporting evidence.
- For accessibility support, activation is denied unless a **valid system owner approval** is in place at the time of the request.
- When activation occurs with users physically present, the endpoint provides an **explicit, unmistakable indication** that matches the actual activation state (confirmed through testing and observation).
- Audit records include enough information to show: requester identity, exception type, evidence references, approval validity (where applicable), token issuance, and the activation outcome.

###### Actions Required for Compliance

- [ ] Set up a remote activation service that issues short-lived, limited-use authorisation tokens only after checks that are triggered by exceptions.
- [ ] Block or disable direct remote activation for collaborative devices and applications, so activation is only possible using tokens issued by the broker.
- [ ] Create and enforce a clear set of categories for exceptions covering incident response, emergency maintenance, and accessibility support, aligned to **SC-15 ODP**.
- [ ] Set up the broker to work with the organisation’s identity system, including multi-factor authentication (MFA) and conditional access, and check that each requester is allowed to make the request for the relevant exception type.
- [ ] Add a check that the system owner approves accessibility support, including expiry and revocation checks when it is activated.
- [ ] Link device activation and deactivation events to the endpoint’s on-screen display and light (LED) overlays, so people nearby get a clear, unmistakable signal that the device is in use.
- [ ] Set up audit logging and security information and event management (SIEM) alerts for activation requests, decisions, token issuance, and activation outcomes.


---

#### SC-15.1 — Physical or Logical Disconnect (Enhancement)

This expectation is about making sure people can clearly and easily stop using shared collaboration tools when their session ends, so they are not left accidentally still connected. If participants do not properly end a shared session, or if their access is removed incorrectly, they could unintentionally keep contributing or still be able to view information. This increases the risk that organisational information could be misused or exposed after the meeting or work session has finished.

The organisation must provide a sensible way to disconnect from shared collaboration devices. This can be a simple button or menu option that participants can use themselves, or it can happen automatically when the session ends or when a defined condition is met. The disconnect option must still be available after the collaboration, be easy to use without complicated steps, and be supported by clear instructions that match what users see on screen. The organisation should also be able to show, using records, that the disconnect happened for the correct person and the correct session.

##### Session-scoped logical disconnect for collaboration tools

- Category: Software
- Priority: Critical

###### WHAT
Implement a **logical disconnect** for collaborative computing devices (for example: shared documents, whiteboards, chat spaces, co-authoring sessions, and screen sharing). This should let participants **end their session, leave, or disconnect** easily. It should also support **automatic disconnect** when the collaboration session ends or when a defined condition occurs.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) **Security and Privacy Controls SC-15(1) Enhancement** requires: “Provide {{ insert: param, sc-15.01_odp }} disconnect of collaborative computing devices in a manner that supports ease of use.” With **sc-15.01_odp = logical**, the organisation must ensure participants can reliably and easily stop their logical participation, so lingering access cannot be misused.

###### HOW (specific steps/approach)
1. **Session-based access**: Configure collaboration tools so participant access is **linked to a specific collaboration session/meeting instance** (not a long-term permission). Ensure the “Leave/End/Disconnect” option **immediately stops** further collaboration actions for that participant (for example: editing, messaging, co-authoring, and screen sharing).
2. **Clear manual disconnect option (user experience)**: Add or standardise a **single, obvious control** that participants can use (for example: “Leave session”, “End collaboration”, or “Disconnect”). Make it available **after the collaboration session** (for example: on the session page, meeting sidebar, or post-session summary screen). Keep it simple (target: one action, with optional confirmation only).
3. **Automatic disconnect**: Turn on tool-supported automatic disconnect/revocation based on defined conditions such as **meeting/session end**, **host end**, and/or an **inactivity timeout**. Ensure automatic disconnect **removes the participant’s session-based permissions** (not just hides the interface).
4. **Identity integration**: Ensure disconnect truly ends access by integrating with the organisation’s identity provider (IdP) and/or the tool’s session token/session entitlement model, so that leaving ends authorisation for that session.
5. **Audit evidence**: Record and retain audit information showing **who disconnected**, **which session**, **the time**, and whether the disconnect was **manual or automatic**. Ensure logs are sent to the **security information and event management (SIEM)** system for audit-ready retrieval.
6. **Participant guidance**: Publish short, role-appropriate guidance that matches the interface exactly (button names, where it appears, and what “disconnected” means). Include a brief instruction for contractors and partners.

###### WHO
- **Application/Collaboration Platform Owner**: responsible for configuring session-based access and tool settings.
- **Security Engineering / Identity and Access Management (IAM) Team**: responsible for identity integration and ensuring disconnect removes authorisation.
- **Security Operations Centre (SOC) / SIEM Team**: responsible for sending logs, retaining them, and alerting on missing or late disconnect patterns.
- **Service Desk / Training Owner**: responsible for participant guidance content and distribution.

###### Acceptance criteria
- For each in-scope collaboration tool, a participant can perform a **manual logical disconnect** using an obvious control with minimal steps, and the participant cannot perform collaboration actions after disconnect.
- For each in-scope collaboration tool, **automatic disconnect** happens when the session ends and/or when inactivity timeout triggers, and authorisation is revoked (not just interface changes).
- Audit evidence exists for each session showing **participant identity, session identifier, disconnect time, and disconnect type (manual/automatic)**.
- Participant guidance matches the deployed interface and is available at the point of use (for example: a help link from the session interface).

###### Actions Required for Compliance

- [ ] List all shared computing devices used to share organisational information, and identify which ones support permissions that apply only during an active session and automatically leave or disconnect when the session ends.
- [ ] Set up each tool so participant access lasts only for the current session, and is removed when the participant chooses **Leave**, **End**, or **Disconnect**.
- [ ] Set up automatic disconnection when a session ends and/or when there is inactivity, so it removes access permissions (revokes authorisation) rather than only updating what the user interface shows.
- [ ] Provide a standard “disconnect” button in the participant-facing manual controls (one clear action) that stays visible on the session screen after the collaboration ends
- [ ] Link disconnect events to the organisation’s identity and session system, and make sure the specific session is properly ended.
- [ ] Set up audit records for manual versus automatic disconnections, including the user, session identification, and the time of the event. Send these records to the security information and event management (SIEM) system and keep them for the required audit retention period.
- [ ] Publish and check participant guidance so it uses the exact same wording as the disconnect control shown in the user interface (UI), and refers to its exact location.


---

#### SC-15.3 — Disabling and Removal in Secure Work Areas (Enhancement)

This requirement is about ensuring that, when computers are installed in the most secure rooms used for highly sensitive information, the tools that let people chat, share screens, take part in video calls, or collaborate on documents are turned off or removed. If this is not done, staff could accidentally or intentionally use these collaboration features inside secure work areas, which could allow unauthorised listening, recording, or sharing of sensitive conversations and information.

To meet this requirement, the organisation must keep a written, up-to-date list of every secure work area where Secret-and-above information is handled (including secure compartmented information facilities (SCIFs) and other approved secure rooms). It must also keep a written list of the specific collaboration devices and applications that must be disabled or removed on federal on-premises computers, and on their associated virtual copies, when those computers are located in those rooms.

The organisation must set out this rule in its procedures, document how the disabling or removal is carried out, apply it to both the physical computers and their virtual instances, restrict who is allowed to turn the features back on, and keep evidence that the controls worked. This evidence must include audit records and retained documentation, along with periodic checks to confirm nothing has been missed or re-enabled.

##### Block/remove collaboration apps in SCIFs via secure-work-area profiles

- Category: Software
- Priority: Critical

###### WHAT
When federal on-premises computers (and their associated virtual machines) are located in {{sc-15.03_odp.02}} (for example, secure facilities for classified information (SCIFs) and other approved Secret+ secure work areas), disable or remove all collaborative computing devices and applications listed for {{sc-15.03_odp.01}}.

###### WHY (control requirement)
The SC-15(3) enhancement requires that collaborative computing devices and applications are **disabled or removed** from **systems or parts of systems** when those systems are in **secure work areas**. Guidance notes that if this is not done, it can allow compromises such as **listening in on conversations**.

###### HOW (specific approach)
Set up a centrally managed and auditable way to enforce a “Secure Work Area Collaboration Restriction Profile” on both physical computers and their associated virtual machines.

1. **Authoritative secure-work-area inventory**: Keep a controlled, up-to-date list of all approved Secret+ secure work areas (SCIFs and others) and their identifiers (for example, site/room codes, network segments, access-control zones).
2. **Authoritative in-scope collaboration inventory**: Keep a controlled list of the collaborative computing devices and applications that must be disabled or removed on federal on-premises computers and their associated virtual machines (for example, collaboration software and collaboration-capable features such as chat, video, and screen sharing, where those are within scope).
3. **Define enforcement profiles for each secure work area**: For each secure work area, define a profile that either:
   - **Removes** in-scope collaboration applications (preferred where possible), or
   - **Blocks use** and disables collaboration-capable features (where removal would break dependencies).
4. **Enforce through computer/virtual machine configuration management**:
   - Apply the profile automatically based on **computer/virtual machine assignment** to a secure work area and/or **secure work area detection** (for example, location tag, network access control posture, network zone/virtual LAN (VLAN), or asset management location).
   - Make enforcement **preventive** (the applications cannot be started or used), not just hidden.
5. **Apply consistently to physical computers and virtual machines**:
   - Use standard “golden” images and/or per-virtual-machine configuration so the same profile is applied to associated virtual machines.
   - Ensure that re-imaging, virtual machine moves, and failover do not bypass the profile.
6. **Change control and prevent re-enabling**:
   - Limit who can change or override the profile, and require approved change requests for any exception.
7. **Audit evidence and regular checks**:
   - Produce audit logs showing when the profile was applied or removed and the enforcement status during the secure work area period.
   - Carry out regular checks that in-scope collaboration applications are missing/blocked and that no overrides have been applied.

###### WHO
- **Security Engineering / Compliance**: Own the secure work area list, the in-scope collaboration inventory, and the profile definitions.
- **Endpoint/Virtualisation Engineering (IT Operations)**: Build and run the enforcement through endpoint management and virtual machine configuration.
- **Privileged Access / Change Management (IT Governance)**: Enforce approval workflows and restrict actions to re-enable or override.
- **Internal Audit / Security Assurance**: Check the evidence and the results of regular checks.

###### Acceptance criteria
- For every endpoint/virtual machine assigned to an approved Secret+ secure work area, all in-scope collaborative computing devices/applications are **disabled or removed** (not merely hidden) according to the defined profile.
- Enforcement applies to both **physical endpoints** and their **associated virtual instances**.
- Audit evidence is available showing profile application and enforcement status during secure work area periods.
- Regular verification confirms no in-scope collaboration applications/features are present or can be used, and any exceptions are controlled through approved change processes.

###### Actions Required for Compliance

- [ ] Create and keep an official list of approved Secret+ secure work areas (secure compartmented information facilities (SCIFs) and others). Give each area a unique identifier that is used to trigger enforcement actions.
- [ ] Create and keep an up-to-date, official list of the in-scope shared computing devices and applications that must be disabled or removed from federal on-premises endpoints and their related virtual instances.
- [ ] Create a version-controlled collaboration restriction profile for each secure work area. This profile should remove or block every in-scope application or feature.
- [ ] Set up endpoint management so that, as soon as devices are assigned to (or found in) the secure work area, the required profile is applied automatically—so that apps cannot be started or used.
- [ ] Set up virtual machine (VM) and image/automation controls so that related virtual instances use the same security and configuration profile, and cannot avoid it when moving to another system or during failover.
- [ ] Restrict and regularly check (audit) any ability to override, re-enable, or exempt the profile, using approved change control and privileged access controls.
- [ ] Set up audit logs and carry out regular checks to prove that enforcement controls are working during secure work area periods, and to spot any return of in-scope collaboration applications.


---

#### SC-15.4 — Explicitly Indicate Current Participants (Enhancement)

This requirement is about ensuring that, during online meetings and teleconferences used for Department of Defense (DoD)-controlled collaborative sessions, everyone can clearly see who else is currently in the meeting. If this is not in place, an unauthorised person could join without being noticed, and participants might accidentally share information with the wrong people.

To meet this expectation, the organisation must:
- define which types of meetings and teleconferences must display the current participant list, and
- set up the meeting system so that the names (or other clearly identifiable labels) of current participants are visible to all participants throughout the session.

The participant list must update automatically as people join or leave, with no hidden participants. The organisation must document how the participant display works, include this in its security planning, and keep system records showing that the participant list was available and updated during real sessions.

##### Show live participant roster for DoD-controlled meetings

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation’s online meeting and teleconference capability for the defined Department of Defense (DoD)-controlled meeting types ({{ insert: param, sc-15.04_odp }} = *online meetings and teleconferences*) so the system clearly shows the **current participants** to **everyone in the meeting** for the whole session.

###### WHY (control requirement)
Security Control (SC)-15(4) enhancement requires: **“Provide an explicit indication of current participants in {{ insert: param, sc-15.04_odp }}.”** The guidance says this helps stop unauthorised people from joining collaborative computing sessions without others knowing who is participating.

###### HOW (specific steps/approach)
1. **Define the meeting types/workflows** that fall under {{ insert: param, sc-15.04_odp }} and link each one to the meeting platform features/templates used to schedule sessions.
2. **Turn on and standardise the participant list** (“people in this meeting” display) for these meeting types so it is visible to all attendees without any special steps (for example, an always-visible participant list panel, or an easy-to-access participant list during the session).
3. **Make sure the participant list is accurate and up to date** by confirming it automatically updates for **late joiners** and for **people who leave** (including sudden disconnections), and that no attendee can appear as “hidden” or “anonymous” in the participant list for these meeting types.
4. **Stop configuration changes from drifting over time** by enforcing the participant list display setting through central administration policy/configuration management (where supported) and by disabling or limiting meeting modes that hide participant information for DoD-controlled sessions.
5. **Add evidence collection**: enable logging/audit trails that show when people join and leave, and that the participant list was available during sessions; send relevant events to the organisation’s security information and event management (SIEM) system for retention and audit purposes.
6. **Document the mechanism** in the system security plan: state what is shown (names/identifiers), where it appears in the user interface, how it updates, and how the organisation ensures it is enabled for the defined meeting types.

###### WHO
- **Meeting platform owner / Collaboration service owner**: implements and enforces the platform configuration.
- **Security architect / compliance lead**: ensures the implementation meets SC-15(4) and updates the system security plan.
- **Identity and access management (IAM)/single sign-on (SSO) administrator**: ensures joining controls match the organisation’s authorised access approach for DoD-controlled sessions.
- **SIEM/monitoring team**: ensures logs/audit events are collected and kept.

###### Acceptance criteria
- For every DoD-controlled meeting type in {{ insert: param, sc-15.04_odp }}, a participant can see an explicit **current participant list** during the session.
- The participant list **updates automatically** when people join late and when people leave/disconnect.
- No DoD-controlled session allows a participant to join in a way that results in **not appearing in the explicit current-participant list**.
- Central configuration enforcement prevents drift (or drift is identified and fixed before sessions start).
- The system security plan documents the participant list mechanism, and evidence is available (logs/audit records) showing join/leave activity and that the participant list was available.

###### Actions Required for Compliance

- [ ] Identify and record the specific meeting types and workflows that make up {{ insert: param, sc-15.04_odp }}.
- [ ] Turn on the participant list (people in the meeting) for those meeting types, and make sure everyone can see it during the entire session.
- [ ] Disable or limit meeting settings that can hide participants from view (for example, anonymous or hidden participant options) for sessions controlled by the Department of Defense (DoD).
- [ ] Test and confirm that the roster updates correctly when people join late or leave, and verify that these changes are applied automatically and accurately.
- [ ] Apply the roster-display settings through central administration using policy and configuration management, and set up drift detection to identify unauthorised changes.
- [ ] Enable and keep audit and log records for people joining or leaving meetings and for roster availability, and send the relevant events to the security information and event management (SIEM) system.
- [ ] Update the system security plan to explain how the participant indicator works, where it appears in the user interface, what happens when it is updated, and what records or evidence are used to support it.


---

### SC-16 — Transmission of Security and Privacy Attributes (Control)

This requirement ensures that whenever information is sent between different systems, or moves within the same system, it carries the correct labels. These labels tell people how the information must be handled and which privacy rules apply. Without this, sensitive information could be shared too widely, copied, or processed in ways that are not allowed, or privacy-sensitive details could be used for the wrong purpose or without the correct safeguards—leading to legal, financial, and reputational harm.

To meet this requirement, the organisation must define:
- the security labels to attach to every data item (for example, whether it is classified as **Secret** or **Confidential**, any handling restrictions, who may receive it, and the authorised limits on how it can be transferred and processed); and
- the privacy labels to attach (for example, whether it contains personal or health data, the permitted purposes for using it, and the flags needed to manage individuals’ rights).

The organisation must make sure these labels are attached and kept intact when information is transferred both between systems and between components inside the same system. The labels must be used to guide decisions about who can access the information and how it may be used. This must be supported by documented procedures, security and privacy plans, clear responsibility for administrators, and audit records showing that the labels were carried correctly and that enforcement worked as intended.

##### Propagate security/privacy attributes on all exchanged data

- Category: Software
- Priority: Critical

###### WHAT
Set up a label and metadata approach so that every time information is shared—between systems and between software components—it includes the organisation’s defined **security attributes** and **privacy attributes** (for example: classification and handling/distribution limits, and flags showing what personal data is allowed for use). Also make sure the receiving systems and components **keep and apply** those attributes.

###### WHY (control requirement)
NIST SP 800-53 **SC-16** requires the organisation to **link** the organisation-defined security and privacy attributes ({{ insert: param, sc-16_prm_1 }}) to information shared between systems and between system components. These attributes must support access control, controlling how information can move, and privacy rules for permitted use and rights handling.

###### HOW (specific approach)
###### 1) Define the attribute structure and required values
- Use the organisation-defined attribute set in **sc-16_prm_1**: classification (Secret/Confidential), handling caveats, distribution limits, and privacy flags (PII/PHI) carried with each data item.
- Make sure the structure explicitly covers the required concepts:
  - **Security attributes**: classification level, who is allowed to see or receive it (need-to-know/distribution rules), and authorised limits for transfer and processing.
  - **Privacy attributes**: whether the data is PII/PHI, the permitted purposes for using it, and flags for how to handle data subject rights.

###### 2) Add attributes when data is created/received and on every exchange
- When the application creates or receives a data item, assign the required attributes based on the organisation’s classification and privacy rules.
- For every outbound exchange (API request/response, message publish, file transfer, database replication event, internal component call), attach the attributes using a standard, machine-readable wrapper:
  - **Recommended**: include attributes in a dedicated metadata/header area (for example: HTTP headers for APIs, message headers for queues/topics, and file sidecar/embedded properties for documents).
  - Ensure the approach supports both **clear, direct linking** (metadata/headers) and keeping the attributes unchanged as the data moves.

###### 3) Keep attributes through component-to-component handovers
- In a multi-tier/microservices setup, implement a shared library or middleware that:
  - Pulls attributes from incoming exchanges.
  - Checks that attributes are present and match the required format.
  - Sends the same attributes on to the next calls.
  - Stops “label removal” during transformations (for example: mapping data objects, serialisation, or enrichment steps).

###### 4) Apply the rules on the receiving side (access, information movement, and privacy permitted use)
- Receiving components must read the received attributes and enforce:
  - **Access control**: allow or block based on classification and distribution/need-to-know rules.
  - **Information flow control**: block, quarantine, or route differently when authorised transfer/processing limits are not met.
  - **Privacy permitted purposes/rights**: run permitted-purpose checks and data subject rights handling steps based on the PII/PHI indicator and rights flags.
- If enforcement cannot be done (for example: attributes are missing or invalid), default to deny/quarantine and record what happened.

###### 5) Record audit evidence for attribute sharing and enforcement decisions
- Log (and keep in line with enterprise logging requirements) at minimum:
  - The attribute values received and sent for each exchange (or a cryptographic hash of the attribute set if required by policy).
  - The enforcement result (allow/deny/quarantine) and the policy rule identifier.
  - Any validation problems (missing attributes, mismatch with the required structure).

###### 6) Put ownership and change control in place
- Assign responsibility to:
  - The application security/data governance owner and the platform/integration team for maintaining the attribute structure and mapping rules, updating the propagation middleware/library, and ensuring new integration points use the same approach.

###### WHO
- **Application owner / data governance lead**: defines and maintains the attribute mapping rules for sc-16_prm_1.
- **Platform/integration engineers**: implement the propagation middleware/library and the standard metadata/envelope handling.
- **Security engineering / privacy officer**: defines the enforcement logic for access, information flow, and privacy permitted-purpose/rights handling.
- **Operations/SOC**: monitors audit logs and manages quarantine/denial workflows.

###### Acceptance criteria
- For every system-to-system and component-to-component exchange carrying classified or privacy-relevant data, the required **security and privacy attributes** from **sc-16_prm_1** are present and kept end-to-end.
- Receiving components enforce access/information-flow and privacy permitted-purpose/rights handling based on the received attributes.
- Exchanges with missing or invalid attributes are denied or quarantined (according to the defined policy) and produce audit evidence.
- Audit logs show attribute sharing and enforcement decisions for representative production and test flows.

###### Actions Required for Compliance

- [ ] Define the required security and privacy data structure (schema) and the rules for how it is mapped for **SC-16 PRM-1**. This includes: classification, handling caveats, limits on who the information can be shared with, whether it contains personal data or personal health information, permitted purposes for use, and flags that indicate how rights and permissions should be handled.
- [ ] Set up a standard “metadata envelope” for outgoing data exchanges (for example, in application programming interface (API) headers, message headers, or document properties). This envelope must carry the full set of attributes with every data object.
- [ ] Create a shared “propagation” middleware library that checks that required attributes are present and correctly formatted, and ensures those attributes are kept unchanged as information moves from one component to another.
- [ ] Set up enforcement on the receiving side to apply access control, control how information can flow, and handle privacy permitted purposes and rights according to the attributes that are received.
- [ ] Set a default “deny” or “quarantine” response for exchanges that have missing, incorrectly formed, or unauthorised attribute values, and make sure this rule works the same way across all integration points.
- [ ] Set up audit logging to record when attributes are sent and when enforcement decisions are made (including any validation failures) so this information can be used as evidence.
- [ ] Update the integration runbooks and change-management checklists so that, for every new system or component interface, teams must use the propagation/envelope mechanism.


---

#### SC-16.1 — Integrity Verification (Enhancement)

This requirement is about making sure the “labels and settings” that control who can access information and how personal data is handled are not changed without authorisation while they are being sent between systems. If these security and privacy labels are altered without permission, the organisation could unintentionally give access to the wrong people or apply the wrong privacy treatment. This would damage trust and could lead to regulatory action and reputational harm.

To meet this expectation, the organisation must first decide exactly which security-related attributes and which privacy-related attributes are sent between systems, and document how each one is sent. The systems must then verify that both sets of attributes arrive unchanged, using an integrity-check method designed to detect unauthorised tampering. If a check shows the attributes have been changed, the system must treat them as invalid and must not apply them.

The organisation must also assign clear responsibility to named roles, and keep evidence in system design documents, configuration records, audit logs, and the relevant security and privacy plans. These records must include procedures that clearly state what to do if the checks fail.

##### Signed security/privacy attribute tokens with fail-closed verification

- Category: Software
- Priority: Critical

###### WHAT
Implement integrity checks for **transmitted security and privacy attributes** by placing them in **cryptographically signed tokens** (for example, **JSON Web Signature (JWS)**; optionally **JSON Web Encryption (JWE)** for confidentiality) and enforcing **strict checks on the receiving side**.

###### WHY (control requirement)
**National Institute of Standards and Technology (NIST) Security Control SC-16(1) (Enhancement)** requires the organisation to **verify the integrity of transmitted security and privacy attributes**. This helps ensure those attributes are **not changed in an unauthorised way while they are being sent**, preventing loss of integrity that could lead to incorrect access decisions or incorrect privacy handling.

###### HOW (specific steps/approach)
1. **Define the attribute set**: Create an authoritative list of which **security attributes** and which **privacy attributes** are sent between systems (for example, authorisation scopes/roles/tenant claims for security; data classification/retention category/processing basis for privacy). Map each attribute to a token field.
2. **Design a standard token format**: Use a structured token structure with clear versioning. Include standard token fields such as `iss` (issuer), `aud` (audience/receiver), `exp`/`nbf` (validity), and ensure token content is produced in a consistent way so there is no ambiguity.
3. **Sign tokens when issued**: Create tokens using **asymmetric signing** (for example, **RS256**/**ES256**) with keys stored and managed in an enterprise **Key Management Service (KMS)**/**Hardware Security Module (HSM)**. Rotate keys and include `kid` so the receiver can find the correct key for verification.
4. **Verify on receipt (fail closed)**: In every receiving service or **application programming interface (API) gateway** that uses these attributes, implement checks that confirm **the signature is valid**, **the issuer is correct**, **the audience is correct**, **the token is within its valid time window**, and **the token format/version is supported**. If any check fails, treat the attributes as **invalid** and **do not apply them** (deny or withhold security attributes; apply the most restrictive privacy handling or block the request according to your privacy policy).
5. **Log verification outcomes for auditability**: Record whether verification succeeded or failed, including reason codes, token identifiers (for example, `jti`), issuer/audience, and the enforcement outcome (applied vs rejected). Send these logs to the **security information and event management (SIEM)** system.
6. **Document procedures and responsibilities**: Update the organisation’s security and privacy procedures/plans to explain (a) how attributes are issued and sent, (b) how receivers verify integrity, (c) what happens when verification fails, and (d) the named roles responsible for key management, token format governance, and operational monitoring.

###### WHO (role responsible)
- **Application Security Lead / Security Architect**: Own token design, verification requirements, and fail-closed enforcement.
- **Platform/Integration Engineer**: Implement token issuance and verification in services and gateways.
- **Identity and Access Management (IAM) / Key Management Owner**: Manage signing keys in KMS/HSM, key rotation, and issuer/audience configuration.
- **Privacy Officer / Data Protection Lead**: Confirm the privacy attribute set and the fail-closed privacy handling decisioning.
- **Operations / Security Operations Centre (SOC)**: Monitor verification failure rates and investigate unusual patterns.

###### Acceptance criteria
- For every defined transmitted **security attribute** and **privacy attribute**, the receiver performs cryptographic integrity verification before applying them.
- If a token signature is invalid, expired, has the wrong audience/issuer, or has an unsupported claim schema/version, the receiver **rejects or withholds** the attributes and does not apply them.
- Verification logic is implemented consistently across all relevant integration points (APIs/gateways/message consumers).
- Audit evidence exists: SIEM logs show verification outcomes (success/failure reason codes) and enforcement decisions.
- Security and privacy procedures/plans are updated to document transmission, verification, failure handling, and named responsibilities.

###### Actions Required for Compliance

- [ ] Create an inventory of the security and privacy information that is sent, and map each item to the corresponding token claim.
- [ ] Define and publish a single, agreed “token claim” format (including how the format version is tracked, the issuer, the intended audience, and the token’s validity period).
- [ ] Set up token issuing that uses asymmetric digital signatures, with keys stored and protected by an enterprise key management system (KMS) or hardware security module (HSM), and rotate the keys regularly.
- [ ] Before applying any attributes, carry out strict checks on the received data to confirm it is valid. This includes verifying the digital signature, the issuer, the intended audience, the expiry and “not before” dates, and that the claim format matches the expected schema and version.
- [ ] Set the system to “fail closed” so that if integrity checks fail, the system rejects or withholds the requested attributes and applies safe default settings.
- [ ] Add audit logging of verification results (reason codes, token identifiers, and enforcement decisions) to the security information and event management (SIEM) system.
- [ ] Update the security and privacy procedures or plans to document how data is sent, how it is checked, what happens if it fails, and the named responsibilities for each role.


---

#### SC-16.2 — Anti-spoofing Mechanisms (Enhancement)

This requirement is about making sure the system’s “security is working” signals cannot be faked. Without strong anti-fraud checks, an attacker could alter the information the organisation uses to decide whether protections have actually been applied. This could make it look like everything is secure when it is not.

To meet this, the organisation must clearly identify which security-status information must be protected. It must then ensure the system has safeguards that prevent unauthorised changes and confirm that the security status shown is based on real, working security measures.

The organisation must also protect this security-status information while it is being sent between systems and while it is stored. It must restrict who can influence it, and ensure only authorised actions can update it.

Finally, the organisation must keep audit records showing what was changed, when, and by whom. It must document how the safeguards work and how they are configured, include this in the system security plan, assign responsible staff to run and monitor it, and maintain procedures for what to do if tampering is suspected.

##### Signed security-status events with verification and tamper rejection

- Category: Software
- Priority: Critical

###### WHAT
Put in place anti-fraud protections for the application’s security-status information (the data used to claim that security checks succeeded). Do this by making sure those security-status items are sent as **signed, traceable security-status events** that are created only by trusted components, and **checked and verified** by the receiving/reporting part before the status is accepted.

###### WHY (control requirement)
The SC-16(2) enhancement requires anti-spoofing measures to stop attackers from **falsifying the security information that indicates the security process worked**. The guidance notes that attackers may change security-status data to make organisations think more security controls are operating successfully than is actually true.

###### HOW (specific steps/approach)
1. **Identify and map the security-status items you will protect** that the application/Security Operations Centre (SOC) dashboards/workflows use to decide what counts as “security success” (for example: patch compliance, multi-factor authentication (MFA) enforcement, endpoint detection and response (EDR) health, encryption enabled, backup success, policy evaluation passed). For each item, define an official event format (schema).
2. **Choose trusted event producers** (for example: endpoint posture service, configuration management (CMDB) reconciliation service, identity policy enforcement engine, compliance attestation agent). These are the only components allowed to generate the security-status events.
3. **Digitally sign each status event** at the producer using keys stored in an enterprise **key management service / hardware security module (KMS/HSM)**. In the signed content, include: the attribute identifier, the value, the producer identity, the time it was created, an event ID, and a nonce or sequence number to help prevent replay attacks.
4. **Verify signatures at the consumer** (the application/reporting service/security information and event management (SIEM) ingestion pipeline). If verification fails (for example: invalid signature, unknown producer, old timestamp/nonce, wrong event format), the consumer must **reject the event** and set the related security-status item to **unknown/invalid** (not “success”).
5. **Use secure communication and storage**: use mutual Transport Layer Security (mutual TLS) for producer-to-consumer communication; store the signed content and verification details (key ID, producer ID, verification result) in an append-only log or tamper-evident storage.
6. **Alert and audit when tampering is suspected**: create detections for signature failures, replay/staleness, producer mismatch, and repeated invalid events. Ensure audit records show what was received, whether verification succeeded or failed, and what action was taken (accepted/rejected).

###### WHO (role responsible)
- **Application Security Architect / Platform Engineer**: define the list of protected security-status items, the event format, and the trust boundaries.
- **Security Engineering (KMS/HSM and key management owner)**: implement signing key management, key rotation, and access controls.
- **Backend/Integration Engineers**: implement producer signing and consumer verification logic.
- **SOC/Monitoring Lead**: set up alerting and ensure audit evidence is kept and reviewed.

###### Acceptance criteria
- For each mapped security-status item, the system accepts only **cryptographically verified** signed events from authorised producers.
- If an attacker tries to falsify an attribute value, the consumer rejects the event and the item is shown as **unknown/invalid**, not “success”.
- Signature verification failures and replay/staleness conditions produce auditable records and trigger alerts.
- Signed content and verification details are retained for investigation (including producer identity, key ID, and verification result).

###### Actions Required for Compliance

- [ ] Create an inventory of security-status details that show when security checks have been completed successfully, and define an event format for each one.
- [ ] Choose and record approved, trusted suppliers who are authorised to generate security-status events for each attribute.
- [ ] Set up digital signing of status events on the producer side, using enterprise key management system (KMS) or hardware security module (HSM) keys, and include fields that prevent replay attacks.
- [ ] Set up signature checking on the customer side, and reject the request (or mark it as unknown) if the signature check fails for any reason.
- [ ] Set up mutual transport layer security (mutual TLS) for sending events between producers and consumers, and store signed message payloads together with verification details in a tamper-evident log.
- [ ] Add security information and event management (SIEM) and monitoring alerts for invalid signatures, replayed or outdated messages, and mismatches between the expected and actual message producer, and check that alerts are sent to the correct recipients.
- [ ] Use tests to confirm that altered or unsigned events cannot be used to mark security processing as successful.


---

#### SC-16.3 — Cryptographic Binding (Enhancement)

This requirement is about ensuring that any security and privacy information sent with a data item is securely linked to that data, so it cannot be quietly changed or separated. Without this, someone could tamper with the security or privacy information (for example, changing how sensitive the data is) or swap the security information from one message onto different content. This could lead to unauthorised access, incorrect handling, or privacy breaches.

To meet this expectation, the organisation must use a “signed and encrypted message” approach. This means it must:
- digitally sign the security and privacy labels as part of the signed message information (so changes are detectable),
- encrypt the whole message using authenticated encryption (so any alteration is detected), and
- reject the message if the signature check or the encryption integrity check fails.

The organisation must also:
- document how this is implemented,
- configure the system to use the required methods for transmissions that include these attributes,
- keep evidence in audit records showing that the checks were carried out, and
- maintain clear procedures and responsibilities in its security planning so administrators can implement and operate it correctly.

##### CMS-signed, AES-GCM encrypted envelope binding security/privacy attributes

- Category: Software
- Priority: Critical

###### WHAT
Add a cryptographic “envelope” around every message sent between systems. This envelope carries the message’s security and privacy information and ensures that information is tightly linked to the message content. It does this by:
- using **Cryptographic Message Syntax (CMS)/Public-Key Cryptography Standards (PKCS) #7 digital signatures** to sign **signed metadata** (including the security and privacy attributes), and
- using **Advanced Encryption Standard (AES) in Galois/Counter Mode (AES-GCM) authenticated encryption** to protect the whole structure.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SC-16(3)** enhancement requires implementing **sc-16.03_odp (mechanisms or techniques)** to **bind security and privacy attributes to transmitted information**. This stops an attacker from changing the attributes (or detaching them from the message content) without being detected.

###### HOW (specific steps/approach)
1. **Define an attribute-carrying envelope format** for the application’s message structure (for example, JSON or XML fields). It must include at least: message identifier, timestamp/nonce, recipient/scope, security label(s), privacy attribute(s), and a hash of the application payload.
2. **Create signed metadata**: convert the security label(s) and privacy attribute(s) into a consistent form, include the payload hash and message identifier, and sign this metadata using **CMS/PKCS#7** with the organisation’s signing certificate.
3. **Bind and encrypt**: encrypt the CMS structure (or the signed metadata plus payload hash plus required context) using **AES-GCM** with a **unique per-message initialisation vector (IV)/nonce**. Use **additional authenticated data (AAD)** for stable context (for example, channel/service identifier and recipient scope) so any changes to that context are detected.
4. **Enforce strict checks on receipt**: when a message arrives, **verify the CMS signature first**, then **decrypt using AES-GCM** and require successful authentication. If either check fails, **reject the message** and ensure the application does not apply or rely on any security/privacy attributes.
5. **Stop non-conforming traffic**: at the application programming interface (API)/messaging boundary, require that any message containing security/privacy attributes uses the envelope format. Reject or quarantine messages that do not match.
6. **Create audit evidence**: record verification outcomes (signature valid/invalid, certificate serial number/thumbprint), AES-GCM authentication success/failure, message identifier, and correlation identifiers for security information and event management (SIEM) linking.

###### WHO (role responsible)
- **Application security engineer / software architect**: implement the envelope format, signing/encryption logic, and the verification process.
- **Platform/integration engineer**: integrate with the organisation’s certificate and cryptography services and enforce boundary validation.
- **Security operations / SIEM engineer**: define and validate the audit log fields and set up alerts for verification failures.

###### Acceptance criteria
- For any outbound message that includes security/privacy attributes, the transmitted data is wrapped in the defined envelope and is both **CMS-signed** (with the attributes included in the signed metadata) and **AES-GCM encrypted**.
- For any inbound message, if the CMS signature is invalid or AES-GCM authentication fails, the system **rejects the message** and does not process or apply the attributes.
- Audit logs include, for each message: message identifier, signature verification result (and certificate identifier), AES-GCM authentication result, and correlation identifiers.
- Boundary controls prevent processing of messages that are not in the envelope format or are malformed.

###### Actions Required for Compliance

- [ ] Define the structure for the information-carrying message, including: a message identifier, a nonce or timestamp, one or more security labels, one or more privacy attributes, a hash of the message content, and the intended recipient(s) or scope.
- [ ] Implement content management system (CMS) / Public-Key Cryptography Standards #7 (PKCS#7) signing over signed metadata that has been converted into a standard (canonical) form, and that includes the security and privacy attributes and the hash of the payload (the data being signed).
- [ ] Encrypt the signed envelope using Advanced Encryption Standard in Galois/Counter Mode (AES-GCM), with a different initial value (IV) for every message, and include additional authenticated data (AAD) to keep the context consistent (for example, the channel or service identifier and the intended recipient scope).
- [ ] Set up receiving-side checks to verify the content management system (CMS) signature, then decrypt the message using advanced encryption standard in Galois/Counter Mode (AES-GCM). Reject the message if any verification or authentication step fails.
- [ ] Use boundary checks at the API gateway, service mesh, and message broker to block or quarantine messages that do not meet requirements—specifically, messages that include attributes but are missing the required envelope.
- [ ] Record an audit log for each message’s signature verification outcome, certificate identifier, AES-GCM authentication result, message identifier, and correlation identifiers.


---

### SC-17 — Public Key Infrastructure Certificates (Control)

This requirement is about ensuring the digital certificates your systems depend on are issued correctly, and that your organisation only trusts approved certificate sources. If certificates are issued without the required rules, or by an unapproved provider, or if systems are allowed to trust unknown or unapproved certificate authorities, attackers could impersonate trusted services or users. This could lead to fraud, unauthorised access, or sensitive information being intercepted, altered, or both.

To meet this requirement, the organisation must either:
- issue public key certificates for Secret and Confidential systems in line with the Department of Defense (DoD) public key infrastructure (PKI) certificate policy for Secret and Confidential systems, including International Traffic in Arms Regulations (ITAR) / Export Administration Regulations (EAR) and aligned with the Cybersecurity Maturity Model Certification (CMMC), or
- obtain the certificates from an approved certificate service provider.

The organisation must also keep its trust lists up to date, so that only approved trust anchors are included in its trust and certificate stores. It must keep clear records and procedures showing how certificates are requested, approved, and issued, and how trust lists are kept accurate and restricted to approved entries.

##### Policy-controlled PKI issuance and approved trust-anchor stores

- Category: Manual
- Priority: Critical

###### WHAT
Set up a controlled process for issuing public key infrastructure (PKI) certificates for **Secret** and **Confidential** systems, following the organisation’s defined **certificate policy** (DoD PKI Certificate Policy (DOD-CP) for Secret and Confidential systems; issuance aligned to ITAR/EAR and the Cybersecurity Maturity Model Certification (CMMC)). Also make sure all systems use **organisation-managed trust/certificate stores** that contain **only approved trust anchors**.

###### WHY (control requirement)
Security and control requirement SC-17 says PKI certificates (both those visible to external parties and those used for internal encryption and security operations) must be issued according to the required certificate policy or obtained from an approved provider. It also requires that trust decisions are based only on **authoritative trust anchors** kept in the organisation’s trust/certificate stores.

###### HOW (specific approach)
1. **Certificate policy governance**: Publish and keep the certificate policy for Secret/Confidential systems exactly as the organisation defines (DoD PKI Certificate Policy (DOD-CP) for Secret and Confidential systems; issuance aligned to ITAR/EAR and the Cybersecurity Maturity Model Certification (CMMC)). Link it to day-to-day procedures for requesting, validating, approving, issuing, revoking, managing the certificate life cycle, and protecting keys.
2. **Controlled issuance workflow**: Create an end-to-end workflow for certificate requests that covers: receiving the request, checking identity and authorisation, approval by authorised roles, issuing the certificate, and recording all request/approval/issuance events in an unchangeable audit log. Make sure only authorised roles can trigger issuance.
3. **Trust-anchor inventory and change control**: Keep an up-to-date inventory of **approved trust anchors** (root and any intermediate certificate authority (CA) certificates), including versions. Treat any change to the approved set as a controlled change, with documented approvals.
4. **Enforce approved trust anchors in trust stores**: Configure endpoints, servers, and application runtime trust stores/certificate bundles so they trust **only** the approved trust anchors. Use central configuration management (for example, enterprise policy or mobile device management (MDM) for endpoints; managed trust bundles for containers and microservices; and controlled operating system or browser trust store management where applicable).
5. **Deployment-time enforcement (policy-as-code)**: Add checks to continuous integration/continuous delivery (CI/CD) and release pipelines to stop deployments that introduce unapproved certificate authority (CA) certificates or trust bundles into application images, configuration files, or runtime trust stores.
6. **Evidence generation**: Keep audit logs for certificate requests, approvals, and issuance, and keep evidence of trust-store configuration (for example, configuration snapshots, versions of the approved trust-anchor inventory, and pipeline deployment confirmations).

###### WHO
- **PKI/Certificate Authority (CA) Operations Lead**: responsible for implementing the issuance workflow and controlling the certificate authority life cycle.
- **Information Security/Compliance Lead**: responsible for certificate policy governance and approving changes to the trust-anchor inventory.
- **Platform/DevOps Engineering Lead**: responsible for distributing trust stores and enforcing the checks in CI/CD.
- **System/Application Owners**: ensure their applications rely only on organisation-managed trust stores.

###### Acceptance criteria
- For Secret/Confidential system certificates, issuance is carried out under the documented **DOD-CP-aligned certificate policy** or through an approved provider (where applicable), with complete audit records for request, approval, and issuance.
- The organisation’s trust/certificate stores used by the application contain **only** the approved trust anchors from the maintained inventory.
- Any attempt to deploy or configure additional/unapproved trust anchors is blocked by pipeline controls and/or configuration management safeguards.
- Evidence is available for auditors, including the certificate policy document, the approved trust-anchor inventory (with change history), issuance workflow logs, and trust-store configuration evidence for production and relevant environments.

###### Actions Required for Compliance

- [ ] Publish and approve the certificate policy for Secret/Confidential systems exactly as defined by the organisation’s standard (DOD-CP), including issuance that is aligned with the International Traffic in Arms Regulations (ITAR), the Export Administration Regulations (EAR), and the Cybersecurity Maturity Model Certification (CMMC).
- [ ] Define and document the full certificate process from start to finish—how requests are received, how they are checked, who gives authorised approval, how certificates are issued, and how they are cancelled or managed over their lifetime. Include the named roles involved and what each role is responsible for.
- [ ] Set up role-based controls so only authorised roles can approve and trigger certificate issuance, and enable tamper-proof audit logs that record every request, approval, and issuance.
- [ ] Create and keep an approved list of trust anchors (root and intermediate certificate authority certificates), with version tracking and controlled approval for any changes.
- [ ] Set up the application and infrastructure trust and certificate lists to include only the approved trust anchors, using central configuration management.
- [ ] Add continuous integration and continuous delivery (CI/CD) and checks during deployment to prevent unapproved certificate authorities (CAs) and trust bundles from being added to application files or to the system trust settings used at runtime.
- [ ] Collect and keep evidence for audits, including: issuance workflow logs, the approved versions of the trust-anchor inventory, and saved snapshots of the trust-store configuration for each environment.


---

### SC-18 — Mobile Code (Control)

This expectation is about preventing risky software or content that can be sent over the internet or email from being run on your organisation’s computers and devices. Without clear rules, someone could accidentally (or deliberately) allow harmful code to run, which could damage systems, steal information, or disrupt services.

To meet this expectation, the organisation must clearly set out in writing which types of mobile code and which specific technologies are allowed and which are not. It must also keep these lists up to date so staff and reviewers can check them. Mobile code must only be allowed to run when it has been explicitly approved. The organisation must monitor mobile code activity so that both allowed and blocked attempts are recorded and can be reviewed.

The organisation should also require that approved mobile code comes from trusted sources, for example by using digitally signed content. It must keep evidence of approvals and monitoring results so that decisions can be checked during audits.

##### Digitally signed mobile code allowlisting with endpoint enforcement

- Category: Software
- Priority: Critical

###### WHAT
Put in place a “trust-first” control for mobile code that only allows mobile code and related technologies that have been explicitly authorised and digitally signed by a trusted source to run. Block mobile code and technologies that are not acceptable. Apply this control at the browser and endpoint level, and keep records of both allowed and blocked attempts for audit purposes.

###### WHY (control requirement)
Security and Controls (SC-18) for Mobile Code requires organisational procedures to stop unacceptable mobile code from being developed, obtained, or introduced. This includes requiring mobile code to be digitally signed by a trusted source. It also requires restrictions and implementation guidance for both server-installed and client-downloaded mobile code.

###### HOW (specific steps/approach)
1. **Define acceptable and unacceptable lists**: Create and maintain written lists of acceptable and unacceptable mobile code types/technologies (for example, allow specific web technologies or features; block unsafe or outdated technologies such as Visual Basic Scripting Edition (VBScript); restrict or disable applet-style execution unless it is explicitly approved). Include what systems are covered (servers versus endpoints versus mobile devices) and the reason for each decision based on potential harm.
2. **Create an authorisation record**: For each approved mobile code technology/type, create an authorisation record that includes: the technology identifier, the trusted signing authority/publisher/certificate details, allowed origins (where relevant), the scope (which device types and environments), and the rules for when it expires and how it is renewed.
3. **Enforce trusted digital signatures at run time**: Set enterprise browser and endpoint policies so mobile code can run only if it is checked against the trusted signing/publisher/certificate requirements in the authorisation records. Where supported, require signed content and verified publishers, and block unsigned or untrusted content (fail closed).
4. **Enforce allow/block for technologies**: Use managed configuration baselines to disable or limit unacceptable mobile code technologies and features (for example, disable legacy scripting or plug-in engines; restrict high-risk web features such as Web Graphics Library (WebGL) where not needed; block specific script or plug-in execution paths). Ensure safe-fail behaviour (blocked execution with clear user or system messaging).
5. **Centralise policy distribution (policy-as-code)**: Store the mobile code policy and how it maps to endpoint and browser settings in version control. Use the organisation’s endpoint management tools to deploy changes with controlled approvals and clear traceability.
6. **Monitor and log results**: Collect information from endpoints, proxies, and browsers for both allowed and blocked mobile code events (for example, “execution blocked: untrusted signature”, “execution allowed: trusted publisher”, “technology disabled”). Send this to security information and event management (SIEM) and keep logs to support review and evidence.

###### WHO (role responsible)
- **Security Engineering / Application Security (AppSec)**: Own the mobile code policy content, the authorisation record model, and how it is enforced technically.
- **Endpoint Management Team (for example, IT Operations / Mobile Device Management (MDM) / Enterprise Mobility Management (EM))**: Implement and maintain the managed browser and endpoint configuration baselines.
- **Security Operations Centre (SOC) / SIEM Team**: Ensure logs are collected correctly, formatted consistently, monitored for alerts (where appropriate), and retained.
- **Change Management / Change Advisory Board (CAB)**: Approve updates to the acceptable/unacceptable lists and trust stores.

###### Acceptance criteria
- Only mobile code that matches an **explicitly authorised** technology/type and is **validated against trusted digital signatures** can run on managed endpoints.
- Mobile code that matches **unacceptable** types/technologies is blocked (or restricted) with safe-fail behaviour.
- For both allowed and blocked attempts, the organisation can provide audit evidence showing: the time and date, device or user context (as permitted), the mobile code type/technology, the result of trust validation, and the policy rule applied.
- Policy changes (updates to lists and trust requirements) are stored in version control, approved through change control, and traceable to the endpoint configurations that were deployed.

###### Actions Required for Compliance

- [ ] Publish written lists of acceptable and unacceptable mobile code and technology, with a clearly defined scope for servers, endpoints, and mobile devices.
- [ ] Create an authorisation record template that links each approved mobile code type or technology to the trusted signing details (including the publisher certificate) and the certificate expiry date.
- [ ] Set up managed browser and device rules so that mobile code is allowed to run only when its digital signature and trust checks succeed, and only for authorised mobile code.
- [ ] Use enterprise configuration baselines to disable or limit mobile code technologies and features that are not acceptable, and ensure the system fails safely if they are encountered.
- [ ] Set up a “policy as code” process to version, approve, and roll out mobile code enforcement settings to endpoint devices.
- [ ] Set up and centralise logging and telemetry for both permitted and blocked mobile code execution attempts, then send the records to security information and event management (SIEM) with retention for audit purposes.


---

#### SC-18.1 — Identify Unacceptable Code and Take Corrective Actions (Enhancement)

This requirement is about spotting dangerous “code-in-files” before it reaches people, then stopping it and raising an alert. In everyday terms, it targets word-processing documents that secretly contain embedded instructions (macros), as well as any scripts or other active content that has been identified as malicious or not allowed under your rules. Without this, harmful content could be sent to staff, which could lead to data theft, fraud, or disruption.

To meet this requirement, the organisation must:
- Keep a documented list of what it considers unacceptable.
- Ensure its systems can detect that specific type of content.
- When it is found, immediately block it from being sent, quarantine it so it cannot be used or delivered normally, and alert both the system owner and the security operations team so they can investigate.
- Record what was detected and what actions were taken, and keep those records so follow-up investigations can be completed.

##### Gateway enforcement to block/quarantine unacceptable mobile code

- Category: Software
- Priority: Critical

###### WHAT
Set up an inspection and enforcement capability at the application’s main points where content enters and leaves the system (for example, email and file upload/download gateways) that:
1) **Identifies unacceptable mobile code** as defined by the organisation: macro-enabled word-processing files that contain embedded macros, and scripts/other active content that are flagged as malicious or against policy.
2) **Takes corrective action when it is found**: **blocks the content from being sent**, **quarantines it**, and **alerts** the system owner and security operations so they can investigate.

###### WHY (control requirement)
The control requirement SC-18(1) enhancement asks the organisation to **identify** the defined “unacceptable mobile code” and **take the defined corrective actions** when it is detected. The guidance says corrective actions can include **blocking**, **quarantine**, or **alerting administrators**, and it specifically notes that **blocking includes stopping the transmission of word-processing files that contain embedded macros** that have been determined to be unacceptable mobile code.

###### HOW (specific steps/approach)
1. **Define what the gateway should look for in its policy**, using the organisation’s agreed values:
   - “unacceptable mobile code” = mobile code that includes **embedded macros in word-processing files**, or **scripts/active content flagged as malicious or against policy**.
   - “corrective actions” = **block transmission**, **quarantine**, and **alert** the system owner and security operations.
2. **Send the relevant channels through the enforcement point** so the gateway can check content before it reaches recipients/users (at minimum: inbound and outbound email, and any web or file-sharing upload/download routes the application uses).
3. **Turn on inspection at the gateway** for embedded macros and other active content:
   - Detect macro-enabled word-processing formats and signs that macros are embedded.
   - Detect scripts/active content and apply the gateway’s malicious/policy-violation classification.
4. **Apply corrective actions automatically when a match is found**:
   - **Block transmission**: stop the message/attachment being delivered, or prevent the upload/download from completing.
   - **Quarantine**: place the exact item into a controlled quarantine repository and assign it a unique quarantine ID.
   - **Alert**: notify both the **system owner** and **security operations** with enough detail to investigate (for example: file name, hash, reason for detection, quarantine ID, source/destination, and timestamps).
5. **Keep evidence that can be audited for every detection/enforcement event**:
   - Store logs showing: the detection result, the policy rule that matched, the file hash, relevant metadata (sender/recipient or upload location), the quarantine ID, and the corrective action taken.
   - Keep logs for as long as required by the organisation’s audit and incident rules.
6. **Run it operationally and test it**:
   - Add test cases using representative macro-enabled documents and known malicious/policy-violating scripts/active content.
   - Confirm that the gateway blocks/quarantines correctly and that alerts reach the right owner and security operations workflow.

###### WHO
- **Security Operations / Security Operations Centre (SOC)**: receives alerts, triages them, and starts investigations.
- **Application/System Owner**: receives owner notifications and coordinates decisions on remediation.
- **Security Engineering / Platform Team**: sets up the gateway inspection/enforcement configuration and maintains the policy (policy-as-code).

###### Acceptance criteria
- When a macro-enabled word-processing file containing embedded macros that is classified as “unacceptable mobile code” is submitted through the routed channels, the gateway **prevents transmission** and **quarantines** the item.
- When scripts/active content classified as malicious or against policy are detected, the gateway **blocks** and **quarantines** the content.
- For every detection, an alert is sent to **both** the system owner and security operations, including at least the detection reason, quarantine ID, and relevant metadata.
- For each event, auditable evidence logs exist showing what was detected, which policy matched, what action was taken, and the timestamps, and they are retained according to organisational requirements.

###### Actions Required for Compliance

- [ ] Create and keep a version-controlled record of the gateway policy that defines what counts as “unacceptable mobile code” and the required “corrective actions” (block, quarantine, alert).
- [ ] Route all relevant incoming and outgoing traffic paths used by the application—specifically email and file upload and download—through the inspection and enforcement gateway.
- [ ] Set up the gateway to check word-processing files for hidden macros, and to block scripts or other active content that has been flagged as malicious or in breach of policy.
- [ ] Set up automatic enforcement to stop the item from being sent, place it in quarantine, and create a unique quarantine ID.
- [ ] Set up alert notifications to go through the security operations centre (SOC), security information and event management (SIEM), and security orchestration, automation and response (SOAR), following the system-owner notification process. Include the reason for the detection and the quarantine reference ID.
- [ ] Turn on audit logging for every detection and enforcement event (including the policy match, file hash, metadata, timestamps, and the action taken), and check that the logs are kept for the required retention period.
- [ ] Run validation tests using realistic macro-enabled documents and harmful or policy-violating active content to confirm the system blocks, quarantines, or alerts as expected.


---

#### SC-18.2 — Acquisition, Development, and Use (Enhancement)

This requirement is about making sure any mobile code your organisation plans to use in its systems is trustworthy before it is put into live services. Without these checks, harmful or changed code could be introduced, potentially stealing data, disrupting services, or helping attackers gain access through features meant to help users.

To meet this expectation, the organisation must ensure that every piece of mobile code it obtains, builds, or uses for deployment is:
- first approved by the system owner,
- scanned for malware (malicious software),
- digitally signed so it can be traced back to an authorised source.

Before deployment, the code must be run only in a separate test environment (sandbox), using the minimum access needed, and recording what happens during the test.

The organisation should be able to provide evidence of approval, malware scanning results, digital signing, and the sandbox test with limited access and logging, for both third-party code and code developed internally.

##### Mobile code pipeline with approval, scan, signing, sandbox gates

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated “mobile code” release process that, for every mobile code file/version meant to be deployed, requires: (1) approval from the system owner, (2) malware scanning, (3) digital signing, and (4) running only in a sandbox (isolated test environment) using least privilege and producing logs, before it can be promoted to production.

###### WHY (control requirement)
SC-18(2) enhancement requires proof that the acquisition, development, and use of mobile code that will be deployed meets the organisation’s defined **mobile code requirements** (sc-18.02_odp): *approved by the system owner, scanned for malware, signed, and run only in a sandbox with least privilege and logging before deployment*.

###### HOW (specific steps/approach)
1. **Define mobile code scope and artefact details**: create an inventory template for the mobile code types you deploy (for example, scripts, applets, browser/mobile extensions, plugins). Capture the artefact hash, version/build, intended target system, and system owner.
2. **Set up CI/CD “policy gates” (fail-closed)**: configure the pipeline so promotion to production is blocked unless proof exists for every required gate:
   - **System-owner approval**: require an approval record linked to the artefact hash/version and target system (for example, system-owner approval through a change ticket or workflow).
   - **Malware scanning**: run an approved malware scanning step on the exact artefact bytes. Require a “clean/known-good” result (or a clearly defined allow-list) and save the scan output as evidence.
   - **Digital signing**: sign the artefact using approved signing keys/certificates. Check that the signature is valid and that the certificate chain is correct during the pipeline, and again at the point of promotion.
   - **Sandbox-only execution**: run the artefact in an isolated test sandbox (separate from production) using a dedicated test identity with **least privilege**. Turn on and collect audit logs from the sandbox host/runtime and from the application test harness.
3. **Prove sandbox use and enforce least privilege**: apply sandbox controls (for example, container or virtual machine isolation, restricted network access, restricted file permissions, and minimal operating system/application permissions). Record run identifiers, the permissions profile used, and where the logs are stored.
4. **Keep an auditable evidence trail**: store the artefact hash, approval ID, scan report ID, signing details (key/certificate identifier), sandbox run ID, and promotion decision logs, so auditors can confirm the exact version deployed.
5. **Ensure “use” happens only through the pipeline**: limit production deployment methods so mobile code can only be deployed via the pipeline promotion step (for example, remove or disable direct upload/deploy routes for mobile code artefacts).

###### WHO (role responsible)
- **Application/System Owner**: provides and confirms approval for each mobile code artefact/version.
- **DevOps/Platform Engineering**: builds and maintains the CI/CD pipeline gates, the sandbox execution test setup, the signing integration, and the evidence capture.
- **Security Engineering**: approves the malware scanning tool/profile and the signing key management approach; checks that sandbox controls meet least-privilege and logging expectations.

###### Acceptance criteria
- For every mobile code artefact/version promoted to production, the pipeline produces evidence of: (a) system-owner approval linked to the artefact hash/version, (b) malware scan results for the same artefact bytes, (c) successful digital signing and signature verification, and (d) a sandbox execution using a least-privilege test identity with collected logs.
- Production deployment is blocked if any gate is missing, fails, or the evidence cannot be linked to the artefact/version.
- Direct production deployment routes for mobile code are disabled or restricted so promotion can happen only through the controlled pipeline.

###### Actions Required for Compliance

- [ ] Define the organisation’s mobile application code scope and record the build artefact hash/version details so the pipeline can be tracked.
- [ ] Set up continuous integration and continuous delivery (CI/CD) promotion “gates” that require the system owner’s approval, linked to the specific software package version (artefact hash/version) and the target system.
- [ ] Add an approved malware scan step and save the scan reports as proof for the promotion.
- [ ] Use approved digital signing keys and certificates, and check that every signature is valid when the software is built and when it is promoted to the next stage.
- [ ] Set up a separate, isolated test environment that runs only the candidate file using a least-privileged test account, and records audit logs.
- [ ] Restrict production deployments so mobile code can only be released through the approved, gated pipeline workflow.
- [ ] Set how long to keep records for the approval ID, scan report ID, signing details, sandbox run ID, and promotion decision logs.


---

#### SC-18.3 — Prevent Downloading and Execution (Enhancement)

This requirement is about preventing unapproved “plug-in” style code from the internet from being brought onto your devices and then run. If this kind of code is allowed, it could quietly change settings, steal information, or help criminals take control of systems, because the code may be unknown, not trusted, or not properly checked.

To meet this expectation, the organisation must block any unapproved mobile code from external sources—such as unsigned JavaScript, Java applets, ActiveX, or Flash—so it cannot be downloaded and cannot run on the system. In practice, the organisation should put in place and keep effective technical protections and usage rules so that attempts to load this unapproved code are stopped every time, including when it comes through common ways users access external content, while approved code (where the organisation has explicitly allowed it) can still run normally.

##### Block unapproved mobile code download and execution via deny-by-default

- Category: Software
- Priority: Critical

###### WHAT
Put “deny-by-default” technical protections in place on devices (endpoints) and client software to stop **unacceptable mobile code** (as defined by `sc-18.03_odp`: *unapproved mobile code such as unsigned JavaScript, Java applets, ActiveX, Flash from external sources*) from being **downloaded and run**.

###### WHY (control requirement)
The SC-18(3) enhancement requires: **“Prevent the download and execution of {{ insert: param, sc-18.03_odp }}.”** This means the controls must cover both delivery (download) and running (execution), not just one of them.

###### HOW (specific approach)
###### 1) Set a deny-by-default baseline for mobile-code “run” capabilities
- Remove or strongly disable legacy mobile-code technologies where they exist (for example: Flash, Java applets, ActiveX) using managed device and browser settings.
- For any remaining “mobile code” types that can run (for example: scripts from external sources), enforce clear trust rules so only explicitly approved sources/origins can run.

###### 2) Block execution (running) even if the content is delivered
- Set client software rules so unapproved mobile code cannot run (for example: disable plugin-based runtimes; allow script execution only in approved contexts/origins).
- Use application control to stop unapproved files or script interpreters from running if they are delivered to the device and could be used as a mobile-code payload.

###### 3) Centralise enforcement and keep evidence
- Send security monitoring data to the security information and event management (SIEM) system for auditability: blocked download attempts (where available), blocked execution events, and the reason/category (for example: “unapproved mobile code runtime disabled”, “unapproved origin blocked”, “application control prevented execution”).
- Ensure logs include at least: date and time, user and device, content/origin identifier (for example, URL or domain where applicable), and the enforcement decision.

###### 4) Cover every entry point used to reach external content
- Test not only web browsers, but also common document viewers and remote access or web client components that users use to open external content.

###### WHO
- **Endpoint/Client Engineering Lead**: sets up managed configuration baselines for browsers and client software, and implements endpoint application control.
- **Cybersecurity (security operations centre (SOC)/Detection Engineering)**: defines how security events are mapped in the SIEM, sets up alerts, and specifies what evidence is required.
- **IT Security Governance/Policy Owner**: confirms that the definition of “unacceptable mobile code” matches `sc-18.03_odp` and approves any allow-list exceptions.

###### Acceptance criteria
- Attempts to access external content that would deliver the defined unacceptable mobile code result in **no successful download and no successful execution** (confirmed through client enforcement and/or endpoint application control logs).
- Execution is blocked even when the content is delivered (shown through test cases demonstrating runtime enforcement).
- Enforcement is applied consistently across the organisation’s managed endpoints and the identified client entry points (browser, document viewer, remote/web access client).
- The SIEM receives audit evidence for blocked download and execution decisions, with enough detail to support incident investigation and audit review.

###### Actions Required for Compliance

- [ ] Create a managed “deny by default” baseline configuration that disables or blocks the mobile-code runtimes identified in **SC-18.03 ODP** (for example, **Flash**, **Java applets**, and **ActiveX**) on all standard devices.
- [ ] Set client runtime rules to stop unapproved mobile code from running when it comes from outside sources. Only allow script or plug-in execution in approved situations, with exceptions only where they are explicitly permitted.
- [ ] Enable endpoint application control to stop unapproved files or tools from running, including those that could be delivered to devices through blocked mobile code.
- [ ] Integrate client and endpoint enforcement logs with the security information and event management (SIEM) system, and make sure each event records the user and device, the source and content identifier, and the reason for the enforcement action.
- [ ] Test and record that access controls are enforced at every relevant entry point, including the web browser, the document viewer, and any remote or web-based client applications used to access external content.
- [ ] Set up an exception process for any mobile code that has been explicitly approved. Make sure each exception is limited to the smallest possible set of approved items (an allow-list) and that it is monitored.


---

#### SC-18.4 — Prevent Automatic Execution (Enhancement)

This requirement is about preventing suspicious code from running automatically when someone opens an email or clicks a link. It also requires that people explicitly confirm before anything potentially risky is opened. Without this, a harmful file or script could start just because an email was viewed or a link was clicked, which could lead to unwanted downloads, unexpected pop-ups, or malware running on company devices.

To meet this expectation, the organisation must keep an up-to-date list of the specific email applications and web browsers used to open attachments and links. It must configure each one so that code from email attachments or web links cannot automatically run on mobile devices. It must also turn off auto-run features for portable storage devices such as USB drives, CDs and DVDs.

Finally, the organisation must ensure users are prompted to confirm before opening attachments or clicking links, and it must be able to demonstrate that this prompt appears before anything runs.

##### Disable mobile-code auto-execution and enforce user prompts

- Category: Software
- Priority: Critical

###### WHAT
Ensure that mobile code delivered through **email attachments** and **web links** never runs automatically, and that users must **confirm first** before opening or clicking the content.

Also stop **automatic running** from **portable storage devices** (for example, USB drives and CD/DVDs) at the system level.

###### WHY (control requirement)
SC-18(4) (Enhancement) requires: **“Prevent the automatic execution of mobile code”** within the organisation-defined scope of **software applications** (parameter **sc-18.04_odp.01**) and to require **confirming before running** (parameter **sc-18.04_odp.02**) before the code runs. Further guidance says users must be prompted before opening email attachments or clicking web links, and that “auto-run” features must be disabled on components that use portable storage devices.

###### HOW (specific steps/approach)
###### 1) Set up the in-scope application list (sc-18.04_odp.01)
- Use endpoint management inventory (for example, mobile device management (MDM) / unified endpoint management (UEM) and device management) to keep a controlled list of the **approved email clients and web browsers** that handle attachments and links.
- Review and update the list through change control, including versioning.

###### 2) Configure each in-scope email client and browser to block automatic running
- For each listed email client:
  - Turn off any **preview/auto-opening** features that could trigger mobile code execution from attachments.
  - Make sure attachments require an explicit user action that triggers the required prompt.
- For each listed browser:
  - Turn off **automatic opening** of downloaded content.
  - Make sure potentially executable content requires explicit user confirmation before opening.

###### 3) Require the user prompt before anything runs (sc-18.04_odp.02)
- Apply a consistent user experience across the in-scope applications so that **before** opening an email attachment or clicking a web link that could deliver mobile code, the system prompts the user to confirm.
- Ensure choosing “Cancel/No” stops the action from continuing.

###### 4) Disable auto-run/auto-execute for portable media
- Apply system-level settings to disable auto-run/auto-execute for portable storage devices (USB/CD/DVD) on managed endpoints.
- Check that the setting cannot be bypassed through normal user actions.

###### 5) Evidence and validation
- For each in-scope application, run controlled tests using safe test attachments/links:
  - Confirm no mobile code runs when viewing email or when a page loads.
  - Confirm the prompt appears **before** opening or clicking.
  - Confirm that refusing the prompt prevents execution.
- Gather evidence from endpoint configuration reports and test results.

###### WHO (role responsible)
- **Endpoint Security Engineer / IT Security Configuration Manager**: implement and maintain the configuration baselines and collect evidence.
- **Service Owner (Email/Browser Platform)**: approve the in-scope application list and confirm any usability impacts.
- **Security Operations Centre (SOC) / Incident Response (IR) or Security Assurance**: review validation evidence and any exceptions.

###### Acceptance criteria
- For every application in **sc-18.04_odp.01**, mobile code does not run automatically from email attachments or web links.
- For every relevant user action, the system enforces **prompt-before-open/click** in line with **sc-18.04_odp.02**; declining the prompt prevents execution.
- Portable media auto-run/auto-execute is disabled on managed endpoints.
- Audit evidence is available: configuration state reports and documented test results showing prompt timing and that mobile code does not run automatically.

###### Actions Required for Compliance

- [ ] Create and keep up to date the approved, in-scope list of email clients and web browsers (sc-18.04_odp.01) using the device inventory and the change control process.
- [ ] Turn off email client features that automatically preview or open attachments, as these could trigger mobile code execution.
- [ ] Turn off the browser’s automatic opening of downloaded files, and require the user to explicitly confirm before opening any item that could be executable.
- [ ] Set up the required “confirm before opening or clicking” user prompt workflow for attachments and links (sc-18.04_odp.02), and make sure that choosing “Cancel/No” stops the action from running.
- [ ] Turn off automatic running or starting of files from portable media (USB drives and CD/DVD discs) at the managed device level.
- [ ] For each in-scope application, run controlled validation tests to confirm that nothing runs when a page is viewed or loaded, and that the prompt is shown before anything executes.
- [ ] Collect and store configuration reports and test evidence to be ready for audits


---

#### SC-18.5 — Allow Execution Only in Confined Environments (Enhancement)

This requirement is about ensuring that any approved “mobile code” (software that is sent to, or runs from, sources outside your organisation) can only run inside tightly controlled, pre-approved virtual machines that are set aside for this purpose. In practice, this reduces the risk that harmful or unwanted code could spread from a testing or intended location into other parts of your systems, leading to disruption, data loss, or unauthorised access.

To meet this expectation, the organisation must keep a current, formally approved written list of the specific confined virtual machines where mobile code is allowed. The list must also state which types of mobile code are acceptable and the rules for what it is permitted to do while running in those machines. The system must be set up to enforce this boundary by blocking execution anywhere outside the approved list, and it must keep records showing both successful allowed runs and blocked attempts.

The organisation must also document how this is designed, how it is managed day to day, who is responsible, and how it is included in its security planning.

##### Confined VM allow-list enforcement for permitted mobile code

- Category: Software
- Priority: Critical

###### WHAT
Put in place a technical enforcement mechanism so that **mobile code** can run **only** inside a **documented, organisation-approved set of restricted virtual machines (VMs)**. If mobile code is started outside these approved restricted VM environments, it must be **blocked**, and the system must produce **audit evidence** showing both **allowed** and **blocked** attempts.

###### WHY (control requirement)
SC-18(5) (enhancement) requires: **“Allow execution of permitted mobile code only in confined virtual machine environments.”** The guidance explains that this reduces the risk of malicious code spreading into other systems or components.

###### HOW (specific steps/approach)
1. **Define the restricted VM set**: Create and maintain an authoritative inventory of the specific VMs (by unique VM ID/name) that are designated as *restricted environments* for mobile code execution.
2. **Define permitted mobile code**: Create an allow-list of mobile code identities (for example, signed artefact identifiers/hashes, package IDs, or approved extension/container image digests—based on how your environment represents “mobile code”). Record the signer, version, and hash.
3. **Tag/enforce restricted status**: Configure the virtualisation or orchestration layer so only VMs with a specific restricted designation (for example, `confined=true` / `mobilecode-sandbox=true`) are eligible to run mobile code.
4. **Enforce allow-only execution**: Implement a deny-by-default approach in the orchestration or launch workflow so mobile code can run **only when**:
   - the target VM is in the restricted VM allow-list, and
   - the mobile code identity matches the permitted mobile code allow-list.
   Any mismatch must result in **execution being blocked**.
5. **Harden the restricted VMs** (to support the confinement intent): Apply baseline restrictions appropriate to your technology stack (for example, least-privilege service accounts, restricted outbound network access, and application-level allow-listing inside the restricted VM) so the restricted environment meaningfully limits potential impact.
6. **Generate audit evidence**: Bring together logs from the orchestration or hypervisor layer and the mobile code runtime (where applicable) so audit records include the mobile code identifier, VM identifier, and result (**allowed**/**blocked**). Keep logs according to your organisation’s retention requirements.
7. **Document the enforcement design**: Record where the policy is implemented, how the restricted VM list is checked, how the mobile code allow-list is managed, and how changes are controlled.

###### WHO (role responsible)
- **Infrastructure/Cloud Security Engineer**: implements enforcement in orchestration/virtualisation and hardens the restricted VMs.
- **Application Owner / Security Architect**: defines what counts as “mobile code” in your environment and maintains the permitted mobile code allow-list.
- **Configuration Management / Change Manager**: ensures updates to the restricted VM list and mobile code allow-list follow change control.
- **SOC / security information and event management (SIEM) Administrator**: ensures audit logs are collected, standardised, and retained.

###### Acceptance criteria
- Mobile code execution is **blocked** when the target VM is not in the restricted VM allow-list.
- Mobile code execution is **blocked** when the mobile code identity is not in the permitted mobile code allow-list.
- For every attempt (allowed or blocked), audit records exist showing the **mobile code identifier**, **restricted VM identifier**, and **outcome**.
- The restricted VM allow-list and permitted mobile code allow-list are documented, version-controlled, and traceable to approved change records.
- The enforcement mechanism is clearly deny-by-default (there is no “run on any VM” option for mobile code).

###### Actions Required for Compliance

- [ ] Create and get approval for an inventory of confined virtual machines (unique virtual machine IDs/names) that are allowed to run mobile code.
- [ ] Create an approved list of mobile code using cryptographic identity (for example, signed artefact identifiers or hashes), and record the person who signed it and the version.
- [ ] Set the orchestration or hypervisor rules so that the target virtual machine must be marked with `confined=true` (or an equivalent label) before any execution is allowed.
- [ ] Set “deny by default” execution rules so mobile code can run only when both the virtual machine (VM) and the mobile code are listed on their respective approved (allow) lists.
- [ ] Apply least-privilege access and limit outbound network connections for each virtual machine that runs in a restricted environment, in line with your organisation’s needs.
- [ ] Integrate orchestration and the hypervisor, and add runtime logging into the security information and event management (SIEM) system. Include fields for the mobile code identifier, the virtual machine (VM) identifier, and whether the outcome was allowed or blocked.
- [ ] Document how enforcement works, and keep version-controlled records of changes when updating the list of virtual machines that are confined and the mobile code allow-list.


---

### SC-20 — Secure Name/Address Resolution Service (Authoritative Source) (Control)

This requirement is about ensuring that when someone looks up your organisation’s website or service address, they get the correct information and also evidence that it genuinely came from your organisation and was not altered while being sent. Without this, attackers could redirect customers or staff to fake websites by changing the address details, or could make it harder for partners to trust that your published information is real.  

To meet this, your official name-and-address service must, with every external response, provide clear cryptographic proof showing where the information came from and that it was not changed during transmission. If your naming system is split across parent and child domains, you must also provide a way for outsiders to check the security status of the child domains and confirm the full chain of trust from the parent to the child.  

You should document how this is done, configure it correctly, keep records showing it is working as intended, and assign clear responsibility to the people who manage and oversee the service.

##### Enable DNSSEC on authoritative DNS with validated delegation chain

- Category: Software
- Priority: Critical

###### WHAT
Implement **Domain Name System Security Extensions (DNSSEC)** on all externally reachable **authoritative Domain Name System (DNS) zones**. This ensures external users receive **cryptographically verifiable proof that the response is genuine and has not been altered** for authoritative name-to-address lookups.  

For hierarchical name spaces, publish and keep the correct **delegation security status** (for example, **Delegation Signer (DS) records** at the parent) so external parties can verify the **full chain of trust from parent to child**.

###### WHY (control requirement)
**Security and Control (SC-20)** requires that a secure name/address resolution service (for example, DNS) provides authoritative records with **cryptographic proof of origin and no tampering** for external queries. It also requires that for hierarchical zones, the service shows **child-zone security status** (for example, using DS-related mechanisms) so external parties can validate the **chain of trust**.

###### HOW (specific steps/approach)
1. **Scope authoritative DNS**: Create an inventory of all authoritative DNS zones and servers that answer for externally reachable host/service names. Include any cloud or vendor-managed authoritative DNS that the organisation relies on.
2. **Enable DNSSEC signing for authoritative zones**: Configure each authoritative zone to sign its authoritative records, and ensure responses include the required DNSSEC signature information (for example, **Resource Record Signature (RRSIG)** records covering the returned records).
3. **Publish correct delegation security at the parent**: For each DNSSEC-signed delegated child zone, ensure the parent publishes the correct **DS records** that match the child zone’s **DNSSEC public keys (DNSKEY set)**. This allows other parties to validate the chain of trust.
4. **Harden and automate key management**: Use **Key Signing Key (KSK)** and **Zone Signing Key (ZSK)** separation, and automate key changes using policy-based rollover with safe procedures. This helps prevent errors such as missing or expired signatures, or mismatches between **DS** and **DNSKEY**.
5. **External validation testing**: Regularly test from external locations that DNSSEC validation works for representative records and delegated zones. Confirm that signature information is present and that validation chains are complete.
6. **Produce audit-ready evidence and runbooks**: Record the DNSSEC design (signing approach, key management approach, delegation approach), configuration settings, change procedures, and roles and responsibilities. Keep evidence of successful external validation and key rollover events.

###### WHO
- **DNS/Network Engineering Lead**: responsible for DNSSEC configuration, correct delegation/DS records, and operational hardening.
- **Security Engineering / Cybersecurity**: sets validation expectations, reviews evidence, and supports audit readiness.
- **Change Management Owner**: ensures DNSSEC changes follow approved change procedures.

###### Acceptance criteria
- For every externally reachable authoritative zone, external DNSSEC-capable resolvers can validate authoritative responses successfully (signatures are present and the chain validates).
- For every delegated DNSSEC-signed child zone, the parent publishes DS records that correctly match the child zone’s DNSKEY set, and external validation of the parent-to-child chain succeeds.
- DNSSEC key rollover is implemented with documented procedures, and evidence exists for at least one successful rollover or controlled signing change.
- Audit evidence exists, including: zone inventory, DNSSEC configuration/design documentation, runbooks, roles and responsibilities, and results/screenshots/logs from external validation tests.

###### Actions Required for Compliance

- [ ] List all externally reachable, authoritative Domain Name System (DNS) zones and identify which ones are responsible for public host and service names.
- [ ] Enable DNS security extensions (DNSSEC) signing for each authoritative zone, so that authoritative resource records (RRsets) are returned together with the required digital signature information.
- [ ] Set up and check secure parent-to-child delegation by publishing Domain Name System Security Extensions (DNSSEC) records that match each child domain’s DNSKEY set that has been signed with DNSSEC.
- [ ] Set up automated key signing key (KSK) and zone signing key (ZSK) lifecycle management, with documented safe key-change (rollover) procedures and clear separation of duties.
- [ ] Run ongoing external Domain Name System Security Extensions (DNSSEC) checks for example records and delegated zones, and record the results as evidence.
- [ ] Create and keep up to date DNS security extensions (DNSSEC) step-by-step guides, define roles and responsibilities, and set change procedures for updating signing and delegation information.


---

#### SC-20.2 — Data Origin and Integrity (Enhancement)

This requirement is about ensuring that when your systems look up internal names and addresses, they can show where the information came from and that it was not altered while being transmitted or while it was being used. Without this, attackers or mistakes could supply your systems with incorrect location details, which could lead staff and services to connect to the wrong places, expose information, or disrupt operations.

To meet this expectation, the organisation must keep clear, easy-to-check records showing that internal lookups use a trustworthy source and include protections that preserve the information’s accuracy. It should document the approach in its security policy and provide step-by-step procedures for secure internal name and address resolution. It must also keep system design and configuration records describing the protections that are actually in place, include these measures in the system security plan, and retain audit records that show the protections were applied.

##### DNSSEC-signed internal resolution with resolver integrity evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up internal name and address lookups using **authoritative, DNSSEC-signed zones** and **controlled recursive resolvers** that **check DNSSEC**. Create evidence that can be audited to show (1) the **source** of the lookup data (authoritative source and trust anchors) and (2) the **accuracy and protection** of the lookup results (the DNSSEC check outcome).

###### WHY (control requirement)
SC-20(2) (Enhancement) requires: **“Provide data origin and integrity protection artifacts for internal name/address resolution queries.”** This means the organisation must be able to show, with reviewable evidence, that internal lookup requests use a trustworthy source and that the returned information is protected from being changed.

###### HOW (specific steps/approach)
1. **Set up authoritative internal DNS zones** for the organisation’s internal domains and records, and make sure all relevant records are provided by these authoritative servers.
2. **Enable DNSSEC signing** on the authoritative zones (including the key signing key/key signing zone key strategy, documented key rotation, and controlled key management procedures).
3. **Deploy or standardise controlled recursive resolvers** for internal users and configure them to **require DNSSEC checking** (for example, treat invalid or incorrect DNSSEC results as failures; record the DNSSEC check status such as validated/bogus/indeterminate).
4. **Ensure internal clients use the approved resolvers** and cannot bypass them (for example, through network controls, DNS settings provided via DHCP and standard configuration baselines, and endpoint management settings).
5. **Enable and keep audit logs** on both the recursive resolvers and the authoritative servers, with enough detail to prove DNSSEC checking is enforced for internal lookups (including the requester identity where appropriate, the DNSSEC check result, and the authoritative zone/server used).
6. **Document the design and day-to-day operating procedures** as audit-ready evidence, including resolver configuration baselines, trust anchor management, key lifecycle and rotation, failure handling, and incident response.
7. **Include these protections in the system security plan** for the relevant system(s), and ensure the evidence is version-controlled and can be reviewed.

###### WHO (role responsible)
- **DNS/Network Security Engineer**: implements DNSSEC, resolver configuration, logging, and enforcement.
- **Infrastructure/Platform Owner**: ensures configuration baselines and change management.
- **Information Security / Compliance**: checks that the evidence is complete and included in the system security plan.

###### Acceptance criteria
- Internal clients resolve internal names and addresses **only using the controlled recursive resolvers**.
- Authoritative internal zones are **DNSSEC-signed**, and resolvers **check DNSSEC** for internal lookups.
- Resolver logs show **DNSSEC check outcomes** for internal lookup attempts (validated/bogus/indeterminate) and are kept according to the organisation’s logging requirements.
- A complete, assessor-ready **set of evidence** exists: design and configuration records, DNSSEC trust anchor and key management procedures, and proof that these measures are included in the **system security plan**.

###### Actions Required for Compliance

- [ ] Create official internal Domain Name System (DNS) zones for every internal name and address lookup record that the system uses.
- [ ] Turn on DNS security extensions (DNSSEC) signing for the authoritative domain zones, and document the key lifecycle and rotation procedures for the key signing key (KSK) and zone signing key (ZSK).
- [ ] Set up internal recursive name servers to check DNS Security Extensions (DNSSEC) for every request, and record whether each DNSSEC check passed or failed for each query.
- [ ] Require clients to use the approved DNS resolver service (using DHCP and DNS baseline settings and network and internet access controls) to prevent them from bypassing the controlled resolvers.
- [ ] Turn on logging for DNS query and response activity and for validation checks on both recursive and authoritative DNS servers, and keep those logs for audit purposes.
- [ ] Create documentation that assessors can review, covering the system design, how trust anchors are managed, possible failure scenarios, and how incidents are handled.
- [ ] Update the system security plan to reference the Domain Name System Security Extensions (DNSSEC) and DNS resolver integrity protections, and to include the locations where supporting evidence is stored.


---

### SC-21 — Secure Name/Address Resolution Service (Recursive or Caching Resolver) (Control)

This requirement ensures that when your systems look up names and addresses (for example, to decide where to send data), they only trust answers that come from approved, official sources and that the information was not altered while it was being sent. Without this, attackers could redirect your systems to the wrong destinations or tamper with the details, causing staff and services to connect to fraudulent locations. This could lead to fraud, disruption, or data loss.

To meet this expectation, the organisation must clearly state which sources are considered authoritative, make sure the service checks that each received answer genuinely came from those sources and has not been changed, and only then use, store, or share the result.

If the organisation uses standard name look-up technology, it must use the built-in protection that verifies signed responses. If it does not, it must use a trusted validation service reached through an authenticated, approved connection.

The organisation must document the secure process, keep records of outcomes in audit logs, assign responsibility for running it, and include it in the system’s security plan.

##### Enable DNSSEC validation and fail-closed caching on resolvers

- Category: Software
- Priority: Critical

###### WHAT
Configure all recursive/caching Domain Name System (DNS) resolvers used by the application environment to perform **Domain Name System Security Extensions (DNSSEC) based checks that confirm the source of DNS data and that the data has not been altered**, for responses received from authoritative sources. Also **reject (and do not store in cache or return) responses that fail these checks**.

###### WHY (control requirement)
Security and control requirement SC-21 requires the system to **request and perform checks that confirm the source of DNS data and that the data has not been altered** for name/address resolution responses received from authoritative sources. For DNS-based name/address mapping, the guidance specifies that DNS client resolvers must either **validate DNSSEC signatures** or **use an approved path to recursive resolvers that perform these validations**.

###### HOW (specific steps/approach)
1. **List all resolver paths used by the application**, including any forwarders, Virtual Private Cloud (VPC)/Virtual Network (VNet) DNS forwarders, and Operational Technology (OT)/Demilitarised Zone (DMZ) plant resolvers if applicable, and identify which components are recursive/caching.
2. **Turn on DNSSEC validation** on each recursive/caching resolver (for example, Domain Name System (DNS) software features such as BIND, Unbound, Knot, or Windows DNS, or equivalent managed DNS services). Ensure the resolver has the **root trust anchor** and can build the DNSSEC chain of trust.
3. **Use fail-closed behaviour**: configure the resolver so that **validation failures produce no usable answer** (for example, handling that results in SERVFAIL or equivalent “no answer” outcomes) rather than returning unsigned or invalid data to clients.
4. **Do not allow validation to be skipped upstream**: if resolvers forward queries to upstream resolvers, ensure the upstream path also performs DNSSEC validation (or remove/avoid any insecure forwarding paths that could weaken or downgrade validation).
5. **Cache only validated answers**: configure caching so that only **DNSSEC-validated** responses are stored and served. Ensure responses that are bogus or cannot be validated are **not** cached as valid.
6. **Create audit evidence**: centralise resolver configuration exports and forward DNSSEC validation outcome logs (validated/bogus/failed) to the security information and event management (SIEM) system for traceability.
7. **Test with controlled cases**: run tests using known DNSSEC-signed domains and an approved lab/controlled authoritative zone to confirm that valid responses are returned and invalid signatures are rejected.

###### WHO (role responsible)
- **Infrastructure/Domain Name System (DNS) engineering lead**: implements resolver configuration (DNSSEC validation, trust anchors, fail-closed behaviour, caching behaviour).
- **Security operations / Security Operations Centre (SOC)**: checks log forwarding, monitors DNSSEC validation failure rates, and keeps audit evidence.
- **Application owner**: confirms where the application depends on DNS and that clients use the approved resolvers.

###### Acceptance criteria
- All recursive/caching resolvers used by the application environment have **DNSSEC validation enabled** with an active trust anchor.
- For a test domain with an intentionally broken/invalid DNSSEC signature, the resolver returns **no valid answer** (fail-closed) and **does not cache** the invalid result.
- Resolver logs show **DNSSEC validation outcomes** (for example, validated versus bogus/failed) and are forwarded to the SIEM.
- Configuration evidence (exported settings and/or policy-as-code where available) is available for audit.

###### Actions Required for Compliance

- [ ] List all Domain Name System (DNS) resolvers and forwarders used by the application that use recursion and/or caching, and identify where the application depends on client DNS lookups.
- [ ] Enable Domain Name System Security Extensions (DNSSEC) validation on each recursive or caching resolver, and confirm that the root trust anchor and the chain-of-trust processing are working.
- [ ] Set DNS Security Extensions (DNSSEC) to fail closed, so that if DNSSEC checks fail, the system returns no usable answer (for example, using “SERVFAIL” or treating the result as “bogus”) instead of returning invalid data.
- [ ] Check that the caching policy only stores and serves Domain Name System Security Extensions (DNSSEC)–validated responses, and that responses that fail validation (or are marked as bogus) are not stored as valid.
- [ ] Check that any upstream forwarding route also performs Domain Name System Security Extensions (DNSSEC) validation, or remove any insecure forwarding routes that could bypass that validation.
- [ ] Send Domain Name System Security Extensions (DNSSEC) validation results from the forwarding resolver to the security information and event management (SIEM) system, and keep configuration evidence for audit purposes.
- [ ] Run test cases using a domain that is known to be signed with DNS Security Extensions (DNSSEC) and an approved test zone with an invalid signature, to confirm that the system rejects the response and does not store it in cache.


---

### SC-22 — Architecture and Provisioning for Name/Address Resolution Service (Control)

This requirement is about keeping the organisation’s “phonebook” for finding website names and internet addresses working reliably, and ensuring it is set up correctly for different types of users. If the service relies on a single point of failure, a website outage or network problem could prevent staff and customers from accessing the organisation’s online services. If internal and external access are mixed up, the wrong people could use the wrong systems, which could expose information or disrupt operations.

To meet this expectation, the organisation must run at least two official name/address servers: one primary and one secondary. These must be placed in different geographically separated network areas, not in the same building or network. The organisation must also separate responsibilities by configuring internal-only servers to accept requests only from approved internal locations, and external-only servers to accept requests only from approved outside sources such as the internet, with clear rules for who is allowed and technical controls that enforce those rules.

The organisation must document the design and procedures, keep configuration records and audit evidence, appoint named individuals responsible for managing it, and retain independent test proof that these arrangements work.

##### Dual-site authoritative DNS with enforced internal/external client roles

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up a fault-tolerant system for looking up names and addresses (for example, an authoritative Domain Name System (DNS) service). For each organisation’s DNS zone, run **at least two authoritative DNS servers**—**one primary and one secondary**—and place them in **separate geographic network subnetworks**. Also, enforce **separate internal and external roles**: DNS servers set up for **internal** use must only answer queries from **authorised internal clients**, and DNS servers set up for **external** use must only answer queries from **authorised external clients**.

###### WHY (control requirement)
SC-22 requires that systems providing name/address resolution are **fault-tolerant** (no single point of failure) and use **separate internal and external roles**. The guidance specifically expects at least two authoritative DNS servers (primary/secondary), deployed across two geographically separated network subnetworks, and role separation by limiting which clients can reach authoritative DNS servers for certain roles (for example, using address ranges and explicit lists).

###### HOW (specific steps/approach)
1. **Provide authoritative DNS redundancy**: For each authoritative zone, deploy two DNS servers with clear **primary** and **secondary** roles (for example, `ns1` as primary and `ns2` as secondary). Confirm both servers are authoritative for the zone (not “look-up only” or caching-only servers).
2. **Ensure geographic/network separation**: Put the primary and secondary servers in **different facilities** and **different network subnetworks** (for example, different VLANs/subnets), with independent network routes where possible.
3. **Implement internal/external role separation**:
   - Set up two server role endpoints (or two server configurations/views) aligned to internal versus external name/address resolution behaviour.
   - Configure network controls (firewalls/security groups/access control lists) so that **User Datagram Protocol (UDP) and Transmission Control Protocol (TCP) port 53 (UDP/TCP 53)** is allowed **only** from **authorised internal source ranges** to the internal-role authoritative servers, and allowed **only** from **authorised external source ranges** (for example, Internet edge resolvers or approved partner networks) to the external-role authoritative servers.
   - Keep clear allow-lists (address ranges and/or explicit client Internet Protocol (IP) lists) for each role.
4. **Harden authoritative behaviour**: Turn off recursion on authoritative servers and ensure they only provide authoritative answers. Where available, use DNS-aware rate limiting and edge protections to reduce the impact of large numbers of queries.
5. **Make provisioning auditable and repeatable**: Manage DNS server settings and firewall/access control list rules using version-controlled infrastructure configuration (or equivalent configuration management), with change control and peer review.
6. **Produce evidence and validate**: Enable access/query logging sufficient to show that only authorised clients can reach the intended role endpoints. Run and keep records of regular validation tests (for example, from internal and external test networks) proving that internal-role servers reject unauthorised external sources and external-role servers reject unauthorised internal sources.

###### WHO (role responsible)
- **Infrastructure/Domain Name System (DNS) Engineering Lead**: designs and sets up the authoritative DNS architecture and role separation.
- **Network Security Engineer**: implements and maintains firewall/access control list rules and logging.
- **Change Manager / Change Advisory Board (CAB)**: ensures DNS and network changes are controlled and reviewed.
- **Security/Compliance Analyst**: checks that the evidence is complete against SC-22 expectations.

###### Acceptance criteria
- For each organisation authoritative DNS zone, there are **at least two authoritative DNS servers** configured as **primary** and **secondary**.
- The primary and secondary servers are in **different geographically separated network subnetworks** (not in the same physical facility).
- Internal-role authoritative DNS servers accept DNS queries **only** from the defined internal allow-list/ranges; external-role authoritative DNS servers accept DNS queries **only** from the defined external allow-list/ranges.
- Recursion is disabled on authoritative servers (authoritative-only behaviour).
- Firewall/access control list and DNS configurations are managed through version-controlled, change-controlled processes.
- Logged evidence exists showing enforcement (allowed/blocked outcomes), and periodic test results demonstrate correct internal/external separation.

###### Actions Required for Compliance

- [ ] For each DNS zone, set up two trusted DNS servers, with one clearly acting as the primary and the other as the secondary.
- [ ] Put the primary and secondary Domain Name System (DNS) servers in separate facilities and on different network subnetworks.
- [ ] Define internal and external client allow-lists (IP address ranges and named IP addresses) for each Domain Name System (DNS) role.
- [ ] Set firewall, security group, and access control list (ACL) rules to restrict Domain Name System (DNS) traffic using User Datagram Protocol (UDP) and Transmission Control Protocol (TCP) on port 53 to the internal-role and external-role DNS servers only.
- [ ] Disable recursion on authoritative Domain Name System (DNS) servers and check that responses come only from authoritative information.
- [ ] Enable and keep DNS (Domain Name System) access and query logging so you can provide audit evidence that role separation controls are being enforced.
- [ ] Run and record regular validation tests from both internal and external test networks to confirm that access is correctly allowed or blocked.


---

### SC-23 — Session Authenticity (Control)

This requirement is about making sure that when two systems communicate, they can reliably trust who they are talking to, and that the information exchanged during the conversation is genuine. Without this, an attacker could secretly interfere with the connection, take over an existing conversation, or send false messages so that actions are carried out under the wrong identity or based on altered information.

To meet this expectation, the organisation must set clear rules for how it will protect the authenticity of ongoing communication sessions, and put practical procedures in place to do so. This includes how it prevents third-party interference, session takeovers, and the insertion of false information. It must document how the system is designed to achieve these protections, configure the systems so the protections are enabled where they are needed, and keep records of the relevant settings.

Finally, it must keep audit records showing when session authenticity protections were applied or failed, assign responsibility to named roles, and be able to demonstrate with evidence that the protections work as intended.

##### Enforce mutual TLS with strict identity checks for session authenticity

- Category: Software
- Priority: Critical

###### WHAT
Put protections in place so that system-to-system connections can prove who they are at the start of a session, using **mutual Transport Layer Security (mutual TLS (mTLS))** with **strict checks that the certificate identity matches** (including subject alternative name (SAN)/hostname checks, enforcing an approved set of trusted certificates, and clear rules for handling certificate revocation). Make sure a session is only created after both sides prove their identities, and keep records of the connection results for audit purposes.

###### WHY (control requirement)
Security Control SC-23 requires protecting the **authenticity of communication sessions**, including resistance to **man-in-the-middle attacks**, **session hijacking**, and **the insertion of false information into sessions**. Using session-level cryptographic authentication (mutual TLS (mTLS)) gives confidence to both ends throughout the session.

###### HOW (specific steps/approach)
1. **Set session authenticity requirements based on integration type** (for example: internal application programming interfaces (APIs), service-to-service, supplier/vendor integrations, remote management). Require **Transport Layer Security (TLS) version 1.2 or later (TLS 1.2+) or TLS 1.3**, require mutual TLS (mTLS), and define which cipher suites are allowed and how certificates must be validated.
2. **Apply mutual TLS (mTLS) at the session layer** for all relevant service endpoints (for example: application programming interface (API) gateways, reverse proxies, service mesh sidecars, or application libraries). Ensure both the client and the server present certificates during the connection setup.
3. **Enforce strict certificate validation on both sides**:
   - Check the certificate chain against an approved trust store.
   - Require subject alternative name (SAN)/identity matching to the expected peer identity (service account/integration identity), not just “any valid certificate”.
   - Define how to handle revocation and expiry (for example: online certificate status protocol (OCSP)/certificate revocation list (CRL) checks where supported, or short-lived certificates with automated rotation).
4. **Link application session details to the authenticated connection identity**: pass the authenticated peer identity from the TLS layer into the application/session context (for example: via gateway headers or verified client certificate attributes) and use it for access decisions and for matching/correlating sessions.
5. **Record and keep evidence of session authenticity**: log both successful and failed TLS handshakes (peer identity, endpoint, time, and failure reason) to help detect man-in-the-middle (MITM) and hijacking attempts and to show that the controls work.
6. **Run certificate management as an ongoing operation**: automate certificate issuing and rotation, manage onboarding and offboarding of peers, and have emergency rollback procedures aligned to change management.

###### WHO (role responsible)
- **Security Architect / Security Engineering**: define authenticity requirements and certificate validation rules.
- **Platform/Network Engineering or Cloud Security Team**: implement mutual TLS (mTLS) enforcement (gateways/proxies/service mesh) and automate certificate lifecycle management.
- **Application Owners**: ensure the authenticated peer identity is included in the application/session context and used for access decisions.
- **Security Operations Centre (SOC) / Security Operations**: review patterns of handshake failures and investigate suspected man-in-the-middle (MITM) or hijacking.

###### Acceptance criteria
- All defined system-to-system integration endpoints establish sessions using **mutual TLS (mTLS)** (no unauthenticated TLS is allowed for those paths).
- Both endpoints perform **strict certificate identity validation** (subject alternative name (SAN)/expected peer identity) and reject mismatches.
- TLS handshake failures are logged with enough detail to identify the peer identity attempt and the reason for failure.
- Application/session context reflects the authenticated peer identity from the TLS handshake and is used for access decisions and session correlation.
- Certificate rotation/onboarding/offboarding works in test and production without turning off authenticity checks (no “trust all” exceptions in normal operation).

###### Actions Required for Compliance

- [ ] Create an integration-by-integration session authenticity requirement matrix that requires mutual Transport Layer Security (mTLS) and strict certificate validation.
- [ ] Set up API gateways, reverse proxies, or a service mesh so that every defined system-to-system session path requires client certificates.
- [ ] Set up certificate-check rules that only allow certificates from approved trust stores, and verify that the certificate’s subject alternative name (SAN) matches the expected identity of the other party.
- [ ] Use authenticated Transport Layer Security (TLS) peer identity as part of the application or user session information, and use it to decide what the user is allowed to do and to link related session activity together.
- [ ] Enable and centralise logging of whether each Transport Layer Security (TLS) connection handshake succeeds or fails, including the other party’s identity, the endpoint, the time, and the reason for any failure, in the security information and event management (SIEM) system.
- [ ] Automate the issuing, renewing, adding, and removing of digital certificates, with clear emergency rollback procedures.


---

#### SC-23.1 — Invalidate Session Identifiers at Logout (Enhancement)

This requirement is about making sure that when someone logs out, the system immediately “closes the door” for that specific login session so it cannot be used again. If this is not done, an attacker who somehow gets a valid session identifier could try to keep using it to access accounts or systems even after the person has left, potentially bypassing the normal sign-in checks.

To meet this expectation, the organisation must ensure that session identifiers are made unusable both when a user logs out and when a session ends for any other reason. The system must also reject any later attempt to use an identifier that has been cancelled.

The organisation should document how sessions are ended, set clear procedures to keep sessions genuine, and keep evidence in audit records showing that sessions are cancelled at logout and at other session-ending events. This approach must be included in the system’s security plan. Responsibilities must be assigned to the relevant administrators, and the system must be configured and supported using suitable technical controls, with configuration details kept up to date.

##### Enforce session revocation on logout and termination via IdP + app checks

- Category: Software
- Priority: Critical

###### WHAT
When a user logs out, and whenever a session ends for any other reason (for example, forced sign-out, credential reset, or an administrator disabling an account), immediately stop that session from being used again. Make sure the application (and any gateways or application programming interfaces) refuses any later attempt to use a stopped session identifier.

###### WHY (control requirement)
Control SC-23(1) enhancement requires that session identifiers are stopped when a user logs out or when a session ends for other reasons. This reduces an attacker’s ability to reuse a session identifier that was previously valid.

###### HOW (specific steps/approach)
1. **Centralise session control in the enterprise identity provider (IdP)**: Configure the organisation’s identity provider (IdP) so that logout and forced sign-out are treated as the official (authoritative) end of a session.
2. **Ensure logout and session-ending information is shared**: Use supported logout methods (for example, front-channel and back-channel logout where available) so that logout causes the relevant session identifiers to be revoked or ended at the IdP.
3. **Cover non-logout session ending events**: Ensure that events such as account disablement, password or credential reset, risk-based sign-out, or administrator-initiated forced termination lead to immediate session revocation at the IdP.
4. **Enforce rejection to stop reuse**: Configure the application and any application programming interface (API) gateway or reverse proxy to reject requests that include a revoked session identifier. Do this by validating the token or session on every request (or at a short, defined interval if continuous validation is not possible). Where applicable, enable refresh-token rotation so that previously issued session identifiers cannot be reused.
5. **Keep audit evidence and link related events**: Turn on audit logging for both (a) IdP logout, forced sign-out, and session revocation events, and (b) access attempts to the application or gateway after the session has ended. Link (correlate) these logs to show that revoked identifiers are refused.
6. **Document session ending rules and how they map to enforcement**: Update system security documentation and operational runbooks to define what counts as “session termination” (logout versus forced termination), which events trigger IdP revocation, and how the application rejects reuse.

###### WHO (role responsible)
- **Application owner / identity and access management (IAM) engineer**: Configure IdP session behaviour and logout/forced sign-out behaviour.
- **Application security engineer / platform engineer**: Implement enforcement in the application and gateways (token/session validation and refresh rotation).
- **Security operations / security information and event management (SIEM) engineer**: Ensure audit logging, retention, and correlation rules are in place.

###### Acceptance criteria
- After a user logs out, the IdP records a logout/session termination event, and the application or gateway rejects any later requests that use the previous session identifier.
- After a session ends due to a non-logout event (for example, administrator forced sign-out, account disablement, or credential reset), the IdP revokes or ends the session, and subsequent reuse attempts are rejected.
- Audit logs show (1) the termination event at the IdP and (2) the matching denial/rejection at the application or gateway for reuse attempts.
- The system security plan and runbooks document the session termination events and the enforcement method used by the relying party to prevent reuse.

###### Actions Required for Compliance

- [ ] Configure the organisation’s identity provider (IdP) to end user sessions when users log out, and to end sessions when users are forcibly signed out or when session termination happens without a normal logout.
- [ ] Enable logout “propagation” (using front-channel and/or back-channel methods where supported) so that relying parties receive signals that the session has ended.
- [ ] Set up relying-party enforcement so the application or gateway checks whether the session or token is still valid, and blocks any session identifiers that have been cancelled or invalidated.
- [ ] Where possible, enable refresh-token rotation and stop accepting any previously issued refresh or session identifiers after they have been revoked.
- [ ] Enable and keep audit logs for identity provider (IdP) logouts and forced sign-outs, and for when applications or gateways reject attempts to reuse access after termination.
- [ ] Update the system security plan and the runbooks to record how session-ending events are matched and to describe the enforcement method used to stop sessions being reused.


---

#### SC-23.3 — Unique System-generated Session Identifiers (Enhancement)

This requirement is about ensuring that every time someone starts a session with your system, they are given a new, hard-to-guess session code that only your system can create. If session codes could be predicted, reused, or influenced by a user, an attacker could copy an old valid code and pretend to be an authorised user, potentially gaining access without logging in again.

To meet this expectation, your organisation must generate a new session identifier for every session using strong, system-generated randomness, providing at least 128 bits of unpredictability per identifier. The system must also accept only session identifiers that it generated itself, and it must reject any codes that were not created by the system or that have already been used in earlier sessions, so that re-login is required or access is denied as appropriate.

##### CSPRNG session IDs with server-side validation (≥128-bit entropy)

- Category: Software
- Priority: Critical

###### WHAT
Create a new, unique session identifier for each session using cryptographically secure randomness (at least 128 bits of entropy per identifier). Then make sure the application only accepts session identifiers that it generated itself—if an identifier is not present and active in the server-side session records, reject it.

###### WHY (control requirement)
The SC-23(3) enhancement requires: **(1)** generating a unique session identifier for each session using **{{ insert: param, sc-23.03_odp }}** and **(2)** accepting only **system-generated** session identifiers. The guidance explains that strong randomness helps protect against attackers reusing or guessing (brute-forcing) session identifiers.

###### HOW (specific steps/approach)
1. **Generate session IDs using a cryptographically secure random number generator (CSPRNG)**: At the start of each session, generate a raw random value using the operating system or platform CSPRNG, ensuring the value provides **at least 128 bits of entropy** (per sc-23.03_odp “randomness requirements”). Encode the value for safe transport or storage (for example, base64url or hex) without reducing its entropy.
2. **Use server-side session state**: Keep session details in a server-managed store (for example, a Redis cluster, distributed cache, or database) using the generated session identifier as the key. Set an explicit **time-to-live (TTL)** and ensure sessions are revoked or removed when the user logs out.
3. **Check on every request**: When a request includes a session identifier (typically via a cookie or header), the application must **look it up** in the server-side session store. If the identifier is **missing, expired, revoked, or not found**, treat the request as unauthenticated (force re-authentication or deny access) and **do not accept it silently**.
4. **Reject non-system-generated and reused IDs**: Because only identifiers stored on the server are valid, any identifier not created by the system (or reused after expiry or revocation) will fail validation.
5. **Evidence and auditability**: Record session creation (including that a CSPRNG was used and the basis for the entropy), session validation results (valid versus invalid/not found), and session revocation events. Keep logs according to organisational retention requirements.

###### WHO
- **Application security engineer / backend engineer**: implement session ID generation, integrate the server-side session store, and validate session identifiers on each request.
- **Platform/infrastructure engineer**: set up and secure the session store (availability, TTL, clustering) and ensure secure configuration.
- **Security operations / compliance**: review evidence (logs and configuration exports) and confirm readiness for audit.

###### Acceptance criteria
- For every session start, the system generates a **new** session identifier using **cryptographically secure randomness** with **at least 128 bits of entropy** per sc-23.03_odp.
- For every request, the system **accepts only** session identifiers that exist in the server-side session store as active (valid lookup); otherwise it denies access or forces re-authentication.
- Session identifiers that are replayed or previously used after logout or expiry are rejected (no successful authorisation).
- Audit evidence exists showing: the session ID generation method (CSPRNG), the entropy basis (documented), the server-side validation behaviour, and events for invalid sessions.

###### Actions Required for Compliance

- [ ] Create a unique session identifier for each session using the platform’s cryptographically secure random number generator (CSPRNG), and record that the randomness provides at least 128 bits of entropy, as required by sc-23.03_odp.
- [ ] Set up a server-side session storage system (for example, Redis or a database) that uses the generated session identifier as the key, with a clearly defined time limit (time-to-live) and session invalidation when the user logs out.
- [ ] Check the session identifier provided by the user against the server’s stored records at the time of each request. If it is not found or has expired, deny the request and require the user to sign in again.
- [ ] Record audit logs for when sessions are created, whether session checks succeed or fail (valid or invalid), and when sessions are revoked.
- [ ] Create automated tests that try using old session identifiers after they have expired and after the user has logged out, and verify that the system rejects them.


---

#### SC-23.5 — Allowed Certificate Authorities (Enhancement)

This requirement is about making sure your web connections only trust certificates from a known, approved set of certificate providers. If you allowed certificates from unknown or unapproved providers, an attacker could potentially make your systems treat a fake website as genuine. This could lead to stolen information, fraudulent logins, or data being sent to the wrong place.

To meet this requirement, the organisation must keep an up-to-date, documented list of which certificate providers are allowed to verify the certificates used to set up secure web sessions. This list must include only the Department of Defense public key infrastructure (DoD PKI) provided by the Defense Information Systems Agency (DISA), and any other commercial providers that have been explicitly approved for Transport Layer Security (TLS).

Any systems that create or check these secure web sessions must be configured to accept certificates only from the providers on the approved list. The organisation must also keep audit records showing evidence that these checks were carried out.

The organisation must document how this is done in its procedures, system design, and security planning, and assign clear responsibility for maintaining the approved list and managing any changes.

##### Enforce TLS CA allowlist for protected sessions (DoD + approved CAs)

- Category: Software
- Priority: Critical

###### WHAT
Set up a clear list (allowlist) of which certificate authorities (CAs) are allowed to check the certificates used to set up **protected sessions** (Transport Layer Security (TLS)). Only CAs in the organisation-approved set (parameter **sc-23.05_odp: certificated authorities**) may be used for TLS certificate checking. All other CAs must be rejected.

###### WHY (control requirement)
SC-23(5) enhancement requires: **“Only allow the use of {{ insert: param, sc-23.05_odp }} for verification of the establishment of protected sessions.”** This stops protected sessions being set up using certificates issued by unapproved or potentially harmful CAs.

###### HOW (specific steps/approach)
1. **Create one “single source of truth” register** called “Allowed TLS CAs”, containing exactly the CAs approved for TLS checking (including **Department of Defense (DoD) Public Key Infrastructure (PKI) (Defense Information Systems Agency (DISA))** and any explicitly approved commercial CAs), as defined by **sc-23.05_odp**.
2. **Store CAs in a format that can be enforced by systems** (for example, CA certificate fingerprints and/or the issuer distinguished name (DN) / CA name), and keep the register versioned.
3. **Build endpoint-specific trust bundles** from the register (do not add to existing system trust stores). Make sure each TLS stopping point (for example, web servers, application programming interface (API) gateways, reverse proxies, and load balancers) trusts **only** the generated bundle.
4. **Apply the check during the TLS connection setup (TLS handshake)**. If the presented certificate chains to a CA that is not on the allowlist, the handshake must fail and the protected session must not be created.
5. **Keep evidence for audits**: log the result of each TLS certificate check and the CA/issuer used (or why it failed) for every protected session attempt, and send the logs to the security information and event management (SIEM) system for retention.
6. **Manage changes with control**: require security review and approval before any update to the allowed CA register, and release trust-bundle updates through the organisation’s configuration/release process with an auditable record.
7. **Regularly verify the configuration**: run periodic compliance checks to confirm each TLS endpoint trust bundle matches the allowed register, and alert if anything changes unexpectedly.

###### WHO (role responsible)
- **Security Engineering / Identity and Access Management (IAM) & Public Key Infrastructure (PKI) team**: maintain the Allowed TLS CAs register and approve additions/removals.
- **Infrastructure/Platform Engineering**: create the trust bundles and configure each endpoint.
- **Application/Network Operations**: ensure all TLS stopping points are covered and that logs are collected correctly.
- **Change Manager / Change Advisory Board (CAB)**: enforce approval steps for changes to the CA allowlist.

###### Acceptance criteria
- Every TLS stopping point used for protected sessions trusts **only** the CAs in **sc-23.05_odp** (Department of Defense (DoD) Public Key Infrastructure (PKI) (Defense Information Systems Agency (DISA)) + approved commercial CAs).
- TLS connection attempts that use certificates chaining to an unapproved CA **fail** (no protected session is established).
- For every TLS certificate check attempt, logs show **success/failure** and the **issuer/CA** (or the failure reason), and this evidence is kept in the SIEM.
- Any change to the allowed CA register is traceable to an approved change record and results in the matching trust-bundle update.
- Periodic configuration compliance checks confirm there is no drift from the allowed CA register.

###### Actions Required for Compliance

- [ ] Create and keep an “Allowed TLS Certificate Authorities (CAs)” register that includes only the Department of Defense public key infrastructure (DoD PKI) from the Defense Information Systems Agency (DISA) and only commercial certificate authorities (CAs) that have been explicitly approved, as required by sc-23.05_odp.
- [ ] For each permitted certificate authority (CA), create machine-readable identifiers (for example, certificate fingerprints and/or the issuer distinguished name and CA name) and version the register.
- [ ] Create trust bundles for every Transport Layer Security (TLS) connection end point using the approved register, and configure each TLS system to trust only those bundles.
- [ ] Set up Transport Layer Security (TLS) checks so connections fail if the certificate chain does not end with an approved certificate authority (CA).
- [ ] Set up and centralise logging of the results of Transport Layer Security (TLS) checks, including the certificate issuer (or the certificate authority) or the reason for failure, and send these logs to security information and event management (SIEM) for secure retention.
- [ ] Use formal change approvals (“change control gates”) before updating the list of authorised certificate authorities (CAs), and release any trust-bundle updates through the normal release process (standard release pipeline).
- [ ] Carry out regular compliance checks to spot any changes in the trusted certificate store (“trust store”) that do not match the approved certificate authority (CA) register, and raise alerts when differences are found.


---

### SC-24 — Fail in Known State (Control)

This requirement is about making sure that if a system experiences a serious failure, it does not move into an unsafe or uncontrolled state. Instead, it must automatically switch to a known, safer, reduced operating mode.

Specifically, if there is power loss, a software crash, a hardware fault, a network outage, a storage input/output failure, or a watchdog reset, the system must:
- pause non-essential services,
- keep critical functions running,
- allow access only for authorised maintenance accounts.

At the same time, it must preserve:
- the current configuration,
- information about any user sessions that were in progress,
- queued transactions,
- the last known sensor or telemetry readings,
- system logs up to the point when the failure occurred.

This matters because, without this approach, important information could be lost or damaged, operations could be disrupted longer than necessary, and unauthorised access could become possible during recovery.

To meet this expectation, the organisation must define and document the specific failure triggers and the safe mode behaviour, ensure the system is designed to perform this automatically, keep the supporting procedures and records, and assign clear responsibility for implementing and maintaining it.

##### Automated safe-mode on defined failures with state preservation

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated “fail to known state” process so that, for the organisation-defined failure types, the application or system moves into a known, safer reduced-function mode. This must be done while keeping the organisation-defined system information needed to continue safely.

###### WHY (control requirement)
Security control SC-24 requires the system to “fail to a {{ insert: param, sc-24_odp.02 }} … while preserving {{ insert: param, sc-24_odp.03 }}” for the organisation-defined failure types {{ insert: param, sc-24_odp.01 }}. This helps prevent loss of confidentiality, integrity, or availability, and supports safe recovery with less disruption.

###### HOW (specific steps/approach)
###### 1) Define and implement failure detection and triggers (per component)
Create a clear mapping from each failure type in {{ sc-24_odp.01 }} to the specific signals that show it is happening in the target environment. Examples include:
- power loss: unclean shutdown during boot
- software crash: crash or supervisor exit codes
- hardware fault: host or cluster health events
- network outage: loss of upstream connectivity
- storage I/O failure: storage input/output error thresholds
- watchdog reset: watchdog reset event

Each detector must raise one internal “enter safe mode” event.

###### 2) Build a Safe Mode Controller that enforces the known safe reduced mode
Create a central Safe Mode Controller that, when it receives the safe-mode event, enforces {{ sc-24_odp.02 }} by:
- pausing non-essential services (stop accepting new work for non-critical endpoints/workers; keep only critical functions running or explicitly place them into a held state)
- allowing access only for authorised maintenance accounts (switch to maintenance-only access; block all other user and application programming interface access paths)
- keeping the system in safe mode until an explicit operator-approved recovery condition is met (for example, health is restored and the maintenance window is approved)

###### 3) Keep the required system information during failure handling
Before the system fully reduces its functions (or immediately when safe mode starts), store the organisation-defined {{ sc-24_odp.03 }}:
- current configuration (save the active configuration version or manifest and relevant runtime settings)
- active session information and queued transactions (use server-side resumable sessions and durable queues/outbox-inbox so work can be continued without being duplicated)
- last known sensor or monitoring data (save a telemetry snapshot to durable storage)
- system logs up to the point of failure (buffer logs and write them to durable storage before pausing services; use crash-safe logging where applicable)

###### 4) Ensure safe-mode entry is automatic and consistent after restart
For failure types that may show up as a restart (software crash, watchdog reset, power loss), ensure the start-up sequence checks for “unclean shutdown / watchdog reset / crash marker” and automatically re-enters safe mode. Then continue restoring state using the preserved {{ sc-24_odp.03 }}.

###### 5) Provide evidence that safe mode was entered
Generate structured audit records for:
- the reason safe mode was triggered (which failure type)
- the time it happened
- which components were affected
- which state items were saved
- when maintenance-only access was turned on

Make sure these audit records are included in the preserved logs up to the point of failure.

###### WHO
- **Application/Platform Engineering Lead**: builds the Safe Mode Controller, the failure detectors, and the state-saving mechanisms.
- **Infrastructure/Operations Lead**: connects component health signals (for example, host/BMC/cluster events, watchdog markers) and checks restart behaviour works as expected.
- **Security/Compliance Owner**: confirms maintenance-only access enforcement matches the authorised maintenance accounts and reviews the evidence produced.

###### Acceptance criteria
- For each failure type in {{ sc-24_odp.01 }}, the system enters the safe reduced mode defined in {{ sc-24_odp.02 }} within the agreed time window, and pauses non-essential services while holding critical functions.
- When safe mode starts, the system saves all required items in {{ sc-24_odp.03 }} (configuration, session state, queued transactions, last telemetry snapshot, and logs up to the failure point) to durable storage.
- While in safe mode, all non-maintenance access paths are blocked (including any user interface, application programming interface, or service accounts not in the authorised maintenance set). Only authorised maintenance accounts can access the allowed functions.
- After restart following power loss/crash/watchdog reset, the system automatically re-enters safe mode and restores from the saved state without losing queued transactions or breaking session continuity.
- Audit evidence exists showing the trigger reason, which state items were saved, and that maintenance-only access enforcement was applied.

###### Actions Required for Compliance

- [ ] For each failure type listed in **sc-24_odp.01**, define the specific detection signals for every component that is affected.
- [ ] Implement a “Safe Mode” controller that enforces sc-24_odp.02 by pausing non-essential services, keeping critical functions running, and restricting access to maintenance use only.
- [ ] Save sc-24_odp.03 items to permanent storage before or when entering safe mode. This includes configuration, session state, queued transactions, a telemetry snapshot, and crash-safe logs.
- [ ] Add checks during system start-up to automatically return to safe mode after a power cut, a software crash, or a watchdog reset marker.
- [ ] Set the system to allow only maintenance access while in safe mode, and check that every non-maintenance access route is blocked.
- [ ] Create automated tests that simulate each **SC-24 ODP.01** failure and confirm that the system state is preserved and that audit evidence is recorded.


---

### SC-25 — Thin Nodes (Control)

This requirement is about keeping certain computers as simple as possible, so they do only the tasks they need to do and store only the information they need to store. This matters because if a thin client computer used for work or administration is compromised, attackers have fewer options to misuse and less data to steal or misuse.

To meet this expectation, the organisation must use:
- thin client workstations,
- diskless virtual desktops, and
- jump hosts

for their intended purposes. Each device must be configured to run only the minimum necessary functions and to store only the minimum necessary information—for example, avoiding persistent local storage where diskless operation is used.

The organisation must also:
- write and maintain clear instructions for how these devices are used,
- keep up-to-date design and configuration records showing how the “minimum” approach is achieved,
- include these controls in its overall security plan,
- assign named responsibilities, and
- keep audit records that show the settings are being followed.

##### Thin node baselines for minimal functionality and diskless storage

- Category: Software
- Priority: Critical

###### WHAT
Set and enforce “minimum needed” starting points (baselines) for each specific system component listed in **SC-25_odp** (thin client workstations, diskless virtual desktops, and jump hosts). These baselines must ensure the components only do the minimum required tasks and only store the minimum required information (for example, diskless or non-persistent operation).

###### WHY (control requirement)
SC-25 requires the organisation to **“Employ minimal functionality and information storage on the following system components: {{ insert: param, sc-25_odp }}.”** The guidance explains that reducing what the components do and what they store means:
- there is less to secure on every device, and
- less information, systems, and services are exposed to attacks.

###### HOW (specific steps/approach)
1. **Create three official baselines** (Thin Client, Diskless VDI, Jump Host) that clearly specify:
   - Allowed/required software and services for the intended purpose.
   - Prohibited or non-essential software, agents, and operating system features.
   - Required settings to achieve **minimal information storage** (for example, non-persistent VDI pools; no or limited local storage on thin clients; controlled session end actions such as clearing on jump hosts).
2. **Enforce the baselines** using the organisation’s standard device and virtualisation management tools:
   - Thin clients: apply configuration profiles that turn off/remove non-essential services, limit local administrator abilities, and enforce approved storage/redirection behaviour.
   - Diskless VDI: set up non-persistent desktops (or an equivalent approach) and ensure user/session data is sent to approved storage; ensure session end actions remove any temporary data.
   - Jump hosts: limit installed tools to what is required, minimise local user data storage, and enforce session/session-end clean-up.
3. **Put “minimal use” into day-to-day practice** by publishing a short, role-based procedure for users and administrators covering:
   - What storage is allowed (approved network storage only; no local storage unless explicitly permitted).
   - Expected reset/clean-up behaviour (for example, logout/reboot/session end).
   - Prohibited actions (for example, installing additional software, saving sensitive data locally).
4. **Keep audit-ready proof** by retaining:
   - Baseline versions and change records.
   - Configuration compliance reports and enforcement logs from the management platform.
   - Evidence that the deployed node types match the intended minimal-function/minimal-storage configuration.

###### WHO
- **Endpoint/VDI platform owner** (or infrastructure engineering lead): owns the baseline definitions and the enforcement settings.
- **Security engineering / compliance**: checks baselines match the intent of SC-25 and approves what is allowed and prohibited.
- **Service desk / operations**: follows the published thin-node usage procedures and escalates any deviations.

###### Acceptance criteria
- For each node type in **sc-25_odp**, the deployed fleet is clearly configured to:
  - run only the baseline-approved functions/services, and
  - use the required minimal information storage approach (for example, diskless/non-persistent VDI; no or controlled local storage on thin clients and jump hosts).
- Baselines are documented, version-controlled, and included in the organisation’s security planning and change process.
- Compliance evidence exists showing enforcement and how configuration changes are handled (for example, periodic compliance reports and enforcement logs).
- Published procedures are available to relevant users and administrators, and any deviations are handled through defined change and escalation routes.

###### Actions Required for Compliance

- [ ] Define three baseline configurations—Thin Client, diskless virtual desktop infrastructure (VDI), and jump host—setting out which functions and services are allowed, and explicitly listing any software or features that are not permitted.
- [ ] Set up virtual desktop infrastructure (VDI) so it does not store data between sessions, and ensure users’ desktops only use approved profiles and data locations, with session end wiping all temporary data.
- [ ] Apply endpoint configuration profiles to thin clients and jump hosts to turn off or remove non-essential services, and to ensure only controlled and cleared local storage is used.
- [ ] Publish procedures for using role-based thin nodes, including what storage is allowed, what reset and cleaning are expected, and actions that are not permitted (for example, installing software locally).
- [ ] Set up ongoing compliance checks and detect any changes (drift) in the endpoint and virtual desktop infrastructure (VDI) management platform, then fix any areas that do not meet the baseline requirements.
- [ ] Keep audit evidence: the baseline version history, compliance reports, and enforcement or drift logs for each type of node.


---

### SC-26 — Decoys (Control)

This requirement is about setting up carefully managed “trap” areas inside your systems. These areas are made to look attractive to attackers, so you can identify them early, keep them occupied away from real services, and learn from what they attempt. Without this, attackers may test and break into your real business systems without being noticed, or their harmful actions could spread and cause real disruption, data loss, or financial harm.

To meet this expectation, the organisation must deploy decoy components that are deliberately configured to attract malicious attention, and use them to detect, redirect, and analyse hostile behaviour. The decoys must be kept appropriately separated from operational systems, so anything an attacker does in the decoy cannot spread into systems that support your mission and day-to-day work.

The organisation must also document how the decoys are used and designed, record relevant activity for investigation, include decoy use in its security planning, assign clear responsibilities, involve system developers as needed, implement the supporting mechanisms, and consult the Office of the General Counsel before deploying decoys when the specific deployment requires it.

##### Isolated deception honeypots with SIEM evidence and OGC workflow

- Category: Software
- Priority: Critical

###### WHAT
Place purpose-built decoy components (for example, honeypot services and deception endpoints) inside the organisation’s information technology (IT) and operational technology (OT) environment. These decoys are set up to look like attractive targets for malicious activity, and are run to **detect, deflect, and analyse** attacks.

###### WHY (control requirement)
Security and control requirement SC-26 requires the organisation to **include components specifically designed to be targeted by malicious attacks** for **detecting, deflecting, and analysing** those attacks. It also requires **supporting isolation measures** so any malicious code that is diverted cannot spread into operational systems. It notes that **Office of the General Counsel (OGC) consultation may be needed**, depending on how the decoys are used.

###### HOW (specific steps/approach)
1. **Define decoy scope and placement**: Choose likely attack entry points (for example, services exposed to the internet and internal services that are commonly used for “lateral movement”). Place decoys in dedicated, separated network areas (separate virtual local area network (VLAN)/subnet/virtual private cloud (VPC)) that are not used for normal business traffic.
2. **Configure decoys to be realistic but non-propagating**: Set up deception services that imitate expected banners and communication behaviour (for example, fake server endpoints for file sharing, remote desktop, secure shell (SSH), web, and database access). Ensure they do not forward requests to production systems and do not expose ways to obtain production credentials or data.
3. **Enforce supporting isolation**: Use fine-grained network separation (“micro-segmentation”) and strict rules for what traffic can enter and leave. Decoys should be able to communicate only with approved destinations (for example, security monitoring and data collection systems, time services, and controlled management or jump hosts). Block all other traffic to production/mission systems by default.
4. **Capture information for detection and analysis**: Set up decoy-specific logging and send it to the enterprise security information and event management (SIEM) system (for example, session start/stop, login attempts, commands, file activity, and any captured items allowed by policy). Make sure alerts include the decoy identity, session identifiers, and the relevant source and destination details.
5. **Run it operationally with runbooks and security planning**: Create and keep up to date decoy runbooks (how to deploy, monitor, escalate issues, and safely shut down or remove decoys). Include decoy use in the system security plan. Assign clear named responsibilities across security operations, infrastructure/network, and application owners.
6. **OGC consultation gate**: Set up a decision process with the Office of the General Counsel (OGC) for decoy types that may involve capturing credentials, simulating user actions, or other legally sensitive collection or processing. Record the outcome and any limits in the decoy design documentation.

###### WHO
- **Cybersecurity / security operations centre (SOC) lead**: owns decoy monitoring, alerting, and analysis processes.
- **Infrastructure/network engineering**: implements network separation, firewall rules, and routing isolation.
- **Application/system owner and developers**: provide realistic details for service emulation and ensure decoys do not act as proxies and cannot pass through to production.
- **Information security governance / risk owner**: ensures decoys are included in the system security plan and keeps supporting evidence.
- **OGC**: is consulted when the organisation’s decision process determines the decoy use is legally sensitive.

###### Acceptance criteria
- Decoy components are deployed and clearly configured as attack targets (for example, reachable decoy endpoints that imitate real services) within separated network zones.
- Supporting isolation is in place: decoys cannot access production/mission systems except to explicitly approved logging/telemetry/management destinations, confirmed by firewall and routing rules.
- Decoy activity produces audit-ready evidence in the SIEM (decoy ID, session context, and relevant interaction details) and supports investigation.
- Decoy runbooks and system security plan entries exist, with named responsibilities and documented operational procedures.
- For decoy types that require it, OGC consultation is completed and documented, including any constraints applied to the decoy design and how telemetry is handled.

###### Actions Required for Compliance

- [ ] Choose decoy targets and set where the decoys will be placed inside separate, dedicated network zones that are not used for normal business traffic.
- [ ] Set up and configure decoy services that imitate real systems attackers would target, while blocking any attempts to use them as a pathway to production systems.
- [ ] Use micro-segmentation and approved “allow-lists” for both outgoing and incoming network traffic, so the decoys can only connect to approved telemetry and management destinations.
- [ ] Connect decoy telemetry to the organisation’s security information and event management (SIEM) system, and set up alerts that are specific to each decoy, including the decoy identifier and the related session details.
- [ ] Create decoy runbooks for deployment, monitoring, escalation, and safe shutdown or decommissioning, and update the system security plan.
- [ ] Set up and run an Office of Government Commerce (OGC) consultation decision process for legally sensitive use of decoys, and record the outcomes.


---

### SC-27 — Platform-independent Applications (Control)

This requirement is about making sure your organisation’s key software can run on more than one type of computer, even if one platform is disrupted, by packaging it in a portable way. Without this, critical services could become unavailable if a particular operating system or hardware type is attacked, fails, or needs replacing, because the software would be difficult to move or rebuild quickly.  

To meet this expectation, the organisation must include containerised, platform-independent applications (for example, microservices managed through Kubernetes) that are provided as signed software packages and include portable deployment instructions. The organisation must also keep an up-to-date list of exactly which applications are included.  

It must document how these applications are handled in its security policy and procedures, describe them in system design and configuration records, include them in the system security plan, and keep audit records showing they are being used and managed as intended.

##### Signed, portable container apps with an auditable platform-independence catalogue

- Category: Software
- Priority: Critical

###### WHAT
Implement and provide evidence that the organisation includes **platform-independent applications** within organisational systems—specifically the platform-independent applications defined by **sc-27_odp** (containerised, platform-independent applications packaged with **signed images** and **portable manifests**).

###### WHY (control requirement)
SC-27 requires that, within organisational systems, the organisation **includes** the platform-independent applications specified in **{{ insert: param, sc-27_odp }}**. The guidance explains that platform-independent applications must be able to run on **multiple platforms** and support **portability and reconstitution** to improve the availability of mission-essential functions.

###### HOW (specific steps/approach)
1. **Create an authoritative catalogue** of in-scope platform-independent applications (service/application name, owning team, supported platforms/architectures, container image repository, signing verification method, and the single agreed source of the portable manifest).
2. **Use signed images** for every in-scope application: build and release processes must produce unchangeable image identifiers (immutable image digests) and require cryptographic signing; deployment must check signatures before releasing.
3. **Standardise portable manifests**: store deployment manifests as **portable artefacts** (for example, Kubernetes resource manifests/Helm/Kustomize outputs) with no assumptions about a specific node or operating system; ensure manifests are generated from the single agreed source (not manually edited inside the environment).
4. **Only deploy approved artefacts**: put in place deployment controls so that only the catalogue-approved image digests and the matching portable manifest versions can be deployed to any environment (development/testing/production/disaster recovery) and any supported platform.
5. **Keep evidence that can be audited**: record and retain evidence that (a) the application is in the catalogue, (b) the deployed image digest is signed and verified, and (c) the running configuration matches the portable manifest version (for example, pipeline logs plus deployment reconciliation records).
6. **Update system documentation and governance**: ensure the system security plan and system design/configuration records reference the catalogue and explain how portability/reconstitution is achieved across platforms; include operational procedures for how the catalogue, signing, and manifest artefacts are managed.

###### WHO (role responsible)
- **Application Owner / Service Owner**: maintains the catalogue entries and supported-platform definitions.
- **DevSecOps / Platform Engineering**: implements signing, manifest generation, and deployment controls.
- **Security Assurance / Compliance**: checks that the evidence is sufficient and that documentation references the control approach.
- **OT/Infrastructure Change Manager (where applicable)**: ensures the same portability artefacts are deployed using OT-appropriate change windows and validation steps.

###### Acceptance criteria
- The organisation has an up-to-date **catalogue** listing all in-scope platform-independent applications defined by **sc-27_odp**, including the agreed image references and portable manifest artefact locations/versions.
- For each in-scope application, deployments across environments/platforms use **signed image digests**, and the deployment process **verifies signatures** before rollout.
- Portable manifests are stored and deployed as **portable artefacts** (with no platform-specific assumptions), and it can be shown that the running state matches the approved manifest version.
- Evidence is retained showing: catalogue membership, signature verification results, and the link between each release’s manifest and its deployment.
- The system security plan and system design/configuration records explicitly reference the catalogue and describe the portability/reconstitution approach.

###### Actions Required for Compliance

- [ ] Define and publish the in-scope, platform-independent application catalogue entries in line with **sc-27_odp**, including: the service name, the supported platforms and computer architectures, the standard (canonical) location for the application images, and the portable source for the deployment manifest.
- [ ] Add cryptographic signing to every in-scope application image, and require the signature to be checked during deployment by using unchangeable image identifiers (immutable image digests).
- [ ] Create a portable “manifest” standard (for example, Kubernetes resource manifests, Helm charts, or Kustomize outputs). Ensure that all manifests are generated from a single, agreed source of truth, rather than being edited directly inside the cluster.
- [ ] Set up deployment gates (admission control and continuous integration/continuous delivery (CI/CD) checks) to stop any deployment if either the software image is not signed or verified, or the manifest version is not the catalogue-approved artefact.
- [ ] Set up a way to capture evidence that can be audited, showing the link from the catalogue entry to the signed image digest, then to the portable manifest version, and finally to the deployed environment or platform. Keep the logs for as long as required by the organisation’s retention rules.
- [ ] Update the system security plan and the system design and configuration records to reference: the catalogue, the approach for enforcing signed files and manifests, and the process for moving and rebuilding the system on the supported platforms.


---

### SC-28 — Protection of Information at Rest (Control)

This expectation is about keeping confidential and secret information safe even when it is stored away, such as on hard drives, in databases, and in backup copies. If this is not done properly, unauthorised people could read sensitive details, or malicious software and insiders could quietly change stored information, including important system settings and authentication details. This could lead to fraud, service disruption, or loss of trust.

To meet this requirement, the organisation must first keep an up-to-date list of exactly which confidential and secret user and system information must be protected while stored. It must then have clear, documented procedures and system designs for protecting that information’s confidentiality and accuracy, and ensure the real systems are set up accordingly. This includes using approved safeguards such as encryption and protections that detect unauthorised or improper changes, and applying the same protections to backups. Where normal protection cannot be achieved, approved alternative measures must be used.

Finally, the organisation must be able to provide evidence that these protections are in place and working. This includes showing that integrity checks and authorised backup restore testing succeed.

##### Encrypt and integrity-protect confidential/secret at-rest data

- Category: Software
- Priority: Critical

###### WHAT must be done
Put in place enforceable protections to keep the organisation-defined **information at rest requiring protection** safe for **confidentiality and integrity**, and make sure these protections apply to **storage media, databases, and backup repositories**.

###### WHY (control requirement)
SC-28 requires the organisation to **protect the specified information at rest** for **confidentiality and integrity**. The guidance explains that “at rest” protection covers data stored on system components (for example, disks and storage devices, and databases). It also covers **system-related information**, such as **authentication information** and **configurations/rule sets** (for example, firewall, intrusion detection system (IDS), and intrusion prevention system (IPS) configurations). It also notes that integrity protection can be achieved using methods such as **write once, read many (WORM)**. Where adequate protection cannot be achieved in another way, organisations may use **frequent scanning** and **secure offline storage**.

###### HOW (specific steps/approach)
1. **Create and maintain an authoritative at-rest scope map** that links the organisation’s defined information categories (confidential and secret user/system information) to the specific storage locations used by this application (for example, database storage, object/file shares, block volumes, configuration repositories, backup sets, snapshots, and replication targets).
2. **Define an approved “At-Rest Confidentiality & Integrity Standard”** that sets out, for each in-scope information category and storage type, the required protection(s):
   - Confidentiality: approved encryption for data while stored (for example, platform-native encryption for volumes/objects and database transparent data encryption (TDE) or an equivalent).
   - Integrity: an enforceable integrity protection method suitable for the data type (for example, **WORM/immutability** for backups and configuration artefacts where feasible; otherwise integrity checking such as verification/signing and scheduled integrity checks).
   - Key management: use enterprise-approved key management (key management service (KMS)/hardware security module (HSM)/Key Vault) with documented key access rules.
3. **Set up the application and platform so encryption for stored data is used by default** for all in-scope storage locations across environments (production, test, development, and disaster recovery as applicable), including:
   - Database encryption (for example, TDE or an equivalent) and encrypted storage for logs/temp where supported.
   - Encrypted storage for file/object/block storage used by the application.
   - Encrypted backup repositories and encrypted backup data streams.
4. **Apply integrity protection to the same in-scope datasets**:
   - Turn on **immutability/WORM** for backups and any configuration/rule-set repositories that must resist unauthorised changes.
   - Where WORM is not practical, implement **integrity verification** (for example, cryptographic signing of important configuration artefacts and scheduled hash/signature checks). Make sure any failure triggers alerts and corrective action.
5. **Strengthen key use and access paths**:
   - Make sure only authorised roles/services can decrypt (least privilege; no shared accounts).
   - Restrict access to key material and ensure it is auditable using enterprise key management logs.
6. **Create audit-ready proof**:
   - Produce reports showing the encryption status for each storage type.
   - Provide proof of integrity controls (for example, evidence of immutability settings; results from integrity check jobs and the history of alerts).
   - Show backup restore testing from protected backups, including confirmation that restored data still meets integrity expectations.

###### WHO (role responsible)
- **Application Owner / Data Protection Engineering Lead**: owns the at-rest scope map and standard.
- **Infrastructure/Cloud Platform Engineer**: implements encryption and immutability settings.
- **Database Administrator (DBA)**: implements and provides evidence for database encryption and integrity protections.
- **Security Engineer (governance, risk and compliance (GRC)/Compliance)**: checks that the standard and evidence meet SC-28 requirements and that any compensating measures are approved where needed.

###### Acceptance criteria
- A current at-rest scope map exists and covers **confidential and secret user/system information** for this application across **storage media, databases, and backup repositories**.
- Encryption for stored data is enabled and evidenced for all mapped storage locations.
- Integrity protection is implemented and evidenced for the mapped datasets (immutability/WORM for backups/configuration where feasible, or integrity verification/signing with alerting where not).
- Key management is enforced with auditable access controls; evidence shows only authorised encryption/decryption use.
- Backup immutability (or an equivalent integrity protection) is evidenced, and at least one recent restore test confirms that protected backups can be restored and integrity expectations are met.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, official record showing which confidential or secret information stored while not in use is held in this application’s storage systems, databases, and backup locations.
- [ ] Publish an approved “At-Rest Confidentiality and Integrity Standard” that sets out the encryption and data-integrity controls required for each storage type and each data category.
- [ ] Turn on encryption for data stored on disk by default for every storage location you connect to, including encrypted database storage (database transparent data encryption (TDE) or an equivalent), encrypted volumes/objects/files, and encrypted backups and snapshots.
- [ ] Enable integrity protection for mapped datasets. Where feasible, use write-once-read-many (WORM) storage and immutability for backups and configuration artefacts. Otherwise, use digital signing and perform scheduled integrity checks, with alerts if any issues are detected.
- [ ] Enforce enterprise key management controls: allow decryption access only on a least-privilege basis, restrict key use to authorised roles and services, and keep audit logs of all key access.
- [ ] Collect audit evidence showing the encryption status, whether the system is configured to be tamper-resistant (immutability and integrity), and the results of integrity checks and backup restore testing.


---

#### SC-28.1 — Cryptographic Protection (Enhancement)

This requirement is about protecting sensitive information so that, even if someone gains access to your on-premises storage, they still cannot read it or change it without being noticed. It protects Confidential and Secret information stored on your own servers, storage systems, and backup locations, including databases, file shares, backups, and records. Without this protection, unauthorised people could copy confidential files, take data from storage, or alter records and backups in ways that may not be detected until it is too late.

To meet this expectation, the organisation must encrypt all Confidential and Secret information while it is stored (“at rest”) across the relevant on-premises storage media and system components, using encryption strength appropriate to the sensitivity of the information. The organisation must also ensure the encryption protects against unauthorised changes. Finally, the organisation must keep clear documentation showing what encryption is used and how it is configured for each relevant storage and backup location.

##### Encrypt Confidential/Secret data at rest on on-prem storage

- Category: Software
- Priority: Critical

###### WHAT
Put cryptographic protection in place for **Confidential and Secret information when it is stored (at rest)** on **on-premises system components or media** (servers, storage arrays, and backup repositories). This must protect against **unauthorised disclosure** and **unauthorised modification**.

###### WHY (control requirement)
NIST SP 800-53 **SC-28(1) Cryptographic Protection (enhancement)** requires using cryptographic methods to stop **unauthorised disclosure and modification** of the specified information **at rest** on the specified system components/media. The guidance also requires choosing protection strength that matches the information’s security category/classification.

###### HOW (specific approach)
1. **Create and keep an up-to-date inventory of where data is stored** for the application’s **Confidential and Secret** information at rest. For each storage location, record the classification (for example: database data files, file-share exports, storage array volumes/LUNs, backup repository volumes).
2. **Turn on encryption at the storage layer for every identified location** (no exceptions) using cryptographic methods approved by the organisation:
   - Use **storage/volume encryption** for storage arrays and server volumes that hold the data.
   - Use **backup repository encryption** so backups kept on-premises remain protected.
3. **Use central key management** (a key management system backed by a hardware security module, or **hardware security module (HSM)-backed key management service (KMS)/enterprise key manager**) with:
   - Strong **role-based access control (RBAC)** for key administration and for access to decrypt data.
   - Records of key use and administrative actions (audited).
   - Automated key lifecycle controls (rotation/revocation) aligned to classification (for example, Confidential versus Secret).
4. **Provide evidence that data integrity is protected (tamper resistance)**:
   - Prefer encryption features that provide **authenticated encryption** or integrity checks at the storage layer.
   - If storage encryption alone does not provide integrity protection, add compensating integrity controls in the storage/backup process (for example, integrity checks during backup/restore and detection of tampering). Also document how failures are reported.
5. **Document the cryptographic methods and settings** for each storage/media type and classification:
   - Encryption method/profile, how keys are mapped to Confidential versus Secret, and where encryption is applied.
   - Evidence artefacts: storage configuration exports and key-management audit logs.
6. **Test in practical ways**:
   - Show that copying encrypted volumes/snapshots without authorisation/keys results in unreadable data.
   - Show that tampering or corruption of backup files is detected during restore/verification (and that logs/alerts record the event).

###### WHO
- **Infrastructure/Storage Engineering Lead**: enables and standardises storage/volume and backup repository encryption.
- **Security Architect / Crypto Governance Lead**: approves cryptographic methods and key policies by classification.
- **Key Management Administrator**: sets up and runs central key management (RBAC, rotation, audit).
- **Application Owner / Data Steward**: confirms the Confidential/Secret data-location inventory is complete and accurate.

###### Acceptance criteria
- **100%** of inventoried **Confidential and Secret** information-at-rest locations on **on-premises storage media/system components** are encrypted (storage/volume and backup repository as applicable), with **no undocumented exceptions**.
- Central key management is used for encryption keys, with auditable key use and key policies mapped by classification.
- Evidence exists that unauthorised access cannot disclose data (for example, test results showing encrypted files are unreadable without authorisation/keys).
- Evidence exists that unauthorised modification is detected or prevented (for example, integrity-capable encryption, or documented integrity verification during backup/restore with logged detection).
- Documentation and audit evidence are produced for each storage location: encryption method/profile, key policy mapping, and configuration exports.

###### Actions Required for Compliance

- [ ] Create and get approval for a complete list of all on-premises storage locations that hold Confidential and Secret data while it is stored (including backups). Map each location to **SC-28.01 ODP.01** and **SC-28.01 ODP.02**.
- [ ] Enable enterprise-approved encryption for storage volumes on every inventoried server and for every storage-array logical unit number (LUN) that hosts the identified data.
- [ ] Turn on encryption for storing backups in the backup repository, and make sure the backup software is configured to write backups to encrypted storage locations.
- [ ] Set up central key management using a hardware security module (HSM)-backed key management service (KMS) or enterprise key manager, with role-based access control (RBAC), a record of all key use for audit purposes, and key policies based on data classification (Confidential versus Secret).
- [ ] Choose encryption options that include integrity and authentication where available. If they are not available, add and document integrity checks during backup and restore to detect any tampering.
- [ ] For each encrypted location, collect and store audit-ready evidence, including storage configuration exports and key-management audit logs.
- [ ] Run validation tests to show that the data cannot be read without authorisation or keys, and to confirm that any tampering or corruption is detected during restore and verification.


---

#### SC-28.2 — Offline Storage (Enhancement)

This requirement is about taking the organisation’s most sensitive information (the **Confidential** and **Secret** data sets and their associated metadata) out of systems that can be reached over the network, and keeping it offline in a secure location.

The real-world risk it addresses is that, if sensitive files stay online, they could be accessed by someone who should not have access—whether due to mistakes, stolen login details, or other unauthorised routes.

To meet this expectation, the organisation must:
- Clearly identify exactly which **Confidential** and **Secret** data sets and metadata are to be moved.
- Remove them from all online storage locations.
- Be able to provide evidence that they are no longer present online.

It must then:
- Store them offline in designated secure locations that are protected against unauthorised access.
- Document where they are stored and how they are moved.
- Keep records showing when the move and offline storage actions took place.

The organisation should also have clear procedures for this approach, and include it in its security planning, system design, configuration documentation, and any related encryption settings if used. Named roles must be responsible for carrying out these actions.

##### Offline secure vault for Confidential/Secret datasets removal

- Category: Manual
- Priority: Critical

###### WHAT
Remove the organisation-defined **information** (parameter **sc-28.02_odp**: *Confidential and Secret data sets and associated metadata*) from **all online storage** locations and store it **offline** in a **secure location**.

###### WHY (control requirement)
SC-28(2) (Enhancement) requires that the specified information be **removed from online storage** and **stored offline in a secure location**. The guidance explains this reduces the risk of unauthorised access through the network.

###### HOW (specific approach)
Set up an auditable “offline vault” process with controlled handling of the storage media and proof that the information was removed:
1. **Authoritative scope definition**: Keep a version-controlled list of all Confidential/Secret data sets and associated metadata. Include every online system/location where each item currently exists (for example: file shares, collaboration sites, object storage, database structures, backup catalogues).
2. **Export to a controlled staging area with integrity checks**: For each data set, copy it from the online source to a controlled staging area. Calculate integrity values (for example, SHA-256) and record the data set identifiers, sizes, and hashes.
3. **Offline secure storage**: Move the exported data sets to **offline, not connected to any network** encrypted media/appliances (for example, encrypted removable media kept in a locked vault). Apply physical access controls and keep operator handling/custody records.
4. **Remove from online storage (including metadata and indexes)**: Delete the data sets and associated metadata from all online locations. This includes removing access (for example, removing shares, links, and service accounts) and ensuring any search indexes/metadata references are removed in line with the organisation’s retention and deletion rules.
5. **Check and prove online removal (evidence)**: Carry out targeted searches/scans across the online storage platforms and backup catalogues to confirm the data sets are no longer present. Keep evidence (scan reports, query results, and a reconciliation of hashes/inventory) showing the only remaining copies are in the offline vault.
6. **Record and approve**: Document the offline vault location identifiers, how encryption keys are handled for offline media, the export/removal procedure, and the named roles responsible for custody and approval. Store all evidence in the organisation’s compliance repository.

###### WHO
- **Data Owner / Information Security Owner**: approves the data set scope and confirms the deletion criteria.
- **System Administrator / Storage Engineer**: carries out the export, deletion, and verification steps.
- **Privileged Operator / Vault Custodian**: manages offline media custody and vault access records.
- **Compliance/Assurance**: reviews the evidence pack to ensure it is ready for audit.

###### Acceptance criteria
- A complete, approved inventory exists for all items in **sc-28.02_odp**, and all online locations are identified.
- For each data set, evidence shows: (a) integrity values from the export were recorded, (b) the encrypted offline storage location was recorded, (c) deletion was completed across all online storage locations and associated metadata references, and (d) verification searches/scans show the data sets are not present online.
- Offline vault media is stored in a **secure location** with custody/access records and documented encryption/key handling for offline protection while stored.
- An audit evidence pack is kept showing who carried out the actions, when they were done, and how the verification was completed.

###### Actions Required for Compliance

- [ ] Create and get approval for a complete list (inventory) of all confidential and secret datasets and their related information (metadata). This list must be matched to every online storage location (per security control SC-28.02_odp).
- [ ] For each dataset in scope, copy it from online storage to a controlled staging area, and record its integrity hash and dataset identifier.
- [ ] Store the exported datasets on offline, encrypted, non-network-connected storage media or an appliance kept in a physically secure vault, with custody and access records.
- [ ] Remove the datasets and their associated metadata from all online storage locations, and cancel any remaining ways to access them (shared links, shared folders, and service accounts).
- [ ] Carry out focused searches of online storage and backup catalogues to confirm the datasets are no longer available online, and keep a record of the results.
- [ ] Document where offline data is stored, how it is encrypted and how encryption keys are handled for offline data protection while it is stored, and provide a step-by-step process to remove it, including the named responsible roles.


---

#### SC-28.3 — Cryptographic Keys (Enhancement)

This requirement is about keeping the secret keys that protect your systems locked away in a special, tamper-resistant place, so they can’t be stolen or used in the wrong way. Without this, an attacker who gets hold of the keys could pretend to be your services, view or change protected information, or take control of systems—even if other safeguards are in place.

To meet this expectation, the organisation must store cryptographic keys using a hardware-protected key store (for example, a Trusted Platform Module), so the keys are protected while they are stored on the device. Access must be limited to the system owner and named key custodians, using the minimum permissions needed. Unauthorised staff must be prevented from accessing the keys.

The organisation must also securely configure the hardware key store, keep evidence of how it is set up and how the protection works, clearly document responsibilities and procedures, include this approach in its security planning, and keep records showing who accessed or used the protected keys.

##### TPM-backed hardware key store with custodian-only access

- Category: Software
- Priority: Critical

###### WHAT
Set up protected storage for cryptographic keys using a hardware-protected key store (backed by a trusted platform module (TPM)), so the keys are stored and used only within the hardware-protected boundary.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) security control SC-28(3) enhancement requires: **“Provide protected storage for cryptographic keys {{ insert: param, sc-28.03_odp.01 }}.”** The organisation-defined parameter specifies **“hardware-protected key store”**. The guidance explicitly cites TPM as an example of a hardware-protected data store.

###### HOW (specific approach)
1. **Use standard TPM-backed key storage for the application’s key material**: create and store the application’s cryptographic keys using operating system or platform cryptographic services that support TPM-backed key storage (or an equivalent hardware-based, root-of-trust key storage approach). Make sure the application never handles raw key material outside the hardware-protected boundary.
2. **Link key use to a trusted state of the platform**: enable measured or attested boot (where available) and set key rules so key operations are allowed only when the platform is in an approved, trusted state (for example, secure boot enabled and expected measurements present).
3. **Apply least-privilege access for key operations**: limit who can request key operations to the **system owner and key custodians** only. Apply this using identity- and process-based authorisation (for example, custodian-controlled service accounts, approvals that happen only when needed, and separation of duties). Ensure unauthorised staff cannot access key-store functions.
4. **Securely configure and strengthen the TPM**: set TPM ownership and hierarchy permissions correctly, turn off any unnecessary interfaces, and configure key-store rules so key creation and use require authorisation and take advantage of the TPM’s tamper-evident protections.
5. **Create and keep audit evidence**: collect and retain audit records for key-store activity (key creation, authorisation changes, key use attempts/successes/failures, and TPM-related events) and send them to the enterprise security information and event management (SIEM) system for monitoring and audit readiness.
6. **Document the mechanism and responsibilities**: keep evidence of the system design and configuration showing the hardware-protected key store approach, TPM configuration settings, key policy settings, and the defined roles and responsibilities for the system owner and key custodians.

###### WHO
- **System Owner / Application Owner**: responsible for ensuring the application uses TPM-backed key storage and that access is limited to authorised roles.
- **Key Custodians (IT/Security operations)**: responsible for key lifecycle activities (creation, rotation, recovery) using approved processes.
- **Platform/Infrastructure Engineers**: responsible for enabling the TPM, strengthening it, and configuring it.
- **Security Engineering / Identity and Access Management (IAM) Team**: responsible for defining roles, enforcing least-privilege authorisation, and integrating audit logs.

###### Acceptance criteria
- The cryptographic keys used by the application are stored in a **hardware-protected key store** (TPM-backed), and raw key material cannot be retrieved through normal operating system or application processes.
- Only the **system owner and designated key custodians** can carry out the key operations needed by the application (creation/use/rotation/recovery) through enforced least-privilege authorisation.
- The TPM is configured with secure ownership and hierarchy permissions, and key policies that use tamper-evident protections.
- Measured or attested boot (where supported) is enabled, and key use is restricted to an approved platform state.
- Audit records for key-store activity are generated, sent to the SIEM, and kept in line with the organisation’s logging and retention requirements.
- Evidence exists for: system design, TPM/key-store configuration, role mappings, and audit log retention and coverage.

###### Actions Required for Compliance

- [ ] Choose and standardise the trusted platform module (TPM)-backed method the application platform supports for storing encryption keys (using the operating system or platform cryptography application programming interfaces (APIs), or an equivalent option).
- [ ] Set up key creation and storage so cryptographic keys are generated and kept inside the trusted hardware-protected key storage, backed by the Trusted Platform Module (TPM).
- [ ] Define and enforce identity and access management (IAM) roles and workflows so the system owner and key custodians can approve key actions, using the principle of least privilege and separating responsibilities.
- [ ] Set up trusted platform module (TPM) hardening and key rules, including who can control it (ownership and hierarchy permissions), what approvals are required before changes (authorisation requirements), and turning off any interfaces that are not needed.
- [ ] Where available, use measured and verified boot, and use Trusted Platform Module (TPM) key policies to ensure keys are only used on the approved device state.
- [ ] Turn on audit logging for key store and Trusted Platform Module (TPM) events, send the logs to the security information and event management (SIEM) system, and check that audit logs are kept long enough to cover key creation, changes, and use attempts.
- [ ] Produce audit-ready documentation, including: evidence of system design, exports of the Trusted Platform Module (TPM) and key store configuration, mappings of user roles, and procedures that describe responsibilities for key custodians.


---

### SC-29 — Heterogeneity (Control)

This requirement is about not relying on just one type of technology. Across the organisation’s network boundary, how people are identified and allowed access, the computers staff use, the servers that run services, the websites and applications, the databases, and the tools that collect and review security records, the organisation should use a deliberately mixed set of technologies rather than depending on a single one.

This matters because if one technology has a hidden weakness, a supplier issue, or a widespread flaw, attackers could potentially use it to affect many parts of the system at the same time. Using a mix of technologies reduces the risk that “one mistake breaks everything” and makes successful attacks harder.

To meet this expectation, the organisation must:
- plan and document how different technologies will be used for each component
- keep an up-to-date list of what is actually in place
- ensure procurement and design records support the decision to use a deliberate mix
- align system settings to the selected technologies
- assign named people to implement and maintain this approach

##### Deliberate technology diversity map and enforcement by component

- Category: Manual
- Priority: High

###### WHAT
Set up and keep a deliberately varied set of information technologies across the system parts defined for **SC-29 (system components)**: **network edge, identity and access management, endpoint operating systems, server operating systems, web and application services, database platforms, security monitoring/logging**.

###### WHY (control requirement)
SC-29 requires using a **varied set of information technologies** for the system parts listed above. The goal is to reduce “single weakness” failures (including those caused by supply chain attacks) and make it harder for an attacker to succeed by ensuring that if one technology is compromised, it is less likely that the attacker can also compromise the other parts.

###### HOW (specific steps/approach)
1. **Create an authoritative “technology diversity map”** (configuration management register) that, for each of the seven component areas, records the **approved technologies that are actually in use** (supplier/product and enough detail to tell platforms apart, such as version/build where relevant), and the **environment scope** (live/production, test, disaster recovery).
2. **Set the target diversity rule for each component** in the system design and security documentation: for each component area, state the **minimum diversity expectation** (for example, two different technology platforms) and the **approved exception criteria** (only where diversity is limited by the environment or by supplier support).
3. **Apply diversity where the application connects to other systems**, so the application’s most important functions do not depend on one single technology end-to-end (for example, separate/independent ways to send logs into the security information and event management (SIEM) system; different reverse-proxy/application runtime options where feasible; multiple identity and access management (IAM) integration approaches such as federation/single sign-on (SSO) broker patterns).
4. **Prevent “no single-platform drift” through deployment control**: make sure deployment pipelines and change management require choosing from the approved technology list for each component area, and stop (or require approval for) changes that would reduce diversity below the agreed rule.
5. **Align settings to the chosen technologies** by keeping baseline configuration standards for each technology platform, so diversity is not just “on paper”.
6. **Record why the technologies were chosen** in procurement and architecture records, showing the decision is intentional and aimed at reducing “single weakness” failure risk.
7. **Keep evidence**: update the diversity map for every release/change, and keep audit evidence showing which deployed components match the approved diversity rule.

###### WHO (role responsible)
- **System Owner / Application Owner**: accountable for meeting SC-29 for the application system.
- **Enterprise Architecture / Security Architecture**: sets the target diversity rules and exception criteria.
- **Infrastructure/Platform Engineering**: implements and maintains the varied technology deployments and baseline configurations.
- **Identity and Access Management (IAM) Team**: ensures identity and access connections meet the diversity rule.
- **Security Operations Centre (SOC)/Security Information and Event Management (SIEM) Engineering**: ensures monitoring/logging diversity and independent log intake routes.
- **Change Management / Release Manager**: enforces governance checkpoints to prevent drift.

###### Acceptance criteria (verifiable)
- A current **technology diversity map** exists and covers all seven component areas for the application system, listing the **deployed technologies** with enough detail to distinguish platforms.
- For each component area, the deployed technologies meet the **defined diversity rule** (or there is a documented, approved exception with compensating controls).
- Deployment and change records show that governance **prevents reducing diversity** without approval.
- Configuration baselines and operational settings match the selected technologies (no evidence of “paper diversity”).
- Procurement/architecture documentation includes the **reasoning** for choosing varied technologies to reduce “single weakness” failure risk.

###### Actions Required for Compliance

- [ ] Create and keep up to date an official technology diversity map that covers every component of the SC-29 system and all relevant environments.
- [ ] Set clear expectations for diversity targets for each component area in system design and security documentation, including specific criteria for when exceptions are allowed.
- [ ] Where possible, choose and deploy at least two different technology platforms for each component area. If this is not feasible, document the approved exceptions and the compensating controls.
- [ ] Add governance checks (“gates”) to the change and release process so that deployments cannot reduce diversity below the approved rule unless approval is granted.
- [ ] Publish and use standard configuration settings for each selected technology platform to prevent “paper diversity”
- [ ] Record the procurement and architecture reasoning showing that diversity was deliberately chosen to reduce the risk of shared (common-mode) failures and failures caused by the supply chain.
- [ ] Review and update the diversity map for every major release. Keep audit records showing which deployed components match the approved diversity rule.


---

#### SC-29.1 — Virtualization Techniques (Enhancement)

This requirement is about using approved virtual environments to run different types of software safely, and updating them on a regular schedule. It addresses the risk that outdated or poorly managed software can make it easier for attackers to gain access, and that changing real systems too frequently can lead to mistakes that leave weaknesses behind.

To meet this expectation, the organisation must run a variety of operating systems and applications inside approved virtual environments, and update those virtual operating systems and applications at least once every quarter. These updates must be carried out through the organisation’s formal change approval process. The organisation must keep clear records showing what was changed, when it was done, and what the system looked like before and after.

The organisation must also keep an up-to-date list of what is running virtually, document how the virtual approach is used in its system design and security planning, name specific people responsible for implementing it, and retain audit-ready evidence that quarterly updates were actually completed.

##### Quarterly VM/App diversity refresh via approved golden images

- Category: Software
- Priority: Critical

###### WHAT
Deploy operating systems and applications using **approved virtualisation methods** into **separate, contained virtual environments**, and refresh that **range of options** on a **quarterly** basis.

###### WHY (control requirement)
SC-29(1) Enhancement requires the organisation to **use virtualisation methods** to support deploying a **variety of operating systems and applications** that are **updated at a defined frequency**. The organisation-defined parameter **sc-29.01_odp (frequency)** is **quarterly**. Updating virtual systems (rather than changing real systems) helps make it harder for attackers to succeed and reduces the effort needed to manage configurations.

###### HOW (specific steps/approach)
1. **Set the approved virtualisation standard** for the environment(s) in scope (for example: approved hypervisors or managed virtual machine platforms, isolation approach, network separation, logging and monitoring requirements, and a security hardening baseline). Publish this as a controlled configuration baseline.
2. **Create and maintain a curated diversity catalogue** of virtual operating system and application combinations (for example: operating system families and versions, and application versions) that the organisation will deploy. Ensure each combination is based on a **template or “golden image”** that follows a defined lineage.
3. **Set up golden-image/template build processes** that rebuild virtual operating system images and application images on a quarterly schedule, including: bringing in vendor security updates, bringing in application updates, scanning for malware, checking configuration correctness, and producing build information (image version, patch level, application version).
4. **Apply deployment safeguards** so that only approved templates and isolation profiles can be used (for example: checks in infrastructure-as-code policies, approval controls, or platform-level template allow-lists).
5. **Carry out quarterly refreshes through formal change control**: for each refresh, raise an approved change record that clearly states “virtual operating system and application update”, links to the pipeline run/build identifiers, and records the configuration state before and after the change.
6. **Maintain auditable records of what is deployed and how it is configured**: automatically update a configuration management database (CMDB) or report listing each virtual instance (or template use), its operating system and application versions, template lineage, and isolation profile; keep pipeline logs and deployment confirmations for audit purposes.
7. **Document the virtualisation approach** in the system design and architecture, and ensure it is reflected in the system security plan, including how diversity and isolation are achieved.

###### WHO
- **Infrastructure/Cloud Platform Engineering Lead**: owns the approved virtualisation standard and the golden-image build process.
- **Application Owner / Service Owner**: checks that application updates are correct and confirms they fit the planned diverse combinations.
- **Information Security / Security Architect**: approves the isolation approach and the security validation checks.
- **Change Manager (or Change Advisory Board)**: ensures quarterly virtual refreshes are authorised and properly recorded.

###### Acceptance criteria
- A controlled, approved virtualisation standard exists and is used to build and deploy virtual operating system and application templates.
- A documented diversity catalogue exists and links to maintained golden images/templates.
- Quarterly (at least once per quarter) virtual operating system and application refreshes are completed through the formal change process, with evidence linking change records to pipeline run/build identifiers.
- For each refresh, auditable records exist showing the configuration before and after (operating system and application versions and template lineage), and an up-to-date inventory of virtualised operating systems and applications.
- The system design and architecture, and the system security plan, explicitly describe the virtualisation approach, including the isolation and diversity mechanisms.

###### Actions Required for Compliance

- [ ] Publish an approved virtualisation standard as a controlled configuration baseline, covering the supported platforms, the isolation model, the security hardening baseline, and the logging requirements.
- [ ] Create and keep up to date a catalogue of the required virtual operating system and application “stacks”, mapped to the approved golden-image and template lineages.
- [ ] Set up a quarterly “golden image” and template build process that rebuilds virtual operating system and application images, including bringing in patches and updates and running security checks to confirm they are safe.
- [ ] Set up deployment guardrails so only approved deployment templates and approved isolation settings can be created (template allow-lists and policy-as-code).
- [ ] Create and get approval for a formal change record for each quarterly virtual refresh. Link it to the relevant pipeline run and build identifiers, and record the “before” and “after” state.
- [ ] Automate updates to the configuration management database (CMDB) and inventory for every virtual machine instance or template that is created, including the operating system and application versions, the template’s origin and history, and the isolation settings. Keep the deployment and pipeline logs so the activity can be audited.
- [ ] Update the system design and architecture and the system security plan to describe the virtualisation approach, the use of diversity, and the isolation controls.


---

### SC-30 — Concealment and Misdirection (Control)

This requirement is designed to make it harder for attackers to identify your real business targets and the routes they could use to reach them. It does this by deliberately disguising and rearranging what attackers see online. Without these measures, criminals could test your internet-facing websites, public-facing application interfaces, and critical operational technology gateway servers, work out how they are set up, and then carry out attacks that are more likely to succeed.

To meet this expectation, the organisation must maintain a documented and approved set of disguise methods for these systems. This includes hiding underlying system details, using fake targets and fake services, changing which network ports are used, and regularly updating relevant configuration details. These actions must run continuously. Decoy and port changes must be carried out at least once every seven days, supported by clear written procedures, named staff responsible for the work, and working mechanisms to ensure the changes can be made.

The organisation must also keep records of what was changed and when. The approach must be included in its security planning documents, so it can be demonstrated that the weekly activity actually took place.

##### Weekly moving-target ingress with decoys and port/service shuffling

- Category: Software
- Priority: Critical

###### WHAT
Implement concealment and misdirection for the defined systems by continuously using a changing (moving-target) entry layer that (1) uses **virtualisation** to run real production and decoy instances, (2) offers **honeypots/decoy services** alongside real services, and (3) uses **randomised service port selection** and **periodic configuration shuffling** at a **minimum weekly (every 7 days)** schedule.

###### WHY (control requirement)
NIST SP 800-53 **SC-30** requires using the organisation-defined concealment and misdirection techniques (**virtualisation, honeypots, decoy services, randomised service ports, periodic configuration shuffling**) for the organisation-defined systems (**internet-facing web applications, public-facing APIs, and critical OT gateway servers**) during the organisation-defined time periods (**continuously, with decoy and port randomisation every 7 days**) to confuse and mislead attackers.

###### HOW (specific steps/approach)
1. **Create an approved “deception techniques” design** for the covered systems that links each technique to clear implementation details (for example: which components are virtualised, which endpoints are decoys, how port mappings are randomised, and which configuration elements are shuffled).
2. **Deploy a programmable entry/gateway** (for example: an API gateway or reverse proxy with programmable routing, a service-mesh entry component, or a load balancer with automation features) that can dynamically redirect external ports/endpoints to internal real or decoy service instances without changing the internal application interfaces.
3. **Use virtualisation to disguise**: run real and decoy services on virtualised instances (virtual machines/containers) with consistent, controlled external “fingerprints” (for example: how Transport Layer Security (TLS) is handled, error-handling patterns, and banner/profile behaviour) so that details of the underlying host are hidden.
4. **Implement decoy services/honeypots**: create decoy endpoints that resemble what is expected (for example: paths, response timing, and controlled error/authentication behaviour) but do not allow access to real data or privileged functions.
5. **Randomise exposed ports and shuffle configuration**: keep an approved set of external port mappings and, every **7 days**, change which ports/endpoints send traffic to real versus decoy instances. For each change, shuffle the approved configuration bindings (for example: routing rules, decoy selection logic, web application firewall (WAF) policy bindings where applicable, and gateway routing profiles) using **configuration-as-code**.
6. **Run continuously with an auditable weekly schedule**: automate the rotation process to run on a strict weekly cadence (minimum every 7 days), including pre-change checks (smoke tests), controlled rollout, and post-change confirmation.
7. **Record evidence for auditability**: log the mapping set identifier, affected systems/endpoints, the technique parameters used, start/end times, and the operator/automation identity; keep evidence showing the weekly execution took place.

###### WHO
- **Security Architect / Deception Engineering Lead**: owns the approved design and the mapping from techniques to implementation.
- **Platform/Network Engineering Lead**: implements the programmable entry/gateway and routing automation.
- **Application Owners (web/API/OT gateway)**: confirm functional compatibility and approve the boundaries for decoy behaviour.
- **Security Operations Centre (SOC)/Monitoring Lead**: ensures monitoring data and alerting are in place to detect and verify the effectiveness of the deception.

###### Acceptance criteria
- For each covered system (internet-facing web applications, public APIs, critical OT gateway servers), the organisation-defined techniques are implemented: virtualised real plus decoy instances, decoy endpoints, randomised external port/service exposure, and periodic configuration shuffling.
- A rotation happens **at least once every 7 days** and continues without interruption, with evidence kept for each rotation.
- Weekly rotation evidence includes: mapping set ID, affected endpoints/ports, timestamps, automation/operator identity, and verification results.
- Decoy services do not provide real data or privileged actions; they return controlled responses that match the approved deception design.
- Changes are deployed using approved change/configuration management with configuration-as-code and rollback capability.

###### Actions Required for Compliance

- [ ] Define and get approval for the deception design approach for each covered system (web applications, public application programming interfaces (APIs), and operational technology (OT) gateway servers).
- [ ] Set up a programmable entry gateway that can automatically route traffic from the outside to the correct real or decoy internal systems.
- [ ] Set up virtual real and decoy service instances with controlled external identifiers (fingerprints) and clear separation from non-production data.
- [ ] Set up decoy endpoints and honeypots that look and behave like the expected systems, but do not provide access to real data or privileged functions.
- [ ] Set up an approved pool of network port mappings, then change the mappings at least weekly (every 7 days or less) and shuffle the configuration each time using configuration-as-code.
- [ ] Automate the weekly rotation process, including checks before and after, the ability to undo changes if needed, and storing proof of what happened (mapping set ID, time and date, and who/what made the change).
- [ ] Confirm and record continuous operation by creating audit-ready evidence for every weekly rotation cycle.


---

#### SC-30.2 — Randomness (Enhancement)

This expectation is about making routine security actions harder for attackers to predict, so they cannot easily plan when and how to strike. If the organisation always carries out the same checks at the same times, always uses the same service accounts and administrative roles, or replaces approved tools or suppliers with unapproved ones, an attacker can learn the pattern and choose the timing of their attempts to cause the most disruption.

To meet this expectation, the organisation must introduce uncertainty by varying routine security activities by time of day, rotating which service accounts and administrative roles are used for those activities, and using only pre-approved alternative tools and suppliers. It must document these “randomness” methods in its security policy and procedures, ensure they are reflected in system design and architecture, apply them through system configuration, include them in the system security plan, and keep audit records and other relevant documentation so authorised people can check that the methods were actually carried out.

##### Policy-driven randomness for routine security tasks

- Category: Software
- Priority: High

###### WHAT must be done
Implement **approved randomness techniques** to introduce uncertainty into the organisation’s operations and assets by **varying routine security tasks depending on the time of day**, and (where relevant) **rotating which service accounts and administrator roles carry out those tasks**. Any alternate tools or suppliers used must be **pre-approved**.

###### WHY (control requirement)
NIST SP 800-53 **SC-30(2) Randomness (enhancement)** requires using the organisation-defined **sc-30.02_odp techniques** to introduce randomness into organisational operations and assets. The guidance expects “misdirection” through uncertainty (for example, using different times of day, rotating roles/service accounts, and using different information technologies or suppliers).

###### HOW (specific steps/approach)
1. **Create and maintain an approved, system-specific register of randomness techniques** aligned to **sc-30.02_odp (techniques)**, explicitly covering:
   - time-of-day variation for defined “routine security tasks” (including permitted time windows and exclusions),
   - rotation of **service accounts and administrator roles** used to carry out those tasks (using an approved rotation set),
   - use of only **approved alternate tools and suppliers** (those already approved by the organisation).
2. **Set up a central, policy-controlled scheduler/orchestrator** for routine security tasks so the timing does not depend on operator judgement. Configure it to:
   - choose an execution pattern (for example, morning/afternoon/evening) and apply controlled variation (“jitter”) within approved windows,
   - block scheduling during excluded periods (for example, change freeze windows, and peak business hours if required by the organisation),
   - start identity and role rotation workflows so tasks run under the approved workload identities/service principals and the approved administrator role set.
3. **Enforce approved tool and supplier use at the time of execution** by linking each task pattern to an approved set of tools and approved integration endpoints (for example, approved scanning engines, approved security information and event management (SIEM) enrichment services, and approved supplier application programming interfaces (APIs)). Reject or alert on any selection that is not approved.
4. **Create audit evidence** for each randomness decision and execution:
   - record the actual start and stop times, the selected time pattern/variation parameters, the selected identity/service account/administrator role, and the selected approved tool/supplier identifier,
   - keep the logs in the organisation’s central logging system and security information and event management (SIEM) environment, and ensure they can be reviewed by authorised staff.
5. **Update the system security plan and runbooks** to reference the randomness techniques register and the scheduler/orchestrator configuration (including version/commit identifiers) so auditors can trace “what was approved” to “what was run”.

###### WHO (role responsible)
- **System Owner / Application Owner**: responsible for defining routine security tasks and ensuring the randomness register is specific to the system.
- **Security Engineering / Governance, Risk and Compliance (GRC)**: owns the governance of the randomness techniques register and ensures alignment to **sc-30.02_odp**.
- **Platform/DevOps Engineering (or operational technology (OT) Operations Engineering where relevant)**: implements and runs the scheduler/orchestrator configuration and the identity/tool bindings.
- **Identity and Access Management (IAM) / Privileged Access Management (PAM) team**: provides the approved rotation set of service accounts/administrator roles and ensures tasks run with the minimum required permissions.

###### Acceptance criteria
- An approved, system-specific **randomness techniques register** exists and clearly covers time-of-day variation, service/administrator rotation (where applicable), and approved alternate tools/suppliers, matching **sc-30.02_odp**.
- Routine security tasks run through a **policy-controlled scheduler/orchestrator** that clearly varies execution timing by time of day within approved windows (with controlled variation) and does not rely on manual operator timing.
- For applicable tasks, executions show **rotation across the approved set of service accounts/administrator roles**.
- Audit records show, for a representative sample of executions, the **actual timestamps**, the **selected randomness pattern/variation**, the **identity/role used**, and the **approved tool/supplier identifier**.
- The **system security plan** and relevant procedures reference the implemented randomness configuration (for example, configuration version/commit identifiers), and authorised reviewers can reproduce the evidence trail.

###### Actions Required for Compliance

- [ ] Create and get approval for a register of system-specific randomness methods, aligned to **SC-30.02_ODP**, covering: **time-of-day variation**, an approved **service and administrator rotation schedule**, and an approved list of **alternative tools or suppliers**.
- [ ] Identify and record the organisation’s “routine security tasks” for this application or system that will be carried out using randomness.
- [ ] Set up a central scheduling and coordination system to apply the approved time-of-day windows for each routine security task, allowing only a limited amount of timing variation (jitter) and preventing execution during excluded time periods.
- [ ] Link each task profile to approved workload identities and service principals, and to an approved set of rotating administrator roles, so execution follows the principle of least privilege.
- [ ] Only allow task execution using approved toolchains and suppliers by checking the selected toolchain or supplier identifier during runtime, and raising an alert if an unapproved option is chosen.
- [ ] Turn on and keep audit logs for every execution. Each log should record the time and date, the chosen randomness profile and jitter settings, the identity or role used, and the approved toolchain or supplier identifier.
- [ ] Update the system security plan and the step-by-step operating guides (runbooks) to point to the randomness techniques register and the version of the implemented scheduler or orchestration configuration.


---

#### SC-30.3 — Change Processing and Storage Locations (Enhancement)

This expectation is about making it harder for criminals to find and attack your most important computer work and where it is stored by periodically moving it to different locations. Without this, attackers can learn your fixed setup and keep targeting the same places, which increases the chance of a successful breach and reduces the time and effort they need.

To meet this expectation, the organisation must keep a documented list of the specific processing and storage locations used for critical services that will be moved. It must then move them at random times, at least once every three months. Each move must be approved through the organisation’s normal change process before it happens. The organisation must keep clear records showing what was changed, when it was approved, and when it was completed.

The organisation must update its records to show the new locations, keep evidence that the changes were carried out, and keep audit evidence showing the move happened as required. This approach must be written into its security planning.

##### Quarterly random relocation of critical processing/storage via change

- Category: Software
- Priority: Critical

###### WHAT
Periodically and unpredictably change the **processing and/or storage locations** used by the application’s **critical mission/business functions**, using **approved change control** and keeping the **from/to** details, approvals, completion records, and audit evidence.

###### WHY (control requirement)
SC-30(3) requires changing the organisation-defined **processing and/or storage** locations at **random time intervals**, with a defined minimum frequency (here: **quarterly**). This makes it harder for an attacker to plan and increases the effort needed to target the system.

###### HOW (specific approach)
Set up a “moving target” process that combines (1) a documented, approved list of components that can be moved, (2) a randomised quarterly move schedule, (3) execution through the organisation’s normal change process, and (4) automated collection of evidence and configuration updates.

1. **Create and keep up to date the scope list** of the specific **processing and/or storage locations** that will be moved for the application’s critical functions (for example: database primary/replica endpoints, object storage buckets, log storage, cache tiers, or compute placement identifiers). Keep this list version-controlled and approved by the system owner.
2. **Plan move windows at random time intervals** while meeting the minimum **quarterly** frequency. Save the planned windows (planned date/time window and reason) as part of the change package so the timing is not predictable.
3. **Carry out each move using approved change control**: for every move window, raise a change record that includes the exact **from/to** processing/storage locations, the cutover method (replication/failover/blue-green/live migration as applicable), the rollback plan, and any required pre-approvals.
4. **Update configuration records when the move is complete** to show the new processing/storage locations (for example: CMDB/service-to-region mapping, storage endpoint references, DNS/ingress targets, replication topology identifiers). Link the CMDB/configuration update to the change record.
5. **Keep audit and operational evidence** showing the move happened as required: orchestration/cloud/hypervisor/database replication logs, failover/cutover timestamps, and the change record showing approval and completion times.
6. **Document the approach in the system security plan** and ensure the relocation procedure follows the organisation’s expectations for concealment/misdirection by keeping the exact move timing and target details non-public and limiting exposure of endpoints until the cutover.

###### WHO
- **System Owner / Application Owner**: owns the scope list and approves the relocation approach.
- **Change Manager (CAB or delegated authority)**: ensures each move is carried out under approved change control.
- **Platform/Infrastructure Engineer**: implements the relocation (compute/storage migration/replication/failover) and the rollback.
- **Configuration Manager / CMDB Administrator**: ensures configuration baselines and records are updated and linked to the change.
- **Security/Compliance Analyst**: checks that evidence is complete for audit purposes.

###### Acceptance criteria
- There is a documented, approved list of the application’s **processing and/or storage locations** that will be moved.
- Relocations happen **at least quarterly**, and the move timing is generated as **random time intervals** (no fixed pattern).
- For each relocation, there is an **approved change record** with pre-approval, **from/to** locations, and completion timestamps.
- Configuration/CMDB records are updated to reflect the new processing/storage locations and are linked to the corresponding change.
- Evidence exists showing the move actually took place (cutover/failover/replication logs) and is retained for audit.
- The relocation approach is documented in the **system security plan** and followed during execution.

###### Actions Required for Compliance

- [ ] Create and approve a version-controlled list of the application’s processing and/or storage locations that are eligible to be moved.
- [ ] Set up a scheduler that creates quarterly “move windows” using randomly selected time periods, and then records them in a controlled change package.
- [ ] Set up the relocation orchestration to move computing and storage using replication, failover, and a blue-green switch-over, and record the time each switch-over happens.
- [ ] Integrate the relocation process with the organisation change management system so that each move must be approved in advance and the system records the start and end locations for that move.
- [ ] Automate updates to the configuration management database (CMDB) and configuration baseline to reflect the new processing and storage locations, and link those updates to the relevant change record.
- [ ] For each relocation, store and keep audit evidence—covering change approval and completion records, plus platform, database, and storage logs—so it is available for audit review.
- [ ] Update the system security plan to include the relocation procedure, the evidence you must keep, and the operational limits for concealment and misdirection.


---

#### SC-30.4 — Misleading Information (Enhancement)

This requirement is about intentionally presenting a public website and its public online programming links in a way that makes outsiders believe the organisation’s security protections are different from what they really are. The real-world risk it addresses is that attackers often look at what protections appear to be in place, then choose the most effective way to test, break into, or disrupt the service. If what they see is realistically misleading, it can slow them down and steer them towards less effective approaches.

To meet this expectation, the organisation must clearly decide which parts of the public website and public programming links are covered. It must then consistently show realistic but intentionally misleading statements about the service’s security position across those pages and responses.

The organisation must also:
- document what is being misrepresented and how
- assign named responsibility for maintaining it
- include the approach in its system planning and design records
- keep the relevant settings and documentation up to date
- keep audit evidence showing that any changes were made through authorised processes, so an independent reviewer can confirm the misleading information is present and intentional

##### Deception catalogue for public web/API security posture messaging

- Category: Software
- Priority: High

###### WHAT
Set up a centrally managed, version-controlled “deception catalogue” that produces realistic but intentionally misleading **security posture** messages across the organisation’s **public-facing web application and related API endpoints** (for example, selected public pages, API response fields/headers, and public documentation/security sections).

###### WHY (control requirement)
SC-30(4) enhancement requires the organisation to **use realistic but misleading information** in **{{ param, sc-30.04_odp }}** about its **security state or posture**. The goal is to mislead potential attackers about the **type and extent of controls in place**, including by using misleading information in **external systems that are known to be targeted**.

###### HOW (specific steps/approach)
1. **Define the public areas in scope for {{ param, sc-30.04_odp }}**: list the exact web routes/pages, API endpoints (including unauthenticated error paths), and any public documentation sections where deception will be shown.
2. **Create a version-controlled deception catalogue**. For each deception item, record: (a) the message text, (b) where it will appear (web template section, API response field/header, or documentation section), (c) the security-posture reason (what it is trying to misrepresent), and (d) internal notes on the real difference (what is actually deployed, or how it differs) to prevent claims becoming implausible or unsafe.
3. **Use one injection method** so all in-scope placements come from the same catalogue version (avoid hard-coded text by individual teams). For web, use shared templates/blocks; for APIs, insert into controlled response elements (for example, a dedicated public-facing header or a structured public error payload field where appropriate) and keep formatting consistent.
4. **Control and audit updates**: require an authorised approval process for catalogue changes; store catalogue versions with content checks (content hashes); record deployment events (catalogue version and build/release identifier) in an immutable audit log.
5. **Check consistency and persistence**: add CI (continuous integration) and CD (continuous delivery) checks that scan the public website and test sample in-scope API endpoints to confirm the expected misleading messages are present and unchanged for the deployed catalogue version.
6. **Maintain a written procedure** for reviewing, approving, updating, and retiring deception content, including roles and safeguards to ensure messages relate to **security posture** (not unrelated operational details).

###### WHO
- **Application Owner / Product Owner**: responsible for defining the in-scope public areas and approving the intended deception outcomes.
- **Cybersecurity Deception/Threat Intelligence Lead**: writes and reviews catalogue entries to ensure they are realistic and relevant to security posture.
- **Engineering Lead (Web/API)**: implements the injection method and the CI/CD validation.
- **Configuration Management / Change Manager**: ensures authorised change control and audit logging.

###### Acceptance criteria
- The organisation has an approved, documented list of in-scope **public web pages and API endpoints** for {{ param, sc-30.04_odp }}.
- A **version-controlled deception catalogue** exists and is the single source of truth for all in-scope misleading security-posture messages.
- Deception content is shown consistently across the in-scope public areas using the same catalogue version.
- Catalogue updates are made through an **authorised change process**, with recorded approvals and immutable audit evidence (catalogue version, content hash, deployment identifiers).
- Automated checks in CI/CD (or an equivalent process) confirm that the deployed public pages and sampled API responses contain the expected misleading messages for the current catalogue version.

###### Actions Required for Compliance

- [ ] List and record the exact public website routes and pages, and the application programming interface (API) endpoints that are in scope for **sc-30.04_odp** (including error paths that can be accessed without authentication).
- [ ] Create a version-controlled deception catalogue that includes the claim wording, where each claim is placed, and internal notes on what is true and what differs.
- [ ] Set up one catalogue-based injection method for web templates and for API response fields and headers.
- [ ] Set up an authorised approval process and permanent audit records for catalogue changes, including the version, a content fingerprint (hash), and the deployment reference (deployment ID).
- [ ] Add automated continuous integration and continuous delivery (CI/CD) checks to scan in-scope pages and test sample in-scope application programming interface (API) endpoints, to confirm that the expected misleading claims are present.
- [ ] Write and keep up to date a procedure that sets out who is responsible, how often the deception content is reviewed, and the criteria for when it should be retired.


---

#### SC-30.5 — Concealment of System Components (Enhancement)

This requirement is about making key systems harder to locate and harder to access by keeping them hidden behind well-designed safeguards. Without this, attackers could more easily target your most important operational technology servers, industrial gateways, and identity servers, and then use stolen or intercepted information to gain access or cause disruption.

To meet this expectation, the organisation must protect and conceal these components by:
- separating their network connections from other systems
- using encryption to protect data both when it is stored and while it is being sent
- using virtual or container-based setups to isolate and disguise the components

The organisation must also keep clear records showing:
- which components are covered
- which concealment methods are used
- how the concealment is designed, implemented, and managed over time

This includes approved procedures, details of the system design and configuration, and evidence that changes are controlled, so the concealment is not accidentally weakened.

##### Conceal OT control servers/gateways/DCs via segmentation, encryption, isolation

- Category: Software
- Priority: Critical

###### WHAT
Put concealment controls in place for the defined **system components** (operational technology (OT) control servers, industrial gateways, and domain controllers) using the defined **techniques**: **network segmentation**, **encryption for data stored and data sent over networks**, and **virtualisation/containerisation**.

###### WHY (control requirement)
NIST SP 800-53 **SC-30(5) (Enhancement)** requires the organisation to “use the following techniques to hide or conceal {{ insert: param, sc-30.05_odp.02 }}: {{ insert: param, sc-30.05_odp.01 }}.” The goal is to reduce the chance that attackers can target these critical components and successfully compromise them.

###### HOW (specific approach)
1. **Create and maintain a concealment map**: record which exact assets/instances are in scope (OT control servers, industrial gateways, domain controllers) and which concealment techniques are applied to each one (segmentation, encryption for data stored and data sent over networks, and virtualisation/containerisation).
2. **Network segmentation (concealment by isolation)**: place each in-scope component into its own network zones (for example, an OT Management zone and an OT Gateway/DMZ zone). Use **default-deny** routing between zones, and allow only the specific management/service connections that are required.
3. **Encryption for data sent over networks (concealment by protected communications)**: require encrypted connections for all management and service communications that reach the in-scope components (for example, Transport Layer Security (TLS) for web/application programming interface (API) consoles, Secure Shell (SSH) for command-line access, and virtual private network (VPN)/private connectivity for remote administration). Disable or block unencrypted (plaintext) options.
4. **Encryption for data stored (concealment by protected storage)**: enable and confirm storage/volume encryption for the in-scope components (for example, cloud-managed volume encryption or operating system/database storage encryption). Ensure encryption keys are managed using the organisation’s approved key management approach.
5. **Virtualisation/containerisation (concealment by isolation and repeatability)**: where it is practical, run the in-scope components in isolated virtual environments/containers (for example, dedicated management cluster/hosts, hardened images, and restricted virtual machine/container-to-network connections). This helps ensure the components are not reachable from a flat network and can be set up again in a consistent way.
6. **System security plan and configuration evidence**: document the concealment approach (zone diagrams, component-to-technique mapping, and the required encrypted protocols) in the system security plan. Ensure the exact configuration settings that implement segmentation/encryption/isolation are captured through configuration management.
7. **Change control to prevent weakening**: require that any change affecting network paths, Transport Layer Security (TLS)/Secure Shell (SSH)/virtual private network (VPN) settings, storage encryption, or virtualisation/container isolation includes an explicit “no weakening of concealment” check and produces audit evidence (for example, configuration differences, firewall policy updates, encryption status reports).

###### WHO (roles responsible)
- **System Owner / OT Platform Owner**: responsible for the in-scope component list and the concealment map.
- **Network Security Engineer**: implements and documents segmentation rules and routing policies.
- **Infrastructure/Cloud Engineer**: implements encryption for data stored and virtualisation/container isolation.
- **Identity and Access Management (IAM)/Platform Security Engineer**: ensures encrypted management access paths and that certificate/key lifecycles align.
- **Configuration Management Lead / Change Manager**: ensures concealment settings are managed through change control and that evidence is kept.

###### Acceptance criteria (audit-ready)
- There is a current, approved document mapping each in-scope component to the concealment techniques applied.
- Network segmentation is evidenced by zone diagrams and firewall/router policies showing default-deny between zones and only the required explicit allow paths to the in-scope components.
- Encryption for data sent over networks is evidenced by enforced encrypted management/service protocols and the absence/blocking of plaintext alternatives.
- Encryption for data stored is evidenced by verified encryption status for the in-scope components’ volumes/storage.
- Virtualisation/containerisation (where feasible) is evidenced by isolated hosting placement and restricted connectivity between networks.
- The system security plan includes the concealment approach and the component/technique mapping.
- Configuration management/change records show concealment settings are controlled, and changes include a “no weakening” verification step with retained evidence.

###### Actions Required for Compliance

- [ ] Create an authoritative, in-scope list (inventory) of operational technology (OT) control servers, industrial gateways, and domain controllers, and link each one to the concealment techniques used.
- [ ] Set up separate operational technology (OT) network zones, block all traffic by default (default-deny routing), and then allow only the specific management and service routes that are required for the in-scope components.
- [ ] Require encrypted ways to manage and connect to services (Transport Layer Security (TLS), Secure Shell (SSH), Virtual Private Network (VPN), and private connectivity), and block unencrypted (plaintext) options for the in-scope components.
- [ ] Turn on and confirm encryption at rest for the in-scope components’ storage volumes, and document that the key management approach matches the agreed requirements.
- [ ] Where possible, deploy the in-scope components in separate virtual or container environments, and limit network connections between hosts and containers.
- [ ] Update the system security plan to include zone diagrams, a link between each component and the security technique it supports, and the required rules for encrypted communications.
- [ ] Add concealment settings (network segmentation rules, encryption requirements, and isolation settings) to configuration management. Also require change tickets to include a confirmation that no security protections are weakened, with supporting evidence kept on record.


---

### SC-31 — Covert Channel Analysis (Control)

This requirement is about checking whether information could leak out through the way systems exchange data—either through what the systems store or through small, hard-to-detect differences in timing. It also requires assessing how much information such a hidden leak could carry. Without this work, someone could potentially send unauthorised information between different parts of an organisation (or between an internal system and an external connection) in ways that are difficult to spot, particularly when sensitive data is involved.

To meet this expectation, the organisation must:
- define the scope of the analysis
- analyse the system’s communications to identify potential hidden storage and potential hidden timing channels
- record what was found
- estimate, for each identified channel, the maximum possible amount of data it could carry

The organisation should use its system design and configuration records as evidence, keep auditable analysis records (including the method, assumptions, and results), ensure the activity is included in the system’s security plan, and update the analysis when changes are made that affect communications.

##### Covert storage/timing channel analysis with bandwidth estimates

- Category: Manual
- Priority: High

###### WHAT
Carry out covert channel analysis focused on **storage** and **timing** information moving through the application’s in-scope communications, including any cross-domain or external network connections.

###### WHY (control requirement)
**Security and control requirement SC-31** asks the organisation to **identify potential covert storage and covert timing channels** in system communications and **estimate the maximum bandwidth** each channel could support. This helps the organisation manage and reduce the risk of hidden information moving between systems. The organisation-defined parameter means the analysis should cover **storage, timing**.

###### HOW (specific steps/approach)
1. **Define analysis scope**: create an “in-scope communications” inventory covering service-to-service/application programming interface (API) traffic, message buses, administrative channels, and any external entry/exit paths that could allow unauthorised information to move across security boundaries.
2. **Identify candidate covert channels**: for each in-scope interface, create a channel-candidate register by reviewing how the protocol behaves and how the system is designed/configured in ways that could allow:
   - **Covert storage channels** (for example, information kept from earlier activity, buffering/queue depth, caching, retry/backoff behaviour, and how long data persists)
   - **Covert timing channels** (for example, variation in response times, effects of scheduling, rate limiting, timeouts, sources of timing “jitter”, and limits caused by concurrency/throughput)
3. **Estimate maximum bandwidth**: use a repeatable, documented template for each channel type, using conservative “worst-case” assumptions. Clearly state:
   - how precisely observations are measured,
   - the maximum symbol/response rates,
   - and how normal system behaviour limits how easy it is to tell the difference.
   Record the resulting bandwidth estimate for each identified channel.
4. **Maintain traceability and audit evidence**: link each channel finding to the specific architecture/design documents and the exact configuration evidence that affects storage/timing behaviour (for example, queue sizes, timeout/retry settings, caching time-to-live (TTL) values, rate-limit policies, and load balancer/concurrency settings). Date and version the analysis outputs.
5. **Update on communications-related changes**: review and update the analysis when communications-related changes occur (for example, protocol changes, changes to timeouts/queueing/rate limiting, or new external integrations). Record what triggered the change and the outcome of the re-analysis.
6. **Reflect in the system security plan**: record that the analysis has been completed, its scope, and where the results are stored, so auditors can trace the SC-31 evidence.

###### WHO
- **Application security architect / security engineering lead**: owns the analysis method, templates, and bandwidth estimation approach.
- **Developers / platform engineers**: provide details of interface behaviour and the configuration evidence.
- **Change manager / release manager**: ensures communications-related changes trigger re-analysis.
- **Information security governance / compliance**: checks that the work is linked to the system security plan and that it is ready for audit.

###### Acceptance criteria
- A completed **in-scope communications inventory** exists and is approved for the application.
- A **channel-candidate register** identifies potential **storage** and **timing** covert channels for each in-scope interface.
- For every identified channel, there is a **documented maximum bandwidth estimate** with explicit assumptions and a repeatable method.
- Each channel record is **traceable** to specific design/configuration evidence (including settings that affect timing/storage).
- The analysis outputs are **versioned**, suitable for audit, and **referenced in the system security plan**.
- There is a defined process to **update the analysis** when communications-related changes occur, including evidence of at least one review cycle (or a documented reason if no changes occurred).

###### Actions Required for Compliance

- [ ] Create and get approval for an in-scope communications inventory that covers all relevant internal connections and all external or cross-domain connections.
- [ ] Run structured workshops to create a list of suitable candidates for each interface, separating candidates related to hidden storage from candidates related to hidden timing.
- [ ] Document a repeatable method for estimating available bandwidth, then apply it to each candidate using clear, conservative assumptions.
- [ ] Link each channel finding to the specific architecture and design documents, plus the configuration proof, that affects how storage and timing behave.
- [ ] Store the analysis outputs in a version-controlled repository with audit-ready documentation of the method, assumptions, results, and dates.
- [ ] Update the system security plan to reference the scope of the SC-31 analysis and where the supporting evidence is stored.
- [ ] Define and run a re-check whenever communications-related changes are made (for example: communication rules, time limits, message handling, caching, limits on message rates, and links to external systems).


---

#### SC-31.1 — Test Covert Channels for Exploitability (Enhancement)

This requirement is about checking whether “hidden routes” could be used to move unauthorised information through your systems. If you do not test, you might assume these hidden routes are harmless, but they could let someone pass information in ways that get around your normal safeguards, which could result in data leakage or other serious misuse.

To meet this requirement, the organisation must take the list of identified hidden routes and select a sensible subset to test. The tests must follow the organisation’s documented procedures and use the real system setup described in its design and configuration records. The organisation then runs the tests for each selected hidden route, records clear results showing whether each one can be used (or not), keeps the supporting evidence in audit records, and updates its hidden-route analysis documentation and the system’s security plan to reflect what was tested and the results.

##### Exploitability testing of selected covert channels with auditable evidence

- Category: Manual
- Priority: High

###### WHAT
Choose a subset of the organisation’s identified covert channels and test that subset to find which channels could be used to move information without authorisation.

###### WHY (control requirement)
SC-31(1) (Enhancement) requires: **“Test a subset of the identified covert channels to determine the channels that are exploitable.”**  
This means you must not assume any channel is safe. You must run exploitability tests on a defined subset and record the results.

###### HOW (specific approach)
1. **Start with the organisation’s identified covert channel list** (from your covert channel analysis records). Select a **documented subset** using a risk-based method (for example, likelihood × impact × exposure). Record why you chose that subset.
2. **Set exploitability test rules for each channel before testing** (for example, what counts as “exploitable”, “not exploitable”, and “inconclusive”). The rules must be measurable and repeatable.
3. **Test in an environment that matches the real design and configuration**: use the separate **test/staging** environment that reflects the relevant system design and configuration settings (including logging/telemetry routes and relevant network/service behaviour). Do not test in production.
4. **Run controlled tests for each selected channel** using a repeatable test method. For each channel, record:
   - test identifier, start/end time
   - the system configuration baseline/version used (or a reference to an exported snapshot)
   - the components involved and the data paths used
   - raw evidence (for example, logs, telemetry exports, packet captures where applicable, and any test outputs produced)
   - what you observed, and whether the predefined exploitability rules were met
5. **Record the result for each channel** as **exploitable / not exploitable / inconclusive**, including where the evidence is stored and why you reached that conclusion.
6. **Update the covert channel analysis records and the system security plan** to show:
   - the scope of the subset that was tested
   - the exploitability results
   - any follow-on actions (for example, mitigations to reduce exploitability) and any channels still marked “untested”.

###### WHO
- **Application Security Lead / Security Architect**: responsible for the subset selection rationale, the exploitability test rules, and the documentation updates.
- **Red Team / Security Testing Engineer** (or an authorised penetration testing function): runs the controlled exploitability tests and produces the evidence.
- **System Owner / Platform Engineer**: provides configuration baselines and ensures the staging environment matches the relevant design/configuration.
- **Compliance/Governance, Risk and Compliance (GRC)**: checks that evidence is suitable for audit and that the system security plan references the testing scope.

###### Acceptance criteria
- There is a documented **subset selection**, based on the identified covert channel list, with a rationale.
- For each tested channel, there is a **recorded outcome** (exploitable / not exploitable / inconclusive) against **predefined criteria**.
- Evidence is kept and can be traced per channel (test identifiers, timestamps, configuration baseline references, and raw evidence items).
- The covert channel analysis records and the **system security plan** are updated to include the **tested subset scope** and results.
- Testing is carried out in a **separate test/staging environment** that matches the relevant system design/configuration (not production).

###### Actions Required for Compliance

- [ ] Compile the current list of identified covert channels and confirm it is the official source of information for SC-31(1) testing.
- [ ] Choose a risk-based subset of covert channels, and document why they were selected and what is included and excluded (the scope boundaries).
- [ ] Before any testing begins, define measurable criteria for whether each selected channel is exploitable, not exploitable, or inconclusive.
- [ ] Set up a staging or test environment that matches the relevant system design and configuration settings, and export a configuration baseline reference for audit purposes.
- [ ] Run controlled “how vulnerable is it?” tests for each communication channel, and collect evidence that can be audited (for example, logs, telemetry, and packet captures where relevant), using unique test reference numbers.
- [ ] For each channel, record the outcome, include evidence references, and explain how it meets the predefined criteria.
- [ ] Update the covert channel analysis report and the system security plan to reflect the scope that was tested and the results obtained.


---

#### SC-31.2 — Maximum Bandwidth (Enhancement)

This requirement is designed to stop hidden ways that information could be passed through a system. It does this by setting a strict limit on how quickly any identified hidden “data storage” or “timing” signals can carry information. Without this limit, a determined attacker could potentially hide messages in the way the system behaves—for example, by using subtle differences in what the system does or when it does it—which could weaken confidentiality even if normal protections are in place.

To meet this expectation, the organisation must have clear written procedures to review systems, identify any hidden channels, and then use the findings to redesign or reconfigure the affected systems. For each identified hidden channel, the maximum hidden information rate must be no more than 50 kilobits per second.

The organisation must:
- document the target and the specific system changes in system plans and design records
- include the same requirement in purchase and supplier contracts
- assign clear responsibilities to the right staff
- keep audit evidence showing the 50 kilobits per second limit remains in place over time

##### Enforce 50 kbps covert-channel bandwidth budgets via config baselines

- Category: Software
- Priority: High

###### WHAT
Set up and continuously enforce a maximum bandwidth limit of **50 kilobits per second (50 kbps)** for each **identified hidden (covert) storage channel** and **hidden (covert) timing channel**. This is done by turning the results of covert-channel analysis into fixed, non-negotiable **configuration and design limits** (“bandwidth budgets”).

###### WHY (control requirement)
SC-31(2) (Enhancement) requires: **“Reduce the maximum bandwidth for identified covert {{param, sc-31.02_odp.01}} channels to {{param, sc-31.02_odp.02}}.”** The organisation-defined parameters cover **storage** and **timing** channels, with a target of **50 kbps**. The guidance notes that fully removing these channels is usually not possible; therefore, the practical requirement is to **reduce the maximum bandwidth** to the stated limit.

###### HOW (specific steps/approach)
1. **Run or obtain covert-channel analysis results** that identify each covert channel and its type (**storage** or **timing**), including the measurable system behaviours that affect bandwidth.
2. For each identified channel, **define the measurable “control levers”** (for example, scheduling/timing-related settings, buffering or queue limits, inter-process or inter-service communication behaviours, and storage access patterns that can be influenced by configuration) that cap the channel’s maximum bandwidth.
3. **Link each channel to a specific configuration/design limit**. This link must be supported by evidence (such as vendor documentation, internal testing, or formal analysis) showing the channel’s maximum bandwidth is **≤ 50 kbps**.
4. **Put the limits into hardened configuration baselines** (policy-as-code / configuration management rules) so the settings cannot drift above the approved values.
5. **Tie enforcement to change control**: any change that affects the mapped control levers must be approved using the covert-channel analysis record, and it must show the limit still remains **≤ 50 kbps**.
6. **Produce audit evidence**: automatically record the effective configuration values for each environment (production, test, disaster recovery), the linked analysis record, and the change ticket identifiers to show ongoing compliance.

###### WHO (role responsible)
- **Application Security Architect / Security Engineering Lead**: owns the interpretation of the covert-channel analysis and the mapping from channels to control levers.
- **Platform/Infrastructure Engineering (Cloud/On-premises)**: implements the hardened baselines and checks for configuration drift.
- **Configuration Management / DevOps Lead**: ensures policy-as-code enforcement and automates evidence collection.
- **Change Advisory Board (CAB) / Change Manager**: enforces the approval process, referencing the analysis and bandwidth budgets.

###### Acceptance criteria
- For every identified covert **storage** and **timing** channel, there is a documented mapping to specific configuration/design limits, including an explicit justification that the maximum bandwidth is **≤ 50 kbps**.
- The organisation’s configuration baselines enforce the mapped limits in all relevant environments, and any drift above the approved values is prevented or detected and corrected.
- Change records for any modification to the mapped control levers include a link to the covert-channel analysis record and show continued compliance with the **≤ 50 kbps** limit.
- Audit evidence exists showing the effective configuration values and their links to the analysis and change tickets.

###### Actions Required for Compliance

- [ ] Carry out covert-channel analysis to identify the hidden storage and timing channels that have been found, and to describe what behaviours influence them.
- [ ] Set clear “control knobs” for each communication channel’s configuration and design, and document the reason why the maximum possible bandwidth is **50 kilobits per second (kbps)** or less.
- [ ] Set fixed bandwidth limits of **50 kilobits per second (kbps)** or less in secure, standard configuration templates for every relevant environment, using automated policy controls (policy-as-code).
- [ ] Set up ongoing configuration compliance checks to detect and stop changes (“drift”) that could increase the capacity of hidden communication channels.
- [ ] Update the change control process so that any change to mapped “knobs” requires approval that references the covert-channel analysis record and the bandwidth budget.
- [ ] Automate audit evidence exports that show the effective configuration values, link them to the relevant analysis identifiers, and include references to the change tickets.


---

#### SC-31.3 — Measure Bandwidth in Operational Environments (Enhancement)

This requirement is about checking, in the real day-to-day environment where your system runs, how much hidden information could potentially be leaked through subtle system behaviour. Examples include patterns in timing or changes linked to how data is stored. If this is not measured, an organisation may underestimate the risk of sensitive information leaking in ways that are difficult to detect, which could harm business operations or mission outcomes.

To meet this expectation, the organisation must measure the “timing-based and storage-based” hidden information routes in the operational environment (not only in a laboratory). It must do this using its documented procedures for covert channel analysis. The organisation must base the work on the relevant system design and current settings, record the measured bandwidth results in its covert channel analysis documentation, and keep traceable supporting evidence in audit records. This should align with the system’s security plan and any other relevant records.

##### Operational covert channel bandwidth measurement (timing & storage)

- Category: Manual
- Priority: Critical

###### WHAT
Measure the bandwidth (the maximum rate at which information could leak) for the organisation-defined subset of covert channels in the **operational environment** for the system. This specifically covers **timing-based** and **storage-based** covert channels.

###### WHY (control requirement)
SC-31(3) enhancement requires that the organisation **measures the bandwidth of the subset of identified covert channels** (parameter: **sc-31.03_odp**) **in the operational environment**. The guidance notes that covert channel bandwidth can be very different between lab/development and real operational use.

###### HOW (specific approach)
1. **Choose what to measure from design/configuration**: Using system design documents and the current operational configuration, identify the specific timing and storage behaviours that match the defined covert channel subset (sc-31.03_odp: *timing-based and storage-based covert channels*). Record the mapping, for example:
   - which request/queue/scheduling paths affect timing,
   - which persistence/logging/database/storage behaviours affect storage.
2. **Use the organisation’s approved covert channel analysis method**: Apply the organisation’s documented covert channel analysis procedure to define:
   - how the sender encodes bits,
   - how the receiver infers information,
   - the measurement time windows and when to stop,
   - the bandwidth measure and how confidence/uncertainty is recorded.
3. **Run controlled, authorised measurements in live operations**: Carry out managed, limited experiments in the operational environment using realistic workloads and limited changes that do not break SLO/Service Level Agreement (SLO/SLA) or safety requirements. Use change approvals and agreed stop/rollback criteria.
   - **Timing-based measurement**: adjust inputs that affect timing (for example, arrival patterns, concurrency levels, and allowed payload sizes) within what is permitted in operations; measure how well the receiver can infer bits from the observed timing patterns.
   - **Storage-based measurement**: adjust inputs that affect storage (for example, create/update/delete patterns, event/log persistence triggers, database row update patterns, and behaviours caused by retention/compaction); follow data classification and retention rules; measure how well the receiver can infer bits from observable changes in storage state.
4. **Keep evidence that can be audited and repeated**: For each channel type, record the measured bandwidth results and all information needed to reproduce the work under the organisation’s procedure:
   - operational environment identifiers (system version/build, configuration baseline, relevant feature flags),
   - workload profile and change parameters,
   - measurement windows, sampling rates, and any filtering,
   - the raw and derived measures used to calculate bandwidth,
   - results (bandwidth value and uncertainty/confidence as defined by the procedure).
   Store supporting evidence in audit records and ensure the results match the system’s **security plan**.

###### WHO
- **Covert channel analysis lead / security engineer**: owns the measurement plan, the channel mapping, and delivery of the analysis procedure.
- **Application owner / system owner**: authorises the scope of operational measurements and ensures business and SLO constraints are met.
- **Change manager / operations lead**: approves and coordinates the change-managed execution window and the stop/rollback criteria.
- **Security operations centre (SOC) / observability engineer**: ensures telemetry collection and evidence capture (logs/traces/metrics) is complete and tamper-evident.

###### Acceptance criteria
- Bandwidth is measured for the **defined subset** (sc-31.03_odp) covering **timing-based** and **storage-based** covert channels.
- Measurements are carried out in the **operational environment** (not only in lab/development) using the organisation’s covert channel analysis procedure.
- For each channel type, the organisation produces auditable records that include the reproducibility context and the calculated bandwidth results (including any confidence/uncertainty per the procedure).
- Evidence is traceable to audit records and aligned with the system’s security plan.
- Operational measurements finish within approved limits (including a documented SLO/SLA impact assessment and agreed stop/rollback criteria).

###### Actions Required for Compliance

- [ ] Identify the specific timing-based and storage-based behaviours that match the defined covert channel subset (SC-31.03_ODP), using the system design and the current operational configuration.
- [ ] Choose and record the bandwidth measure to use, the encoding and receiver methods, the time periods for the measurements, and the conditions for stopping, following the organisation’s covert channel analysis procedure.
- [ ] Get approval through the change-management process and set the operational limits, including the impact on service level objectives (SLOs) and service level agreements (SLAs), the conditions for rolling back or stopping the change, and the rules for how data will be handled and retained.
- [ ] Carry out limited, authorised operational tests to measure timing-based hidden communication channels, and calculate the data transfer rate (bandwidth) from the recorded telemetry.
- [ ] Carry out limited, approved operational tests to measure storage-based covert channels, and calculate bandwidth from the recorded telemetry.
- [ ] Record the results and supporting evidence in the covert channel analysis records, with clear links to the audit records and alignment with the system security plan.


---

### SC-32 — System Partitioning (Control)

This requirement is about keeping different parts of your system in separate, clearly separated areas, so that sensitive information and important functions cannot be accessed casually. Without this separation, a mistake or compromise in one part (for example, a web service) could spread to other parts (such as databases holding confidential records) and potentially disrupt operations, expose data, or allow unauthorised actions across the whole environment.

To meet this expectation, the organisation must split the system into separate logical areas for network services, application services, and data stores. Each area must be placed based on how sensitive and critical the data is (Secret/Confidential) and whether it is in an information technology (IT) or operational technology (OT) environment.

The organisation must also use managed, controlled connection points so that only the information that is necessary can pass between these areas, with everything else blocked by default. Finally, it must document why this design was chosen, keep diagrams and an up-to-date list of the domains, ensure the live setup matches the documentation, maintain clear responsibilities and procedures, and record the approach in its security plan.

##### Zone-based logical partitioning with managed allow-listed interfaces

- Category: Software
- Priority: Critical

###### WHAT
Split the system into **network services, application services, and data stores** that run in **separate logical areas/environments**. Decide where each area goes based on the need for **physical or logical separation**, considering **data sensitivity/importance (Secret/Confidential)** and the **IT versus operational technology (OT) trust boundary**. Use **controlled connections** so that only the information flows that are explicitly needed are allowed between these separated areas.

###### WHY (control requirement)
Security control **SC-32** requires: “Partition the system into {{ sc-32_odp.01 }} residing in separate {{ sc-32_odp.02 }} domains or environments based on {{ sc-32_odp.03 }}.” The guidance also requires “defence in depth” through partitioning, and that **controlled connections** limit or prevent network access and information flow between the separated components.

###### HOW (specific approach)
1. **Define the partition model**: create an official list of zones/areas for:
   - **Network services** (for example: entry traffic routing/load balancing, domain name system (DNS), application programming interface (API) gateways)
   - **Application services** (for example: web/application programming interface (API) services, microservices)
   - **Data stores** (for example: relational databases, document stores, object storage)
2. **Match placement to the situation**: for each zone, record why it is placed there using:
   - **Data sensitivity/importance** (Secret/Confidential)
   - **IT versus OT trust boundaries** (or equivalent trust separation within the organisation)
3. **Create logical separation**:
   - Use **separate subnets/virtual private clouds (VPCs)/virtual networks (VNETs)/tenants** (as applicable) for each zone.
   - Treat **production, testing, and disaster recovery (DR)** as separate environments (at minimum, separate domains or equivalent isolation).
4. **Enforce controlled interfaces with “default deny”**:
   - Place a central control point (for example: next-generation firewall, cloud security policy, zero trust network access (ZTNA) gateway) between zones.
   - Configure **explicit “allow-list” rules** only for the required traffic flows (from source zone to destination zone, protocol/port, and where possible identity/service context).
   - Block all other cross-zone traffic by default; record both allowed and blocked attempts.
5. **Make the partitioning auditable and resistant to unauthorised change**:
   - Keep zone membership and interface rules as **version-controlled configuration** (for example: infrastructure as code (IaC)/policy as code).
   - During change windows, run a **diagram-to-configuration check** to confirm the live setup matches the documented partitioning.
6. **Run it with clear ownership**:
   - Assign owners for zone definitions and for changes to interface rules.
   - Require formal change approval for any update to cross-zone allow-list rules.

###### WHO
- **Security architect / Chief Information Security Officer (CISO) delegate**: approves the zone model and placement rationale.
- **Network/security engineering**: implements zone separation and controlled interface policies.
- **Application/infrastructure owners**: ensure services are deployed into the correct zones.
- **Change manager / Change Advisory Board (CAB)**: enforces the approval process for cross-zone rule changes.

###### Acceptance criteria
- The system is partitioned into **network services, application services, and data stores** in **separate logical areas/environments**.
- Each zone’s placement rationale is documented using **Secret/Confidential sensitivity** and **IT versus OT trust boundaries**.
- Cross-zone connectivity is **default-deny**, with **only required allow-list rules** enforced through controlled interfaces.
- Evidence exists showing the **zone inventory and network diagrams**, and that the **live configuration matches those diagrams** (with no unapproved cross-zone paths).
- Blocked cross-zone attempts are logged and can be reviewed (at least through the security information and event management (SIEM)/logging pipeline).

###### Actions Required for Compliance

- [ ] Create and get approval for an inventory of zones and domains used for network services, application services, and data stores.
- [ ] Document where each zone is placed, and explain why, based on its Secret or Confidential sensitivity level and the trust boundary between information technology (IT) and operational technology (OT).
- [ ] Set up logical separation for each zone by using separate subnets, virtual private clouds (VPCs), virtual networks (VNETs), or tenants, as appropriate for the way the service is hosted.
- [ ] Set up managed connections between network zones using a “deny by default” approach, and then add only the specific “allow” rules needed for required data flows.
- [ ] Store which zones a system belongs to and the rules for its network interfaces in version-controlled infrastructure-as-code (IaC) and policy-as-code, and enforce these settings by deploying only through change-controlled deployment pipelines.
- [ ] Create network and site (facility) diagrams, then compare the diagrams against the configuration records to confirm that the live environment matches the documented network and site partitioning.
- [ ] Assign owners for each network zone and for rules that connect zones, and require Change Advisory Board (CAB) approval before making any changes that allow-list connectivity.


---

#### SC-32.1 — Separate Physical Domains for Privileged Functions (Enhancement)

This requirement is about keeping the most powerful, security-critical activities in separate physical areas, so that one problem cannot automatically spread to everything else. If all “privileged” activities that can make important security changes are carried out from the same location, then a break-in, equipment failure, or loss of service in that one area could stop or compromise everything at the same time.

To meet this expectation, the organisation must first identify which activities are privileged. It must then place them into separate physical areas or environments, and ensure that if one area is compromised or goes offline, the others are not affected. The organisation must also document how this separation works in its security policy, partitioning procedures, system design and architecture documents, configuration settings records, and its security plan. It must keep an up-to-date list of the physical areas used.

Finally, the organisation must maintain site and network diagrams that clearly show where the privileged activities are located and how the separated environments connect. All documents must be consistent with each other.

##### Physically isolate privileged admin functions into separate domains

- Category: Manual
- Priority: Critical

###### WHAT
Separate the application’s privileged functions (actions that can make security-relevant changes) into different physical areas or environments. This way, if one area is compromised or unavailable, it cannot automatically affect privileged functions in another area.

###### WHY (control requirement)
SC-32(1) Enhancement requires that privileged functions running in a single physical area create a single point of failure. Separating them reduces the risk that a compromise or outage in one area spreads to other privileged capabilities.

###### HOW (specific approach)
1. **Create a privileged-function inventory and map it to domains**: identify which application-adjacent functions are privileged (for example: identity and access management (IAM) administration for the application, security configuration management, certificate and public key infrastructure (PKI) administration, logging and security information and event management (SIEM) administration actions, backup and restore authority, infrastructure and virtualisation management for hosting components, and any “break-glass” emergency administrative tools). Map each privileged function to a dedicated physical domain.
2. **Set up separate physical domains/environments** (at minimum, separate “security administration” from “general operations administration”, and separate “identity and IAM administration” from “application security configuration”):
   - Identity and IAM Admin Domain (identity provider (IdP) and IAM admin consoles, automation runners)
   - Security Configuration Admin Domain (security policy and configuration management, SIEM and security orchestration, automation and response (SOAR) administration, endpoint detection and response (EDR) and telemetry administration)
   - Backup and Recovery Admin Domain (backup orchestration and restore authority)
   - Application and Platform Privileged Admin Domain (only if needed; otherwise keep privileged actions within the domains above)
3. **Enforce physical separation in the management setup**: use dedicated admin workstations or hardened jump hosts for each domain. Each domain must have its own management network (for example, virtual local area network (VLAN) or virtual routing and forwarding (VRF)) and restricted routing. Make sure privileged tools and credentials are only available inside the intended domain.
4. **Limit and document connections between domains**: allow only the minimum, narrowly defined information flows (for example, read-only export of logs and telemetry from other domains into the Security Configuration Admin Domain). By default, block administrative access between domains.
5. **Stop privileged components being placed in the wrong domain**: use infrastructure-as-code and deployment pipelines with approval checks so privileged components cannot be deployed into the wrong domain (for example, continuous integration and continuous delivery (CI/CD) checks that confirm the target network or host group before provisioning).
6. **Keep audit-ready evidence and ensure consistency**: maintain an authoritative, up-to-date list of physical domains. Ensure facility and network diagrams, the system security plan, architecture and design documents, and configuration records all consistently show the privileged-function partitioning.

###### WHO
- **Application Security Architect / Security Engineering Lead**: owns the privileged-function inventory, domain mapping, and design decisions.
- **Infrastructure and Cloud Platform Team**: implements domain separation (networks, jump hosts, routing, deployment guardrails).
- **IAM/Identity Team**: implements controls for the Identity and IAM Admin Domain and the approved access routes.
- **Security Operations Centre (SOC) / SIEM Engineering Team**: implements the Security Configuration Admin Domain tooling and connectivity.
- **Change Management / Configuration Management Owner**: ensures updates to diagrams, the security plan, and configuration baselines are controlled and versioned.

###### Acceptance criteria
- A documented privileged-function inventory exists, and each privileged function is mapped to exactly one physical domain.
- Dedicated admin environments or jump hosts exist for each domain, with separate management networks and no general administrative access across domains.
- Connections between domains are limited to required flows (for example, telemetry or log read-only access), and administrative control-plane access is denied by default.
- CI/CD or provisioning guardrails prevent privileged components from being deployed into the wrong domain.
- Facility and network diagrams, and the system security plan, match the implemented domain partitioning. Configuration and change records provide evidence that the separation is in place during operation.

###### Actions Required for Compliance

- [ ] Identify and record all privileged functions for the application and its management system (security-sensitive administrative capabilities), and assign an accountable owner to each one.
- [ ] Define the required physical areas and environments, and assign each privileged function to its designated area.
- [ ] Set up dedicated administration computers (“jump hosts”) for each domain, with separate management networks (virtual local area networks (VLANs) and virtual routing and forwarding (VRF) instances), and block all administrative network traffic by default, only allowing the required routes.
- [ ] Set up tightly limited connections between domains (for example, read-only sharing of telemetry and logs) and explicitly block any cross-domain routes that would allow administrative control.
- [ ] Add deployment and provisioning safeguards (continuous integration and continuous delivery (CI/CD) checks or infrastructure as code (IaC) validation) to prevent privileged components from being placed in the wrong physical area.
- [ ] Update and version the facility and network diagrams, system security plan, architecture and design documents, and configuration records so they reflect the domain partitioning and stay consistent with each other.


---

### SC-34 — Non-modifiable Executable Programs (Control)

This requirement is about ensuring the classified system starts from software that cannot be changed, and that only approved applications run from similarly protected, unchangeable copies. Without this, someone could alter the system’s starting code or install unauthorised software, allowing harmful changes to remain every time the system boots and giving attackers a reliable way in.

To meet this expectation, the organisation must ensure that the operating system and the virtual machine host components used for classified workloads are loaded and run only from hardware-protected read-only media. It must also ensure that only the approved mission and security applications packaged in read-only images are loaded and run from the same kind of protected media.

The organisation must keep exact, documented lists of which system components and applications are allowed. It must record which specific read-only media are used, define and follow clear procedures for how these unchangeable images are created and used, and document the design, settings, and controls that enforce this behaviour.

It must also keep audit records showing the system started and ran as expected, and it must check that attempts to use writable storage to boot or run applications are blocked.

##### Verified read-only boot and app images for classified hosts

- Category: Software
- Priority: Critical

###### WHAT
Put in place a technical and process-based approach so that, for the organisation-approved **system parts** (operating system (OS) and hypervisor/virtual machine (VM) host components used for classified work) and **applications** (approved mission and security applications), the system **only loads and runs software from hardware-protected, read-only storage** (read-only media / read-only images).

###### WHY (control requirement)
Security Control SC-34 requires that, for the specified **system parts** and **applications**, the operating environment and applications are **loaded and run only from hardware-protected, read-only storage**. This helps ensure software has not been changed since the read-only image was created, and it reduces the risk of unauthorised or long-lasting tampering.

###### HOW (specific steps/approach)
###### 1) Set up approved lists and the expected “fingerprints” of media
- Keep an authoritative, version-controlled list of:
  - approved OS/hypervisor/VM host component sets for classified work (sc-34_odp.01)
  - approved mission/security applications packaged as read-only images (sc-34_odp.02)
- For each approved image, record unchangeable identifiers used to check it at runtime (for example: image hash, signing certificate thumbprint, and/or measured-boot measurement values). Link these identifiers to the approved read-only media types used in your environment.

###### 2) Lock down the classified host so it cannot be altered at start-up
- Configure the device firmware to use **hardware-backed verified/measured boot** so the system starts only when:
  - the start-up path comes from the **approved hardware-protected read-only media** (or an equivalent one-time programmable (OTP) option), and
  - the verified/measured boot results match the expected values for the authorised OS/hypervisor component set.
- Where supported, fix the start-up order in firmware and prevent classified hosts from starting from writable devices.

###### 3) Build and sign read-only images using a controlled process
- Create the OS/hypervisor and application read-only images using a controlled build process.
- Sign the images when they are created, and produce the information needed to confirm them during operation (hashes/measurements, signing details, and a clear link back to the approved lists).
- Make sure day-to-day handling keeps the read-only media intact from creation through insertion/installation.

###### 4) Allow applications to run only from approved read-only images
- Package mission/security applications into read-only images.
- Configure the application launcher/runtime so it:
  - runs only when the read-only image matches the approved identifiers (hash/signature/measurement), and
  - stops safely (does not run) if the application is not the approved read-only version.

###### 5) Keep evidence for start-up and application execution
- Store and retain records showing:
  - which boot device/media identifier was used,
  - the verified/measured boot results,
  - which authorised OS/hypervisor component set was loaded,
  - which approved application image(s) were executed.
- Send these events to the organisation’s logging and security information and event management (SIEM) platform, and keep them according to policy.

###### WHO
- **Platform/Infrastructure Security Engineer**: sets up and enforces verified/measured boot.
- **Build/Release Engineer**: runs the controlled image build and signing process, and produces the required evidence.
- **System Owner / Authorising Official (or a delegated governance role)**: maintains and approves the sc-34_odp.01 and sc-34_odp.02 allow-lists.
- **Security Operations Centre (SOC) / Monitoring Lead**: ensures audit evidence is collected, linked together, and retained.

###### Acceptance criteria
- Classified hosts **boot successfully only** when start-up comes from the approved hardware-protected read-only media and the verified/measured boot results match the authorised OS/hypervisor component set.
- Approved mission/security applications **run only** when launched from the approved read-only images; attempts to run from writable or unapproved locations must fail safely.
- For every boot and application run, the system produces audit records that include: boot/media identifier, verification/measurement outcome, and the specific approved image identifiers used.
- The sc-34_odp.01 and sc-34_odp.02 allow-lists are up to date, version-controlled, and traceable to the signed/expected image items used at runtime.

###### Actions Required for Compliance

- [ ] Create and approve version-controlled lists of approved items for (1) authorised operating system and hypervisor components (sc-34_odp.01) and (2) approved mission and security applications (sc-34_odp.02).
- [ ] Implement hardware-backed verified and measured boot that only allows the system to start from approved, hardware-enforced read-only storage, and checks that the expected measurements and digital signatures match.
- [ ] Create read-only images of the operating system, hypervisor, and applications using a controlled production process, and digitally sign them when they are created, recording permanent, unchangeable identifiers.
- [ ] Configure the platform’s firmware and software so that if someone tries to start the system or run an application from writable or unauthorised storage media, it will be blocked or will safely fail.
- [ ] Set up the application to start and run only from approved, read-only image identifiers (such as a hash, digital signature, or measurement), and block any unapproved images.
- [ ] Keep and centralise audit records for boot devices or media, verification or measurement results, and the identifiers of executed application images.


---

#### SC-34.1 — No Writable Storage (Enhancement)

This requirement is about ensuring that any computer parts used to handle **Confidential** and **Secret** information cannot save changes to storage in a way that still exists after a restart or a power cut. In everyday terms, it stops a malicious person from placing harmful software or hidden files that would still be present the next time the device starts—an approach attackers commonly use to persist and maintain control.

To meet this expectation, the organisation must:

- Keep a documented list of every component that handles **Confidential** and **Secret** data.
- Configure each component so it has **no persistent writable storage** after a restart or power on/off. This includes both internal storage and removable media such as **Universal Serial Bus (USB)** drives or **Secure Digital (SD)** cards.
- Where removable storage is possible, enforce appropriate access restrictions for mobile or portable use, so persistent writable storage cannot be used.

The organisation must also:

- Document how these controls are enforced.
- Reflect them in system plans and design and configuration records.
- Keep evidence from settings and audit records showing that the actual behaviour matches what is claimed.

##### Enforce stateless, non-persistent storage for in-scope components

- Category: Software
- Priority: Critical

###### WHAT
Set up every **system component that handles Confidential and Secret information** so it uses **no writable storage that remains after the component restarts or after power is turned off and back on**. Achieve this by running workloads from **immutable, read-only system images**, and by making sure any writable areas are either **stored only in memory** or are **explicitly non-persistent and wiped when the system reboots**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **SC-34(1) Enhancement** requires: *“Employ {{ insert: param, sc-34.01_odp }} with no writeable storage that is persistent across component restart or power on/off.”* The organisation-defined parameter **sc-34.01_odp** specifies *“system components to be employed with no writeable storage are defined”* (default: all system components handling Confidential and Secret information). The goal is to prevent malicious persistence by ensuring there is no persistent writable storage.

###### HOW (specific steps/approach)
1. **Identify in-scope components**: Use the official deployment and inventory record to list all components that handle Confidential/Secret information (as defined by sc-34.01_odp).
2. **Make fixed storage non-persistent** (for each in-scope component):
   - Configure the operating system root area and system partitions as **read-only** where supported.
   - Redirect application and runtime writable locations to **memory-only storage** (for example, tmpfs/ramdisk) or to **scratch areas that are cleared every time the system boots**.
   - Ensure logs, caches, and temporary files either:
     - write to **non-persistent** locations, or
     - are sent to **centralised logging and monitoring (telemetry)** services instead of being stored on local persistent disk.
3. **Use immutable deployment artefacts**:
   - Deploy using **golden images / immutable templates** (signed where possible) so changes cannot remain after restarts.
   - Prefer **replace-on-change** (recreate instances/containers from the immutable image) rather than making changes directly in place for in-scope components.
4. **Enforce and check “no persistent writable storage”**:
   - Use configuration-as-code to apply the read-only and wipe-on-boot settings.
   - Add monitoring and detection for attempts to write to locations that should be non-persistent (for example, endpoint or host controls, cloud audit events, or filesystem access denials).
5. **Document enforcement**:
   - Record the technical methods used (read-only root, tmpfs/ramdisk, wipe-on-boot, replace-on-change) in the system security plan and configuration/design records.
   - Keep evidence from configuration baselines and audit logs showing the behaviour across restart and power cycles.

###### WHO
- **System Owner / Application Owner**: confirms the component list and the required Confidential/Secret handling behaviour are correct.
- **Infrastructure/Platform Engineer**: implements immutable images, read-only configuration, and non-persistent writable locations.
- **Security Engineer / Compliance**: checks the evidence, updates the system security plan, and confirms it can be audited.

###### Acceptance criteria (verifiable)
- For each in-scope component (per sc-34.01_odp), after a restart or power cycle there is **no persistence** of files written to the designated writable locations (other than explicitly non-persistent/memory-backed areas).
- The operating system and system partitions are configured as **read-only** (or an equivalent enforcement method), and writable application locations are mapped to **tmpfs/ramdisk or wipe-on-boot scratch**.
- Configuration is managed using **approved baselines/configuration-as-code**, and evidence (baseline outputs plus audit logs) is kept to show enforcement.
- Monitoring and detection are in place to alert on attempts to write to non-persistent locations or on any drift from the approved baseline.

> Note: SC-34(1) also applies to removable storage. This approach focuses on fixed storage and non-persistent behaviour for in-scope components. Handling removable media must be addressed separately through the organisation’s access restrictions for portable/mobile use.

###### Actions Required for Compliance

- [ ] Create and keep up to date the official list of in-scope system components that handle Confidential and Secret information (sc-34.01_odp).
- [ ] Set up the in-scope components so that the operating system and system partitions are read-only, and any locations that need to be writable are redirected to memory-based storage or to temporary scratch space that is cleared when the system boots.
- [ ] Deploy in-scope components from unchangeable, digitally signed golden images or templates, and use “replace on change” rather than updating them in place.
- [ ] Set up “configuration as code” baseline settings to stop changes from drifting over time in the way read-only and non-persistent storage mappings are defined.
- [ ] Set up monitoring and alerts for attempts to write to non-persistent locations and for changes that indicate configuration drift.
- [ ] Update the system security plan and the configuration and design records to document the technical method(s) that prevent data from being kept after a restart or power cycle, and to keep evidence that this has been tested.


---

#### SC-34.2 — Integrity Protection on Read-only Media (Enhancement)

This expectation is about ensuring information is genuine and remains genuine when it is copied onto read-only discs or similar storage, and then keeping tight control of the storage media after it has been written. Without this, someone could change the information before it is recorded, swap the disc for a different one, or reprogram a device that is meant to be read-only. This could cause systems to run altered or malicious content.

To meet this expectation, the organisation must protect the information before it is written so it cannot be changed during preparation, and must stop anyone from substituting or reprogramming the media before it is installed. After recording is complete, the organisation must control the media, check for any signs of tampering or replacement, and take appropriate action if problems are found.

The organisation must also document how these controls are carried out, ensure that named authorised people are responsible for installing and maintaining the media, and keep records and audit information showing that the approach was applied and kept in place.

##### Sign read-only media content and verify at installation with custody control

- Category: Software
- Priority: Critical

###### WHAT
Use cryptographic checks to protect the integrity of files (“artefacts”) written to read-only media (for example, organisation-signed hashes and manifests). Then ensure the media is kept in a tamper-evident way and is checked again after recording and before it is installed or used.

###### WHY (control requirement)
SC-34(2) (Enhancement) requires the organisation to **protect the integrity of information before it is stored on read-only media** and to **control the media after the information has been recorded onto it**. The guidance also expects measures to prevent, detect, and respond to attempts to swap media and reprogram programmable read-only media before installation.

###### HOW (specific approach)
1. **Create a signed content manifest before recording**: For each media “release”, create a manifest that lists a hash for each file (and any required details such as release ID, environment, and intended target). Sign the manifest using a protected signing key (preferably one backed by a hardware security module) and store the signature with the release record.
2. **Link the manifest to the physical media identity**: When recording, give each media unit a unique identifier (serial number, label, or asset tag) and include it in the signed manifest (or create a per-media signature that includes the media identifier). This makes any substitution detectable.
3. **Use a controlled recording process**: Limit who can start recording, require approval before releasing to media, and ensure the recording tool only writes content that matches the signed manifest (including automated pre-recording checks of the hashes and signature).
4. **Use tamper-evident packaging and keep custody records after recording**: Seal the media using tamper-evident packaging and labels, and record every handover (who, when, where, and why) in an auditable workflow system. Keep the media in a controlled area until installation.
5. **Check integrity and media identity at installation/receipt**: On the engineering/build workstation (or installation host), run a verifier that checks the signed manifest, confirms the file hashes match, and verifies the media identifier is the expected one. Record the verification results in the central logging system and security information and event management (SIEM).
6. **If checks fail, quarantine and re-issue**: If verification fails (for example, the signature is invalid, hashes do not match, or the media identifier does not match), quarantine the media, stop installation/use, raise an incident or ticket, and re-issue media through the authorised release process.

###### WHO
- **Release/Build Engineer (or CI/CD Release Manager)**: creates signed manifests and starts the recording workflow.
- **Media Custodian / Configuration Manager**: manages tamper-evident packaging, controlled storage, and custody records.
- **Integrator / System Installer (engineering workstation operator)**: performs verification at installation time and quarantines media if there is a failure.
- **Security/Compliance (or Security Engineering)**: protects the signing key, approves the verification tooling, and reviews audit evidence.

###### Acceptance criteria
- For each media release, a **signed manifest** (including hashes) is created before recording.
- The signed artefact is **cryptographically verified** by the recording process before it is written to the media.
- Each physical media unit has a **unique identifier** that is **cryptographically linked** to the signed manifest.
- After recording, custody handovers are recorded with **timestamps and authorised personnel**, and the media is stored under controlled conditions with tamper-evident packaging.
- At installation/receipt, the verifier performs **signature, hash, and media-identity checks** and produces audit logs.
- If any verification fails, the process **stops installation**, quarantines the media, and starts a controlled re-issue workflow with documented evidence.

###### Actions Required for Compliance

- [ ] Define which read-only media types are included in scope, and identify the locations where checks will be carried out during recording and installation.
- [ ] Add a step to generate a signed content manifest in the release pipeline, using a signing key that is protected by the organisation.
- [ ] Update the recording process so that each physical media identifier (serial number or label) is included in the signed manifest, and require checks before the media is burned.
- [ ] Set up tamper-evident packaging and a custody process that logs every handover of the item, including the identity of the authorised person and the date and time (timestamp).
- [ ] Create and standardise an installation and receipt checker that confirms the signature is valid, verifies file fingerprints (hashes), and checks that the media is the expected identity before it is used.
- [ ] Set up an incident and quarantine process, then update and re-issue the playbook for verification failures. Make sure it runs automatically or through a workflow that is fully auditable and can be independently checked.
- [ ] Connect the verifier and custody records to the organisation’s central logging and security information and event management (SIEM) system, and keep the evidence for audit purposes.


---

### SC-35 — External Malicious Code Identification (Control)

This requirement is about actively checking the outside world for dangerous software and websites before they can harm you. The real-world risk is that harmful code hosted on external sites, or hidden within web content, could be downloaded, opened, or triggered and then spread into your organisation’s systems. This could lead to disruption, loss of data, and financial or reputational damage.

To meet this expectation, the organisation must run automated tools that proactively test external networks, including the Internet, to identify suspicious malicious code and malicious websites. The organisation must also have clear, documented procedures that explain how these checks are carried out, how often they run, what is scanned, and what happens to anything that is flagged.

Any suspicious content found must be handled only in a safely separated, controlled environment (for example, a virtualised sandbox) so it cannot infect production systems.

The organisation must document how the scanning tools are built and configured, keep records of scanning activity and results, include this approach in its security planning, and assign named roles responsible for operating, installing, configuring, and maintaining the capability.

##### Proactive external web probing with sandbox detonation pipeline

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated capability that regularly checks external networks (including the Internet) to find signs of network-based malicious code and malicious websites. Any suspicious content found must be handled only inside a tightly isolated, virtual environment (a “sandbox”) before any further review or use.

###### WHY (control requirement)
Security control **SC-35** requires the organisation to “include system components that proactively seek to identify network-based malicious code or malicious websites.” The guidance also requires isolation measures (commonly using virtualisation) so that any malicious code found and then run does not spread to organisational systems.

###### HOW (specific steps/approach)
1. **Define external checking scope and frequency**: Create a documented plan for what to check (for example, newly observed suspicious domains/URLs, high-risk categories from threat intelligence, brand-impersonation patterns, and controlled test lists). Set a working schedule (for example, hourly/daily) based on risk.
2. **Deploy proactive checking components**: Use an enterprise web threat detection/checking capability (for example, web threat defence with URL checking, threat emulation, or security orchestration that can actively fetch and review external web content). Configure it to look for malicious code indicators, not just respond after incidents.
3. **Isolate analysis using virtualisation**: Process all suspicious items in a dedicated sandbox with strict network controls: deny-by-default outward connections, no access to internal networks, and only the minimum required outbound access to the specific external destinations being checked. Use temporary (short-lived) execution where possible.
4. **Automate the workflow and decision**: Implement an automated process: **check → capture candidate item/URL → sandbox review → decision (malicious/benign/unknown) → triage**. Ensure the checking service cannot directly access internal resources.
5. **Log and keep audit evidence**: Record checking activity (targets, times, outcomes), sandbox activity details (item identifiers, decisions, and sandbox boundary identifiers), and any operator actions. Send relevant events to the **security information and event management (SIEM)** system for auditability.
6. **Operational governance and roles**: Assign named responsibilities for running the checking service, installing/configuring it, and maintaining/updating the detection logic and sandbox rules.

###### WHO (role responsible)
- **Cybersecurity Operations (SOC/Threat Hunting Lead)**: owns the checking scope and frequency, the triage workflow, and how decisions are handled.
- **Security Engineering (Platform/Sandbox Engineer)**: owns the sandbox isolation design, network rules, and pipeline automation.
- **IT/Cloud/Infrastructure Engineering**: ensures the checking and sandbox environments are deployed in approved infrastructure with the required network separation.
- **Information Security Governance**: ensures the capability is included in the system security plan and that evidence retention meets organisational requirements.

###### Acceptance criteria
- The organisation can show that the system components **actively check** external networks/Internet targets on a defined schedule (not only after incidents).
- Any item flagged as suspicious is **processed only in the isolated virtualised sandbox**, with no connection to internal networks.
- Evidence is available showing the checking targets, checking outcomes, sandbox execution records, and triage/decision results.
- Named roles are documented for operating, installing/configuring, and maintaining the capability.
- The capability is included in the relevant system security plan and is managed through the organisation’s standard change-control process.

###### Actions Required for Compliance

- [ ] Document the external probing scope, the criteria used to choose targets, and the probing schedule in an auditable procedure.
- [ ] Set up and deploy an enterprise capability that actively checks external websites and domains for signs of malicious code.
- [ ] Set up a virtual “sandbox” environment that blocks all outgoing connections by default and has no network routes to the organisation’s internal systems.
- [ ] Set up an automated process that takes captured probes, runs them in a safe test environment, records the outcome (verdict), and then routes the results to the security operations centre (SOC) for triage.
- [ ] Connect probe and sandbox execution logs to the security information and event management (SIEM) system, and keep the evidence for audit purposes.
- [ ] Assign specific named responsibilities for operating, installing/configuring, and maintaining the probing and sandbox components.


---

### SC-36 — Distributed Processing and Storage (Control)

This expectation is about not putting all your computing and data in one place. That way, if one site has a problem, your work can continue. Without this, a single site outage, maintenance issue, or other disruption could stop important services and make your information unavailable, which would directly affect day-to-day operations and the people who depend on them.

To meet this requirement, the organisation must spread its main processing components—application servers, the system that runs and manages containers, and scheduled batch job services—across multiple physical locations. It must also spread its storage components—databases, file or object storage, and backup storage—across multiple physical locations. There must be no single location that is the only place where processing or storage can happen.

The organisation must:
- document where each component runs;
- record how the sites are arranged in design and security planning documents;
- keep configuration records that support the multi-location setup;
- assign named responsibilities for running and maintaining each location; and
- ensure contingency plans cover how operations and access to data can continue by using parallel processing and storage at the other locations.

##### Multi-site processing and storage placement with parallel failover

- Category: Software
- Priority: Critical

###### WHAT must be done
Spread the organisation-defined **processing components** (for example, application servers, container orchestration, batch processing services) and **storage components** (for example, databases, object storage, backup storage) across **multiple physical locations**. This must ensure there is no single location that is the only place processing or storage can happen.

###### WHY (control requirement)
Security Control SC-36 requires distributing processing and storage across multiple {{ sc-36_prm_1 }}: {{ sc-36_prm_2 }}. This creates redundancy and overlap, so an attacker has to work harder to disrupt operations, assets, and individuals. It also allows processing and storage to run in parallel.

###### HOW (specific steps/approach)
1. **Define the target locations/domains**: create an official mapping showing at least two physical locations (for example, DC-A and DC-B) for each type of processing component and each type of storage component. This must follow the organisation-defined parameters:
   - Processing components must be distributed across multiple physical locations/domains (sc-36_odp.01 + sc-36_odp.02)
   - Storage components must be distributed across multiple physical locations/domains (sc-36_odp.03 + sc-36_odp.04)
2. **Deploy processing across multiple locations**:
   - Run application servers in both locations.
   - Run container orchestration workers in both locations, and place the orchestration control components in a way that is resilient under the platform’s high-availability model. This ensures processing can continue if one location is unavailable.
   - Run batch processing services in both locations using a coordination method (for example, splitting work into parts, choosing a single leader, or using job ownership rules) to prevent duplicate execution while still enabling parallel processing.
3. **Deploy storage across multiple locations**:
   - Set up database replication so the database service can be accessed from both locations, using the selected availability and consistency approach.
   - Set up object storage replication and cross-site availability.
   - Set up backup storage targets in at least two physical locations, and ensure restores can be carried out using the secondary location.
4. **Ensure enough capacity in parallel and avoid “single-primary” assumptions**:
   - Use health-aware routing and load balancing so workloads can run in parallel across locations.
   - Confirm that if one location is down, the remaining location(s) can continue processing and still provide access to the replicated storage.
5. **Produce audit-ready evidence and documentation**:
   - Keep system design/architecture/security plans and configuration records that clearly show the component-to-location mapping and the multi-location arrangement.
   - Keep configuration records (for example, infrastructure-as-code outputs, deployment manifests, and placement constraints) showing that the required distribution is enforced.
6. **Assign named operational responsibilities and test contingency**:
   - Assign named owners for each location’s processing and storage components.
   - Update and test contingency and disaster recovery procedures to show the service can continue through parallel processing and storage at the other location(s).

###### WHO (role responsible)
- **Solution/Platform Architect**: defines the component-to-location mapping and the target architecture.
- **Infrastructure/Cloud Engineer**: implements multi-site deployment, replication, and placement constraints.
- **Application Owner / DevOps Lead**: ensures batch job coordination and workload partitioning.
- **DR/Business Continuity Manager**: ensures contingency procedures and tests match the multi-site design.
- **Security/Compliance Lead**: checks that documentation and audit evidence are sufficient.

###### Acceptance criteria
- Processing components are deployed so they can run from **multiple physical locations** (there is no single location that is the only execution point).
- Storage components are deployed so data access and use can continue using **replicated/cross-site** storage from **multiple physical locations**.
- Batch processing can run with parallel capacity across locations without duplicate job execution.
- Backup storage exists in at least two physical locations, and a restore test confirms recovery using the secondary location.
- System design/security/configuration records clearly show the distribution of processing and storage components to the defined physical locations/domains.
- A tested contingency scenario shows continued processing and data access when one location is unavailable.

###### Actions Required for Compliance

- [ ] Define and document which system components process and store data at each physical location, covering processing (sc-36_odp.01) and storage (sc-36_odp.03) across multiple locations (sc-36_odp.02, sc-36_odp.04).
- [ ] Set up application servers and container orchestration workers in at least two separate physical locations, and control where they run using infrastructure-as-code.
- [ ] Set up batch processing so it can run at the same time across different locations, using job splitting (partitioning/sharding) or a single “leader” process (leader election) to prevent the same job running more than once.
- [ ] Set up database and object storage replication and cross-site availability, so storage can be accessed from multiple locations without relying on a single primary site.
- [ ] Set up backup storage in more than one physical location, and test restoring data from the secondary location.
- [ ] Update the system design, architecture, security plan, and configuration records to show that the system is set up to work across multiple locations and to process and store data in parallel (at the same time).
- [ ] Assign specific operational responsibilities for each location, and run a contingency test to show that processing and access to data continue when one location is unavailable.


---

#### SC-36.1 — Polling Techniques (Enhancement)

This expectation is about regularly checking that your on-premises systems are still working correctly. It does this by comparing the outputs from multiple copies of the same processing and storage, and acting quickly if they do not match. Without these checks, faults, data errors, or unauthorised changes could go unnoticed, which could result in confidential information being exposed or altered, or services becoming unavailable.

To meet this expectation, the organisation must keep a documented list of the on-premises application servers, databases, and storage clusters that store Confidential and Secret data. It must also have a documented method for periodically comparing results and stored content across the different parts of the system, using a clear decision approach rather than relying on a single component.

The organisation must keep evidence that these checks are carried out. If an inconsistency is found, it must record when it was detected and respond by quarantining the affected nodes or volumes, alerting the security operations centre (SOC), starting incident response, and rolling the affected components back to the last known good state. Records must show what was changed and that normal operation was restored.

##### Quorum polling for DB/storage replicas with automated quarantine

- Category: Software
- Priority: Critical

###### WHAT
Set up automated checks (polling) that compare processing results and/or stored data across distributed processing and storage parts (for example, database replicas and storage cluster volumes). Use a defined voting rule to spot faults, errors, or signs of possible compromise. If the checks show a mismatch, automatically isolate (quarantine) the affected node(s) and/or volume(s), notify the security operations centre (SOC), start incident response, and revert to the last known good state.

###### WHY (control requirement)
The security control requirement SC-36(1) enhancement guidance expects polling to be used to compare distributed components’ results/data, vote on the outcome, and identify potential faults, compromises, or errors. The organisation-defined parameter also requires defined actions when faults, errors, or compromise are identified.

###### HOW (specific steps/approach)
1. **Define the in-scope distributed components**: Keep an authoritative list of on-premises application servers, database clusters, and storage clusters that host Confidential/Secret data. Include replica/node identifiers and volume identifiers (sc-36.01_odp.01).
2. **Define clear, repeatable “consistency signals” for each component type**:
   - Databases: replica state markers (for example, log sequence number (LSN) / global transaction identifier (GTID)) and repeatable integrity checks (for example, sampled page/block hashes, or application-level invariant hashes for specific tables/partitions).
   - Storage: volume snapshot identifiers, sampled block-level hashes, and filesystem/metadata consistency indicators.
3. **Run scheduled polling with standardised handling**: Perform polling on a fixed schedule (and on demand during/after maintenance windows) to collect signals from each distributed member. Standardise the data so time windows and sampling methods align, then produce a comparable result.
4. **Apply a voting rule**: Use a documented decision method (for example, majority/quorum or a ruleset) to determine whether the outcomes match. Record what was used in the vote (member identifiers and signals) and the final decision.
5. **Automate the response when a mismatch is found**: If the vote shows inconsistency, carry out the organisation-defined actions: quarantine the affected nodes/volumes, alert the SOC, start incident response, and revert to the last known good state (sc-36.01_odp.02).
6. **Produce audit-ready evidence**: Keep tamper-evident records for each polling run, including scope, signals collected, the vote result, mismatch details, quarantine/rollback actions, timestamps, and correlation identifiers linking detection to response.

###### WHO
- **Security Architect / Compliance Lead**: Approves the in-scope inventory, the voting rule, and how responses map to findings.
- **Platform/Database Engineer**: Builds the polling collectors and defines the consistency signals.
- **SOC Analyst / Incident Commander**: Receives alerts and confirms incident start and rollback outcomes.
- **Automation/DevOps Engineer**: Builds the orchestration, quarantine/rollback automation, and evidence logging.

###### Acceptance criteria
- Polling runs cover all on-premises distributed components listed in the inventory that host Confidential/Secret data (sc-36.01_odp.01) and produce comparable signals.
- Polling results are decided using a documented voting rule (majority/quorum/ruleset), and the vote inputs and decision are recorded.
- When a mismatch is simulated (for example, induced replica divergence or corrupted sampled hashes), the system quarantines the specific implicated node(s)/volume(s), alerts the SOC, starts incident response, and rolls back to a last known good snapshot/version (sc-36.01_odp.02).
- For each run, evidence is available showing polling execution, any detected inconsistencies, and the response actions taken, with traceable correlation identifiers.

###### Actions Required for Compliance

- [ ] Create and keep an accurate, official list of on-premises distributed processing and storage components that host Confidential or Secret data for polling.
- [ ] Define clear, repeatable “consistency check” signals and the sampling and normalisation rules for each component type (database replicas and storage volumes).
- [ ] Set up scheduled polling to collect signals from each replica, node, and volume, and then calculate comparable representations.
- [ ] Set up a documented voting method (for example, majority, quorum, or a defined ruleset) and make sure that the voting inputs and the final decision are recorded for each run.
- [ ] Set up automated mismatch detection that triggers an automatic response: isolate the affected devices or storage volumes, notify the security operations centre (SOC), and start the incident response process.
- [ ] Set up automated rollback so the system can be returned to the last known good snapshot/version, and record the rollback details using correlation identifiers (correlation IDs).
- [ ] Store tamper-evident audit evidence for each polling run, including the coverage (scope), the signals recorded, the vote result, and the actions taken in response.


---

#### SC-36.2 — Synchronization (Enhancement)

This requirement is about making sure your duplicate company directory—and the information it uses to decide who can log in and what they can do—stays consistent across every data centre. If this is not done, different locations could end up with different user details or permissions. This could cause staff to be incorrectly blocked, allow unauthorised access, or make critical business systems behave differently depending on where they are accessed.

To meet this expectation, the organisation must clearly identify and document exactly what is duplicated (the on-premises directory service and the related login and permission information). It must also describe and document how the synchronisation works, and include this in the system design, architecture, and security planning.

The organisation must configure the systems so synchronisation runs as intended, keep records that show it is working, monitor it over time, and be able to provide evidence that changes made in one data centre appear in the others within the organisation’s agreed acceptable timeframes.

##### Synchronise on-prem AD and auth/authorisation data across data centres

- Category: Software
- Priority: Critical

###### WHAT
Set up synchronisation for the duplicate systems/components defined by the organisation: **on-premises Active Directory (AD) and the related authentication and authorisation information across data centres** (for example: users, groups, group memberships, and other AD security identities used to authenticate and authorise access).

###### WHY (control requirement)
NIST **SC-36(2) Synchronization (enhancement)** requires the organisation to **synchronise the duplicate systems or system components** defined in **param sc-36.02_odp**. The guidance explains that synchronising duplicated and redundant services and data helps ensure information in different locations can be used for mission or business needs.

###### HOW (specific steps/approach)
Use **native Active Directory replication** between **authoritative domain controllers (DCs)** deployed in each data centre, and run it with measurable “convergence” targets and evidence suitable for audits.

1. **Define and document the data in scope for synchronisation**: confirm the exact AD objects and security-relevant information that count as “authentication and authorisation data” for the application (at minimum: users, groups, group memberships, and any AD-linked security settings that affect access decisions).
2. **Design multi-site AD replication**: configure **Active Directory Sites and Subnets** to match the data centre network layout; ensure replication connections and schedules are aligned with the required timing.
3. **Standardise authoritative DC deployment for each data centre**: make sure each data centre has resilient coverage of domain controllers (document compensating controls if a domain controller cannot be deployed).
4. **Ensure consistent replication prerequisites**: standardise time settings (Network Time Protocol (NTP)), Domain Name System (DNS) configuration, and domain controller baseline settings across sites; manage changes through controlled processes.
5. **Set and measure an acceptable convergence window**: agree an organisation-approved timing target for how quickly changes (for example, updates to group membership) must appear across data centres under normal conditions.
6. **Implement monitoring and keep evidence**: collect Active Directory replication health and error information (for example, replication status and queue, failures, and indicators of objects that have not fully replicated) into the **security information and event management (SIEM)** or monitoring platform; keep logs long enough to show synchronisation is ongoing.
7. **Test using controlled changes**: carry out periodic, documented tests by making controlled changes in one data centre (for example, add or remove a user from a group) and confirming the change is visible in the other data centre(s) within the acceptable convergence window.

###### WHO
- **Identity and Directory Services Engineer**: designs the replication layout, domain controller deployment, and replication configuration.
- **Security Operations / Security Operations Centre (SOC)**: monitors replication health alerts and retains evidence in the SIEM.
- **Application Owner / Identity and Access Management (IAM) Owner**: confirms the in-scope authentication and authorisation data and validates access-impact tests.
- **Change Manager**: ensures replication-related changes follow change control.

###### Acceptance criteria
- Active Directory replication is configured and working between data centres for the in-scope duplicate components (Active Directory and security identities used for authentication and authorisation).
- Evidence exists showing replication health monitoring is active (alerts and/or logs) and is retained.
- A documented acceptable convergence window is defined, and periodic tests show that authentication and authorisation-relevant changes converge within that window.
- The organisation can provide audit evidence that changes made in one data centre are reflected in the others within the agreed timing for the defined in-scope data.

###### Actions Required for Compliance

- [ ] Confirm and record the exact Active Directory (AD) objects and security-relevant information that make up the organisation-defined “authentication and authorisation data” for sc-36.02_odp.
- [ ] Set up Active Directory (AD) sites and subnets, and define the replication layout so that each data centre has its own authorised domain controllers (DCs) that take part in replication.
- [ ] Standardise the requirements for data replication across all participating data centres, including time synchronisation (Network Time Protocol (NTP)), Domain Name System (DNS) settings, and a baseline configuration for domain controllers (DCs).
- [ ] Set an acceptable time window for when authentication and authorisation changes must take effect, and document how you will measure it.
- [ ] Set up and centralise monitoring of Active Directory (AD) replication health and failures in the security information and event management (SIEM) and monitoring platform, with alerts.
- [ ] Keep records of replication health and related event evidence for audit purposes, with access restricted to authorised users.
- [ ] Carry out regular, controlled checks to confirm system updates settle as expected (for example, changes to group membership), and record the results showing that the system settles within the agreed acceptable time window.


---

### SC-37 — Out-of-band Channels (Control)

This requirement is about ensuring that the most sensitive items needed to run and update your on-premises systems are delivered using safe, separate routes rather than the usual everyday computer connections. Without this, someone could intercept or alter items such as secret keys, login details, security updates, or system update packages while they are being sent over normal working networks. This could lead to unauthorised access or harmful changes.

To meet this expectation, the organisation must keep a documented and approved list of “out-of-band” delivery methods and use only options that are physically separate for these items. Specifically, this means using one of the following: physically separate courier delivery, dedicated offline media transfer (for example, an encrypted USB device), or the United States Postal Service.

The organisation must send these items only to named, authorised system owners and designated receiving custodians for each on-premises system. It must also keep clear records of what was sent, to whom, and when, and maintain written procedures and supporting documentation (including system plans and design notes) that show how these separate delivery routes are used and who is responsible.

##### Out-of-band delivery register with authorised recipients and evidence

- Category: Manual
- Priority: Critical

###### WHAT
Set up and run an organisation-controlled “out-of-band” delivery process that uses **only approved out-of-band channels** to deliver or transmit the defined in-scope items (cryptographic keys/key-management information, authenticators/credentials, security updates, and configuration change packages) from dispatchers to **authorised system owners and designated receiving custodians**.

###### WHY (control requirement)
SC-37 requires: “Employ the following out-of-band channels for the physical delivery or electronic transmission of {{ sc-37_odp.02 }} to {{ sc-37_odp.03 }}: {{ sc-37_odp.01 }}.” This means the organisation must ensure sensitive items are sent using **physically separate channels** and only to **authorised recipients**, with evidence that can be checked later to show delivery and receipt.

###### HOW (specific steps/approach)
1. **Define the approved out-of-band channel list** exactly as: (a) physically separate courier delivery, (b) dedicated offline media transfer (for example, encrypted USB), and (c) United States Postal Service.
2. **Create an in-scope item matrix** that links each item type to the required out-of-band channel(s): cryptographic keys/key-management information, authenticators/credentials, security updates, and configuration change packages.
3. **Maintain an authorised recipient list for each on-premises system**: record the authorised system owner(s) and designated receiving custodian(s) who are allowed to receive in-scope items.
4. **Use a tamper-evident chain-of-custody and evidence approach for each channel**:
   - Courier: require a waybill/tracking number plus a signed receipt from the recipient.
   - Postal: require a tracking number plus a signed receipt from the recipient.
   - Offline media: require logging the media serial number, secure handling of the encrypted media, and an issue/return/disposal record signed by the custodian.
5. **Prevent “in-band” alternatives in day-to-day operations** for in-scope items by requiring dispatchers to choose the delivery method from the approved list and the recipient from the authorised list; any exceptions must be rejected and escalated.
6. **Keep records** (delivery request, dispatch evidence, receipt evidence, and any return/disposal evidence) in a controlled repository so they can be audited.

###### WHO
- **Information Security / Compliance lead**: owns the SC-37 process, approves the channel list and item matrix.
- **System owners**: approve authorised recipients and confirm the system-specific receiving custodians.
- **Receiving custodians / IT operations**: confirm receipt, sign the chain-of-custody evidence, and manage offline media return/disposal.
- **Change/release managers or designated dispatchers**: carry out deliveries using the approved channels and complete the evidence capture.

###### Acceptance criteria
- The organisation has an approved, documented list of out-of-band channels that matches **sc-37_odp.01**.
- The organisation has a documented mapping of in-scope items matching **sc-37_odp.02** to out-of-band channels.
- For at least one recent delivery for each channel type, evidence exists showing:
  - the item type was in-scope,
  - the delivery method used was one of the approved out-of-band channels,
  - the recipient was an authorised system owner or designated receiving custodian matching **sc-37_odp.03**, and
  - dispatch and receipt/return/disposal records are complete and retained.

###### Actions Required for Compliance

- [ ] Approve and publish the list of out-of-band communication channels: use a physically separate courier, dedicated encrypted offline storage media, and the United States Postal Service.
- [ ] Create an in-scope item matrix covering cryptographic keys and key-management information, authenticators and credentials, security updates, and configuration change packages.
- [ ] Maintain an approved list of recipients for each on-premises system (the authorised system owners and the named people responsible for receiving and handling the data).
- [ ] Define and document the evidence-handling requirements for courier services, postal services, and encrypted offline storage media. This includes recording serial numbers, tracking each item’s issue, return, and disposal, and keeping signed receipts.
- [ ] Add a delivery request and check step that requires dispatchers to choose only approved delivery channels and only authorised recipients for items that are in scope.
- [ ] Keep proof of delivery and receipt in a secure, controlled system for audit purposes, including tracking numbers and signed records showing who had custody of the item.


---

#### SC-37.1 — Ensure Delivery and Transmission (Enhancement)

This requirement ensures that sensitive items are delivered only to the correct people and the correct systems. Without it, confidential and highly restricted information, approved software or firmware updates, and authorised equipment could be given to the wrong recipient, intercepted, or installed by unauthorised staff. This could lead to data exposure, disruption to operations, or malicious tampering.

To meet this expectation, the organisation must use an approved courier service for these deliveries. The courier must check the recipient’s government-issued photographic identification and only hand over the items after the required checks are completed.

The organisation must also make sure deliveries are limited to authorised, security-cleared personnel and the designated owners of the specific receiving information system or operational technology network. The courier must deliver the correct items to the correct receiving system or network.

The organisation must keep delivery records that show the approved courier was used and that the identification and handover checks were carried out.

##### Approved courier ID-verified handoff for confidential and OT/IT items

- Category: Manual
- Priority: Critical

###### WHAT
Set up an approved courier delivery process that ensures only the intended, authorised recipients receive the specified items (confidential/Secret data, approved software/firmware updates, and authorised operational technology (OT)/information technology (IT) components) through a controlled handover.

###### WHY (control requirement)
Security control SC-37(1) requires using the organisation’s agreed approach to ensure that only the designated people or systems receive the specified information/system components/devices. The guidance specifically requires an approved courier service, where recipients must show government-issued photographic identification before the delivery can be accepted.

###### HOW (specific steps/approach)
1. **Create and maintain a recipient-to-receiving-system list (registry):** Keep an official list that links each receiving information system and each OT control network to the named system owner(s) and any authorised cleared staff who can accept deliveries on their behalf.
2. **Set delivery scope and where acceptance happens:** For each delivery type (confidential/Secret data, approved updates, authorised components), define the required acceptance location (for example, a controlled reception desk or secure mailroom) and the checks that must be completed at handover.
3. **Require courier ID checks and keep records (in the contract):** Update the courier contract/standard operating procedure (SOP) so the courier must: (a) check government-issued photographic identification, (b) confirm the recipient matches the registry entry for the delivery reference, and (c) only complete the controlled handover after the checks are successful.
4. **Use a delivery reference to prevent wrong deliveries:** Create a unique delivery reference for each shipment and print it on the label/manifest so the courier and the receiving location can confirm the correct recipient-to-receiving-system mapping.
5. **Apply refusal and escalation steps:** At the acceptance point, staff must refuse the handover if ID checks fail or if the recipient is not the designated system owner/authorised cleared personnel for that specific receiving system/OT control network. Escalate to the owning team according to the procedure.
6. **Keep evidence suitable for audit:** Keep courier proof of delivery including: delivery reference, date/time, receiving location, recipient name, result of ID verification, and confirmation that the handover was completed.

###### WHO
- **Information Security / Compliance Lead:** Owns the SC-37(1) process requirements and what evidence must be kept.
- **IT Operations / OT Engineering (System Owners):** Own the recipient-to-receiving-system registry and approve any authorised alternates.
- **Procurement / Vendor Management:** Owns updates to the courier contract/SOP.
- **Controlled Reception Desk / Secure Mailroom Staff:** Carry out the acceptance checks and refusal/escalation.

###### Acceptance criteria
- For every shipment of the defined items, the courier checks government-issued photographic identification and records the result.
- Handover happens only to recipients listed in the registry for the specific receiving system/OT control network linked to the delivery reference.
- Delivery records exist for each shipment showing approved courier use, delivery reference, recipient identity/verification result, and successful handover.
- Wrong deliveries are prevented by refusing/escalating when the recipient mapping or ID verification fails.

###### Actions Required for Compliance

- [ ] Set up and get approval for a recipient register that links each receiving system and operational technology (OT) control network to the named system owner and an authorised backup alternate who has been cleared to act.
- [ ] Define clear acceptance checkpoints and the refusal and escalation steps to follow when identity verification fails or when the recipient details do not match.
- [ ] Update the approved courier contract and standard operating procedure (SOP) to require verification of government-issued photographic identification and an access-controlled handover.
- [ ] Add a unique delivery reference to each label and delivery document, and require courier and receiving staff to check that the delivery reference matches the correct recipient.
- [ ] Train reception and secure mailroom staff on how to verify requests, when to refuse them, and how to escalate concerns
- [ ] Store delivery evidence that can be used for audits—such as the delivery reference, the recipient’s identity, the result of identity checks, the time and location of delivery, and confirmation of handover—in a tamper-evident repository.


---

### SC-38 — Operations Security (Control)

This requirement is about protecting the most sensitive project information while you build, test, and release systems, so it does not reach the wrong people. Without this protection, attackers could learn how your organisation plans to operate, what weaknesses exist, and how your suppliers and testing activities work. That would make it easier for them to interfere with your services, steal information, or disrupt operations.

To meet this expectation, the organisation must use a structured approach throughout the entire build-and-test process: identify which specific information is critical to the organisation’s mission, analyse who might try to access it and what could go wrong, assess the risk of it being disclosed or misused, and then put practical safeguards in place.

This must cover not only internal development and testing, but also information shared with suppliers, potential suppliers, and external testing or evaluation partners. Information sharing must be limited to those who need it.

The organisation must also document who is responsible, keep a plan and a list of safeguards, record the key decisions and risk assessments, track actions until fixes are completed, and ensure relevant staff follow the documented approach.

##### SDLC OPSEC workflow with supplier/test sharing gates

- Category: Manual
- Priority: Critical

###### WHAT
Set up an operations security (OPSEC) process across the full system development life cycle (SDLC) to: (1) identify important organisational information, (2) analyse threats and weaknesses, (3) assess risk, and (4) apply and record safeguards—specifically including how OPSEC-important information is handled when sharing with suppliers, potential suppliers, and testing or evaluation partners.

###### WHY (control requirement)
Security control SC-38 requires the organisation to “employ … operations security controls to protect key organisational information throughout the system development life cycle” (parameter: **sc-38_odp**). The guidance describes OPSEC as a five-step process (important information identification, threat analysis, weakness analysis, risk assessment, safeguards) and explains that OPSEC controls protect confidentiality. This includes limiting sharing with suppliers, potential suppliers, and other parties outside the organisation. It also states that important information includes items such as user identities, how components are used, suppliers, supply chain processes, functional and security requirements, system design specifications, testing or evaluation procedures, and details of how security controls are implemented.

###### HOW (specific approach)
###### 1) Set up OPSEC governance and ownership across the SDLC
- Appoint named roles responsible for running OPSEC (for example: OPSEC owner, security architect, product or system owner, supplier management lead, and test or evaluation lead).
- Create an OPSEC security plan that links the five OPSEC steps to SDLC stages (requirements, design, build, integration, testing or evaluation, deployment or transition).

###### 2) Create an OPSEC-important information register linked to SDLC documents
- Keep a register of OPSEC-important information categories and specific examples for each type of SDLC document. This must include, at minimum, the categories listed in the guidance: user identities, how components are used, suppliers and supply chain processes, functional requirements, security requirements, system design specifications, testing or evaluation procedures, and details of how security controls are implemented.
- For each SDLC document, record: the owner, classification/OPSEC status, handling rules, and whether it can be shared externally.

###### 3) Carry out and record the five OPSEC steps for each relevant SDLC deliverable
- For each deliverable that contains OPSEC-important information, complete an OPSEC assessment record covering:
  - **Important information identification** (what is critical and where it appears)
  - **Threat analysis** (who may try to obtain it and why)
  - **Weakness analysis** (how it could be exposed or misused)
  - **Risk assessment** (likelihood and impact, and the decision made)
  - **Safeguards** (specific protections and any remaining risk)
- Keep evidence in an auditable repository linked to the deliverable or release.

###### 4) Apply sharing controls for suppliers and testing or evaluation partners
- Put clear “only share what is needed” rules in place for sharing OPSEC-important information with:
  - suppliers and potential suppliers (for example: integration steps, supplier access details, supply chain processes)
  - testing or evaluation partners (for example: test procedures, security control implementation details, details of the evaluation environment)
- Require an OPSEC approval checkpoint before any external sharing happens, including:
  - the documented purpose of the sharing
  - an approved list of recipients
  - rules for sharing only the minimum necessary information and redacting what is not needed
  - contractual and technical controls for how information is handled, and how it is returned or destroyed

###### 5) Track remediation and keep closure evidence
- If any OPSEC gaps are identified during threat, weakness, or risk analysis, create remediation actions and track them to completion (for example, using the organisation’s ticketing and remediation workflow), and keep evidence that the issue was closed.

###### WHO
- **OPSEC owner / Security governance lead**: maintains the OPSEC security plan and register; ensures assessments are completed.
- **System or product owner**: ensures deliverables are assessed and OPSEC requirements are met.
- **Security architect**: carries out or verifies threat and weakness analysis and selects safeguards.
- **Supplier management lead**: controls sharing with suppliers and potential suppliers.
- **Test or evaluation lead**: controls handling of testing or evaluation procedures.
- **Release manager / Change manager**: ensures SDLC gates prevent release or testing progression without the required OPSEC approvals.

###### Acceptance criteria
- An OPSEC security plan exists and links the five OPSEC steps to SDLC stages.
- An OPSEC-important information register exists with specific examples linked to SDLC document types (including testing or evaluation procedures and security control implementation details).
- For each SDLC deliverable that contains OPSEC-important information, an OPSEC assessment record exists covering important information identification, threat analysis, weakness analysis, risk assessment, and safeguards.
- Sharing of OPSEC-important information with suppliers, potential suppliers, and testing or evaluation partners is blocked unless an OPSEC approval checkpoint is completed and documented.
- Remediation actions resulting from OPSEC risk decisions are tracked to closure with auditable evidence.

###### Actions Required for Compliance

- [ ] Appoint named operational security (OPSEC) roles and publish an operational security (OPSEC) plan that maps the five OPSEC steps to each phase of the software development life cycle (SDLC).
- [ ] Create and keep up to date an operations security (OPSEC)-critical information register, with clear examples for each software development life cycle (SDLC) document type.
- [ ] Carry out and record operational security (OPSEC) assessments for each deliverable that is relevant to OPSEC, including: identifying critical information, analysing threats, analysing vulnerabilities, assessing risk, and documenting countermeasures.
- [ ] Define and enforce “need-to-know” sharing rules for suppliers (and potential suppliers) and for testing or evaluation partners, including approval checkpoints.
- [ ] Set up a software development lifecycle (SDLC) approval step so that external sharing of operational security (OPSEC)-critical information cannot happen unless there is recorded OPSEC approval.
- [ ] Track operational security (OPSEC) issues to the corrective actions taken, and keep proof that each issue has been closed so it can be checked during audits.


---

### SC-39 — Process Isolation (Control)

This requirement is about keeping each part of a running system in its own protected space. This prevents one software component from interfering with another component’s code or data. Without this separation, a faulty or malicious programme could disrupt other programmes, change what they do, steal or corrupt information, or use one component to spread harm across the system.

To meet this expectation, the organisation must design and build the system so that every running process has its own separate execution environment. Any communication between processes must happen only through approved, controlled routes.

The organisation must document how this separation is achieved in its system design and architecture. It must also keep evidence from independent testing showing that the separation works as intended—specifically, that attempts to interfere with another process are blocked, while authorised communication still works.

Developers and system integrators must implement the isolation measures described. The organisation must keep the supporting records showing that the approach is enabled and applied to the relevant processes.

##### OS-enforced per-process isolation with controlled IPC

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up operating-system (OS) protections so that each running system process has its own separate execution space (distinct address space). This ensures one process cannot change another process’s code or data. Make sure all communication between processes happens only through clearly defined, security-controlled interfaces (for example: authenticated network connections, message brokers, or OS communication objects with strict access-control lists).

###### WHY (control requirement)
SC-39 requires keeping a separate execution space for each running system process. This is usually done by giving each process its own address space and ensuring process-to-process communication is controlled by security checks, so one process cannot modify the running code of another.

###### HOW (specific steps/approach)
1. **Standardise a hardened OS baseline** across all application hosts (cloud virtual machines, on-prem servers, or container hosts). This baseline must enforce memory protection features (for example: NX/DEP, address space layout randomisation (ASLR)) and disable or limit debugging and cross-process inspection where feasible.
2. **Run each application component as a separate OS process identity** (for example, a dedicated service account or a separate container process) using the least privileges possible. Ensure processes cannot attach to, read, or write to other processes’ memory (for example, using OS security policy and capability restrictions).
3. **Enforce process separation using the platform’s built-in isolation features**:
   - **For virtual machines/hosts**: rely on OS address-space isolation plus OS security policy and capability controls.
   - **For containers**: ensure each container has its own process namespace and runs with restricted privileges (no privileged containers; restrict kernel capabilities; prevent access to processes in other containers).
4. **Limit inter-process communication (IPC) to approved security-controlled channels only**:
   - Replace any informal shared-memory or unauthorised IPC methods with authenticated and authorised approaches (for example: TLS-encrypted network connections, authenticated message broker topics/queues, or OS IPC objects with strict access-control lists).
   - Add authorisation checks at the IPC endpoints (for example, service-to-service identity using enterprise identity and access management (IAM) service accounts).
5. **Document the isolation design** in the system architecture/design records: show which isolation mechanism applies to each running process (address-space boundary and/or container boundary), and list the allowed IPC methods and authorisation rules.
6. **Provide independent, auditable testing evidence**:
   - Run negative tests that try to tamper across processes (for example, attach-like actions, memory write attempts, unauthorised IPC calls) and confirm these are blocked.
   - Run positive tests to confirm that authorised IPC still works.
   - Keep independent test reports with objective details (method, expected outcome, actual outcome).

###### WHO (role responsible)
- **Infrastructure/Platform Security Engineer**: defines and implements the hardened OS/container host baseline and isolation policy.
- **Application Security/Architect**: ensures application components are deployed as separate processes/identities and that IPC uses only approved security-controlled interfaces.
- **DevOps/Release Engineering**: uses configuration-as-code and ensures consistent deployment across environments.
- **Independent Test/Assurance (IV&V) function**: runs tampering and IPC tests and produces evidence.

###### Acceptance criteria
- For every running process/component in the production deployment, there is a documented isolation boundary (distinct address space and/or container/process namespace isolation) enforced by the platform.
- Attempts to change another process’s code/data (or attach to another process’s memory) are blocked by OS/container security controls, with retained test evidence.
- All IPC between processes happens only through approved, security-controlled interfaces with enforced authorisation, and authorised IPC succeeds in positive tests.
- Architecture/design documentation and independent test reports are available for audit.

###### Actions Required for Compliance

- [ ] Define and publish a more secure operating system (OS) and container host baseline that enables memory protection and limits attempts to inspect or attach to other processes.
- [ ] Deploy each application component as its own operating system identity (for example, a service account or a non-privileged container process) and give it the minimum permissions needed (least privilege).
- [ ] Set operating system and container security rules (for example, mandatory access control and capability restrictions) so that one process cannot read, write to, or attach to another process’s memory.
- [ ] Refactor inter-process communication so that all process-to-process data sharing uses approved secure communication channels, with authentication and authorisation checks.
- [ ] Create and keep an architecture record that links each running process to the way it is isolated and the inter-process communication (IPC) routes it is allowed to use.
- [ ] Run independent tests to check for unauthorised tampering (including attempts to attach to another process, write to memory, and use unauthorised inter-process communication) and keep evidence that is ready for audit.
- [ ] Run independent positive inter-process communication (IPC) tests to confirm that authorised communication still works.


---

#### SC-39.1 — Hardware Separation (Enhancement)

This requirement is about using built-in computer hardware safeguards to keep different system tasks separate, so one task cannot easily interfere with or reveal information from another. Without this, a problem in one part of the system could spread, allowing attackers or faults to move between tasks and potentially access sensitive information or disrupt services.

To meet this expectation, the organisation must:
- choose the specific hardware separation features it will rely on (for example, hardware memory management);
- include that choice in its security policy;
- clearly describe it in the system’s design and overall architecture.

The organisation must also make sure the system is configured so those safeguards are enabled and working as intended, and must keep records of the settings.

Finally, the organisation must keep supplier documentation that supports the selected features, and must retain independent verification evidence showing that the separation has been implemented correctly and is effective. The same features must be referenced consistently across the security policy, design, configuration records, and verification reports.

##### Enable hardware-enforced process isolation on managed compute

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up and enforce hardware-based separation controls (for example, hardware memory management features used by the hypervisor/host) so that system processes/workloads are kept apart by hardware enforcement, rather than relying only on software settings and intentions.

###### WHY (control requirement)
SC-39(1) Enhancement requires using hardware-based separation controls to support process isolation. The guidance notes that hardware-based separation is generally harder to undermine than software-based separation, and gives hardware memory management as an example.

###### HOW (specific steps/approach)
1. **Choose and standardise the hardware separation control(s)** that will provide process isolation for the organisation’s computing platform (for example, CPU virtualisation features and hardware-assisted memory translation features used by the hypervisor). Record the exact vendor feature names and where enforcement happens (host firmware/hypervisor).
2. **Define the separation limits** in the system design and security design (for example, production workloads separated from administrative tools; separation between different tenants/workloads; separation between security tools and business workloads where relevant).
3. **Configure the computing layer to turn on the selected hardware controls** (BIOS/UEFI/firmware and hypervisor settings) and confirm they are enabled on every approved host/cluster.
4. **Create an auditable “starting point” configuration** for the hardware separation settings (including the expected values) and store it in configuration management with version control.
5. **Gather live proof from running systems** (for example, hypervisor/host configuration outputs, firmware configuration reports, and/or platform tooling outputs that list the enabled hardware isolation features) and compare it with the starting point.
6. **Keep consistent traceability between documents and proof**: update the system security plan, architecture/design documents, and configuration records so the same mechanism name is used consistently from policy/design through to the configuration evidence.
7. **Keep supplier/manufacturer documentation** showing the chosen mechanism(s) and how they are enabled/used, and commission or carry out independent verification (independent verification and validation (IV&V)) to confirm the separation limit is enforced as intended.

###### WHO (role responsible)
- **Infrastructure/Platform Security Engineer**: selects the mechanisms, defines the separation boundaries, and updates the architecture/security plan.
- **Systems/Hypervisor Administrator**: implements and maintains the firmware/hypervisor configuration.
- **Configuration Management Lead**: maintains baselines and the process for collecting evidence.
- **Independent Assessor (internal audit/third party)**: performs IV&V and checks the evidence.

###### Acceptance criteria
- The organisation can show, using live configuration evidence, that the selected hardware separation mechanism(s) are enabled and active on all in-scope hosts/clusters.
- The system security plan/architecture/design documents clearly name the mechanism(s) used for hardware-enforced process isolation, using consistent naming that can be traced to the configuration evidence.
- Supplier/manufacturer documentation is kept and matches the mechanism(s) that are actually enabled.
- Independent verification evidence is available showing the separation mechanism works as intended (for example, proof that the enabled hardware isolation features are present/attested, and confirmation that the enforced isolation behaviour is in place).

###### Actions Required for Compliance

- [ ] Choose and record the exact hardware separation method(s) (including the vendor’s feature names) used to keep processes isolated from each other on the computing platform.
- [ ] Update the system security plan and the overall system design to clearly define the separation boundaries and the enforcement layer (host firmware and hypervisor).
- [ ] Set the selected hardware separation settings in the basic input/output system (BIOS), unified extensible firmware interface (UEFI), firmware, and hypervisor configuration for all in-scope hosts and clusters.
- [ ] Create and keep a version-controlled record of the configuration baseline, including the expected hardware separation setting values.
- [ ] Set up automated evidence collection to export the live host and hypervisor configuration outputs, listing which hardware isolation features are enabled.
- [ ] Carry out independent checks to confirm that the mechanism is switched on and that the separation boundaries are being enforced, and keep the independent verification and validation (IV&V) report.
- [ ] Keep supplier and manufacturer documentation that clearly confirms the selected mechanism(s) and explains how they are enabled.


---

#### SC-39.2 — Separate Execution Domain Per Thread (Enhancement)

This requirement is about ensuring that when your system handles **Confidential** and **Secret** work at the same time, each processing thread runs in its own separate, protected working environment. This prevents threads from accidentally using the same working area. Without this separation, one thread could affect another—potentially mixing data, exposing sensitive information, or producing unreliable results, particularly when different confidentiality levels are handled at the same time.

To meet this expectation, the organisation must clearly define and document how this per-thread separation is achieved for multi-threaded processing of **Confidential** and **Secret** work. It must also keep an up-to-date list of the separate working environments used for each thread, and record the specific system settings that enforce the separation.

The organisation must also keep design and supplier/developer evidence supporting the approach, include it in the system’s security plan, and provide independent test evidence showing that each thread truly runs in its own isolated environment for both **Confidential** and **Secret** workloads.

##### Enforce per-thread execution domains via process-per-worker isolation

- Category: Software
- Priority: Critical

###### WHAT
Set up a separate execution environment for each logical processing thread used to handle **Confidential** and **Secret** workloads in a multi-threaded way.

###### WHY (control requirement)
SC-39(2) enhancement requires: “Maintain a separate execution domain for each thread in {{ insert: param, sc-39.02_odp }}.” Here, {{ sc-39.02_odp }} means “multi-threaded processing handling Confidential and Secret workloads”. The goal is to stop threads from sharing the same execution space, so one thread cannot affect another.

###### HOW (specific approach)
Use a **process-per-logical-thread (worker) model** so each logical thread runs in its own operating-system (OS) enforced execution environment, instead of sharing one shared in-process runtime memory space.

1. **Define the thread-to-domain mapping**
   - Identify each logical thread role used for the **Confidential** and **Secret** workload paths (for example: queue consumer, transformer, enrichment worker).
   - Define a mapping from each logical thread role to a dedicated worker execution unit (OS process/container) and its inter-process communication (IPC) endpoints.

2. **Refactor/configure the runtime to isolate execution per thread**
   - Replace in-process shared-thread execution with a supervisor/dispatcher that starts **one worker process per logical thread role** (or one per thread instance, if roles are created dynamically).
   - Ensure workers do not share writable memory or shared filesystem locations by default; use explicit IPC/message passing with strict message formats.

3. **Enforce isolation at the OS/container layer**
   - Apply per-worker confinement using OS controls suitable for the platform (for example: Linux namespaces and control groups (cgroups) for isolation boundaries; mandatory access control (MAC) such as AppArmor or Security-Enhanced Linux (SELinux); system call filtering such as seccomp).
   - Configure each worker with the minimum permissions needed (use separate service identities where feasible) and an allow-list for IPC endpoints.

4. **Record and keep evidence of the enforcing configuration**
   - Keep an auditable inventory: logical thread role → worker process/container identity → IPC endpoints → confinement profile.
   - Store the configuration materials (supervisor/worker start rules, MAC and seccomp profiles, IPC allow-lists) and link them to the architecture/design documentation.

5. **Include in the system security plan and validate with independent tests**
   - Update the system security plan to explain how separate per-thread execution environments are achieved for **Confidential** and **Secret** workloads.
   - Carry out independent verification by running **Confidential** and **Secret** workloads at the same time and collecting evidence that:
     - each logical thread role maps to a distinct worker execution identity, and
     - IPC boundaries prevent data mixing between threads (for example: attempts to share memory/files are blocked; logs show clear separation).

###### WHO
- **Application architect / lead developer**: implement the process-per-worker model and IPC boundaries.
- **Platform/infrastructure engineer**: implement OS/container confinement (namespaces/cgroups/MAC/seccomp) and worker confinement profiles.
- **Security engineer / compliance lead**: maintain the thread-to-domain inventory, update the system security plan, and coordinate independent verification and validation (IV&V).

###### Acceptance criteria
- For **Confidential** and **Secret** multi-threaded processing, each logical thread role runs in a distinct OS-enforced execution environment (no shared in-process runtime execution space).
- A maintained inventory exists mapping each logical thread role to its execution environment identity and IPC endpoints.
- Confinement configuration (start rules + MAC/seccomp/IPC allow-lists) is documented and retained as evidence.
- The system security plan references SC-39(2) implementation and enforcement evidence.
- Independent tests show concurrent **Confidential/Secret** processing without cross-thread data mixing, with logs showing distinct worker identities per thread role.

###### Actions Required for Compliance

- [ ] Identify all logical thread roles used for the Confidential and Secret workload paths, and define the intended mapping between each thread role and its domain.
- [ ] Change the runtime so that each logical “thread role” runs in its own dedicated worker process (or an equivalent execution unit), instead of sharing multiple roles within the same in-process threads.
- [ ] Set up strict inter-process communication (IPC) and message passing, with checks that every message matches the expected format (schema validation). Also remove or disable any shared writable memory and prevent workers from writing to the default shared filesystem.
- [ ] Apply operating system and container confinement for each worker (using isolation features such as namespaces and control groups, plus mandatory access control and restricted system-call permissions) and enforce least privilege for each worker.
- [ ] Create and keep an auditable record that maps each logical thread role to the worker’s identity, its confinement profile, and its inter-process communication (IPC) endpoints.
- [ ] Update the system security plan to include the per-thread execution domain design, the configuration settings, and where the supporting evidence is stored.
- [ ] Run independent, simultaneous tests for Confidential and Secret data, and collect evidence that each thread’s role runs in its own separate execution environment and that data cannot be mixed between threads.


---

### SC-40 — Wireless Link Protection (Control)

This requirement is about keeping your Wi‑Fi, mobile and Bluetooth connections safe from people who try to interfere with the radio signals or pretend to be something they are not. Without this, an attacker could disrupt service (for example by jamming signals or forcing devices off the network), trick devices into connecting to unauthorised networks, reuse old messages to impersonate users, or listen in to capture sensitive information—especially for connections that can be reached from outside your controlled sites.

To meet this expectation, the organisation must keep an up-to-date, approved list of every wireless connection it uses, both external and internal. It must clearly show which connections are accessible from outside and which are only available inside controlled facilities and operational areas, and it must document which types of signal attacks it needs to defend against.

The organisation must also have written procedures and assigned responsibilities for putting these protections in place and keeping them maintained. It must document the wireless design and the configuration settings used, include this approach in its security planning and policies, and keep audit records showing the protections are working and that wireless incidents are investigated and handled appropriately.

##### Wireless link protections via per-link security baselines

- Category: Software
- Priority: Critical

###### WHAT
Set up and keep in place technical protections for every in-scope **external and internal** wireless connection (Wi‑Fi, cellular, and Bluetooth). This is to protect the system against the organisation-defined **signal parameter attacks** (jamming, spoofing, replay, rogue access points, deauthentication/disassociation, and signal interception).

###### WHY (control requirement)
Security control SC-40 requires: **“Protect external and internal {{sc-40_prm_1}} from … {{sc-40_prm_2}}.”** Wireless connections that can be seen by unauthorised people are especially at risk. Without suitable protections, attackers can disrupt services, pretend to be legitimate users, replay communications, or intercept signals.

###### HOW (specific approach)
1. **Create a list of wireless connections by link** covering all in-scope external and internal wireless connections, and match each connection to the required attack coverage:
   - External links: jamming, rogue access points, deauthentication/disassociation, replay, interception.
   - Internal links: spoofing, replay, deauthentication/disassociation, interception.
2. **Standardise the security settings for each wireless type** and enforce them centrally (for example: a wireless network controller, mobile device management (MDM)/unified endpoint management (UEM), and cellular router configuration management):
   - **Wi‑Fi (external + internal):**
     - Require enterprise authentication (for example, WPA2‑Enterprise/WPA3‑Enterprise with 802.1X) and turn off old or insecure connection methods.
     - Use modern encryption settings and enable protected management message support where available.
     - Turn on and check replay protection at the wireless security layer (as supported by the chosen Wi‑Fi security method), and ensure there is no fallback to weaker security.
   - **Rogue access point controls (external Wi‑Fi):**
     - Turn on controller-based rogue access point detection and set up automated alerting/containment steps (for example: alert the security operations centre (SOC), and quarantine the relevant service identifier (SSID)/virtual local area network (VLAN) mapping where supported).
   - **Resilience to deauthentication/disassociation:**
     - Configure client and access point settings to reduce vulnerability (for example: disable insecure roaming behaviour, keep stable SSID/VLAN mapping, and ensure quick re-authentication using strong credentials).
     - Send relevant wireless events (authentication failures, spikes in deauth/disassoc activity, rogue access point alerts) to monitoring.
   - **Bluetooth (internal):**
     - Allow pairing/bonding only with managed/authorised devices; disable or limit discoverable/open pairing modes.
     - Require encryption for bonded connections and block unauthorised pairing attempts.
   - **Cellular (external):**
     - For cellular routers/modems reachable from outside, require strong device authentication to the network (SIM/eSIM controls, APN restrictions) and protect data end-to-end at the application/session level (for example, transport layer security (TLS)) to reduce interception and replay risks.
3. **Run the security settings as an ongoing operation using change control, drift detection, and evidence:**
   - Keep wireless security baselines as version-controlled templates.
   - Regularly check that the deployed settings match the baselines (configuration compliance checks) and alert if they change.
   - Keep audit evidence showing protections are enabled for each in-scope connection and that relevant wireless security events are recorded.

###### WHO
- **Network Security Engineer / Wireless Engineer:** defines and implements the wireless security baselines per connection and the rogue access point detection settings.
- **SOC (Security Operations Centre) / Security Operations:** ensures wireless event monitoring, alert triage, and incident handling processes are in place.
- **Configuration Management Lead:** maintains the version-controlled templates and the drift detection evidence.
- **System Owner / Chief Information Security Officer (CISO) delegate:** approves the scope of the connection list and the mapping of attack coverage.

###### Acceptance criteria
- There is a current, auditable list of all in-scope **external and internal** wireless connections (Wi‑Fi/cellular/Bluetooth), and each connection is mapped to the required attack types.
- For every in-scope connection, the deployed configuration matches the approved baseline (no insecure/legacy wireless modes; enterprise authentication enforced for Wi‑Fi; Bluetooth pairing restricted; rogue access point detection enabled for external Wi‑Fi).
- Wireless security events relevant to SC-40 (for example, rogue access point detections, authentication failures, deauth/disassoc anomalies, and interception indicators where available) are logged and sent to monitoring/security information and event management (SIEM).
- Any configuration changes that cause drift are detected and corrected through change control, with evidence retained for audit.

###### Actions Required for Compliance

- [ ] Build and maintain an auditable record (inventory) of all in-scope external and internal Wi‑Fi, cellular, and Bluetooth connections, and label each one as either external or internal.
- [ ] Define and publish wireless security baseline requirements for each technology. These requirements must clearly cover the specific threats we need to defend against: jamming, spoofing, replay attacks, rogue access points, deauthentication and disassociation attacks, and interception.
- [ ] Set up the organisation’s Wi‑Fi networks (both external and internal) to require enterprise authentication (for example, Wi‑Fi Protected Access 2 Enterprise (WPA2‑Enterprise) or Wi‑Fi Protected Access 3 Enterprise (WPA3‑Enterprise)), and turn off insecure or older connection methods.
- [ ] Set up and test detection and alerts for unauthorised “rogue” Wi‑Fi access points connected to external networks, and put in place containment and response steps where the system supports them.
- [ ] Make Bluetooth more secure by allowing pairing and bonding only with managed and authorised devices, and by requiring encryption at the link level for any bonded connections.
- [ ] Set up cellular edge devices (routers or modems) so they can only access approved network services (using restricted APN settings), and make sure application and session data is encrypted in transit (for example, using Transport Layer Security (TLS)) to reduce the risk of interception and replay attacks.
- [ ] Set up detection of changes (configuration drift) in wireless baseline settings, and send wireless security alerts to the security information and event management (SIEM) system and security operations centre (SOC) so they can be monitored and investigated.


---

#### SC-40.1 — Electromagnetic Interference (Enhancement)

This requirement is about keeping your anti-jamming wireless connections working even if someone deliberately tries to disrupt them by transmitting interfering radio signals. If you do not use strong, carefully selected protection, an attacker could work out how your anti-jamming behaviour works, predict it, and then interfere in a way that blocks or reduces the quality of communications.

To meet this requirement, the organisation must:

- First, identify which wireless connections are intended to resist jamming.
- Then apply high-assurance cryptographic protections to those specific connections, so the anti-jamming behaviour cannot be predicted by unauthorised people.
- Make sure these protections are actually enabled for the wireless connection behaviour, rather than being left as a general, unused setting.

The approach must be documented in the wireless link protection procedures and system design, including clear diagrams, recorded configuration and architecture details, and the names of staff responsible for implementing, maintaining, and authorising the protected connections.

Finally, the organisation must keep audit evidence showing the protections remain enabled and operating as intended, including evidence that unauthorised attempts cannot join or make sense of the protected communications.

##### High-assurance crypto for anti-jam spread-spectrum links

- Category: Software
- Priority: Critical

###### WHAT must be done
Put in place cryptographic (encryption and authentication) protections for the organisation-approved wireless anti-jam spread-spectrum links, so that the anti-jam behaviour (for example, channel hopping or pattern selection and the related timing/settings) cannot be predicted by unauthorised people.

###### WHY (control requirement)
NIST SC-40(1) enhancement requires: “Implement cryptographic mechanisms that achieve {{ insert: param, sc-40.01_odp }} against the effects of intentional electromagnetic interference.” This guidance explains that the purpose is to protect against deliberate jamming by making sure the anti-jam wireless spread-spectrum signals are not predictable by unauthorised people. The organisation-defined parameter sc-40.01_odp sets the required “level of protection” (here: high assurance cryptographic protection for anti-jam wireless spread-spectrum links).

###### HOW (specific steps/approach)
1. **Define and scope the anti-jam wireless links**: identify which wireless links and endpoints are intended to provide anti-jam protection (in-scope radios, service set identifiers (SSIDs)/links, link modes, and operating environments).
2. **Choose “high assurance” cryptography for anti-jam behaviour**: select cryptographic mechanisms that directly control the anti-jam signal behaviour (for example, cryptographically keyed hopping or pattern selection), not just encryption of the data payload. Map the selected algorithms, key sizes, strength of mutual authentication, and key lifetimes to the organisation’s approved “high assurance” standard.
3. **Require cryptographic anti-jam mode activation**: configure radios and wireless software so anti-jam signal generation uses cryptographic keys and is not left in default, fixed, or unauthenticated modes. Ensure endpoints must mutually authenticate before they can synchronise to the anti-jam signal.
4. **Integrate key management with authenticated distribution and rotation**: use the enterprise key management system and secure key storage so that keys used for anti-jam signal generation are protected, provided only to authorised endpoints, and rotated according to the defined lifetimes. Ensure rekey events are recorded with key identifiers.
5. **Make configuration auditable and tamper-evident**: set configuration baselines and use change control so anti-jam cryptographic settings cannot be silently reduced. Enable device and system audit logs for anti-jam cryptographic mode status, key identifiers, rekey events, and join/authentication outcomes; send logs to security information and event management (SIEM).
6. **Operational verification and acceptance testing**: carry out tests to show that unauthorised devices cannot predict or synchronise to the anti-jam signal (for example, join attempts fail; hopping/pattern settings cannot be worked out without authorised keys; anti-jam remains enabled after configuration changes).

###### WHO (role responsible)
- **Network/Wireless Security Engineer**: designs the anti-jam cryptographic approach and configuration.
- **Key Management/Platform Engineer**: implements and runs key management, key rotation, and secure storage.
- **System/Network Administrator**: applies configuration baselines and ensures deployment to test and production.
- **Security Assurance/Compliance Lead**: checks the evidence, test results, and readiness for audit.

###### Acceptance criteria
- All in-scope anti-jam wireless spread-spectrum links are configured so anti-jam signal behaviour is cryptographically controlled and cannot be predicted without authorised cryptographic material.
- Endpoints must mutually authenticate to join and synchronise to the anti-jam signal; unauthorised join/synchronisation attempts are rejected and logged.
- Anti-jam cryptographic mode activation and key identifiers/rekey events are recorded in audit logs and available for review in SIEM.
- Configuration baselines and change control prevent unauthorised or accidental downgrades of anti-jam cryptographic protection.
- Test evidence shows unauthorised parties cannot predict or synchronise to the anti-jam signal, and that the anti-jam link continues to operate under intentional interference conditions.

###### Actions Required for Compliance

- [ ] Identify and record all wireless spread-spectrum anti-jamming connections and devices that are in scope, including the anti-jamming mode and settings (parameters).
- [ ] Define the organisation’s “high assurance” encryption requirements for anti-jam waveform behaviour, and match them to approved encryption methods, key lengths, and time periods for using keys.
- [ ] Set up the radios and wireless system so that frequency-hopping and pattern selection, and the generation of anti-jamming waveforms, are protected using cryptographic keys. Also require mutual authentication so the devices can synchronise securely.
- [ ] Integrate anti-jamming waveform keys with the organisation’s key management system and secure key storage, ensuring that keys are only shared after authentication and are rotated on a scheduled basis.
- [ ] Set standard security configurations and use formal change control to prevent any reduction (downgrade) of anti-jamming cryptographic protection, including only allowing changes that are signed off and approved.
- [ ] Set up and centralise audit logs in security information and event management (SIEM) for anti-jam crypto mode status, key identifiers, rekey events, and join and authentication results.
- [ ] Run acceptance tests to show that unauthorised devices cannot predict or synchronise to the anti-jamming signal, and that anti-jamming stays switched on after configuration changes.


---

#### SC-40.2 — Reduce Detection Potential (Enhancement)

This requirement is about making certain important wireless messages much harder for outsiders to notice, recognise, or work out—especially for mission-critical covert links where avoiding detection and stopping location tracking are essential. Without strong protections, unauthorised people could intercept the transmissions, work out which devices are communicating, and use patterns in the traffic to track or disrupt operations.

To meet this requirement, the organisation must first clearly identify which wireless links are classed as high risk (mission-critical covert and anti-geo-location wireless links). It must then document the encryption protections it will use to reduce the chance of detection, and ensure those protections are turned on for every such link on both ends of the communication path.

The organisation must also avoid predictable transmission behaviour by not using default or easily guessed settings. It must have a written approach for how encryption keys are handled, restrict who can change that approach, and keep records showing that the protections remain enabled over time. These records should include the design, the network locations, the configuration settings, and evidence such as dated configuration snapshots and authorised change records.

##### End-to-end crypto for high covert/anti-geo wireless links

- Category: Software
- Priority: Critical

###### WHAT must be done
Install cryptographic protections on all **organisation-defined “high (mission-critical covert and anti-geo-location) wireless links”** to reduce their **likelihood of being detected**—that is, to stop unauthorised parties from detecting, identifying, and predicting wireless transmissions (including any transmission behaviours influenced by the cryptography).

###### WHY (control requirement)
The NIST **SC-40(2)** enhancement requires: *“Implement cryptographic mechanisms to reduce the detection potential of wireless links to {{ insert: param, sc-40.02_odp }}.”* This guidance is intended for **covert communications** and to **protect wireless transmitters from geo-location**. It also requires that the chosen approach for reducing detection is **not predictable** by unauthorised individuals.

###### HOW (specific steps/approach)
1. **Define the protected wireless link set**: create and maintain an inventory (for example, a configuration management database (CMDB) plus network diagrams) that labels each wireless link as “high” using the organisation’s parameter **sc-40.02_odp = high (mission-critical covert and anti-geo-location wireless links)**.
2. **Select an approved cryptographic protection approach** for wireless links that provides confidentiality and strong authentication (and, where available, features that help prevent identification). Record the reason this approach meets the required “level of reduction”.
3. **Ensure end-to-end protection is enabled**: configure the wireless network and devices so the cryptographic protections are enabled **on both ends** and across the entire wireless route for every tagged high link (including any bridging, mesh, or relay components).
4. **Remove predictability**: make sure cryptographic settings and key material are not default, not widely shared, not fixed, and not easy to guess. Where possible, use **unique credentials per link and per session**, and enforce **key rotation and revocation**.
5. **Put configuration control and proof in place**: use “configuration as evidence” by producing dated exports or snapshots of the wireless security settings and linking them to authorised change records. Keep evidence showing the protections remain enabled over time.

###### WHO (role responsible)
- **Network Security Engineer / Wireless Architect**: defines the cryptographic protection approach and implements configurations on wireless local area network (WLAN) controllers, access points (APs), mesh systems, and point-to-point radios.
- **Identity and Access Management (IAM) / Public Key Infrastructure (PKI) Administrator (or equivalent)**: issues certificates and credentials and manages the key lifecycle, including rotation.
- **Configuration Manager / Change Manager**: ensures authorised change records and configuration snapshots are created and retained.
- **Security Assurance / Compliance Lead**: checks that the protected link set and the evidence meet SC-40(2) expectations.

###### Acceptance criteria
- Every wireless link tagged as “high (mission-critical covert and anti-geo-location)” has the approved cryptographic protections **enabled and verified** on both ends and across the wireless path.
- The cryptographic configuration is **not based on default settings** and provides **strong authentication**; key material is **unique where feasible** and is subject to **documented rotation and revocation**.
- For each high link, there are dated configuration exports or snapshots and authorised change records showing protections were enabled at the time the evidence was captured and that they have not changed unexpectedly.
- There is a documented mapping from the organisation-defined **sc-40.02_odp “level of reduction”** to the implemented cryptographic protections and the operational key lifecycle controls.

###### Actions Required for Compliance

- [ ] Tag and record all “high (mission-critical covert and anti-geo-location)” wireless links in the configuration management database (CMDB) and in the network diagrams.
- [ ] Define and get approval for a wireless security protection profile that matches the “level of reduction” requirement in sc-40.02_odp.
- [ ] Set up the wireless network and devices so that encryption is enabled from start to finish for every “high” priority link that is tagged.
- [ ] Use unique, non-default login details for each wireless link and each session, and follow the documented process to regularly change (rotate) and cancel (revoke) the wireless encryption keys.
- [ ] Implement configuration-as-evidence by exporting dated wireless security settings and linking them to authorised change records.
- [ ] Carry out regular compliance checks to spot changes from the approved settings (for example, disabled or outdated cryptography modes) and fix them through the organisation’s change-management process.


---

#### SC-40.3 — Imitative or Manipulative Communications Deception (Enhancement)

This requirement is about preventing fake wireless messages from being accepted as genuine. Without it, someone could copy the normal wireless “signals” and trick your systems into treating their device or message as trusted. This could result in unauthorised access or harmful actions.

To meet this expectation, the organisation must use security codes for wireless connections. Each incoming wireless transmission must be checked using these codes, and any deliberate attempts to imitate or interfere with trusted wireless communications must be rejected and not acted upon.

The organisation must also ensure that the verification information cannot be easily guessed by people outside the organisation. It must keep clear records explaining how the wireless protection is designed and which wireless connections it covers, and document the configuration settings that put it in place.

In addition, the organisation must keep audit records showing when rejected attempts occur because the security code checks failed, and include this approach in its system security planning.

##### Cryptographically authenticate wireless links and reject failed frames

- Category: Software
- Priority: Critical

###### WHAT
Implement cryptographic protections for all in-scope wireless transmissions so receiving devices can confirm the sender is genuine and **reject** transmissions that are deliberate attempts to imitate or manipulate communications deception.

###### WHY (control requirement)
SC-40(3) (enhancement) requires cryptographic protections to identify and reject wireless transmissions that are deliberate attempts to achieve imitative or manipulative communications deception based on signal characteristics. The guidance highlights that cryptographic verification reduces the risk that unauthorised people can predict or mimic signal characteristics.

###### HOW (specific steps/approach)
1. **Standardise wireless security using cryptographic link authentication**: For Wi‑Fi, require Wi‑Fi Protected Access 3 Enterprise (WPA3-Enterprise) (preferred) or Wi‑Fi Protected Access 2 Enterprise (WPA2-Enterprise) with **IEEE 802.1X** (Extensible Authentication Protocol—Transport Layer Security (EAP-TLS) or an equivalent strong EAP method). Disable open networks and avoid shared-key or pre-shared key (PSK) modes for in-scope trust zones.
2. **Tie trust to cryptographic credentials, not radio characteristics**: Configure access points and controllers so devices can only connect and exchange data after successful IEEE 802.1X/Extensible Authentication Protocol (EAP) authentication and key setup. Ensure the application or system does not treat communications as “trusted” based on observable signal characteristics.
3. **Reject unauthorised imitative/manipulative attempts using cryptographic failure handling**: Configure the wireless infrastructure to drop frames or traffic when authentication, key setup, or session setup fails. Ensure any application-level acceptance logic (if it exists) only proceeds after a successful cryptographic session is established.
4. **Use credentials that cannot be guessed, managed centrally, with rotation**: Integrate with the organisation’s identity provider and Remote Authentication Dial-In User Service (RADIUS) (or equivalent) to issue per-user/per-device credentials (for example, certificates). Enforce certificate revocation when users or devices leave the organisation and rotate credentials periodically, so attackers cannot reuse predictable “signal-like” characteristics.
5. **Keep audit evidence for rejection events**: Send access point/controller logs (IEEE 802.1X/EAP failures, handshake failures, session rejections) to the security information and event management (SIEM) system. Set up alerts and dashboards for repeated failed authentications from unauthorised device identifiers.
6. **Document the scope and configuration of wireless cryptographic protection**: Maintain an auditable record of which service set identifiers (SSIDs), radios, and links are covered, which cryptographic mechanisms are used, and the configuration baseline (including evidence that insecure modes are disabled).

###### WHO
- **Network/Operational Technology (OT) and Information Technology (IT) wireless engineering lead**: implements and checks WPA3/WPA2-Enterprise and controller/access point configuration.
- **Identity and Access Management (IAM) team**: manages certificate/credential issuing, rotation, and revocation.
- **Security monitoring / Security Operations Centre (SOC)**: ensures logs are sent to the SIEM and that rejection events are monitored.
- **System owner / compliance lead**: ensures documentation and evidence packs are maintained for audits.

###### Acceptance criteria
- All in-scope wireless networks use WPA3-Enterprise or WPA2-Enterprise with IEEE 802.1X; open and shared-key/PSK modes are disabled for those networks.
- Wireless infrastructure allows traffic only after successful cryptographic authentication and session setup.
- If authentication or session setup fails, the system rejects the transmission (no application/service acceptance) and produces auditable logs.
- Credentials are managed through central IAM/RADIUS with per-user/per-device identities and clear, demonstrable rotation and revocation processes.
- The SIEM receives wireless authentication/handshake failure logs and rejection events that can be searched for incident investigation.
- Documentation exists showing coverage (SSIDs, radios, links), cryptographic mechanisms, and configuration baseline evidence.

###### Actions Required for Compliance

- [ ] List all in-scope wireless connections (service set identifiers (SSIDs) and radios) and link each one to the appropriate trust zone and system.
- [ ] For in-scope networks, turn off open Wi‑Fi and shared-key or pre-shared key (PSK) Wi‑Fi modes, and require Wi‑Fi protected access 3 (WPA3) Enterprise or Wi‑Fi protected access 2 (WPA2) Enterprise using 802.1X.
- [ ] Set up access point (AP) and controller rules so network traffic is allowed only after the device proves its identity using cryptographic authentication and a secure session key has been established.
- [ ] Set up IEEE 802.1X with the organisation’s identity provider (IdP) and remote authentication dial-in user service (RADIUS) using credentials for each user and each device (for example, certificate-based extensible authentication protocol transport layer security (EAP-TLS)), and make sure access is cancelled when someone leaves the organisation.
- [ ] Set up and send wireless authentication and handshake failure logs, and session reject logs, to the security information and event management (SIEM) system, including enough identifying details to trace each event to the responsible user or device.
- [ ] Create and keep an auditable record of the agreed configuration baseline and coverage for the wireless cryptographic mechanisms used.


---

#### SC-40.4 — Signal Parameter Identification (Enhancement)

This requirement is about preventing outsiders from identifying and tracking the specific radio transmitters used for classified and confidential United States Department of Defense (DoD) communications. It does this by copying and protecting the transmitters’ unique “signal fingerprints” so that the signal cannot be reliably matched to a particular transmitter.

Without this protection, someone could listen to the radio traffic, measure distinctive features of the signal, and reliably work out which transmitter is being used. This could enable intelligence gathering, tracking, or identifying the mission and users.

To meet this expectation, the organisation must:
- clearly define which wireless transmitters are covered by this protection;
- keep up-to-date diagrams showing where the protection is applied; and
- ensure the system uses cryptographic protections that deliberately change or obscure transmitter signal settings, so unauthorised people cannot predict the resulting behaviour, while still allowing anonymity when it is needed.

The organisation must also:
- document how the protection works;
- record the system design and configuration details that implement it; and
- keep evidence that the settings are enabled and consistent for all covered links.

Any changes must be made only by authorised personnel, with audit and change records. Testing must show that repeated observations do not produce a consistent, reliable way to identify the transmitter.

##### Cryptographic anti-fingerprinting for in-scope wireless transmitters

- Category: Software
- Priority: Critical

###### WHAT
Put cryptographic protections in place on each in-scope wireless transmitter/link so that unauthorised parties cannot reliably identify the transmitter by analysing observable signal characteristics (often called “radio fingerprinting”). The cryptographic design must ensure any changes made to hide signal characteristics are not predictable, and must provide anonymity when required.

###### WHY (control requirement)
SC-40(4) Enhancement requires: “Implement cryptographic mechanisms to prevent the identification of {{ insert: param, sc-40.04_odp }} by using the transmitter signal parameters.” The guidance explains this protects against uniquely identifying wireless transmitters through radio fingerprinting by ensuring the anti-fingerprinting changes are not predictable by unauthorised individuals, and provides anonymity when required.

###### HOW (specific approach)
1. **Define and scope in-scope transmitters**: Create an authoritative inventory of “wireless transmitters used for classified and confidential Department of Defense (DoD) communications” (sc-40.04_odp), mapped to the specific wireless links/radios managed by your controllers (for example, controller-managed access points, radio modules, or dedicated transmitter endpoints). Keep a current network diagram showing where the protection is applied.
2. **Use cryptographic link protections that make observable behaviour non-predictable**: Configure each in-scope wireless link to use the strongest secure wireless options available in your technology stack (for example, Wi-Fi Protected Access 3 (WPA3) Enterprise / WPA3 Personal where applicable, strong encryption settings, and any vendor-supported secure wireless features at the link layer). Ensure the configuration creates per-session/per-packet cryptographic variation where supported, so an observer cannot predict the resulting observable signal characteristics.
3. **Control key management and rekey behaviour**: Configure how encryption keys are created and rotated (rekeyed), including the rotation intervals, so that observable characteristics tied to session activity cannot be kept constant for fingerprinting. Ensure rekeying happens automatically and fits operational constraints.
4. **Baseline and enforce configuration**: Implement configuration baselines (policy-as-code where possible) that lock the cryptographic anti-fingerprinting settings for all in-scope links. Only authorised administrators may change these settings, and changes must be made through controlled change management.
5. **Test effectiveness using controlled capture testing**: Run repeatable, controlled tests (for example, using an authorised spectrum/radio capture setup) to show that repeated observations do not produce a consistent, reliable transmitter identification without access to the cryptographic secrets/keys.
6. **Document the cryptographic mechanism and evidence**: Record the cryptographic approach, which signal characteristics are being protected/obscured by the selected secure wireless options, the configuration details, and evidence that settings are enabled and consistent across all in-scope links.

###### WHO
- **Wireless/Network Engineering Lead**: Implements secure wireless mode and key management configuration.
- **Security Architect / Chief Information Security Officer (CISO) delegate**: Approves the cryptographic approach and the anti-fingerprinting test method.
- **Configuration Management (CM) / Security Operations (SecOps)**: Maintains baselines, enforces change control, and keeps audit evidence.
- **Test/Validation Engineer**: Carries out controlled capture testing and produces results.

###### Acceptance criteria
- All in-scope wireless transmitters/links (sc-40.04_odp) are listed in an authoritative inventory and shown on current network diagrams.
- For every in-scope link, cryptographic link protections are enabled using approved strong encryption settings, with approved key/rekey behaviour configured.
- Controlled testing shows that unauthorised observers cannot reliably identify/fingerprint the transmitter from observable signal characteristics across repeated observations (that is, identification is not consistent/reliable without the cryptographic secrets).
- Configuration evidence (exports/configuration snapshots) and test results are retained, showing settings are consistent across production and relevant environments where in-scope transmitters operate.
- Only authorised personnel can change the cryptographic anti-fingerprinting configuration, and change records are retained.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, official list of all wireless transmitters/links that are in scope for SC-40.04 ODP, and link each item to the current network diagrams.
- [ ] Set up each in-scope wireless connection to use approved secure wireless settings, including strong encryption and cryptographic integrity checks.
- [ ] Set and enforce the key creation and key rekeying/rotation rules to ensure that session-based signal settings are not kept the same.
- [ ] Implement configuration baselines (policy-as-code where possible) to lock the cryptographic anti-tracking settings for all in-scope links.
- [ ] Allow only authorised administrators to change wireless controller or radio encryption settings, and record (log) every change.
- [ ] Run controlled radio recording tests to show that repeated observations do not allow consistent identification of a transmitter unless the cryptographic secrets are available.
- [ ] Document the encryption method, the configuration details, and the test results that show consistent anti-fingerprinting behaviour across all in-scope links.


---

### SC-41 — Port and I/O Device Access (Control)

This requirement is about preventing people from using certain plug-in connections and disc drives to move data into or out of important computers. If USB, Thunderbolt, Firewire (IEEE 1394) ports, or CD/DVD drives are left available, someone could copy confidential information off a system or introduce harmful software by plugging in a device or using a disc.

To meet this requirement, the organisation must keep a documented list of:
- the specific ports and disc drives that must be physically disabled or removed, and
- which systems are covered.

This includes workstations, servers, engineering workstations, and operational technology (OT) control system gateways.

For every covered system, the organisation must physically block or remove these ports and drives (not just change software settings). It must document how the blocking or removal is done, and keep procedures and records showing that the setup matches the actual hardware. Responsibility must be assigned to the people who install and maintain the systems. The organisation must be able to provide evidence through inspections and records, including after any maintenance or hardware changes.

##### Physically block USB/Thunderbolt/Firewire and disable CD/DVD on in-scope hosts

- Category: Manual
- Priority: Critical

###### WHAT
Physically disable or remove the specified **connection ports** (Universal Serial Bus (USB), Thunderbolt, Firewire/Institute of Electrical and Electronics Engineers 1394 (IEEE 1394)) and **input/output devices** (Compact Disc/Digital Versatile Disc (CD/DVD) drives) on the in-scope systems/components: **workstations, servers, engineering workstations, and operational technology (OT) control system gateways**.

###### WHY (control requirement)
Security Control 41 (SC-41) requires the organisation to **“disable or remove”** the defined **connection ports or input/output devices** (**sc-41_odp.01**) on the defined **systems or system components** (**sc-41_odp.03**), using the defined **method** (**sc-41_odp.02 = physically**). The guidance makes clear that **physically disabling/removing ports/devices is the stronger action** to reduce the risk of information being taken out (exfiltration) and malware being introduced through these interfaces.

###### HOW (specific approach)
1. **Create and maintain authoritative inventories**:
   - Keep a documented list of in-scope systems/components (workstations, servers, engineering workstations, OT control system gateways).
   - Keep a documented list of the exact ports/devices to be physically disabled/removed (USB, Thunderbolt, Firewire/IEEE 1394, and CD/DVD drives).
2. **Standardise the physical hardening method**:
   - For USB/Thunderbolt/Firewire: fit tamper-evident **port blockers/covers** or remove/disable the relevant port hardware where feasible.
   - For CD/DVD drives: either **remove the optical drive hardware** or **physically disable/lock** the drive bay so discs cannot be inserted or used.
   - Define how to handle docking stations, port replicators, and external hubs (for example, treat them as separate hardware items that also must be blocked/controlled, or ensure they are not allowed for in-scope hosts).
3. **Apply through lifecycle and change control**:
   - Apply the hardening during imaging/initial deployment and after any hardware replacement/repair.
   - Ensure every maintenance/repair work order for in-scope hosts includes a mandatory **SC-41 physical verification** step before it is closed.
4. **Produce audit-ready evidence**:
   - For each in-scope system, keep a per-device checklist recording:
     - which ports/devices were physically disabled/removed,
     - the method used (blocker type / drive removal or lock method),
     - completion date and technician/approver.
   - Keep evidence such as inspection checklists and, where practical, photos showing blocked port areas and the optical drive bay status.

###### WHO
- **IT Infrastructure / Workplace Engineering Lead**: owns the standard hardening kit and deployment method for workstations/servers.
- **OT Engineering / OT Security Lead**: owns the application of hardening to engineering workstations and OT control system gateways, including coordination of maintenance windows.
- **Service Desk / Field Technicians**: carry out the physical installation/removal and complete the per-device checklist.
- **Configuration Management (CM) / Compliance Team**: maintains inventories and checks that evidence is sufficient for audit.

###### Acceptance criteria
- For every in-scope system in the authoritative inventory, there is documented evidence that **USB, Thunderbolt, Firewire (IEEE 1394) ports** are physically blocked/disabled and **CD/DVD drives** are physically removed or disabled/locked.
- Evidence is complete for all systems after initial deployment and after any hardware maintenance/repair.
- The physical condition observed during inspection matches the documented method and scope for each system.

###### Actions Required for Compliance

- [ ] Create and get approval for an official list of all in-scope systems and components (workstations, servers, engineering workstations, and operational technology (OT) control system gateways).
- [ ] Publish an approved list of ports and devices that must be physically disabled or removed (Universal Serial Bus (USB), Thunderbolt, Firewire/Institute of Electrical and Electronics Engineers 1394 (IEEE 1394), and CD/DVD drives).
- [ ] Choose and standardise the physical methods used to prevent unauthorised access to ports and drives, such as tamper-evident port blockers or covers, or removing port hardware; and removing the optical drive or using a locked or disabled drive bay.
- [ ] Apply the physical security hardening to all in-scope systems and record the exact method used for each device.
- [ ] Update maintenance and repair work orders to require mandatory SC-41 physical checks and supporting evidence to be recorded before the work is signed off.
- [ ] Carry out periodic inspection sampling and compare the results against the SC-41 checklists and photos for each device.


---

### SC-42 — Sensor Capability and Data (Control)

This requirement is about preventing phones and tablets from being used to secretly listen, watch, or track people in sensitive rooms. It also ensures that, when sensors are used for a legitimate purpose, the correct staff can clearly tell that this is happening.

Without these protections, someone could remotely enable features such as location tracking, microphones, cameras, or motion sensors in areas used for classified information storage and secure communications. This could enable covert surveillance and cause serious harm to privacy and security.

The organisation must block remote activation of these sensing features in those areas, except for authorised testing, incident response, or accessibility needs—where there is documented approval and the action is recorded for audit purposes.

Where sensor use is permitted, the device must provide a clear, explicit indication to authorised personnel who need access to mobile device sensors for mission or security purposes. This indication must not be visible to staff who are not authorised.

##### MDM geofenced sensor lockdown with auditable exception workflow

- Category: Software
- Priority: Critical

###### WHAT
Put in place an enterprise mobile device management (MDM) policy that **stops remote activation** of mobile device environmental sensing features (for example: GPS/location, microphone, camera, accelerometer) when the device is inside **classified information storage areas** and **secure communications rooms**. Allow remote activation **only** when there is a **documented, time-limited, approved exception**, and ensure **audit records** are kept. While an exception is active, make sure the device shows an **obvious “sensor in use” indication** to **authorised staff**.

###### WHY (control requirement)
The SC-42 guidance highlights the risk of hidden (covert) activation of mobile sensors (for example, remotely enabling GPS to track people). It requires that sensor use is **prohibited** in sensitive locations, with only **authorised exceptions** allowed—supported by **documented approval** and **audit records**—and that there is an **obvious indication** of sensor use to authorised staff.

###### HOW (specific steps/approach)
1. **Define restricted zones** within the MDM and automation layer by linking each “classified information storage area” and “secure communications room” to official zone identifiers (for example: geofence identifiers or facility location signals).
2. **Lock down sensors through policy**: configure MDM to block remote enabling of environmental sensing features (GPS/location, camera, microphone, motion/accelerometer) whenever the device is detected inside a restricted zone.
3. **Set up an exception process** for permitted cases (for example: authorised testing, incident response, or accessibility needs):
   - Require an approval record that includes the reason, device identity, sensor types, and start/end time.
   - Ensure only users in the defined **authorised staff** group can request and approve exceptions.
4. **Enable audit records** for every exception and every attempted activation:
   - Record the requester identity, approver identity, device, sensor types, restricted zone, date and time, request/approval identifiers, and whether activation succeeded or failed.
   - Send the records to the organisation’s security information and event management (SIEM) system for storage and review.
5. **Show an obvious “sensor in use” indication** during approved exceptions:
   - Use the operating system’s built-in indicators where available.
   - Add an enterprise “sensor in use” message or overlay that is clear and visible to authorised staff (and does not depend on the user noticing it).

###### WHO
- **Mobile/Endpoint Security Lead**: responsible for configuring the MDM policy (sensor lock-down and indication behaviour).
- **Security Operations (SOC) / Incident Response Lead**: responsible for approving exceptions during incident response and ensuring audit evidence is complete.
- **Facility Security / Security Governance**: maintains the official list of restricted zones.
- **Identity and Access Management (IAM) team**: applies role/group controls for authorised staff and connects the approval process to identity systems.

###### Acceptance criteria
- Devices in restricted zones cannot have environmental sensors remotely activated (attempts are blocked and recorded).
- Remote sensor activation is possible only when an approved, time-limited exception exists for the specific device and sensor types.
- Every allowed activation has complete audit evidence (who requested, who approved, which sensor(s), when, where/zone, and the result).
- During an approved exception, authorised staff receive a clear, unambiguous indication that sensors are in use.
- Audit records are collected centrally (for example, in the SIEM) and can be provided for audit purposes within the organisation’s retention period.

###### Actions Required for Compliance

- [ ] Map each classified storage area and secure communications room to the official zone identifiers used by the mobile device management (MDM) and location services.
- [ ] Set up mobile device management (MDM) rules to block remote activation of GPS/location, the camera, the microphone, and the accelerometer when devices are in restricted areas.
- [ ] Set up an approval process for authorised exceptions that requires a documented reason, the device and sensor types involved, and the start and end times.
- [ ] Limit exception requests and approvals to the approved authorised staff group by using enterprise identity and access management (IAM) and strong authentication.
- [ ] Integrate mobile device management (MDM) and automation logs with the security information and event management (SIEM) system to record who initiated and approved actions, which device was used, what sensor types were involved, the zone, the date and time, and whether each activation succeeded or failed.
- [ ] Check that any approved exceptions cause a clear “sensor in use” warning that authorised staff can see, and that unauthorised users are not given confusing or incorrect access information.


---

#### SC-42.1 — Reporting to Authorized Individuals or Roles (Enhancement)

This requirement is about ensuring that any information collected by your network intrusion detection sensors and endpoint monitoring agents is sent only to the correct people within your organisation, and never to unauthorised people or to other organisations. Without this, sensitive monitoring information could be sent to the wrong place, shared by mistake, or forwarded to the wrong systems. That could expose confidential information, personal data, or internal security weaknesses, and could also weaken or disrupt investigations.

To meet this expectation, the organisation must configure the sensors so that where they send information is restricted at the moment the data is sent. This should be done using a clear, approved list of recipients, and by blocking any destinations that are not on the approved list, including backups. The organisation must also ensure that even when authorised staff trigger or activate the sensors, the information produced still follows the same approved sending routes.

Finally, the organisation should document the reporting settings and keep evidence that they are in place. It should be able to show, using records, that reporting went only to authorised roles and approved destinations, including where personal data is involved.

##### Allow-list sensor reporting destinations with enforced RBAC

- Category: Software
- Priority: Critical

###### WHAT
Set up the network intrusion detection sensors and endpoint telemetry agents ({{ insert: param, sc-42.01_odp }}) so that the data they collect is sent only to people or job roles that are explicitly authorised. This must be enforced by the system itself at the point where data is reported—not only through staff procedures. This includes limiting where the data can be sent (data collectors/receiving systems) and ensuring only authorised roles can access and export the received data.

###### WHY (control requirement)
SC-42(1) Enhancement requires proof that the system is configured so collected data is only reported to authorised people or roles. The guidance notes that even if sensors are turned on by authorised staff, the data could still be sent to unauthorised parties—so the system must enforce the rule at the reporting point.

###### HOW (specific steps/approach)
1. **Create an authorised reporting allow-list**: list the approved places the sensors/agents may send data (for example, security information and event management (SIEM) log receiving endpoints, approved secondary collectors, and any approved downstream integrations). Link each destination to the authorised role(s) allowed to receive and use the data.
2. **Block unapproved destinations at the sensor/forwarder**: configure each sensor/agent to send data only to the approved allow-listed fully qualified domain name (FQDN)/internet protocol (IP) addresses and ports. Turn off or prevent any settings that could redirect data to unapproved places (for example, automatic discovery of destinations, automatic fallback to public endpoints, “send to any configured URL”, unauthorised proxy bypass, or any backup/failover destinations not on the allow-list).
3. **Use identity-based forwarding**: make the sensor/agent authenticate to the collector using dedicated service or workload identities (with the minimum permissions needed), so the sending path cannot be changed by user actions. Use mutual transport layer security (mTLS) or workload identity where supported, and ensure the collector rejects any unauthorised identities.
4. **Control authorised access on the receiving platform**: apply role-based access control (RBAC) and attribute-based access control (ABAC) on the SIEM/log platform so only authorised roles can view, search, export, or generate reports from the ingested datasets. Limit export methods (application programming interface (API) tokens, scheduled reports, comma-separated values (CSV)/portable document format (PDF) downloads, email/webhook reporting) to authorised roles and approved destinations only.
5. **Stop bypass through integrations and secondary routes**: ensure any downstream routing (pipelines, stream processing, webhooks, security orchestration, automation and response (SOAR) actions, data lake ingestion, backup copies) is also restricted to the same allow-list of authorised destinations and roles, and that no unauthorised integration can reroute the data.
6. **Keep audit-ready evidence**: store proof of configuration (sensor/forwarder settings showing allow-listed destinations) and audit logs showing successful forwarding and access decisions (who accessed/exported what, and to which approved destinations).

###### WHO (role responsible)
- **Security Engineering / security operations centre (SOC) Engineering**: define authorised destinations and roles, and implement allow-list enforcement on sensors/agents and collectors.
- **Platform/Infrastructure Team**: implement and maintain collector-side authentication (service identities) and network controls.
- **SIEM/Observability Administrator**: implement RBAC/ABAC and restrict exports/reporting.
- **Information Security / Compliance**: review the evidence and approve the authorised destination/role mapping.

###### Acceptance criteria
- Sensors/agents are configured to forward data only to the approved allow-listed collector destinations; attempts to send to unapproved destinations are blocked.
- Collector-side authentication ensures only authorised sensor/agent identities can ingest the data.
- Only authorised roles can view, search, and export the ingested datasets; export/reporting to unapproved destinations is blocked.
- Audit logs show that forwarding and access/export actions occurred only for authorised roles and approved destinations.
- Evidence is available for both production and disaster recovery environments showing the enforced configuration and the matching audit trails.

###### Actions Required for Compliance

- [ ] Set up an authorised allow-list of sensor reporting destinations (a primary destination and approved secondary destinations), and link each destination to the authorised roles that are permitted to use it.
- [ ] Set up each network intrusion detection system (IDS) sensor and each endpoint telemetry agent so they send data only to the approved (allow-listed) collector fully qualified domain name (FQDN) or IP addresses and the approved ports.
- [ ] Turn off dynamic endpoint discovery, automatic fallback, and any backup or secondary reporting routes that are not approved in the agent or forwarder settings.
- [ ] Set up data collection so that it only accepts connections authenticated to specific service or workload identities, using the minimum permissions needed (least privilege).
- [ ] Set up role-based access control (RBAC) and attribute-based access control (ABAC) on the receiving security information and event management (SIEM) and log platform, so that only authorised roles can view, search, and export the ingested datasets.
- [ ] Limit export and reporting options (application programming interface (API) tokens, scheduled reports, downloads, webhooks and email) to authorised roles and approved destinations.
- [ ] Collect and keep evidence: saved snapshots of the agent/forwarder configuration, plus audit logs showing forwarding activity and any authorised access or export actions.


---

#### SC-42.2 — Authorized Use (Enhancement)

This requirement is about making sure any information collected by your sensors is used only for the specific, approved purposes your organisation intends. Without this, sensitive information such as location or other observations could be misused to monitor people for the wrong reasons, or shared with outsiders who then use it in ways you never agreed to.

To meet this expectation, the organisation must:
- Clearly define and document what each type of sensor data may be used for.
- Publish an authorised-use policy that staff can follow.
- Restrict access so only people whose job role matches an approved purpose can view or use the data.

Relevant staff must complete mandatory annual training on authorised use, including examples of how misuse can happen and the consequences.

Where sensor data is shared with contractors, or stored or maintained by external parties, the organisation must include contractual terms that limit their use to authorised purposes only and require them to follow your rules.

##### Purpose-tagged sensor data access with RBAC enforcement

- Category: Software
- Priority: Critical

###### WHAT
Put in place an access-control mechanism that makes sure data or information collected by the specified sensors is **only used for authorised purposes**. This must be enforced at the point where people access it (for example, viewing, exporting, using an application programming interface (API), or accessing the data layer), not just through the user interface.

###### WHY (control requirement)
SC-42(2) Enhancement requires measures to ensure that data or information collected by **{{ insert: param, sc-42.01_odp }}** is only used for **{{ insert: param, sc-42.02_odp }}**. The guidance notes the risk of misuse (for example, tracking individuals using global positioning system (GPS) data) and says to reduce that risk using measures such as training and contractual restrictions. This solution focuses on enforcing authorised use through technical controls.

###### HOW (specific steps/approach)
1. **Create a sensor data inventory and purpose categories**: list each sensor dataset/feed and label it with a clear authorised purpose (for example, “traffic navigation support” versus “individual tracking prohibited”).
2. **Link roles to authorised purposes**: set up which job roles are allowed to use which purposes, so each role can only access datasets that match its approved use case.
3. **Enforce purpose-based authorisation in the application/API/data layer**: implement role-based access control (RBAC) and attribute-based access control (ABAC) checks so users can only view, export, or query data when their role is allowed for the dataset’s purpose label. Block all other actions, including bulk export and API retrieval.
4. **Connect to the organisation’s identity and access process**: use the enterprise identity provider (IdP) and single sign-on (SSO) for authentication, and automatically update access for joiners, movers, and leavers so access is granted or removed immediately when job roles change.
5. **Make enforcement auditable**: record every access decision (who accessed what dataset/purpose, the action type such as view/export/API query, and whether it was allowed or denied) and keep the logs for investigation.
6. **Add training completion checks for sensitive purposes (optional but recommended)**: for higher-risk purposes (for example, location-like data), require annual completion of authorised-use training before granting access to datasets with those purpose labels.

###### WHO (role responsible)
- **Application/Data Owner**: approves the authorised purpose categories and the role-to-purpose mappings.
- **Identity and Access Management (IAM)/Platform Engineer**: implements the RBAC/ABAC enforcement and IdP integration.
- **Security Engineer**: checks that the policies and configurations are correct, and that logging and audit evidence are in place.
- **Business/Operations Lead**: confirms the operational authorised purposes and reviews misuse scenarios.

###### Acceptance criteria
- Each sensor dataset/feed is labelled with an authorised purpose aligned to **{{ insert: param, sc-42.02_odp }}**.
- For every access route (user interface (UI), API, exports, and direct data queries), requests are denied unless the user’s role is mapped to the dataset’s purpose.
- Joiner/mover/leaver events lead to timely access changes, with no ongoing access for unauthorised purposes.
- Audit logs show allow/deny decisions including the dataset/purpose and the action type.
- Evidence is provided showing the purpose categories, role mappings, enforcement configuration, and sample audit logs.

###### Actions Required for Compliance

- [ ] List every sensor data set or feed and give each one a clearly defined authorised purpose that matches sc-42.02_odp
- [ ] Define and get approval for which purposes each user and service role is allowed to access for sensor data.
- [ ] Implement purpose-based role-based access control (RBAC) and attribute-based access control (ABAC) for every way users can access data (user interface, application programming interface (API), exports, and data queries).
- [ ] Integrate enforcement with the central identity provider and single sign-on service, and automate updates to user roles when people join, move to a new role, or leave the organisation.
- [ ] Set up audit logs that record every allow or deny decision, including the dataset or purpose and the type of action, and keep the logs for later review.
- [ ] Use test cases to confirm that access for unauthorised purposes (including bulk export and application programming interface (API) retrieval) is blocked.


---

#### SC-42.4 — Notice of Collection (Enhancement)

This requirement is about making sure people are clearly told when the organisation is collecting information about them, so they can make informed choices and protect their privacy. Without clear information, people may not realise that network monitoring, tracking of computer activity, or closed-circuit television (CCTV) and door-access systems are capturing personal information. This could lead to surprise, complaints, misuse of trust, and legal or reputational harm.

To meet this requirement, the organisation must:
- show privacy notice banners on the login page and on web portals
- place clear signs at the locations where sensors are used (including CCTV and door-access areas)
- display in-app prompts, with wording that explicitly covers all three sensor types

The notices must be easy to see, readable, and understandable at the point where people would reasonably notice them. The organisation should also:
- document what it uses
- keep evidence that the notices are delivered
- ensure system and privacy policies and system settings match the notices
- assign clear responsibility to the people who implement, configure, and maintain these measures

##### Identity and app notice banners for PII collection by defined sensors

- Category: Software
- Priority: High

###### WHAT
Set up an identity-first, in-application privacy notice experience that tells people that the organisation’s defined sensors are collecting personal data (personally identifiable information (PII)).

###### WHY (control requirement)
SC-42(4) (Enhancement) requires using measures to help people understand that PII is being collected by **{{ insert: param, sc-42.04_odp.02 }} (sensors)**, using **{{ insert: param, sc-42.04_odp.01 }} (measures)**. Guidance also stresses that the notice must be easy to use and effective, and that measures can include both standard privacy notices and sensor settings that make people aware directly or indirectly.

###### HOW (specific steps/approach)
1. **Create one agreed source of truth for the notice text** that clearly names the sensor categories from **sc-42.04_odp.02** (for example: network monitoring sensors, endpoint data-collection agents, CCTV/door-access systems) and explains the notice purpose at a high level (what is collected and why). This should match the **{{ insert: param, sc-42.04_odp.01 }} (measures)**.
2. **Show the notice during sign-in** by configuring the organisation’s identity provider (IdP) to display a **login banner** (or an equivalent notice/consent screen before authentication) using the approved notice text.
3. **Add web portal banners** using a shared user interface component (or portal middleware) so the same approved notice text appears on relevant pages (for example: the landing page, the signed-in home page, and any portal areas that use monitored data).
4. **Add in-app prompts** in the application middleware/application programming interface (API) gateway so prompts appear when users access features that are clearly supported by the defined sensors (for example: remote access consoles, endpoint management views, and monitoring dashboards).
5. **Check notice completeness before release** (policy-as-code/configuration validation) so a release cannot go live unless the notice text includes every sensor category listed in **sc-42.04_odp.02**.
6. **Keep audit evidence** by recording (a) banner/prompt display events and (b) user acknowledgement events (if used), including timestamps, user/session identifiers, and the notice version.
7. **Make sure the notice matches what the system actually does** by linking the notice text to the system’s documented sensor coverage and data-collection settings, and by confirming that the application features that trigger prompts correspond to the sensor categories.

###### WHO (role responsible)
- **Application Owner / Product Owner**: owns the notice experience and the mapping between features and sensors.
- **Identity and Access Management (IdAM) Lead**: implements the login banner/notice in the identity provider (IdP).
- **Security Engineering / Privacy Engineering**: maintains the approved notice text model and checks that sensor coverage is aligned.
- **Platform/DevOps Engineer**: implements the shared banner component, middleware prompts, deployment checks, and evidence logging.

###### Acceptance criteria
- The sign-in process displays a notice banner that clearly states that PII is collected by the defined sensor categories in **sc-42.04_odp.02**.
- The web portal shows a consistent banner using the same approved notice text.
- In-app prompts appear at the point of interaction for features that rely on monitored data, and they explicitly reference the defined sensor categories.
- Deployment checks prevent release if the notice text omits any sensor category from **sc-42.04_odp.02**.
- Audit evidence exists showing banner/prompt display events and the notice version (and acknowledgement events where implemented).
- The notice text is clearly consistent with the organisation’s documented sensor coverage and the application’s actual integration points.

###### Actions Required for Compliance

- [ ] Create a controlled notice content template that clearly includes every type of sensor listed in **sc-42.04_odp.02**.
- [ ] Set up the organisation’s identity provider (IdP) so the login banner shows the approved notice text, using the correct version.
- [ ] Implement a shared web portal banner that displays the same controlled notice content.
- [ ] Add in-app prompts through application middleware and the application programming interface (API) gateway for features that depend on the defined sensors.
- [ ] Add a check at the time of release to stop deployments if the notice content does not include every required sensor category.
- [ ] Turn on audit logging for banner and prompt display events, and for the notice version (and acknowledgement events, if they are used).


---

#### SC-42.5 — Collection Minimization (Enhancement)

This requirement is about collecting the smallest amount of personal information possible when using video analytics, so people are not identified more than necessary. Without this, a system could capture and store more detail than needed, such as clear faces or other identifying features, and it could also record sound when it should not. This could cause privacy harm and increase the risk that internal rules are applied incorrectly.

To meet this expectation, the organisation must set up its video analytics to blur or pixelate faces and use privacy masks that hide human features. It must also keep audio recording turned off by default, and only allow audio when there is explicit authorisation.

The organisation must be able to check what the sensors collect, keep clear records of what information is collected (including whether audio is on or off), document how and why the information-minimisation settings are used to reduce privacy risk, complete privacy assessments that cover both the video and audio approach, and keep audit records showing the system worked as configured.

##### Privacy-preserving sensor configuration with auditable audio gating

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation’s video analytics sensors to reduce the amount of information collected about individuals to only what is needed. Do this by using privacy-protecting processing (for example, blurring or pixelating faces and using privacy masks that hide human features). Also make sure audio recording is turned off by default, and only turned on when there is clear, documented permission that can be checked later.

###### WHY (control requirement)
SC-42(5) enhancement requires using the organisation-approved sensors (parameter: **sc-42.05_odp = sensors**) configured to reduce collection of personal information that is not needed. The guidance specifically highlights hiding human features (for example, blurring or pixelating skin tones) and reducing privacy risk at the point where data enters the system, including lowering the risk of failures in how policies are enforced.

###### HOW (specific steps/approach)
1. **Create and apply a “minimising sensor profile” baseline** for each camera and edge analytics device. This baseline must include: (a) face blurring/pixelation and privacy masks, and (b) audio capture set to **disabled** by default (matching the organisation’s parameter: video analytics with face blurring/pixelation and privacy masks; audio capture disabled unless explicitly authorised).
2. **Lock the baseline in place using configuration management / policy-as-code** so that deployments and configuration changes cannot move away from the minimisation profile (for example, automated checks in CI/CD that reject releases if privacy mode is off or if audio is enabled).
3. **Require explicit audio permission through a controlled process**: turning on audio must require an approved change request/workflow that records the approver’s identity, the reason, the scope (site/camera), and the time period it applies to. The system should only accept audio-enable actions when that workflow approval is present (and it should record the event in logs).
4. **Continuously check for changes and detect “drift”**: regularly review each sensor/edge device and the analytics platform to confirm the privacy mode is active and whether audio is enabled. If settings drift away from the baseline, raise alerts and automatically put them back.
5. **Keep evidence that shows what is collected** by ensuring the analytics platform/edge devices provide audit-friendly information (for example, whether privacy mode is active and whether an audio stream is present or absent) and by storing logs centrally for retention.

###### WHO (role responsible)
- **Application/OT Analytics Owner**: owns the minimising sensor profile and ensures it is applied to all relevant sensors.
- **Security Engineering / Privacy Engineering**: defines the privacy-protecting configuration requirements and checks that masks/blurring meet the intended minimisation.
- **Platform/Infrastructure Engineering**: implements policy-as-code enforcement, drift detection, and recovery actions.
- **Change Management / IAM Workflow Owner**: ensures the audio permission workflow is auditable and linked to identity and approvals.

###### Acceptance criteria
- For all production sensors, the active configuration shows **face blurring/pixelation and privacy masks enabled**.
- For all production sensors, **audio capture is disabled by default** and cannot be enabled unless it goes through the explicit authorisation workflow.
- Every audio enablement event has an associated **auditable approval record** (who/when/justification/scope) and a matching system log entry.
- Drift detection reports show that running configurations match the baseline within the agreed monitoring time. Any difference triggers alerts and remediation.
- Centralised audit logs and configuration snapshots provide evidence of the minimisation settings and the current sensor behaviour (privacy mode and audio state).

###### Actions Required for Compliance

- [ ] Create a version-controlled “minimum data” sensor profile that automatically applies face blurring or pixelation and privacy masks, and sets audio capture to “disabled” by default.
- [ ] Set up automated checks for policy-as-code and configuration management that block any deployment where the “minimising profile” has not been applied.
- [ ] Set up an approval process that can be audited, so audio can only be turned on through an approved change request. The request must record who approved it, their identity, the reason for approval, what it covers (scope), and the specific time period when audio is allowed.
- [ ] Set up the analytics platform and edge nodes to record whether privacy mode is on, and whether an audio stream is present or not, and send this information to the central logging system for audit evidence.
- [ ] Run scheduled checks to compare the current sensor settings against the agreed baseline, and raise an alert and fix the issue if they do not match.


---

### SC-43 — Usage Restrictions (Control)

This requirement is about ensuring that only approved people and approved equipment can connect to, use, or be installed on your systems, and that their activity is monitored. Without clear rules and permission checks, staff could accidentally or deliberately use unapproved mobile devices, wireless connections, or equipment such as printers, scanners, and optical devices. This could result in system damage, service disruption, or unauthorised access.  

To meet this expectation, the organisation must set clear, practical day-to-day rules and setup guidance for mobile code, mobile devices, wireless access, and wired or wireless peripherals, and follow these rules during installation, configuration, and everyday use. It must formally approve (authorise) the use of these components, monitor their use so authorised activity is recorded, and control or restrict behaviour to prevent unauthorised use or address it quickly.

##### Authorise and enforce approved mobile/wireless/peripheral usage

- Category: Software
- Priority: Critical

###### WHAT
Put in place organisation-approved rules and practical guidance for **mobile code, mobile devices, wireless access, and wired/wireless peripherals** (for example, printers, scanners, optical devices). This must ensure only **authorised** components and settings are used, and that use is **monitored and recorded**.

###### WHY (control requirement)
Control SC-43 requires usage rules and guidance for all relevant types of components. This is because some components could cause harm or damage, and we must ensure only **authorised** use of systems. This means setting up authorisation, applying the restrictions, and monitoring use so unauthorised or harmful use is prevented or dealt with quickly.

###### HOW (specific steps/approach)
###### 1) Define what counts as “authorised components” and the restrictions
- Create one, centrally managed and version-controlled **Component Usage Policy** covering: mobile code, mobile devices, wireless access, and wired/wireless peripherals.
- For each component type, set out:
  - Which device types are allowed or blocked, and who owns them (for example, corporate-managed devices only for wireless access)
  - Which ways devices may connect to the network (for example, **802.1X only**; no temporary “ad-hoc” hotspots)
  - Which peripheral types are allowed and the approved ways to connect them (for example, only through authenticated print/scan gateways)
  - Prohibited behaviour (for example, unmanaged printers/scanners, and direct device discovery where this can be avoided)

###### 2) Check authorisation when devices connect
- **Mobile devices & wireless access:** require **managed device registration** (mobile device management / mobile endpoint management) and use **conditional access** so only devices that meet requirements can authenticate to enterprise Wi‑Fi and any peripheral access points.
- **Wireless access:** require **802.1X** using per-user/per-device credentials or certificates, and link authorisation to approved device groups and roles.
- **Wired/wireless peripherals:** limit peripheral connections by:
  - Allowing only approved network routes/ports/protocols for print/scan services
  - Requiring authenticated access to print/scan gateways (to avoid unauthenticated direct discovery)
  - Blocking unauthorised peripheral network areas (for example, subnets/VLANs) where supported

###### 3) Monitor and record use for traceability
- Set up logging so you can link each type of component use to the **user/account** and the **device/peripheral identity**:
  - Wireless authentication records (**802.1X** / authentication, authorisation, and accounting)
  - Mobile device management / mobile endpoint management registration and compliance events
  - Print/scan gateway records (job details and the source identity)
  - Access control system records showing policy decisions (including conditional access outcomes)
- Send all relevant events to the **security information and event management (SIEM)** system and keep logs according to the organisation’s retention requirements.

###### 4) Detect unauthorised attempts and respond
- Create **SIEM** alerts for:
  - Attempts to connect using non-authorised or unmanaged devices
  - Wireless authentication failures that suggest unauthorised access attempts
  - Peripheral connection attempts from non-approved device groups
  - Signs that rules have changed outside the normal change process (policy drift), such as changes to allowlists or conditional access rules
- Use **security orchestration, automation, and response (SOAR)** incident procedures to revoke access, isolate devices, or raise incidents when restricted actions are detected.

###### WHO
- **Information Security / Security Architecture Lead:** owns the Component Usage Policy and the enforcement design.
- **Identity and Access Management (IAM) / Network Engineering** (for example, Wi‑Fi/authentication team): implements **802.1X**, conditional access, and network segmentation.
- **Endpoint Management Team** (mobile device management / mobile endpoint management): implements device registration and compliance requirements.
- **Infrastructure/Platform Team:** implements peripheral gateway allowlisting and network controls.
- **Security Operations Centre (SOC) / SIEM Team:** implements detections, alerts, and response procedures.

###### Acceptance criteria
- Only devices that are **authorised and managed** can connect to enterprise wireless and peripheral access routes (enforced in practice, not just guidance).
- Wired/wireless peripherals are limited to **approved connection routes** (for example, authenticated print/scan gateways), and unauthorised peripheral connections are blocked or fail safely.
- Use records for mobile devices, wireless access, and peripheral use are logged with enough information to identify the **user/account** and **device/peripheral**.
- The SIEM includes alerts for unauthorised attempts and policy drift, and response procedures are tested (at least one tabletop exercise or controlled test).
- Evidence exists for authorisation (policy versions/approvals) and monitoring (sample logs showing traceability).

###### Actions Required for Compliance

- [ ] Create and get approval for a version-controlled “Component Usage Policy” covering mobile code, mobile devices, wireless access, and wired and wireless peripherals, with clear rules for what is allowed and what is prohibited.
- [ ] Set up managed-device registration and conditional access so that only authorised and compliant devices can sign in for wireless access and for peripheral access endpoints.
- [ ] Require IEEE 802.1X for enterprise Wi‑Fi, allowing access only for approved devices and peripherals, based on pre-approved access groups and user roles.
- [ ] Allow only approved network connections for peripheral devices, and require authenticated access through the print and scan gateways (where possible, block unauthorised direct device discovery).
- [ ] Set up security information and event management (SIEM) logging for wireless sign-ins, device registration and compliance checks, and use of peripheral gateways, using both user or account details and device or peripheral identifiers.
- [ ] Create security information and event management (SIEM) alerts and security orchestration, automation and response (SOAR) action playbooks for unauthorised connection attempts, attempts to access connected devices, and changes to security policies, then test them using a controlled scenario.


---

### SC-44 — Detonation Chambers (Control)

This requirement is about safely testing suspicious digital content in a controlled, locked-off environment before it ever reaches staff. The real-world risk is that a harmful email attachment, an untrusted or suspicious programme, or a web link could run malicious code and spread into everyday working systems, causing disruption, data loss, or unauthorised access.  

To meet this expectation, the organisation must run an on-premises “detonation” sandbox for email and web traffic inside the classified network enclave. In this sandbox, suspicious attachments, untrusted applications, and web (URL) requests are opened or run in isolation, so any harmful behaviour is identified quickly and then prevented from reaching users’ normal systems.  

The organisation must also document how the sandbox is set up and configured, keep its procedures and security plan up to date for how it is used, and keep audit records showing when the sandbox was used and the result.

##### Enclave detonation sandbox for email attachments and URL requests

- Category: Software
- Priority: Critical

###### WHAT
Deploy and run an **on-premises detonation chamber capability** (dynamic execution) **inside the classified network enclave** to handle **email attachments**, **untrusted or suspicious applications**, and **web or URL requests**.

###### WHY (control requirement)
SC-44 requires the organisation to **“Employ a detonation chamber capability within {{ param, sc-44_odp }}.”** The guidance explains that detonation chambers provide **protected, isolated execution** to check whether content contains malicious code. The goal is to **quickly identify malicious behaviour and stop it spreading** into user environments.

###### HOW (specific steps/approach)
1. **Set up an on-premises detonation sandbox cluster inside the classified enclave** at the location defined by **sc-44_odp** (on-premises email and web detonation sandbox cluster within the classified network enclave).
2. **Connect the sandbox to the email security process** so suspicious attachments are automatically sent for **isolated execution and analysis** before they are delivered to users (or before users open them).
3. **Connect the sandbox to the web/URL security process** so suspicious URLs are **retrieved and executed in isolation** (dynamic analysis). Use what is observed to produce a decision (verdict).
4. **Use strong isolation and short-lived execution**: run each detonation in a fresh temporary environment (for example, a snapshot or throwaway virtual machine/container), with **no lasting presence** in user networks and **limited outbound access** only to what is needed for detonation.
5. **Contain based on the verdict**: translate sandbox results into clear, repeatable actions in the email and web security systems (for example, quarantine, block, disable link rewriting, or allow with a warning) so malicious content does not spread.
6. **Keep audit-ready records**: record submission identifiers, detonation start and stop times, the type of item analysed (attachment/URL/application), the verdict, and the containment action. Keep logs according to the organisation’s retention policy.
7. **Document the capability**: maintain a design/configuration record and operating procedures for the enclave detonation chamber. Include routing criteria, isolation controls, the lifecycle (temporary execution), and response actions.

###### WHO
- **Detonation/Security Engineering Lead**: designs where it sits in the enclave, the isolation approach, and the integration points.
- **Email/Web Security Platform Owner**: sets up routing of suspicious attachments/URLs to the detonation service and applies the verdict actions.
- **SOC/IR Lead**: defines how verdicts are handled operationally and ensures audit evidence is kept and reviewed.
- **Enclave/Infrastructure Team**: sets up and secures the on-premises sandbox cluster inside the classified enclave.

###### Acceptance criteria
- Suspicious email attachments and suspicious URLs are **sent to the detonation chamber** at **sc-44_odp** and run in **isolated, short-lived** environments.
- Detonation activity is **prevented from directly affecting user environments** (no lateral movement or lasting presence in user networks).
- Sandbox verdicts lead to **enforced containment actions** in the email/web security workflow (for example, quarantine or block) before any spread occurs.
- For every detonation, there is evidence including **submission ID, item type, execution window, verdict, and containment action**, retained for audit.
- Documentation exists covering **where the capability runs (sc-44_odp), how it is isolated, how it is used, and how outcomes are handled**.

###### Actions Required for Compliance

- [ ] Set up an on-premises detonation “sandbox” cluster inside the classified network enclave at the location specified by `sc-44_odp`.
- [ ] Set up the email security process so that any suspicious attachments are automatically sent to the detonation chamber for safe, isolated testing.
- [ ] Set up the website and web address (URL) security process so that any suspicious URL is sent to the “detonation chamber” for isolated retrieval and live testing.
- [ ] Run each submission in a temporary, one-time environment (a fresh snapshot that is discarded after use), with outgoing network access restricted and no lasting connections or storage on the user’s network.
- [ ] Match the results of map “detonation” checks to the containment actions that are enforced in the email and web security layers (quarantine, block, disable, or allow with a warning).
- [ ] Record an audit log for every detonation, including the submission ID, artefact type, execution window, verdict, and containment action, and keep the logs according to the applicable policy.
- [ ] Document the rules for routing items to the detonation chamber, the isolation controls to prevent unintended access, the limits for how long records are kept and how long the system is used, and the step-by-step procedures for safe day-to-day handling.


---

### SC-45 — System Time Synchronization (Control)

This requirement is about making sure every computer clock in your organisation shows the correct time, both within each system and across different systems and their parts. If clocks drift or disagree, important security checks can fail. For example, people may be incorrectly allowed or blocked when they log in, certificates may appear valid or expired at the wrong time, and systems may behave unpredictably. This could lead to a denial of service or allow credentials to keep working when they should no longer work.

To meet this expectation, the organisation must set clear, written procedures for how clocks are synchronised. These procedures must specify which time source to use and how often synchronisation should happen. The organisation must then apply the approved settings to every relevant system component. Administrators must be able to follow these procedures in day-to-day work. The approach must be documented in system design and security plans, and records must be kept to show synchronisation is working and to prove that any failures or excessive clock drift are detected and corrected promptly.

##### Authoritative NTP time sync with automated enforcement and drift alerts

- Category: Software
- Priority: Critical

###### WHAT  
Set up an organisation-approved, reliable time-setting approach and apply it to all in-scope system clocks (within each system and between systems/components). Use **Network Time Protocol (NTP)** (or **Precision Time Protocol (PTP)** where needed). Continuously check that clocks stay in sync, and raise alerts if they drift beyond the agreed limit.

###### WHY (control requirement)  
**Security and control requirement SC-45** says system clocks must be synchronised **within and between systems and system components**. Guidance explains that incorrect or out-of-sync clocks can disrupt security services—for example, **certificate checks** and **authentication time windows**—which can lead to denial of service or accepting expired credentials.

###### HOW (specific steps/approach)  
1. **Write down the approved time standard and allowed variation**: state whether systems must use **Coordinated Universal Time (UTC)** (or local time with an offset), the maximum acceptable difference (tolerance), and how it will be measured (for example, NTP offset/dispersion).  
2. **Use backup (redundant) authoritative time sources** in a controlled network area (for example, internal NTP servers). Where possible, use authenticated time methods (for example, NTP implementations that support **Network Time Security (NTS)**) and monitor whether the upstream reference sources are healthy.  
3. **Set NTP clients consistently across the full environment** (presentation, application, data, and administration hosts; hypervisors; container hosts; **continuous integration/continuous delivery (CI/CD)** runners; and disaster recovery environments). Ensure they synchronise only to the approved internal sources.  
4. **Automatically enforce the settings** using configuration management and standard “known good” baselines, so time synchronisation settings (enabled state, time source list, UTC handling, and any security-related time settings) are corrected automatically after drift, reboots, or system image updates.  
5. **Continuously verify and alert**: collect each host’s time-synchronisation status (for example, whether it can reach the NTP source and the current time difference). Alert when the difference exceeds the agreed tolerance, including how issues are escalated and handled.  
6. **Keep audit-ready records**: store regular snapshots/logs of time-synchronisation status for each system/component. Also keep records of any changes to time-synchronisation settings, including when tolerance limits were breached and how the issue was resolved.  
7. **Document how to handle outages** in the procedure (for example, what happens if authoritative sources cannot be reached, the maximum period of reduced accuracy, and when to escalate).

###### WHO (role responsible)  
- **Infrastructure/Platform Engineering Lead**: owns the authoritative time source design and the standards for configuring clients.  
- **Security Engineering/Compliance**: sets and approves the tolerance and checks that audit evidence is sufficient.  
- **Operations/Site Reliability Engineering (SRE) Team**: runs monitoring, investigates issues, and escalates when tolerance limits are breached.  
- **Configuration Management Owner** (for example, DevOps/IT Operations): implements the automated enforcement.

###### Acceptance criteria  
- **100%** of in-scope system components (as defined in the procedure) are configured to synchronise to the approved internal time sources.  
- The measured time difference between each host and the approved time standard stays within the agreed tolerance during normal operations (and alerts trigger if it is exceeded).  
- Time-synchronisation configuration is enforced automatically (no manual reconfiguration is needed after standard changes or reboots).  
- Monitoring provides evidence of synchronisation status and any tolerance breaches, and this evidence is retained for audit.  
- Outage handling behaviour is documented and tested (for example, during planned maintenance of authoritative time sources).

###### Actions Required for Compliance

- [ ] Define and get approval for the time standard to use (Coordinated Universal Time (UTC) versus local time offset) and the maximum allowed difference (tolerance) in system clocks for the in-scope components.
- [ ] Set up duplicate internal Network Time Protocol (NTP) servers that are the official source of time (and use authenticated time checks where possible), and record health checks that confirm whether their upstream time sources are working correctly.
- [ ] Set up network time protocol (NTP) on all production, test, and disaster recovery servers, virtual machines, and containers so they use only the approved internal time sources.
- [ ] Use automated checks and enforcement through configuration management and endpoint baselines to keep time settings correct, and to fix any changes that occur after reboots or when new system images are installed.
- [ ] Set up continuous monitoring of time synchronisation status (whether it can be reached and whether the time difference is within tolerance), and configure alerts and escalation when the allowed tolerance is exceeded.
- [ ] Store evidence of periodic time synchronisation status and records of configuration changes for audit purposes, including any instances where tolerance limits were exceeded and the remediation actions taken.


---

#### SC-45.1 — Synchronization with Authoritative Time Source (Enhancement)

This requirement is about making sure every system’s internal clock matches an official time source, so events are logged with the correct time. If clocks drift or do not match, it becomes harder to investigate incidents, confirm what happened and when, and coordinate responses across different systems. This increases the risk of delays, mistakes, and unreliable records.

To meet this expectation, the organisation must configure systems to check their internal time against the organisation-approved Department of Defense (DoD) Global Positioning System (GPS) time servers within the approved network every 60 seconds, and automatically correct the system clock whenever the difference is more than 5 seconds.

The organisation must also document how the time checks and corrections work, record what actions were taken (including the size of the time difference when correction was triggered, where available), and include these responsibilities in its system plans so administrators can run the process consistently and reliably.

##### Enforce NTP sync to approved DoD GPS servers with 5s threshold

- Category: Software
- Priority: Critical

###### WHAT
Set the clocks on all in-scope systems to match the organisation’s approved “source of truth” time (DoD GPS Network Time Protocol (NTP) servers within the organisation’s approved network). Automatically re-check and re-sync the clock whenever the difference from the source time goes beyond the organisation’s agreed threshold.

###### WHY (control requirement)
Security Control SC-45(1) enhancement requires internal system clocks to stay aligned with an authoritative time source. This ensures consistent time stamps across systems and networks. The organisation’s agreed settings are:
- compare time **every 60 seconds**
- use **DoD GPS time servers (NTP)** as the authoritative source
- use a **5 second** time difference threshold to decide when to trigger corrective re-synchronisation

###### HOW (specific steps/approach)
1. **Authoritative source allow-list**: Create and maintain a list of approved DoD GPS NTP server hostnames and IP addresses. Limit access to only those servers through the organisation’s approved network routes.
2. **Standard NTP configuration baseline**: For each supported operating system/platform (for example, chrony/ntpd equivalents), set:
   - the time check (poll/compare) interval so comparisons happen **every 60 seconds**
   - the corrective behaviour so the system only re-syncs when the measured time difference is **greater than 5 seconds** (and does nothing when the difference is **5 seconds or less**)
3. **Central enforcement and fixing clock drift**: Use enterprise configuration management (for example, policy-as-code using Ansible, Microsoft Intune, or Configuration Manager) to apply the baseline across production, test, and disaster recovery environments. Add automated fixes that re-apply the NTP settings and restart/force the time service only when a host is found to:
   - not be using the approved authoritative sources, or
   - have a time difference greater than **5 seconds** for more than one comparison cycle
4. **Audit-ready evidence capture**: Make sure the time service logs and/or exported monitoring data capture:
   - which authoritative source was selected
   - periodic comparison and re-sync attempts
   - the measured time difference when corrective re-synchronisation is triggered (where the platform provides this information)
   - the time the corrective action was taken
5. **Operational documentation and responsibilities**: Update each system’s security plan and operational runbooks to explain:
   - the NTP design
   - the authoritative source
   - the **60-second** comparison cadence
   - the **5-second** corrective threshold
   - what to do if the authoritative source is not reachable (for example, follow the fail-safe behaviour defined by the platform’s time service configuration and change control)
6. **Validation testing**: Run controlled tests to confirm behaviour at and around the threshold (for example, time differences of 4.9 seconds and 5.1 seconds). Confirm corrective re-synchronisation happens only when the difference is **greater than 5 seconds**.

###### WHO
- **Infrastructure/Platform Engineering Lead**: owns the NTP baseline design and platform-specific configuration.
- **System Administrators**: implement and maintain the enforcement tools and check that the required logs are produced.
- **Security/Compliance Officer**: confirms audit evidence requirements are met and that security plans and runbooks are updated.

###### Acceptance criteria
- All in-scope systems synchronise to the organisation-approved DoD GPS NTP servers.
- Systems compare their clock to the authoritative source at a cadence consistent with **every 60 seconds**.
- Corrective re-synchronisation is triggered only when the measured time difference is **greater than 5 seconds**; no corrective action occurs when the difference is **5 seconds or less** (confirmed through test cases).
- Central reporting or retained logs provide audit evidence of time comparisons and any corrective re-synchronisation events, including the triggering time difference values where available.
- System security plans and operational runbooks document the authoritative source, cadence, threshold, and how to handle an unreachable authoritative source.

###### Actions Required for Compliance

- [ ] Create and approve an allow-list of the organisation’s Department of Defense (DoD) Global Positioning System (GPS) Network Time Protocol (NTP) server hostnames and Internet Protocol (IP) addresses, so they can only be reached from approved network segments.
- [ ] Set up a standard Network Time Protocol (NTP) / chrony time-setting baseline on all in-scope systems, so they can be compared and synchronised on a 60-second schedule.
- [ ] Set the corrective action so that resynchronisation happens only when the measured time difference is more than 5 seconds (and not when it is 5 seconds or less).
- [ ] Use central configuration management to roll out the baseline, and automatically fix any hosts that drift out of compliance.
- [ ] Enable and keep time service logs and telemetry that record which trusted source was selected, any attempts to compare or synchronise with other sources, and the offset values used to trigger changes when available.
- [ ] Update each system security plan and runbook to use the authoritative source, check for differences every 60 seconds, raise an alert if the source is unreachable for more than 5 seconds, and follow the defined process for handling unreachable sources.
- [ ] Run timing threshold checks (for example, comparing a 4.9 second offset with a 5.1 second offset) and record the results as evidence.


---

#### SC-45.2 — Secondary Authoritative Time Source (Enhancement)

This requirement is about making sure your systems can always keep accurate time, even if their usual trusted time source becomes unavailable. Accurate time matters because many important business and security activities depend on events being correctly dated and put in the right order. If time becomes wrong or inconsistent, investigations, audits, and troubleshooting can be misleading, and problems may be harder to spot or prove.

To meet this expectation, the organisation must:
- choose a second trusted time source in a different geographic region from the main one
- record how the organisation verified that the locations are correct
- configure the systems so they automatically switch to the second source whenever the main source is unavailable

When the main source is available again, the systems should switch back to it rather than staying on the backup unnecessarily. The organisation should also keep clear procedures describing how the time switching works, and be able to demonstrate—using configuration settings and records—that the automatic switch took place during a primary outage.

##### Dual-region secondary authoritative time source with auto-failover

- Category: Software
- Priority: High

###### WHAT
Set up the application’s hosting infrastructure (for example, servers/virtual machines/containers where system time is set) so it can keep accurate time by synchronising to an **authoritative primary time source** and an **authoritative secondary time source in a different geographic region**. Configure it to **automatically switch** to the secondary if the primary is not available, and **automatically switch back** to the primary once it is available again.

###### WHY (control requirement)
SC-45(2) enhancement requires using a **secondary authoritative time source** and, where needed, using **location information** to ensure it is in a **different geographic region**. The goal is to keep time accurate and continuous even if the primary source is unavailable.

###### HOW (specific steps/approach)
1. **Select time sources**: Choose an authoritative primary and a secondary time source that supports network time protocols (for example, organisation-approved Network Time Protocol (NTP) servers, cloud provider time endpoints, or vendor time services) that your environment can reach.
2. **Prove geographic separation**: Record the primary and secondary provider location details (for example, region/country). Then gather independent location evidence (for example, DNS/IP-to-location checks or provider documentation). Store this evidence in a place that can be audited.
3. **Define failover/unavailability criteria**: Configure the time service to treat the primary as unavailable when measurable conditions are met (for example, repeated NTP reachability failures, synchronisation failure, or selection rules based on reachability/offset thresholds, as supported by the operating system time service).
4. **Enable multi-source selection and return**: Configure the operating system time synchronisation service (for example, chrony/systemd-timesyncd/Windows time service equivalents) to use both sources. It should automatically select the secondary when the primary is unavailable, then switch back to the primary when it is reachable and healthy again.
5. **Standardise configuration across tiers**: Apply the same time configuration baseline to all production components that affect event ordering (web/application servers, application programming interface (API) nodes, job runners, message brokers, and database hosts). Use configuration management with version-controlled baselines.
6. **Generate audit evidence and monitoring**: Turn on time synchronisation status logging and send relevant events to the security information and event management (SIEM) and monitoring system. Make sure the logs show which source is currently active and when switching happens.
7. **Test and document failover**: During a controlled maintenance window, simulate a primary outage (for example, block outbound access to the primary NTP endpoint). Confirm the system switches to the secondary, and then returns to the primary after the primary is restored. Record the results.

###### WHO (role responsible)
- **Infrastructure/Platform Engineering Lead**: owns the time service configuration and baseline rollout.
- **Security/Compliance Engineer**: checks the geographic separation evidence and ensures it is auditable.
- **Operations/Site Reliability Engineering (SRE)**: runs the failover test and confirms monitoring alerts and evidence.

###### Acceptance criteria
- Under normal conditions, systems synchronise to the **primary**.
- During a simulated primary outage, systems automatically synchronise to the **secondary** within the expected time-service convergence window.
- After the primary is restored, systems automatically return to the **primary** (they are not permanently fixed to the secondary).
- Geographic separation is evidenced and retained (documented provider region/country plus independent location evidence).
- Audit evidence exists showing the active time source and the switch event(s) (logs/monitoring records) for at least one tested failover scenario.

###### Actions Required for Compliance

- [ ] Choose a reliable main time source and a reliable backup time source that your systems can access.
- [ ] Record and provide evidence of the primary and secondary geographic regions using the provider’s location information and independent geolocation checks.
- [ ] Set up the operating system time synchronisation service to use both time sources, choosing the one that is reachable and working (based on failure and availability), and automatically switch back when the preferred source becomes available again.
- [ ] Apply the agreed time settings consistently across all production environments using configuration management.
- [ ] Enable and centralise logging of time synchronisation status, so active-source and switch events can be audited.
- [ ] Simulate a main service outage by blocking the main Network Time Protocol (NTP) address, then check that the system automatically switches to the backup (secondary) address. After service is restored, switch back to the main (primary) address.
- [ ] Store the configuration details, geographic evidence, and test results in the organisation’s audit-ready evidence repository.


---

### SC-46 — Cross Domain Policy Enforcement (Control)

This requirement is about putting a strong, physical barrier in place between different “security areas”, so that the traffic and access rules cannot be quietly bypassed. Without this, someone could potentially find a direct connection path that avoids the intended checks, which could allow unauthorised access or movement of data between areas that should be kept separate.

To meet this expectation, the organisation must physically implement a control mechanism between the physical and/or network connection points that link those security domains. This control must block any way to get around the rules through a direct path, and it must not create any hidden, indirect route that could weaken the separation.

The organisation must also document how the control works, where it sits in the overall design, and the specific settings used. Configuration records must be kept up to date, audit records must be retained to show it is working as intended, and the approach must be included in the system security plan. Named staff must be assigned to install, configure, and maintain it, and they must follow the documented procedures.

##### Physically enforced cross-domain guard between security domains

- Category: Software
- Priority: Critical

###### WHAT
Put in place a **physical** method to enforce cross-domain security rules between the **connecting physical and/or network connections** of the security domains (organisation parameter **sc-46_odp = physically**).

###### WHY (control requirement)
SC-46 requires that a security rule enforcement method be placed **between the connecting connections for security domains**. This is to stop anyone bypassing the intended cross-domain security rules. The guidance also stresses that for **physical** enforcement, the setup must be strong enough to prevent **hidden (covert) communication paths** from getting into the protected domain.

###### HOW (specific steps/approach)
1. **List the connecting connections and possible bypass routes**: Create an inventory of every physical/network connection that could create a direct route between the defined security domains (for example: production ↔ management, user ↔ admin, partner ↔ internal services). Clearly mark which connections are included for SC-46.
2. **Install a dedicated physical “choke point”**: Place a dedicated cross-domain guard device (or a pair for high availability) in a **separately cabled/segmented** guard network. Ensure there is **no shared switching/routing connection** that could allow a direct route to bypass the guard.
3. **Use one-way where possible**: If business needs allow, use **one-way** data movement (for example, a data diode / one-way gateway) for data-only transfers. If two-way is required, use a tightly controlled, state-aware, allow-list approach with explicit “deny by default”.
4. **Remove logical bypass routes**: Remove or disable any inter-domain routing, static routes, or alternative network paths that could get around the guard (including unintended management access). Make sure there are no dual-connected systems or shared infrastructure segments that could create hidden or alternate communication routes around the enforcement.
5. **Strengthen and configure the guard**: Configure the guard using explicit service/protocol allow-lists, strict session controls, and logging for both allowed and blocked traffic. Ensure changes follow controlled processes (for example, change tickets and peer review) and can be checked.
6. **Create audit evidence**: Turn on audit logging at the guard boundary (allowed/blocked sessions, policy changes, administrative actions, and health/status). Send these logs into the organisation’s security information and event management (SIEM) system so evidence is available for audits and investigations.
7. **Record this in the system security plan**: Document the physical location, cabling/segmentation rationale, enforcement rules, and verification/maintenance steps in the system security plan and related configuration documents.

###### WHO
- **Network/operational technology (OT)–information technology (IT) security architect**: defines the security domains, identifies connecting connections, and designs the guard layout.
- **Network engineers / security engineers**: implement the cabling/segmentation and configure the guard enforcement rules.
- **Security operations centre (SOC) / SIEM administrator**: ensures audit logs are collected, kept, and monitored.
- **System owner / information system security officer (ISSO) (or equivalent)**: ensures the design and evidence are captured in the system security plan and that maintenance follows the documented process.

###### Acceptance criteria
- There is **no direct logical path** between the in-scope security domains that bypasses the physical guard (confirmed through network path checks and routing/adjacency verification).
- The guard uses **deny by default**, with explicit allow-lists for required services/protocols.
- The guard is installed with **strong physical separation** (separate cabling/segmentation) so that no unintended shared infrastructure enables hidden or alternate communication into the protected domain.
- **Guard boundary audit logs** (allowed/blocked sessions and administrative/policy changes) are generated and sent to the SIEM.
- The system security plan and configuration documentation include the guard location, rule set, and maintenance/verification steps, with evidence available for audit.

###### Actions Required for Compliance

- [ ] Create an inventory of all physical and network connection points (interfaces) between security domains, and identify which connection paths are in scope for control SC-46.
- [ ] Design and implement a dedicated, physically separated “guard” network segment so there is no direct switching or routing connection between the domains.
- [ ] Set up the guard to block everything by default, and only permit the specific protocols and services that are required. Use one-way data transfer where business needs allow it.
- [ ] Remove or disable any routing between different network domains, any static routes, or any alternative network paths that could get traffic around the guard.
- [ ] Enable and send guard boundary audit logs (allowed and denied sessions, and policy or administrator changes) to the security information and event management (SIEM) system, with appropriate retention.
- [ ] Update the system security plan and configuration documents to include where the safeguards are placed, the set of rules they use, and the procedures for checking and maintaining them.


---

### SC-47 — Alternate Communications Paths (Control)

This requirement ensures that key decision-makers can still communicate and direct operations even if the usual communication methods fail. Without dedicated backup communication routes, a disruption during an incident could leave the organisation unaware of what is happening and unable to give timely instructions, which would slow recovery and increase harm.

The organisation is expected to put in place and maintain dedicated secure voice and encrypted message routes that operate outside the normal systems. This includes using satellite phones and approved secure email.

The organisation must name the specific primary decision-makers, and also name specific alternate decision-makers who take over when the primary people are unavailable. Each alternate’s authority must have clear, documented limits on what they are allowed to approve.

The organisation should document how these routes are used, include them in its system plans and design records, configure the arrangements so they work, and keep evidence that the routes and named contacts are tested, up to date, and usable.

##### SC-47 Comms Kit: secure voice bridge + encrypted out-of-band messaging

- Category: Manual
- Priority: Critical

###### WHAT
Set up and keep **alternative communication routes** available for system operations and organisational decision-making by providing:
- A **dedicated secure voice conference bridge** for command-and-control communications.
- **Encrypted messages sent outside the main network** using **satellite phones** and **approved secure email**.
- A list of **named primary decision-makers** and **named alternate decision-makers**, including **when alternates should be activated** and **what actions alternates are allowed to take** based on their role.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) **Security and Privacy Controls (SC-47)** requires the organisation to “**Establish {{ param, sc-47_odp }} for system operations organisational command and control**”. The guidance explains that incidents can disrupt existing communication routes. Having alternative routes—such as naming alternate decision-makers and defining the extent and limits of what they can do—helps ensure information can still be shared quickly and that direction can still be given.

###### HOW (specific approach)
1. **Provide the dedicated secure voice conference bridge** as a restricted-access bridge/conference service (or an equivalent secure voice bridge), with documented joining instructions for the SC-47 roster.
2. **Provide encrypted out-of-band messaging**:
   - Assign **dedicated satellite phones** as SC-47 assets.
   - Set up **approved secure email** (a secure email gateway/workflow) for SC-47 communications.
3. **Create an authoritative SC-47 roster** (the system of record) that lists:
   - Named **primary** decision-makers.
   - Named **alternate** decision-makers.
   - Bridge joining instructions, satellite phone asset IDs/numbers, and approved secure email addresses.
4. **Define activation triggers and handover rules** in a single SC-47 activation runbook (for example: the primary decision-maker is unavailable for a defined period, an incident is declared, or confirmed communication failure occurs). This must include:
   - **When alternates take over command**.
   - **When and whether control is handed back**.
5. **Define action limits for alternate decision-makers** (measurable and based on role). Clearly state what alternates may authorise and what they may not (for example: limits on safety-critical changes, the scope of operational instructions, and required notifications/escalations).
6. **Make it operational and prove it works** by running supervised tests (for example, quarterly) that confirm:
   - Alternates can join the secure voice conference bridge.
   - Satellite phones are reachable and working.
   - Secure email delivery works end-to-end.
   - Test results (pass/fail, date/time, and participants) are kept as evidence for audit.

###### WHO
- **Incident/Operations Manager (or Security Operations Centre (SOC)/Incident Response (IR) Lead)**: owns the SC-47 runbook, activation triggers, and action limits.
- **Chief Information Security Officer (CISO)/Information Security Manager**: approves the secure voice conference bridge and the approved secure email configuration.
- **IT/Cloud/Network Engineering**: sets up and maintains the secure voice conference bridge and secure email integration.
- **Business Continuity/Disaster Recovery (DR) Lead**: ensures alignment with business continuity and incident response processes, including test scheduling.

###### Acceptance criteria
- A documented SC-47 roster exists with **named primary and named alternate decision-makers** and their bridge/satellite/secure-email contact details.
- A documented SC-47 activation runbook exists with **defined activation triggers** and **handover/handback rules**.
- A documented set of **alternate decision-maker action limits** exists and has been approved by the organisation.
- The secure voice conference bridge and out-of-band channels are **in service** and **tested** (with retained evidence) within the last defined test cycle (for example, quarterly).
- Evidence shows that alternates can successfully use all alternative communication routes during a test scenario.

###### Actions Required for Compliance

- [ ] Set up a dedicated secure voice bridge that only authorised SC-47 personnel can access, with documented instructions on how to join.
- [ ] Assign dedicated satellite phones as SC-47 assets and record their asset ID numbers in the SC-47 roster.
- [ ] Set up and approve a secure email process for SC-47 communications that uses encryption and a separate (out-of-band) communication channel.
- [ ] Publish an official SC-47 list of the main and backup decision-makers, including bridge, satellite, and secure email contact details.
- [ ] Document the rules for activating the SC-47, how and when to escalate or hand over responsibility, and when the backup (alternate) crew takes command during an SC-47 activation runbook
- [ ] Define and get approval for role-specific limits on what alternates are allowed to do, including clear items they are not permitted to do and required notifications when those actions occur.
- [ ] Run and record supervised quarterly usability tests for joining the bridge, checking satellite connectivity, and ensuring secure email delivery


---

### SC-48 — Sensor Relocation (Control)

This expectation is about changing where your “watchers” look for suspicious activity inside your own network, and where you collect key internal event records, so they are not always in the same place. The risk it addresses is that a determined attacker could figure out where you are monitoring and then avoid detection or steal information by using network paths you do not monitor—especially when they move between systems.

To meet this expectation, the organisation must keep a documented list of the specific internal traffic watchers and event collectors it will relocate. It must also identify any newly discovered network areas and operational technology monitoring points that were not previously monitored, and decide whether to move the watchers based on threat information that suggests likely routes for getting in or taking data out, or alternatively move them on a random timetable to make the pattern harder to predict.

Every relocation must be approved and recorded. The organisation’s configuration and design records must be updated to show the new locations, and evidence must be kept to prove the watchers actually started operating in the new, previously unmonitored places.

##### Threat-intel driven relocation workflow for east–west sensors

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled, auditable process to move the organisation’s in-scope **network intrusion detection sensors** and **security event log collectors for east–west traffic** from their current monitoring locations to **newly identified network segments and operational technology (OT) demilitarised zone (DMZ) monitoring points that were not previously monitored**, **when threat intelligence indicates likely routes for an attacker to get in and take data out**.

###### WHY (control requirement)
Control SC-48 requires the organisation to **move sensors and monitoring capabilities to specified locations under defined conditions**. Here, the condition is: **“when threat intelligence indicates likely routes for an attacker to get in and take data out.”** The goal is to make it harder for an attacker to move sideways through the network and to steal data by reducing how predictable the monitoring coverage is.

###### HOW (specific steps/approach)
1. **Keep a complete, up-to-date relocation inventory** of every in-scope sensor/collector, including: their IDs, current tap/span/log source mappings, the owning team, and the current locations where they are already monitoring.
2. **Define and document how targets are chosen**, linking threat-intelligence findings to the **new** target network segments/OT DMZ points, and **excluding any targets that are already being monitored** by the relevant sensors/collectors.
3. **Create a relocation plan** (showing from/to mappings) that includes: the threat-intelligence (TI) reference, why each target was selected, an evidence checklist (including proof the target was **not previously monitored**), and the required change record.
4. **Carry out the moves using controlled change management**: update configurations to redirect the intrusion detection system (IDS) sensors and log collectors, including before-and-after configuration snapshots and clear rollback steps.
5. **Update the relevant documentation** (configuration, design, and security plan) to show the new monitoring locations, and disable or retire the old primary collection points as part of the same approved change.
6. **Gather audit evidence**: logs from the monitoring platform and collectors showing the sensors/collectors started receiving data from the new sources, and evidence that the old sources are no longer the primary collection points.

###### WHO
- **Cybersecurity Monitoring Lead**: owns the in-scope sensor/collector inventory and the relocation rationale.
- **Threat Intelligence Analyst**: provides threat-intelligence inputs and references.
- **Network/OT Security Engineer**: implements the sensor/collector configuration changes.
- **Change Manager / Change Advisory Board (CAB)**: approves and records the relocation change.
- **Configuration Management (CM) Owner**: ensures documentation/design/security-plan updates are completed.

###### Acceptance criteria
- For each relocation event, there is an approved change record that includes: (a) the TI reference, (b) clear from/to mappings for the in-scope sensors/collectors, and (c) evidence that the target locations were **previously not monitored**.
- After the change, evidence shows IDS sensors and log collectors are actively receiving data from the **new** network segments/OT DMZ points.
- Documentation (configuration/design/security-plan) is updated to reflect the new locations, and the old locations are disabled or no longer the primary collection points.
- Every relocation action can be traced end-to-end (TI item → relocation plan → approved change → deployment evidence).

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, official list of all in-scope east–west intrusion detection system (IDS) sensors and security event log collectors, including their current instrumented locations.
- [ ] Set up threat-intelligence rules to match potential threats to specific operational technology (OT) locations, so you generate candidate targets and automatically exclude any locations that are already monitored.
- [ ] Create a relocation plan (from/to mapping) that points to the TI source and includes an evidence checklist to verify “previously uninstrumented” items.
- [ ] Submit relocation plans through the organisation’s change management process, with approval from the change advisory board (CAB), rollback steps, and before-and-after configuration snapshots.
- [ ] Update the intrusion detection system (IDS) sensors and log collectors to the approved new network segments and operational technology (OT) demilitarised zone (DMZ) monitoring locations, and turn off the old primary collection points.
- [ ] Update configuration management records and the design and security plan documents to reflect the new monitoring locations.
- [ ] Keep audit records from the monitoring and data-collection platforms that show (1) successful data ingestion from new sources and (2) that primary data collection has stopped at the old sources.


---

#### SC-48.1 — Dynamic Relocation of Sensors or Monitoring Capabilities (Enhancement)

This requirement is about being able to move your monitoring tools quickly and safely when circumstances change, so you can continue to see what is happening. If these tools cannot be moved during planned maintenance, while an incident is being contained, when there is a suspected security compromise, when the network layout changes, or when coverage or risk levels are no longer acceptable, you may lose visibility at the exact time you most need it—delaying detection and response.

The organisation must have clear written procedures for dynamically relocating the following components to the approved on-premises security monitoring areas and operational technology (OT) demilitarised segments whenever these triggers occur: network intrusion detection sensors, host-based logging agents, and security monitoring collectors. The organisation must also keep an up-to-date list showing exactly what can be moved and where it is allowed to go, record each relocation through change control, and update the official records of configuration, system design, system settings, audit evidence, and the system security plan so they accurately show what was moved, when it was moved, and why.

##### Event-driven relocation runbooks for sensors and monitoring collectors

- Category: Software
- Priority: High

###### WHAT
Set up event-driven, documented procedures (runbooks) and automation to move the organisation-defined **sensors and monitoring capabilities** (for example, network intrusion detection system (NIDS) sensors, host-based logging agents, security monitoring collectors) to the organisation-defined **locations** (security monitoring zones on premises and operational technology (OT) demilitarised segments) when the organisation-defined **conditions or circumstances** happen (during maintenance, incident containment, suspected compromise, changes to network layout, or when risk or coverage limits are exceeded).

###### WHY (control requirement)
Security and Compliance control SC-48(1) requires the organisation to **dynamically relocate** the specified monitoring capabilities **to the specified locations** **under the specified conditions/circumstances**. This must be supported by auditable, repeatable procedures so monitoring visibility continues during operational and security events.

###### HOW (specific steps/approach)
1. **Create an authoritative relocation scope register** listing each type of capability that can be moved and each eligible instance (for example, NIDS sensor ID, host logging agent instance, collector instance). Include whether each instance is eligible for relocation and its current/owner location.
2. **Create and maintain an approved destination allow-list** of target locations (on-premises security monitoring zones and OT demilitarised segments). Include the connection limits needed for safe relocation (for example, allowed network routes, firewall and routing endpoints, and any OT-specific operational constraints).
3. **Define relocation triggers and map them to the five required circumstances**:
   - maintenance
   - incident containment
   - suspected compromise
   - topology changes
   - risk or coverage thresholds exceeded  
   Link each trigger to the correct runbook and the required approval steps (for example, security operations centre (SOC) / incident response (IR) lead approval for suspected compromise; change manager approval for maintenance).
4. **Implement automation-first orchestration** that runs the runbook steps to redirect or reconfigure capabilities to the selected approved destination(s) (for example, update log forwarder endpoints, set collector target routing, and change sensor management or telemetry destinations). Use policy-as-code so automation can only choose destinations from the allow-list.
5. **Add pre-checks and post-checks** in the runbook to confirm the relocation worked and monitoring continues (for example, confirm the destination endpoints are reachable, confirm certificates or identities are valid where relevant, and confirm the expected telemetry and alerts appear in the monitoring system or security information and event management (SIEM) within a defined time window).
6. **Record and provide evidence for every relocation** through change and configuration management. Capture what was moved (capability ID/type), from where to where (source and destination location IDs), when it happened, which trigger/circumstance caused it, who authorised it, and the results of the pre-checks and post-checks. Update the system security plan and configuration or design records to reflect the new monitoring layout (or record a clear reason if no design change is needed).

###### WHO
- **SOC/IR Lead**: authorises relocations for incident containment and suspected compromise triggers.
- **Change Manager / IT Operations Manager**: authorises relocations for maintenance and topology-change triggers.
- **OT Security/Operations Representative**: checks OT demilitarised segment constraints and approves OT-related relocation approval steps.
- **Platform/Monitoring Engineering**: maintains the relocation scope register, destination allow-list, and automation/orchestration.
- **Configuration Management (CM) / Governance, Risk and Compliance (GRC)**: ensures evidence is captured and system security plan and configuration records are updated.

###### Acceptance criteria
- For each of the five required circumstances, there is an approved runbook that can be executed to move the defined monitoring capabilities to the approved locations.
- The relocation automation (or execution process) only allows destinations from the approved allow-list and only relocates capabilities listed in the relocation scope register.
- Every relocation execution produces auditable evidence, including capability ID/type, source and destination location IDs, time of execution, trigger/circumstance, authoriser, and pre-check and post-check results.
- After relocation, monitoring continuity is demonstrated by successful telemetry and alert intake into the target monitoring system or SIEM within the defined verification window.
- The system security plan and configuration or design records reflect the relocated monitoring layout (or an explicit, documented “no design change” rationale is recorded).

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date relocation scope register for all eligible sensors and monitoring capabilities, including their identification numbers, types, current locations, and whether they can be relocated.
- [ ] Define and keep an approved list of allowed destinations for on-premises security monitoring zones and operational technology (OT) demilitarised (DMZ) network segments, including the destination identifiers and the permitted connection limits.
- [ ] Create relocation runbooks for each required situation (planned maintenance, incident containment, suspected compromise, network layout changes, and when risk or coverage thresholds are exceeded), and include the required approval steps before actions can be taken.
- [ ] Set up automation that automatically redirects sensors, agents, and data collectors only to approved destinations (use an approved list and block all other destinations).
- [ ] Add runbook checks before and after the move to confirm the system can be reached and that telemetry and alerts are successfully received.
- [ ] Integrate relocation execution with change and configuration management so that you record what was moved, where it was moved to, when it happened, and why, and then update the system security plan and the configuration and design records.


---

### SC-49 — Hardware-enforced Separation and Policy Enforcement (Control)

This requirement is about putting a strong, hardware-based protection in place between your Secret (classified) network area and your confidential information technology (IT) and operational technology (OT) network areas. This ensures that only the specific, approved connections and permitted actions can move between them. Without this protection, sensitive information could be exposed, or unauthorised systems could gain access to the more sensitive environment, which could lead to major operational disruption and potential regulatory and reputational damage.

To meet this expectation, the organisation must clearly define and document the two areas that need to be separated. It must then use hardware controls to enforce the agreed rules for what traffic and actions are allowed to cross between them, blocking unauthorised traffic and actions. The organisation must also keep design and configuration records up to date to show how the protection works, maintain clear procedures for how the cross-area rules are created, changed, and checked, include this approach in the system security plan, and keep audit records that demonstrate the protection is working as intended.

##### Hardware cross-domain gateway enforcing Secret↔Confidential policy

- Category: Software
- Priority: Critical

###### WHAT
Set up a **hardware-enforced separation boundary** between the organisation-defined **security domains** (parameter **sc-49_odp**: *classified enclave (Secret) and confidential IT/OT network segments*). Use a **dedicated hardware security gateway** that is the **only permitted route** for traffic moving between domains. Enforce the **cross-domain rules in hardware**, using **default-deny** (block by default) with **explicit allow rules** (only what is approved is permitted).

###### WHY (control requirement)
SC-49 requires: **“Implement hardware-enforced separation and policy enforcement mechanisms between {{ param, sc-49_odp }}.”** Hardware enforcement is expected to provide stronger separation than software-only controls, ensuring separation between domains and enforcement of the required rules for the defined domains.

###### HOW (specific steps/approach)
1. **Define the boundary and domains**: Create an authoritative record of the *Secret enclave* and *Confidential IT/OT segments* (authoritative IP ranges, who controls the routing, and any DNS/service naming views). Record which network interfaces/virtual routing and forwarding instances (VRFs)/zones belong to each domain.
2. **Place a dedicated hardware gateway**: Deploy a hardware security appliance (for example, a firewall) between the two domains. Use **separate interfaces (or VRFs/zone connections)** for each domain. Configure routing and connections so that **cross-domain traffic can only pass through this gateway** (no other routes via routing changes, virtual private network (VPN) concentrators, or unmanaged switch connections).
3. **Enforce policy in hardware**: Configure the gateway with **default-deny** for cross-domain traffic. Add **explicit allow rules** that match the approved cross-domain policy exactly, including direction (which way traffic flows), source and destination, protocol and port, and any session limits. Make sure the rules align with the required business/data flows.
4. **Enable tamper-evident audit logging**: Turn on gateway logging detailed enough to prove enforcement (for example, rule identifier, allow/deny decision, source and destination, direction, timestamps, and session identifiers). Send logs to the enterprise **security information and event management (SIEM)** system with integrity controls.
5. **Control rule lifecycle and keep evidence**: Use a controlled change process for creating and changing rules (approval workflow, version control, and checks after changes). Keep **design and configuration evidence** (architecture diagram, interface/VRF mapping, exported configuration/rule snapshots, and log retention settings).
6. **Update the system security plan and verify**: Record the boundary and enforcement approach in the system security plan. Carry out periodic verification (for example, configuration compliance checks and sampling of allowed/blocked traffic) to show the mechanism works as intended.

###### WHO
- **System Owner / Security Architect**: owns the domain definitions, boundary design, and updates to the system security plan.
- **Network/Operational Technology (OT)/Infrastructure Engineers**: implement where the gateway is placed, restrict routing as required, and configure the hardware rule set.
- **Security Operations (SOC) / SIEM Team**: ensure logging, log forwarding, alerting, and retention are in place.
- **Change Manager / Change Advisory Board (CAB)**: approves rule changes and ensures evidence is produced.

###### Acceptance criteria
- Cross-domain traffic between the *Secret enclave* and *Confidential IT/OT segments* passes through the **hardware gateway only** (confirmed by routing/path checks).
- The gateway enforces **default-deny** with **explicit allow rules** that match the approved cross-domain policy (confirmed by configuration review).
- Gateway logs show **allow/deny decisions** with enough information to support audit evidence (confirmed by log sampling in SIEM).
- Design and configuration evidence is available and up to date: boundary diagram, interface/VRF/zone mapping, exported rule-set snapshots, and references in the system security plan (confirmed by document review).
- After any rule updates, **post-change verification** is completed and the required configuration compliance checks are scheduled (confirmed by change records and check results).

###### Actions Required for Compliance

- [ ] Document the “Secret” and “Confidential” security areas for **sc-49_odp**, including the authorised Internet Protocol (IP) address ranges, who owns the network routing, and how network interfaces, virtual routing and forwarding (VRF) instances, and zones are mapped.
- [ ] Set up a dedicated hardware “cross-domain” gateway with separate network interfaces and routing tables for each domain. Configure the network routing so this gateway is the only allowed route between domains.
- [ ] Set up the gateway to block everything by default (“default-deny”) and then add only the specific “allow” rules needed to follow the approved cross-domain policy, including the required direction, protocol and port, and the allowed source and destination.
- [ ] Enable tamper-evident logging at the gateway for decisions to allow or deny access, and send those logs to the enterprise security information and event management (SIEM) system with the required retention period.
- [ ] Set up a controlled process for managing rules, including approval steps, version tracking, and checks after changes are made. Save exported configuration snapshots as audit evidence.
- [ ] Update the system security plan to refer to the hardware separation boundary, and carry out regular checks to confirm that the security controls are working effectively.


---

### SC-50 — Software-enforced Separation and Policy Enforcement (Control)

This requirement is about using built-in software controls to keep different parts of your systems and data strictly separated, so that only the right people and systems can move between areas. Without this, someone could accidentally or deliberately access sensitive information or critical operational systems from the wrong place, or carry out actions they are not allowed to do. This could result in data leaks, service disruption, or unauthorised changes.

To meet this expectation, the organisation must clearly define the separation boundaries between:
- the information technology (IT) and operational technology (OT) network areas,
- the user and administrator areas, and
- the Secret and Confidential data areas,

and then enforce these boundaries using software, not policy alone.

The organisation must also:
- document how the rules for moving across boundaries are enforced,
- reflect this approach in system design and configuration settings,
- ensure installers and maintainers follow the documented method, and
- keep audit records and a system security plan showing that the separation works as intended, including any stronger measures needed for higher-risk situations.

##### Software-enforced domain separation via policy gateways and ABAC

- Category: Software
- Priority: Critical

###### WHAT
Set up software-based separation and rules enforcement between the organisation-defined **security domains** ("{{param, sc-50_odp}}"). This includes **IT/OT network segments for IT/OT zones**, **user/admin domains**, and **data classification domains** for **Secret** and **Confidential** data.

###### WHY (control requirement)
SC-50 requires the system to **use software to separate access and enforce policies** between the defined security domains. This means any access across domains must be controlled at the points where software makes decisions (not only by network separation or trust). The enforcement must also be **able to be checked and audited**.

###### HOW (specific steps/approach)
1. **Define domain boundaries and enforcement points**: For each cross-domain path (for example, user/admin → application programming interfaces (APIs); application → Secret/Confidential data stores; IT/OT zone → application services), identify the exact software point(s) where access will be enforced (for example, zero trust network access (ZTNA)/secure access gateway, API gateway, reverse proxy, service-to-service authorisation layer, database proxy).
2. **Apply access rules at the boundary (ABAC/RBAC)**: Configure an authorisation policy engine connected to the organisation’s identity provider (IdP) so that decisions are based on **identity details** (for example, user/admin role, service account identity) and **resource details** (for example, data classification: Secret/Confidential; application/data domain tags). Use **deny-by-default** for cross-domain actions.
3. **Enforce separation at the action level**: For each pair of domains, define which actions are allowed (for example, read/write/export/transfer/configuration change). Ensure the enforcement point blocks any actions that are not allowed. For sensitive actions that affect Secret data, use **step-up checks** or **re-authorisation**.
4. **Apply enforcement continuously for sessions and requests**: Make sure rules are checked for each request (or at least for sensitive actions). Ensure session tokens cannot be used to get around domain rules (for example, use short-lived tokens and re-check during step-up actions).
5. **Create audit evidence of enforcement**: Set up logs at each enforcement point to record the **decision result (allow/deny)**, **identity**, **role/attributes**, **source domain**, **target domain**, **resource classification**, **action attempted**, **enforcement component**, and **time**. Send these logs to the security information and event management (SIEM) system for retention and correlation.
6. **Document the enforcement design and settings**: Record the cross-domain enforcement approach in the system security documentation and reflect it in configuration baselines (including the exact enforcement components and where the policy rules come from).

###### WHO
- **System Owner / Application Owner**: responsible for defining the domains, ensuring enforcement coverage, and keeping the documentation up to date.
- **Security Architect**: designs the ABAC/RBAC model and the boundary enforcement approach.
- **IAM/Platform Engineer**: implements the identity provider (IdP) integration, configures the policy engine, and sets up token/session controls.
- **Application/Integration Engineer**: ensures service and data access paths go through the enforcement points, and that resource classification tags are applied.
- **Security Operations Centre (SOC)/SIEM Engineer**: ensures audit logs are collected correctly, kept for the required period, and available as evidence.

###### Acceptance criteria
- Cross-domain requests between the defined security domains are **enforced by software** at the identified boundary components, using **deny-by-default** behaviour.
- For Secret and Confidential resources, only identities with the correct domain/role/attributes can perform the permitted actions; unauthorised actions are blocked.
- Audit logs exist for enforcement decisions and include allow/deny outcomes, along with identity, domain, resource classification, action, and enforcement point.
- The enforcement approach and configuration are documented and match the deployed system (audit evidence is available).

###### Actions Required for Compliance

- [ ] Identify and document all cross-domain access routes between information technology (IT) and operational technology (OT) zones, user and administrator areas, and Secret and Confidential data areas.
- [ ] Choose and set up software “enforcement points” for each path (for example, zero trust network access/secure access gateway, API gateway, reverse proxy, service-to-service authorisation, and database proxy).
- [ ] Set up access rules using attribute-based access control (ABAC) and role-based access control (RBAC) that work with the organisation’s identity provider (IdP). Use domain details and resource labels to decide what access is allowed, and block cross-domain actions by default (deny-by-default).
- [ ] Set permissions at the action level for **Secret** and **Confidential** information, and require extra approval (step-up re-authorisation) before carrying out sensitive actions.
- [ ] Enable continuous authorisation checks for each request and session, so policies cannot be bypassed using outdated tokens or by reusing an existing session.
- [ ] Set up audit logging at every enforcement point to record each allow or deny decision, the user identity, the domain, the resource classification, the action taken, and the enforcement component involved; then send these records to security information and event management (SIEM).
- [ ] Publish and keep up to date system security documents and configuration baselines that describe how security rules are enforced and list the exact settings that are currently deployed.


---

### SC-51 — Hardware-based Protection (Control)

This requirement is about physically locking the most important built-in software on your devices so it cannot be changed without permission. It matters because if someone alters the built-in start-up settings, the system management functions, or the rules that control secure boot, they could quietly take control of the device or make it behave in ways you may not easily notice.

To meet this expectation, the organisation must keep hardware write-protection enabled for the Unified Extensible Firmware Interface (UEFI)/basic input/output system (BIOS) firmware, the system management firmware (such as baseboard management controller (BMC), iDRAC, or iLO), and the secure boot settings during normal operation.

When an approved firmware update is genuinely needed, the system owner, the firmware administrator, and the authorised change manager must follow documented, role-specific steps to manually switch the hardware write-protection off only for that approved change, and then switch it back on before the device is returned to operational use.

##### Hardware write-protect lock and role-gated firmware change procedure

- Category: Manual
- Priority: Critical

###### WHAT
Put in place and run **hardware-based write-protection** for (1) **UEFI/BIOS firmware**, (2) **system management firmware** (for example, **baseboard management controller (BMC)**, **integrated Dell Remote Access Controller (iDRAC)**, **HP iLO**), and (3) the **secure boot configuration** so it stays enabled during normal use. Create **documented, role-based steps** to **manually turn off** the hardware write-protect only for an approved firmware change, and then **turn it back on** before the system is used again.

###### WHY (control requirement)
**Security Control SC-51** requires that hardware write-protect remains in place for the specified firmware parts and the secure boot configuration during normal operation, and that turning it off and back on is done using **procedures limited to authorised people**.

This approach follows the organisation’s defined parameters:
- **sc-51_odp.01**: lists the firmware parts that must have hardware-based write-protect (UEFI/BIOS, BMC/iDRAC/iLO, secure boot configuration).
- **sc-51_odp.02**: names the authorised people and requires procedures for turning hardware write-protect off and back on.

###### HOW (specific steps/approach)
1. **Standardise the hardware write-protect method by device model**: For each in-scope server/laptop model, document the exact vendor method(s) that enforce write-protect for UEFI/BIOS, BMC/iDRAC/iLO, and the secure boot configuration (for example, a BIOS write-protect switch, jumper, or key lock). Also record what the **enabled/locked** indicator looks like.
2. **Create a firmware change guide with role-based responsibilities**: Create a step-by-step guide for three authorised roles: system owner, firmware administrator, and authorised change manager. The guide must cover: (a) checking the current locked state, (b) turning off hardware write-protect only during the approved change window, (c) carrying out only the approved firmware update(s), (d) turning hardware write-protect back on, and (e) checking the locked state after the change.
3. **Separate duties and keep evidence**: Make sure the **turn-off** and **turn-back-on** actions are done using a two-person process with the authorised roles (for example, the firmware administrator performs the physical action; the authorised change manager checks the lock state and records the evidence). Record timestamps, device identifiers, lock state before and after, and the result of the secure boot check in the change record.
4. **Check secure boot after the change**: After turning write-protect back on, check in the UEFI interface that the secure boot configuration is in the expected state and that configuration changes are not allowed while locked (where supported by the specific device model). Record the result.
5. **Return-to-service approval gate**: The system can only be put back into operational use after the authorised change manager confirms that write-protect has been turned back on and completes the sign-off checklist.

###### WHO
- **Firmware administrator**: performs the physical turn-off/turn-on actions and carries out the approved firmware update steps.
- **Authorised change manager**: checks the lock state before and after, confirms the change is approved, and signs the evidence/checklist.
- **System owner**: confirms business approval for the change window and ensures operational readiness and any rollback considerations are addressed.

###### Acceptance criteria
- For each in-scope device model, there is a documented description of the **hardware write-protect method** covering **UEFI/BIOS**, **BMC/iDRAC/iLO**, and **secure boot configuration**, including a clearly defined **enabled/locked** state.
- During normal operation, there is evidence (for example, completed inspection checklist records) showing that hardware write-protect is enabled for the specified components.
- For every approved firmware change, the change record includes: (1) confirmation of the locked state before the change, (2) the documented steps used to turn write-protect off, performed only by authorised roles, (3) the firmware update carried out only within the approved scope, (4) the documented steps used to turn write-protect back on, performed only by authorised roles, and (5) confirmation after the change that secure boot is in the expected state and that the lock state has been restored.
- Systems are not returned to operational use until the authorised change manager signs the checklist confirming write-protect has been turned back on.

###### Actions Required for Compliance

- [ ] For each in-scope device model, identify and document how the vendor protects against unauthorised changes to firmware (UEFI/BIOS and BMC/iDRAC/iLO), and document the secure boot configuration.
- [ ] Create a firmware change runbook with step-by-step instructions to disable and then re-enable the firmware, aligned to the three authorised roles.
- [ ] Set up a two-person process where the firmware administrator carries out the required actions, and the authorised change manager checks the evidence and signs it off.
- [ ] Update the change management template to require: pre-change checks that the system is in a locked state, post-change checks that verification has been re-enabled, and confirmation of the secure boot verification results.
- [ ] Train the system owner, firmware administrator, and authorised change manager on the runbook and the evidence they must provide.
- [ ] Carry out an initial baseline check of all in-scope devices to confirm that hardware write protection is enabled, and record the results.

