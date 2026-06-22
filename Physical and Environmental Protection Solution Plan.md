### PE-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation clearly explains how it will protect its physical sites and the surrounding environment, and keeps those rules up to date. Without an agreed, documented approach, responsibilities can be unclear, important updates may be missed after incidents or changes, and the organisation may not meet legal and regulatory expectations—leaving people, assets, and day-to-day operations more exposed to theft, sabotage, or unauthorised access.

The organisation must create and document an organisation-wide physical and environmental protection policy. This policy must explain its purpose, where it applies, who is responsible for what (including the Physical Security Officer, Facility Security Officer, and Security Engineering Lead), how senior leadership is committed, how different teams will work together, and how compliance will be checked. It must also align with all relevant laws, directives, regulations, and internal standards.

The organisation must appoint the chief information security officer (CISO) (or a delegated Physical Security Policy Owner) to manage producing, recording, and sharing the policy and supporting procedures with the CISO, chief information officer (CIO), Facility Security Officers, operational technology (OT) site managers, and all security programme leads.

The policy must be reviewed and updated at least every year, and also after security incidents, audit findings, significant changes in risk, or updates to regulations or internal policy. The procedures must be reviewed and updated at least every year, and also after security incidents, audit findings, major changes to facilities, or changes to relevant laws or directives. The procedures must be shared with Facility Security Officers, Physical Security Officers, OT site managers, and system security officers.

##### Authoritative PE policy pack with owned review and controlled dissemination

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-level **physical and environmental protection policy** and **supporting procedures** that put the PE controls into practice across the organisation. The policy and procedures must have a named owner, be shared with the defined roles, and be kept up to date.

###### WHY (control requirement)
PE-1 requires that physical and environmental protection policy and procedures are put in place and kept current, so that PE controls are applied consistently and updated as risks and circumstances change. The guidance says that the security and privacy programmes must work together, that an organisation-level policy is preferred, and that updates must be triggered by assessment and audit findings, security incidents or breaches, and changes to relevant laws, directives, regulations, policies, or standards.

###### HOW (specific steps/approach)
1. **Define the policy pack**: publish one official organisation-level policy document (or a small set of linked policy documents) and a set of procedure documents or modules that explain how PE controls are carried out (for example: secure areas, visitor and supplier access, escorting, how CCTV and monitoring are handled, environmental protections, facility access control processes, and coordination for incident or breach response involving physical events).
2. **Assign an official owner**: appoint the **CISO (or delegated Physical Security Policy Owner)** as the official responsible for managing the policy and procedures (creating them, updating them, approving them, and sharing them).
3. **Define who receives what**:
   - Share the **policy** with: **CISO, CIO, Facility Security Officers (FSOs), operational technology (OT) site managers, and all security programme leads**.
   - Share the **procedures** with: **FSOs, Physical Security Officers (PSOs), OT site managers, and system security officers**.
4. **Set review and update timing, and trigger events**:
   - Review and update the **policy** **at least annually** and after trigger events: security incidents, audit findings, material changes to risk assessments, or updates to relevant regulations or policies.
   - Review and update the **procedures** **at least annually** and after trigger events: security incidents, audit findings, major changes to facilities, or changes to relevant laws or directives.
5. **Publish in a controlled way and keep evidence**: store the policy and procedure pack in an organisation document repository with version control and access controls; record approval dates, review outcomes, and evidence that the named roles received and acknowledged the documents.
6. **Coordinate security and privacy**: involve Security Programme leads and privacy stakeholders in the policy and procedure development and maintenance process, so privacy impacts (for example, monitoring and how records are handled) are addressed, rather than treating PE as purely physical.

###### WHO (role responsible)
- **Policy owner**: CISO (or delegated Physical Security Policy Owner)
- **Contributors/approvers**: CIO representative, **FSO/PSO**, OT site managers, Security Engineering Lead, and Security and Privacy programme leads.

###### Acceptance criteria
- An organisation-level PE policy exists, is approved by the designated official owner, and is shared with the specified policy recipients.
- Supporting PE procedures exist, are approved by the designated official owner, and are shared with the specified procedure recipients.
- The policy is scheduled for review **at least annually** and updated after the defined trigger events.
- The procedures are scheduled for review **at least annually** and updated after the defined trigger events.
- Controlled repository evidence exists for: current version identifiers, approval and review records, and dissemination or acknowledgement records.

###### Actions Required for Compliance

- [ ] Draft an organisation-wide physical and environmental protection policy pack that includes its purpose, scope, responsibilities (physical security officer (PSO), facilities security officer (FSO), and Security Engineering Lead), how these roles coordinate, and the approach for meeting compliance requirements.
- [ ] Appoint the Chief Information Security Officer (CISO), or the delegated Physical Security Policy Owner, as the official person responsible for managing the policy and its procedures.
- [ ] Publish the policy and procedures in a controlled shared location with version history and an approval workflow.
- [ ] Share the policy with the Chief Information Security Officer (CISO), Chief Information Officer (CIO), Field Security Officers (FSOs), operational technology (OT) site managers, and all security programme leads, and record proof that they have acknowledged it.
- [ ] Share the procedures with financial security officers (FSOs), programme security officers (PSOs), operational technology (OT) site managers, and system security officers, and record proof that they have acknowledged receipt.
- [ ] Set review and update schedules: review the policy every year and also after any trigger events; review the procedures every year and also after any trigger events.
- [ ] Set up a process to collect “trigger events” so that audit findings, security incidents, major changes to facilities, and regulatory updates are sent into the review workflow.


---

### PE-2 — Physical Access Authorizations (Control)

This requirement is about ensuring that only the right people can physically enter the building where the system is kept, and that their access remains up to date. Without a clear, approved list and regular checks, former staff, contractors, or the wrong people could keep their access badges or cards, which could allow unauthorised entry to sensitive areas and increase the risk of theft, disruption, or misuse.

To meet this requirement, the organisation must create, formally approve, and keep up to date a written or electronic list of everyone authorised to access the site, including which areas each person can enter. It must issue site access credentials—such as identity badges, identification cards, or smart cards—only to people on that list. It must set the appropriate level of credential strength in line with the relevant rules and policies. It must review the authorised access list at least every 90 days, and promptly remove anyone whose access is no longer needed by revoking or disabling their credentials.

Visitors must be managed through the visitor authorisation process. People with permanent access must be treated as authorised personnel and included on the list.

##### Authorised facility access list with automated badge issuance/revocation

- Category: Software
- Priority: Critical

###### WHAT
Set up and run an auditable, official **Authorised Facility Access List** for employees and contractors (people who have permanent physical access). The list must show the **areas/levels** each person is allowed to enter. Only issue physical access credentials (ID badges/identification cards/smart cards) **to people on the approved list**. **Review the list at least every 90 days**, and **quickly remove/disable access** when it is no longer needed.

###### WHY (control requirement)
This requirement (PE-2) says physical access permissions must be controlled using an approved list and a clear credential lifecycle. It covers employees and visitors, but permanent credential holders are **not** treated as visitors. Credentials must be issued based on the authorised list. The strength of credentials must be set according to the relevant requirements. The access list must be reviewed at least every 90 days, and access must be removed and credentials revoked/disabled when no longer needed.

###### HOW (specific steps/approach)
1. **Create an official access information structure** for facility access: person identity, employee/contractor status, access level, and the permitted areas/doors (or access groups linked to doors).
2. **Set up a controlled process** to produce the approved Authorised Facility Access List (electronic or paper). This must include named approvers (for example, facility/security operations and line management) and keep records of approval.
3. **Connect the identity sources** (human resources information system and contractor lifecycle feeds) to the process, so joiner/mover/leaver changes trigger access requests and updates to list membership.
4. **Link the process to the physical access management system** so badge issuance, updates, and removal are automated based on list membership (badge ID ↔ person ↔ access level ↔ date/time). When someone is removed from the list, their access must be disabled immediately.
5. **Run the 90-day re-check process**: create review tasks by access group. Reviewers must confirm the person still needs and is eligible for access. Record the results (kept/removed) and keep evidence that checks were completed.
6. **Set and apply credential strength rules** (for example, badge technology and how strongly the person is verified) based on risk and applicable laws/regulations/policies. Use stronger verification for restricted areas where required.
7. **Manage visitors separately**: ensure visitor access is handled through the visitor authorisation process (and not treated as permanent list membership). Permanent credential holders must remain on the authorised list.

###### WHO
- **Facility Security Manager / Physical Security Lead**: owns the access list governance, approvals, and decisions about credential strength.
- **Identity and Access Management (IAM) Engineer**: builds the connections with the human resources and contractor systems and the physical access management system.
- **HR Operations / Contractor Management**: provides lifecycle information and ensures joiner/mover/leaver updates happen on time.
- **Line Managers / Area Owners**: carry out the 90-day re-check confirmations for whether access is still needed.

###### Acceptance criteria
- There is an **approved, official** Authorised Facility Access List showing each person’s permitted areas/levels.
- Physical access credentials are issued **only** to people on the approved list (with automated records of issuance).
- The authorised access list is **reviewed at least every 90 days**, with retained evidence of eligibility/need checks and the outcomes.
- When access is removed, credentials are **promptly revoked/disabled**, with audit records showing when disablement happened.
- Visitor access is handled through the **visitor authorisation process**, and permanent access holders are not incorrectly treated as visitors.
- Credential strength is defined and applied according to organisational and risk requirements for the relevant areas.

###### Actions Required for Compliance

- [ ] Set up the official facility access information model, including a person’s identity, their access level, and which areas or doors they are allowed to use. Then link each access group to the specific physical doors it can open.
- [ ] Set up a controlled process to create and approve the Authorised Facility Access List, with named approvers and records of the approval evidence.
- [ ] Integrate human resources information system (HRIS) and contractor lifecycle updates into the workflow so that access list membership is automatically updated for joiners, movers, and leavers.
- [ ] Connect the approved list process to the physical access management system so badge requests are automated, including issuing new badges, updating details, and disabling badges when needed.
- [ ] Set up 90-day access reviews for each access group, and require documented confirmation from the reviewer that the person still needs access and is still eligible.
- [ ] Set a policy for how strong badge and sign-in credentials must be, based on the risk level of each area, and apply this policy when issuing badges.
- [ ] Set up visitor authorisation as a separate process, so visitors are not added to the permanent list of members.


---

#### PE-2.1 — Access by Position or Role (Enhancement)

This requirement is about making sure only the right people can physically enter the building where the system is kept, based on their job. Without this, unauthorised staff, contractors, or visitors could enter sensitive areas, interfere with equipment, or disrupt services simply because access was given for convenience rather than need.

To meet this expectation, the organisation must set clear rules that link each job role to specific entry and exit points for the facility. It must also include authorised permanent and routine maintenance staff, duty officers, and emergency medical staff.

The organisation must keep up-to-date records showing which roles are allowed to use which doors or routes. It must also maintain written procedures for how these permissions are approved, recorded, updated when roles change, and removed when people leave.

The organisation should ensure that access activity is logged at the relevant entry and exit points, so permissions can be checked against actual use.

##### Role-to-door access matrix with approval and PACS enforcement

- Category: Manual
- Priority: Critical

###### WHAT
Set up an organisation-controlled **role-based authorisation process** for physical access. This process links **authorised job positions/roles** to the specific facility entry and exit points (doors, gates, and other controlled routes) for the facility where the system is located. It must include **permanent and routine maintenance staff, duty officers, and emergency medical staff**.

###### WHY (control requirement)
PE-2(1) requires that physical access to the facility where the system is located is **authorised based on job position or role**. Role-based access must cover the specified role types.

###### HOW (specific approach)
1. **Define the facility boundary and entry/exit points**: create an official list of the doors, gates, and controlled routes that make up access to the system facility.
2. **Create and maintain a role-to-entry/exit-point access matrix**: for each facility, define which roles are allowed at each entry/exit point. This must explicitly include routine maintenance staff, duty officers, and emergency medical staff.
3. **Set up a controlled authorisation lifecycle**: request access by role, check that the role is eligible, get approval from the named approver (for example, the facility security manager or operations owner), record the change, and apply it to the physical access control system (PACS).
4. **Enforce through PACS role groups (not one-off, person-by-person exceptions)**: configure door controllers/PACS to grant access based on **role group membership** (for example, “Duty Officer – Facility A – Door 3/4”). This ensures the matrix mapping is what is enforced.
5. **Handle joiner/mover/leaver and role changes**: when human resources (HR) or job function changes, trigger a controlled update so access permissions are updated and removed in line with the authorisation lifecycle.
6. **Keep records that can be audited and access logs**: retain evidence of (a) the version of the role-to-door matrix and its approvals, and (b) physical access activity at the relevant entry/exit points (who, where, when, and the role/authorisation basis where available).
7. **Document in the system security plan**: reference the role-to-entry/exit-point matrix, how PACS enforces it, and who is responsible for maintaining and reviewing authorisations.

###### WHO (roles responsible)
- **Facility Security Manager / Security Operations**: owns the role-to-door matrix and controls how PACS is configured.
- **System/Operations Owner**: approves the role definitions for the system facility and confirms operational need.
- **HR / Identity Management**: provides the authoritative role/job-function information and triggers role-change events.
- **Physical Access Control Administrator**: implements PACS changes and ensures logging is turned on.
- **Information Security / Compliance**: ensures the system security plan references this approach and that evidence is kept for audit.

###### Acceptance criteria
- A current, version-controlled **role-to-entry/exit-point matrix** exists for each system facility and includes the required role types (routine maintenance staff, duty officers, emergency medical staff).
- PACS/door controllers enforce access permissions according to the matrix (role groups), with no uncontrolled one-off door permissions for those roles.
- There is an auditable authorisation record for every matrix change (request, approval, implementation, and effective dates).
- Joiner/mover/leaver (role change) events lead to timely updates and removal of physical access permissions.
- Physical access logs for the relevant entry/exit points are enabled, retained, and can be linked back to the authorised role basis for access events.

###### Actions Required for Compliance

- [ ] Create an official list of all facility entry and exit points that are on the system’s facility boundary.
- [ ] Create and publish a matrix showing which roles are allowed to enter and leave each access point, including for routine maintenance staff, duty officers, and emergency medical staff.
- [ ] Set up a controlled process for granting role-based access (request, check, approve, log, apply, and review).
- [ ] Set up the door access controllers and public address and control system (PACS) so they grant permissions based on role groups that match the access matrix, with no individual (per-person) exceptions that are not managed.
- [ ] Set up joiner, mover, and leaver checks to update and remove physical access when people’s roles change
- [ ] Enable and keep physical access logs at every relevant entry and exit point, and link the evidence to the authorised role that justifies access.
- [ ] Update the system security plan to reference the matrix, the picture archiving and communication system (PACS) enforcement mechanism, and the responsibilities.


---

#### PE-2.2 — Two Forms of Identification (Enhancement)

This requirement is about making sure visitors prove who they are twice before being allowed into the building where the organisation’s systems are kept. It matters because if someone could enter using only one proof of identity, the wrong person could get onto the site, tamper with equipment, or gain a foothold that leads to wider harm.

To meet this expectation, the organisation must require visitors to show two forms of identification selected from: a passport, a REAL ID-compliant drivers’ licence, a personal identity verification (PIV) card, a key card, a PIN, or biometrics such as a fingerprint or face recognition. The organisation must apply this “two forms of identification” rule for access to that specific facility.

For automated entry, the organisation should allow entry using the approved options that match the access method, including personal identity verification (PIV) cards and/or key cards, and where appropriate a PIN and/or biometrics.

##### Enforce two-ID visitor admission for the system facility

- Category: Software
- Priority: Critical

###### WHAT
Set up a visitor sign-in process and enforce access controls so that **visitor entry to the facility where the system is located** is allowed only after the visitor shows **two forms of identification** chosen from the organisation’s approved list.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-2(2)** requires: **“Require two forms of identification from the following forms of identification for visitor access to the facility where the system resides: {{ insert: param, pe-02.02_odp }}.”** The guidance also explains which identification is acceptable (for example: passports, driver’s licences that meet REAL ID requirements, and personal identity verification (PIV) cards; and for automated systems, PIV/key cards, personal identification numbers (PINs), and biometrics).

###### HOW (specific steps/approach)
1. **Define and put the approved identification list into operation** using **param pe-02.02_odp** (passport, REAL ID-compliant driver’s licence, PIV card, key card, PIN, biometrics) in the visitor management system (VMS) and/or the physical access management system integration.
2. **Configure the visitor check-in workflow** so that **two separate evidence items** are required before a visitor credential/pass is issued or activated. The workflow must confirm that both items come from the approved list and that they are recorded in the visitor’s record.
3. **Apply the “two identification” rule at the facility entry points** by linking credential activation/authorisation to a recorded status such as **“two-ID verified”** and to the correct **facility/zone**. In other words, the credential must only be valid for the specific facility where the system is located.
4. **Support automated entry methods** by ensuring automated gates/door controllers allow entry only when the credential is in the **two-ID verified** state. If the facility uses automated methods, allow combinations that include **PIV and/or key cards**, and optionally **PIN and/or biometrics**, in line with the control guidance.
5. **Create audit-ready records**: record the result of the two-ID check, the specific identification types used, date and time, the identity of the staff verifier (if staff verification is used), and the resulting access authorisation/door events.

###### WHO (role responsible)
- **Physical security lead / facilities security manager**: owns the visitor admission process and enforces access at facility entry points.
- **Identity and access management (IAM) / access control engineer**: implements the VMS-to-access-control connection and the credential activation rules.
- **System owner / application security lead**: ensures the facility/zone mapping covers the boundary of where the “system resides” and that logs are kept for audit.

###### Acceptance criteria
- A visitor cannot receive an active credential/pass for the system facility unless **two approved identification types** from **pe-02.02_odp** are recorded as verified.
- Automated doors/gates must block entry when the credential is not marked **two-ID verified** or is not limited to the correct facility/zone.
- Audit logs must show: (a) the two-ID verification event, (b) the two identification types used, (c) timestamps and verifier identity (if applicable), and (d) access authorisation/door events for the facility.
- Test evidence shows at least one valid identification combination and at least one invalid attempt (for example, only one identification type) is correctly rejected.

###### Actions Required for Compliance

- [ ] Set up the visitor management process so that, before any access credentials are issued or activated, it requires exactly two different types of identification from **pe-02.02_odp**.
- [ ] Set up facility and zone scoping so the issued credential only authorises access to the facility where the system is located.
- [ ] Link the video management system (VMS) credential activation status to door and gate access control, so entry is refused unless the status is marked “two-ID verified”.
- [ ] Enable automated support by matching the approved allowed combinations to a Personal Identity Verification (PIV) card or key card, and optionally to a personal identification number (PIN) and/or biometrics, according to the approved set.
- [ ] Record and keep audit logs showing the two identification types used, the verification result, the date and time, and the resulting access authorisation and door events.
- [ ] Test valid two-identifier combinations and try invalid single-identifier attempts to confirm the rules are enforced at both the check-in point and the access points.


---

#### PE-2.3 — Restrict Unescorted Access (Enhancement)

This expectation is about keeping the room where the system is kept secure and locked, so that only the right people can enter without being supervised. If unsupervised access is allowed too widely, unauthorised staff or visitors could see sensitive information, interfere with it, remove it, or disrupt the system in ways that are difficult to detect later.

To meet this expectation, the organisation must keep an up-to-date, documented list of everyone who is allowed to enter the facility without an escort. This permission must be formally approved for all information held by the system, not just part of it. Anyone who does not have the required formal authorisation, security clearance, and a demonstrated need to know must be escorted at all times by staff who are themselves authorised to escort and to enter without an escort.

The organisation must also keep records of who is authorised, who accessed the facility and when. Access credentials must be issued only to authorised people and promptly withdrawn when authorisations change or end.

##### Unescorted access enforced via “all-information” badge authorisation

- Category: Software
- Priority: Critical

###### WHAT
Put in place an access decision that allows **entry without an escort only** for staff whose **formal access permissions cover every piece of information held in the system** (per `pe-02.03_odp.01`). Everyone else must be **escorted by staff who have the correct physical access permissions** (per `pe-02.03_odp.02`).

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **PE-2(3)** requires that unescorted access is limited to people whose permission scope matches what the organisation defines as covered (`{{ insert: param, pe-02.03_odp.01 }}`). Guidance also requires that anyone without the required clearances, approvals, and “need to know” is escorted by someone who has the correct physical access permissions.

###### HOW (specific approach)
1. **Create an “all-information” permission scope model** for the facility access decision: list the system’s information that is in scope (applications, databases, administration consoles, data stores, and any hosted services) and make sure this scope is clearly linked to the facility access decision.
2. **Keep one single, official permission record for each person** that includes: (a) which system(s) they are allowed to access, (b) the **information coverage** (it must cover *all* in-scope information for the system), (c) the dates the permission is valid, and (d) proof of approval.
3. **Set up an authorisation-to-physical access control system (PACS) rule** (policy-as-code or an equivalent method) that sets an attribute such as `unescorted_allowed = true` only when the person’s formal permission covers **all** in-scope information for the system and is currently valid.
4. **Connect this to the PACS/badge system** so door and area access is applied automatically:
   - Doors/areas open without an escort only for identities with `unescorted_allowed = true`.
   - For other identities, configure the PACS to block unescorted entry or start an **escort-required process** (for example, an escort badge must be shown; the escort person must also be physically authorised for the facility).
5. **Make sure escort staff are physically authorised** by allowing escort-only access only for identities that have the organisation-defined physical access permissions (`pe-02.03_odp.02`) and whose permissions are currently valid.
6. **Log physical access events that can be audited** in the access control logs: identity, area/door, time, and whether the entry was unescorted or escort-assisted (including the escort identity when escort-assisted).
7. **Control the permission mapping and evidence** by linking the policy version and the “all-information” scope mapping to the system security plan, so auditors can see why unescorted access was allowed.

###### WHO
- **Facility Security Officer (FSO)**: owns the formal access permission scope (`pe-02.03_odp.01`) and the physical access permissions for escorts (`pe-02.03_odp.02`).
- **Identity and Access Management (IAM) / Security Engineering**: builds the permission scope model, implements the decision logic for the policy-as-code approach, and provides the required attributes.
- **Physical Security / PACS Administrator**: sets up the PACS door/area rules and the escort process.
- **System Owner / Authorising Official**: ensures the security plan points to the control implementation and the supporting evidence.

###### Acceptance criteria
- A person is granted **unescorted** facility access only if their formal access permission covers **all** in-scope information for the system and is currently valid.
- A person whose permission does not cover all in-scope information is **never** granted unescorted access; access is denied or requires an escort process.
- Escort-assisted entries show the escort identity and are allowed only when the escort identity has the required physical access permissions.
- PACS logs record unescorted versus escort-assisted events with enough information to support audit.
- The system security plan includes traceable references to the “all-information” scope mapping and the version of the policy decision logic.

###### Actions Required for Compliance

- [ ] Define which information assets are in scope for the facility access decision.
- [ ] Create and approve a formal “all-information” authorisation scope record for each person.
- [ ] Set the `unescorted_allowed` setting only when the authorisation covers all information that is in scope.
- [ ] Use the calculated attribute as part of the physical access card (badge) setup in the physical access system, so door entry is automatically enforced.
- [ ] Set up the picture archiving and communication system (PACS) escort process so that people who are not authorised cannot enter areas without an escort, and so that an escort identity is always required.
- [ ] Enable and keep physical access logs that record whether someone was unescorted or escorted, and—if escorted—the identity of the escort.
- [ ] Update the system security plan by adding links to the evidence that shows how the scope was mapped and which version of the policy decision logic was used.


---

### PE-3 — Physical Access Control (Control)

This requirement is about making sure only authorised people can physically enter your building and any sensitive areas, and that you can prove who went where. Without it, unauthorised visitors, staff, or intruders could enter through entrances, vehicle access points, loading areas, or restricted rooms, and then access valuables, systems, or information.

To meet this expectation, the organisation must check each person’s permission to enter before allowing access at the main entrance, vehicle gate, loading bay, and every interior restricted-area door. It must also control entry and exit at these points using guards.

The organisation must keep records of door access for all exterior doors, loading bay doors, and restricted-area interior doors. For publicly accessible areas, it must prevent unauthorised movement into non-public areas by using badge-controlled entry, staffed reception/guards during the handover from public to secure areas, and access logs for non-public doors.

All visitors to non-public areas must be escorted at all times, and their entry and exit must be recorded.

The organisation must securely manage keys, lock parts, access cards, and card readers. It must inventory these items every quarter, and change lock combinations immediately if any are lost, compromised, or when the holder leaves or is transferred—otherwise at least every 12 months. Keys must be changed immediately if lost, or when the holder leaves or is transferred—otherwise at least every 12 months.

##### Integrated PACS access authorisation, visitor escort, and audit logs

- Category: Software
- Priority: Critical

###### WHAT
Set up an integrated **Physical Access Control System (PACS)** that: (1) checks physical access permissions at agreed entry and exit points, (2) controls entry and exit using badge-controlled access points and staffed guard or reception processes at handovers from public areas to secure areas, (3) keeps physical access records (audit logs) for agreed doors, and (4) requires visitor escort and records visitor entry and exit when visitors go into non-public areas.

###### WHY (control requirement)
**PE-3** requires physical access controls for employees and visitors, including controls at agreed entry and exit points, use of guards where the organisation decides they are needed, keeping physical access records for both public and non-public transitions, and clear rules for when visitors must be escorted, including controlling visitor activity and recording visitor entry and exit.

###### HOW (specific steps/approach)
1. **Define and set up access points in the PACS** for: the main entrance, vehicle gate, loading bay, and all interior restricted-area access points. Link each one to a door controller or reader, and label it as a **public-to-non-public transition**.
2. **Check permissions**: configure each reader or door controller so access is granted only when the presented badge or credential matches an active permission for that specific door or point (including immediate cancellation if a person’s access is transferred or ended).
3. **Control public-to-secure handovers**: use badge-controlled entry for publicly accessible areas. For non-public areas, enforce a **“no unescorted access”** rule by linking PACS rules with the guard or reception process. For example: when a visitor checks in, the check-in process triggers the escort requirement; the door controller blocks visitor credentials unless an escort (authorised escort session) is active.
4. **Physical access audit logging**: turn on automatic logging for all exterior site doors, loading bay doors, and interior doors to restricted areas. Record, at minimum: date and time, door or reader ID, badge or identity reference, whether access was granted or denied, and the event type (including failed attempts).
5. **Visitor escort and logging**: set up a visitor process that requires escort at all times for visitors entering non-public areas. Ensure visitor entry and exit are recorded for the agreed non-public doors or points, and that the PACS supports temporary permissions limited to the visitor’s escort session and the doors they are allowed to use.
6. **Evidence and retention**: send PACS logs to the organisation’s approved logging and **security information and event management (SIEM)** system, with protections to keep the records trustworthy (such as restricted administrator access and tamper-evident storage where available) so audit evidence for **PE-3** can be produced.

###### WHO
- **Physical Security Lead / Facilities Security Manager**: responsible for defining access points, the guard or reception workflow, and enforcing the visitor escort policy.
- **Identity and Access Management (IAM) Lead**: ensures badge or permission lifecycle is integrated (joiner, mover, leaver) and that access is revoked when required.
- **PACS Administrator / Operational Technology (OT) or Infrastructure Engineer**: configures door controllers and readers, logging, and system integrations.
- **Security Operations (SOC/Monitoring)**: checks that logs are received correctly, manages alerts (for example, repeated denied attempts), and ensures evidence is kept for audit.

###### Acceptance criteria (verifiable)
- Access is denied at each agreed entry and exit point unless the credential is currently authorised for that specific door or point.
- Physical access logs are created and retained for **all exterior site doors, loading bay doors, and interior restricted-area doors**, including both granted and denied events.
- Visitors trying to access non-public areas are blocked unless the escort requirement is met under the agreed visitor process, and visitor entry and exit are recorded.
- Audit evidence can be produced showing: (a) which credentials were used at each door, (b) whether access was granted or denied, and (c) visitor entry and exit for non-public areas.

###### Actions Required for Compliance

- [ ] Identify and record every approved entry and exit point in the public address and control system (PACS), including the main entrance, vehicle gate, loading bay, and doors inside restricted areas.
- [ ] Connect the picture archiving and communication system (PACS) to the organisation’s official identity and access approval system to control entry by each door and to remove access immediately when an employee is transferred or their employment ends.
- [ ] Set up badge-controlled entry from public areas to secure areas, and apply a rule that prevents visitors from accessing non-public doors unless the required escort process conditions have been met.
- [ ] Set up and centralise automated records of physical access checks for all exterior doors, loading bay doors, and doors inside restricted areas, including records of denied entry events.
- [ ] Set up a visitor process that requires an escort at all times, and record when visitors enter and leave non-public areas.
- [ ] Check that logs are complete and kept for the right length of time by testing the full process of creating evidence for a sample of access events and visitor sessions.


---

#### PE-3.1 — System Access (Enhancement)

This requirement is about making sure only the right people can physically enter the areas where the organisation’s most important system equipment is kept, such as the server room, the secure network equipment room, and any dedicated data centre cage. Without this, someone who should not be there could tamper with or steal equipment, disrupt services, or gain access that could lead to wider harm.

To meet this expectation, the organisation must clearly define these protected areas, allow entry only to people who have been formally approved to access them, and provide the correct entry credentials (such as badges, keys, or equivalent) that match that approval. It must also apply the right physical security measures for each area, control and identify the entry and exit points, and keep records of access attempts so they can be checked later.

Responsibilities must be assigned, procedures must explain how access is granted, reviewed, and removed, and the approach must be documented in the system plan.

##### Enforce area-specific physical access authorisations for system rooms

- Category: Software
- Priority: Critical

###### WHAT
Apply physical access permissions specifically to the system-protected physical areas (for example: server room, secure network equipment room, and a dedicated data centre cage). Only allow entry when the person (or their credential) is authorised for that exact area.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-3(1)** enhancement requires: **“Enforce physical access authorizations to the system in addition to the physical access controls for the facility”** for the organisation-defined system physical areas (**param: pe-03.01_odp**). This adds extra protection for areas where system components are concentrated.

###### HOW (specific steps/approach)
1. **Set up system-protected areas in the access control system**: Create separate zones, doors, and entry points for each physical space listed in **pe-03.01_odp** (for example: server room, secure network equipment room, dedicated data centre cage). Make sure the access control system can tell each area/door apart.
2. **Link credentials to area-specific permissions**: Configure door controllers and access groups so that a badge or key credential works only for the area(s) the person is explicitly authorised to enter. Do not allow general, building-wide credentials to grant access to these system areas.
3. **Connect badge/key issuing and removal to an approved authorisation process**: Use the organisation’s identity and request process (for example: human resources information system (HRIS) or identity and access management (IAM) plus ticketing) so that approval triggers credential issuing. When authorisation is removed, revoke the credential immediately (including during offboarding and when roles change).
4. **Turn on and centralise physical access event logging**: Enable logging at the controller level and send it to the security information and event management (SIEM) or log platform with audit-ready details: date and time, person/credential identifier, entry point/door, the mapped system area, and the outcome (granted/denied).
5. **Run regular access checks for each system area**: Periodically review who currently has permissions for each defined system area and fix any mismatches (for example: a credential is still active even though authorisation was removed).
6. **Document procedures for the full authorisation lifecycle**: Keep clear procedures for how permissions are requested, approved, issued, changed, reviewed, and revoked for each system area. Include responsibilities for the access control administrator and the security/operations approvers.

###### WHO (role responsible)
- **Physical Security / Access Control Administrator**: sets up zones/doors, links credentials to areas, and manages logging.
- **Security Governance / Compliance Lead**: ensures procedures and review timing meet the evidence needs for PE-3(1).
- **IAM/HR Workflow Owner**: ensures authorisation approvals and removals drive the credential lifecycle.
- **System/Infrastructure Owner (or delegate)**: confirms that area access requirements match where system components are concentrated.

###### Acceptance criteria
- Each system-protected physical space in **pe-03.01_odp** is set up as a separate access control zone/door group in the access control system.
- Credentials allow entry **only** to the authorised system area(s); attempts to enter without valid area-specific authorisation are denied.
- Credential issuing and removal follow the approved authorisation workflow, with removal happening within the organisation-defined operational timeframe (and no access remaining after authorisation is removed).
- Physical access logs provide audit evidence for every attempt: who/credential, which door/entry point, which system area, and whether access was granted or denied.
- Regular reviews are completed and any discrepancies are resolved, with documented outcomes.

###### Actions Required for Compliance

- [ ] Create separate access control zones (door groups) for each physical location listed in **pe-03.01_odp**.
- [ ] Set up door controller rules so that each credential is valid only for the relevant area access group(s).
- [ ] Link the issuing and cancelling of badges or keys to the approved physical access authorisation process.
- [ ] Enable logging of controller events and send those events to the security information and event management (SIEM) system, including the door, area, credential or person ID, and whether access was granted or denied.
- [ ] Run and record periodic access reviews for each system area, and fix any access mismatches.
- [ ] Publish and keep up-to-date procedures for the full authorisation process—request, approval, issuing, changing, reviewing, and revoking—assigning named responsibilities to specific roles.


---

#### PE-3.2 — Facility and Systems (Enhancement)

This requirement is about regularly checking the outside boundaries of your site. This helps prevent people from taking information or equipment out quietly, without permission. If these checks are not done, someone could take advantage of weak points such as gates, loading bays, external doors, or other entry and exit routes around the boundary to steal hardware, remove parts of systems, or move sensitive information out of the facility.

To meet this expectation, the organisation must carry out security checks along the facility or system’s physical perimeter every day during 24/7 operations, and also after any change to the perimeter (for example, new fencing, altered access points, or construction work) or after any security incident.

Named, responsible staff must follow documented procedures to inspect the perimeter for signs of tampering, forced entry, or gaps that could allow removal or unauthorised movement. They must also keep clear records showing when, where, and by whom the checks were carried out, including evidence of what was checked and any follow-up actions taken.

##### Daily perimeter security checks with zone coverage and tamper-evident logs

- Category: Software
- Priority: Critical

###### WHAT
Run a standard physical security check of the site perimeter based on location. These checks must be carried out **every day during 24 hours a day, 7 days a week**, and also **after any perimeter change or security incident**. Each check must look for **attempts to take information out of the site** and **removal of system components**, and must create **records that can be audited**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **PE-3(2)** enhancement requires: “Perform security checks {{ insert: param, pe-03.02_odp }} at the physical perimeter of the facility or system for exfiltration of information or removal of system components.”  
The organisation-defined parameter **pe-03.02_odp (frequency)** sets the requirement to check **daily during 24x7 operations, and after any perimeter change or security incident**. The guidance also expects organisations to decide the level of coverage and how often checks happen to reduce risk. This approach meets the required frequency and provides **auditable evidence**.

###### HOW (specific steps/approach)
1. **Create a perimeter coverage model**: split the perimeter into zones and list every place that can be checked for entry or exit (for example, gates, loading bays, external doors, service entrances, and boundary barriers). Map these to the facility or system layout documents.
2. **Define a documented inspection procedure**: give checkers a clear, written process for what to look for. Include visible signs linked to taking information out or removing components (for example, signs of forced entry, tampering, gaps or doors left unsecured, unusual activity, and evidence that equipment or storage media has been moved without authorisation).
3. **Set up daily 24x7 execution**: use shift-based tasking so that every zone and entry/exit point is checked each day during 24x7 operations. Make sure the task is automatically re-issued when a **perimeter change** or **security incident** is recorded.
4. **Use tamper-evident, add-only logging**: for each check, record the **date and time**, the **perimeter zone and entry/exit points checked**, the **checker’s identity**, the **result**, and the **evidence required** (such as photos or notes for any issues). Prevent changes to logs so they cannot be altered without detection.
5. **Set evidence and follow-up rules**: if anything suggests tampering or possible taking of information/removal of components, require evidence to be captured and a follow-up action to be created (for example, an incident or ticket reference) before the check can be marked complete.
6. **Assign named responsibility**: appoint authorised checkers and supervisors to carry out the checks and review them. Ensure only authorised people can complete checks in the process.

###### WHO
- **Site Security Manager / Physical Security Lead**: owns the perimeter coverage model, inspection procedure, and evidence/follow-up rules.
- **Authorised perimeter checkers (shift personnel)**: carry out the checks and record results and evidence.
- **Security Operations / Security Operations Centre (SOC) (if applicable)**: ensures that incident and perimeter-change triggers lead to the required post-event checks and that outcomes are reviewed.
- **IT/Identity team (if using a digital workflow)**: ensures access controls and tamper-evident logging are set up correctly.

###### Acceptance criteria
- For the last operational period, evidence shows **perimeter checks were completed daily during 24x7 operations** for all defined zones and entry/exit points.
- Evidence shows **extra checks were completed after every perimeter change and every security incident** that affected the physical perimeter.
- Every check record includes **date/time, location/zone or entry/exit points checked, checker identity, outcomes**, and **required evidence** for any issue.
- Records are **tamper-evident** (add-only or equivalent), and access to change or delete records is restricted.
- If an issue suggests possible taking of information or removal of components, a **follow-up action/incident reference** is created and linked to the check record.

###### Actions Required for Compliance

- [ ] Define the perimeter zones and list every entry and exit point that can be checked, mapped to the facility or system layout documentation.
- [ ] Create a documented perimeter inspection procedure that sets out what to look for to detect unauthorised information leaving the organisation and the removal of system components.
- [ ] Set up a shift-based process that creates and assigns daily perimeter inspection tasks for round-the-clock (24 hours a day, 7 days a week) operations.
- [ ] Automate re-checking the perimeter after changes to the perimeter and after security incidents.
- [ ] Set up tamper-evident, append-only logging for every check, using required information fields and restricting who can write to the logs.
- [ ] When anomalies are detected, require evidence to be captured (for example, photos or notes) and ensure the follow-up actions are linked as a required next step.


---

#### PE-3.3 — Continuous Guards (Enhancement)

This requirement is about having trained security staff physically present to stop unauthorised people from entering the areas where your systems are kept, all day and every day. Without continuous cover at the main entrance, the server room entrance, the loading dock access points, and the perimeter gate access points, someone could enter unnoticed, tamper with equipment, or gain access during quieter hours when checks are weakest.

To meet this expectation, the organisation must ensure security guards are on duty 24 hours a day, 7 days a week at each of these entry points. It must also clearly document the guards’ role, responsibilities, and working practices. The organisation must name the people responsible for these duties, keep records showing when guards are present and what they do, and keep evidence that the site is monitored to support the guards’ work.

The organisation must also ensure guards are trained and formally authorised to carry out access checks, and that the server room and perimeter gates have immediate, documented responses to any access incidents.

##### 24/7 guards at defined facility access points with auditable patrol logs

- Category: Manual
- Priority: Critical

###### WHAT
Provide continuous (24 hours a day, 7 days a week) physical guard coverage at the organisation-defined **physical entry points to the facility where the system is located**: **main entrance, server room entrance, loading dock access points, and perimeter gate access points**.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-3(3)** requires using guards to control the specified physical entry points **24/7**. The guidance expects guards to enable quick response and human observation in areas not covered by video.

###### HOW (specific approach)
1. **Define the guard coverage map**: record each entry point (main entrance, server room entrance, loading dock access points, perimeter gate access points) and confirm which doors/gates are used to enter and leave the system facility.
2. **Create standard operating procedures (SOPs) for each entry point type**: set out procedures for checking identity and authorisation, handling visitors and deliveries, escort rules (especially for the server room and perimeter gates), and what to do if authorisation cannot be verified (including escalation and refusal).
3. **Set up continuous rostered coverage**: maintain a named roster that ensures there are no coverage gaps across all entry point types (including nights, weekends, and public holidays). Use shift handover checklists and supervisor sign-off.
4. **Use electronic patrol/presence logging**: require guards to record time-stamped check-ins at each entry point type (and record denied entries and incidents as they occur). Ensure logs can be linked to a named guard and the specific location.
5. **Keep supporting evidence**: retain audit-ready records linking (a) roster/assignment, (b) patrol/presence logs, and (c) incident/response records (and any relevant surveillance references) for audit purposes.
6. **Train and formally authorise guards for these duties**: keep training records covering access verification, server room restrictions, delivery/visitor processes, and incident response and communication.

###### WHO
- **Head of Facilities / Security Operations**: owns the guard coverage map, rosters, and SOPs.
- **Security Supervisor**: ensures shift handovers happen correctly, checks patrol logging, and reviews incidents.
- **Information Security / System Owner (or delegate)**: confirms that server room and system-relevant access rules match the system security plan and the facility risk assessment.
- **Guards (authorised personnel)**: carry out the SOPs and complete electronic check-ins and incident reporting.

###### Acceptance criteria
- For each of the four entry point categories (main entrance, server room entrance, loading dock access points, perimeter gate access points), there is evidence of **24/7 guard coverage** with **no unauthorised coverage gaps**.
- Patrol/presence logs show **time-stamped check-ins** at the required entry points, attributable to **named, authorised guards**.
- SOPs exist and are followed for identity/authorisation checks, visitor/delivery handling, and escalation/refusal rules (with stronger controls for the server room and perimeter gates).
- Training and authorisation records exist for guards carrying out these duties.
- The audit package includes roster/assignment records, patrol/presence logs, and incident/response records, retained in line with the organisation’s retention requirements.

###### Actions Required for Compliance

- [ ] Document and get approval for the list of authorised facility access points, matched to the system’s physical entry and exit locations (main entrance, server room entrance, loading dock access points, and perimeter gate access points).
- [ ] Create standard operating procedures (SOPs) for each type of access point. Each SOP should cover: identity and permission checks, visitor and delivery processes, when an escort is required, and the rules for escalation or refusal.
- [ ] Set up a named, round-the-clock (24/7) rota with shift handover checklists to prevent any missed coverage at all agreed access points.
- [ ] Set up time-stamped electronic patrol and presence records that require location-specific check-ins, and record incidents automatically when they occur.
- [ ] Keep training records and formal authorisation records for guards carrying out these duties, including the server room and perimeter gate procedures.
- [ ] Define and keep an audit-ready set of evidence that links staff rosters and assignments, patrol logs, and incident and response records.


---

#### PE-3.4 — Lockable Casings (Enhancement)

This requirement is about keeping work phones, tablets, and portable notebook computers physically secure by storing them in lockable storage. It matters because the biggest real-world risk with portable devices is theft or unauthorised handling. If equipment can be taken from desks, rooms, or shared areas, sensitive work information can be exposed, and the organisation can face disruption and extra cost.

To meet this expectation, the organisation must protect every work-used portable notebook computer, tablet, and smart phone by storing it in a suitable lockable case, such as a lockable cabinet or enclosure, whenever it is not being used under authorised supervision.

The organisation must also:
- keep a documented list of which devices require this protection
- set out clear procedures for who can access the locked cases and how access is controlled
- include these responsibilities in its physical protection policy and system security planning
- keep records showing that this approach is in place and being followed

##### Lockable casings for work portable devices when unattended

- Category: Manual
- Priority: Critical

###### WHAT
Provide lockable physical housings (for example, lockable cabinets/enclosures and/or single-device lock boxes) to protect the organisation’s defined portable work devices—**portable notebook computers, tablets, and smart phones used for work**—from unauthorised physical access whenever they are **not under authorised supervision**.

###### WHY (control requirement)
NIST SP 800-53 **PE-3(4)** (enhancement) requires: **“Use lockable physical casings to protect {{ param, pe-03.04_odp }} from unauthorized physical access.”** The guidance notes that the biggest risk for portable devices is **theft**. Lockable housings can be secured using **cable locks** or **lockdown plates** to make it harder to remove the locked housing that contains the equipment.

###### HOW (specific approach)
1. **Define the scope list (device-to-housing mapping):** Keep an auditable register of all work-used portable notebooks/tablets/smart phones that must be protected with a housing (by asset tag/serial number, owner, location, and whether housing is required = yes). This meets the organisation-defined parameter **pe-03.04_odp**.
2. **Standardise housing types based on where and how devices are used:**
   - **Single-device housings** for individual laptops/tablets/phones in offices and meeting rooms.
   - **Multi-device cabinets** for shared areas (for example, reception and shared offices) and for storing spare devices.
   - Where appropriate, ensure housings can be secured with **cable locks or lockdown plates** so the locked housing containing the equipment cannot be easily removed.
3. **Use an “unattended → locked” routine:**
   - Require users to place the device into the correct lockable housing **whenever it is unattended** (for example, leaving a desk, attending meetings, end of shift, overnight storage).
   - Define what counts as **authorised supervision** (for example, the device is in the user’s immediate possession, or it is in a controlled area where unauthorised access is prevented).
4. **Control access to the housings:**
   - Use managed key control (key register, issuing and returning keys, and periodic checks to confirm keys are accounted for) or electronic locks with controlled access (badge/personal identification number (PIN)) and audit logs.
   - Limit access to authorised roles (for example, IT/Facilities security custodians and approved delegates).
5. **Keep evidence and check compliance:**
   - Record where housings are used (by location), the key/lock method used, and results from periodic physical spot checks.
   - Carry out scheduled checks (for example, monthly) in higher-risk locations and keep evidence for audit.
6. **Update the system security plan:** Include the housing standards, the device scope (pe-03.04_odp), covered locations, responsibilities, and how compliance will be verified.

###### WHO (roles responsible)
- **Information Security / Security Governance:** owns PE-3(4) compliance requirements and updates to the system security plan.
- **Facilities / Workplace Services:** provides and maintains physical housings and places them in agreed locations.
- **IT Asset Management:** maintains the device register for pe-03.04_odp and ensures devices are assigned to the correct housing type/location.
- **IT Security / Physical Security Custodians:** manages key/electronic lock access controls and performs/records spot checks.
- **All device users:** follow the “unattended → locked” routine.

###### Acceptance criteria (verifiable)
- An auditable register exists for **portable notebook computers, tablets, and smart phones used for work** (pe-03.04_odp) showing which devices require lockable housings.
- For each listed device location, a suitable **lockable physical housing** is installed (single-device or multi-device cabinet as defined).
- A documented procedure exists and is enforced: devices are placed in housings whenever unattended.
- Access to housings is restricted using managed keys or electronic locks with controlled access; key/lock access records and/or audit logs are retained.
- Monthly (or as defined) physical spot checks are completed with evidence retained, confirming devices are stored in locked housings when unattended.

###### Actions Required for Compliance

- [ ] Create and keep an auditable record of all devices for **pe-03.04_odp** (work portable notebooks, tablets, and smart phones), including each device’s **location** and whether its **casing is required**.
- [ ] Choose and standardise lockable casing types (single-device enclosures and multi-device cabinets), and set the rules for when cable locks and lockdown plates are required.
- [ ] Install the protective casings in every location identified as unattended-risk and label each one with the required storage procedure.
- [ ] Publish and train the “unattended → locked in casing” procedure, including clear definitions of what counts as authorised supervision and how exceptions are handled
- [ ] Use controlled access for casings by using managed keys or electronic locks, allowing entry only to authorised roles, and keeping records of access evidence.
- [ ] Update the system security plan to record the casing standards, who is responsible for them, and how compliance will be checked for PE-3(4).
- [ ] Carry out and record regular physical spot checks to confirm that devices are kept inside locked cases when they are not being used.


---

#### PE-3.5 — Tamper Protection (Enhancement)

This expectation is about making sure important hardware cannot be quietly opened, moved, or changed without clear evidence that it has been tampered with. If someone interferes with devices that protect your network, manage industrial systems, or provide security services, they could get around protections, introduce harmful changes, or swap equipment using supply-chain deception. You may not notice until after damage has been done.

To meet this expectation, the organisation must use tamper-evident seals, tamper-detection switches, and anti-tamper coatings on the relevant network security appliances, operational technology (OT) control gateways, and server hardware that hosts security services. It should use detection on some components and both detection and prevention on others where appropriate.

The organisation must also:
- document which safeguards apply to which components;
- include the approach in its physical protection policy and system security plan;
- define procedures and named responsibilities for physical access and for overseeing information security;
- ensure supporting measures are in place; and
- keep records showing the safeguards are applied, checked, and followed up when tampering is detected.

##### Tamper-evident seals and tamper detection on security hardware

- Category: Manual
- Priority: Critical

###### WHAT
Apply anti-tamper measures to the **hardware components** defined by the organisation: **network security appliances, OT control gateways, and server hardware hosting security services**. Use **tamper-evident seals** and **tamper-detection switches** (to detect) and, where the organisation chooses, **tamper prevention** (for example, anti-tamper coatings or other prevention measures) so that physical interference or changes cannot be done quietly.

###### WHY (control requirement)
NIST SP 800-53 **PE-3(5)** requires using the organisation-defined anti-tamper measures to **detect and/or prevent physical interference or changes** to the specified hardware components. The guidance explicitly allows mixed approaches (detection-only on some components; detection plus prevention on others) and the use of anti-tamper measures such as **tamper-evident seals, tamper-detection switches, and anti-tamper coatings**.

###### HOW (specific approach)
1. **Define what is covered (detection vs detection+prevention):** Create an official mapping that, for each asset, states which anti-tamper measures are used and whether the component is **detection-only** or **detection+prevention**, aligned to the organisation’s defined parameters:
   - anti-tamper measures: *tamper-evident seals, tamper-detection switches, anti-tamper coatings*
   - capability: *detect, prevent*
   - hardware components: *network security appliances, OT control gateways, server hardware hosting security services*
2. **Apply tamper-evidence to all covered security appliances/gateways:** Install **tamper-evident seals** on standard access points (for example, casing covers, maintenance panels, access screws) for each covered device model. Where possible, use seals that are uniquely identified/traceable so the evidence can be linked to a specific device and inspection.
3. **Add tamper detection where access is likely to be disturbed:** Install **tamper-detection switches** on selected components (for example, high-risk sites, devices that are frequently maintained, or where seals alone are not enough) to generate an alert if a cover/panel is disturbed and/or if the device is moved.
4. **Apply tamper prevention to selected server hardware:** Where the organisation selects **prevent** for server hardware hosting security services, apply **anti-tamper coatings** (or an equivalent prevention measure that is documented as part of the anti-tamper measures) to make unauthorised opening/replacement clearly visible or operationally difficult.
5. **Make tamper detection part of the incident process:** If tamper evidence is broken or a tamper-detection alert is raised, start a defined process: isolate the affected device (following a risk-based procedure), raise an incident/ticket, carry out forensic/inspection steps, and only return the device to service after verification and re-sealing.
6. **Inspection and evidence keeping:** Set an inspection schedule (based on risk) and record, for each covered asset: device identifier, seal serial/status, tamper switch status (if applicable), inspector identity, inspection date, and evidence (for example, photos where feasible). Keep records for audit and investigation.

###### WHO (roles responsible)
- **Physical security lead / OT security lead:** owns the coverage mapping and installation standards.
- **Infrastructure/OT engineering (network and OT gateway teams):** installs the seals/switches/coatings on the specified hardware.
- **Security operations (SOC) / incident response lead:** owns the tamper alert process and the criteria for isolating and returning devices to service.
- **Asset owner / system security officer:** approves the detection-only versus detection+prevention decision and ensures it is reflected in the system security plan documentation.

###### Acceptance criteria
- A documented, audit-ready **asset-to-technology mapping** exists covering all **network security appliances, OT control gateways, and server hardware hosting security services**.
- For each mapped asset, **tamper-evident seals** are installed at the defined access points, and seal status/serial numbers are recorded.
- For each mapped asset that requires detection, **tamper-detection switches** are installed and generate useful alerts (tested and validated).
- For each mapped server that requires prevention, **anti-tamper coatings** are applied and recorded.
- Tamper events (seal break or switch alert) reliably trigger the defined incident process, including isolation and verification before the device is put back into service.
- Inspection records (including evidence) are kept and show ongoing compliance with the defined inspection schedule.

###### Actions Required for Compliance

- [ ] Create a complete, authoritative list of the covered assets—network security appliances, operational technology (OT) control gateways, and servers that host security services—along with their physical locations.
- [ ] For each asset, record the decision on whether it will be monitored only (detection-only) or monitored and blocked (detect-and-prevent), and specify the anti-tamper technologies that will be used.
- [ ] Fit tamper-evident seals to the specified access points for each covered device model, and record the seal identification numbers and their status.
- [ ] Fit tamper-detection switches to selected components and confirm that any disturbance or movement triggers alerts that can be acted on.
- [ ] Apply anti-tamper coatings to selected server hardware where the organisation has chosen to prevent tampering and to record proof of this in the application evidence.
- [ ] Set up and run a tampering event process that covers: isolating the affected system, investigating what happened, verifying the findings, and then re-sealing or restoring it—assigning named responsibilities for each step.
- [ ] Set an inspection schedule based on risk, and keep evidence that is ready for audit (such as inspection records and photos where possible).


---

#### PE-3.7 — Physical Barriers (Enhancement)

This requirement is about using strong, physical protection—such as bollards, concrete slabs, jersey walls, or hydraulic vehicle barriers—to prevent people or vehicles from entering areas where they should not. Without these safeguards, someone could accidentally or deliberately reach sensitive areas and systems, which could result in theft, disruption, or unauthorised access.

To meet this expectation, the organisation must:
- limit access to the system by installing and using the correct physical barriers at the relevant entry points and access routes; and
- keep an up-to-date, documented list of which barriers are in place and their locations.

The organisation must also set out the physical access control steps in its Physical and Environmental Protection Policy, and record the same steps in its system security plan, ensuring the barrier list matches those procedures.

Finally, the organisation must clearly assign responsibility for physical access control and for overseeing information security, and keep supporting records showing that the barriers are managed and maintained.

##### Barrier inventory and access-route mapping for system entry points

- Category: Manual
- Priority: High

###### WHAT
Create and keep an up-to-date, auditable list of every physical access point that matters for system security (for example: perimeter gates, loading bays, and doors into communications rooms or server rooms). For each access point, record the exact physical barriers used to restrict entry (for example: bollards, concrete slabs, jersey walls, and hydraulic active vehicle barriers).

###### WHY (control requirement)
PE-3(7) (Enhancement) requires the organisation to **limit access using physical barriers**. The guidance specifically names **bollards, concrete slabs, jersey walls, and hydraulic active vehicle barriers**. Therefore, the list must be detailed by barrier type and by where it is placed at each relevant entry point/access route.

###### HOW (specific steps/approach)
1. **Define scope**: identify the application’s physical security boundary (for example: production, test, and disaster recovery [DR] sites/rooms, as applicable). Then list every access route/entry point that could allow unauthorised access.
2. **Create a barrier inventory** (a single source of truth) with these fields: barrier type (bollard/jersey wall/concrete slab/hydraulic active vehicle barrier/other), exact location reference (site ID plus drawing grid/coordinate), protected access point/route, and the related physical access control procedure reference.
3. **Populate and provide evidence**: use site surveys, architectural drawings/CAD/building information modelling (BIM) exports, and dated photographs to fill in the inventory. Keep the evidence with the relevant inventory entry.
4. **Align documentation**: update the **Physical and Environmental Protection Policy** to explain how the barriers limit access. Update the **system security plan** to reference the same procedure rules and the corresponding barrier inventory entries (ensuring the barrier list matches the procedures).
5. **Assign responsibilities**: name specific roles for (a) ensuring the physical access barriers work as intended (for example: facilities/security operations) and (b) overseeing that barrier effectiveness is managed properly (for example: security governance/ISO 27001 owner).
6. **Operational verification and records**: set a review/inspection schedule and keep records (inspection checklists, maintenance and change records) that reference the barrier inventory entry IDs.

###### WHO (role responsible)
- **Facilities/Physical Security Manager**: owns the barrier inventory content, evidence collection, and inspection/maintenance recordkeeping.
- **Information Security Manager / Security Governance Lead**: ensures the **Physical and Environmental Protection Policy** and the **system security plan** match the inventory.
- **System Owner / Application Security Owner**: confirms the scope of relevant access points for the application environments.

###### Acceptance criteria
- A controlled, versioned **barrier inventory** exists and is complete for all identified system-relevant access points/routes.
- Each inventory entry states the **barrier type** and **location**, and clearly shows which access point/route it protects.
- The **Physical and Environmental Protection Policy** and the **system security plan** reference the same barrier inventory/procedure rules, with no differences.
- Named responsibilities are recorded for both barrier effectiveness and security oversight.
- Inspection/maintenance records exist for the most recent review cycle and reference the relevant inventory entry IDs.

###### Actions Required for Compliance

- [ ] Identify and record all physical entry points and access routes that are relevant to system operation, across the production, test, and disaster recovery environments.
- [ ] Create a controlled barrier inventory template with fields for the barrier type, a location reference, and the protected access point or route.
- [ ] Update the inventory using on-site surveys, architectural drawings (computer-aided design/computer-aided design and building information modelling), and dated photographs.
- [ ] Update the Physical and Environmental Protection Policy to explain how access is restricted by using the documented barriers.
- [ ] Update the system security plan so it refers to the same barrier inventory entries and procedure rules, to ensure consistency.
- [ ] Assign named responsibilities for ensuring barrier effectiveness and for overseeing information security, and publish these responsibilities in the relevant governance documents.
- [ ] Set a regular schedule for inspections and maintenance, and keep records that refer to the barrier inventory entry IDs.


---

#### PE-3.8 — Access Control Vestibules (Enhancement)

This requirement is about creating a small, secure “waiting area” at the main entrances to sensitive areas. This prevents people from entering simply by following an authorised colleague inside. Without this two-step entry, an unauthorised person could gain access by walking in behind someone who has already been approved—a common issue known as tailgating. This could lead to theft, interference with equipment or records, or exposure of highly sensitive information and equipment.

The organisation must install access control vestibules at every main entry point to server rooms, classified storage areas, and processing areas controlled under the International Traffic in Arms Regulations (ITAR) and the Export Administration Regulations (EAR). Each vestibule must have two interlocking doors that cannot be opened at the same time. Entry into the secure area must only occur after the person’s physical access has been checked and approved.

The organisation must:
- keep an up-to-date list of all vestibule locations
- maintain clear written procedures for how the vestibules are used
- follow those procedures in practice
- include this approach in its system security plan
- assign named responsibilities for operating the vestibules and for oversight by information security staff

##### Automate interlocking vestibules at secure entry points

- Category: Software
- Priority: Critical

###### WHAT
Install access control vestibules at the organisation-defined locations (server rooms, classified storage, and ITAR/EAR-controlled processing areas) and configure them with **two interlocking doors** so that an unauthorised person cannot enter by following an authorised person (tailgating/piggybacking).

###### WHY (control requirement)
NIST SP 800-53 **PE-3(8)** enhancement requires: **“Employ access control vestibules at {{ param, pe-03.08_odp }}.”** The guidance specifies vestibules as a space between two interlocking doors to stop tailgating/piggybacking. It uses interlocking door controllers that can be fully or partially automated.

###### HOW (specific steps/approach)
1. **Define and document vestibule locations**: Create and maintain an authoritative vestibule register listing each vestibule location mapped to the required secure areas (from **pe-03.08_odp: locations**).
2. **Implement interlocking door logic**: Configure the vestibule door controllers so **only one door can be unlocked/opened at a time**, with a controlled vestibule state (for example, Door A unlocks only when Door B is confirmed closed/locked). Include controller timeouts and fault handling that match safety and life-safety requirements.
3. **Verify physical access before entry**: Link the first-door credential check to the physical access control system (PACS) so entry into the vestibule is allowed only after physical access authorisation is confirmed. Do not allow the second door unless the vestibule state shows the authorised person is present.
4. **Operational containment and monitoring**: Turn on event logging for interlock state changes, door-open/door-held conditions, and denied attempts. Send these events into the organisation’s physical security monitoring workflow and security information and event management (SIEM) process for auditability and incident investigation.
5. **Procedures and oversight**: Create standard operating procedures (SOPs) for normal operation and exceptions (for example, interlock faults, doors held open, emergency egress). Assign named responsibilities for operating the vestibules and for oversight by information security and physical security governance.
6. **System security plan update**: Record the vestibule approach, locations, controller behaviour, and monitoring evidence sources in the system security plan. Keep the vestibule register under change control.

###### WHO
- **Physical Security Engineer / PACS Integrator**: designs and configures interlocking vestibule controllers and the related integrations.
- **Information Security Manager (or delegate)**: ensures the approach is documented in the system security plan and that oversight responsibilities are assigned.
- **Facilities/Operations Lead**: checks that installations are correct, coordinates safety and life-safety constraints, and supports adoption of SOPs.

###### Acceptance criteria
- Vestibules are installed and working at **all** locations listed in **pe-03.08_odp** (server rooms, classified storage, ITAR/EAR-controlled processing areas).
- For each vestibule, the two doors are configured as **interlocking** so they cannot be opened at the same time; controller logic enforces a containment/vestibule state.
- Entry into the secure area happens only after **physical access authorisation** is verified for the first door, and the second door is not granted in a way that enables tailgating.
- Interlock events (including denied attempts and fault/held-open conditions) are logged and available for audit and incident response.
- A current vestibule register exists, SOPs are approved, responsibilities are assigned, and the system security plan reflects the implemented vestibule controls.

###### Actions Required for Compliance

- [ ] Create and keep up to date a vestibule register that links each required secure area to the correct vestibule location (from **PE-03.08 ODP**).
- [ ] Set up the door controllers for the picture archiving and communication system (PACS) so that only one vestibule door can be unlocked and opened at any time. Also define what happens in fault conditions and how long the system waits before timing out.
- [ ] Set up checks to verify credentials at the first door, and use vestibule rules so the second door cannot be used to follow someone through (tailgating).
- [ ] Enable and centralise event logging for changes in interlock status, blocked (denied) attempts, and door-held or fault conditions, and route these events into the organisation’s monitoring workflow.
- [ ] Write and get approval for standard operating procedures (SOPs) for normal use and for exceptions, including interlock faults, doors held open, and emergency exits. Assign specific named responsibilities for day-to-day operations and for oversight.
- [ ] Update the system security plan to include the vestibule locations, how the controllers should behave, and where the evidence comes from. Put the register under change control.


---

### PE-4 — Access Control for Transmission (Control)

This expectation is about protecting the physical parts that carry your organisation’s communications, such as network cabling, patch panels, wiring closets, and telecommunications distribution frames. These areas must be kept locked and protected from unauthorised access. Without these safeguards, someone could interfere with the wiring, disrupt services, or listen in or change connections in ways that may be difficult to detect later.

To meet this expectation, the organisation must:
- Clearly identify the specific locations where these components are kept.
- Restrict access to authorised personnel only.
- Ensure wiring closets are kept locked when not in use.
- Physically protect cabling using conduit or cable trays (or an equivalent protection method).
- Lock spare connection points, or otherwise prevent them from being used.
- Use tamper-evident seals where opening could occur.

The organisation must also:
- Document how physical access is managed in its procedures and system security plan.
- Keep system design and facility wiring diagrams up to date.
- Maintain a list of the physical safeguards in place.
- Assign named responsibilities for physical access and for overseeing information security.
- Keep supporting records showing that these measures are carried out.

##### Lock and protect MDF/IDF, patch panels, and spare jacks with seals

- Category: Manual
- Priority: Critical

###### WHAT
Put in place physical security controls for the organisation’s **system distribution and transmission lines** (network cabling, patch panels, wiring closets, and telecommunications distribution frames). Use measures such as **locked wiring closets, conduit or cable trays, locked spare jacks, and tamper-evident seals**.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-4** requires the organisation to **control physical access** to the defined transmission locations within organisational buildings, using the specified security measures. This helps prevent **physical interference**, **service disruption**, and unauthorised **listening in or changing** of transmissions.

###### HOW (specific approach)
1. **Create and keep an up-to-date inventory/map** of all protected transmission locations (main distribution frame (MDF)/intermediate distribution frame (IDF), communications rooms, wiring closets, patch panel banks, and telecommunications distribution frames). Include room/rack identifiers and the specific patch panel/termination areas covered.
2. **Make the physical layout harder to access** so cabling is not easily reached: run cabling through **conduit and/or cable trays** (or an equivalent physical protection method). Ensure any tray/conduit access points are also within **locked or enclosed** areas.
3. **Lock access points**: keep **wiring closets** locked when they are not being actively attended by authorised staff. Use keyed locks or badge-controlled access in line with the organisation’s physical security approach.
4. **Lock spare connection points**: stop unauthorised use of spare jacks by using **locked patch panels**, **locked blanking plates**, or **locked patch-cord management equipment** for spare or unused ports.
5. **Use tamper-evident seals** on covers/access points that could expose patching, spare jacks, or cabling routes (for example, removable side panels or access cover plates). Record the seal identifiers and where each seal is placed.
6. **Put access and evidence into day-to-day operation**: define a process for requesting and approving access, dealing with any seal break, and completing a close-out check after each access event. Keep evidence suitable for audit (seal register entries, inspection results, and access logs where available).

###### WHO
- **Facilities/Physical Security Manager**: responsible for locking enclosures, improving conduit/tray protection, and carrying out physical inspections.
- **Network/Telecom Engineering Lead**: responsible for the protected-location inventory/map and the design for locking patch panels/spare jacks.
- **Information Security (or Security Compliance) Officer**: approves the access process, seal handling process, and evidence requirements.
- **Authorised Personnel** (IT/telecom operations): carry out access under the process and complete the close-out verification.

###### Acceptance criteria
- A current inventory/map exists covering all **network cabling, patch panels, wiring closets, and telecommunications distribution frames** that require PE-4 physical access controls.
- All identified **wiring closets** are **locked** when not being actively attended by authorised personnel.
- Cabling is routed/contained using **conduit/cable trays (or an equivalent method)** so unauthorised physical access to transmission media is not easily possible.
- All **spare/unused jacks** are **locked** (for example, locked patch panels/locked blanking plates/locked patch-cord management equipment).
- **Tamper-evident seals** are applied to relevant covers/access points, and a **seal register** is kept with evidence of periodic reconciliation.
- A documented process exists for access, handling seal breaks, and completing close-out verification, with records kept for audit.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list and map of all locations of protected system distribution and transmission lines, including main distribution frames (MDF) and intermediate distribution frames (IDF), patch panels, wiring closets, and distribution frames.
- [ ] Install and check locked enclosures for all identified wiring cupboards and communications access points.
- [ ] Route and protect cabling using conduit and/or cable trays (or an equivalent physical protection method), and make sure all connection points are located within locked, restricted areas.
- [ ] Secure any spare or unused network connection points by using locked patch panels, locked blanking plates, or locked patch-cord management equipment.
- [ ] Apply tamper-evident seals to covers or access points that could reveal patching, spare jacks, or cabling routes, and record each seal’s ID and location in a register.
- [ ] Set up and document an access and approval process that includes how to handle cases where a seal is broken, and includes a check after access is completed to confirm everything is closed out correctly. Keep records that are suitable for audit.


---

### PE-5 — Access Control for Output Devices (Control)

This requirement is about keeping work results—anything shown on screens, printed, scanned, faxed, copied, or played through audio devices—out of the reach of anyone who should not see or take them. Without this, confidential information could be viewed, copied, or removed by unauthorised visitors or staff, simply by getting close to an output device or by taking printed pages before they are collected.

To meet this expectation, the organisation must keep all such output devices in secure rooms or other secured areas. These areas must be protected with keypad or card-reader entry, and only authorised people must be allowed in. The devices must be placed so staff can monitor them. Where there is a realistic risk that someone could see the screen from the side or overhear what is being played, privacy screen filters and headphones (or equivalent measures) must be used.

The organisation must also keep up-to-date records showing which devices and outputs are covered, document the procedures and the room layout, include this approach in its security plan, assign responsibility for controlling access and for oversight, and keep records of who accessed these secure rooms over time so access can be checked.

##### Secure output device rooms with controlled access and privacy measures

- Category: Manual
- Priority: Critical

###### WHAT
Put all covered output devices (monitors, printers, scanners, audio devices, facsimile machines, and copiers) in secure areas where physical entry is controlled (keypad or card reader) and where unauthorised people cannot obtain, view, or overhear the output.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53, Protection Element (PE)-5 requires controlling physical access to output from the organisation’s defined output devices to stop unauthorised people from obtaining the output. Further guidance also requires using secure areas, keypad or card access, staff visibility/oversight, and risk-based measures such as monitor or screen privacy filters and headphones.

###### HOW (specific steps/approach)
1. **Define the scope of covered output devices** by keeping an authoritative register (asset identification (ID) or serial number, device type, location, and output types such as print, copy, scan, fax, audio, and display) aligned to `pe-05_odp`.
2. **Set up secure areas (“output rooms”)** for these devices and ensure each area is protected by **keypad or card reader** access, with entry limited to **authorised individuals only**.
3. **Place the devices inside the secure areas** and position them so staff can monitor output collection and use (for example, devices placed so staff can observe output from their normal working positions).
4. **Add privacy and anti-“shoulder surfing” measures** where side viewing or overhearing is realistic: fit monitor or screen privacy filters on display devices and provide headphones (or equivalent measures) for audio output devices.
5. **Create and document operating procedures** for handling output (for example, immediate collection by authorised staff, or use of a controlled collection point that unauthorised people cannot access).
6. **Keep audit-ready evidence**: retain physical access control records or logs for the secure output areas (door access events), and keep documentation showing the room layout and the actual device locations.

###### WHO (role responsible)
- **Facilities / Security Operations**: configure secure room access hardware, manage door access control, and retain access logs.
- **Information Security / Compliance**: maintain the covered output device register, approve the risk-based privacy measures, and confirm evidence is available for audits.
- **Business / Application Owners**: ensure authorised staffing and output collection procedures are followed.

###### Acceptance criteria
- A current register exists covering all `pe-05_odp` output devices, with verified physical locations.
- Each covered device is located in a keypad or card-reader secured area, with access restricted to authorised personnel.
- Door access logs for each secured output area are retained and can be retrieved for audit.
- Privacy measures are in place where side viewing or overhearing is plausible (screen filters for monitors; headphones or equivalent for audio).
- Documented output handling procedures are in place and confirmed through walkthroughs or spot checks (for example, outputs are collected promptly or via a controlled collection point).

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date master list of all covered output devices linked to `pe-05_odp`, including their confirmed physical locations.
- [ ] Set up secure output rooms or areas and allow entry only for authorised people by using keypad and card-reader access controls.
- [ ] Move all covered printing and output devices into secure areas, and place them so staff can monitor how output is used and collected.
- [ ] Install screen privacy filters on monitors/screens and provide headphones (or an equivalent alternative) for audio output where other people could realistically see the screen or overhear the audio.
- [ ] Put in place and document procedures for handling outputs (either collect them immediately or collect them at a controlled collection point), and train authorised staff.
- [ ] Enable and keep physical access control records for every secured output area, and collect evidence of the room layout for audit purposes.


---

#### PE-5.2 — Link to Individual Identity (Enhancement)

This requirement is about making sure sensitive documents are only released to the specific person who is authorised to receive them, directly at the printer, photocopier, or fax machine. Without this, confidential information could be collected by the wrong person, left accessible on a machine, or sent to the wrong recipient—creating real risks such as data breaches, financial loss, and harm to individuals whose details are included in the documents.

To meet this requirement, the organisation must:
- keep an up-to-date list of the output devices and the types of sensitive outputs that must only be released after identity checks; and
- configure those devices so that printing, copying, or faxing is held back until the requesting person proves they are the authorised individual using an approved method.

The organisation must also:
- protect physically the areas where these devices are kept;
- keep records showing that access is controlled;
- keep records showing who released which document and when; and
- document the approach in its system and privacy planning, including any required privacy assessments and risk reviews.

##### Device secure release (hold-and-release) linked to individual identity

- Category: Software
- Priority: Critical

###### WHAT
Set up authentication on in-scope output devices (for example, printers and copiers) and use secure release, so print and copy jobs are held until the person requesting the job authenticates at the device. Once released, the job is linked to that individual’s identity.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53, requirement PE-5(2) enhancement, requires linking a person’s identity to when they receive output from output devices. The guidance says to use security features on fax machines, copiers, and printers to allow authentication at the device before the job is released.

###### HOW (specific steps/approach)
1. **Create an in-scope output device register** that records asset ID, location, device type/model, and which output types (for example, human resources/payroll/legal/regulatory reports) require identity-linked release.
2. **Turn on secure print/copy hold-and-release** for each in-scope printer/copier. Configure the device to **block release** until a user authenticates at the device (for example, badge swipe and/or personal identification number (PIN), or device login). Ensure the device releases only the held jobs belonging to the authenticated user.
3. **Link device authentication to individual identity** by connecting the device authentication method to the organisation’s central identity service (for example, enterprise identity provider (IdP)), so the authenticated device user maps to a single, unique individual identity.
4. **Standardise how sensitive jobs are submitted** so sensitive jobs always go to the secure/held queue (using print management rules and/or configuration management). This prevents any workaround that could print without hold-and-release.
5. **Set up audit logging and retention** on the devices and/or the print management layer to record identity, device ID, job identifier/name, time, and whether release was allowed or blocked. Send logs to the security information and event management (SIEM) system for retention and review.
6. **Apply physical access controls** to the areas where devices are located (for example, badge-controlled doors or restricted rooms). Keep access evidence that matches the same retention period used for output release logging.
7. **Document the control implementation** in system, design, and configuration records. Complete the required privacy planning and risk assessment for linking identity to output (including any privacy considerations of capturing identity at release).

###### WHO (role responsible)
- **IT Workplace/Print Services Lead**: configure devices (secure release, authentication method, queue rules) and manage integration with print management.
- **Identity and Access Management (IAM) Lead**: manage identity mapping and integration with the enterprise IdP.
- **Information Security/Compliance Lead**: define in-scope outputs, approve the risk/privacy assessment, and confirm audit logging and retention are in place.
- **Facilities/Security Operations**: implement and maintain physical access controls for device locations.

###### Acceptance criteria
- For every in-scope printer/copier, a job that requires identity-linked release is **held** and **cannot be released** unless successful authentication happens at the device.
- Released jobs are available only to the **authenticated individual** (no cross-user release).
- Audit records show **who authenticated**, **which device**, **which job**, **when**, and whether release **succeeded or was denied**.
- Sensitive outputs are routed to the secure/held queue by default, with no documented operational bypass for in-scope outputs.
- Physical access to device areas is controlled, and supporting evidence is retained.
- Documentation and privacy/risk assessment records are completed and traceable to the implemented devices and output types.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of in-scope output devices (printers and photocopiers) that require identity-linked release.
- [ ] Set up secure “hold and release” for each in-scope printer and photocopier, and configure it so that releasing a held print requires successful user authentication on the device.
- [ ] Link device sign-in to the organisation’s identity provider so that each signed-in user is matched to a single, unique person identity.
- [ ] Set up print management rules so sensitive print jobs are always sent to the secure/held queue, with no option to bypass this for outputs that fall within scope.
- [ ] Set up and centralise audit logs for release and denial events, including the user identity, device ID, job ID or job name, and the date and time; then send the logs to security information and event management (SIEM).
- [ ] Put physical security controls in place for where devices are kept, and keep records of access in line with the agreed log retention period.
- [ ] Document the design and configuration, and complete the privacy planning and risk assessment for linking identity to output.


---

### PE-6 — Monitoring Physical Access (Control)

This expectation is about closely monitoring who physically enters the building where your system is kept. The goal is to spot suspicious activity early and respond properly. Without this, someone could enter unnoticed, access restricted areas at the wrong time, repeatedly go into places they should not, stay in an area for unusually long periods, move through doors in an unusual order, or continue after a security alarm—leaving the organisation vulnerable to theft, disruption, or unauthorised access.

To meet this expectation, the organisation must monitor physical entry across the entire site, including areas that are open to the public, using practical measures such as security staff, cameras, or sensors. It must review physical access records every day, and immediately investigate any entry outside normal working hours, repeated entry into unusual areas, unusually long periods of access, access that is out of sequence, or any entry after an access-control alarm. The organisation must record what it found and coordinate the review and investigation outcomes with its incident response capability.

##### Daily review and event-triggered investigation of physical access logs

- Category: Software
- Priority: Critical

###### WHAT
Set up a capability to monitor and review physical access so that it: (1) covers all relevant parts of the site, including areas that the public can access, (2) produces records that can be audited from physical monitoring tools (for example, door readers, turnstiles, and cameras or sensors), (3) reviews physical access records **every day**, and (4) starts **immediate investigation** when defined warning signs occur: **access outside normal hours, repeated access to areas that are not usually used, unusually long time spent in an area, access in the wrong order, and any access after a door alarm**. Record the results of reviews and coordinate any investigations with the organisation’s incident response capability.

###### WHY (control requirement)
PE-6 requires the organisation to monitor physical access (including areas the public can access) and to review physical access records at a defined frequency (organisation-defined; default **daily**) and for defined events that suggest suspicious physical access activity (organisation-defined list). Reviewing records helps identify suspicious behaviour and possible threats, and the incident response capability must be used to investigate and respond to physical security incidents.

###### HOW (specific steps/approach)
1. **Define what is covered and what triggers mean**: Create an inventory of all “access areas” (every door and entry point, plus publicly accessible areas) and link each one to the access-control, video, and sensor sources that generate records.
2. **Make sure records can be audited**: Configure access-control equipment and any supporting video or sensor systems to create time-matched, tamper-evident records that include at least: date and time, location/door/zone, person identifier (badge/credential/recognised identity where available), event type (for example, access granted or denied), and a link to any access-control alarm events.
3. **Set up automated daily exception reporting**: Run a daily process that checks physical access records and produces an exception report for the defined warning signs (including out-of-hours access, repeated unusual-area access, unusually long access, out-of-sequence access, and access after an access-control alarm). Assign each report to named reviewers.
4. **Set up immediate investigation for warning signs**: When any warning sign occurs, automatically create an incident or alert record and send it to the physical security or security operations centre (SOC) triage queue, including pointers to supporting evidence (for example, door event details and references to relevant video clips). Confirm that the investigation has started through the organisation’s incident response process.
5. **Record results and coordinate with incident response**: For each daily review and each investigation triggered by a warning sign, record what was found, whether the activity was confirmed as suspicious, what actions were taken, and any link to an incident (if escalated). Send confirmed incidents back into the incident response capability for further investigation and response.
6. **Make responsibilities operational**: Document and enforce roles for (a) daily record review, (b) triage and starting investigations for warning signs, and (c) escalating and communicating incidents. Ensure the process produces audit-ready evidence of review and investigation outcomes.

###### WHO
- **Physical Security Lead / Facilities Security Manager**: owns the monitoring scope, access-area definitions, and routes investigations for triage.
- **Security Operations Centre (SOC) Analyst (or Physical Security Triage)**: carries out immediate triage and starts investigations for defined warning signs.
- **Security Operations / Incident Response Manager**: ensures coordination with the incident response capability and manages incident escalation.
- **Security Information and Event Management (SIEM) / Monitoring Engineer**: sets up log collection, scheduled checks, alert rules, and links evidence to alerts and incidents.

###### Acceptance criteria
- Physical access monitoring includes publicly accessible areas and all relevant facility entry points/areas where the system is in place.
- Physical access records are reviewed **daily** (organisation-defined frequency) and evidence of each daily review is kept.
- For every occurrence of the defined suspicious warning signs (out-of-hours access, repeated access to unusual areas, unusually long access, out-of-sequence access, and access after an access-control alarm), an investigation is started immediately through the workflow, with recorded outcomes.
- Review and investigation outcomes are recorded and linked to incident response actions where applicable.
- Evidence produced by the workflow (exception reports, alert or incident records, investigation notes, and evidence pointers) is sufficient for audit review.

###### Actions Required for Compliance

- [ ] Create an inventory of all publicly accessible areas, and link each area to the physical monitoring records that capture activity in that area.
- [ ] Set up access controls and any sensors or video systems to produce time-matched, traceable records of physical access, linked to the relevant door or area (zone) and any alarms.
- [ ] Set up daily scheduled checks that produce exception reports for the agreed suspicious triggers, and send each report to the specified named reviewers.
- [ ] Set up real-time alerts so that, whenever any agreed trigger happens, a case record is automatically created for triage and investigation.
- [ ] Add links to supporting evidence in every alert or incident record (for example, details from the door event and references to the relevant video clip).
- [ ] Record the results of every daily review and every investigation that is started, and link confirmed incidents to the incident response process.


---

#### PE-6.1 — Intrusion Alarms and Surveillance Equipment (Enhancement)

This requirement is about making sure that, if someone tries to enter the building area where your system is kept, you are alerted immediately and can see what happened. Without physical alarms and cameras, unauthorised entry could go unnoticed, giving criminals or other wrongdoers time to tamper with equipment, steal information, or cause disruption.

To meet this expectation, the organisation must clearly decide which parts of the facility and which entry points are covered. It must then use physical intrusion alarms (for example, alarms on doors, movement detectors, or glass-break sensors) and surveillance cameras placed in key locations to monitor access attempts and prompt action by security staff. The organisation must keep records of alarm events and camera monitoring activity, review them regularly, and document the procedures, the people responsible, and how the alarm and camera systems work.

The organisation must also have privacy documentation that explains what is monitored, why it is monitored, and how privacy is protected. Finally, it must ensure that incident response responsibilities are in place so that security staff know what to do if monitoring suggests a potential unauthorised access event.

##### Alarm + CCTV coverage with correlated alerts and evidence workflow

- Category: Manual
- Priority: Critical

###### WHAT
Install physical intrusion alarms and surveillance equipment for the facility where the system is located, and make sure alarm alerts trigger a documented security response. Keep complete, auditable records of intrusion alarm events and surveillance monitoring.

###### WHY (control requirement)
PE-6(1) requires the organisation to **monitor physical access to the facility where the system is located** using **physical intrusion alarms** (for example, motion, door contact, glass-break) and **surveillance equipment** (for example, video cameras). The guidance also expects alarms to work alongside other physical security measures and to trigger a response when other controls may have been bypassed or compromised.

###### HOW (specific steps/approach)
1. **Define monitoring scope**: Create a map of the facility areas and entry points where the system is located (for example, routes to the server room, doors, loading bays, corridors). Identify which alarm sensors and cameras cover each entry point.
2. **Deploy and verify intrusion sensors**: Make sure door contact sensors, motion sensors, and/or glass-break sensors are installed and correctly linked to named zones/entry points. Ensure their “armed” and response settings match the facility’s operating hours.
3. **Deploy and verify surveillance coverage**: Install cameras in suitable locations so they can clearly view the covered entry points and approach routes. Use consistent camera identifiers (camera ID/label) and ensure live viewing and recorded playback work reliably.
4. **Link alarms to surveillance**: Set up the physical security monitoring process so that when an intrusion alarm triggers, security staff are shown the relevant camera view(s) and a defined evidence time window (for example, footage around the event) to support quick verification.
5. **Trigger a documented response**: Put in place a standard operating procedure (SOP) that states who is alerted, what checks to carry out, how to record results, and when to escalate or declare an incident if unauthorised access is suspected.
6. **Recordkeeping and review**: Ensure the system records intrusion alarm events (date/time, zone/entry point, sensor type, acknowledgement, outcome) and keeps surveillance monitoring/incident notes. Set a review schedule (for example, daily or weekly) with named reviewers, and retain evidence suitable for audit.
7. **Privacy governance**: Keep privacy documentation describing what is monitored, why it is monitored, and how privacy is protected for surveillance and monitoring activities (including how long video/evidence is kept and who can access it).

###### WHO (role responsible)
- **Facilities/Physical Security Manager**: owns the monitoring scope, sensor and camera coverage, and the SOP.
- **Security Operations (SOC/Physical Security Monitoring Team)**: runs the monitoring process, captures evidence, and records event outcomes.
- **Information Security/Privacy Officer**: ensures privacy documentation and retention/access rules are in place and reviewed.
- **System Owner (application/infrastructure owner)**: ensures the facility hosting the system is included in scope and that evidence is available for investigations.

###### Acceptance criteria
- A documented zone/entry-point coverage map exists and is approved by Physical Security.
- Intrusion alarms are installed for the covered entry points and produce events linked to named zones/entry points.
- Surveillance cameras cover the covered entry points/approach routes and use consistent identifiers.
- For each intrusion alarm event, the monitoring process provides security staff with the linked camera view/recorded evidence time window.
- A documented response SOP exists, is followed by the monitoring team, and includes escalation criteria.
- Intrusion alarm and surveillance monitoring records are kept and reviewed on a defined schedule, including the reviewer’s identity and the outcome.
- Privacy documentation covers the surveillance/monitoring purpose, scope, and privacy protections (including retention/access).

###### Actions Required for Compliance

- [ ] Create and get approval for a coverage map showing which facility areas (where the system is located) are covered by each zone and entry point.
- [ ] Check that intrusion sensors (door contacts, motion sensors, and glass-break sensors where applicable) are installed, correctly linked to the relevant areas (zones), and are able to record and send event alerts.
- [ ] Check that closed-circuit television (CCTV) cameras cover every entry point and approach route, using consistent camera names and dependable recording.
- [ ] Set up the monitoring process so that every intrusion alarm is linked to the correct camera(s) and the relevant time window for the evidence.
- [ ] Create a standard operating procedure (SOP) that sets out who should receive alerts, how alerts must be checked, when issues should be escalated, and what proof (evidence) must be recorded.
- [ ] Set up how long event and monitoring records are kept, and ensure they are reviewed by named people on a regular schedule.
- [ ] Maintain privacy documentation that explains what is monitored, why it is monitored, and how privacy is protected, including how long records are kept and who can access them.


---

#### PE-6.2 — Automated Intrusion Recognition and Responses (Enhancement)

This requirement is about automatically spotting common signs of unauthorised break-ins and taking sensible protective action straight away, without waiting for someone to notice. It matters because attackers may try to guess or reuse login details, spread harmful software or lock your systems for ransom, attack web services, try to gain higher permissions, or move from one system to another—often faster than people can respond—leading to service disruption, data loss, and financial harm.

To meet this expectation, the organisation must set up automated detection to recognise credential stuffing, malware or ransomware activity, web application attacks such as SQL injection or cross-site scripting, attempts to increase privileges, and suspicious movement between systems. It must then automatically carry out the matching response actions: isolate the affected device or network area, block the offending internet addresses or domains, disable any compromised accounts, raise an incident ticket to the security operations centre, and notify the incident response lead. This must be done using approved automated mechanisms such as automated alert analysis, automated device containment, intrusion alerts, guided response workflows, and email or text messages to on-call responders.

The organisation must document the types of intrusion and the response actions, define responsibilities and processes (including where physical access monitoring is involved), keep the required plans and records, and retain audit evidence showing what was detected and what actions were taken.

##### SIEM-to-SOAR automated intrusion recognition and response

- Category: Software
- Priority: Critical

###### WHAT
Set up automated detection that recognises the organisation’s defined types of intrusions, and automatically starts the organisation’s defined response actions using the organisation’s defined automated tools.

###### WHY (control requirement)
PE-6(2) enhancement requires that the organisation **recognises the defined types/classes of intrusions** and **starts the defined response actions** using the **defined automated tools**. The guidance explicitly supports automated response actions such as **isolating affected devices or network sections, blocking the offending Internet Protocol (IP) addresses or domains, disabling compromised accounts, raising incident tickets to the security operations centre (SOC), and notifying incident response staff**.

###### HOW (specific steps/approach)
1. **Create an intrusion “taxonomy” and detection mapping** in the security information and event management (SIEM) and security orchestration, automation and response (SOAR) integration layer for the specified intrusion types: **credential stuffing, malware/ransomware activity, web application attacks (Structured Query Language (SQL) injection/cross-site scripting (XSS)), privilege escalation attempts, suspicious lateral movement**. For each type, define the minimum detection inputs (for example: identity-related events, endpoint detection and response (EDR) alerts, web application firewall (WAF) logs, network flow and intrusion detection and prevention system (IDS/IPS) alerts) and the required extra information (asset identity, user/account, source IP/domain, confidence level, time window).
2. **Build SIEM correlation rules** (detection rules written as code) for each intrusion type using the organisation-defined automated tools (for example: **SIEM correlation rules** and **IDS/IPS alerts** as inputs). Make sure each rule outputs a structured event that SOAR can use to choose the correct response actions.
3. **Coordinate responses using SOAR playbooks** so that, when a detection matches, the playbook automatically starts the organisation-defined response actions:
   - **Isolate affected device or network section** using EDR automated containment and/or network segmentation controls (for example: software-defined networking (SDN)/firewall controller) mapped to the correct asset.
   - **Block offending IP addresses/domains** using firewall or WAF rules, or secure domain name system (DNS) controls.
   - **Disable compromised accounts** using identity and governance application programming interfaces (application programming interfaces (APIs)) (for example: identity provider (IdP)/Active Directory (AD)/Microsoft Entra/identity governance and administration (IGA)), with safeguards to prevent accidentally locking out accounts that are not compromised.
   - **Raise an incident ticket to the SOC** using the ticketing integration.
   - **Notify the incident response lead** using the organisation-approved **email/text message (SMS)/on-call** method.
4. **Add safety guardrails to prevent harmful automation** while still meeting the requirement for “automated initiation”: implement blast-radius limits (for example: isolate only the specific endpoint/device or network segment), rate limiting, allow/deny lists for known harmless sources, and confidence thresholds that decide whether the playbook runs fully or switches to a restricted set of actions.
5. **Ensure end-to-end auditability**: configure SIEM, SOAR, EDR, and identity integrations so that every detection and every initiated response action is recorded with clear linking identifiers (detection ID → playbook run ID → containment/block/account-disable actions → SOC ticket ID → notification delivery confirmation).

###### WHO (role responsible)
- **Cybersecurity Detection Engineering Lead**: owns the intrusion taxonomy, SIEM correlation rule logic, and the detection rules lifecycle.
- **SOC Automation/SOAR Engineer**: owns SOAR playbooks, integrations, and guardrails.
- **Identity and Access Management (IAM) Engineer**: ensures account disablement actions are implemented correctly using approved APIs.
- **Network/Operational Technology (OT)/Infrastructure Security Engineer (where applicable)**: ensures isolation and blocking controls are available and correctly mapped to assets.

###### Acceptance criteria
- For each of the five intrusion types, a SIEM correlation rule exists that recognises the type and produces a structured event that SOAR can consume.
- For each intrusion type, the matching SOAR playbook automatically initiates **all** organisation-defined response actions (isolate, block, disable accounts, SOC ticket, notify the incident response lead) using the organisation-defined automated tools.
- No manual “first responder” step is needed to start the response actions once the detection triggers (automation is end-to-end).
- Every detection-to-response execution produces auditable evidence linking the detection, actions taken, SOC ticket creation, and the notification outcome.
- Guardrails (blast-radius limits and confidence thresholds) are implemented and tested to prevent unintended isolation, blocking, or account disablement.

###### Actions Required for Compliance

- [ ] Define an intrusion classification scheme in the security information and event management (SIEM) and security orchestration, automation and response (SOAR) layer for the five intrusion categories defined by the organisation, and specify the required enrichment fields.
- [ ] Implement and version security information and event management (SIEM) correlation rules for each type of intrusion to produce structured events that can be used by security orchestration, automation and response (SOAR).
- [ ] Create security orchestration, automation and response (SOAR) playbooks that link each type of intrusion to the organisation’s agreed response actions: isolate, block, disable accounts, raise a security operations centre (SOC) ticket, and notify the incident response lead.
- [ ] Integrate security orchestration, automation and response (SOAR) with endpoint detection and response (EDR) containment, firewall and web application firewall (WAF) or secure domain name system (DNS) blocking, and identity and access management (IAM) and identity governance and administration (IGA) account disablement using application programming interfaces (APIs), with limits on potential impact (“blast radius”) and confidence checks to prevent incorrect actions.
- [ ] Set up integrations between **security information and event management (SIEM)**, **security orchestration, automation and response (SOAR)**, **endpoint detection and response (EDR)**, and **identity and access management (IAM)** so they capture end-to-end audit records. These records must link each detection reference to every response action taken and to the final result of any notifications.
- [ ] For each type of intrusion, run tabletop exercises and technical checks to confirm that the automated response starts immediately (without waiting for a person) and that it generates the expected security operations centre (SOC) ticket and notifications.


---

#### PE-6.3 — Video Surveillance (Enhancement)

This requirement is about using cameras to keep a clear record of who enters your site and where they go in the most sensitive areas, so any suspicious activity can be spotted and investigated later. Without this, unauthorised people could get access to data centre entrances, server rooms, or the site perimeter, and you may not notice unusual behaviour in time or be able to show what happened afterwards.

To meet this requirement, the organisation must install video surveillance covering data centre entrances, server rooms, and perimeter access points. It must then regularly check the footage for alerts and unusual behaviour: review it every day when there are alerts or anomalies, and otherwise at least once a week. The organisation must also keep the recorded footage for 90 days, and be able to demonstrate that the cameras are placed correctly, that footage is reviewed at the required frequency, and that recordings can be retrieved within the 90-day period.

##### VMS video coverage, 90-day retention and auditable review workflow

- Category: Software
- Priority: Critical

###### WHAT
Set up video surveillance for the organisation’s defined **operational areas** (data centre entrances, server rooms, and perimeter access points). Make sure recordings are **reviewed at the defined frequency** (daily for alerts/anomalies; otherwise weekly). Keep recordings for the **defined time period** (90 days). Provide evidence that footage can be retrieved within the retention period, and that access to the video system and footage is controlled and recorded.

###### WHY (control requirement)
PE-6(3) enhancement guidance requires video surveillance to capture activity in specified areas for later review. Reviews must follow a defined schedule for unusual or suspicious events, and recordings must be kept for a defined period. The organisation must be able to show camera coverage, demonstrate that reviews are carried out, and confirm that recordings can be retrieved within the retention window.

###### HOW (specific steps/approach)
1. **Define and implement camera coverage**: Create a camera coverage register that links each required operational area to camera identifiers, what each camera can see, and the recording settings. Configure the video management system so every defined area is covered.
2. **Set retention to 90 days**: Configure the video management system recording retention to **90 days** for all relevant camera feeds. Where supported, enable tamper-evident or “cannot be changed” (immutable) storage features.
3. **Set up a review process with the required schedule**:
   - Configure event or alert triggers (for example, intrusion, loitering, forced entry, and door events where available) to create a **daily review queue**.
   - Schedule **weekly review tasks** for cameras/areas with no events.
   - Require reviewers to record structured review results (date/time, camera/area, what was observed, the decision/outcome, and an evidence or case reference).
4. **Control and audit access to footage**: Connect the video management system sign-in to the organisation’s identity system, and apply least-privilege role-based access control (RBAC) (reviewer versus exporter versus administrator versus auditor). Ensure the video management system records and retains:
   - user logins,
   - viewing sessions,
   - export/download actions,
   - administrative changes to camera and retention settings.
5. **Prove retrieval within 90 days**: Carry out periodic retrieval tests (for example, monthly) to retrieve a sample of footage from exactly **90 days ago**. Record whether retrieval succeeded and note any exceptions.
6. **Keep audit-ready evidence**: Store the camera coverage register, video management system configuration evidence (retention settings), review logs, and retrieval test results in controlled repositories aligned to the organisation’s record-keeping requirements.

###### WHO (role responsible)
- **Physical Security Lead / Security Operations (SOC) Manager**: owns the review process, review outcomes, and day-to-day procedures.
- **Infrastructure/Video Management System (VMS) Engineer**: configures camera mapping in the VMS, sets retention to 90 days, implements RBAC, and ensures logging is enabled.
- **Information Security / Compliance**: checks that audit evidence is complete and approves the access control approach.
- **Identity and Access Management (IAM) Team**: ensures integration with the organisation’s identity system and multi-factor authentication (MFA) and any conditional access controls.

###### Acceptance criteria (verifiable)
- A camera coverage register exists and shows that **data centre entrances, server rooms, and perimeter access points** are covered by active cameras in the VMS.
- VMS retention is set to **90 days** for the relevant camera feeds, and evidence of this configuration is retained.
- Review evidence exists showing:
  - **daily** review of recordings linked to **alerts/anomalies**, and
  - **at least weekly** review for other periods/areas.
- VMS access logs show least-privilege enforcement, and record viewing/export/download activity and administrative actions.
- Retrieval tests confirm that footage from **90 days prior** can be retrieved successfully and that the results are documented.

###### Actions Required for Compliance

- [ ] Create a camera coverage register that links each data centre entrance, server room, and perimeter access point to the relevant video management system (VMS) camera ID and its field of view.
- [ ] Set the video management system (VMS) retention policy to keep recordings for 90 days for all required camera streams.
- [ ] Set up daily review queues that automatically collect alerts and unusual activity, and schedule a weekly review for the remaining cameras and areas.
- [ ] Apply least-privilege role-based access control (RBAC) in the video management system (VMS) for roles including reviewer, exporter, administrator, and auditor, and link sign-in to the organisation’s identity provider (IdP).
- [ ] Turn on and keep audit logs so you can review viewing sessions, export or download activity, and any administrative changes to camera settings or retention settings.
- [ ] Run and record regular retrieval tests to pull video footage from exactly 90 days ago, and keep evidence showing the results.


---

#### PE-6.4 — Monitoring Physical Access to Systems (Enhancement)

This requirement is about keeping a detailed record of who physically enters the specific rooms where important equipment is stored, such as server rooms, media storage areas, and communications centres. This goes beyond general building security. Without this extra, room-by-room monitoring, unauthorised people could access critical systems or sensitive storage without being detected, or authorised access could be misused without notice. This increases the risk of disruption, data loss, or misuse.

To meet this expectation, the organisation must:
- identify and document these key equipment areas
- set clear written procedures for monitoring access to the systems in those areas
- assign named staff to carry out the monitoring, involving information security and privacy roles where appropriate
- use approved access methods (such as access badges or keys)
- keep reliable access records showing who entered and when
- retain those records for review
- document this approach in its system security and privacy planning, including privacy impact and risk assessments

##### Area-specific physical access monitoring for system-concentration rooms

- Category: Software
- Priority: Critical

###### WHAT
Set up monitoring that records physical access to the **system-concentration areas** (server rooms, media storage areas, and communications centres) **as well as** general monitoring of physical access to the site.

###### WHY (control requirement)
PE-6(4) requires that physical access to the **system itself** is monitored for the defined system-concentration areas, not only at the facility perimeter. This gives stronger evidence and better detection of unauthorised or inappropriate access to areas where system components are concentrated.

###### HOW (specific approach)
1. **Define what is covered** by mapping each system-concentration area to the exact physical entry points (door/portal/turnstile) that control access to that area.
2. **Set up event logging for each access point** so the records capture, at minimum: date and time, credential identifier (badge/user ID), event type (entry/exit/denied/door open), and the specific area/door identifier.
3. **Centralise and protect the logs** by sending physical access events from the physical access control system (PACS) to a secure logging location (for example, security information and event management (SIEM) or a dedicated physical security log store). Use integrity protections (such as restricted write access and tamper-evident storage where available) and ensure clocks are synchronised.
4. **Put review into day-to-day operations** by creating a documented monitoring procedure that assigns named roles to review access events for the monitored areas and to investigate exceptions (for example, entries outside normal hours, repeated denied attempts, or unexpected badge/user ID use).
5. **Coordinate with intrusion and system monitoring** by linking physical access exceptions to the organisation’s incident and detection process (for example, connect physical access alerts with information technology (IT) and operational technology (OT) security monitoring signals).
6. **Cover retention and audit evidence** by keeping the area-level physical access logs for the organisation’s required review and audit period, and ensuring they can be retrieved by area and time.
7. **Privacy by design**: if closed-circuit television (CCTV) or other video analytics are used to support monitoring, ensure the monitoring design and data handling are covered by the organisation’s privacy impact and privacy risk assessments (and record the outcome in the system security and privacy planning documents).

###### WHO
- **Physical Security Manager / Facilities Security Lead**: owns the area-to-door mapping and PACS configuration.
- **Information Security (and Privacy Officer where applicable)**: approves what is monitored, what fields are logged, how long logs are kept, and the outcomes of privacy impact and privacy risk assessments.
- **Security Operations Centre (SOC) / Security Operations Lead**: owns exception triage, linking to security monitoring, and escalation.
- **System Owner / Authorising Official (or delegated governance role)**: ensures the approach is documented in system security planning.

###### Acceptance criteria
- For each defined system-concentration area, there is an identified set of access-controlled doors/portals whose events are logged.
- Area-level logs include credential identifier, timestamp, event type, and area/door identifier.
- Logs are sent to a central, access-controlled logging destination and can be retrieved for audit by area and time.
- A documented procedure exists for monitoring and handling exceptions, with named responsible roles and escalation routes.
- Evidence exists that privacy impact and privacy risk assessments cover any additional monitoring data sources (for example, CCTV), and that the monitoring approach is reflected in system security and privacy planning.

###### Actions Required for Compliance

- [ ] Create an official map that links each system concentration area (server rooms, media storage areas, communications centres) to the specific picture archiving and communication system (PACS) doors or entry points that control access.
- [ ] Set up the physical access control system and its access points (PACS) to record the following details for each event: the time and date, the credential identifier, the type of event (entry, exit, denied, or door open), and the area or door identifier.
- [ ] Export and centralise area-level physical access events into the organisation’s secure logging and security information and event management (SIEM) system, with restricted access and tamper-evident protections where available
- [ ] Define and document an exception-monitoring process for the monitored areas, including who reviews exceptions, how often reviews happen, the steps to investigate issues, and the escalation route if action is needed.
- [ ] Set up correlation rules to connect physical access exceptions in monitored areas with existing intrusion detection and incident reporting workflows.
- [ ] Check that logs are kept for the required length of time and that they can be retrieved for audits by area and date, and test that the evidence can be provided for review.
- [ ] Complete and record a privacy impact and privacy risk assessment for any additional monitoring data sources used to support system-area monitoring.


---

### PE-8 — Visitor Access Records (Control)

This requirement is about keeping a clear, time-stamped record of who enters the building where your systems are kept, and making sure those records are checked and followed up. Without this, the organisation could miss unauthorised visitors, fail to notice incorrect or unexpected entries, or continue allowing access that is no longer needed—raising the risk of theft, disruption, or other harm to critical operations.

To meet this expectation, the organisation must keep complete visitor access records for 365 days. These records must include details such as who visited, who they were visiting, why they came, what identification they provided, when they entered and left, and their signature. Every 90 days, the organisation must review these records to confirm that each visitor’s access is still up to date and still needed for business purposes.

Any unusual or unexpected findings must be reported to the Security Operations Centre lead and the facility security manager. Records are not required for areas that are publicly accessible.

##### Visitor access records with 365-day retention and 90-day reviews

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up a facility visitor access recording capability that captures the required visitor details (visitor name and organisation, visitor signature, identification form, dates of access, entry and departure times, purpose of visit, and the name and organisation of the individuals visited). Keep these records for **365 days** and carry out **regular reviews every 90 days** to confirm that visitor access permissions are still up to date and still needed. During each review, identify any unusual or unexpected items and **report them to the SOC lead and the facility security manager**.

###### WHY (control requirement)
PE-8 requires visitor access records to include the specified fields and to be reviewed at a set frequency to confirm whether access permissions are still current and still required. It also requires identifying unusual items and escalating them. Records are **not required for publicly accessible areas**.

###### HOW (specific steps/approach)
1. **Capture the required fields at check-in** for restricted facility entry only. Configure the process so **publicly accessible areas** do not create visitor records.
2. **Store records in an audit-friendly, tamper-evident log** (for example, write-once, append-only storage or an equivalent approach) with time-stamped entry and exit events and signature capture.
3. **Keep records for 365 days**, and support legal hold or exception handling if your organisation requires it.
4. **Run an automated review every 90 days** that produces a review pack showing: missing or invalid required fields, time inconsistencies (for example, departure before entry), visitors whose host/visited person no longer exists or is no longer active, and visitors whose purpose/host arrangement no longer matches current business need.
5. **Escalate unusual items** from the review process into a case management process, and notify the **SOC lead and facility security manager** with enough evidence (record identifiers, timestamps, missing fields, and any host arrangement changes).
6. **Keep review accountability** by recording who carried out each review, when it was done, and the outcome (access still required / access no longer required / anomaly investigated).

###### WHO (role responsible)
- **Facility security manager**: owns the visitor process, checks review outcomes, and ensures unusual items are investigated.
- **SOC lead**: receives anomaly notifications and ensures the right security investigation or response actions are taken.
- **Security engineering / IAM and security operations team**: sets up the visitor management configuration, retention, and review automation.

###### Acceptance criteria
- Visitor records for restricted areas include all required fields: visitor name and organisation, visitor signature, identification form, date(s) of access, entry and departure times, purpose of visit, and the name/organisation of individuals visited.
- Records are kept for **365 days** and are not kept for entries into **publicly accessible areas**.
- A review is completed **every 90 days**, with the reviewer’s identity, review date, and outcome recorded.
- Unusual items found during reviews are escalated to the **SOC lead and facility security manager**, with evidence sufficient to support investigation.
- Audit evidence exists for: retention settings, review schedule completion, review outputs, and anomaly case records.

###### Actions Required for Compliance

- [ ] Set up the visitor sign-in process to collect all required PE-8 details and signatures for access to restricted areas only.
- [ ] Define and apply “publicly accessible” versus “restricted facility” entry types so that public areas do not create visitor records.
- [ ] Set up tamper-evident, auditable storage for visitor access records, recording time-stamped entry and departure events.
- [ ] Set retention controls to keep visitor access records for 365 days, and apply organisational legal-hold handling where applicable.
- [ ] Set up and run an automated 90-day review process that checks for missing information, timing problems, and changes in whether the host and the visited person are still relevant.
- [ ] Set up an anomaly escalation process that alerts the security operations centre (SOC) lead and the site security manager, including the supporting evidence and the case reference identifiers.


---

#### PE-8.1 — Automated Records Maintenance and Review (Enhancement)

This requirement ensures that visitor access records are captured automatically, kept up to date, and reviewed regularly, so that only the right people have access for the right reasons. Without this, a visitor’s access could continue after it should have ended, sponsor approval could be missed, or unusual access could go unnoticed—raising the risk of unauthorised entry or internal incidents.

The organisation must automatically collect visitor badge and entry events from its on-site physical entry system and store them in a records database. The records must include the visitor’s identity, sponsor, site or location, and the date and time, using built-in checks to confirm the information is reliable. The organisation must also link these visitor records to its access authorisation records so staff can review them properly.

At scheduled intervals, automated checks must highlight expired permissions, permissions that are still active, missing sponsor approvals, and unusual access patterns for human review. This must include clear results, documented procedures, named responsibilities, and evidence that the reviews are carried out and records are kept.

##### PACS-to-visitor records ingestion with scheduled automated review

- Category: Software
- Priority: Critical

###### WHAT
Set up automated processes to (1) collect visitor badge/access events from the on-premises physical access control system (PACS) and store them in a database of visitor access records that can be retrieved, and (2) regularly review those records using automated checks that highlight expired access permissions, permissions that are still active, missing sponsor approvals, and unusual access patterns for human follow-up.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-8(1)** enhancement requires: **“Maintain and review visitor access records using {{ insert: param, pe-8.1_prm_1 }}.”** The guidance also expects visitor access records to be stored and maintained in a database that organisational staff can access. Automated access is expected to support regular reviews to confirm whether access permissions are still current and still needed.

###### HOW (specific steps/approach)
1. **Define what will be captured and how identities are matched**: Use the organisation-defined mechanism **pe-8.1_prm_1** (“Automated visitor badge/access record capture and periodic review via the on-premises physical access control system (PACS) and identity and access management (IAM) integration”). Set the official matching key between the PACS visitor identity and the IAM/authorisation identity (for example, visitor ID or a dedicated visitor identity attribute).
2. **Build the PACS-to-database transfer**: Implement an integration service (for example, event streaming, scheduled export, or an API-based pull where supported by the PACS) that writes visitor badge/access events into a **visitor access records database**. Ensure each stored record includes at least: visitor identity, sponsor, site/location, and event date/time(s).
3. **Run integrity checks before saving records**: Apply automated validation before records are saved, including checks that required fields are present, date/time values are sensible, and related references are correct (for example, the sponsor exists and is approved in the sponsor directory or sponsor approval system). Record batch details for each ingestion run and use tamper-evident and audit logging to record ingestion results.
4. **Connect to IAM/authorisation information for review**: Give the review process a read-only view of the IAM/authorisation status for the matched visitor identity, so it can confirm whether permissions are expired or still active, and whether sponsor approvals are in place.
5. **Run scheduled automated review checks**: Create a scheduled job (for example, daily or weekly, based on organisational risk) that runs automated checks to flag:
   - **Expired** permissions (end date has passed),
   - **Still-active** permissions (currently valid),
   - **Missing sponsor approvals** (approval is absent or not in an approved state),
   - **Unusual access patterns** (predefined rules such as repeated access outside expected times/locations, or unusually frequent access).
   Send the results to a review queue/case management view for authorised staff.
6. **Keep review evidence and record outcomes**: For each flagged item, record the review date/time, reviewer identity, decision (for example, permission kept/removed, sponsor approval obtained), and any reference to corrective action. Keep the review outputs so organisational staff can show that automated reviews are carried out and acted upon.

###### WHO
- **Application/Integration Owner**: builds the PACS transfer, the database structure, and the review process integration.
- **Identity and Access Management (IAM) / Identity Governance and Administration (IGA) Owner**: provides the authorisation status information and sponsor approval data mapping.
- **Security Operations / Physical Security Reviewers**: carry out human follow-up on flagged items and record outcomes.
- **Compliance/Assurance**: checks that evidence is produced and that reviews happen on the required schedule.

###### Acceptance criteria
- Visitor badge/access events from the on-premises PACS are automatically captured and stored in a visitor access records database, including visitor identity, sponsor, site/location, and date/time stamps.
- Ingestion includes automated integrity checks and records evidence of ingestion success or failure.
- The system integrates with IAM/authorisation data so scheduled reviews can identify expired versus still-active permissions and detect missing sponsor approvals.
- Scheduled automated reviews run at the agreed frequency and produce review outputs for authorised staff.
- Over a sample period, evidence is available showing flagged items, reviewer actions/decisions, and date/time stamps for review outcomes.

###### Actions Required for Compliance

- [ ] Define the official mapping between the picture archiving and communication system (PACS) and identity and access management (IAM) for visitor records, and enforce rules that prevent duplicate identities.
- [ ] Set up a process to bring PACS (Picture Archiving and Communication System) records into a database of visitor records. The database must record the visitor’s identity, their sponsor, the site or location, and the relevant dates and times, and it must be auditable.
- [ ] Set up automated checks to confirm the data is complete and sensible as it is imported, including verifying that the schema is complete, timestamps are reasonable, and sponsor details are linked correctly and approved.
- [ ] Integrate the review engine with identity and access management (IAM) and authorisation status, and with sponsor approval data, using read-only interfaces.
- [ ] Run scheduled automated checks to identify expired items, items that are still active, missing sponsor approvals, and unusual access patterns.
- [ ] Set up a review queue (case view) and record, for each flagged item, who reviewed it, when they reviewed it, the outcome (disposition), and any corrective actions taken.


---

#### PE-8.3 — Limit Personally Identifiable Information Elements (Enhancement)

This requirement is about making sure visitor records do not contain more personal information than is necessary.

It matters because if visitor access records include unnecessary details—such as home addresses, personal phone numbers, personal email addresses, dates of birth, or government-issued identity numbers—then any mistake, unauthorised access, or data leak could cause greater harm.

To meet this expectation, the organisation must first use its privacy risk assessment to identify exactly which information items are needed for visitor access records. It must then store only the following items:
- full name  
- home address  
- personal phone number  
- personal email address  
- date of birth  
- government-issued identity numbers  

The organisation must ensure no other personal details are added. It must also be able to demonstrate—by checking the records and the way the fields are defined—that only the permitted items are included.

##### Allowlist-only PII fields in visitor access records

- Category: Software
- Priority: Critical

###### WHAT
Set up visitor access record capture and storage so it includes **only** the personal information items (personal data) that are specifically listed in the privacy risk assessment for **PE-8(3)**.

The allowed items are: **full name, home address, personal phone number, personal email address, date of birth, government-issued ID numbers**.

###### WHY (control requirement)
PE-8(3) requires limiting the personal information in visitor access records to the items listed in the privacy risk assessment (parameter **pe-08.03_odp**: *elements*). This lowers privacy risk by stopping the unnecessary storage of sensitive personal data.

###### HOW (specific steps/approach)
1. **Create an approved “allowlist”** of the visitor-record personal data fields, taken directly from the privacy risk assessment parameter **pe-08.03_odp** (the allowed set above). Treat this allowlist as the **only** source of truth.
2. **Apply the allowlist when capturing data** (web/mobile forms, kiosk screens, and any internal front-desk system): remove any fields that are not allowed, and stop users from entering free text that could capture extra personal data.
3. **Apply the allowlist when systems connect** (integration/application programming interface (API) layer): check incoming data and reject any request that includes any personal data fields that are not allowed (do not accept anything beyond the allowlist). Make sure upstream systems (badge issuing, host notifications, ticketing) only send values for the allowed fields.
4. **Apply the allowlist in the data storage structure** (data model layer): ensure the visitor access record database stores **only** the allowed items (and if other information is needed, store it in non-personal-data categories that are not saved as personal data in visitor access records).
5. **Add automated checks and keep proof**: run a scheduled audit that confirms (a) only allowed personal data fields are present and (b) no disallowed personal data fields/attributes are present. Save the audit results for review.
6. **Put change control in place**: manage the allowlist and validation rules as version-controlled configuration, with approvals linked to updates to the privacy risk assessment.

###### WHO (role responsible)
- **Application owner / engineering lead**: implement the controls in the user interface (UI), API, and data storage, and run the automated audits.
- **Privacy officer / data protection lead**: confirm and approve the allowed item list from the privacy risk assessment.
- **Security/compliance lead**: check that audit proof meets PE-8(3) expectations and that changes follow governance.

###### Acceptance criteria
- Visitor access record creation/update **cannot succeed** if any disallowed personal data fields are provided (the UI/API rejects or removes them; the data storage does not save them).
- The visitor access record structure/fields contain **only** the allowed elements from **pe-08.03_odp**.
- Automated audit evidence shows that, across a representative sample (and over time), **no disallowed personal data elements** appear in visitor access records.
- Any change to the allowed element list requires an approved update to the privacy risk assessment and the corresponding configuration update.

###### Actions Required for Compliance

- [ ] Create and document the visitor-record personal data (PII) allowlist exactly as defined in **pe-08.03_odp**, including: full name, home address, personal phone number, personal email address, date of birth, and government-issued identity numbers.
- [ ] Remove any personal data (PII) fields that are not allowed from all visitor information capture screens (web, mobile, kiosk, and front desk) and turn off any free-text entry that could collect additional personal data (PII).
- [ ] Set up checks for incoming application programming interface (API) requests and their data (payloads) to reject any visitor-record submissions that include personal information (PII) fields that are not allowed (fail closed).
- [ ] Limit the visitor access record data so it contains only approved personal information (PII) fields/columns, or ensure any unapproved data is not stored as personal information (PII) in visitor access records.
- [ ] Update all integrations and mappings that record visitor access so they only fill in permitted personal information (PII) fields, and remove or tokenise everything else.
- [ ] Set up an automated audit that checks visitor access records to confirm they include only the permitted personal information (PII) fields, and save the results as evidence for later compliance review.
- [ ] Manage the allowlist and validation rules as version-controlled configuration, with approval from the privacy officer for any changes.


---

### PE-9 — Power Equipment and Cabling (Control)

This requirement is about making sure the power supplies and the cables that keep the system running are physically protected against damage or destruction. If power equipment or cabling is knocked, interfered with, exposed to the weather, or otherwise harmed, the system could fail, shut down unexpectedly, or become unreliable—causing disruption for the organisation and potentially putting critical services at risk.

To meet this expectation, the organisation must clearly document how it will protect all system power equipment and power cabling, both inside its own buildings (such as offices and data centres) and outside them (such as generators and their external cabling). It must also cover power sources for self-contained or deployable components, such as vehicles and satellites.

The organisation must produce step-by-step procedures for protecting the equipment and cabling, list every internal and external location where this equipment and cabling are stored or routed, apply the appropriate physical protections at each location, name specific people responsible for these protections, ensure they understand their responsibilities, involve staff with information security responsibilities, and keep evidence showing that the protections have been defined and put in place.

##### Power protection playbooks and evidence for all power equipment/cabling

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain written, location-specific procedures (“power protection playbooks”) to protect **power equipment** and **power cabling** for the system from **damage and destruction** across:
- internal sites (for example, uninterruptible power supply (UPS) and data centre power rooms, and rack/row cabling),
- external sites (for example, generators and external power cabling), and
- deployable or self-contained environments (for example, vehicles and satellite power sources).

###### WHY (control requirement)
PE-9 requires the organisation to **protect power equipment and power cabling** from **damage and destruction**. The guidance also requires the organisation to decide **what types of protection are needed** for different locations (internal/external) and operating environments, and to include examples such as **UPS**, **generators and external power cabling**, and **deployable/self-contained power sources**.

###### HOW (specific steps/approach)
1. **Create an up-to-date register** of every internal and external location where the system’s power equipment and power cabling are stored or routed. This includes UPS rooms, generator sites, cable tray/conduit routes, rack/row cabling areas, and deployable kits/vehicle/satellite power points. Each register entry must include asset identifiers and physical location identifiers.
2. **Define a standard “power protection approach”** based on risk. This must set out the protection measures to use, such as physical barriers/guards, secure routing (for example conduit or trunking), protection against water ingress, deterrence against tampering or unauthorised access, and protection against foreseeable physical hazards. The approach must clearly separate internal, external, and deployable environments.
3. **Create two sets of procedures** (as playbooks) and tailor them by location type:
   - **Power equipment playbook** (UPS, power distribution units (PDUs), batteries, transfer switches, generators, and any deployable power sources): what to inspect, how to secure, and what to do if damage is suspected.
   - **Power cabling playbook** (internal cabling routes, cable trays/conduits, external runs, and any deployable cabling): what to inspect, how to secure/route, and what to do if damage is suspected.
4. **Carry out inspections and record proof of completion** through the organisation’s work-order / computerised maintenance management system (CMMS) process. For each inspection or relevant change, require completion of a checklist linked to the correct register entry and capture evidence (for example, checklist results and photos where applicable), plus record any corrective actions taken.
5. **Name responsible people for each location type** (for example, facilities/data centre operations/field engineering lead) and ensure information security responsibilities are included where relevant (for example, escalation and incident handling for suspected tampering). Add these responsibilities and the playbook references into the **system security plan**.
6. **Put the process into day-to-day use and train the responsible roles** so they understand their duties in the playbooks, including when to escalate and what evidence must be recorded.

###### WHO
- **Accountable owner:** Infrastructure/Facilities Security Lead (or equivalent) to approve the power protection approach and playbooks.
- **Implementers:** Data centre operations lead, facilities/generator site engineer, field engineering lead for deployable systems.
- **Governance:** Information Security (to ensure alignment with the system security plan and escalation/incident pathways).

###### Acceptance criteria
- A complete **power asset and cabling location register** exists covering internal, external, and deployable/self-contained environments for the system.
- **Power equipment** and **power cabling** playbooks exist, are specific to locations, and refer to the protection approach.
- The **system security plan** names accountable roles and links to the playbooks.
- Evidence capture is enforced in the work-order/CMMS process (checklists completed and evidence retained) for inspections and relevant changes.
- Named responsible personnel have been trained and can demonstrate how to use the playbooks and record evidence.

###### Actions Required for Compliance

- [ ] Create and keep a complete list (register) of all locations—internal, external, and places where equipment can be deployed—where the system’s power equipment and power cables are stored or routed.
- [ ] Define a risk-based approach to power protection that treats internal, external, and deployable environments differently.
- [ ] Publish playbooks for power equipment and power cabling that give step-by-step instructions for inspection, securing, and escalation, tailored to each location type.
- [ ] Set up the computerised maintenance management system (CMMS) and work-order process so that inspections and relevant changes must include completing a checklist and saving supporting evidence (including photos where applicable).
- [ ] Update the system security plan to include the power protection approach and name the accountable roles for each type of location.
- [ ] Train the people responsible for day-to-day operations and the information security stakeholders on the runbooks, what proof (evidence) is required, and when and how issues should be escalated.


---

#### PE-9.1 — Redundant Cabling (Enhancement)

This requirement is about ensuring your power supply has a backup route that is physically separated from the main route. In real life, this protects against situations where one power cable route is cut, damaged, or fails. If the two routes are too close together, the backup route could be affected as well, causing equipment to lose power and operations to stop.

To meet this expectation, the organisation must install at least two separate power cable routes for resilience (backup). These routes must be kept at least 2 metres apart along their route, so damage to one route is unlikely to affect the other.

The organisation should:
- document how the separated, resilient cabling is designed and installed
- have clear procedures for protecting power cables and maintaining the separation
- assign named staff responsibility for protecting the cabling
- include this approach in its planning documents

Any facilities that house the power equipment must also support and maintain the required separation.

##### Independent redundant power routes with ≥2m physical separation

- Category: Manual
- Priority: Critical

###### WHAT
Install redundant power cabling using at least two physically separate cable routes (for example, separate cable trays/conduits/containment areas). Confirm that the closest physical distance between the two redundant routes is **at least 2 metres**.

###### WHY (control requirement)
NIST SP 800-53 **PE-9(1)** requires: “Employ redundant power cabling paths that are physically separated by {{ insert: param, pe-09.01_odp }}.” This guidance is intended to prevent loss of continuous power if one cable route is cut or damaged.

###### HOW (specific steps/approach)
1. **Design for independence**: Create a two-route (A/B) power cabling design from the power source (for example, UPS/Power Distribution Unit (PDU)) to the critical load(s). Use cable containment that supports separation (separate cable trays, separate conduits/ducts, or physically separated containment areas). Do not use arrangements where both routes share the same containment unless a verified physical separation is in place.
2. **Set where separation will be measured**: On the route drawings, mark the expected closest-approach locations (for example, corridor crossings, room entries, cable ladder transitions, and any shared penetrations).
3. **Install and verify separation**: During installation, measure the **minimum distance** between the redundant routes at the closest point using a calibrated measuring method (tape/laser/measurement wheel as appropriate). Keep **evidence** (a photo showing both routes and the measurement point, plus the recorded distance).
4. **Keep as-built evidence**: Update as-built drawings and inspection/acceptance records to include the measured minimum separation (must be **≥ 2 metres**, per `pe-09.01_odp`), route identifiers (A/B), and references to the evidence.
5. **Control changes**: Ensure change management for power cabling requires a separation re-check and evidence update whenever routes are changed, added, or re-routed.

###### WHO (role responsible)
- **Facilities/Infrastructure Engineering Lead**: owns the two-route design and containment layout.
- **Electrical/Operational Technology (OT) Cabling Contractor + Site Supervisor**: installs the cabling and performs the separation measurements.
- **Configuration Management / Compliance Engineer**: ensures as-built documentation and evidence are stored, and that change control approval steps require re-verification.

###### Acceptance criteria
- For each critical power route pair (A/B), the **minimum measured physical separation** between the redundant cabling routes is **≥ 2 metres** at the closest point along their routing.
- As-built records exist for each affected route showing route identifiers (A/B), containment identifiers, and measurement evidence (photo plus recorded distance).
- Any post-install change to power cabling triggers a re-verification of separation and updates the evidence set accordingly.

###### Actions Required for Compliance

- [ ] Create a two-route (A/B) redundant power cabling design, with each critical power load using its own separate containment (separate cable trays, conduits, and zones).
- [ ] Mark the expected points of closest approach on the route drawings for the redundant cable routes.
- [ ] Measure and record the minimum physical distance between the A and B routes during installation, and make sure it is at least 2 metres.
- [ ] Take and store photo evidence at the measurement point, and keep it together with the as-built drawings and the inspection and acceptance records.
- [ ] Update the system security planning documentation to reference the redundant power design and the requirement for at least 2 metres of separation (≥ 2 m).
- [ ] Implement a change-control checkpoint that requires re-checking separation distances and updating supporting evidence for any changes to power cabling.


---

#### PE-9.2 — Automatic Voltage Controls (Enhancement)

This requirement is about keeping the electricity supply stable for the most important equipment that handles Secret and Confidential information. It does this by using automatic devices that continuously check the incoming power and automatically correct or stabilise it when it starts to vary. Without this protection, even small power problems can damage equipment, cause outages, or result in data loss and service disruption—especially for mission-critical servers, network switches and routers, storage systems, and security appliances.

To meet this expectation, the organisation must keep a documented list of exactly which of these components require automatic voltage monitoring and stabilisation. It must then ensure the correct equipment is installed for each component and configured to monitor the voltage and respond automatically.

The organisation must also document how the voltage is monitored and what actions are taken when voltage limits are exceeded. It must assign named individuals responsible for environmental protection and information security, and record the equipment details and settings in the relevant plans and procedures. This provides clear evidence that the arrangements are in place and working as intended.

##### Automatic voltage control for critical loads with monitored thresholds

- Category: Manual
- Priority: Critical

###### WHAT
Install and run automatic voltage controls (voltage regulators/conditioners/stabilisers) in the organisation-defined **critical system components’** power supply path (mission-critical servers, network switches/routers, storage arrays, and security appliances that handle Secret/Confidential data). Continuously monitor the incoming power and automatically correct voltage when it goes out of range.

###### WHY (control requirement)
NIST SP 800-53 **PE-9(2)** enhancement requires: **“Employ automatic voltage controls for {{ param, pe-09.02_odp }}.”** The guidance explains that these controls must **monitor and control voltage**, including using **voltage regulators, voltage conditioners, and voltage stabilizers**.

###### HOW (specific approach)
1. **Create and keep up to date the official list of critical loads** for **pe-09.02_odp**, and link each component on the list to its physical power path (uninterruptible power supply/power distribution unit → automatic voltage control device → load).
2. **Choose automatic voltage control equipment** that fits the power path and the type of load (for example, regulator/conditioner/stabiliser). Make sure each device supports:
   - voltage monitoring,
   - automatic correction/stabilisation,
   - event/state logging,
   - alert output (for example, simple network management protocol (SNMP)/syslog/application programming interface (API)) to the organisation’s monitoring platform.
3. **Set organisation-approved voltage limits and thresholds** on each device (under-voltage/over-voltage and fault conditions) and turn on the automatic control actions.
4. **Link monitoring and alerts** so that voltage problems and device faults create clear, actionable alerts. Route these alerts into the enterprise monitoring/information technology service management (ITSM) process used by infrastructure operations, with agreed severity and escalation.
5. **Keep audit-ready records** by updating the relevant **system security plan** and physical/environmental protection documentation to include:
   - the pe-09.02_odp component list,
   - the device type used for each component (regulator/conditioner/stabiliser),
   - device identifiers and the configuration profile used,
   - where monitoring and alerts are sent,
   - maintenance and operational responsibilities.
6. **Test and regularly check** that the controls work by reviewing device logs/events and confirming alerts are generated and tickets are raised during planned maintenance windows (or through vendor self-tests where available). Save the results as evidence.

###### WHO
- **Infrastructure/Facilities Engineering Lead**: responsible for power-path design, equipment selection, and installation.
- **Security/Compliance Lead**: ensures the pe-09.02_odp scope and documentation updates meet governance and audit requirements.
- **Operations (Data Centre/IT Operations)**: maintains configurations, monitors alerts, and keeps evidence.

###### Acceptance criteria
- Every asset in the **pe-09.02_odp** list is linked to a power path that includes an **automatic voltage control device** (regulator/conditioner/stabiliser).
- Devices are configured with **monitoring turned on** and **automatic voltage control actions enabled**.
- Voltage out-of-range and fault events produce **recorded logs** and **alerts** that are sent into the enterprise monitoring/ITSM workflow.
- The **system security plan / physical/environmental protection documentation** includes the required component list, device identifiers, configuration profile/threshold references, and monitoring/alert destinations.
- Evidence exists (configuration exports and recent log/alert records) showing the controls are working and that alerts are actionable.

###### Actions Required for Compliance

- [ ] Define and get approval for the official inventory of pe-09.02_odp critical system components that require automatic voltage control.
- [ ] Create power-path diagrams that show how each **pe-09.02_odp** component connects to its **uninterruptible power supply (UPS)**, its **power distribution unit (PDU)**, and its **automatic voltage control device**.
- [ ] Procure automatic voltage control equipment (voltage regulator/conditioner/stabiliser) that allows monitoring, automatic correction of voltage problems, and records events in a log.
- [ ] Set the organisation-approved low-voltage and high-voltage limits, and turn on automatic actions to correct the voltage on each device.
- [ ] Integrate device alerts (for example, simple network management protocol (SNMP), system log (syslog), or application programming interface (API) alerts) into the organisation’s monitoring and IT service management (ITSM) process, with clear escalation steps.
- [ ] Update the system security plan and the physical and environmental protection documents to include device identifiers, configuration profiles, and where monitoring and alerts should be sent.
- [ ] Keep evidence by exporting the device settings and checking recent voltage-control records and alerts to confirm the system is working effectively.


---

### PE-10 — Emergency Shutoff (Control)

This requirement ensures there is a clear, quick way to switch off power to the data centre’s server racks and the equipment that distributes that power if something goes seriously wrong. Without an emergency shutoff that works reliably and can be reached immediately, a fire, flood, electrical fault, or other urgent incident could spread damage, put people at risk, or cause major disruption that takes much longer to resolve.

The organisation must:
- Provide an emergency shutoff capability that can switch off power to the server racks and the associated power distribution units.
- Install emergency shutoff switches or devices at every data hall electrical room entrance and at the main power distribution unit control panel.
- Ensure only authorised personnel can activate the emergency shutoff.
- Physically and procedurally protect these shutoff devices from unauthorised use.
- Keep clear written procedures for when to use the shutoff and how to restore power safely.
- Ensure the responsible staff know the correct locations and the steps to follow.

##### Hardwired emergency shutoff for data hall racks/PDUs with access control

- Category: Manual
- Priority: Critical

###### WHAT
Set up a physically hardwired emergency power shutoff that can quickly cut power to the defined **data centre server racks and the associated power distribution units (PDUs)**. Install emergency shutoff devices at the required locations and protect them so they cannot be used by unauthorised people.

###### WHY (control requirement)
PE-10 requires an emergency power shutoff capability for facilities that hold concentrations of system resources. This ensures there is a **fast way to cut power in emergencies**, and that emergency shutoff switches/devices are **clearly located** and **controlled so only authorised people can use them**.

###### HOW (specific steps/approach)
1. **Define the exact power scope**: for each emergency shutoff device, specify which server racks and associated PDUs it must switch off (rack-to-PDU-to-breaker/feed mapping per data hall).
2. **Install hardwired emergency shutoff circuits** that directly interrupt the relevant power paths for the mapped racks/PDUs (do not rely on software to perform the cut).
3. **Place emergency shutoff devices at the defined locations**:
   - at **each data hall electrical room entrance**
   - at the **main PDU control panel**
   Use consistent labelling and keep the approach routes clear.
4. **Restrict activation to authorised personnel** using physical access control:
   - locked enclosures/locked covers for the shutoff devices
   - controlled keys (key register held under facilities/security control)
   - tamper-evident seals and/or tamper detection where feasible
5. **Protect the controls from unauthorised use** by keeping clear physical barriers, using visible signage, and carrying out periodic access/condition checks (with evidence kept for audit).
6. **Create and maintain documented emergency shutoff and safe power-restoration procedures** (including verification steps and the safe order for restoring power). Ensure responsible staff can follow them through tabletop walkthroughs.

###### WHO
- **Facilities/critical power engineer**: designs and implements the hardwired power cut, and confirms the correct equipment is switched off.
- **Data centre operations lead / on-call operations**: owns the emergency shutoff and restoration procedures and runs walkthroughs.
- **Security (physical security) and/or facilities security manager**: owns key control, access authorisation, and periodic checks.
- **Compliance/assurance**: checks that enough evidence is available for audit.

###### Acceptance criteria
- For each data hall, an emergency shutoff device is installed and clearly labelled at **each electrical room entrance** and at the **main PDU control panel**.
- Activating each device switches off only the defined **server racks and associated PDUs** mapped to that device (confirmed through test records).
- Shutoff devices are protected by locked enclosures and controlled key access; tamper evidence/condition checks are in place.
- Documented procedures exist for emergency use and safe restoration, and walkthroughs/tabletops have been completed with the responsible staff.
- Audit evidence is available: device location records, scope mapping, test/validation results, key control records, and procedure/training evidence.

###### Actions Required for Compliance

- [ ] Create a clear connection map from each data hall emergency shutoff device to the correct power distribution unit (PDU) and circuit breaker/feed.
- [ ] Design and install fixed (hardwired) power cut-off circuits that switch off power to the mapped server racks and the connected power distribution units (PDUs).
- [ ] Install emergency shut-off devices at the entrance to every data hall electrical room and at the main power distribution unit (PDU) control panel, with clear signage.
- [ ] Lock and protect each shut-off device using controlled key access and tamper-evident seals, with a key register kept under Facilities and Security control.
- [ ] Test and record that each shut-off device correctly turns off power to the intended racks and power distribution units (PDUs), and that it results in the expected safe condition.
- [ ] Publish emergency shut-off and safe restart procedures, and run scenario “tabletop” walkthroughs with on-call operations and facilities staff.


---

### PE-11 — Emergency Power (Control)

This requirement is about making sure your equipment does not suddenly stop when the main electricity supply fails, so you have enough time to switch it off properly. Without an uninterruptible power supply, a power cut could cause sudden shutdowns, corrupted files, loss of information, disruption to services, and even safety risks during an emergency.

To meet this expectation, the organisation must provide an uninterruptible power supply for the relevant systems. When the main power source is lost, it must automatically switch to emergency power within seconds and keep the system running long enough to complete an orderly shutdown.

The organisation must also:
- document which equipment the uninterruptible power supply powers and how it supports the shutdown
- keep this documentation up to date
- test the arrangement to confirm it works, and record the results

In addition, the organisation must have clear emergency power procedures that:
- name who is responsible
- explicitly instruct staff to use the uninterruptible power supply to achieve the orderly shutdown
- ensure the system’s plans reflect these instructions.

##### UPS-backed orderly shutdown with automated trigger and evidence

- Category: Software
- Priority: Critical

###### WHAT
Provide a correctly sized and configured uninterruptible power supply (UPS) for the in-scope application infrastructure. If the main power supply fails, the UPS must automatically provide near-immediate emergency power and supply enough battery time to carry out an **orderly shutdown** of the affected systems (per **pe-11_odp: “an orderly shutdown of the system”**).

###### WHY (control requirement)
PE-11 requires the organisation to **provide an uninterruptible power supply** to achieve the required outcome (**pe-11_odp**) during **loss of the main power supply**. This means the UPS must switch over automatically and provide enough time to complete the orderly shutdown (not just a short “ride-through”).

###### HOW (specific steps/approach)
1. **Identify UPS coverage and shutdown targets**: Create a clear list showing which production components (for example, application servers, the hypervisor/host, critical network services, storage controllers, and any management endpoints needed to coordinate shutdown) are powered by each UPS, and which of them must perform the orderly shutdown.
2. **Size the UPS for enough time to finish shutdown**: Estimate the highest realistic load during a power event (including growth margin and battery ageing). Set a battery runtime target that is longer than the measured/validated time needed to complete the orderly shutdown sequence under worst-case conditions.
3. **Set up automatic switching and shutdown triggers**: Configure the UPS and its management interface (for example, simple network management protocol (SNMP), vendor application programming interface (API), or an agent) so that when the UPS reports **running on battery** (and/or the estimated remaining runtime drops below a set threshold), the system starts the orderly shutdown automatically (for example, orchestrating the hypervisor/host shutdown and stopping services in the correct order).
4. **Carry out shutdown orchestration**: Make sure the shutdown sequence is predictable and safe (stop application services, stop or reduce traffic where applicable, close and flush sessions, stop dependent services in the correct order, then power down hosts). Ensure it is triggered by the UPS signal without anyone needing to intervene manually.
5. **Document and test the arrangement**: Keep an auditable set of documents covering which systems are covered by each UPS, the shutdown trigger thresholds, the shutdown sequence logic, and the expected signals/indicators. Run periodic tests that simulate loss of main power (or use UPS self-test/transfer testing where possible) and record results showing shutdown completes within the required battery runtime.
6. **Operational procedures and accountability**: Update emergency power procedures/runbooks so staff understand the UPS is intended to support an orderly shutdown. Include named responsibilities, escalation steps, and what to check if shutdown does not complete as expected.

###### WHO
- **Infrastructure/Platform Engineering Lead**: responsible for mapping UPS coverage, sizing, and configuration.
- **Systems/Virtualisation Administrator**: implements shutdown orchestration and confirms the stop order is safe.
- **Security/Compliance Owner**: ensures documentation, evidence retention, and alignment with procedures for audit purposes.
- **Operations Team (on-call)**: follows emergency power procedures and escalation guidance.

###### Acceptance criteria
- During a simulated loss of main power, the UPS automatically switches to battery power and the in-scope systems start the orderly shutdown without manual intervention.
- The measured battery runtime during tests is sufficient for shutdown to complete within the defined operational expectation for **pe-11_odp**.
- UPS-to-system coverage and shutdown trigger settings are documented and kept up to date.
- Test evidence is available showing successful shutdown completion (including timestamps/indicators) and any corrective actions taken for deviations.
- Emergency power procedures explicitly reference UPS behaviour and the orderly shutdown outcome, including named responsibilities and escalation steps.

###### Actions Required for Compliance

- [ ] Create a matrix showing, for all in-scope systems, which components are powered to achieve **PE-11 ODP**.
- [ ] Calculate and set uninterruptible power supply (UPS) battery runtime targets that are longer than the longest measured orderly shutdown time, including allowance for battery ageing and extra load margin.
- [ ] Set up uninterruptible power supply (UPS) monitoring (for example, using simple network management protocol (SNMP), the supplier’s application programming interface (API), or an agent) so it can detect when the UPS is running on battery and when the estimated remaining runtime falls below agreed thresholds, and then automatically shut down the connected system.
- [ ] Set up and test a controlled shutdown process that stops services in the correct order, stops new traffic and lets existing work finish, and then powers down the host systems. This process should be started when the uninterruptible power supply (UPS) triggers.
- [ ] Run and record scheduled tests that simulate a primary power loss or power transfer, and show that the system completes its shutdown within the required time window.
- [ ] Publish and keep up to date emergency power procedures and escalation contact details, making sure they refer to the uninterruptible power supply (UPS) status indicators and the expected orderly shutdown process.


---

#### PE-11.1 — Alternate Power Supply — Minimal Operational Capability (Enhancement)

This requirement is about ensuring your key systems keep running during a long power cut. It requires a backup power supply that turns on automatically and maintains the minimum level of operation you need. Without this, an extended loss of main electricity could stop essential services, disrupt work, and prevent you from operating or responding when it matters most.

To meet this expectation, the organisation must:
- provide an alternative power supply for the in-scope system;
- ensure it switches on automatically if the main power fails; and
- confirm it can sustain the minimum required operation for an extended outage.

The organisation must also:
- document how the backup is set up and used;
- test it to prove it takes over automatically and can run at the minimum required level;
- keep records of those tests; and
- include this approach in the system’s security planning.

Named individuals must be responsible for emergency power actions. Emergency power procedures must be clear and easy to access, and staff with information security responsibilities must be involved in overseeing the arrangement.

##### Automatic UPS failover sized for minimum capability during outages

- Category: Software
- Priority: Critical

###### WHAT
Set up an alternate power supply for the in-scope system that automatically starts when the main power source is lost (per **pe-11.01_odp**). This alternate supply must keep the system running at its **minimum required operational capability** for an **extended** power outage.

###### WHY (control requirement)
PE-11(1) enhancement requires an alternate power supply that turns on when primary power is lost and can keep the system at its minimum required operational capability during an extended outage. The guidance allows this to be met using a secondary commercial power supply or another external power supply.

###### HOW (specific steps/approach)
1. **Define the minimum operational capability and duration**: agree the exact set of services and components that must stay available (for example, authentication/identity connectivity, core application endpoints, logging/monitoring data intake, database connectivity, and essential network services). Also agree the target duration for an extended outage.
2. **Set up the alternate power supply**: install a correctly sized uninterruptible power supply (UPS) (and/or automatic transfer to a secondary commercial or external power supply, if used). Make sure the switch-over is automatic and that the protected equipment matches the defined minimum capability. Ensure the UPS is configured to start automatically (no manual start).
3. **Configure automatic activation and alarms**: set the UPS/transfer settings so they trigger when primary power is lost. Turn on operational alerts for “on UPS/external power”, “runtime remaining”, and “approaching end of runtime”.
4. **Prove the capability with tests and evidence**: carry out controlled failover tests (where safe) and verify runtime to show (a) automatic takeover and (b) continued operation of the defined minimum capability for the required extended duration. Record the test date/time, what takeover behaviour was observed, runtime remaining, and which services stayed operational.
5. **Document and include in security planning**: update system documentation and the system security plan to explain what is powered, the conditions for activation, the basis for expected runtime, and the failover behaviour. Ensure emergency power procedures reference the arrangement and explain what to do if runtime is not sufficient.
6. **Assign named responsibilities and involve security**: name the roles responsible for emergency power actions. Ensure information security reviews how “outage mode” affects security-relevant functions (for example, logging continuity, availability of monitoring and alerts, and triggers for incident response).

###### WHO
- **Infrastructure/Facilities Engineering Lead**: designs and implements the UPS/transfer arrangement and load protection.
- **Application/Platform Owner**: confirms the components that make up the minimum operational capability and checks service behaviour during tests.
- **Information Security Officer / Security Architect**: reviews and approves documentation and security planning updates, and ensures security-relevant impacts are addressed.
- **Operations Manager**: maintains emergency power procedures and ensures tests are carried out and evidence is kept.

###### Acceptance criteria
- The in-scope system automatically switches to the alternate power supply when primary power is lost (no manual intervention required).
- During an extended outage test (or a validated runtime demonstration), the system maintains the agreed **minimum operational capability** for the required duration.
- Test evidence is available showing automatic takeover and sustained minimum capability (including runtime remaining/observed duration and confirmation of which services remained available).
- The arrangement is documented in the system security plan and emergency power procedures, including what is powered and the expected runtime.
- Named responsibilities are assigned for emergency power actions, and information security review is completed for security-relevant outage impacts.

###### Actions Required for Compliance

- [ ] Define the system’s minimum operational capability and the required maximum length of time it must remain unavailable.
- [ ] Choose and size a backup power supply (uninterruptible power supply (UPS) and/or automatic switching to a secondary or external power source) to cover the agreed minimum power demand.
- [ ] Set up the backup power supply to switch on automatically if the main power fails, in line with **PE-11.01_ODP**.
- [ ] Set up and connect uninterruptible power supply (UPS) and power-transfer status, plus runtime alerts, to the operations monitoring system.
- [ ] Run failover and live-operation tests to confirm that automatic takeover works and that the system can continue to meet the minimum required capability, and keep the test results as evidence.
- [ ] Update the system security plan and emergency power procedures to list which powered components are included, the conditions that trigger activation, and the expected runtime.
- [ ] Assign named responsibility for emergency power during an outage, and complete a review of information security impacts related to security during outage mode.


---

#### PE-11.2 — Alternate Power Supply — Self-contained (Enhancement)

This requirement is about ensuring your system can keep running if the main power fails. It requires a backup power source that turns on automatically. Without this, a long power cut could switch off critical services, disrupt work, and potentially lead to loss of important operations because the system would have no reliable power to run on.

To meet this expectation, the organisation must provide an alternative power supply for the system that:
- turns on automatically when the main power source is lost,
- is self-contained and does not rely on power from elsewhere, and
- can keep the system operating at full capability during an extended loss of the main power source.

The organisation must also document how the backup power works, what it powers, and how it supports full operation during a long outage. In addition, it must keep records showing the backup has been tested to confirm it starts automatically and can sustain full operation.

##### Self-contained auto-start generator/UPS for full operational capability

- Category: Software
- Priority: Critical

###### WHAT
Set up an alternate power supply for the system that **switches on automatically** when the main power is lost, is **self-contained** (it provides its own power), and keeps the system running at **full operational capability** for the organisation-defined length of time called the “extended loss”.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) PE-11(2) enhancement requires an alternate power supply that:
- turns on automatically (parameter **pe-11.02_odp.01 = automatically**), and
- is self-contained and able to keep the system at **full operational capability** (parameter **pe-11.02_odp.02 = full operational capability**) during an extended loss of main power.

Guidance allows long-term self-contained power using one or more generators with enough capacity.

###### HOW (specific steps/approach)
1. **Define the “full operational capability” load** for the production system (for example: application services, data services, required security and monitoring endpoints, and the network services needed to operate). Clearly exclude non-essential loads using a documented load-reduction approach.
2. **Size the power and runtime**: measure or estimate the steady power use and the highest power needs (including start-up surges) for the defined load. Then size the alternate power system (uninterruptible power supply (UPS) and/or generator) to run for the required duration in the organisation’s extended outage definition, accounting for battery/generator ageing and reduced performance at higher temperatures.
3. **Enable automatic switching**: configure the alternate power system so that when main power fails, it automatically switches to the alternate source (for example: UPS transfer/temporary support followed by generator start, or generator start directly depending on the design). Confirm the switching time is acceptable for the application.
4. **Confirm self-contained operation**: check the design does not rely on external power generation (for example: generator fuel is stored on site and sized for the required duration; the UPS is powered internally; there is no reliance on third-party power supplies).
5. **Document the design and assumptions**: produce an auditable record including equipment ratings/models, the load list, runtime calculations, switching/activation logic, fuel/battery assumptions, and operational limits (for example, conditions when maintenance bypass is used).
6. **Test and keep evidence**: carry out planned and/or staged tests to prove that (a) the system starts automatically when main power is lost, and (b) it can run for the required duration with the defined load (or a validated equivalent test method). Keep test reports, measured runtime and power quality results (voltage/frequency), and record any deviations with corrective actions.

###### WHO
- **Infrastructure and Facilities Engineering Lead**: responsible for generator/UPS design, sizing, and installation.
- **Site Reliability and Platform Engineering Lead**: checks that the application load coverage is correct and that full operational capability is maintained during tests.
- **Security and Compliance Lead**: ensures documentation and evidence meet audit expectations, and that the load set matches “full operational capability”.

###### Acceptance criteria
- Alternate power **starts automatically** within the designed switching window when main power is lost.
- The alternate power system is **self-contained** and supports the defined “full operational capability” load set for the organisation-defined extended loss duration.
- Documentation is available for load coverage, sizing calculations, switching/activation logic, and assumptions.
- Test evidence shows automatic activation and sustained operation (including measured performance), with corrective actions completed for any failures or deviations.

###### Actions Required for Compliance

- [ ] Define and get approval for the system power-load settings needed to achieve “full operational capability” during an extended primary power outage.
- [ ] Measure power usage and calculate the required uninterruptible power supply (UPS) and generator capacity, and how long they must run, for the approved set of loads.
- [ ] Set up automatic switching so that backup power starts automatically if the main power fails.
- [ ] Check that the system can run on its own by confirming that the on-site fuel or battery supply is enough to last for the extended period, without needing any outside power generation.
- [ ] Create an auditable alternate power design record that includes equipment details, how power transfers work, the sizing calculations, and all assumptions.
- [ ] Carry out and record an automatic start test (and a sustained run test, or an equivalent validated test) and keep the results as audit evidence.


---

### PE-12 — Emergency Lighting (Control)

This requirement is about making sure the building can guide people to safety if the power goes out. Automatic emergency lighting must be installed, kept in working order, and designed to turn on by itself during a power cut or other loss of power. It must light all emergency exits and the evacuation routes leading from them.

Without this, people may not be able to find exits, could become trapped in poorly lit areas, and evacuation could be delayed or unsafe—especially in places where important equipment is located.

To meet this expectation, the organisation must provide emergency lighting for the relevant areas, make sure it turns on correctly during tested power-disruption scenarios, and keep it working after any maintenance. It must also have clear written procedures, up-to-date records showing which exits and routes are covered, named staff responsible for emergency lighting planning, and records proving that emergency lights are tested and that any faults are followed up and fixed.

##### Automatic emergency lighting with exit/route coverage register

- Category: Manual
- Priority: Critical

###### WHAT
Install and maintain automatic emergency lighting that turns on during a power outage or other power disruption, providing light for all emergency exits and evacuation routes in the facility areas that support the application.

###### WHY (control requirement)
NIST SP 800-53 **PE-12** requires the organisation to **provide and maintain automatic emergency lighting** that **turns on during a power outage or disruption** and **covers emergency exits and evacuation routes** within the facility.

###### HOW (specific approach)
1. **Define scope and coverage mapping**: Create an **Emergency Lighting Coverage Register** listing every emergency exit and every evacuation route section (corridors, approaches to stairwells, doorways, and route junctions) for the floors/rooms used by the application’s operational teams (for example, server rooms, operations areas, and administration areas).
2. **Select compliant lights and signs**: Specify emergency lights/exit signs that are designed for **automatic activation when normal power is lost** and that meet the building and fire safety standards the organisation uses (for example, local fire code requirements). Record the installed asset identifiers against the coverage register.
3. **Implement a test-and-evidence process**: Set up a scheduled **functional testing programme** (as required by the facility’s safety rules) to confirm automatic activation and sufficient lighting. Keep auditable records (pass/fail, date/time, location, tester, and any faults) and store them in the organisation’s document control system.
4. **Maintain and fix issues**: If tests show failure or reduced performance, raise a corrective work order, re-test after the fix, and update the coverage register if any replacement changes coverage.
5. **Link to contingency planning**: Include the emergency lighting capability and coverage locations in the organisation’s **contingency plan** for power-related disruptions, including which areas are covered and how failures are handled (for example, escalation and alternative processing/site considerations if coverage cannot be provided).

###### WHO (roles responsible)
- **Facilities/Building Services Manager**: responsible for installation specifications, maintenance, and testing.
- **Health & Safety / Fire Safety Officer**: checks coverage against evacuation routes and ensures compliance with applicable safety requirements.
- **Business Continuity Manager**: ensures the contingency plan references emergency lighting capability and limitations.
- **Configuration/Asset Management Lead**: maintains the Emergency Lighting Coverage Register and links to supporting evidence.

###### Acceptance criteria
- A complete **Emergency Lighting Coverage Register** exists for all emergency exits and evacuation routes in the facility areas that support the application.
- For each listed exit/route section, there is an associated emergency light/exit sign asset that is **set to turn on automatically when normal power is lost**.
- Functional test records show **automatic activation** was checked for the defined areas, with evidence kept, and any faults fixed and re-tested.
- The organisation’s **contingency plan** for power disruptions clearly references emergency lighting coverage for the relevant system areas and records what actions will be taken if emergency lighting cannot be provided.

###### Actions Required for Compliance

- [ ] Create an emergency lighting coverage register that lists every emergency exit and the evacuation route sections it lights up for all facility areas relevant to the application.
- [ ] Specify and install emergency lights and exit signs that turn on automatically if the normal power fails, and record the asset identification numbers against the coverage register.
- [ ] Set up and run a planned functional test to confirm that automatic activation works correctly and that there is enough light for every registered exit and every route section.
- [ ] Store test results that can be audited (pass or fail, where the test was run, date and time, who tested, and any faults found) in the organisation’s controlled document repository.
- [ ] Set up a corrective action process for any tests that fail or perform poorly, including re-running the tests and updating the coverage register after the fixes are completed.
- [ ] Update the organisation’s contingency plan to include emergency lighting coverage for the relevant system areas, and document what to do if emergency lighting cannot be provided, including escalation steps and alternate site considerations.


---

#### PE-12.1 — Essential Mission and Business Functions (Enhancement)

This requirement is about making sure people can still leave safely if the power goes out in the parts of your building that are most important for your work. If emergency lighting is not provided in every essential area, corridors, rooms, and exit routes could become dark. This would increase the risk of injury and cause delays and disruption during an emergency.

To meet this requirement, the organisation must first clearly identify which areas support essential mission and business functions. It must then install emergency lighting and ensure it is working in every part of those areas, including the spaces that lead to emergency exits and evacuation routes.

The organisation must keep clear records showing what areas are covered, which exits and routes are supported, and who is responsible for planning and maintaining the system. It must also carry out emergency lighting tests and keep records of the results, showing that all essential areas were checked and that any faults found were followed up and fixed.

##### Essential-areas register and emergency lighting coverage-to-exit mapping

- Category: Manual
- Priority: Critical

###### WHAT
Create and keep an auditable list (register) of the facility areas that support the organisation’s essential mission and business functions. Then link that list to an emergency lighting coverage plan that clearly shows which emergency exits and evacuation route sections are lit for each essential area.

###### WHY (control requirement)
PE-12(1) (Enhancement) requires the organisation to **provide emergency lighting for all areas within the facility that support essential mission and business functions**. The guidance explains that **organisations define what their essential missions and functions are**, so the scope of “essential areas” must be clearly defined and shown to be covered.

###### HOW (specific steps/approach)
1. **Define essential areas**: create an “Essential Areas Register” (by floor/zone/room) using input from business and operations teams. Include any areas needed to keep critical services running (for example, operations rooms, critical support functions, data/communications rooms, and control rooms).
2. **Create a coverage-to-exit matrix**: for each essential area, record which emergency lighting fittings/zones provide coverage and the **specific emergency exits and evacuation route sections** that the lighting supports.
3. **Standardise identifiers**: use the same room/zone codes across floor plans, the emergency lighting asset register (computerised maintenance management system/enterprise asset management (CMMS/EAM)), and the test sheets. This ensures evidence can be traced without confusion.
4. **Use controlled documentation**: store the Essential Areas Register and the coverage-to-exit matrix in a controlled system (with version control and an approval process) and ensure changes are managed.
5. **Set installation checks and testing scope**: use the matrix to decide which fittings/areas must be included in routine emergency lighting inspections and tests. Make sure test records use the same essential-area identifiers and link to the relevant exits/routes.
6. **Maintain change triggers**: require that any change to layout or occupancy that affects essential areas (for example, partitioning, re-zoning, or moving critical functions) triggers a review and update of the register and coverage-to-exit matrix.

###### WHO (role responsible)
- **Facilities/Estates Engineering Lead**: owns the emergency lighting coverage matrix and the mapping to assets.
- **Business Continuity / Operations Owner**: provides and confirms the list of essential mission and business functions, and the resulting essential areas.
- **CMMS/EAM Administrator**: ensures asset identifiers and work orders use the same identifiers as the matrix.
- **Compliance/Assurance Lead**: checks audit readiness and that evidence can be traced.

###### Acceptance criteria
- An approved Essential Areas Register exists, is up to date (version-controlled), and has clear ownership.
- A coverage-to-exit matrix exists showing, for every essential area, the emergency lighting coverage and the emergency exits/evacuation route sections supported.
- Identifiers are consistent across floor plans, CMMS/EAM asset records, and emergency lighting test records (no differences caused by free-text entries).
- A sample audit shows that a selected essential area can be traced from the register → coverage matrix → specific fittings → the latest test evidence.
- Documented change triggers ensure the register/matrix is reviewed whenever essential areas or layouts change.

###### Actions Required for Compliance

- [ ] Run a business and operations workshop to identify and agree which parts of the facility support the essential mission and business activities.
- [ ] Create an Essential Areas Register using standard room and zone names or codes, and assign a single accountable owner.
- [ ] Create an emergency lighting coverage matrix that links each essential area to its emergency lighting fittings or zones, and to the specific exits and evacuation route segments.
- [ ] Keep the register and matrix in a controlled, version-managed shared repository, with an approval workflow.
- [ ] Set up computerised maintenance management system (CMMS) / enterprise asset management (EAM) asset IDs and test work orders so the test records use the same essential-area IDs and the same exit and route details.
- [ ] Set clear triggers for changes so that any change to layout or occupancy that affects essential areas requires a review and update of the register/matrix.


---

### PE-13 — Fire Protection (Control)

This requirement is about making sure your buildings can recognise a fire early and respond reliably, even if the usual electricity supply fails. If fire alarms and fire-fighting systems are not correctly installed and working, a small fire could go unnoticed for too long, or the equipment meant to control it might not work when needed—putting people, critical equipment, and business continuity at serious risk.

To meet this expectation, the organisation must install and keep in working order fire detection and fire suppression systems in the relevant facilities. These systems must be powered by a separate, independent power source—separate from the building’s normal supply (or able to be separated)—so they continue to operate during a power loss. The organisation must also maintain these systems, carry out regular checks and tests, and keep clear records showing they have been inspected, tested, and are ready to use when required.

##### Independent-power fire detection/suppression design and commissioning

- Category: Manual
- Priority: Critical

###### WHAT
Install and keep working fire detection and fire suppression systems in the relevant facilities (for example, data centres, server rooms, and mainframe computer rooms). Make sure these systems are backed by an independent power supply.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-13** requires the organisation to **install and maintain** fire detection and fire suppression systems that are **backed by an independent power supply**. The guidance explains that independent power can include **microgrids**. It also notes that systems that may need independent power include **sprinkler systems** and **smoke detectors**.

###### HOW (specific steps/approach)
1. **Create a list of in-scope facilities** covering every facility that hosts the application’s critical infrastructure (data centres, server rooms, mainframe rooms). For each room, record which fire alarm zones/areas it belongs to.
2. **Produce “as-built” fire protection engineering documents** that clearly show:
   - the fire detection system parts (for example, smoke/heat detectors, alarm panels, monitoring routes),
   - the fire suppression system parts (for example, sprinkler control valves, pump controllers, and suppression control electronics where used), and
   - the **normal power supply versus independent power supply** (for example, dedicated uninterruptible power supply (UPS)/battery feeds or a microgrid feed), including any isolation points.
3. **Test and formally approve the systems using independent power** (do not assume):
   - confirm the fire alarm panel and detection/monitoring functions still work when normal power is removed or isolated,
   - confirm the suppression control electronics (for example, pump controller/valve actuator control where applicable) receive and use the independent power supply to reach the intended operating state.
4. **Create a controlled evidence pack for each facility** that links every device/zone to the power setup and the commissioning results (for example, device lists, zone mapping, single-line diagrams, panel schedules, commissioning certificates, and test results).
5. **Hand over to operations so maintenance can be done correctly** by making sure the commissioning “starting point” is reflected in the maintenance work instructions. This ensures the “maintain” expectation in PE-13 is supported by something that can be checked during an audit.

###### WHO
- **Fire protection engineer / safety engineering lead**: produces the as-built design and commissioning plan.
- **Facilities/operational technology (OT) electrical engineer**: checks that power separation and independent power feeds are correct.
- **Security/Compliance governance, risk, and compliance (GRC) lead**: confirms the evidence pack is complete and ready for audit.
- **Facilities operations / maintenance team**: receives the commissioning starting point and updates maintenance work instructions.

###### Acceptance criteria
- For every in-scope facility, there is an auditable record mapping **fire detection and fire suppression components** to **normal versus independent power** (including isolation points).
- Commissioning records show **independent power operation** for detection/monitoring functions, and where suppression control electronics exist, for suppression control functions.
- The evidence pack is complete and traceable to facility asset identifiers (zone/area mapping + device lists + power diagrams + commissioning/test certificates).
- The documentation matches what is actually installed (as-built) and is stored in a controlled repository that is available for audit.

###### Actions Required for Compliance

- [ ] Create a list of all in-scope facilities and map each room to the relevant fire alarm zone or area.
- [ ] Create “as-built” fire detection and fire suppression diagrams that show the normal power setup and the separate (independent) power and isolation points.
- [ ] Install the fire alarm control panels and the fire detection and monitoring wiring paths, with independent checks that the power supply is correctly isolated (normal power disconnected/removed).
- [ ] Commission the suppression control electronics (for example, pump and valve control where used) to confirm they can operate using independent power.
- [ ] Compile a site-level evidence pack that links each device and zone to the site’s power design and to commissioning and testing certificates.
- [ ] Update the maintenance work instructions to refer to the commissioning baseline and the required independent power checks.


---

#### PE-13.1 — Detection Systems — Automatic Activation and Notification (Enhancement)

This requirement is about ensuring that, when a fire is detected, the building’s fire alarms automatically activate and immediately alert the correct people—without anyone needing to press a button. If this does not happen, a fire could be discovered too late, the wrong people could be notified, or emergency response could be delayed, putting lives, the site, and any sensitive activities at risk.

The organisation must ensure its fire detection systems automatically trigger an alert on a fire and automatically notify the Facility Security Officer, the Information System Security Officer, and the building fire warden, as well as the local base fire and emergency services dispatch and the on-duty fire response team. It must clearly state who is included on these notification lists, assign named responsibilities for detection and notification, and keep documented procedures, records of the devices and systems used, and test evidence showing that the alerts work as intended—including during power disruption using an independent power source.

##### Automatic fire alarm activation with dual internal/external notification

- Category: Software
- Priority: Critical

###### WHAT
Set up the site’s fire detection and fire alarm system so that, when a fire is detected, it **automatically**:
- **activates** the fire alarm response, and
- **notifies** the right people and services.

Notification must be sent to:
- **{{pe-13.01_odp.01}}** (Facility Security Officer, Information System Security Officer, and the building fire warden)
- **{{pe-13.01_odp.02}}** (Local base fire and emergency services dispatch and the on-duty fire response team)

Notification must continue during a fire, even if there is **a power disruption**, by using an **independent power source** for the notification function.

###### WHY (control requirement)
NIST SP 800-53 **PE-13(1)** enhancement requires fire detection systems that **automatically activate** and **automatically notify** the organisation’s defined internal roles and **emergency responders** when a fire is detected. It also expects the notification method to use **independent power** so notification is not affected by the fire.

###### HOW (specific approach)
1. **Use the Fire Alarm Control Panel (FACP) as the trigger**: configure the FACP so that fire detection events automatically start the alarm and notification actions (with **no manual start**).
2. **Set up two notification routes from the FACP**:
   - **Internal notification route** to {{pe-13.01_odp.01}} using an approved signalling/announcement method (for example, monitored alarm messages to the security desk, announcements in controlled areas, or an approved paging/text message gateway that is directly triggered by the FACP).
   - **External notification route** to {{pe-13.01_odp.02}} using the approved signalling route to the dispatch/receiving centre (for example, a monitored transmission to the alarm receiving centre, with agreed expectations for testing and acknowledgement).
3. **Provide independent power for notification**: check that the FACP and any connected communication/paging/receiving transmission equipment used for notification are **backed by batteries or otherwise powered independently**, and can operate for the required length of time during fire scenarios.
4. **Record and document who is notified and how**:
   - Keep a current, auditable record of which internal roles are notified and by what method ({{pe-13.01_odp.01}}), and which external responders are notified and by which signalling route ({{pe-13.01_odp.02}}).
   - Include escalation and acknowledgement expectations where relevant (for example, that the dispatch receives and logs the event).
5. **Prove it through testing and records**:
   - Keep and retain FACP event logs that show detection leads to notification.
   - Carry out supervised tests that confirm both internal and external notification routes work, and store the results in an auditable record system.
   - Include at least one test showing notification still works during a simulated power disruption, following the manufacturer’s and site’s safety procedures.

###### WHO
- **Facility Security Officer (FSO)**: owns the internal notification list and confirms the correct roles are mapped.
- **Information System Security Officer (ISSO)**: confirms the notification process includes the required information technology security role and that day-to-day procedures match security governance.
- **Building Fire Warden**: confirms the internal notification works effectively on site.
- **Facilities/Fire Safety Engineering (or the contracted fire alarm installer)**: programs and maintains the FACP, sets up the signalling connections, and verifies independent power.
- **Alarm Receiving Centre / Local base dispatch liaison**: confirms the external signalling route and how the receiving centre responds.

###### Acceptance criteria
- A fire detection event results in **automatic activation** and **automatic notification** to all entities listed in {{pe-13.01_odp.01}} and {{pe-13.01_odp.02}}.
- There is evidence (FACP logs and test records) showing detection-to-notification works for both internal and external routes.
- Independent power verification is documented, and a test (or documented validation) shows notification continues during a power disruption.
- Notification mappings (who/what is notified and by which signalling method) are documented, current, and any changes are controlled through formal change management.

###### Actions Required for Compliance

- [ ] Set up the fire alarm control panel so that fire detection events automatically send alarm and notification messages, without any manual start.
- [ ] Link {{pe-13.01_odp.01}} to the approved internal notification routes and record this link in an auditable configuration document.
- [ ] Route {{pe-13.01_odp.02}} through the approved external dispatch and receiving signalling path, and confirm what the receiving centre expects for testing and acknowledgement.
- [ ] Check and record that the notification feature has coverage from an independent power source (for example, a battery backup or another independent power supply), including for any connected communication devices.
- [ ] Run supervised tests to confirm that internal and external notifications work correctly, and store the fire alarm control panel (FACP) event logs and test evidence in a compliance repository.
- [ ] Carry out a power-disruption validation test, following the safety and manufacturer instructions, and record the results to show that notification remains available.


---

#### PE-13.2 — Suppression Systems — Automatic Activation and Notification (Enhancement)

This requirement ensures the fire suppression system can take action by itself and immediately raise the correct alerts, even when no one is on site. Without this, a fire could spread before help is called, or the people who need to respond could be missed, delayed, or unable to reach the right responders—particularly during nights, weekends, or planned closures when the site is not continuously staffed.

The organisation must ensure the suppression system automatically starts releasing suppression when needed, and automatically alerts the facility security officer, the system owner, and the designated operations duty officer, as well as the installation fire marshal and the on-call base emergency response team. It must also clearly identify who these recipients are, ensure they have the right permissions to respond, and ensure the alerting still works during a power loss by using independent backup power.

##### Configure fire suppression auto-release and resilient multi-recipient alerts

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up the fire suppression system so it can **automatically activate** (release suppression without anyone manually triggering it) and **automatically notify** both:
- **Internal duty roles/personnel** (for example: facility security officer, system owner, designated operations duty officer)
- **External/on-call emergency responders** (for example: installation fire marshal and the on-call base emergency response team)

Make sure the notification function has **independent power and resilience**, so alerts are not affected by fire-related power loss.

###### WHY (control requirement)
The PE-13(2) enhancement guidance requires that suppression systems can act **automatically** and that notification systems can still work during fire conditions (including power loss). It also requires listing the **specific people/roles and emergency responders** who must receive notifications, so they have the right access permissions and clearances to respond.

###### HOW (specific steps/approach)
1. **Set up automatic suppression release** in the suppression controller/fire panel, so activation happens based on fire detection and alarm conditions (no manual action by an operator).
2. **Configure automatic notification routing** from the fire panel/suppression controller to two recipient groups:
   - Internal: facility security officer, system owner, designated operations duty officer
   - External: installation fire marshal and the on-call base emergency response team  
   Use the fire panel’s built-in alarm/notification outputs, or an alarm communicator/gateway that supports sending to multiple recipients and escalation.
3. **Set escalation and acknowledgement behaviour** (where supported by the panel/communicator), for example: if no one acknowledges within a set time, escalate from internal duty roles to external responders.
4. **Ensure notification resilience during power loss** by making sure the notification route uses **independent power** (for example: a battery-backed panel/communicator and/or an independent alarm gateway power supply), and document what is expected to happen and how long it will operate during loss of mains power.
5. **Confirm access permissions for responders** by ensuring the roles/people listed for notifications are covered by the organisation’s facility access authorisation process, so they can enter restricted areas when notified. Keep an up-to-date record mapping notification recipients to the authorised access routes/levels.
6. **Produce audit-ready evidence**: keep fire panel/communicator event logs showing suppression activation and the times alerts were sent, and keep records of periodic unattended tests showing notifications during simulated conditions.

###### WHO (role responsible)
- **Fire safety engineer / operational technology (OT) systems engineer**: configure suppression automatic release and alarm routing/escalation.
- **Facilities/security officer**: confirm the internal recipient list and ensure access permissions/clearances for notified roles.
- **Installation fire marshal / emergency response coordinator**: confirm external responder contact details and escalation expectations.
- **Compliance/assurance lead**: check evidence collection and that test records are retained for audit.

###### Acceptance criteria
- Suppression releases automatically when the configured fire detection/alarm conditions occur (verified through test records; no manual triggering required).
- After activation, notifications are automatically sent to **all defined internal roles** and **all defined external/on-call responders**.
- Notification delivery continues to work during a simulated loss of mains/power-loss scenario (verified by test evidence showing independent power operation).
- Recipient lists and escalation rules are documented, up to date, and changes are controlled.
- Evidence exists (event logs and test records) showing suppression activation and the timing of alert transmissions.
- Notified recipients/roles have the appropriate facility access permissions/clearances to respond to the affected areas.

###### Actions Required for Compliance

- [ ] Set up the fire suppression control unit and fire panel so they automatically release the suppression system when the agreed detection and alarm conditions are met.
- [ ] Set up alarm and notification routing so alerts are sent to the internal on-call duty roles list (facility security officer, system owner, and the designated operations duty officer).
- [ ] Set up alarm and notification routing so alerts are sent to the external on-call responders list (the installation fire marshal and the on-call base emergency response team).
- [ ] Set up and record clear rules for when escalations and acknowledgements must happen, so that external responders are contacted if internal teams do not acknowledge within the agreed time limits.
- [ ] Test that the notification system can still work independently during a power failure by running a controlled power-loss test and recording the results.
- [ ] Create and keep an up-to-date record showing which notification recipients or job roles are allowed to access each facility, including the clearance level they need to respond.
- [ ] Record and keep records of panel/communicator events and unattended test evidence showing when suppression was activated and the times alerts were sent.


---

#### PE-13.4 — Inspections (Enhancement)

This requirement is about making sure your building’s fire safety is checked properly and fixed quickly, so small problems do not turn into a serious incident. Without an annual inspection by the right, properly qualified fire safety professionals, problems with fire alarms, sprinklers, fire extinguishers, or other fire safety arrangements could be missed, putting people and property at risk.  

To meet this expectation, the organisation must arrange an annual fire safety inspection for each relevant facility by authorised and qualified inspectors, such as state, county, or city fire inspectors and fire marshals. The organisation must keep the inspection records and ensure any issues they identify are formally recorded and corrected within 30 days.  

If the inspection requires access to areas that may contain sensitive information, the organisation must provide an escort for the inspectors during those parts of the visit.

##### Annual fire inspection workflow with 30-day deficiency closure

- Category: Software
- Priority: Critical

###### WHAT
Set up an inspection-to-closure process to ensure every facility gets fire protection inspections at the agreed frequency. Only authorised and suitably qualified inspectors must carry out (and be recorded for) the inspections. Any problems found must be formally recorded, and each one must be fixed within the agreed time period (30 days), with evidence that can be checked later. If an inspection needs access to sensitive information areas, make sure escorts are provided and that this is recorded.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) PE-13(4) requires facilities to be inspected for fire protection by authorised and suitably qualified inspectors, and for any problems found to be fixed within the time period defined by the organisation. The guidance also requires escorts during inspections when systems within the facilities contain sensitive information.

###### HOW (specific steps/approach)
1. **Create an “Authorised Inspector” list**: keep a controlled list of approved inspector identities and roles (for example, fire inspectors or fire marshals). Store the qualification and jurisdiction evidence used to confirm that each inspector is authorised and qualified for each inspection.
2. **Set up an inspection workflow in the enterprise IT service management (ITSM) / enterprise asset management (EAM) system** (for example, ServiceNow, Jira, or Maximo):
   - Create a standard “Fire Protection Inspection” record for each facility and each inspection event.
   - Capture required fields: facility, inspection date, inspector identity (linked to the authorised inspector list), inspection report reference, and the list of deficiencies.
   - Automatically set each deficiency due date to **inspection date + 30 days**.
3. **Track deficiencies and require closure evidence**:
   - Each deficiency must be linked to a corrective action or work order.
   - Do not allow the workflow to be closed unless closure evidence is attached (for example, a contractor completion certificate, an updated inspection/verification record, and photos where applicable) and the deficiency reference matches.
   - Do not allow items to be marked complete after the 30-day service level agreement (SLA) unless an approved exception record exists (exception handling must follow your organisation’s process).
4. **Record escort requirements for sensitive areas**:
   - Add a workflow step to flag whether the inspection will access sensitive information areas.
   - If flagged, require named escort(s) and the access time window(s) to be recorded in the inspection record (and/or referenced to the visitor management log).
5. **Produce audit-ready evidence packs**:
   - For each inspection event, generate a report that includes: the inspection report link, deficiency list, due dates, closure dates, closure evidence, and escort evidence (if applicable), with an unchangeable audit trail.

###### WHO (role responsible)
- **Fire Safety / Facilities Manager**: owns the inspection programme, ensures inspections are scheduled, and drives deficiencies to closure.
- **Compliance / Assurance (or Risk / Regulatory team)**: reviews exceptions (if used) and checks that audit evidence is sufficient.
- **ITSM / EAM Administrator**: configures workflow fields, controls, and reporting.
- **Authorised Inspector Liaison / Security Operations**: ensures escorts are arranged and recorded when sensitive areas are accessed.

###### Acceptance criteria
- For each facility, an inspection record exists at the agreed frequency (annually) and includes an inspector identity that is on the authorised inspector list.
- Every deficiency found during the inspection is recorded as a separate item with a due date of inspection date + 30 days.
- All deficiencies are closed with attached closure evidence, and closure happens within 30 days of identification (or an approved exception record exists, in line with organisational governance).
- Where sensitive information areas are accessed, the escort(s) and access time window(s) are recorded and can be retrieved as evidence.
- Audit evidence packs can be produced for a selected inspection event showing the inspection, deficiencies, due dates, closure dates, and links to evidence.

###### Actions Required for Compliance

- [ ] Create and keep an authorised inspector register, with proof of each inspector’s qualifications and the jurisdictions they are approved to inspect, for every acceptable inspector identity.
- [ ] Set up an IT service management (ITSM) and enterprise asset management (EAM) workflow for “Fire Protection Inspection”. Make the following details mandatory: the site or facility, the inspector’s identity, the inspection report reference, and the list of deficiencies.
- [ ] Set controls (“guardrails”) that automatically calculate the due date for any deficiency as the inspection date plus 30 days, and prevent a case from being closed unless there is a linked corrective action and supporting closure evidence.
- [ ] Add a “sensitive area” flag, and require the names of the escort(s) and evidence of the approved access time window before inspections are allowed into areas that contain sensitive information.
- [ ] Set up automated generation of audit packs that brings together inspection reports, deficiency tracking, proof of closure, and proof of escorting, with an unchangeable audit record.
- [ ] Run a trial inspection process for one site, check that every identified issue is fixed within 30 days, and produce complete evidence for the audit.


---

### PE-14 — Environmental Controls (Control)

This requirement is about keeping the room that houses your important equipment at the correct climate, and ensuring you are warned immediately if conditions move outside the acceptable range. If temperature and dampness are allowed to vary too much, the equipment can overheat, be damaged, or become unreliable—potentially stopping services your business depends on.

To meet this expectation, the organisation must:
- identify the specific facility and room where the system is located; and
- keep the temperature between **18°C and 27°C** and the relative humidity between **40% and 60%** at all times.

The organisation must continuously monitor these conditions and raise alerts whenever either temperature or humidity goes outside the allowed limits, sending the alerts to the named people responsible for oversight and response.

The organisation should also:
- document how these settings are maintained;
- assign clear responsibilities;
- include the environmental arrangements in its planning documents; and
- keep dated records of temperature and humidity readings, including evidence that alerts were raised for any out-of-range events.

##### Calibrated temp/RH monitoring with 18–27°C and 40–60% alerts

- Category: Software
- Priority: Critical

###### WHAT
Put in place environmental controls for the specific facility/room(s) where the application is hosted. Keep **temperature between 18–27°C** and **relative humidity between 40–60% RH**, and **continuously monitor** these values. Set up **alerts** so you are notified whenever the readings go outside the required limits.

###### WHY (control requirement)
PE-14 requires environmental controls to prevent harm to **availability** of systems and components caused by poor facility environmental conditions. The organisation’s defined targets cover the required **temperature and humidity**, and the monitoring approach is **continuous monitoring with alerts**.

###### HOW (specific steps/approach)
1. **Scope the facility/room(s):** Identify the exact server room(s) / data hall zones where the application’s production (and, if applicable, disaster recovery) infrastructure is located. Document which room maps to which part of the application environment.
2. **Deploy calibrated sensors:** Install calibrated temperature and humidity sensors following documented placement rules (for example, use representative locations across hot and cold areas; avoid placing sensors where airflow could skew results). Record each sensor’s ID, calibration date, and next calibration due date.
3. **Configure threshold alerting:** Configure the monitoring system to enforce the organisation-defined acceptable limits: **temperature 18–27°C** and **humidity 40–60% RH**. Set alert rules so alerts trigger when readings fall outside these ranges. Use alert suppression or “buffer” logic to reduce false alarms while still alerting on genuine breaches.
4. **Enable continuous monitoring and evidence logging:** Make sure the monitoring system records readings continuously (near real time) and keeps **time-stamped** logs that can be used as audit evidence.
5. **Route alerts to named owners:** Send alerts to the designated operational owners (and an information security oversight channel where required by your governance model). Use the enterprise ticketing or IT service management (ITSM) process so alert handling can be traced.
6. **Create response procedures and records:** Maintain a runbook that explains what to do immediately when readings go out of range (for example, check heating, ventilation and air conditioning (HVAC) and humidification, escalate, and take corrective action). Ensure corrective actions are recorded against the alert or ticket.
7. **Link to security planning:** Reference the environmental control scope, targets, monitoring, and response process in the relevant security planning documents (for example, the system security plan linkage) so auditors can trace “controls in place” back to “controls documented”.

###### WHO (role responsible)
- **Infrastructure/Facilities Engineering Lead:** sensor installation, alignment of HVAC and humidification settings, and sensor calibration management.
- **IT Operations / Data Centre Operations Manager:** monitoring platform configuration, alert routing, and runbook ownership.
- **Information Security (Governance, Risk and Compliance (GRC)) / Security Architect:** links to security planning documentation and audit evidence requirements.

###### Acceptance criteria
- Temperature readings for the defined room(s) stay within **18–27°C** and humidity stays within **40–60% RH** during normal operating periods, with any exceptions managed through the alert workflow.
- The monitoring platform provides **continuous** logging and generates alerts when either limit is breached.
- Alerts are sent to **named** operational owners and are traceable in ITSM/ticket records.
- Evidence is available for: (a) sensor calibration status, (b) time-stamped readings, and (c) alert/ticket records for any out-of-range events.
- Environmental control scope and response procedures are documented and linked to the system’s security planning artefacts.

###### Actions Required for Compliance

- [ ] Identify and record the exact facility room or rooms where the application infrastructure is hosted, and link each sensor to the correct room.
- [ ] Fit temperature and humidity sensors, and record each sensor’s ID, calibration date, and the date when the next calibration is due.
- [ ] Set the monitoring system alert thresholds to temperatures of 18–27°C and humidity of 40–60% relative humidity (RH), with alerts triggered if these limits are exceeded.
- [ ] Set up continuous temperature and humidity logging, with time-stamped records kept for an appropriate period so it can be used as audit evidence.
- [ ] Set up alert routing so alerts are sent to named operational owners through IT service management (ITSM), so each alert creates a traceable ticket.
- [ ] Publish and keep a step-by-step guide (runbook) for handling out-of-range alerts, and record what corrective action was taken for each alert or ticket.
- [ ] Link the environmental monitoring programme—its scope, targets, and response process—to the system security planning documentation.


---

#### PE-14.1 — Automatic Controls (Enhancement)

This requirement is about automatically keeping the areas where your important equipment is stored at safe temperature and moisture levels, so conditions do not slowly move into damaging extremes. Without this, heat, dampness, or overly dry air can gradually harm or degrade equipment, which can cause failures, downtime, or expensive repairs.

The organisation is expected to install automatic temperature and humidity sensors in the relevant areas, continuously monitor the readings, and have the heating, ventilation and air conditioning system automatically adjust to keep conditions within agreed safe limits. If the readings go outside those limits, the system must automatically raise alarms and record what happened, including the safe limits that were exceeded and how the alarms behaved.

The organisation must also document the safe limits, the site layout, the automated setup, and the procedures for what staff should do if monitoring or automatic adjustment fails. This documentation must include named responsibilities, and there must be evidence showing that monitoring, adjustments, and alarms are working as intended.

##### BMS-integrated temperature/humidity auto-control with alarm logging

- Category: Software
- Priority: Critical

###### WHAT
Set up automatic environmental controls for the facility or system areas where equipment is housed. Continuously monitor temperature and humidity, and automatically adjust heating, ventilation and air conditioning (HVAC) settings (for example, temperature targets and operating modes) when conditions move towards or beyond agreed safe limits. Set up automatic alarms, and make sure alarm events and control actions are recorded so they can be reviewed during audits.

###### WHY (control requirement)
NIST SP 800-53 PE-14(1) requires **automatic environmental controls** to prevent **fluctuations that could be harmful to the system** (parameter: **pe-14.01_odp: “automatic environmental controls”**). Continuous monitoring and an immediate HVAC response reduce the risk that environmental conditions damage or degrade system components.

###### HOW (specific steps/approach)
1. **Set environmental limits for each equipment housing zone**: For each identified equipment housing area (for example, server room, data hall, communications room), document the acceptable temperature and humidity ranges, plus the warning and critical thresholds. Add hysteresis/deadbands to stop the HVAC system from repeatedly switching on and off.
2. **Install and enable sensors for continuous readings**: Place temperature and humidity sensors in each zone and connect them to the facility automation layer (typically a building management system (BMS) or building controller). Ensure readings are continuously collected and available for the control rules.
3. **Set rules for automatic HVAC adjustments**: Configure the BMS so HVAC operation automatically changes based on sensor readings (for example, cooling/heating stages, fan speed, humidification/dehumidification) without needing manual action.
4. **Set up automatic alarms and escalation**: Create alarm triggers for warning and critical threshold breaches. Define how alarms should behave (for example, whether acknowledgement is required, how quickly escalation happens, and who is notified—such as on-call/facilities and relevant security/operations contacts). Ensure alarms activate automatically when thresholds are exceeded.
5. **Enable audit-ready record keeping**: Ensure the BMS records (a) sensor readings, (b) when thresholds are crossed, and (c) what HVAC control actions were taken in response, including timestamps. Keep records in line with the organisation’s retention requirements.
6. **Document the implementation and day-to-day procedures**: Update the system/facility environmental procedures and the system security plan references to include the housing layout, the agreed limits, alarm behaviour, and the identifiers for the automated control configuration.
7. **Test through commissioning**: Run controlled commissioning tests (for example, temporarily simulate conditions within safe bounds) to confirm that alarms trigger and HVAC automatic adjustments work as configured, and that the expected records are captured.

###### WHO (role responsible)
- **Facilities/Building Services Engineer**: sensor placement, HVAC/BMS integration, control logic configuration.
- **System Owner / Infrastructure Owner**: approves the agreed limits and ensures coverage for all system housing zones.
- **Security/Compliance Lead**: ensures documentation, evidence retention, and auditability meet governance requirements.
- **Operations/On-call Lead**: confirms alarm escalation and acknowledgement procedures.

###### Acceptance criteria
- Temperature and humidity are continuously monitored in each defined system housing zone.
- HVAC responds automatically to sensor readings according to the documented thresholds (including hysteresis/deadbands) without manual intervention.
- Warning and critical alarms trigger automatically when thresholds are exceeded and follow the documented escalation/notification behaviour.
- The BMS (or equivalent) produces audit-ready records showing sensor readings, threshold crossings, and HVAC control actions with timestamps.
- Commissioning/validation tests confirm correct alarm triggering and control action behaviour, and the results are retained as evidence.

###### Actions Required for Compliance

- [ ] Identify and document all building areas (system housing zones) and map them to the corresponding environmental control zones, including the boundaries for each zone.
- [ ] Set safe limits for temperature and humidity (warning and critical thresholds). Add hysteresis or deadbands so the system does not repeatedly switch back and forth around those limits.
- [ ] Connect temperature and humidity sensors to the building management system (BMS) and building controller, and collect the data continuously.
- [ ] Set up building management system (BMS) control logic to automatically adjust heating, ventilation and air conditioning (HVAC) operation based on sensor readings, with no manual control actions required.
- [ ] Set up automatic alarm points and define how alerts are escalated and notified when warning and critical thresholds are exceeded.
- [ ] Turn on and confirm time-stamped logging for sensor readings, threshold crossings, and heating, ventilation and air conditioning (HVAC) control actions; keep the logs for the period required by organisational policy.
- [ ] Run commissioning tests to recreate the threshold conditions and confirm that alarms, heating, ventilation and air conditioning (HVAC) responses, and log entries behave exactly as described in the documentation.


---

#### PE-14.2 — Monitoring with Alarms and Notifications (Enhancement)

This requirement is about ensuring the building where the system is housed can detect dangerous environmental changes early and alert the right people immediately. By continuously checking conditions such as temperature and humidity, the organisation reduces the risk of harm to staff and helps prevent damage to equipment that can occur when conditions move outside safe limits. This can otherwise lead to outages, expensive repairs, or safety incidents.

To meet this requirement, the organisation must install environmental monitoring in the facility housing the system and set it up so that, when readings suggest potentially harmful changes, it triggers an audible alarm and/or a clear visual warning. It must also send real-time notifications to the Facilities Operations Duty Officer, the Environmental Health and Safety (EHS) lead, and the on-call Network Operations Centre engineer.

The alerts must reach these named roles promptly. The organisation must also keep records showing what was monitored and what triggered each alarm, so incidents can be reviewed and handled effectively.

##### Environmental monitoring alarms with role-based real-time notifications

- Category: Software
- Priority: Critical

###### WHAT
Set up environmental monitoring for the facility where the system is housed (at minimum temperature and humidity). The monitoring must detect potentially harmful changes and immediately trigger an audible and/or visual alarm, as well as send real-time notifications.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 PE-14(2) enhancement requires the organisation to “use environmental control monitoring that provides an alarm or notification of changes potentially harmful to personnel or equipment” for the organisation-defined personnel or roles.

###### HOW (specific approach)
1. **Use the facility’s official monitoring source** (for example, Building Management System (BMS) or a dedicated environmental monitoring platform) as the source of truth for temperature and humidity readings.
2. **Set alarm thresholds** for “potentially harmful” conditions using manufacturer limits and Environmental Health and Safety (EHS) requirements. Configure the platform so alarms trigger when thresholds are exceeded (and, where supported, when sensors report faults or invalid readings).
3. **Enable local audible and visual alarms** in the relevant facility area(s) so on-site staff are alerted immediately (for example, a siren and/or beacon and/or a clearly visible alarm message panel).
4. **Set up real-time notifications** to the organisation-defined roles:
   - Facilities Operations Duty Officer
   - Environmental Health and Safety (EHS) lead
   - On-call Network Operations Centre (NOC) engineer  
   Make sure notifications account for on-call status (for example, by integrating with the organisation’s on-call schedule or rotation process).
5. **Keep central records for audit purposes**: store time-stamped readings, threshold values, alarm state changes, sensor identifiers, and whether notifications were delivered successfully or failed in a central log or monitoring system.
6. **Strengthen the alerting connections**: limit access to the BMS or monitoring platform and the notification delivery endpoints using least-privilege service accounts, network segmentation and allow-listing, and updates that follow the organisation’s change control process.

###### WHO (roles responsible)
- **Facilities Operations Duty Officer / Facilities Operations team**: check that alarm routing works correctly, and ensure on-site alarms are visible and can be acted upon.
- **EHS lead**: approve what counts as “potentially harmful” thresholds and what notifications should be sent.
- **NOC engineer (on-call)**: confirm notifications arrive in time and that the process for handling incidents or creating tickets is integrated.
- **Facilities/Operational Technology (OT) Engineering (or BMS administrator)**: set up sensor coverage, thresholds, and local alarm announcements.
- **Security and Compliance (with the IT monitoring team)**: ensure logging, access controls, and evidence retention meet audit requirements.

###### Acceptance criteria
- Temperature and humidity monitoring is enabled for the system facility and continuously collects live readings.
- If configured thresholds are exceeded (or sensor fault conditions occur, if implemented), the system raises an audible and/or visual alarm in real time.
- Real-time notifications are sent automatically to all three organisation-defined roles, including the on-call NOC engineer, without manual intervention.
- Alarm events are recorded with timestamps, sensor or zone identifiers, measured values, threshold values, and notification delivery outcomes.
- Changes to alarm/notification settings are made through the organisation’s change and configuration management process and are restricted to authorised roles.

###### Actions Required for Compliance

- [ ] Confirm the system’s facility coverage, and link each monitored area or zone to the environmental sensors used by the building management system (BMS) and monitoring platform.
- [ ] Set up the temperature and humidity sensors, and confirm that live readings are being collected correctly, that each sensor is working properly, and that the system checks and collects data at the right time intervals.
- [ ] Agree with the Environment, Health and Safety (EHS) team on what alarm levels could be harmful, and put those levels in place as configurable settings that are managed through change control.
- [ ] Set up local audible and/or visual alarms for events that reach the alarm level in the relevant facility area(s).
- [ ] Set up real-time alerts to go to the Facilities Operations Duty Officer, the environment, health and safety (EHS) lead, and the on-call network operations centre (NOC) engineer, using the organisation’s on-call schedule integration.
- [ ] Set up central logging of alarm events in the organisation’s monitoring and logging platform, including the time of the event, the measured value, the threshold, the sensor or zone identifier, and whether the notification was successfully delivered.
- [ ] Use service accounts with the minimum permissions needed, restrict network access using allow-lists and network segmentation, and control who can change building management system (BMS) and monitoring settings.


---

### PE-15 — Water Damage Protection (Control)

This requirement is about preventing water leaks from turning into expensive damage. It requires main water shut-off valves or local isolation valves for the areas where important equipment is kept, such as server rooms or data centres. If these valves are not installed and usable, a leak can spread quickly, damaging critical equipment, disrupting services, and leading to costly clean-up and downtime.

To meet this expectation, the organisation must:
- install the correct shut-off or isolation valves for the site’s water supply, and keep them physically accessible and working properly
- keep clear, up-to-date records showing where the valves are and how to operate them
- ensure named key staff know the exact locations and the step-by-step process for turning off the water when needed, including an organisational process for activating the shut-off and recording that it has been done

##### Accessible master shutoff/isolation valves with tested activation

- Category: Manual
- Priority: Critical

###### WHAT
Provide main shutoff valves or local isolation valves for the facility’s water supply to the areas that house the application’s critical infrastructure (for example, server rooms, data centre floors, communications rooms). Make sure each valve is **easy to reach**, **working properly**, and **known to the key people who need to use it**.

###### WHY (control requirement)
NIST SP 800-53 **PE-15** requires protection against damage caused by water leaks by using **main shutoff or isolation valves** that are **easy to reach**, **working properly**, and **known to key personnel**. The guidance also explains that isolation valves can be used to stop water flow in specific areas without shutting down the whole organisation.

###### HOW (specific approach)
1. **Link protected areas to water supply zones**: Create a facilities-led map showing which parts of the site (for example, production, testing, and disaster recovery hosting areas as applicable) contain critical resources, and link each one to the exact water supply line(s) and the matching shutoff/isolation valve(s). Use existing “as-built” drawings and carry out site walkdowns.
2. **Install and label valves for day-to-day use**: Make sure every required shutoff/isolation valve is installed and labelled with a unique identifier, the protected area name, and clear **OPEN/CLOSE** directions. Add signage at the valve access point and, where needed, along the route to reach it.
3. **Check that valves can be reached and used**: Confirm each valve can be reached and operated without unreasonable delay (for example, it is not blocked by equipment, not behind access controls that are not managed, and does not require unusual tools). Where access is controlled, ensure key personnel have authorised access.
4. **Carry out readiness checks**: Set up a risk-based maintenance plan (at least every six months for higher-risk areas such as data centre/server rooms). Each check must confirm the valve can be moved to the shutoff position and then returned to normal operation. Keep proof of the check (date, valve identifier, technician, result).
5. **Maintain an audit-ready valve register and emergency steps**: Keep a controlled document set (“valve register”) listing each valve’s identifier, location (site address/room/coordinate), protected area, normal position, and step-by-step instructions for use. Include an emergency activation process that states who authorises the shutoff, who carries it out, and who must be informed (for example, facilities/security/IT, as defined by the organisation).
6. **Train and test key personnel**: Identify key personnel (for example, facilities duty manager, on-call facilities engineer, incident commander for the hosting environment). Run regular walkdowns and checks of competence, where staff physically locate the correct valve and explain the activation steps.

###### WHO
- **Facilities/Estates Manager**: owns the valve mapping, installation, labelling, and maintenance schedule.
- **Facilities Engineering/Technicians**: carry out readiness checks and record evidence.
- **Security Operations / Incident Management Lead**: defines the emergency activation process and what notifications are expected.
- **Application/Infrastructure Owner (hosting environment)**: ensures the protected areas list includes all critical hosting locations for the application.
- **Compliance/Assurance**: checks that evidence is complete for audits.

###### Acceptance criteria (verifiable)
- A current **valve register** exists and covers every facility area that hosts the application’s critical infrastructure, including valve identifiers, exact locations, and activation steps.
- For each listed valve, there is evidence of **functional readiness testing** within the defined maintenance interval (for example, within the last 6 months for higher-risk areas), showing the valve can be shut off and then restored.
- Valves are **physically accessible** (access is not blocked), and key personnel can demonstrate locating the correct valve and following the documented shutoff steps during a walkdown/competence check.
- The emergency **activation process** is documented and includes requirements for authorisation, execution, notification, and recording. At least one tabletop exercise or drill has been completed within the last year (or in line with the organisation’s incident-response schedule).

###### Actions Required for Compliance

- [ ] Create a site map that links each critical hosting area to the specific water supply pipe(s) and the required main shut-off or isolation valve(s).
- [ ] Install each required valve and give it a unique label showing the protected area name, with clear markings showing the correct OPEN and CLOSE direction.
- [ ] Remove any access barriers and confirm that stop valves can be reached and operated by authorised key staff without unreasonable delay.
- [ ] Set up and carry out a risk-based schedule of functional readiness tests for each valve, including both shut-off and restore actions, and keep the supporting evidence for each valve identified by its valve ID.
- [ ] Create and keep up to date a controlled log of the valve settings, and a step-by-step emergency activation procedure that covers who is authorised to act, how the actions are carried out, and who must be notified.
- [ ] Identify the key staff members and complete the required periodic site walkdowns and competency checks to confirm the valves are in the correct position and that the correct activation steps are followed.


---

#### PE-15.1 — Automation Support (Enhancement)

This requirement is about finding water where it should not be, straight away, and ensuring the right people are informed immediately. If water leaks are not noticed near the systems that keep the business running, they can cause damage, service interruptions, and expensive repairs, and the problem may grow before anyone realises what is happening.  

To meet this expectation, the organisation must automatically detect water near the system using water leak detection sensors placed in the relevant areas of each facility. When water is detected, the system must automatically trigger both a local audible warning and a local visible warning on site.  

At the same time, it must send an alert to the organisation’s monitoring setup so that the facilities duty officer and the on-call infrastructure operations lead are notified promptly, with enough information to act—including the location of the issue and the time it was detected.

##### Water leak sensors with local alarms and monitoring alerts

- Category: Software
- Priority: Critical

###### WHAT
Install automated water presence detection near the system using water leak detection sensors. Configure it to (1) trigger local audible and local visible alarms on site and (2) send an alert to the organisation’s monitoring platform.

###### WHY (control requirement)
NIST Special Publication 800-53 PE-15(1) (Automation Support) requires: “Detect the presence of water near the system and alert {{ insert: param, pe-15.01_odp.01 }} using {{ insert: param, pe-15.01_odp.02 }}.” The enhancement guidance explains that automated mechanisms include “notification systems, water detection sensors, and alarms.”

###### HOW (specific steps/approach)
1. **Define alert recipients and routing**: confirm the alert recipients are the **facilities duty officer** and the **on-call infrastructure operations lead** (pe-15.01_odp.01), and confirm the monitoring platform can send alerts to these roles (for example, via paging/SMS/voice/team messaging linked to the on-call schedule).
2. **Define automated mechanisms**: choose and configure **water leak detection sensors with local audible/visual alarms and an alert to the monitoring platform** (pe-15.01_odp.02).
3. **Place sensors to cover “near the system”**: identify the relevant facility areas (for example, electrical cabinets, uninterruptible power supply (UPS) rooms, server room perimeters, cable trenches/ducts) and assign them stable zone identifiers so the alert includes the **area/location**.
4. **Ensure local alarm independence**: wire/configure the sensors (or the facility alarm panel/gateway they connect to) so the audible/visual alarms activate directly when water is detected, without relying on the monitoring platform for the local alarm function.
5. **Integrate detection events to the monitoring platform**: configure the facility gateway/panel integration to send events to the monitoring platform, at minimum including: water detected status, zone/location, sensor/device identifier, and timestamp.
6. **Validate end-to-end behaviour**: run controlled tests for each zone to confirm that (a) the local audible alarm and local visible alarm activate promptly, and (b) the monitoring platform raises an alert routed to the duty officer and the on-call infrastructure operations lead.
7. **Record audit evidence**: keep logs/evidence from the monitoring platform and the facility alarm system showing the event time, zone/location, and notification delivery/acknowledgement (where supported).

###### WHO
- **Facilities engineering / facilities duty officer owner**: responsible for sensor placement, local alarm configuration, and evidence that local alarms work as expected.
- **Infrastructure operations lead (on-call)**: confirms alerts are routed to the on-call team and takes part in acceptance testing.
- **Monitoring/security information and event management (SIEM)/observability engineer**: implements and checks that the monitoring platform receives events and routes alerts to the correct roles.
- **Change manager**: ensures controlled deployment and testing in production and disaster recovery (DR) environments.

###### Acceptance criteria
- When water is detected in a defined zone, **local audible and local visible alarms** activate automatically within the vendor/system-defined response time.
- The monitoring platform receives the event and **alerts the facilities duty officer and the on-call infrastructure operations lead** using the configured automated mechanisms.
- Each alert includes at least **water detected**, **zone/location**, and **detection timestamp** (and sensor/device identifier if available).
- Test evidence exists for each covered zone showing both local alarm activation and monitoring platform alert delivery/routing.

###### Actions Required for Compliance

- [ ] Confirm who should receive the alerts, and set up the monitoring system so alerts are routed to the facilities duty officer and the on-call infrastructure operations lead.
- [ ] Select and install water leak detection sensors with local audible and visual alarms in all facility areas that are close to the system.
- [ ] Give every sensor a stable zone and location identifier, and make sure each event includes the zone, the time it happened (timestamp), and the sensor or device identifier.
- [ ] Set up the facility alarm panel or gateway so that water-detection alerts are sent to the monitoring platform.
- [ ] During sensor tests, confirm that local audible and visible alarms work independently of the monitoring platform.
- [ ] Carry out controlled tests in each network zone and record proof that local alarms activate and that monitoring alerts are sent, received, and acknowledged.


---

### PE-16 — Delivery and Removal (Control)

This requirement is about ensuring that only approved items can be brought into or taken out of your site, and that you can show what happened. Without it, unauthorised equipment, storage devices, or software updates could be smuggled in or removed, which could cause disruption, data loss, or unauthorised changes to systems.

To meet this expectation, the organisation must clearly set out which types of items are allowed to enter and leave. This includes hardware such as servers, workstations, and network devices, removable storage media, software or firmware updates, and parts. It must only allow items to enter when they have been authorised for entry, and it must manage the entry process so unauthorised items cannot be taken directly into sensitive areas.

It must also only release items when they have been authorised for exit, and it must control the exit process. Finally, it must keep accurate records of all system components that enter and exit the facility.

##### Authorised delivery/removal workflow with immutable scan-and-ticket records

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up controlled, auditable entry and exit for in-scope system items (hardware, removable media, software/firmware updates, and parts) so that only items with prior authorisation are allowed into, and released from, the facility.

###### WHY (control requirement)
Policy PE-16 requires authorisations to be enforced for bringing system components into and taking them out of the environment. This may mean limiting access to delivery areas, separating those areas from the system and media libraries, and keeping records that can be audited of deliveries and removals.

###### HOW (specific steps/approach)
1. **Define the in-scope item types and the identifiers needed** in an “In-scope Components” catalogue, based on the organisation’s agreed scope (hardware, removable media, software/firmware updates, and parts). For each type, specify what must be recorded (for example: asset tag/serial number for hardware; a unique media ID for removable media; the package hash/checksum and a reference to the signature verification for software/firmware updates; part number/lot for parts).
2. **Create one intake/dispatch process** in the organisation’s ticketing/workflow system (for example, ServiceNow or Jira Service Management) that generates an **authorisation reference** for every delivery or removal. The process must require these mandatory details: component type, identifier(s), quantity, purpose, destination/source system or component, requester, approver, and the required delivery/collection time window.
3. **Only accept items at controlled receiving/dispatch points when pre-authorised**: receiving/dispatch staff must only take in or release items when the authorisation reference is shown and matches the workflow record. Use barcode or QR scanning at check-in and check-out to link the physical item to the correct ticket line and prevent releasing the wrong item.
4. **Keep tamper-evident proof for every event**: store scan events and workflow status changes (created/approved/received/checked-in/released/returned) in an immutable or append-only logging method (for example, write-once-read-many storage or an immutable security information and event management (SIEM) event store). Include timestamps, operator identity, authorisation reference, and item identifiers.
5. **Control software/firmware updates using cryptographic checks**: ensure the ticket/workflow record includes the authorised software/firmware hash/checksum and the result/reference of signature verification (for example, the outcome of internal code-signing verification). Receiving/dispatch must confirm the update being delivered matches the authorised record before it is allowed in.
6. **Check that items leaving match the same authorisation**: at dispatch check-out, scanned items must be reconciled against the ticket line items and the asset register (where applicable). Any mismatch must stop the release and start an exception process.

###### WHO (role responsible)
- **Facilities/Security Operations**: run the controlled receiving/dispatch points and enforce “no authorisation reference, no intake/exit”.
- **IT asset management (ITAM)/Asset Management or Infrastructure Engineering**: maintain the in-scope component catalogue and the identifier requirements.
- **Service Management/Workflow Owner**: configure the ticketing workflow, mandatory fields, and approval routing.
- **Security (security operations centre (SOC)/incident response (IR) or governance, risk and compliance (GRC))**: ensure immutable logging, retention, and that audit evidence is available.

###### Acceptance criteria
- For each in-scope item type, the organisation can show that **intake and exit require a valid authorisation reference**, and that receiving/dispatch processes will not proceed without it.
- For at least one complete delivery/removal cycle, evidence shows **scan-in and scan-out records linked to the same ticket/workflow authorisation reference**, including timestamps, operator identity, and item identifiers.
- For software/firmware updates, evidence shows the **authorised software/firmware hash/checksum and signature verification reference** are recorded and checked during intake.
- Immutable/append-only logs provide a complete, searchable audit trail for all events (received/checked-in/released/returned), with no ability for routine operators to change past records.

###### Actions Required for Compliance

- [ ] Create and publish an in-scope components catalogue that covers hardware, removable media, software and firmware updates, and parts, including the required identifiers.
- [ ] Set up a ticket and workflow approval process that creates an authorisation reference for every delivery and removal event, with required fields.
- [ ] Set up barcode and QR code scanning at controlled receiving and dispatch points to link physical items to the correct ticket line items.
- [ ] Record workflow events and scan events in an unchangeable, add-only logging system, including the operator’s identity and the time and date of each event.
- [ ] Require software and firmware update submissions to include and check an authorised file hash or checksum, and to reference signature verification.
- [ ] Run reconciliation checks when a release is ready to go out. If anything does not match, stop the release and send the issue to the team for investigation.


---

### PE-17 — Alternate Work Site (Control)

This requirement is about making sure staff can work safely from approved alternative locations—such as United States Department of Defence (DoD) government facilities and pre-approved private homes—without reducing existing protections.

The main risk is that, if access is not strictly controlled when staff are away from their usual workplace, unauthorised people could gain entry. Sensitive information could be exposed if a work device is lost or accessed by someone else, and suspicious activity could go unnoticed—particularly if something goes wrong and staff do not know who to contact.

To meet this expectation, the organisation must:
- Keep a documented, approved list of the specific alternative locations that are allowed.
- For each approved location, require strong identity checks for every login.
- Protect work devices using encryption.
- Use only an approved, secure method for remote connection.
- Limit staff access permissions to only what they need for their role.
- Record activity so it can be reviewed.

The organisation must also check and document how well these protections work at each alternative site. Finally, it must provide a clear, easy-to-find way for employees to contact the organisation’s information security and privacy personnel immediately to report incidents.

##### Authorised alternate work sites with enforced secure access

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable, organisation-approved list of approved alternate work sites, and apply the organisation’s required security safeguards to every access attempt made from those sites.

###### WHY (control requirement)
PE-17 requires that alternate work sites are defined and authorised, and that the organisation’s required safeguards for those sites are put in place and checked to confirm they work effectively. This also includes a way to report security incidents from alternate work sites.

###### HOW (specific steps/approach)
1. **Create and maintain an auditable register of approved alternate work sites**. This register must list the specific allowed site types/instances (Department of Defense (DoD) government facilities and pre-approved employee private residences). It must include the approver’s identity, effective dates, and a record of changes.
2. **Only allow access from the approved sites** by using connection/session information. Require that all remote access from alternate work sites goes through the **approved secure virtual private network (VPN)** (or an equivalent approved secure access route), and only allow sessions when the connection originates from an approved route.
3. **Apply identity and device checks at sign-in** using enterprise identity conditional access:
   - Require **multi-factor authentication (MFA)** for all access (prefer authentication methods that are resistant to phishing).
   - Require **device encryption** and that the device meets compliance requirements before access is granted.
4. **Apply least-privilege access for sessions from alternate sites** using role-based access control (RBAC), and require time-limited, logged approval for any privileged actions.
5. **Centralise audit records for alternate-site activity** by sending identity sign-in events, VPN/zero trust network access (ZTNA) session events, and device compliance events to the **security information and event management (SIEM)** system so the activity can be reviewed.
6. **Provide a single incident reporting contact** that can be reached from any alternate work site (for example, one security/privacy incident reporting channel or number). Ensure this is included in employee guidance and any messages about alternate-site access.
7. **Check effectiveness for each alternate work site type/site** using evidence from the enforced safeguards (for example, sign-in and VPN success/failure rates, device compliance achievement, and completeness of audit records). Record the results and any remediation actions.

###### WHO (role responsible)
- **Information Security (Chief Information Security Officer (CISO)/Information Assurance)**: owns the governance of the alternate work site register, the security control definitions, and the effectiveness checks.
- **Identity and Access Management (IAM) team**: implements conditional access and multi-factor authentication (MFA) enforcement.
- **Endpoint Management team**: enforces device encryption and device compliance.
- **Network/Secure Access team**: implements and maintains the approved secure VPN/access route.
- **Security Operations Centre (SOC)/SIEM team**: ensures audit records are collected, kept for the required period, and used for alerts related to unusual alternate-site access.
- **Human Resources (HR)/Business Continuity/Facilities liaison**: supports the nomination and approval process for private residences and provides facility access details.

###### Acceptance criteria
- An auditable register exists that lists only the approved alternate work sites (Department of Defense (DoD) government facilities and pre-approved employee private residences), including an approval trail and effective dates.
- Access from alternate work sites is blocked unless the session uses the **approved secure VPN/access route**, the user completes **multi-factor authentication (MFA)**, and the device meets the **encryption and compliance** requirements.
- Sessions from alternate sites enforce **least privilege**, and any privileged actions are time-limited and logged.
- Identity, VPN/zero trust network access (ZTNA), and device compliance events for alternate-site access are recorded in the SIEM with enough detail to support review.
- Employees have one clearly communicated incident reporting contact that can be used from alternate work sites.
- Effectiveness evidence is collected and documented for each alternate work site type/site, and any gaps are tracked with remediation actions.

###### Actions Required for Compliance

- [ ] Set up an auditable list of approved alternate work sites for Department of Defense (DoD) facilities and pre-approved residences, including the approver’s identity, the start and end dates, and a record of all changes.
- [ ] Set up conditional access so that multi-factor authentication (MFA) is required for every sign-in coming through the approved secure virtual private network (VPN) or access route.
- [ ] Require endpoint encryption and compliance checks before allowing access, and automatically block or quarantine any devices that do not meet the requirements
- [ ] Use role-based access control (RBAC) and allow privileged actions only for a limited time during alternate-site sessions, with those actions recorded for audit purposes.
- [ ] Integrate sign-in identity records, virtual private network (VPN) or zero trust network access (ZTNA) session records, and endpoint compliance logs into the security information and event management (SIEM) system, using consistent event fields so teams can review activity from alternate sites.
- [ ] Set up and test one single incident reporting contact point (security and privacy) that can be reached from alternate work sites, and include this contact in communications sent to staff at alternate sites.
- [ ] For each alternate work site type and site, carry out and record effectiveness checks using access and compliance evidence, and track any required fixes until they are fully completed.


---

### PE-18 — Location of System Components (Control)

This expectation is about placing important equipment in the correct physical locations inside your buildings. This makes it less likely to be damaged and less likely to be accessed, tampered with, or overheard by people who should not be able to reach it. Without this, floods, fires, vandalism, terrorism, and electrical faults could damage the equipment. Also, unauthorised people near entrances or public areas might be able to interfere with it or intercept information that is sent or spoken.

To meet this expectation, the organisation must set out and follow documented rules for where each item of equipment is placed. These rules must be based on a written list of relevant risks, such as floods, fires, terrorism, vandalism, electromagnetic effects, and electrical interference. The organisation must record where each item is located and which approved rooms or areas it is in. It must include this approach in its system plan, appoint named people to make and review placement decisions, and keep evidence that the process is followed when equipment is installed, moved, or upgraded.

##### Hazard-based component placement standard with location evidence

- Category: Manual
- Priority: High

###### WHAT
Set out and enforce a documented, hazard-based standard for where system components are physically placed within facilities. Keep auditable records showing the current location of each component.

###### WHY (control requirement)
PE-18 requires that system components are placed within the facility to (1) minimise potential damage from physical and environmental hazards defined by the organisation (pe-18_odp) and (2) minimise opportunities for unauthorised access, including interception risks due to being close to entry points or public areas.

###### HOW (specific steps/approach)
1. **Create a “Placement Standard”** that links the hazard categories defined in **pe-18_odp** (floods, fires, terrorism, vandalism, electromagnetic pulse, electrical interference, and other incoming electromagnetic radiation) to clear placement rules. This includes approved rooms/areas, rack or enclosure requirements, expectations for separation where electromagnetic interference or electromagnetic pulse risks apply, and restrictions for areas near entry points or public access.
2. **Define an approved location catalogue** with unique identifiers down to the level needed for evidence (for example: building → floor → room → rack or cabinet → mounting position). Include which locations are controlled or restricted, and which are higher risk because they are close to unauthorised access opportunities.
3. **Set up a placement decision workflow** for installation, relocation, and upgrades. Engineers must choose an approved location from the catalogue. The workflow checks the choice against the hazard-based placement rules. Any departure from the standard must be treated as an exception, with documented risk acceptance and time-limited compensating actions.
4. **Record component location and reason** in the authoritative asset record (or configuration management database (CMDB) / information technology asset management (ITAM) integration). Record the component identifier, approved location identifier, date of placement, and the hazard-rule set used.
5. **Collect placement evidence when the change is completed** (for example, a photo showing the rack or cabinet or room with readable identifiers, plus confirmation of the approved location ID). Store this evidence in the change and configuration repository so it can be traced during audits.
6. **Include placement requirements in the system security plan** and assign named roles responsible for placement decisions and information security review. Ensure the reasoning clearly links back to the PE-18 hazard categories.

###### WHO (role responsible)
- **Facilities/Infrastructure Security Lead**: owns the placement standard and the approved location catalogue.
- **Information Security (or Security Architecture) Lead**: reviews the hazard-rule mapping and the exception criteria.
- **Change Manager / Configuration Manager**: ensures the workflow is followed and evidence is retained.
- **System/Infrastructure Engineers**: carry out installations and relocations and provide the required evidence.

###### Acceptance criteria
- A current, approved **Placement Standard** exists and covers all hazard categories in **pe-18_odp**.
- Every system component has a recorded **current location** that references an **approved location ID**.
- For each installation, relocation, or upgrade, the change record includes **placement evidence** and references the applicable hazard-rule set.
- Exceptions to placement rules are rare and are documented with **risk acceptance**, **time limits**, and **compensating controls**.
- The **system security plan** includes the PE-18 placement requirements and names the responsible roles.

###### Actions Required for Compliance

- [ ] Create a hazard-based PE-18 placement standard that maps each PE-18 operational design phase (PE-18 ODP) hazard to specific, approved location rules.
- [ ] Create and keep an approved location catalogue (building, floor, room, rack, cabinet, and mounting identifiers) that records each location’s controlled-access characteristics.
- [ ] Define and publish a placement procedure for installing, moving, and upgrading systems that requires choosing an approved location.
- [ ] Assign named owners for placement decisions and for information security review, and include these responsibilities in the system security plan.
- [ ] Require change records to include proof of where the component was placed (for example, the room, rack, or cabinet identifier) and to link the component to the approved location ID.
- [ ] Set up an exceptions process for any deviations, including written approval of the risk, an expiry date, and additional compensating controls.


---

### PE-19 — Information Leakage (Control)

This requirement is about preventing sensitive information from “leaking” through hidden electrical or radio signals that could be detected outside your system. Without these protections, someone nearby could potentially capture those signals and piece together confidential information, creating a serious risk to privacy, commercial secrets, and legal compliance.

To meet this requirement, the organisation must have a documented plan for protecting both the system and the building area where it is located from signal leakage. The plan must also include clear, step-by-step procedures for how staff will control and reduce unwanted emissions. The organisation must name specific individuals who are responsible for the physical environment and for information security. It must also put in place the appropriate technical and building measures to limit emissions, and ensure these measures remain effective during installation, maintenance, and any changes.

The organisation must carry out electromagnetic emissions testing, keep the test evidence and results, and refer to them in the system’s security plan and related records.

##### EM leakage protection programme with shielding standards and test evidence

- Category: Manual
- Priority: Critical

###### WHAT
Set up and run an engineering-led programme to protect the system and its hosting site from information being leaked through electromagnetic (EM) signals. The programme must define clear, enforceable technical and site requirements (for example, shielding and containment, and installation and maintenance standards). It must also require controlled changes for anything that could affect EM signal leakage, and it must produce evidence that can be audited, including the results of EM emissions or emanation testing.

###### WHY (control requirement)
PE-19 requires the organisation to **protect the system from information leakage caused by electromagnetic (EM) signal emanations**. The guidance explains that leakage is when data or information is released into an untrusted environment through EM emanations. It also states that the protections chosen should be based on the system’s confidentiality level, organisational policy, and how much risk the organisation is willing to accept.

###### HOW (specific steps/approach)
1. **Create an EM leakage protection baseline** for each in-scope environment (for example, production, test, and disaster recovery (DR) hosting areas). This should translate the organisation’s risk tolerance and confidentiality category into practical facility and engineering requirements, including shielding and containment expectations, approved enclosures and parts, grounding and bonding expectations, rules for how cables and power are routed, and rules for openings (penetrations) and enclosure integrity.
2. **Document installation and maintenance procedures** as checklists that technicians must follow. For example: confirm covers and enclosures are in place, check the integrity of shielding and filters, confirm correct grounding and bonding, use only approved cabling and routing, and follow the required approval process for any modifications that could change EM emissions.
3. **Put change control gates in place**: require an **EM leakage impact assessment** for any hardware replacement, enclosure removal, cable rerouting, power distribution change, or hosting-site modification. Block or reverse changes that do not meet the baseline or where evidence is missing.
4. **Assign named responsibilities** within programme governance: one accountable role for **facility and environmental EM controls**, and one accountable role for **information security activities related to EM leakage**. This includes approving the baseline, making decisions at the change gates, and updating the security plan.
5. **Carry out EM emissions or emanation testing** for each in-scope system and facility configuration (or for representative configurations where equivalence is documented). Make sure testing covers the relevant operating states, and repeat testing after any approved change that could affect EM emanations.
6. **Keep an auditable evidence pack**: store test reports using unchangeable identifiers. Include what was tested, when, where and the scope, configuration details, the test method or standard used, the results, and whether it passed or failed against the agreed acceptance criteria.
7. **Update the system security plan** to clearly reference the EM leakage protection baseline, the installation and maintenance procedures, the technical measures installed, and the exact EM test report identifiers and dates (with links to supporting records).

###### WHO
- **Information Security Manager / Security Architect**: owns the governance for the EM leakage protection programme, selects the baseline based on risk, and updates the system security plan.
- **Facilities/Infrastructure Engineering Lead**: owns the facility and environmental EM control requirements, and the installation and maintenance standards.
- **Change Manager / Configuration Manager**: enforces the EM impact assessment gate within the change management process.
- **Qualified EM testing provider / internal test laboratory**: performs EM emissions or emanation testing and produces the reports.

###### Acceptance criteria
- A documented EM leakage protection baseline and installation and maintenance procedures exist and are approved by the accountable information security and facilities leads.
- Change control includes an EM leakage impact assessment gate for relevant modifications, and changes cannot be completed unless baseline requirements are met and evidence is retained.
- EM emissions or emanation testing has been completed for each in-scope configuration (or documented equivalent), and the results are kept as auditable evidence.
- The system security plan references the EM leakage programme components and includes links or identifiers to the corresponding EM test reports.
- Evidence is available for audit and remains up to date after installation, maintenance, and approved changes.

###### Actions Required for Compliance

- [ ] Define and get approval for an “email (EM) leakage” protection baseline for each in-scope hosting environment, based on the data confidentiality category and the organisation’s risk tolerance.
- [ ] Publish installation and maintenance checklists that require correct shielding and containment, correct grounding and bonding, and use of only approved cabling and power routing routes.
- [ ] Update the change management process to require an electrical magnetic (EM) leakage impact assessment and evidence to be kept for any enclosure, cabling, or power/facility modification.
- [ ] Assign named, accountable roles for facility and environmental environmental management (EM) controls, and for information security decisions related to environmental management (EM) leakage.
- [ ] Plan and carry out electromagnetic (EM) emissions and emanation testing for each in-scope configuration (or an equivalent configuration that is documented) and record permanent, unchangeable test report reference numbers.
- [ ] Update the system security plan to reference the electromagnetic (EM) leakage baseline, the related procedures, the installed protection mechanisms, and the corresponding electromagnetic (EM) test report reference numbers and dates.


---

#### PE-19.1 — National Emissions Policies and Procedures (Enhancement)

This requirement is about making sure your organisation’s equipment, the way it sends information, and the connections it uses are protected in line with UK rules (or other relevant national rules) designed to stop sensitive information leaking through unintended signals. If this is not done, confidential information could be seen by the wrong people because the physical and technical setup of systems, links, and network routes does not provide the level of protection needed for the information being handled.

To meet this expectation, the organisation must:
- identify which national leakage and emissions rules apply to each type of information, and
- apply the required protections to the relevant parts of the systems, the data routes used to move information, and the networks those systems connect to.

The organisation must also:
- document clear, step-by-step procedures for handling leakage,
- keep design and configuration records that show compliance,
- include these requirements in the system’s plan,
- assign named responsibilities, and
- check that the settings actually implemented match what the rules require.

Any exceptions must be formally recorded and limited to a defined time period.

##### EMSEC/TEMPEST category mapping to component, comms and network baselines

- Category: Software
- Priority: Critical

###### WHAT
Create and maintain an auditable record that links each information security category or classification to the applicable **national Emissions Security (EMSEC) policies and procedures** (including requirements aligned to **TEMPEST**). Use this record to decide and apply **protective measures** for:
1) **system components**, 2) **data communications**, and 3) **networks**.

###### WHY (control requirement)
PE-19(1) requires that system components, associated data communications, and networks are protected **in line with national EMSEC policies and procedures**, and that the protections chosen are based on the **security category or classification of the information**.

###### HOW (specific steps/approach)
1. **Set up an EMSEC/TEMPEST control catalogue**: for each information category or classification, define the required protections for (a) components, (b) communication links/channels/services, and (c) network connections/segments/paths. Include references to the relevant national EMSEC/TEMPEST policy sections and identify what proof (evidence) is expected.
2. **Create a category-to-baseline mapping**: use a repeatable process to map the organisation’s information classification model to the EMSEC/TEMPEST catalogue entries, producing baseline protection settings for components, communications, and networks for each category.
3. **Produce system security plan content and checklists**: automatically (or semi-automatically) generate the relevant parts of the system security plan that explain how EMSEC/TEMPEST protections are applied to components, communications, and networks for each information category the system handles.
4. **Apply configuration baselines and check for changes**: enforce the generated baselines through infrastructure and application configuration standards (for example, approved network segmentation templates, secure remote access limits, and approved cryptographic/network settings where relevant). Also run automated checks to confirm the live configuration matches the baseline for the relevant information category.
5. **Document TEMPEST-aligned leakage procedures**: keep practical, step-by-step instructions for emissions/leakage-related handling activities required by the national EMSEC/TEMPEST policies (for example, how systems are prepared/checked/changed in ways that could affect emissions). Link each procedure to the relevant catalogue entries.
6. **Manage exceptions with expiry**: if the national EMSEC/TEMPEST requirements cannot be met for a specific category/component/communication path, record the exception, the compensating measures, the person responsible for approval, and an expiry or review date. Ensure the system security plan and baseline generation include the exception.
7. **Verify and provide evidence**: collect auditable proof that the implemented protections match the catalogue requirements (for example, configuration snapshots, change records, baseline compliance reports, and any specialist leakage validation results required by the national EMSEC/TEMPEST process).

###### WHO
- **Information Security Manager / EMSEC/TEMPEST accountable owner**: maintains the catalogue, mapping rules, and exception governance.
- **System Owner / Architecture Lead**: ensures the system security plan is created or updated and that baselines are applied to the system design.
- **Infrastructure/Network Engineering**: implements and maintains the enforced baselines and change (drift) checks.
- **Compliance/Assurance (internal audit or security assurance team)**: checks that evidence is complete and that verification matches national EMSEC/TEMPEST expectations.

###### Acceptance criteria
- For each information category or classification handled by the system, there is an auditable mapping to the applicable national EMSEC/TEMPEST protections covering **components**, **data communications**, and **networks**.
- The system security plan includes the EMSEC/TEMPEST protection approach for each category and references the leakage/emissions procedures.
- Live configurations for each category match the generated baselines (or documented exceptions exist with compensating measures and expiry/review dates).
- Evidence artefacts are produced and can be traced from catalogue requirement → baseline → deployed configuration → compliance report.
- TEMPEST-aligned leakage procedures are documented as practical, actionable procedures and are linked to the relevant catalogue entries.

###### Actions Required for Compliance

- [ ] Create an EMSEC/TEMPEST control catalogue that maps each information category to the required protections for system components, communications, and networks.
- [ ] Set up a process that maps each category to its baseline, so the system automatically produces configuration baselines for each category and the corresponding sections of the system security plan.
- [ ] Build baseline security requirements into infrastructure and application configuration standards, and verify them during continuous integration and continuous delivery (CI/CD) release checks.
- [ ] Set up automated checks to confirm that the components you have deployed, their communication settings, and their network settings match the agreed baseline settings for their category.
- [ ] Publish and link procedures that are aligned with TEMPEST (a standard for limiting information leakage) and that cover how to control leakage and emissions. Make them available as clear, step-by-step instructions for the relevant change and handling activities.
- [ ] Set up an exception process that includes agreed “compensating measures” and clear end dates and review dates. Make sure any approved exceptions are included in the automatically generated baselines and in the content of the security plan.
- [ ] Collect and store verifiable records that link each information category’s catalogue requirements to the deployed system configuration and the resulting compliance reports.


---

### PE-20 — Asset Monitoring and Tracking (Control)

This requirement is about making sure important items are not lost or moved to the wrong place by using global positioning system (GPS) and radio-frequency identification (RFID) tracking. The system must automatically alert staff when tracked assets move into or out of agreed controlled areas. Without this, classified and confidential equipment, key information technology (IT) and operational technology (OT) hardware, and critical vehicles or equipment could be misplaced, accessed in unauthorised areas, or moved without anyone noticing. This would create serious safety, compliance, and operational risks.

To meet this expectation, the organisation must track and monitor the specified assets while they are inside United States Department of Defense (DoD) controlled facilities, secure rooms, and OT production floors that have access control. The system must be configured so that entry and exit events trigger alerts. The organisation must also keep written procedures, records of the system and its configuration, and an up-to-date list of which assets are being tracked, and it must keep records of tracking events.

The organisation must document this capability in its security planning, create a privacy plan to address any personal privacy impacts, and involve legal counsel where needed so privacy concerns are properly addressed.

##### GPS/RFID geofenced asset tracking with privacy-legal governance

- Category: Software
- Priority: Critical

###### WHAT must be done
Deploy and operate **asset location technologies** to **track and monitor where defined assets are and how they move** within **defined controlled areas**, using **global positioning system (GPS)** and **radio-frequency identification (RFID)** with **geofencing** so that **entry and exit events** can be detected and monitored.

###### WHY (control requirement)
The **National Institute of Standards and Technology (NIST) Privacy Enhancement (PE)-20** requirement is for the organisation to use the defined **asset location technologies** to track and monitor the location and movement of the defined **assets** within the defined **controlled areas** (parametric placeholders: pe-20_odp.01, pe-20_odp.02, pe-20_odp.03). The guidance also requires consultation with the **Office of the General Counsel** and a **senior agency official for privacy** to address potential privacy concerns.

###### HOW (specific steps/approach)
1. **Define the tracking scope and mapping**: create and keep an authoritative asset register for the defined assets (pe-20_odp.02). Assign each asset a unique identifier and link it to the tracking method (a **GPS device** and/or an **RFID tag/reader**).
2. **Implement geofenced controlled areas**: set up the defined controlled areas (pe-20_odp.03) as named geofences/zones (for example, a facility, a secure room, and operational technology (OT) production floor zones). Configure the boundaries and rules for what counts as **inside** versus **outside**.
3. **Configure tracking and alerting**: configure the tracking platform to record location and movement events and to **generate alerts when tracked assets enter or leave** geofenced zones. Make sure alerts include the asset ID, zone name, date and time, and event type.
4. **Establish operational procedures and evidence**: document how tags are commissioned or replaced, how alerts are reviewed and investigated, and how the asset list is kept up to date. Ensure the tracking capability and its operating approach are referenced in the system security planning documents.
5. **Privacy and legal oversight**: complete a privacy impact assessment/plan for using asset location technologies (especially where personal data could be inferred), and obtain documented input and approval from **legal counsel** and the **senior privacy official** as required by the guidance.
6. **Protect and retain tracking records**: keep tracking event records for an auditable period, protect them using **role-based access control (RBAC)**, and ensure only authorised roles can view or export location history.

###### WHO (role responsible)
- **Asset Tracking/OT and Infrastructure Lead**: responsible for technical deployment, geofence configuration, and managing the full lifecycle of devices/tags.
- **Information Security Officer (ISO) / Security Engineering**: ensures evidence is suitable for audit, ensures access control, and aligns work with security planning.
- **Privacy Officer + Office of the General Counsel (OGC)**: reviews and approves the privacy plan/assessments and any required mitigations.
- **Security Operations Centre (SOC)/Operations Lead**: owns the alert review (triage) process and keeps evidence of closure.

###### Acceptance criteria
- A current asset register exists for all defined assets (pe-20_odp.02), with correct mapping to GPS/RFID identifiers.
- Controlled areas (pe-20_odp.03) are implemented as geofences/zones and validated (test assets confirm correct inside/outside detection).
- Entry/exit alerts are generated for tracked assets and sent into an operational workflow, with recorded triage and closure.
- Documented procedures exist for managing the tag/device lifecycle and handling alerts, and the capability is referenced in system security planning.
- A documented privacy plan/assessment exists, with evidence that legal counsel and the senior privacy official were involved.
- Tracking event records are retained and access-controlled; audit evidence shows only authorised access.

###### Actions Required for Compliance

- [ ] Create and keep an accurate master list of the defined assets, and link each asset to its GPS (global positioning system) or RFID (radio-frequency identification) identifier.
- [ ] Set up location-based boundaries (geofences) for each defined controlled area, and check that the boundary lines are accurate by testing with test assets.
- [ ] Set up the tracking system to record and time-stamp entry and exit events when a device moves into or out of a geofence area.
- [ ] Build alert delivery into the organisation’s day-to-day operations (for example, the ticketing process or security operations centre) and require records showing that each alert has been reviewed (triaged) and either resolved or closed.
- [ ] Document the procedures for commissioning (setting up), replacing, decommissioning (removing), and handling alerts for tags and devices, and reference this capability in the system security plan.
- [ ] Complete a privacy plan and assessment for asset location technologies, and obtain documented input from legal counsel and the senior privacy officer.
- [ ] Apply role-based access control (RBAC) to tracking records and set retention rules so location and movement event history can be audited.


---

### PE-21 — Electromagnetic Pulse Protection (Control)

This requirement is about ensuring your critical equipment is physically protected against strong bursts of electromagnetic energy that could disrupt or permanently damage electronic systems. Without this protection, a sudden electromagnetic pulse could switch off systems that operate continuously, interfere with equipment used to control operations, and lead to expensive downtime or unsafe working.

To meet this expectation, the organisation must:
- identify all on-site information technology systems and operational control components that support 24/7 operations; and
- apply the correct protective measures at the specific sites where the equipment is installed or connected.

These protective measures include:
- shielding (physical barriers to reduce electromagnetic effects),
- surge protection for power and network connections,
- earthing (grounding) to safely manage electrical faults, and
- ferro-resonant transformers where they are applicable.

The organisation must document this approach in its physical and environmental protection procedures, keep clear records of what protection is in place and where, include these measures in each system’s security planning documents, and assign named responsibilities to the people responsible for physical protection, system build or integration, and ongoing oversight. The organisation must also keep evidence showing that the protections are installed and maintained over time.

##### EMP protection standard and location register for 24x7 IT/OT

- Category: Manual
- Priority: Critical

###### WHAT
Set up and put in place protection against electromagnetic pulse (EMP) damage—**shielding, surge suppressors, ferro-resonant transformers (where applicable), and earth grounding**—for **all on-premises information systems and operational technology (OT) control system components that support 24x7 operations**. Apply these measures at the **specific physical places** where the systems/components are installed or connected.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PE-21** requires the organisation to **use the agreed EMP protection measures to protect the defined system and its components** (using organisation-defined parameters **pe-21_odp.01** and **pe-21_odp.02**). The guidance also states that protection measures can include **shielding, surge suppressors, ferro-resonant transformers, and earth grounding**.

###### HOW (specific approach)
1. **Create an EMP Protection Standard** that sets the minimum acceptable measures and installation rules for:
   - **Shielding** (for example, shielded enclosures/cabinets and correct bonding/termination practices)
   - **Surge suppressors** (surge protection devices (SPDs) on power and relevant signal/network connections)
   - **Ferro-resonant transformers** **where applicable** (set the decision criteria for when they are needed)
   - **Earth grounding** (bonding/earthing requirements that match the organisation’s electrical safety/engineering standards)
2. **Create an EMP Protection Location Register** that records **site → building → room → rack/cabinet → power distribution point and interface type** (power/network/input-output (IO)) and links each to the required EMP measures.
3. **Update the security planning documents for each in-scope system** (for example, system security plan / equivalent design-security document) so they point to:
   - The relevant sections of the EMP Protection Standard, and
   - The exact entries in the EMP Protection Location Register for that system/component.
4. **Make this linkage mandatory through the change and approval process**:
   - Require EMP protection checks and sign-off when systems are installed, moved, or when power/network connection boundaries change.
   - Do not approve system security plan templates for in-scope items if they do not include the EMP sections.
5. **Assign named responsibilities** for maintaining the standard, maintaining the location register, and checking installations/changes (for example, the physical/environmental protection owner, the OT/IT integration owner, and the security governance owner).

###### WHO
- **Head of Infrastructure/OT Engineering (or equivalent)**: owns the EMP Protection Standard and engineering rules.
- **OT/IT Integration Lead / Systems Engineering**: ensures each in-scope system’s security planning document references the correct location register entries.
- **Information Security / Governance, Risk and Compliance (GRC) Lead**: ensures security planning documents are complete and that the approval process enforces the requirements.
- **Facilities/Electrical Engineering (where applicable)**: supports grounding/bonding and checks that surge protection devices (SPDs) are installed correctly.

###### Acceptance criteria
- A documented **EMP Protection Standard** exists and clearly covers **shielding, surge suppressors, ferro-resonant transformers (where applicable), and earth grounding**.
- An **EMP Protection Location Register** exists and is complete for **all on-premises information systems and OT control components supporting 24x7 operations**.
- For every in-scope system/component, the system security planning documentation **references the standard** and **the specific location register entries**.
- Change/approval records show that EMP protection checks are carried out for relevant installation/move/power-network boundary changes.
- Named roles and responsibilities are assigned for maintaining the standard, maintaining the register, and keeping it aligned with the ongoing system/component inventory.

###### Actions Required for Compliance

- [ ] Define and publish an EMP (electromagnetic pulse) protection standard that covers physical shielding, surge suppressors, ferro-resonant transformers (where applicable), and earthing (earth grounding).
- [ ] Create an environmental management plan (EMP) protection location register that maps each in-scope system or component to its exact physical installation and connection points.
- [ ] Update each in-scope system security plan to cite the EMP Standard clauses and the matching entries in the Location Register.
- [ ] Put in place a change-approval checkpoint that requires sign-off from the EMP protection team before any installations, relocations, or power and network boundary changes are carried out.
- [ ] Assign named responsibilities for maintaining the EMP standard, the Location Register, and ensuring the system security plan is linked correctly.
- [ ] Collect and keep audit evidence for all in-scope systems, including standard version records, register entries, and references to the security plan.


---

### PE-22 — Component Marking (Control)

This expectation requires that every piece of hardware that could handle sensitive information is clearly and visibly labelled with the level of sensitivity it is allowed to process. Without this, devices such as laptops, phones, printers, monitors, or scanners could be used with the wrong type of information. This increases the risk that confidential or secret material is mishandled, sent to the wrong place, or accessed by people who should not have it.

To meet this requirement, the organisation must:
- identify all hardware components connected to systems that process or store Confidential or Secret information, and
- physically mark them with clear, easy-to-read labels showing the permitted sensitivity level for processing, storing, and sending.

The labels must:
- use the organisation’s approved wording,
- be based on documented information categories,
- be included in system planning, and
- be supported by written procedures, an up-to-date device inventory, and named responsibilities.

Labels must also be checked regularly and kept readable over time.

##### Physical marking of Confidential/Secret hardware components

- Category: Manual
- Priority: Critical

###### WHAT must be done
Identify all hardware components that may be connected to systems that process or store **Confidential** and **Secret** information, and **physically mark** each component with a **clear, human-readable security label** showing the **permitted impact/classification level**.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) **PE-22 (Component Marking)** requires hardware components to be marked to show the **impact level or classification level** of the information they are allowed to process, store, or transmit. The guidance states that the security marking must be **human-readable**, and the marking should reflect the relevant policies/standards.

###### HOW (specific steps/approach)
1. **Define the approved label standard**: create a controlled document that sets the exact human-readable wording/attributes for permitted levels (for example, “CONFIDENTIAL” / “SECRET” or organisation equivalents), the label format, and where labels must be placed on common device types (laptops/tablets/phones, keyboards, monitors, printers/scanners, and so on).
2. **Create/maintain an authoritative component inventory**: ensure the asset inventory (configuration management database (CMDB)/asset management) records, for each hardware asset, the **device type** and the **connected system(s)** (or authorised use case), and the **permitted impact/classification level** taken from the system security plan.
3. **Decide which components need marking**: use the inventory information to mark components connected to systems that process/store Confidential/Secret information. Exclude only components that are clearly public-domain/publicly releasable under organisational policy.
4. **Run marking through a controlled process**: when an asset is added or redeployed, or when a system’s classification/impact level changes, create a work order that requires the correct label to be applied, followed by a quality check.
5. **Keep evidence and ensure labels are readable**: record audit evidence for each asset (for example, a photo of the label and the recorded label wording/level), and set a regular check schedule to confirm labels remain readable (including during maintenance, refurbishment, and redeployment).
6. **Assign named responsibilities**: appoint an accountable role for owning the label standard and an operational role for applying/checking labels (for example, IT Asset Management plus Infrastructure/Service Desk), with triggers for label updates when systems are reclassified.

###### WHO (role responsible)
- **Information Security Manager / Security Governance**: owns the approved label standard and the mapping to permitted impact/classification levels.
- **IT Asset Management / CMDB Owner**: maintains the authoritative inventory and ensures the connected-system mapping is correct.
- **Service Desk / Infrastructure Operations**: applies labels and completes the physical quality check.
- **System Owners**: confirm the permitted handling levels for their systems in the security plan.

###### Acceptance criteria
- Every hardware asset in the inventory that is connected to (or authorised to connect to) Confidential/Secret systems has a **physical, human-readable label** showing the correct permitted impact/classification level.
- The label wording/format matches the **approved label standard** and is applied according to the placement rules.
- Audit evidence exists for a sample of assets (photo plus recorded label level), and labels are **readable** at the time of inspection.
- When a system is reclassified or a device is redeployed, the process updates the inventory and triggers the correct label application/verification within the agreed change window.

###### Actions Required for Compliance

- [ ] Publish an approved, plain-language label standard that defines the allowed impact or classification wording, the required format, and where labels must be placed for each device type.
- [ ] Update the official asset inventory / configuration management database (CMDB) to record, for each hardware component, (1) which connected system(s) it is linked to and (2) the permitted impact or classification level.
- [ ] Identify all assets that are connected to, or authorised to connect to, Confidential or Secret systems, and flag any that need to be marked accordingly.
- [ ] Set up a controlled work-order process that automatically applies a physical label when an asset is added or redeployed, and when the system is reclassified.
- [ ] Label each identified hardware component and carry out a physical quality check to confirm the label text is correct and clearly readable.
- [ ] Keep audit evidence for each asset (for example, photos and the asset label) and carry out regular checks that labels are still readable during maintenance or refurbishment.


---

### PE-23 — Facility Location (Control)

This requirement is about making sure your organisation selects and records the exact location where a system will be housed, with a clear understanding of what could physically disrupt it. If you do not take account of hazards such as floods, fires, severe storms, earthquakes, terrorism, vandalism, and unusual electrical or electromagnetic interference, the system could be damaged, shut down, or become unreliable when you need it most.

To meet this expectation, the organisation must plan and document the facility location (and, where relevant, where within the building the system will be placed). This must be done by assessing the physical and environmental risks for that specific site, including risks related to electromagnetic effects. For systems already in place, the organisation must review the same hazards and ensure they are included in its overall risk management approach.

The organisation must also document how identified risks will be reduced, ensure contingency plans take account of hazards at the facility level, and record the location assumptions and hazard considerations in the system’s own planning documents.

##### Hazard-assessed facility location decision pack for each system

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an auditable, repeatable “facility location decision pack” for each system (and for major relocations). This pack must record the planned facility/site (and, where relevant, the room/zone) and the physical and environmental hazards considered for that specific location, including electromagnetic-related hazards.

###### WHY (control requirement)
PE-23 requires the organisation to plan and document where system components will be housed by assessing physical and environmental hazards for that specific site. It also requires electromagnetic hazards to be included (for example, EMP and electrical/electromagnetic interference). For systems already in place, the organisation must review these hazards and keep the hazard considerations up to date within risk management, mitigation, contingency planning, and system security documentation.

###### HOW (specific steps/approach)
1. **Define a standard decision-pack template** that creates a clearly identifiable record of the planned facility/site (site ID/name, address or cloud region/tenant location identifier as applicable, and room/zone if used). Include the date, system identifier, and the responsible roles.
2. **Use a mandatory hazard checklist** tailored to the facility/site. It must explicitly cover floods, fires, severe storms/tornadoes, earthquakes, hurricanes, terrorism, vandalism, and electromagnetic-related hazards (EMP exposure and sources of electrical/electromagnetic interference such as nearby high-voltage infrastructure, lightning/grounding conditions, generator switching effects, and nearby radio-frequency or industrial electromagnetic interference sources).
3. **Carry out and document the hazard assessment** for the selected site, and keep evidence (for example, site survey results, utility/engineering statements, environmental risk reports, and any facility engineering assessments).
4. **Link hazard findings to risk treatment and contingency assumptions**: for each hazard category, record the mitigation actions (including the owner, target date, and current status) and update contingency planning assumptions (for example, criteria for an alternative site, assumptions for power restoration, and triggers for incidents) so that facility-level hazard scenarios are clearly considered.
5. **Include the decision pack in system security documentation**: attach it (or reference it as an annex) from the system security plan, so that location assumptions and hazard considerations can be traced back to the system’s security planning.
6. **For existing facilities, re-check periodically** in line with the organisation’s risk review cycle (or when the facility changes) to refresh hazard assumptions and update the decision pack, risk treatment records, contingency planning, and the system security plan annex.

###### WHO (role responsible)
- **Facilities/Real Estate (Site Selection Owner):** maintains site identifiers, coordinates site surveys, and ensures the selected location is recorded.
- **Enterprise Risk / Risk Owner:** ensures hazard assessment outcomes are included in risk management and risk treatment tracking.
- **Information Security (Chief Information Security Officer (CISO)/Information Security) / System Security Owner:** ensures electromagnetic hazard coverage is complete, and that the decision pack is referenced in the system security plan.
- **Business/Application Owner:** confirms operational needs and agrees the contingency assumptions.

###### Acceptance criteria
- For each new system deployment or major relocation, there is a completed decision pack that records the planned facility/site (and room/zone where applicable) and includes all required hazard categories, explicitly including electromagnetic hazards.
- Each hazard category has traceable outcomes: at least one documented mitigation action (or a documented reason for accepting the risk) and updated contingency planning assumptions.
- The decision pack is referenced from the system security plan (as an annex or controlled reference) and can be independently audited.
- For existing systems, the decision pack has been re-validated within the defined risk review cycle (or after facility changes), with updates passed through to risk management, mitigation actions, contingency planning, and the system security plan reference.

###### Actions Required for Compliance

- [ ] Create a controlled “facility location decision pack” template with required fields for site identity, room or zone (if used), assessor, date, and references to supporting evidence.
- [ ] Create a hazard checklist that clearly includes electromagnetic pulse (EMP) and electrical or electromagnetic interference sources, alongside other physical and environmental hazards.
- [ ] Carry out and record a site-specific hazard assessment for each new system deployment or major relocation, and keep the supporting evidence.
- [ ] For each hazard finding, link it to the documented risk reduction actions (responsible person, target date, and current status). Then update the assumptions used in the contingency planning accordingly.
- [ ] Attach the decision pack to the system security plan, or reference it there, as an auditable annex.
- [ ] Schedule regular re-checks for existing systems in line with the organisation’s risk review cycle, and update the decision pack, risk response actions, contingency planning, and references in the system security plan.

